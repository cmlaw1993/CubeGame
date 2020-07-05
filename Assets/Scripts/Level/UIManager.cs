using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
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
        dailyStreak = 0;

        FindBoardAndBoundObjects();
        FindPanelTopObjects();
        FindPanelLeftObjects();
        FindPanelRightObjects();
        FindPanelStartObjects();
        FindPanelHintObjects();
        FindPanelPauseObjects();
        FindPanelPreWinObjects();
        FindPanelWinObjects();
        FindPanelStoreObjects();
        FindPanelAdObjects();
    }
    
    void Start()
    {
        /* Setup UI */

        SetupBoardAndBound();
        SetupPanelTop();
        SetupPanelLeft();
        SetupPanelRight();
        SetupPanelStart();
        SetupPanelHint();
        SetupPanelPause();
        SetupPanelPreWin();
        SetupPanelWin();
        SetupPanelStore();
        SetupPanelAd();
    }

    void LateUpdate()
    {
        if (updateBoundExit)
            UpdateBoundExit();
    }

#region BOARD_AND_BOUND

    public Sprite spriteBound_Default;
    public Sprite[] spriteBoundShadow;

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

                int shadow = 0;

                bound[i, j].GetComponent<SpriteRenderer>().sortingLayerName = "Bound";

                if (boardSize == 64) {
                    if (i == 0 || i == 9 || j == 0 || j == 9) {
                        // bound[i, j].GetComponent<BoxCollider2D>().enabled = false;
                        // bound[i, j].GetComponent<Animator>().Play("BoundNoneEnter");
                        continue;
                    }
                }

                if (levelCollection.GetBound(levelAlphabetInt, levelNumber, i, j) == Level.DATA_BOUND_BOUND) {

                    bound[i, j].GetComponent<SpriteRenderer>().sprite = spriteBound_Default;
                    bound[i, j].GetComponent<Animator>().Play("BoundBoundEnter");

                } else if (levelCollection.GetBound(levelAlphabetInt, levelNumber, i, j) == Level.DATA_BOUND_EMPTY ||
                        levelCollection.GetBound(levelAlphabetInt, levelNumber, i, j) == Level.DATA_BOUND_CUBE_RED ||
                        levelCollection.GetBound(levelAlphabetInt, levelNumber, i, j) == Level.DATA_BOUND_CUBE_GREEN ||
                        levelCollection.GetBound(levelAlphabetInt, levelNumber, i, j) == Level.DATA_BOUND_CUBE_BLUE ||
                        levelCollection.GetBound(levelAlphabetInt, levelNumber, i, j) == Level.DATA_BOUND_CUBE_YELLOW) {

                    if (i > lb && levelCollection.GetBound(levelAlphabetInt, levelNumber, i - 1, j) == 1)
                        shadow += 1;

                    if (i < hb && levelCollection.GetBound(levelAlphabetInt, levelNumber, i + 1, j) == 1)
                        shadow += 4;

                    if (j > lb && levelCollection.GetBound(levelAlphabetInt, levelNumber, i, j - 1) == 1)
                        shadow += 8;

                    if (j < hb && levelCollection.GetBound(levelAlphabetInt, levelNumber, i, j + 1) == 1)
                        shadow += 2;

                    if (i > lb && j < hb && levelCollection.GetBound(levelAlphabetInt, levelNumber, i - 1, j + 1) == Level.DATA_BOUND_BOUND &&
                            levelCollection.GetBound(levelAlphabetInt, levelNumber, i - 1, j) != Level.DATA_BOUND_BOUND &&
                            levelCollection.GetBound(levelAlphabetInt, levelNumber, i, j + 1) != Level.DATA_BOUND_BOUND)
                        shadow += 16;
                    
                    if (i < hb && j < hb && levelCollection.GetBound(levelAlphabetInt, levelNumber, i + 1, j + 1) == Level.DATA_BOUND_BOUND &&
                            levelCollection.GetBound(levelAlphabetInt, levelNumber, i + 1, j) != Level.DATA_BOUND_BOUND &&
                            levelCollection.GetBound(levelAlphabetInt, levelNumber, i, j + 1) != Level.DATA_BOUND_BOUND)
                        shadow += 32;

                    if (i < hb && j > lb && levelCollection.GetBound(levelAlphabetInt, levelNumber, i + 1, j - 1) == Level.DATA_BOUND_BOUND &&
                            levelCollection.GetBound(levelAlphabetInt, levelNumber, i + 1, j) != Level.DATA_BOUND_BOUND &&
                            levelCollection.GetBound(levelAlphabetInt, levelNumber, i, j - 1) != Level.DATA_BOUND_BOUND)
                        shadow += 64;

                    if (i > lb && j > lb && levelCollection.GetBound(levelAlphabetInt, levelNumber, i - 1, j - 1) == Level.DATA_BOUND_BOUND &&
                            levelCollection.GetBound(levelAlphabetInt, levelNumber, i - 1, j) != Level.DATA_BOUND_BOUND &&
                            levelCollection.GetBound(levelAlphabetInt, levelNumber, i, j - 1) != Level.DATA_BOUND_BOUND)
                        shadow += 128;

                    if (shadow != 0)
                        bound[i, j].GetComponent<SpriteRenderer>().sprite = spriteBoundShadow[shadow];

                    bound[i, j].GetComponent<BoxCollider2D>().enabled = false;
                    bound[i, j].GetComponent<Animator>().Play("BoundNoneEnter");
                }
            }
        }

        audioMan.PlayBoundEnterAudio();
    }

    void PlayBoundExit()
    {
        int animationIdx = 0;

        for (int i = 0; i < Level.DATA_BOUND_ROW_SIZE; i++) {
            for (int j = 0; j < Level.DATA_BOUND_COL_SIZE; j++) {

                bound[i, j].GetComponent<SpriteRenderer>().sortingLayerName = "BoundExit";

                if (levelCollection.GetBound(levelAlphabetInt, levelNumber, i, j) == Level.DATA_BOUND_BOUND) {

                    bound[i, j].GetComponent<Animator>().Play("BoundBoundExit" + animationIdx);
                    animationIdx++;
                    if (animationIdx > 2)
                        animationIdx = 0;

                } else if (levelCollection.GetBound(levelAlphabetInt, levelNumber, i, j) == Level.DATA_BOUND_EMPTY ||
                        levelCollection.GetBound(levelAlphabetInt, levelNumber, i, j) == Level.DATA_BOUND_CUBE_RED ||
                        levelCollection.GetBound(levelAlphabetInt, levelNumber, i, j) == Level.DATA_BOUND_CUBE_GREEN ||
                        levelCollection.GetBound(levelAlphabetInt, levelNumber, i, j) == Level.DATA_BOUND_CUBE_BLUE ||
                        levelCollection.GetBound(levelAlphabetInt, levelNumber, i, j) == Level.DATA_BOUND_CUBE_YELLOW) {

                    bound[i, j].GetComponent<SpriteRenderer>().sprite = null;
                }
            }
        }
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
    GameObject textTopRecord;

    GameObject panelTopCurrent;
    GameObject textTopCurrent;
    GameObject textTopTarget;

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
        textTopRecord = GameObject.Find("/UI/PanelTop/PanelRecord/Text");

        panelTopCurrent = GameObject.Find("/UI/PanelTop/PanelCurrent");
        textTopCurrent = GameObject.Find("/UI/PanelTop/PanelCurrent/TextCurrent");
        textTopTarget = GameObject.Find("/UI/PanelTop/PanelCurrent/TextTarget");
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
        SetTextTopTarget(levelCollection.Get3StarMoves(levelAlphabetInt, levelNumber));
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

    void SetTextTopTarget(int moves)
    {
        if (levelMode == LevelCollection.LEVEL_MODE_RELAX) {
            /* Nothing to do */
        } else if (levelMode == LevelCollection.LEVEL_MODE_STAR
                || levelMode == LevelCollection.LEVEL_MODE_DAILY) {
            textTopTarget.GetComponent<Text>().text = moves.ToString();
        }
    }

#endregion

#region PANEL_LEFT_RIGHT_COMMON

    const float PANEL_LR_ENTER_TIME = 0.6F;
    const float PANEL_LR_EXIT_TIME = 0.6F;

    public Sprite spriteButtonHintOn;
    public Sprite spriteButtonHintOff;
    public Sprite spriteButtonHintAd;

    /* Panel Left Right Buttons */

    public void OnButtonLRHintAdPressed()
    {
        panelStore.SetActive(true);
        textStoreHint.GetComponent<Text>().text = ":    " + keyMan.GetHintCount();
        buttonStoreHintAdsBuy.GetComponent<Button>().interactable = true;
        if (keyMan.GetAdFree() == KeyManager.AdFree.PURCHASED) {
            buttonStoreNoAds.SetActive(false);
        } else {
            buttonStoreNoAds.SetActive(true);
            buttonStoreNoAdsBuy.GetComponent<Button>().interactable = true;
        }
        buttonStoreHint5Buy.GetComponent<Button>().interactable = true;
        buttonStoreHint21Buy.GetComponent<Button>().interactable = true;
        buttonStoreHint45Buy.GetComponent<Button>().interactable = true;
        buttonStoreHint100Buy.GetComponent<Button>().interactable = true;
        buttonStoreClose.GetComponent<Button>().interactable = true;
        if (alignLeft)
            panelStoreMain.GetComponent<Animator>().Play("PanelEnterRight");
        else
            panelStoreMain.GetComponent<Animator>().Play("PanelEnterLeft");
    }

    public void OnButtonLRPausePressed()
    {
        PlayPanelPauseEnter();
    }

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

#region PANEL_RIGHT

    GameObject panelRight;

    GameObject buttonRightUndo;
    GameObject buttonRightReset;
    GameObject buttonRightHint;
    GameObject buttonRightHintAd;
    GameObject buttonRightPause;

    GameObject textRightLabelHint;

    void FindPanelRightObjects()
    {
        panelRight = GameObject.Find("/UI/PanelRight");
        
        buttonRightUndo = GameObject.Find("/UI/PanelRight/PanelButton/ButtonUndo");
        buttonRightReset = GameObject.Find("/UI/PanelRight/PanelButton/ButtonReset");
        buttonRightHint = GameObject.Find("/UI/PanelRight/PanelButton/ButtonHint");
        buttonRightHintAd = GameObject.Find("/UI/PanelRight/PanelButton/ButtonHintAd");
        buttonRightPause = GameObject.Find("/UI/PanelRight/PanelButton/ButtonPause");

        textRightLabelHint = GameObject.Find("/UI/PanelRight/PanelButton/LabelHint");
    }

    void SetupPanelRight()
    {
        /* Do not call SetPanelRightEnter() as it has audio */
        if (!alignLeft)
            panelRight.GetComponent<Animator>().Play("PanelRightEnter");

        SetButtonRightHintActive();
        SetButtonRightAllInteractable(false);
        SetButtonRightHintImage(false);
        SetTextRightLabelHint(keyMan.GetHintCount());
    }

    public void SetPanelRightEnter()
    {
        panelRight.GetComponent<Animator>().Play("PanelRightEnter");
        audioMan.PlayRLEnterAudio();
    }

    public void SetPanelRightExit()
    {
        panelRight.GetComponent<Animator>().Play("PanelRightExit");
        audioMan.PlayRLExitAudio();
    }

    public void SetButtonRightHintActive()
    {
        if (keyMan.GetHintCount() == 0) {
            buttonRightHint.SetActive(false);
            buttonRightHintAd.SetActive(true);
        } else {
            buttonRightHint.SetActive(true);
            buttonRightHintAd.SetActive(false);
        }
    }

    public void SetButtonRightAllInteractable(bool interactable)
    {
        buttonRightUndo.GetComponent<Button>().interactable = interactable;
        buttonRightReset.GetComponent<Button>().interactable = interactable;
        buttonRightPause.GetComponent<Button>().interactable = interactable;

        if (buttonRightHint.activeSelf)
            buttonRightHint.GetComponent<Button>().interactable = interactable;
        if (buttonRightHintAd.activeSelf)
            buttonRightHintAd.GetComponent<Button>().interactable = interactable;
    }

    public void SetButtonRightHintImage(bool hintOn)
    {
        if (hintOn)
            buttonRightHint.GetComponent<Image>().sprite = spriteButtonHintOn;
        else
            buttonRightHint.GetComponent<Image>().sprite = spriteButtonHintOff;
    }

    public void SetTextRightLabelHint(int num)
    {
        textRightLabelHint.GetComponent<Text>().text = "Hint(" + num.ToString() + ")";
    }

#endregion

#region PANEL_START

    const float PANEL_START_ENTER_ANIMATION_DELAY = 0.7F;

    GameObject panelStart;

    void FindPanelStartObjects()
    {
        panelStart = GameObject.Find("UI/PanelStart");
    }

    void SetupPanelStart()
    {
        panelStart.SetActive(false);
        Invoke("PlayPanelStartEnter", PANEL_START_ENTER_ANIMATION_DELAY);
    }

    void PlayPanelStartEnter()
    {
        panelStart.SetActive(true);
        panelStart.GetComponent<Animator>().Play("PanelStartEnter");
        audioMan.PlayLevelStartAudio();
    }

#endregion

#region PANEL_HINT

    GameObject panelHintOn;
    GameObject panelHintLeft;
    GameObject panelHintRight;

    void FindPanelHintObjects()
    {
        panelHintOn = GameObject.Find("UI/PanelHintOn");
        panelHintLeft = GameObject.Find("UI/PanelHintLeft");
        panelHintRight = GameObject.Find("UI/PanelHintRight");
    }

    void SetupPanelHint()
    {
        SetPanelHintOnActive(false);
        SetPanelHintLRActive(false);
    }

    public void SetPanelHintOnActive(bool active)
    {
        panelHintOn.SetActive(active);
    }

    public void PlayPanelHintOnEnter()
    {
        SetPanelHintOnActive(true);
        panelHintOn.GetComponent<Animator>().Play("PanelHintOnEnter");
        audioMan.PlayHintOnEnterAudio();
    }

    public void PlayPanelHintOnExit()
    {
        SetPanelHintOnActive(true);
        panelHintOn.GetComponent<Animator>().Play("PanelHintOnExit");
        audioMan.PlayHintOnExitAudio();
    }

    public void SetPanelHintLRActive(bool active)
    {
        if (active) {
            if (alignLeft)
                panelHintRight.SetActive(active);
            else
                panelHintLeft.SetActive(active);
        } else {
            panelHintRight.SetActive(false);
            panelHintLeft.SetActive(false);
        }
    }

    public void PlayPanelHintMoveUp()
    {
        SetPanelHintLRActive(true);

        if (alignLeft)
            panelHintRight.GetComponent<Animator>().Play("PanelHintUp");
        else
            panelHintLeft.GetComponent<Animator>().Play("PanelHintUp");
    }

    public void PlayPanelHintMoveDown()
    {
        SetPanelHintLRActive(true);

        if (alignLeft)
            panelHintRight.GetComponent<Animator>().Play("PanelHintDown");
        else
            panelHintLeft.GetComponent<Animator>().Play("PanelHintDown");
    }

    public void PlayPanelHintMoveLeft()
    {
        SetPanelHintLRActive(true);

        if (alignLeft)
            panelHintRight.GetComponent<Animator>().Play("PanelHintLeft");
        else
            panelHintLeft.GetComponent<Animator>().Play("PanelHintRight");
    }

    public void PlayPanelHintMoveRight()
    {
        SetPanelHintLRActive(true);

        if (alignLeft)
            panelHintRight.GetComponent<Animator>().Play("PanelHintRight");
        else
            panelHintLeft.GetComponent<Animator>().Play("PanelHintLeft");
    }

#endregion

#region PANEL_PAUSE

    public Sprite spriteButtonAudioOn;
    public Sprite spriteButtonAudioOff;

    public Sprite spriteButtonAlignL;
    public Sprite spriteButtonAlignR;

    GameObject panelPause;
    GameObject panelPauseMain;
    GameObject buttonPauseMenu;
    GameObject buttonPauseAlignLR;
    GameObject buttonPauseAudio;
    GameObject buttonPauseResume;

    void FindPanelPauseObjects()
    {
        panelPause = GameObject.Find("/UI/PanelPause");
        panelPauseMain = GameObject.Find("/UI/PanelPause/PanelMain");
        buttonPauseMenu = GameObject.Find("/UI/PanelPause/PanelMain/PanelButton/ButtonMenu");
        buttonPauseAlignLR = GameObject.Find("/UI/PanelPause/PanelMain/PanelButton/ButtonAlignLR");
        buttonPauseAudio = GameObject.Find("/UI/PanelPause/PanelMain/PanelButton/ButtonAudio");
        buttonPauseResume = GameObject.Find("/UI/PanelPause/PanelMain/PanelButton/ButtonResume");
    }

    void SetupPanelPause()
    {
        SetPanelPauseInteractiveFalse();
        SetPanelPauseActiveFalse();
    }

    void SetPanelPauseActiveTrue()
    {
        panelPause.SetActive(true);
    }

    void SetPanelPauseActiveFalse()
    {
        panelPause.SetActive(false);
    }

    void SetPanelPauseInteractiveTrue()
    {
        buttonPauseMenu.GetComponent<Button>().interactable = true;
        buttonPauseAlignLR.GetComponent<Button>().interactable = true;
        buttonPauseAudio.GetComponent<Button>().interactable = true;
        buttonPauseResume.GetComponent<Button>().interactable = true;
    }

    void SetPanelPauseInteractiveFalse()
    {
        buttonPauseMenu.GetComponent<Button>().interactable = false;
        buttonPauseAlignLR.GetComponent<Button>().interactable = false;
        buttonPauseAudio.GetComponent<Button>().interactable = false;
        buttonPauseResume.GetComponent<Button>().interactable = false;
    }

    void SetButtonPauseAudioImage(bool audioOn)
    {
        if (audioOn)
            buttonPauseAudio.GetComponent<Image>().sprite = spriteButtonAudioOn;
        else
            buttonPauseAudio.GetComponent<Image>().sprite = spriteButtonAudioOff;
    }

    void SetButtonPauseAlignLRImage(bool alignL)
    {
        if (alignL)
            buttonPauseAlignLR.GetComponent<Image>().sprite = spriteButtonAlignR;
        else
            buttonPauseAlignLR.GetComponent<Image>().sprite = spriteButtonAlignL;
    }

    void PlayPanelPauseEnter()
    {
        SetPanelPauseActiveTrue();
        SetButtonPauseAudioImage(audioEnable);
        SetButtonPauseAlignLRImage(alignLeft);
        panelPauseMain.GetComponent<Animator>().Play("PanelEnterMiddle");
        Invoke("SetPanelPauseInteractiveTrue", PANEL_ENTER_EXIT_ANIMATION_TIME); 
    }

    void PlayPanelPauseExit()
    {
        SetPanelPauseInteractableFalse();
        panelPauseMain.GetComponent<Animator>().Play("PanelExitMiddle");
        Invoke("SetPanelPauseActiveFalse", PANEL_ENTER_EXIT_ANIMATION_TIME);
    }

    void SetPanelPauseInteractableTrue()
    {
        buttonPauseMenu.GetComponent<Button>().interactable = true;
        buttonPauseAlignLR.GetComponent<Button>().interactable = true;
        buttonPauseAudio.GetComponent<Button>().interactable = true;
        buttonPauseResume.GetComponent<Button>().interactable = true;
    }

    void SetPanelPauseInteractableFalse()
    {
        buttonPauseMenu.GetComponent<Button>().interactable = false;
        buttonPauseAlignLR.GetComponent<Button>().interactable = false;
        buttonPauseAudio.GetComponent<Button>().interactable = false;
        buttonPauseResume.GetComponent<Button>().interactable = false;
    }

    /* Panel Pause Buttons */

    public void OnButtonPauseAlignLRPressed()
    {
        alignLeft = !alignLeft;

        SetButtonPauseAlignLRImage(alignLeft);
        SetPanelPauseInteractableFalse();

        if (alignLeft) {
            keyMan.SetAlignLR(KeyManager.AlignLR.LEFT);
            SetPanelRightExit();
            Invoke("SetPanelLeftEnter", PANEL_LR_EXIT_TIME);
        } else {
            keyMan.SetAlignLR(KeyManager.AlignLR.RIGHT);
            SetPanelLeftExit();
            Invoke("SetPanelRightEnter", PANEL_LR_EXIT_TIME);
        }

        Invoke("SetPanelPauseInteractableTrue", PANEL_LR_EXIT_TIME + PANEL_LR_ENTER_TIME);
    }

    public void OnButtonPauseAudioPressed()
    {
        audioEnable = !audioEnable;
        SetButtonPauseAudioImage(audioEnable);
    }

    public void OnButtonPauseResumePressed()
    {
        PlayPanelPauseExit();
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
    const float WIN_NEW_RECORD_PRE_ENTER_ANIMATION_TIME = 0.35F;
    const float WIN_NEW_RECORD_ENTER_ANIMATION_TIME = 1.0F;
    const float WIN_BEST_SOLUTION_PRE_ENTER_ANIMATION_TIME = 0.35F;
    const float WIN_BEST_SOLUTION_ENTER_ANIMATION_TIME = 1.0F;

    GameObject panelWin;

    GameObject textLabelLevelComplete;   
    GameObject textLabelNewRecord;
    GameObject textLabelBestSolution;
    GameObject particleConfetti;

    GameObject[] imageWinStar;
    GameObject[] imageWinStarNone;
    GameObject[] particleWinStar;

    GameObject buttonWinMenu;
    GameObject buttonWinReplay;
    GameObject buttonWinHintAd;
    GameObject buttonWinNext;

    void FindPanelWinObjects()
    {
        panelWin = GameObject.Find("/UI/PanelWin");

        textLabelLevelComplete = GameObject.Find("UI/PanelWin/PanelLabel/LabelLevelComplete");
        textLabelNewRecord = GameObject.Find("UI/PanelWin/PanelLabel/LabelNewRecord");
        textLabelBestSolution = GameObject.Find("UI/PanelWin/PanelLabel/LabelBestSolution");
        particleConfetti = GameObject.Find("UI/PanelWin/PanelLabel/ParticleConfetti");

        imageWinStar = new GameObject[Level.STAR_NUM];
        imageWinStarNone = new GameObject[Level.STAR_NUM];
        particleWinStar = new GameObject[Level.STAR_NUM];

        for (int i = 0; i < Level.STAR_NUM; i++) {
            imageWinStar[i] = GameObject.Find("/UI/PanelWin/PanelMain/PanelStar/Star" + i);
            imageWinStarNone[i] = GameObject.Find("/UI/PanelWin/PanelMain/PanelStar/StarNone" + i);
            particleWinStar[i] = GameObject.Find("/UI/PanelWin/PanelMain/PanelStar/ParticleStar" + i);
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
        SetImageWinStarActive(false);

        textLabelLevelComplete.SetActive(true);
        textLabelNewRecord.SetActive(false);
        textLabelBestSolution.SetActive(false);

        panelWin.GetComponent<Animator>().Play("PanelWinEnter");
        audioMan.PlayWinAudio();
    }

    // void SetTextWinLabelRecord(bool newRecord)
    // {
    //     if (levelMode == LevelCollection.LEVEL_MODE_STAR) {

    //         if (newRecord)
    //             textLabelRecord.GetComponent<Text>().text = "New Record!";
    //         else
    //             textLabelRecord.GetComponent<Text>().text = "Level Complete!";

    //     } else if (levelMode == LevelCollection.LEVEL_MODE_RELAX) {
    //         textLabelRecord.GetComponent<Text>().text = "Level Complete!";

    //     } else if (levelMode == LevelCollection.LEVEL_MODE_DAILY) {
    //         textLabelRecord.GetComponent<Text>().text = "Streak + " + dailyStreak;
    //     }
    // }

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
        particleWinStar[index].GetComponent<ParticleSystem>().Play();
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

    void PlayNewRecordEnter()
    {
        textLabelLevelComplete.SetActive(false);
        textLabelBestSolution.SetActive(false);

        textLabelNewRecord.SetActive(true);
        textLabelNewRecord.GetComponent<Animator>().Play("PanelWinLabelEnter");
        particleConfetti.GetComponent<ParticleSystem>().Play();
        audioMan.PlayNewRecordAudio();
    }

    void PlayBestSolutionEnter()
    {
        textLabelLevelComplete.SetActive(false);
        textLabelNewRecord.SetActive(false);

        textLabelBestSolution.SetActive(true);
        textLabelBestSolution.GetComponent<Animator>().Play("PanelWinLabelEnter");
        particleConfetti.GetComponent<ParticleSystem>().Play();
        audioMan.PlayNewRecordAudio();
    }

    public void PlayWinSequence(bool newRecord, int stars)
    {
        float animDelay = 0.0F;

        SetPanelPreWinActive(false);

        updateBoundExit = true;
        PlayBoundExit();
        audioMan.PlayBoundExitAudio();
        animDelay += BOUND_EXIT_ANIMATION_TIME;

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

            if (newRecord) {
                animDelay += WIN_NEW_RECORD_PRE_ENTER_ANIMATION_TIME;
                Invoke("PlayNewRecordEnter", animDelay);
                animDelay += WIN_NEW_RECORD_ENTER_ANIMATION_TIME;
            }

            if (stars >= 3) {
                animDelay += WIN_BEST_SOLUTION_PRE_ENTER_ANIMATION_TIME;
                Invoke("PlayBestSolutionEnter", animDelay);
                animDelay += WIN_BEST_SOLUTION_ENTER_ANIMATION_TIME;
            }
        }

        Invoke("SetPanelWinInteractableTrue", animDelay);
    }

#endregion

#region PANEL_STORE

    GameObject panelStore;
    GameObject panelStoreMain;
    GameObject textStoreHint;
    GameObject buttonStoreHintAdsBuy;
    GameObject buttonStoreNoAds;
    GameObject buttonStoreNoAdsBuy;
    GameObject buttonStoreHint5Buy;
    GameObject buttonStoreHint21Buy;
    GameObject buttonStoreHint45Buy;
    GameObject buttonStoreHint100Buy;
    GameObject buttonStoreClose;

    void FindPanelStoreObjects()
    {
        panelStore = GameObject.Find("/UI/PanelStore");
        panelStoreMain = GameObject.Find("/UI/PanelStore/PanelMain");
        textStoreHint = GameObject.Find("UI/PanelStore/PanelMain/TextHint");
        buttonStoreHintAdsBuy = GameObject.Find("/UI/PanelStore/PanelMain/ScrollView/Viewport/Content/ButtonHintAds/ButtonBuy");
        buttonStoreNoAds = GameObject.Find("/UI/PanelStore/PanelMain/ScrollView/Viewport/Content/ButtonNoAds");
        buttonStoreNoAdsBuy = GameObject.Find("/UI/PanelStore/PanelMain/ScrollView/Viewport/Content/ButtonNoAds/ButtonBuy");
        buttonStoreHint5Buy = GameObject.Find("/UI/PanelStore/PanelMain/ScrollView/Viewport/Content/ButtonHint5/ButtonBuy");
        buttonStoreHint21Buy = GameObject.Find("/UI/PanelStore/PanelMain/ScrollView/Viewport/Content/ButtonHint21/ButtonBuy");
        buttonStoreHint45Buy = GameObject.Find("/UI/PanelStore/PanelMain/ScrollView/Viewport/Content/ButtonHint45/ButtonBuy");
        buttonStoreHint100Buy = GameObject.Find("/UI/PanelStore/PanelMain/ScrollView/Viewport/Content/ButtonHint100/ButtonBuy");
        buttonStoreClose = GameObject.Find("/UI/PanelStore/PanelMain/ButtonClose");
    }

    void SetupPanelStore()
    {
        SetStoreHintCount(keyMan.GetHintCount());

        if (keyMan.GetAdFree() == KeyManager.AdFree.PURCHASED)
            buttonStoreNoAds.SetActive(false);
        
        SetPanelStoreActiveFalse();
    }

    void SetPanelStoreActiveFalse()
    {
        panelStore.SetActive(false);
    }

    public void SetStoreHintCount(int num)
    {
        textStoreHint.GetComponent<Text>().text = ":    " + num;
    }

    public void UpdatePanelStore()
    {
        if (keyMan.GetAdFree() == KeyManager.AdFree.PURCHASED)
            buttonStoreNoAds.SetActive(false);
        else
            buttonStoreNoAds.SetActive(true);

        SetStoreHintCount(keyMan.GetHintCount());
    }

    /* Panel Store Button */

    public void OnButtonStoreClosePressed()
    {
        buttonStoreHintAdsBuy.GetComponent<Button>().interactable = false;
        buttonStoreNoAdsBuy.GetComponent<Button>().interactable = false;
        buttonStoreHint5Buy.GetComponent<Button>().interactable = false;
        buttonStoreHint21Buy.GetComponent<Button>().interactable = false;
        buttonStoreHint45Buy.GetComponent<Button>().interactable = false;
        buttonStoreHint100Buy.GetComponent<Button>().interactable = false;
        buttonStoreClose.GetComponent<Button>().interactable = false;
        if (alignLeft)
            panelStoreMain.GetComponent<Animator>().Play("PanelExitRight");
        else
            panelStoreMain.GetComponent<Animator>().Play("PanelExitLeft");
        Invoke("SetPanelStoreActiveFalse", PANEL_ENTER_EXIT_ANIMATION_TIME);
    }

#endregion

#region PANEL_AD

    GameObject panelAd;

    GameObject panelAdReward;
    GameObject buttonAdRewardClose;

    GameObject panelAdConnection;
    GameObject buttonAdConnectionClose;

    public void FindPanelAdObjects()
    {
        panelAd = GameObject.Find("/UI/PanelAd");

        panelAdReward = GameObject.Find("/UI/PanelAd/PanelReward");
        buttonAdRewardClose = GameObject.Find("/UI/PanelAd/PanelReward/ButtonClose");

        panelAdConnection = GameObject.Find("/UI/PanelAd/PanelConnection");
        buttonAdConnectionClose = GameObject.Find("/UI/PanelAd/PanelConnection/ButtonClose");
    }

    void SetupPanelAd()
    {
        SetPanelAdAllActiveFalse();
    }

    public void SetPanelAdAllActiveFalse()
    {
        panelAdConnection.SetActive(false);
        panelAdReward.SetActive(false);
        panelAd.SetActive(false);
    }

    public void SetPanelAdActiveTrue()
    {
        panelAd.SetActive(true);
    }

    public void PlayPanelAdRewardEnter()
    {
        panelAd.SetActive(true);
        panelAdReward.SetActive(true);
        buttonAdRewardClose.GetComponent<Button>().interactable = true;
        panelAdReward.GetComponent<Animator>().Play("PanelEnterMiddle");
    }

    public void PlayPanelAdConnectionEnter()
    {
        panelAd.SetActive(true);
        panelAdConnection.SetActive(true);
        buttonAdConnectionClose.GetComponent<Button>().interactable = true;
        panelAdConnection.GetComponent<Animator>().Play("PanelEnterMiddle");
    }

    /* Panel Ad Buttons */

    public void OnButtonAdRewardClosePressed()
    {
        buttonAdRewardClose.GetComponent<Button>().interactable = false;
        panelAdReward.GetComponent<Animator>().Play("PanelExitMiddle");
        Invoke("SetPanelAdAllActiveFalse", PANEL_ENTER_EXIT_ANIMATION_TIME);
    }

    public void OnButtonAdConnectionClosePressed()
    {
        buttonAdConnectionClose.GetComponent<Button>().interactable = false;
        panelAdConnection.GetComponent<Animator>().Play("PanelExitMiddle");
        Invoke("SetPanelAdAllActiveFalse", PANEL_ENTER_EXIT_ANIMATION_TIME);
    }

#endregion

}
