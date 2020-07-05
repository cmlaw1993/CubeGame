//#define TEST_ENABLE

using System;
using System.Globalization;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuMainManager : MonoBehaviour
{
    KeyManager keyMan;
    AudioManager audioMan;
    AdManager adMan;
    IAPManager iapMan;
    PlayGamesManager playGamesMan;

    LevelCollection levelCollection;
    LevelAlpha levelAlpha;
    LevelBravo levelBravo;
    LevelCharlie levelCharlie;
    LevelDelta levelDelta;

    /* Mode */

    enum Mode {
        NONE,
        REWARDED_AD
    }

    Mode mode;

    /* Panel Animation */

    const float PANEL_ENTER_EXIT_ANIMATION_TIME = 0.25F;

    void Awake()
    {
        Debug.Log(">>>>>> MainMenu Scene loaded");

        /* Find Game Objects */

        keyMan = GameObject.Find("KeyManager").GetComponent<KeyManager>();
        audioMan = GameObject.Find("AudioManager").GetComponent<AudioManager>();
        adMan = GameObject.Find("AdManager").GetComponent<AdManager>();
        iapMan = GameObject.Find("IAPManager").GetComponent<IAPManager>();
        playGamesMan = GameObject.Find("PlayGamesManager").GetComponent<PlayGamesManager>();

        levelCollection = GameObject.Find("LevelCollection").GetComponent<LevelCollection>();
        levelAlpha = GameObject.Find("LevelCollection").GetComponent<LevelAlpha>();
        levelBravo = GameObject.Find("LevelCollection").GetComponent<LevelBravo>();
        levelCharlie = GameObject.Find("LevelCollection").GetComponent<LevelCharlie>();
        levelDelta = GameObject.Find("LevelCollection").GetComponent<LevelDelta>();

        FindPanelPlayObjects();
        FindPanelBottomObjects();
        FindPanelSettingsObjects();
        FindPanelCloudGoogleObjects();
        FindPanelStoreObjects();
        FindPanelAdObjects();

        /* Initialise variables */

        mode = Mode.NONE;
    }

    void Start()
    {
        /* Setup UI */

        SetupPanelPlay();
        SetupPanelSettings();
        SetupPanelCloudGoogle();
        SetupPanelStore();
        SetupPanelBottom();
        SetupPanelAd();

        /* Setup Ads */

        if (keyMan.GetAdFree() == KeyManager.AdFree.NOT_PURCHASED)
            adMan.DisplayBannerAd();
    }

    void Update()
    {
        if (mode == Mode.REWARDED_AD)
            DoModeRewardedAd();
    }

#region ADS

    void DoModeRewardedAd()
    {
        if (audioMan.IsPlaying())
            return;

        AdManager.RewardedAdStatus status = adMan.GetRewardedAdStatus();

        if (status == AdManager.RewardedAdStatus.REQUEST_SUCCESS) {
            adMan.DisplayRewardedAd();
            return;
        } else if (status == AdManager.RewardedAdStatus.DISPLAY_FAILED ||
                status == AdManager.RewardedAdStatus.REQUEST_FAILED) {
            PlayPanelAdConnectionEnter();
            adMan.DestroyRewardedAd();
            adMan.RequestRewardedAd();
            mode = Mode.NONE;
            return;
        } else if (status == AdManager.RewardedAdStatus.CLOSED) {
            if (adMan.GetRewardReceived()) {

                int newHintCount = keyMan.GetHintCount() + 1;

                keyMan.SetHintCount(newHintCount);
                SetStoreHintCount(newHintCount);
                audioMan.PlayRewardAudio();
                PlayPanelAdRewardEnter();
            } else {
                SetPanelAdAllActiveFalse();
            }
            adMan.ClearRewardReceived();
            adMan.DestroyRewardedAd();
            adMan.RequestRewardedAd();
            mode = Mode.NONE;
            return;
        } else {
            return;
        }
    }

#endregion

#region AUDIO

    public void PlayButtonAudio()
    {
        audioMan.PlayButtonAudio();
    }

    public void PlayButtonStartPressedAudio()
    {
        audioMan.PlayAudioStartPressedAudio();
    }

#endregion

#region PANEL_PLAY

    const float PANEL_PLAY_EXIT_ANIMATION_TIME = 0.60F;

    public Sprite spriteButtonPlayRedDisabled;

    GameObject panelPlay;

    GameObject buttonPlayStart;
    GameObject textPlayStart;

    GameObject buttonPlayRelaxMode;
    GameObject textPlayRelaxModeStar;

    GameObject buttonPlayStarMode;
    GameObject textPlayStarModeStar;

    GameObject buttonPlayDailyMode;
    GameObject textPlayDailyModeStreak;

    void FindPanelPlayObjects()
    {
        panelPlay = GameObject.Find("/UI/PanelPlay");

        buttonPlayStart = GameObject.Find("/UI/PanelPlay/ButtonStart");
        textPlayStart = GameObject.Find("/UI/PanelPlay/ButtonStart/Text");

        buttonPlayRelaxMode = GameObject.Find("/UI/PanelPlay/ButtonRelaxMode");
        textPlayRelaxModeStar = GameObject.Find("/UI/PanelPlay/ButtonRelaxMode/TextStar");

        buttonPlayStarMode = GameObject.Find("/UI/PanelPlay/ButtonStarMode");
        textPlayStarModeStar = GameObject.Find("/UI/PanelPlay/ButtonStarMode/TextStar");

        buttonPlayDailyMode = GameObject.Find("/UI/PanelPlay/ButtonDailyMode");
        textPlayDailyModeStreak = GameObject.Find("/UI/PanelPlay/ButtonDailyMode/TextStreak");
    }
    
    void DisablePanelPlay()
    {
        buttonPlayStart.GetComponent<Button>().interactable = false;
        buttonPlayRelaxMode.GetComponent<Button>().interactable = false;
        buttonPlayStarMode.GetComponent<Button>().interactable = false;
        buttonPlayDailyMode.GetComponent<Button>().interactable = false;
    }

    void SetupPanelPlay()
    {   
        /* Button Start */

        string lastLevelMode = keyMan.GetLevelModeLast();
        string lastLevelAlphabet = keyMan.GetLevelAlphabetLast();
        int lastLevelNumber = keyMan.GetLevelNumberLast();

        textPlayStart.GetComponent<Text>().text = lastLevelMode + " - " + lastLevelAlphabet[0] + " - " + lastLevelNumber;

        /* Button Relax and Star */

        int numLevels = levelCollection.GetNumLevelForAllAlphabets();

        for (int i = 0; i < LevelCollection.NUM_MODES - 1; i++) {   /* Level Mode */

            string mode = levelCollection.GetMode(i);

            float starsCollected = (float)keyMan.GetStarsByMode(mode);
            float starsTotal = (float)(levelCollection.GetNumStarsPerLevel(mode) * numLevels);
            int percent = (int)((starsCollected / starsTotal) * 100.0F);

            GameObject textObj;

            if (i == 0)
                textObj = textPlayRelaxModeStar;
            else
                textObj = textPlayStarModeStar;

            textObj.GetComponent<Text>().text = percent.ToString() + " %";
        }

        /* Button Daily Challenge */

        string dateToday = DateTime.Now.ToString("dd/MM/yyyy");
        string dateYesterday = DateTime.Now.AddDays(-1).ToString("dd/MM/yyyy");
        string lastDate = keyMan.GetDailyDate();

        Debug.Log("today: " + dateToday);
        Debug.Log("yesterday: " + dateYesterday);
        
        if (lastDate == dateToday) {
            buttonPlayDailyMode.GetComponent<Button>().interactable = false;
            buttonPlayDailyMode.GetComponent<Image>().sprite = spriteButtonPlayRedDisabled;
        } 

        if (lastDate == dateYesterday || lastDate == dateToday) {
            textPlayDailyModeStreak.GetComponent<Text>().text = keyMan.GetDailyStreak().ToString();
        } else {
            keyMan.SetDailyStreak(0);
            textPlayDailyModeStreak.GetComponent<Text>().text = "0";
        }

        /* Play audio */

        audioMan.PlayPanelPlayEnterAudio();
    }

    /* Panel Play Buttons */

    public void OnButtonPlayStartPressed()
    {
        DisablePanelPlay();
        DisablePanelBottom();
        panelPlay.GetComponent<Animator>().Play("PanelPlayExit");
        adMan.DestroyBannerAd();
    }

    public void OnButtonPlayRelaxPressed()
    {
        keyMan.SetLevelMode(LevelCollection.LEVEL_MODE_RELAX);
        SceneManager.LoadScene("MenuAlphabet");
    }

    public void OnButtonPlayStarPressed()
    {
        keyMan.SetLevelMode(LevelCollection.LEVEL_MODE_STAR);
        SceneManager.LoadScene("MenuAlphabet");
    }

    public void OnButtonPlayDailyPressed()
    {
        string dateToday = DateTime.Now.ToString("dd/MM/yyyy");
        
        keyMan.SetLevelMode(LevelCollection.LEVEL_MODE_DAILY);
        keyMan.SetLevelAlphabet(LevelCollection.LEVEL_ALPHABET_ALPHA);
        keyMan.SetLevelNumber(1);
        
        SceneManager.LoadScene("Level");
    }

#endregion

#region PANEL_BOTTOM

    GameObject buttonBottomSettings;
    GameObject buttonBottomHowToPlay;
    GameObject labelBottomNoAds;
    GameObject buttonBottomNoAds;
    GameObject labelBottomRate;
    GameObject buttonBottomRate;
    GameObject buttonBottomStore;
    GameObject buttonBottomCloud;

    void FindPanelBottomObjects()
    {
        buttonBottomSettings = GameObject.Find("/UI/PanelBottom/PanelButton/ButtonSettings");
        buttonBottomHowToPlay = GameObject.Find("/UI/PanelBottom/PanelButton/ButtonHowToPlay");
        labelBottomNoAds = GameObject.Find("/UI/PanelBottom/PanelButton/LabelNoAds");
        buttonBottomNoAds = GameObject.Find("/UI/PanelBottom/PanelButton/ButtonNoAds");
        labelBottomRate = GameObject.Find("/UI/PanelBottom/PanelButton/LabelRate");
        buttonBottomRate = GameObject.Find("/UI/PanelBottom/PanelButton/ButtonRate");
        buttonBottomStore = GameObject.Find("/UI/PanelBottom/PanelButton/ButtonStore");
        buttonBottomCloud = GameObject.Find("/UI/PanelBottom/PanelButton/ButtonCloud");
    }

    void SetupPanelBottom()
    {        
        UpdatePanelBottom();
    }

    public void DisablePanelBottom()
    {
        buttonBottomSettings.GetComponent<Button>().interactable = false;
        buttonBottomHowToPlay.GetComponent<Button>().interactable = false;
        buttonBottomNoAds.GetComponent<Button>().interactable = false;
        buttonBottomRate.GetComponent<Button>().interactable = false;
        buttonBottomStore.GetComponent<Button>().interactable = false;
        buttonBottomCloud.GetComponent<Button>().interactable = false;
    }

    public void UpdatePanelBottom()
    {
        if (keyMan.GetAdFree() == KeyManager.AdFree.PURCHASED) {
            labelBottomNoAds.SetActive(false);
            buttonBottomNoAds.SetActive(false);
            labelBottomRate.SetActive(true);
            buttonBottomRate.SetActive(true);
        } else {
            labelBottomNoAds.SetActive(true);
            buttonBottomNoAds.SetActive(true);
            labelBottomRate.SetActive(false);
            buttonBottomRate.SetActive(false);
        }
    }

    /* Panel Bottom Buttons */

    public void OnButtonBottomSettingsPressed()
    {
        OpenPanelSettings();
    }

    public void OnButtonBottomHowToPlayPressed()
    {
        keyMan.SetSceneAfterHowToPlay(KeyManager.SceneAfterHowToPlay.MAIN_MENU);
        SceneManager.LoadScene("HowToPlay");
        adMan.DestroyBannerAd();
    }

    public void OnButtonBottomRatePressed()
    {
        Application.OpenURL("market://details?id=com.Level27Games.PerfectSquare");
    }

    public void OnButtonBottomNoAdsPressed()
    {
        iapMan.PurchaseAdFree();
    }

    public void OnButtonBottomStorePressed()
    {
        OpenPanelStore();
    }

    public void OnButtonBottomCloudPressed()
    {
       OpenPanelCloudGoogle();
    }

#endregion

#region PANEL_SETTINGS

    public Sprite spriteSettingsAudioOn;
    public Sprite spriteSettingsAudioOff;

    public Sprite spriteSettingsAlignL;
    public Sprite spriteSettingsAlignR;

    GameObject panelSettings;
    GameObject panelSettingsMain;
    GameObject imageSettingsAudio;
    GameObject imageSettingsAlignLR;
    GameObject buttonSettingsAudioToggleL;
    GameObject buttonSettingsAudioToggleR;
    GameObject buttonSettingsAlignLRToggleL;
    GameObject buttonSettingsAlignLRToggleR;
    GameObject buttonSettingsClose;

    void FindPanelSettingsObjects()
    {
        panelSettings = GameObject.Find("/UI/PanelSettings");
        panelSettingsMain = GameObject.Find("/UI/PanelSettings/PanelMain");
        imageSettingsAudio = GameObject.Find("/UI/PanelSettings/PanelMain/PanelAudio/Image");
        imageSettingsAlignLR = GameObject.Find("/UI/PanelSettings/PanelMain/PanelAlignLR/Image");
        buttonSettingsAudioToggleL = GameObject.Find("/UI/PanelSettings/PanelMain/PanelAudio/ButtonToggleL");
        buttonSettingsAudioToggleR = GameObject.Find("/UI/PanelSettings/PanelMain/PanelAudio/ButtonToggleR");
        buttonSettingsAlignLRToggleL = GameObject.Find("/UI/PanelSettings/PanelMain/PanelAlignLR/ButtonToggleL");
        buttonSettingsAlignLRToggleR = GameObject.Find("/UI/PanelSettings/PanelMain/PanelAlignLR/ButtonToggleR");
        buttonSettingsClose = GameObject.Find("/UI/PanelSettings/PanelMain/ButtonClose");
    }

    void SetupPanelSettings()
    {
        if (keyMan.GetAudio() == KeyManager.Audio.ON)
            imageSettingsAudio.GetComponent<Image>().sprite = spriteSettingsAudioOn;
        else
            imageSettingsAudio.GetComponent<Image>().sprite = spriteSettingsAudioOff;

        if (keyMan.GetAlignLR() == KeyManager.AlignLR.LEFT)
            imageSettingsAlignLR.GetComponent<Image>().sprite = spriteSettingsAlignL;
        else
            imageSettingsAlignLR.GetComponent<Image>().sprite = spriteSettingsAlignR;

        panelSettings.SetActive(false);
    }

    void SetPanelSettingsActiveFalse()
    {
        panelSettings.SetActive(false);
    }

    void OpenPanelSettings()
    {
        panelSettings.SetActive(true);
        buttonSettingsAudioToggleL.GetComponent<Button>().interactable = true;
        buttonSettingsAudioToggleR.GetComponent<Button>().interactable = true;
        buttonSettingsAlignLRToggleL.GetComponent<Button>().interactable = true;
        buttonSettingsAlignLRToggleR.GetComponent<Button>().interactable = true;
        buttonSettingsClose.GetComponent<Button>().interactable = true;
        panelSettingsMain.GetComponent<Animator>().Play("PanelEnterLeft");
    }

    void ClosePanelSettings()
    {
        buttonSettingsAudioToggleL.GetComponent<Button>().interactable = false;
        buttonSettingsAudioToggleR.GetComponent<Button>().interactable = false;
        buttonSettingsAlignLRToggleL.GetComponent<Button>().interactable = false;
        buttonSettingsAlignLRToggleR.GetComponent<Button>().interactable = false;
        buttonSettingsClose.GetComponent<Button>().interactable = false;
        panelSettingsMain.GetComponent<Animator>().Play("PanelExitLeft");
        Invoke("SetPanelSettingsActiveFalse", PANEL_ENTER_EXIT_ANIMATION_TIME);
    }

    /* Panel Settings Button */

    public void OnButtonSettingsClosePressed()
    {
        ClosePanelSettings();
    }

    public void OnButtonSettingsAudioToggleLRPressed()
    {
        if (keyMan.GetAudio() == KeyManager.Audio.ON) {
            imageSettingsAudio.GetComponent<Image>().sprite = spriteSettingsAudioOff;
            keyMan.SetAudio(KeyManager.Audio.OFF);
        } else {
            imageSettingsAudio.GetComponent<Image>().sprite = spriteSettingsAudioOn;
            keyMan.SetAudio(KeyManager.Audio.ON);
        }

        audioMan.OnButtonAudioPressed();
        audioMan.PlayButtonAudio();
    }

    public void OnButtonSettingsAlignLRToggleLRPressed()
    {
        if (keyMan.GetAlignLR() == KeyManager.AlignLR.LEFT) {
            imageSettingsAlignLR.GetComponent<Image>().sprite = spriteSettingsAlignR;
            keyMan.SetAlignLR(KeyManager.AlignLR.RIGHT);
        } else {
            imageSettingsAlignLR.GetComponent<Image>().sprite = spriteSettingsAlignL;
            keyMan.SetAlignLR(KeyManager.AlignLR.LEFT);
        }
    }

#endregion

#region PANEL_CLOUD_GOOGLE

    GameObject panelCloudGoogle;
    GameObject panelCloudGoogleMain;
    GameObject buttonCloudGoogleSignIn;
    GameObject buttonCloudGoogleSignOut;
    GameObject buttonCloudGoogleSave;
    GameObject buttonCloudGoogleLoad;
    GameObject buttonCloudGoogleAchievements;
    GameObject buttonCloudGoogleLeaderboard;
    GameObject buttonCloudGoogleClose;

    GameObject panelCloudGoogleConnection;
    GameObject buttonCloudGoogleConnectionClose;

    void FindPanelCloudGoogleObjects()
    {
        panelCloudGoogle = GameObject.Find("/UI/PanelCloudGoogle");
        panelCloudGoogleMain = GameObject.Find("/UI/PanelCloudGoogle/PanelMain");
        buttonCloudGoogleSignIn = GameObject.Find("/UI/PanelCloudGoogle/PanelMain/ButtonSignIn");
        buttonCloudGoogleSignOut = GameObject.Find("/UI/PanelCloudGoogle/PanelMain/ButtonSignOut");
        buttonCloudGoogleSave = GameObject.Find("/UI/PanelCloudGoogle/PanelMain/ButtonSave");
        buttonCloudGoogleLoad = GameObject.Find("/UI/PanelCloudGoogle/PanelMain/ButtonLoad");
        buttonCloudGoogleAchievements = GameObject.Find("/UI/PanelCloudGoogle/PanelMain/ButtonAchievements");
        buttonCloudGoogleLeaderboard = GameObject.Find("/UI/PanelCloudGoogle/PanelMain/ButtonLeaderboard");
        buttonCloudGoogleClose = GameObject.Find("/UI/PanelCloudGoogle/PanelMain/ButtonClose");

        panelCloudGoogleConnection = GameObject.Find("/UI/PanelCloudGoogle/PanelConnection");
        buttonCloudGoogleConnectionClose = GameObject.Find("/UI/PanelCloudGoogle/PanelConnection/ButtonClose");
    }

    void SetupPanelCloudGoogle()
    {
        SetPanelCloudGoogleActiveFalse();
        SetPanelCloudGoogleConnectionActiveFalse();
    }

    void SetPanelCloudGoogleActiveFalse()
    {
        panelCloudGoogle.SetActive(false);
    }

    void SetPanelCloudGoogleConnectionActiveFalse()
    {
        panelCloudGoogleConnection.SetActive(false);
    }

    public void UpdatePanelCloudGoogle()
    {
        if (playGamesMan.IsSignedIn()) {
            buttonCloudGoogleSignIn.SetActive(false);
            buttonCloudGoogleSignIn.GetComponent<Button>().interactable = false;
            buttonCloudGoogleSignOut.SetActive(true);
            buttonCloudGoogleSignOut.GetComponent<Button>().interactable = true;
            buttonCloudGoogleSave.GetComponent<Button>().interactable = true;
            buttonCloudGoogleLoad.GetComponent<Button>().interactable = true;
            buttonCloudGoogleAchievements.GetComponent<Button>().interactable = true;
            buttonCloudGoogleLeaderboard.GetComponent<Button>().interactable = true;
        } else {
            buttonCloudGoogleSignIn.SetActive(true);
            buttonCloudGoogleSignIn.GetComponent<Button>().interactable = true;
            buttonCloudGoogleSignOut.SetActive(false);
            buttonCloudGoogleSignOut.GetComponent<Button>().interactable = false;
            buttonCloudGoogleSave.GetComponent<Button>().interactable = false;
            buttonCloudGoogleLoad.GetComponent<Button>().interactable = false;
            buttonCloudGoogleAchievements.GetComponent<Button>().interactable = false;
            buttonCloudGoogleLeaderboard.GetComponent<Button>().interactable = false;
        }
    }

    void OpenPanelCloudGoogle()
    {
        panelCloudGoogle.SetActive(true);

        UpdatePanelCloudGoogle();
        
        buttonCloudGoogleClose.GetComponent<Button>().interactable = true;

        panelCloudGoogleMain.GetComponent<Animator>().Play("PanelEnterMiddle");
    }

    void ClosePanelCloudGoogle()
    {
        buttonCloudGoogleSignIn.GetComponent<Button>().interactable = false;
        buttonCloudGoogleSignOut.GetComponent<Button>().interactable = false;
        buttonCloudGoogleSave.GetComponent<Button>().interactable = false;
        buttonCloudGoogleLoad.GetComponent<Button>().interactable = false;
        buttonCloudGoogleAchievements.GetComponent<Button>().interactable = false;
        buttonCloudGoogleLeaderboard.GetComponent<Button>().interactable = false;
        buttonCloudGoogleClose.GetComponent<Button>().interactable = false;

        panelCloudGoogleMain.GetComponent<Animator>().Play("PanelExitMiddle");
        Invoke("SetPanelCloudGoogleActiveFalse", PANEL_ENTER_EXIT_ANIMATION_TIME);
    }

    public void OpenPanelCloudGoogleConnection()
    {
        panelCloudGoogleConnection.SetActive(true);
        panelCloudGoogleConnection.GetComponent<Animator>().Play("PanelEnterMiddle");
    }

    void ClosePanelCloudGoogleConnection()
    {
        panelCloudGoogleConnection.GetComponent<Animator>().Play("PanelExitMiddle");
        Invoke("SetPanelCloudGoogleConnectionActiveFalse", PANEL_ENTER_EXIT_ANIMATION_TIME);
    }

    /* Panel Cloud Google Buttons */

    public void OnButtonCloudGoogleClosePressed()
    {
        ClosePanelCloudGoogle();
    }

    public void OnButtonCloudGoogleSignInPressed()
    {
        playGamesMan.SignInCanPromptAlways();
    }

    public void OnButtonCloudGoogleSignOutPressed()
    {
        buttonCloudGoogleSignIn.SetActive(true);
        buttonCloudGoogleSignIn.GetComponent<Button>().interactable = true;
        buttonCloudGoogleSignOut.SetActive(false);
        buttonCloudGoogleSignOut.GetComponent<Button>().interactable = false;
        buttonCloudGoogleSave.GetComponent<Button>().interactable = false;
        buttonCloudGoogleLoad.GetComponent<Button>().interactable = false;
        buttonCloudGoogleAchievements.GetComponent<Button>().interactable = false;
        buttonCloudGoogleLeaderboard.GetComponent<Button>().interactable = false;

        playGamesMan.SignOut();
    }

    public void OnButtonCloudGoogleAchievementsPressed()
    {
        playGamesMan.ShowAchievements();
    }

    public void OnButtonCloudGoogleLeaderboardPressed()
    {
        playGamesMan.ShowLeaderboard();
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
        textStoreHint = GameObject.Find("/UI/PanelStore/PanelMain/TextHint");
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

    void OpenPanelStore()
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
        panelStoreMain.GetComponent<Animator>().Play("PanelEnterRight");
    }

    void ClosePanelStore()
    {
        buttonStoreHintAdsBuy.GetComponent<Button>().interactable = false;
        buttonStoreNoAdsBuy.GetComponent<Button>().interactable = false;
        buttonStoreHint5Buy.GetComponent<Button>().interactable = false;
        buttonStoreHint21Buy.GetComponent<Button>().interactable = false;
        buttonStoreHint45Buy.GetComponent<Button>().interactable = false;
        buttonStoreHint100Buy.GetComponent<Button>().interactable = false;
        buttonStoreClose.GetComponent<Button>().interactable = false;
        panelStoreMain.GetComponent<Animator>().Play("PanelExitRight");
        Invoke("SetPanelStoreActiveFalse", PANEL_ENTER_EXIT_ANIMATION_TIME);
    }

    /* Panel Store Buttons */

    public void OnButtonStoreClosePressed()
    {
        ClosePanelStore();
    }

    public void OnButtonStoreHintAdPressed()
    {
        SetPanelAdActiveTrue();
        adMan.ClearRewardReceived();
        adMan.RequestRewardedAd();
        mode = Mode.REWARDED_AD;
    }

    public void OnButtonStoreNoAdsPressed()
    {
        iapMan.PurchaseAdFree();
    }

    public void OnButtonStoreHint5Pressed()
    {
        iapMan.PurchaseHint5();
    }

#endregion

#region PANEL_AD

    GameObject panelAd;

    GameObject panelAdReward;
    GameObject buttonAdRewardClose;

    GameObject panelAdConnection;
    GameObject buttonAdConnectionClose;

    void FindPanelAdObjects()
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
    
    void SetPanelAdAllActiveFalse()
    {
        panelAdConnection.SetActive(false);
        panelAdReward.SetActive(false);
        panelAd.SetActive(false);
    }

    void SetPanelAdActiveTrue()
    {
        panelAd.SetActive(true);
    }

    void PlayPanelAdRewardEnter()
    {
        panelAd.SetActive(true);
        panelAdReward.SetActive(true);
        buttonAdRewardClose.GetComponent<Button>().interactable = true;
        panelAdReward.GetComponent<Animator>().Play("PanelEnterMiddle");
    }

    void PlayPanelAdConnectionEnter()
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


    public void OnButtonDeletePlayerPrefs()
    {
        PlayerPrefs.DeleteAll();
    }

    public void OnButtonUnlock()
    {
        keyMan.SetAdFree(KeyManager.AdFree.PURCHASED);
        for (int i = 1; i < 51; i++)
            keyMan.SetLevelLocked("Star", "Demo", i, KeyManager.LevelLock.UNLOCKED);
        for (int i = 1; i < 51; i++)
            keyMan.SetLevelLocked("Star", "Alpha", i, KeyManager.LevelLock.UNLOCKED);
        for (int i = 1; i < 51; i++)
            keyMan.SetLevelLocked("Star", "Bravo", i, KeyManager.LevelLock.UNLOCKED);
        for (int i = 1; i < 51; i++)
            keyMan.SetLevelLocked("Star", "Charlie", i, KeyManager.LevelLock.UNLOCKED);
    }
}
