using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuLevelManager : MonoBehaviour
{
    KeyManager keyMan;
    AudioManager audioMan;
    AdManager adMan;

    LevelCollection levelCollection;
    string levelMode;
    string levelAlphabet;

    void Awake()
    {
        keyMan = GameObject.Find("KeyManager").GetComponent<KeyManager>();
        audioMan = GameObject.Find("AudioManager").GetComponent<AudioManager>();
        adMan = GameObject.Find("AdManager").GetComponent<AdManager>();

        levelCollection = GameObject.Find("LevelCollection").GetComponent<LevelCollection>();

        levelMode = keyMan.GetLevelMode();
        levelAlphabet = keyMan.GetLevelAlphabet();

        FindPanelTopObjects();
        FindPanelBottomObjects();
        FindPanelLevelObjects();
    }

    void Start()
    {
        /* Setup UI */

        SetupPanelTop();
        SetupPanelBottom();
        SetupPanelLevel();

        /* Setup Ads */

        if (keyMan.GetAdFree() == KeyManager.AdFree.NOT_PURCHASED)
            adMan.DisplayBannerAd();
    }

#region AUDIO

    public void PlayButtonAudio()
    {
        audioMan.PlayButtonAudio();
    }

#endregion

#region PANEL_TOP

    public Sprite spritePanelTopBlue;
    public Sprite spritePanelTopYellow;

    GameObject imageTopAlphabet;
    GameObject textTopAlphabet;

    GameObject textTopStarsCollected;
    GameObject textTopStarsTotal;

    void FindPanelTopObjects()
    {
        imageTopAlphabet = GameObject.Find("/UI/PanelTop/PanelAlphabet/Image");
        textTopAlphabet = GameObject.Find("/UI/PanelTop/PanelAlphabet/Text");

        textTopStarsCollected = GameObject.Find("/UI/PanelTop/PanelStar/TextCollected");
        textTopStarsTotal = GameObject.Find("/UI/PanelTop/PanelStar/TextTotal");
    }

    void SetupPanelTop()
    {
        if (levelMode == LevelCollection.LEVEL_MODE_RELAX) {
            imageTopAlphabet.GetComponent<Image>().sprite = spritePanelTopBlue;
            textTopAlphabet.GetComponent<Text>().text = levelAlphabet;
            //textTopDifficulty.GetComponent<Text>().color = new Color(0.0F, 0.0F, 0.0F, 1.0F);
        } else if (levelMode == LevelCollection.LEVEL_MODE_STAR) {
            imageTopAlphabet.GetComponent<Image>().sprite = spritePanelTopYellow;
            textTopAlphabet.GetComponent<Text>().text = levelAlphabet;
            // textTopDifficulty.GetComponent<Text>().color = new Color(0.20F, 0.14F, 0.03F, 1.0F);
        }

        int collectedStars = keyMan.GetStarsByAlphabet(levelMode, levelAlphabet);
        int totalStars = levelCollection.GetNumStarsPerLevel(levelMode)
                * levelCollection.GetNumLevelForAlphabet(levelAlphabet);

        textTopStarsCollected.GetComponent<Text>().text = collectedStars.ToString();
        textTopStarsTotal.GetComponent<Text>().text = "/" + totalStars.ToString();
    }

#endregion

#region PANEL_BOTTOM

    void FindPanelBottomObjects()
    {
        /* Nothing to do */
    }

    void SetupPanelBottom()
    {
        /* Nothing to do */
    }

    public void OnButtonBottomBackPressed()
    {
        SceneManager.LoadScene("MenuAlphabet");
    }

#endregion

#region PANEL_LEVEL

    public GameObject prefabButtonLevelN;

    public Sprite[] spriteButtonLevelStar;
    public Sprite[] spriteButtonLevelStarSingle;
    public Sprite spriteButtonLevelLocked;

    GameObject contentLevel;
    GameObject[] buttonLevelN;

    void FindPanelLevelObjects()
    {
        contentLevel = GameObject.Find("/UI/PanelLevel/ScrollView/Viewport/Content");
    }

    void SetupPanelLevel()
    {
        int numLevels = levelCollection.GetNumLevelForAlphabet(levelAlphabet);

        buttonLevelN = new GameObject[numLevels];

        for (int i = 0; i < numLevels; i++) {
            
            int lvlNum = i + 1; /* Account for index 0 */

            buttonLevelN[i] = Instantiate(prefabButtonLevelN);
            buttonLevelN[i].transform.SetParent(contentLevel.transform);
            buttonLevelN[i].transform.localScale= new Vector3(1, 1, 1);
            buttonLevelN[i].name = "ButtonLevel" + lvlNum;
            buttonLevelN[i].GetComponent<Button>().onClick.AddListener(delegate{OnButtonLevelNPressed(lvlNum);});
            buttonLevelN[i].GetComponent<Button>().onClick.AddListener(PlayButtonAudio);
            buttonLevelN[i].transform.Find("Text").GetComponent<Text>().text = lvlNum.ToString();

            if (keyMan.GetLevelLocked(levelMode, levelAlphabet, lvlNum) == KeyManager.LevelLock.LOCKED) {
                buttonLevelN[i].GetComponent<Image>().sprite = spriteButtonLevelLocked;
                buttonLevelN[i].GetComponent<Button>().interactable = false;
                buttonLevelN[i].transform.Find("Text").GetComponent<Text>().transform.position = new Vector2(0.0F, 0.1F);
            } else {
                int stars = keyMan.GetStarsByNumber(levelMode, levelAlphabet, lvlNum);

                if (levelMode == LevelCollection.LEVEL_MODE_RELAX)
                    buttonLevelN[i].GetComponent<Image>().sprite = spriteButtonLevelStarSingle[stars];
                else if (levelMode == LevelCollection.LEVEL_MODE_STAR)
                    buttonLevelN[i].GetComponent<Image>().sprite = spriteButtonLevelStar[stars];

                buttonLevelN[i].GetComponent<Button>().interactable = true;
            }
        }
    }

    public void OnButtonLevelNPressed(int levelNum)
    {
        keyMan.SetLevelNumber(levelNum);

        if (keyMan.GetHowToPlayShown() == false) {
            keyMan.SetSceneAfterHowToPlay(KeyManager.SceneAfterHowToPlay.LEVEL);
            SceneManager.LoadScene("HowToPlay");
            adMan.DestroyBannerAd();
        } else {
            SceneManager.LoadScene("Level");
            adMan.DestroyBannerAd();
        }
    }

#endregion
}
