using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GooglePlayGames;
using GooglePlayGames.BasicApi;
using UnityEngine.SocialPlatforms;

public class PlayGamesManager : MonoBehaviour
{
    static PlayGamesManager instance = null;

    static PlayGamesPlatform platform;

    void Awake()
    {
        /* Ensure that there is only a single instance of PlayGamesManager for the
           entire game */
        
        if (instance != null & instance != this) {
            Destroy(this);
            return;
        }

        instance = this;
        DontDestroyOnLoad(this);

        if (platform == null) {
            PlayGamesClientConfiguration config = new PlayGamesClientConfiguration.Builder()
                /* Enables saving game progess */
                //.EnableSavedGames()
                // .RequestServerAuthCode(false)
                .Build();

            PlayGamesPlatform.InitializeInstance(config);
            
            PlayGamesPlatform.DebugLogEnabled = true;

            platform = PlayGamesPlatform.Activate();
        }

        SignInCanPromptOnce();
        //SignIn();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

#region SIGN_IN_OUT

    public bool IsSignedIn()
    {
        Debug.Log("GGGGGG PlayGamesManager: IsSignedIn()");

        if (PlayGamesPlatform.Instance.IsAuthenticated()) {
            Debug.Log("GGGGGG PlayGamesManager: Already signed in");
            return true;
        } else {
            Debug.Log("GGGGGG PlayGamesManager: Not yet signed in");
            return false;
        }
    }

    public void SignInCanPromptOnce()
    {
        Debug.Log("GGGGGG PlayGamesManager: SignInCanPromptOnce()");

        PlayGamesPlatform.Instance.Authenticate(SignInInteractivity.CanPromptOnce, result =>
        {
            if (result == SignInStatus.Success) {
                Debug.Log("GGGGGG PlayGamesManager: SignInCanPromptOnce Success");
            } else if (result == SignInStatus.UiSignInRequired) {
                Debug.Log("GGGGGG PlayGamesManager: SignInCanPromptOnce UiSignInRequired");
            } else if (result == SignInStatus.DeveloperError) {
                Debug.Log("GGGGGG PlayGamesManager: SignInCanPromptOnce DeveloperError");
            } else if (result == SignInStatus.NetworkError) {
                Debug.Log("GGGGGG PlayGamesManager: SignInCanPromptOnce NetworkError");
            } else if (result == SignInStatus.InternalError) {
                Debug.Log("GGGGGG PlayGamesManager: SignInCanPromptOnce InternalError");
            } else if (result == SignInStatus.Canceled) {
                Debug.Log("GGGGGG PlayGamesManager: SignInCanPromptOnce Canceled");
            } else if (result == SignInStatus.AlreadyInProgress) {
                Debug.Log("GGGGGG PlayGamesManager: SignInCanPromptOnce AlreadyInProgress");
            } else if (result == SignInStatus.Failed) {
                Debug.Log("GGGGGG PlayGamesManager: SignInCanPromptOnce Failed");
            } else if (result == SignInStatus.NotAuthenticated) {
                Debug.Log("GGGGGG PlayGamesManager: SignInCanPromptOnce NotAuthenticated");
            } else {
                Debug.Log("GGGGGG PlayGamesManager: SignInCanPromptOnce Unknown code");
            }
        });
    }

    /* Note that this function should only be called by Main Menu Manager */

    public void SignInCanPromptAlways()
    {
        Debug.Log("GGGGGG PlayGamesManager: SignInCanPromptAlways()");

        PlayGamesPlatform.Instance.Authenticate(SignInInteractivity.CanPromptAlways, result =>
        {
            if (result == SignInStatus.Success) {

                Debug.Log("GGGGGG PlayGamesManager: SignInCanPromptAlways Success");
                GameObject.Find("MenuMainManager").GetComponent<MenuMainManager>().UpdatePanelCloudGoogle();

            } else {

                if (result == SignInStatus.UiSignInRequired) {
                    Debug.Log("GGGGGG PlayGamesManager: SignInCanPromptAlways UiSignInRequired");
                } else if (result == SignInStatus.DeveloperError) {
                    Debug.Log("GGGGGG PlayGamesManager: SignInCanPromptAlways DeveloperError");
                } else if (result == SignInStatus.NetworkError) {
                    Debug.Log("GGGGGG PlayGamesManager: SignInCanPromptAlways NetworkError");
                } else if (result == SignInStatus.InternalError) {
                    Debug.Log("GGGGGG PlayGamesManager: SignInCanPromptAlways InternalError");
                } else if (result == SignInStatus.Canceled) {
                    Debug.Log("GGGGGG PlayGamesManager: SignInCanPromptAlways Canceled");
                } else if (result == SignInStatus.AlreadyInProgress) {
                    Debug.Log("GGGGGG PlayGamesManager: SignInCanPromptAlways AlreadyInProgress");
                } else if (result == SignInStatus.Failed) {
                    Debug.Log("GGGGGG PlayGamesManager: SignInCanPromptAlways Failed");
                } else if (result == SignInStatus.NotAuthenticated) {
                    Debug.Log("GGGGGG PlayGamesManager: SignInCanPromptAlways NotAuthenticated");
                } else {
                    Debug.Log("GGGGGG PlayGamesManager: SignInCanPromptAlways Unknown code");
                }

                GameObject.Find("MenuMainManager").GetComponent<MenuMainManager>().OpenPanelCloudGoogleConnection();
            }
        });
    }

    void SignIn()
    {
        Social.Active.localUser.Authenticate(result =>
        {
            if (result) {
                Debug.Log("GGGGGG PlayGamesManager: Success");
            } else {
                Debug.Log("GGGGGG PlayGamesManager: Fail");
            }
        });
    }

    public void SignOut()
    {
        Debug.Log("GGGGGG PlayGamesManager: SignOut()");
        PlayGamesPlatform.Instance.SignOut();
    }

#endregion

#region ACHIEVEMENTS

    public void ShowAchievements()
    {
        Social.ShowAchievementsUI();
    }

#endregion

#region LEADERBOARD

    public void ShowLeaderboard()
    {
        Social.ShowLeaderboardUI();
    }

#endregion
}
