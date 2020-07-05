using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuAlphabetManager : MonoBehaviour
{
    KeyManager keyMan;
    AudioManager audioMan;
    AdManager adMan;

    LevelCollection levelCollection;
    LevelAlpha levelAlpha;
    LevelBravo levelBravo;
    LevelCharlie levelCharlie;
    LevelDelta levelDelta;

    string levelMode;

    void Awake()
    {
        keyMan = GameObject.Find("KeyManager").GetComponent<KeyManager>();
        audioMan = GameObject.Find("AudioManager").GetComponent<AudioManager>();
        adMan = GameObject.Find("AdManager").GetComponent<AdManager>();

        levelCollection = GameObject.Find("LevelCollection").GetComponent<LevelCollection>();
        levelAlpha = GameObject.Find("LevelCollection").GetComponent<LevelAlpha>();
        levelBravo = GameObject.Find("LevelCollection").GetComponent<LevelBravo>();
        levelCharlie = GameObject.Find("LevelCollection").GetComponent<LevelCharlie>();
        levelDelta = GameObject.Find("LevelCollection").GetComponent<LevelDelta>();

        levelMode = keyMan.GetLevelMode();

        FindPanelTopObjects();
        FindPanelBottomObjects();
        FindPanelAlphabetObjects();
    }

    void Start()
    {
        /* Setup UI */

        SetupPanelTop();
        SetupPanelBottom();
        SetupPanelAlphabet();

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

    public Sprite spriteTopBlue;
    public Sprite spriteTopYellow;

    GameObject imageTopMode;
    GameObject textTopMode;

    GameObject textTopStar;

    void FindPanelTopObjects()
    {
        imageTopMode = GameObject.Find("/UI/PanelTop/PanelMode/Image");
        textTopMode = GameObject.Find("/UI/PanelTop/PanelMode/Text");

        textTopStar = GameObject.Find("/UI/PanelTop/PanelStar/Text");
    }

    void SetupPanelTop()
    {
        if (levelMode == LevelCollection.LEVEL_MODE_RELAX) {
            imageTopMode.GetComponent<Image>().sprite = spriteTopBlue;
            textTopMode.GetComponent<Text>().text = "Relax Mode";

        } else if (levelMode == LevelCollection.LEVEL_MODE_STAR) {
            imageTopMode.GetComponent<Image>().sprite = spriteTopYellow;
            textTopMode.GetComponent<Text>().text = "Star Mode";
        }

        int totalLevels = levelCollection.GetNumLevelForAllAlphabets();

        float starsCollected = 0.0F;
        float starsTotal = 0.0F;
        int percent = 0;

        for (int i = 0; i < LevelCollection.NUM_ALPHABETS; i++) {
            string alphabet = levelCollection.GetAlphabet(i);
            starsCollected += keyMan.GetStarsByAlphabet(levelMode, alphabet);
        }

        if (levelMode == LevelCollection.LEVEL_MODE_RELAX)
            starsTotal = 1.0F * totalLevels;
        else if (levelMode == LevelCollection.LEVEL_MODE_STAR)
            starsTotal = 3.0F * totalLevels;

        percent = (int)((starsCollected / starsTotal) * 100.0F);

        textTopStar.GetComponent<Text>().text = percent.ToString() + " %";
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

    /* Panel Bottom Buttons */

    public void OnButtonBottomBackPressed()
    {
        SceneManager.LoadScene("MenuMain");
    }

#endregion

#region PANEL_ALPHABET

    public Sprite spriteAlphabetBlue;
    public Sprite spriteAlphabetYellow;
    public Sprite spriteAlphabetLocked;

    public GameObject prefabButtonAlphabetN;

    GameObject contentAlphabet;
    GameObject[] buttonAlphabetN;
    
    void FindPanelAlphabetObjects()
    {
        contentAlphabet = GameObject.Find("/UI/PanelAlphabet/ScrollView/Viewport/Content");
    }

    void SetupPanelAlphabet()
    {
        Sprite spriteNotLocked;

        if (levelMode == LevelCollection.LEVEL_MODE_RELAX)
            spriteNotLocked = spriteAlphabetBlue;
        else
            spriteNotLocked = spriteAlphabetYellow;

        buttonAlphabetN = new GameObject[LevelCollection.NUM_ALPHABETS];

        for (int i = 0; i < LevelCollection.NUM_ALPHABETS; i++) {

            string alphabet = levelCollection.GetAlphabet(i);
            int collectedStars = keyMan.GetStarsByAlphabet(levelMode, alphabet);
            int totalStars = levelCollection.GetNumStarsPerLevel(levelMode) * levelCollection.GetNumLevelForAlphabet(alphabet);
            
            buttonAlphabetN[i] = Instantiate(prefabButtonAlphabetN);
            buttonAlphabetN[i].transform.SetParent(contentAlphabet.transform);
            buttonAlphabetN[i].transform.localScale= new Vector3(1, 1, 1);
            buttonAlphabetN[i].name = "ButtonAlphabet" + alphabet;
            buttonAlphabetN[i].GetComponent<Button>().onClick.AddListener(delegate{OnButtonAlphabetNPressed(alphabet);});
            buttonAlphabetN[i].GetComponent<Button>().onClick.AddListener(PlayButtonAudio);
            buttonAlphabetN[i].transform.Find("Label").GetComponent<Text>().text = alphabet;

            if (keyMan.GetLevelLocked(levelMode, alphabet, 1) == KeyManager.LevelLock.LOCKED) {
                buttonAlphabetN[i].GetComponent<Image>().sprite = spriteAlphabetLocked;
                buttonAlphabetN[i].GetComponent<Button>().interactable = false;
                buttonAlphabetN[i].transform.Find("Text").gameObject.SetActive(false);
                buttonAlphabetN[i].transform.Find("StarL").gameObject.SetActive(false);
                buttonAlphabetN[i].transform.Find("StarR").gameObject.SetActive(false);
            } else {
                buttonAlphabetN[i].GetComponent<Image>().sprite = spriteNotLocked;
                buttonAlphabetN[i].GetComponent<Button>().interactable = true;
                buttonAlphabetN[i].transform.Find("Text").GetComponent<Text>().text
                    = collectedStars.ToString() + " / " + totalStars.ToString();
            }

            
        }
    }

    /* Panel Alphabet Buttons */

    public void OnButtonAlphabetNPressed(string alphabet)
    {
        keyMan.SetLevelAlphabet(alphabet);
        SceneManager.LoadScene("MenuLevel");
    }

#endregion
}
