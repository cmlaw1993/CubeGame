using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIManagerTest : MonoBehaviour
{
    KeyManager keyMan;
    AudioManager audioMan;

    LevelCollection levelCollection;
    string levelMode;
    string levelAlphabet;
    int levelAlphabetInt;
    int levelNumber;

    bool audioEnable;
    bool alignLeft;
    bool updateBoundExit;
    bool newRecordSet;
    int dailyStreak;

    const float PANEL_ENTER_EXIT_ANIMATION_TIME = 0.25F;

    void Awake()
    {
        keyMan = GameObject.Find("KeyManager").GetComponent<KeyManager>();
        audioMan = GameObject.Find("AudioManager").GetComponent<AudioManager>();

        levelCollection = GameObject.Find("LevelCollection").GetComponent<LevelCollection>();
        levelMode = keyMan.GetLevelMode();
        levelAlphabet = keyMan.GetLevelAlphabet();
        levelAlphabetInt = levelCollection.GetAlphabet(levelAlphabet);
        levelNumber = keyMan.GetLevelNumber();

        audioEnable = (keyMan.GetAudio() == KeyManager.Audio.ON) ? true : false;
        alignLeft = (keyMan.GetAlignLR() == KeyManager.AlignLR.LEFT) ? true : false;
        updateBoundExit = false;
        newRecordSet = false;
        dailyStreak = 0;

        FindBoardAndBoundObjects();
        FindPanelTopObjects();
        FindPanelLeftObjects();
        FindPanelHintObjects();
        FindPanelPreWinObjects();
        FindPanelWinObjects();
    }
    
    void Start()
    {
        /* Setup UI */

        SetupBoardAndBound();
        SetupPanelTop();
        SetupPanelLeft();
        SetupPanelHint();
        SetupPanelPreWin();
        SetupPanelWin();
    }

    void LateUpdate()
    {
        if (updateBoundExit)
            UpdateBoundExit();
    }

#region BOARD_AND_BOUND

    public Sprite spriteBound_Default;

    public Sprite spriteBoard64_Default;
    public Sprite spriteBoard100_Default;

    GameObject board;
    GameObject[,] bound;
    Vector2[,] boundPos;

    void FindBoardAndBoundObjects()
    {
        bound = new GameObject[Level.DATA_BOUND_ROW_SIZE, Level.DATA_BOUND_COL_SIZE];
        boundPos = new Vector2[Level.DATA_BOUND_ROW_SIZE, Level.DATA_BOUND_COL_SIZE];

        for (int i = 0; i < Level.DATA_BOUND_ROW_SIZE; i++) {
            for (int j = 0; j < Level.DATA_BOUND_COL_SIZE; j++) {
                bound[i, j] = GameObject.Find("Bound_" + i + j);
                boundPos[i, j] = bound[i, j].transform.position;
            }
        }

        board = GameObject.Find("Board");
    }

    void SetupBoardAndBound()
    {
        int boardSize = levelCollection.GetBoardSize(levelAlphabetInt, levelNumber);

        if (boardSize == 64)
            board.GetComponent<SpriteRenderer>().sprite = spriteBoard64_Default;
        else
            board.GetComponent<SpriteRenderer>().sprite = spriteBoard100_Default;

        int lb;
        int hb;

        if (boardSize == 64) {
            lb = 1;
            hb = 8;
        } else {
            lb = 0;
            hb = 9;
        }

        for (int i = 0; i < Level.DATA_BOUND_ROW_SIZE; i++) {
            for (int j = 0; j < Level.DATA_BOUND_COL_SIZE; j++) {

                if (boardSize == 64) {
                    if (i == 0 || i == 9 || j == 0 || j == 9)
                        continue;
                }

                int shadow = 0;

                bound[i, j].GetComponent<SpriteRenderer>().sortingLayerName = "Bound";

                if (levelCollection.GetBound(levelAlphabetInt, levelNumber, i, j) == Level.DATA_BOUND_BOUND) {



                    bound[i, j].GetComponent<SpriteRenderer>().sprite = spriteBound_Default;

                } else if (levelCollection.GetBound(levelAlphabetInt, levelNumber, i, j) == Level.DATA_BOUND_EMPTY ||
                        levelCollection.GetBound(levelAlphabetInt, levelNumber, i, j) == Level.DATA_BOUND_CUBE_RED ||
                        levelCollection.GetBound(levelAlphabetInt, levelNumber, i, j) == Level.DATA_BOUND_CUBE_GREEN ||
                        levelCollection.GetBound(levelAlphabetInt, levelNumber, i, j) == Level.DATA_BOUND_CUBE_BLUE ||
                        levelCollection.GetBound(levelAlphabetInt, levelNumber, i, j) == Level.DATA_BOUND_CUBE_YELLOW) {

                    bound[i, j].GetComponent<BoxCollider2D>().enabled = false;
                }
            }
        }

        audioMan.PlayBoundEnterAudio();
    }

    void PlayBoundExit()
    {
    }

    void UpdateBoundExit()
    {
        for (int i = 0; i < Level.DATA_BOUND_ROW_SIZE; i++) {
            for (int j = 0; j < Level.DATA_BOUND_COL_SIZE; j++) {
                Vector3 offset = boundPos[i, j] - boundPos[0, 0];
                bound[i, j].transform.position += offset;
            }
        }
    }

#endregion

#region PANEL_TOP

    GameObject[] imageTopStar;
    GameObject[] imageTopStarLeather;

    public Sprite imagePanelLevelRed;
    public Sprite imagePanelLevelGreen;
    public Sprite imagePanelLevelBlue;
    public Sprite imagePanelLevelYellow;

    GameObject imageTopLevel;
    GameObject textTopLevel;
    GameObject buttonTopPrev;
    GameObject buttonTopNext;

    GameObject panelTopRecord;
    GameObject panelTopCurrent;
    GameObject textTopRecord;
    GameObject textTopCurrent;

    void FindPanelTopObjects()
    {
        imageTopStar = new GameObject[Level.STAR_NUM];
        imageTopStarLeather = new GameObject[Level.STAR_NUM];
        for (int i = 0; i < Level.STAR_NUM; i++) {
            imageTopStar[i] = GameObject.Find("/UI/PanelTop/PanelStar/Star" + i);
            imageTopStarLeather[i] = GameObject.Find("/UI/PanelTop/PanelStar/StarLeather" + i);
        }

        imageTopLevel = GameObject.Find("/UI/PanelTop/PanelLevel/Image");
        textTopLevel = GameObject.Find("/UI/PanelTop/PanelLevel/Text");
        buttonTopPrev = GameObject.Find("/UI/PanelTop/PanelLevel/ButtonPrev");
        buttonTopNext = GameObject.Find("/UI/PanelTop/PanelLevel/ButtonNext");;

        panelTopRecord = GameObject.Find("/UI/PanelTop/PanelRecord");
        panelTopCurrent = GameObject.Find("/UI/PanelTop/PanelCurrent");
        textTopRecord = GameObject.Find("/UI/PanelTop/PanelRecord/Text");
        textTopCurrent = GameObject.Find("/UI/PanelTop/PanelCurrent/Text");
    }

    void SetupPanelTop()
    {
        SetImageTopStar(keyMan.GetStarsByNumber(levelMode, levelAlphabet, levelNumber));

        SetTopLevelImageAndText();

        SetButtonTopActive();
        SetButtonTopAllInteractable(false);
        
        SetPanelRecordCurrentActive();
        SetTextTopRecord(keyMan.GetLevelMoves(levelMode, levelAlphabet, levelNumber));
        SetTextTopCurrent(0);
    }

    void SetImageTopStar(int num)
    {
        if (levelMode == LevelCollection.LEVEL_MODE_RELAX) {

            imageTopStar[0].SetActive(false);
            imageTopStar[2].SetActive(false);
            imageTopStarLeather[0].SetActive(false);
            imageTopStarLeather[2].SetActive(true);
            imageTopStarLeather[2].SetActive(false);

            if (num != 1)
                imageTopStar[1].SetActive(false);
            else
                imageTopStar[1].SetActive(true);
    
        } else if (levelMode == LevelCollection.LEVEL_MODE_STAR) {

            for (int i = 0; i < num; i++)
                imageTopStar[i].SetActive(true);
            for (int i = num; i < Level.STAR_NUM; i++)
                imageTopStar[i].SetActive(false);

        } else if (levelMode == LevelCollection.LEVEL_MODE_DAILY) {

            for (int i = 0; i < Level.STAR_NUM; i++)
                imageTopStar[i].SetActive(false);
        }
    }

    void SetTopLevelImageAndText()
    {
        if (levelMode == LevelCollection.LEVEL_MODE_RELAX) {
            imageTopLevel.GetComponent<Image>().sprite = imagePanelLevelBlue;
            textTopLevel.GetComponent<Text>().text = levelAlphabet + " - " + levelNumber;
            //textTopLevel.GetComponent<Text>().color = new Color(0.75F, 0.69F, 0.6F, 1.0F);
        } else if (levelMode == LevelCollection.LEVEL_MODE_STAR) {
            imageTopLevel.GetComponent<Image>().sprite = imagePanelLevelYellow;
            textTopLevel.GetComponent<Text>().text = levelAlphabet + " - " + levelNumber;
            //textTopLevel.GetComponent<Text>().color = new Color(0.75F, 0.69F, 0.6F, 1.0F);
        } else if (levelMode == LevelCollection.LEVEL_MODE_DAILY) {
            imageTopLevel.GetComponent<Image>().sprite = imagePanelLevelRed;
            textTopLevel.GetComponent<Text>().text = "Challenge";
            //textTopLevel.GetComponent<Text>().color = new Color(0.75F, 0.69F, 0.6F, 1.0F);
        }
    }

    public void SetButtonTopActive()
    {
        if (levelMode == LevelCollection.LEVEL_MODE_RELAX) {
            buttonTopPrev.transform.localPosition = new Vector2(-140.0F, 130.0F);
            buttonTopNext.transform.localPosition = new Vector2(140.0F, 130.0F);
        } else if (levelMode == LevelCollection.LEVEL_MODE_STAR) {
            /* Nothing to do */
        } else if (levelMode == LevelCollection.LEVEL_MODE_DAILY) {
            buttonTopPrev.SetActive(false);
            buttonTopNext.SetActive(false);
        }
    }

    public void SetButtonTopAllInteractable(bool interactable)
    {
        if (levelMode == LevelCollection.LEVEL_MODE_RELAX
                || levelMode == LevelCollection.LEVEL_MODE_STAR) {

             /* ButtonTopPrev */

            if (levelNumber == 1)
                buttonTopPrev.GetComponent<Button>().interactable = false;
            else
                buttonTopPrev.GetComponent<Button>().interactable = interactable;

            /* ButtonTop Next */

            if (levelNumber == levelCollection.GetNumLevelForAlphabet(levelAlphabet))
                buttonTopNext.GetComponent<Button>().interactable = false;
            else if (keyMan.GetLevelLocked(levelMode, levelAlphabet, levelNumber + 1) == KeyManager.LevelLock.LOCKED)
                buttonTopNext.GetComponent<Button>().interactable = false;
            else
                buttonTopNext.GetComponent<Button>().interactable = interactable;

        } else if (levelMode == LevelCollection.LEVEL_MODE_DAILY) {
            buttonTopPrev.SetActive(false);
            buttonTopNext.SetActive(false);
        }
    }

    public void SetPanelRecordCurrentActive()
    {
        if (levelMode == LevelCollection.LEVEL_MODE_RELAX) {

            panelTopCurrent.SetActive(false);
            panelTopRecord.SetActive(false);
    
        } else if (levelMode == LevelCollection.LEVEL_MODE_STAR) {

            /* Nothing to do */

        } else if (levelMode == LevelCollection.LEVEL_MODE_DAILY) {

            /* Nothing to do */
        }
    }

    public void SetTextTopRecord(int moves)
    {
        if (levelMode == LevelCollection.LEVEL_MODE_RELAX) {
            /* Nothing to do */
        } else if (levelMode == LevelCollection.LEVEL_MODE_STAR) {

            if (moves == KeyManager.LEVEL_MOVES_NONE)
                textTopRecord.GetComponent<Text>().text = "-";
            else
                textTopRecord.GetComponent<Text>().text = moves.ToString();

        } else if (levelMode == LevelCollection.LEVEL_MODE_DAILY) {
            textTopRecord.GetComponent<Text>().text = "-";
        }       
    }

    public void SetTextTopCurrent(int moves)
    {
        if (levelMode == LevelCollection.LEVEL_MODE_RELAX) {
            /* Nothing to do */
        } else if (levelMode == LevelCollection.LEVEL_MODE_STAR
                || levelMode == LevelCollection.LEVEL_MODE_DAILY) {
            textTopCurrent.GetComponent<Text>().text = moves.ToString();
        }
    }

#endregion

#region PANEL_LEFT_RIGHT_COMMON

    const float PANEL_LR_ENTER_TIME = 0.6F;
    const float PANEL_LR_EXIT_TIME = 0.6F;

    public Sprite spriteButtonHintOn;
    public Sprite spriteButtonHintOff;
    public Sprite spriteButtonHintAd;

#endregion

#region PANEL_LEFT

    GameObject panelLeft;

    GameObject buttonLeftUndo;
    GameObject buttonLeftReset;
    GameObject buttonLeftHint;
    GameObject buttonLeftHintAd;
    GameObject buttonLeftPause;

    GameObject textLeftLabelHint;

    void FindPanelLeftObjects()
    {
        panelLeft = GameObject.Find("/UI/PanelLeft");

        buttonLeftUndo = GameObject.Find("/UI/PanelLeft/PanelButton/ButtonUndo");
        buttonLeftReset = GameObject.Find("/UI/PanelLeft/PanelButton/ButtonReset");
        buttonLeftHint = GameObject.Find("/UI/PanelLeft/PanelButton/ButtonHint");
        buttonLeftHintAd = GameObject.Find("/UI/PanelLeft/PanelButton/ButtonHintAd");
        buttonLeftPause = GameObject.Find("/UI/PanelLeft/PanelButton/ButtonPause");

        textLeftLabelHint = GameObject.Find("/UI/PanelLeft/PanelButton/LabelHint");
    }

    void SetupPanelLeft()
    {
        /* Do not call SetPanelLeftEnter() as it has audio. */
        if (alignLeft)
            panelLeft.GetComponent<Animator>().Play("PanelLeftEnter");

        SetButtonLeftHintActive();
        SetButtonLeftAllInteractable(false);
        SetButtonLeftHintImage(false);
        SetTextLeftLabelHint(keyMan.GetHintCount());
    }

    public void SetPanelLeftEnter()
    {
        panelLeft.GetComponent<Animator>().Play("PanelLeftEnter");
        audioMan.PlayRLEnterAudio();
    }

    public void SetPanelLeftExit()
    {
        panelLeft.GetComponent<Animator>().Play("PanelLeftExit");
        audioMan.PlayRLExitAudio();
    }

    public void SetButtonLeftHintActive()
    {
        if (keyMan.GetHintCount() == 0) {
            buttonLeftHint.SetActive(false);
            buttonLeftHintAd.SetActive(true);
        } else {
            buttonLeftHint.SetActive(true);
            buttonLeftHintAd.SetActive(false);
        }
    }

    public void SetButtonLeftAllInteractable(bool interactable)
    {
        buttonLeftUndo.GetComponent<Button>().interactable = interactable;
        buttonLeftReset.GetComponent<Button>().interactable = interactable;
        buttonLeftPause.GetComponent<Button>().interactable = interactable;

        if (buttonLeftHint.activeSelf)
            buttonLeftHint.GetComponent<Button>().interactable = interactable;
        if (buttonLeftHintAd.activeSelf)
            buttonLeftHintAd.GetComponent<Button>().interactable = interactable;
    }

    public void SetButtonLeftHintImage(bool hintOn)
    {
        if (hintOn)
            buttonLeftHint.GetComponent<Image>().sprite = spriteButtonHintOn;
        else
            buttonLeftHint.GetComponent<Image>().sprite = spriteButtonHintOff;
    }

    public void SetTextLeftLabelHint(int num)
    {
        textLeftLabelHint.GetComponent<Text>().text = "Hint(" + num.ToString() + ")";
    }

#endregion

#region PANEL_HINT

    GameObject panelHintRight;

    void FindPanelHintObjects()
    {
        panelHintRight = GameObject.Find("UI/PanelHintRight");
    }

    void SetupPanelHint()
    {
        SetPanelHintOnActive(false);
        SetPanelHintLRActive(false);
    }

    public void SetPanelHintOnActive(bool active)
    {
    }

    public void PlayPanelHintOnEnter()
    {
        SetPanelHintOnActive(true);
        audioMan.PlayHintOnEnterAudio();
    }

    public void PlayPanelHintOnExit()
    {
        SetPanelHintOnActive(true);
        audioMan.PlayHintOnExitAudio();
    }

    public void SetPanelHintLRActive(bool active)
    {
        if (active) {
            if (alignLeft)
                panelHintRight.SetActive(active);
        } else {
            panelHintRight.SetActive(false);
        }
    }

    public void PlayPanelHintMoveUp()
    {
        SetPanelHintLRActive(true);

        if (alignLeft)
            panelHintRight.GetComponent<Animator>().Play("PanelHintUp");
    }

    public void PlayPanelHintMoveDown()
    {
        SetPanelHintLRActive(true);

        if (alignLeft)
            panelHintRight.GetComponent<Animator>().Play("PanelHintDown");
    }

    public void PlayPanelHintMoveLeft()
    {
        SetPanelHintLRActive(true);

        if (alignLeft)
            panelHintRight.GetComponent<Animator>().Play("PanelHintLeft");
    }

    public void PlayPanelHintMoveRight()
    {
        SetPanelHintLRActive(true);

        if (alignLeft)
            panelHintRight.GetComponent<Animator>().Play("PanelHintRight");
    }

#endregion

#region PANEL_PRE_WIN

    GameObject panelPreWin;

    void FindPanelPreWinObjects()
    {
        panelPreWin = GameObject.Find("UI/PanelPreWin");
    }

    void SetupPanelPreWin()
    {
        SetPanelPreWinActive(false);
    }

    public void SetPanelPreWinActive(bool active)
    {
        panelPreWin.SetActive(active);
    }

    public void PlayPanelPreWinEnter()
    {
        SetPanelPreWinActive(true);
        panelPreWin.GetComponent<Animator>().Play("PanelPreWinEnter");
    }

#endregion

#region PANEL_WIN

    const float BOUND_EXIT_ANIMATION_TIME = 2.3F;
    const float PANEL_WIN_ENTER_ANIMATION_TIME = 0.7F;
    const float WIN_STAR_ENTER_ANIMATION_TIME = 0.23F;

    GameObject panelWin;

    GameObject textLabelRecord;

    GameObject[] imageWinStar;
    GameObject[] imageWinStarNone;

    GameObject buttonWinMenu;
    GameObject buttonWinReplay;
    GameObject buttonWinHintAd;
    GameObject buttonWinNext;

    void FindPanelWinObjects()
    {
        panelWin = GameObject.Find("/UI/PanelWin");

        textLabelRecord = GameObject.Find("UI/PanelWin/PanelLabel/LabelRecord");

        imageWinStar = new GameObject[Level.STAR_NUM];
        imageWinStarNone = new GameObject[Level.STAR_NUM];

        for (int i = 0; i < Level.STAR_NUM; i++) {
            imageWinStar[i] = GameObject.Find("/UI/PanelWin/PanelMain/PanelStar/Star" + i);
            imageWinStarNone[i] = GameObject.Find("/UI/PanelWin/PanelMain/PanelStar/StarNone" + i);
        }

        buttonWinMenu = GameObject.Find("/UI/PanelWin/PanelMain/PanelButton/ButtonMenu");
        buttonWinReplay = GameObject.Find("/UI/PanelWin/PanelMain/PanelButton/ButtonReplay");
        buttonWinHintAd = GameObject.Find("/UI/PanelWin/PanelMain/PanelButton/ButtonHintAd");
        buttonWinNext = GameObject.Find("/UI/PanelWin/PanelMain/PanelButton/ButtonNext");
    }

    void SetupPanelWin()
    {
        SetPanelWinInteractable(false);
        SetPanelWinActive(false);
    }

    void SetPanelWinActive(bool active)
    {
        panelWin.SetActive(active);
    }

    void SetPanelWinInteractable(bool interactable)
    {
        buttonWinMenu.GetComponent<Button>().interactable = interactable;
        buttonWinReplay.GetComponent<Button>().interactable = interactable;
        buttonWinHintAd.GetComponent<Button>().interactable = interactable;

        if (levelMode == LevelCollection.LEVEL_MODE_RELAX
                || levelMode == LevelCollection.LEVEL_MODE_STAR) {

            if (levelNumber == levelCollection.GetNumLevelForAlphabet(levelAlphabet))
                buttonWinNext.GetComponent<Button>().interactable = false;
            else
                buttonWinNext.GetComponent<Button>().interactable = interactable;

        } else if (levelMode == LevelCollection.LEVEL_MODE_DAILY) {
            buttonWinReplay.GetComponent<Button>().interactable = false;
            buttonWinNext.GetComponent<Button>().interactable = false;
        }       
    }

    void SetPanelWinInteractableTrue()
    {
        SetPanelWinInteractable(true);
    }

    void PlayPanelWinEnter()
    {
        SetPanelWinActive(true);
        SetTextWinLabelRecord(newRecordSet);
        SetImageWinStarActive(false);

        panelWin.GetComponent<Animator>().Play("PanelWinEnter");
        audioMan.PlayWinAudio();
    }

    void SetTextWinLabelRecord(bool newRecord)
    {
        if (levelMode == LevelCollection.LEVEL_MODE_STAR) {

            if (newRecord)
                textLabelRecord.GetComponent<Text>().text = "New Record!";
            else
                textLabelRecord.GetComponent<Text>().text = "Level Complete!";

        } else if (levelMode == LevelCollection.LEVEL_MODE_RELAX) {
            textLabelRecord.GetComponent<Text>().text = "Level Complete!";

        } else if (levelMode == LevelCollection.LEVEL_MODE_DAILY) {
            textLabelRecord.GetComponent<Text>().text = "Streak + " + dailyStreak;
        }
    }

    void SetImageWinStarActive(bool active)
    {
        if (levelMode == LevelCollection.LEVEL_MODE_RELAX) {

            imageWinStar[0].SetActive(false);
            imageWinStar[2].SetActive(false);
            imageWinStarNone[0].SetActive(false);
            imageWinStarNone[2].SetActive(false);

            imageWinStar[1].SetActive(active);
            imageWinStarNone[1].SetActive(active);

        } else if (levelMode == LevelCollection.LEVEL_MODE_STAR
                || levelMode == LevelCollection.LEVEL_MODE_DAILY) {

            for (int i = 0; i < Level.STAR_NUM; i++)
                imageWinStar[i].SetActive(active);
        }
    }

    void PlayImageWinStarEnter(int index)
    {
        imageTopStar[index].SetActive(true);
        imageWinStar[index].SetActive(true);
        imageWinStar[index].GetComponent<Animator>().Play("WinStar" + index + "Enter");
        audioMan.PlayStarAudio(index);
    }

    void PlayImageWinStar0Enter()
    {
        PlayImageWinStarEnter(0);
    }

    void PlayImageWinStar1Enter()
    {
        PlayImageWinStarEnter(1);
    }

    void PlayImageWinStar2Enter()
    {
        PlayImageWinStarEnter(2);
    }

    public void PlayWinSequence(bool newRecord, int stars)
    {
        float animDelay = 0.0F;

        SetPanelPreWinActive(false);

        updateBoundExit = true;
        PlayBoundExit();
        audioMan.PlayBoundExitAudio();
        animDelay += BOUND_EXIT_ANIMATION_TIME;

        newRecordSet = newRecord;
        dailyStreak = stars;
        Invoke("PlayPanelWinEnter", animDelay);
        animDelay += PANEL_WIN_ENTER_ANIMATION_TIME;

        if (levelMode == LevelCollection.LEVEL_MODE_RELAX) {

            Invoke("PlayImageWinStar1Enter", animDelay);
            animDelay += WIN_STAR_ENTER_ANIMATION_TIME;

        } else if (levelMode == LevelCollection.LEVEL_MODE_STAR
                || levelMode == LevelCollection.LEVEL_MODE_DAILY) {

            if (stars >= 1) {
                Invoke("PlayImageWinStar0Enter", animDelay);
                animDelay += WIN_STAR_ENTER_ANIMATION_TIME;
            }
            if (stars >= 2) {
                Invoke("PlayImageWinStar1Enter", animDelay);
                animDelay += WIN_STAR_ENTER_ANIMATION_TIME;
            }
            if (stars >= 3) {
                Invoke("PlayImageWinStar2Enter", animDelay);
                animDelay += WIN_STAR_ENTER_ANIMATION_TIME;
            }
        }

        Invoke("SetPanelWinInteractableTrue", animDelay);
    }

#endregion
}
