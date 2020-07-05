
#define TEST_ADMOB

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GoogleMobileAds.Api;
using GoogleMobileAds.Common;

public class AdManager : MonoBehaviour
{
#if (TEST_ADMOB)
    private string ADMOB_APP_ID = "ca-app-pub-3940256099942544~3347511713";
    private string ADMOB_ADUNIT_ID_BANNER = "ca-app-pub-3940256099942544/6300978111";
    private string ADMOB_ADUNIT_ID_INTERSTITIAL = "ca-app-pub-3940256099942544/1033173712";
    private string ADMOB_ADUNIT_ID_REWARDED = "ca-app-pub-3940256099942544/5224354917";
#else
    private string ADMOB_APP_ID = "ca-app-pub-5822654434829216~8105659187";
    private string ADMOB_ADUNIT_ID_BANNER = "ca-app-pub-5822654434829216/2853332507";
    private string ADMOB_ADUNIT_ID_INTERSTITIAL = "ca-app-pub-5822654434829216/2470189123";
    private string ADMOB_ADUNIT_ID_REWARDED = "ca-app-pub-5822654434829216/5659497233";
#endif

    static AdManager instance = null;

    void Awake()
    {
        /* Ensure that there is only a single instance of AdManager for the
           entire game */
        
        if (instance != null & instance != this) {
            Destroy(this);
            return;
        }

        instance = this;
        DontDestroyOnLoad(this);
    }

    // Start is called before the first frame update
    void Start()
    {

        MobileAds.Initialize(initStatus => { });

        RequestInterstitialAd();
        RequestRewardedAd();
    }

    // Update is called once per frame
    void Update()
    {
    }

    /* Banner Ad */

    private BannerView bannerAd = null;

    bool bannerAdRequestSuccess = false;

    void RequestBannerAd()
    {
        if (bannerAd != null) {
            if (bannerAdRequestSuccess)
                return;
            else
                bannerAd.Destroy();
        }

        bannerAd = new BannerView(ADMOB_ADUNIT_ID_BANNER, AdSize.SmartBanner, AdPosition.Bottom);

        bannerAd.OnAdLoaded += this.HandleOnBannerAdLoaded;
        bannerAd.OnAdFailedToLoad += this.HandleOnBannerAdFailedToLoad;
        bannerAd.OnAdOpening += this.HandleOnBannerAdOpened;
        bannerAd.OnAdClosed += this.HandleOnBannerAdClosed;
        bannerAd.OnAdLeavingApplication += this.HandleOnBannerAdLeavingApplication;

#if (TEST_ADMOB)
        AdRequest adRequest = new AdRequest.Builder()
            .AddTestDevice("A8CDEEBD50F31A4BE7AA22E4CDEAE677")
            .Build();
#else
        AdRequest adRequest = new AdRequest.Builder()
            .Build();
#endif

        bannerAd.LoadAd(adRequest);
    }

    void HandleOnBannerAdLoaded(object sender, EventArgs args)
    {
        Debug.Log("BannerAd loaded");
        bannerAdRequestSuccess = true;
    }

    void HandleOnBannerAdFailedToLoad(object sender, AdFailedToLoadEventArgs args)
    {
        MonoBehaviour.print("BannerAd failed to load: " + args.Message);
        bannerAdRequestSuccess = false;
    }

    void HandleOnBannerAdOpened(object sender, EventArgs args)
    {
        MonoBehaviour.print("BannerAd opened");
    }

    void HandleOnBannerAdClosed(object sender, EventArgs args)
    {
        MonoBehaviour.print("BannerAd closed");
    }

    void HandleOnBannerAdLeavingApplication(object sender, EventArgs args)
    {
        MonoBehaviour.print("BannerAd leaving application");
    }

    public void DisplayBannerAd()
    {
        RequestBannerAd();  /* Banner ads automatically shows on request */
    }

    public void DestroyBannerAd()
    {
        Debug.Log("BannerAd Destroyed");

        if (bannerAd != null) {
            bannerAd.Destroy();
            bannerAd = null;
        }

        bannerAdRequestSuccess = false;
    }

    /* Interstitial Ad */

    private InterstitialAd interstitialAd;

    public enum InterstitialAdStatus {
        NONE,
        REQUESTED,
        REQUEST_SUCCESS,
        REQUEST_FAILED,
        DISPLAYED,
        CLOSED
    };

    InterstitialAdStatus interstitialAdStatus = InterstitialAdStatus.NONE;

    public InterstitialAdStatus GetInterstitialAdStatus()
    {
        return interstitialAdStatus;
    }

    public void RequestInterstitialAd()
    {
        if (interstitialAd != null) {
            if (interstitialAdStatus == InterstitialAdStatus.REQUESTED ||
                    interstitialAdStatus == InterstitialAdStatus.REQUEST_SUCCESS)
                return;
            else
                interstitialAd.Destroy();
        }

        interstitialAd = new InterstitialAd(ADMOB_ADUNIT_ID_INTERSTITIAL);

        interstitialAd.OnAdLoaded += HandleOnInterstitialAdLoaded;
        interstitialAd.OnAdFailedToLoad += HandleOnInterstitialAdFailedToLoad;
        interstitialAd.OnAdOpening += HandleOnInterstitialAdOpened;
        interstitialAd.OnAdClosed += HandleOnInterstitialAdClosed;
        interstitialAd.OnAdLeavingApplication += HandleOnInterstitialAdLeavingApplication;

#if (TEST_ADMOB)
        AdRequest adRequest = new AdRequest.Builder()
            .AddTestDevice("A8CDEEBD50F31A4BE7AA22E4CDEAE677")
            .Build();
#else
        AdRequest adRequest = new AdRequest.Builder()
            .Build();
#endif

        interstitialAd.LoadAd(adRequest);

        interstitialAdStatus = InterstitialAdStatus.REQUESTED;
    }

    public void DisplayInterstitialAd()
    {
        if (interstitialAd.IsLoaded()) {
            interstitialAd.Show();
            interstitialAdStatus = InterstitialAdStatus.DISPLAYED;
        }
    }

    public void DestroyInterstitialAd()
    {
        if (interstitialAd != null) {
            interstitialAd.Destroy();
            interstitialAd = null;
        }

        interstitialAdStatus = InterstitialAdStatus.NONE;
    }

    void HandleOnInterstitialAdLoaded(object sender, EventArgs args)
    {
        MonoBehaviour.print("InterstitialAd Loaded");
        interstitialAdStatus = InterstitialAdStatus.REQUEST_SUCCESS;
    }

    void HandleOnInterstitialAdFailedToLoad(object sender, AdFailedToLoadEventArgs args)
    {
        MonoBehaviour.print("InterstitialAd failed to load: " + args.Message);
        interstitialAdStatus = InterstitialAdStatus.REQUEST_FAILED;
    }

    void HandleOnInterstitialAdOpened(object sender, EventArgs args)
    {
        MonoBehaviour.print("InterstitialAd opened");
    }

    void HandleOnInterstitialAdClosed(object sender, EventArgs args)
    {
        MonoBehaviour.print("InterstitialAd closed");
        interstitialAdStatus = InterstitialAdStatus.CLOSED;
    }

    void HandleOnInterstitialAdLeavingApplication(object sender, EventArgs args)
    {
        MonoBehaviour.print("InterstitialAd leaving application");
    }

    /* Rewarded Video Ad */

    private RewardedAd rewardedAd;

    public enum RewardedAdStatus {
        NONE,
        REQUESTED,
        REQUEST_SUCCESS,
        REQUEST_FAILED,
        DISPLAYED,
        DISPLAY_FAILED,
        CLOSED
    };

    RewardedAdStatus rewardedAdStatus = RewardedAdStatus.NONE;
    bool rewardReceived = false;

    public RewardedAdStatus GetRewardedAdStatus()
    {
        return rewardedAdStatus;
    }

    public void ClearRewardReceived()
    {
        rewardReceived = false;
    }

    public bool GetRewardReceived()
    {
        return rewardReceived;
    }

    public void RequestRewardedAd()
    {
        if (rewardedAd != null) {
            if (rewardedAdStatus == RewardedAdStatus.REQUESTED ||
                    rewardedAdStatus == RewardedAdStatus.REQUEST_SUCCESS)
                return;
        }

        rewardedAd = new RewardedAd(ADMOB_ADUNIT_ID_REWARDED);

        rewardedAd.OnAdLoaded += HandleRewardedAdLoaded;
        rewardedAd.OnAdFailedToLoad += HandleRewardedAdFailedToLoad;
        rewardedAd.OnAdOpening += HandleRewardedAdOpening;
        rewardedAd.OnAdFailedToShow += HandleRewardedAdFailedToShow;
        rewardedAd.OnUserEarnedReward += HandleUserEarnedReward;
        rewardedAd.OnAdClosed += HandleRewardedAdClosed;

#if (TEST_ADMOB)
        AdRequest adRequest = new AdRequest.Builder()
            .AddTestDevice("A8CDEEBD50F31A4BE7AA22E4CDEAE677")
            .Build();
#else
        AdRequest adRequest = new AdRequest.Builder()
            .Build();
#endif

        rewardedAd.LoadAd(adRequest);

        rewardedAdStatus = RewardedAdStatus.REQUESTED;
    }

    public void DisplayRewardedAd()
    {
        if (rewardedAd.IsLoaded()) {
            rewardedAd.Show();
            rewardedAdStatus = RewardedAdStatus.DISPLAYED;
        }
    }

    public void DestroyRewardedAd()
    {
        rewardedAd = null;
        rewardedAdStatus = RewardedAdStatus.NONE;
    }

    void HandleRewardedAdLoaded(object sender, EventArgs args)
    {
        MonoBehaviour.print("RewardedAd loaded");
        rewardedAdStatus = RewardedAdStatus.REQUEST_SUCCESS;
    }

    void HandleRewardedAdFailedToLoad(object sender, AdErrorEventArgs args)
    {
        MonoBehaviour.print("RewardedAd failed to load: " + args.Message);
        rewardedAdStatus = RewardedAdStatus.REQUEST_FAILED;
    }

    void HandleRewardedAdOpening(object sender, EventArgs args)
    {
        MonoBehaviour.print("RewardedAd opening");
    }

    void HandleRewardedAdFailedToShow(object sender, AdErrorEventArgs args)
    {
        MonoBehaviour.print("RewardedAd failed to show: " + args.Message);
        rewardedAdStatus = RewardedAdStatus.DISPLAY_FAILED;
    }

    void HandleRewardedAdClosed(object sender, EventArgs args)
    {
        MonoBehaviour.print("RewardedAd closed");
        rewardedAdStatus = RewardedAdStatus.CLOSED;
    }

    void HandleUserEarnedReward(object sender, Reward args)
    {
        string type = args.Type;
        double amount = args.Amount;
        MonoBehaviour.print("RewardedAd user earned reward" + amount.ToString() + " " + type);
        rewardReceived = true;
    }
}
