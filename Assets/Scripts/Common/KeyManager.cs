
//#define TEST_DELETE_PLAYER_PREFS
#define TEST_LEVEL
//#define TEST_AUDIO
// #define TEST_ALIGNLR
#define TEST_HINT_COUNT
//#define TEST_LEVEL_MOVES
//#define TEST_LEVEL_STARS
//#define TEST_HOW_TO_PLAY_SHOWN

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class KeyManager : MonoBehaviour
{
    const string test_level_mode = LevelCollection.LEVEL_MODE_STAR;
    const string test_level_alphabet = LevelCollection.LEVEL_ALPHABET_ALPHA;
    const int test_level_number = 1;
    const KeyManager.Audio test_audio = KeyManager.Audio.OFF;
    const KeyManager.AlignLR test_alignlr = KeyManager.AlignLR.LEFT;
    const int test_hint_count = 99;
    const int test_level_moves = 0;
    const int test_level_stars = 3;
    const bool test_how_to_play_shown = false;

    static KeyManager instance = null;

    static bool doOnce = false;

    void Awake()
    {
        /* Ensure that there is only a single instance of KeyManager for the
           entire game */
        
        if (instance != null & instance != this) {
            Destroy(this);
            return;
        }

        instance = this;
        DontDestroyOnLoad(this);

#if (TEST_DELETE_PLAYER_PREFS)
        PlayerPrefs.DeleteAll();
#endif

#if (TEST_LEVEL)
        SetLevelMode(test_level_mode);
        SetLevelAlphabet(test_level_alphabet);
        SetLevelNumber(test_level_number);
#endif

#if (TEST_AUDIO)
        SetAudio(test_audio);
#endif

#if (TEST_ALIGNLR)
        SetAlignLR(test_alignlr);
#endif

#if (TEST_HINT_COUNT)
        SetHintCount(test_hint_count);
#endif

#if (TEST_LEVEL_MOVES)
        SetLevelMoves(test_level_moves);
#endif

#if (TEST_LEVEL_STARS)
        SetLevelStars(test_level_difficulty, test_level_number, test_level_stars);
#endif

#if (TEST_HOW_TO_PLAY_SHOWN)
        SetHowToPlayShown(test_how_to_play_shown);
#endif
    }

    void Start()
    {
        /* Update StarsByMode and StarsByAlphabet */

        if (doOnce)
            return;

        LevelCollection levelCollection = GameObject.Find("LevelCollection").GetComponent<LevelCollection>();

        for (int i = 0; i < LevelCollection.NUM_MODES - 1; i ++) {

            string mode = levelCollection.GetMode(i);

            int collectedStarsMode = 0;

            for (int j = 0; j < LevelCollection.NUM_ALPHABETS; j++) {

                string alphabet = levelCollection.GetAlphabet(j);
                int numLevels = levelCollection.GetNumLevelForAlphabet(alphabet);
                int collectedStarsAlphabet = 0;

                for (int k = 0; k < numLevels; k++)
                    collectedStarsAlphabet += this.GetStarsByNumber(mode, alphabet, k + 1);

                this.SetStarsByAlphabet(mode, alphabet, collectedStarsAlphabet);

                collectedStarsMode += collectedStarsAlphabet;
            }

            this.SetStarsByMode(mode, collectedStarsMode);
        }

        doOnce = true;
    }

    /* Scene Transition */

#region HOW_TO_PLAY_SHOWN

const string HOW_TO_PLAY_SHOWN_KEY = "HTPShown";

    public bool GetHowToPlayShown()
    {
        if (PlayerPrefs.HasKey(HOW_TO_PLAY_SHOWN_KEY)) {
            if (PlayerPrefs.GetInt(HOW_TO_PLAY_SHOWN_KEY) == 0)
                return false;
            else
                return true;
        } else {
            PlayerPrefs.SetInt(HOW_TO_PLAY_SHOWN_KEY, 0);
            return false;
        }
    }

    public void SetHowToPlayShown(bool val)
    {
        if (val)
            PlayerPrefs.SetInt(HOW_TO_PLAY_SHOWN_KEY, 1);
        else
            PlayerPrefs.SetInt(HOW_TO_PLAY_SHOWN_KEY, 0);
    }

#endregion

#region SCENE_AFTER_HOW_TO_PLAY

    const string SCENE_AFTER_HTP_KEY = "SceneAfterHTP";

    public enum SceneAfterHowToPlay {
        MAIN_MENU = 0,
        LEVEL = 1
    }

    public SceneAfterHowToPlay GetSceneAfterHowToPlay()
    {
        if (PlayerPrefs.HasKey(SCENE_AFTER_HTP_KEY)) {
            if (PlayerPrefs.GetInt(SCENE_AFTER_HTP_KEY) == (int)SceneAfterHowToPlay.MAIN_MENU)
                return SceneAfterHowToPlay.MAIN_MENU;
            else
                return SceneAfterHowToPlay.LEVEL;
        } else {
            PlayerPrefs.SetInt(SCENE_AFTER_HTP_KEY, (int)SceneAfterHowToPlay.MAIN_MENU);
            return SceneAfterHowToPlay.MAIN_MENU;
        }
    }

    public void SetSceneAfterHowToPlay(SceneAfterHowToPlay val)
    {
        PlayerPrefs.SetInt(SCENE_AFTER_HTP_KEY, (int)val);
    }

#endregion

    /* Purchases */

#region AD_FREE

    const string AD_FREE_KEY = "AdFree";

    public enum AdFree {
        NOT_PURCHASED = 0,
        PURCHASED = 1
    }

    public AdFree GetAdFree()
    {
        if (PlayerPrefs.HasKey(AD_FREE_KEY)) {
            if (PlayerPrefs.GetInt(AD_FREE_KEY) == (int)(AdFree.NOT_PURCHASED))
                return AdFree.NOT_PURCHASED;
            else
                return AdFree.PURCHASED;
        } else {
            PlayerPrefs.SetInt(AD_FREE_KEY, (int)(AdFree.NOT_PURCHASED));
            return AdFree.NOT_PURCHASED;
        }
    }

    public void SetAdFree(AdFree val)
    {
        PlayerPrefs.SetInt(AD_FREE_KEY, (int)val);
    }

#endregion

#region HINT_COUNT

    const string HINT_COUNT_KEY = "HintCount";

    const int HINT_COUNT_DEFAULT = 3;

    public int GetHintCount()
    {
        if (PlayerPrefs.HasKey(HINT_COUNT_KEY)) {
            return PlayerPrefs.GetInt(HINT_COUNT_KEY);
        } else {
            PlayerPrefs.SetInt(HINT_COUNT_KEY, HINT_COUNT_DEFAULT);
            return HINT_COUNT_DEFAULT;
        }
    }

    public void SetHintCount(int val)
    {
        PlayerPrefs.SetInt(HINT_COUNT_KEY, val);
    }

#endregion

    /* Settings */

#region AUDIO

    const string AUDIO_KEY = "Audio";

    public enum Audio {
        OFF = 0,
        ON = 1,
    }

    public Audio GetAudio()
    {
        if (PlayerPrefs.HasKey(AUDIO_KEY)) {
            if (PlayerPrefs.GetInt(AUDIO_KEY) == (int)Audio.ON)
                return Audio.ON;
            else
                return Audio.OFF;
        } else {
            PlayerPrefs.SetInt(AUDIO_KEY, (int)Audio.ON);
            return Audio.ON;
        }
    }

    public void SetAudio(Audio val)
    {
        PlayerPrefs.SetInt(AUDIO_KEY, (int)val);
    }

#endregion

#region ALIGNLR

    const string ALIGNLR_KEY = "AlignLR";

    public enum AlignLR {
        LEFT = 0,
        RIGHT = 1
    }

    public AlignLR GetAlignLR()
    {
        if (PlayerPrefs.HasKey(ALIGNLR_KEY)) {
            if (PlayerPrefs.GetInt(ALIGNLR_KEY) == (int)AlignLR.LEFT)
                return AlignLR.LEFT;
            else
                return AlignLR.RIGHT;
        } else {
            PlayerPrefs.SetInt(ALIGNLR_KEY, (int)AlignLR.LEFT);
            return AlignLR.LEFT;
        }
    }

    public void SetAlignLR(AlignLR val)
    {
        PlayerPrefs.SetInt(ALIGNLR_KEY, (int)val);
    }

#endregion

    /* Levels */

#region LEVEL_MODE

    const string LEVEL_MODE_KEY = "LevelMode";

    const string LEVEL_MODE_DEFAULT = LevelCollection.LEVEL_MODE_STAR;

    public string GetLevelMode()
    {
        if (PlayerPrefs.HasKey(LEVEL_MODE_KEY)) {
            return PlayerPrefs.GetString(LEVEL_MODE_KEY);
        } else {
            PlayerPrefs.SetString(LEVEL_MODE_KEY, LEVEL_MODE_DEFAULT);
            return LEVEL_MODE_DEFAULT;
        }
    }

    public void SetLevelMode(string val)
    {
        PlayerPrefs.SetString(LEVEL_MODE_KEY, val);
    }

#endregion

#region LEVEL_MODE_LAST

    const string LEVEL_MODE_LAST_KEY = "LevelModeLast";

    const string LEVEL_MODE_LAST_DEFAULT = "Star";

    public string GetLevelModeLast()
    {
        if (PlayerPrefs.HasKey(LEVEL_MODE_LAST_KEY)) {
            return PlayerPrefs.GetString(LEVEL_MODE_LAST_KEY);
        } else {
            PlayerPrefs.SetString(LEVEL_MODE_LAST_KEY, LEVEL_MODE_LAST_DEFAULT);
            return LEVEL_MODE_LAST_DEFAULT;
        }
    }

    public void SetLevelModeLast(string val)
    {
        PlayerPrefs.SetString(LEVEL_MODE_LAST_KEY, val);
    }

#endregion

#region LEVEL_APHABET

    const string LEVEL_ALPHABET_KEY = "LevelAlphabet";

    const string LEVEL_ALPHABET_DEFAULT = LevelCollection.LEVEL_ALPHABET_ALPHA;

    public string GetLevelAlphabet()
    {
        if (PlayerPrefs.HasKey(LEVEL_ALPHABET_KEY)) {
            return PlayerPrefs.GetString(LEVEL_ALPHABET_KEY);
        } else {
            PlayerPrefs.SetString(LEVEL_ALPHABET_KEY, LEVEL_ALPHABET_DEFAULT);
            return LEVEL_ALPHABET_DEFAULT;
        }
    }

    public void SetLevelAlphabet(string val)
    {
        PlayerPrefs.SetString(LEVEL_ALPHABET_KEY, val);
    }

#endregion

#region LEVEL_ALPHABET_LAST

    const string LEVEL_ALPHABET_LAST_KEY = "LevelAlphabetLast";

    const string LEVEL_ALPHABET_LAST_DEFAULT = "Alpha";

    public string GetLevelAlphabetLast()
    {
        if (PlayerPrefs.HasKey(LEVEL_ALPHABET_LAST_KEY)) {
            return PlayerPrefs.GetString(LEVEL_ALPHABET_LAST_KEY);
        } else {
            PlayerPrefs.SetString(LEVEL_ALPHABET_LAST_KEY, LEVEL_ALPHABET_LAST_DEFAULT);
            return LEVEL_ALPHABET_LAST_DEFAULT;
        }
    }

    public void SetLevelAlphabetLast(string val)
    {
        PlayerPrefs.SetString(LEVEL_ALPHABET_LAST_KEY, val);
    }

#endregion

#region LEVEL_NUMBER

    const string LEVEL_NUMBER_KEY = "LevelNumber";

    const int LEVEL_NUMBER_DEFAULT = 1;

    public int GetLevelNumber()
    {
        if (PlayerPrefs.HasKey(LEVEL_NUMBER_KEY)) {
            return PlayerPrefs.GetInt(LEVEL_NUMBER_KEY);
        } else {
            PlayerPrefs.SetInt(LEVEL_NUMBER_KEY, LEVEL_NUMBER_DEFAULT);
            return LEVEL_NUMBER_DEFAULT;
        }
    }

    public void SetLevelNumber(int val)
    {
        PlayerPrefs.SetInt(LEVEL_NUMBER_KEY, val);
    }

#endregion

#region LEVEL_NUMBER_LAST

    const string LEVEL_NUMBER_LAST_KEY = "LevelNumberLast";

    const int LEVEL_NUMBER_LAST_DEFAULT = 1;

    public int GetLevelNumberLast()
    {
        if (PlayerPrefs.HasKey(LEVEL_NUMBER_LAST_KEY)) {
            return PlayerPrefs.GetInt(LEVEL_NUMBER_LAST_KEY);
        } else {
            PlayerPrefs.SetInt(LEVEL_NUMBER_LAST_KEY, LEVEL_NUMBER_LAST_DEFAULT);
            return LEVEL_NUMBER_LAST_DEFAULT;
        }
    }

    public void SetLevelNumberLast(int val)
    {
        PlayerPrefs.SetInt(LEVEL_NUMBER_LAST_KEY, val);
    }

#endregion

#region LEVEL_LOCKED

    public enum LevelLock {
        UNLOCKED = 0,
        LOCKED = 1
    }

    public LevelLock GetLevelLocked(string mode, string alphabet, int num)
    {
        string key = "LevelLock_" + mode + "_" + alphabet + "_" + num;

        if (PlayerPrefs.HasKey(key)) {
            if (PlayerPrefs.GetInt(key) == (int)LevelLock.UNLOCKED)
                return LevelLock.UNLOCKED;
            else
                return LevelLock.LOCKED;
        } else {
            if (alphabet == LevelCollection.LEVEL_ALPHABET_ALPHA && num == 1) {
                PlayerPrefs.SetInt(key, (int)LevelLock.UNLOCKED);
                return LevelLock.UNLOCKED;
            } else {
                PlayerPrefs.SetInt(key, (int)LevelLock.LOCKED);
                return LevelLock.LOCKED;
            }
        }
    }

    public void SetLevelLocked(string mode, string alphabet, int num, LevelLock val)
    {
        string key = "LevelLock_" + mode + "_" + alphabet + "_" + num;
        PlayerPrefs.SetInt(key, (int)val);
    }

#endregion

    /* Moves */

#region LEVEL_MOVES

    public const int LEVEL_MOVES_NONE = -1;

    public int GetLevelMoves(string mode, string alphabet, int num)
    {
        string key = "LevelMoves" + "_" + mode + "_" + alphabet + "_" + num;

        if (PlayerPrefs.HasKey(key)) {
            return PlayerPrefs.GetInt(key);
        } else {
            PlayerPrefs.SetInt(key, LEVEL_MOVES_NONE);
            return LEVEL_MOVES_NONE;
        }
    }

    public void SetLevelMoves(string mode, string alphabet, int num, int val)
    {
        string key = "LevelMoves" + "_" + mode + "_" + alphabet + "_" + num;
        PlayerPrefs.SetInt(key, val);
    }

#endregion

    /* Stars */

#region STARS_BY_MODE

    public int GetStarsByMode(string mode)
    {
        string key = "Stars_" + mode;

        if (PlayerPrefs.HasKey(key)) {
            return PlayerPrefs.GetInt(key);
        } else {
            PlayerPrefs.SetInt(key, 0);
            return 0;
        }
    }

    public void SetStarsByMode(string mode, int val)
    {
        string key = "Stars_" + mode;
        PlayerPrefs.SetInt(key, val);
    }

#endregion

#region STARS_BY_ALPHABET

    public int GetStarsByAlphabet(string mode, string alphabet)
    {
        string key = "Stars_" + mode + "_" + alphabet;

        if (PlayerPrefs.HasKey(key)) {
            return PlayerPrefs.GetInt(key);
        } else {
            PlayerPrefs.SetInt(key, 0);
            return 0;
        }
    }

    public void SetStarsByAlphabet(string mode, string alphabet, int val)
    {
        string key = "Stars_" + mode + "_" + alphabet;
        PlayerPrefs.SetInt(key, val);
    }

#endregion

#region STARS_BY_NUMBER

    public int GetStarsByNumber(string mode, string alphabet, int num)
    {
        string key = "Stars_" + mode + "_" + alphabet + "_" + num;

        if (PlayerPrefs.HasKey(key)) {
            return PlayerPrefs.GetInt(key);
        } else {
            PlayerPrefs.SetInt(key, 0);
            return 0;
        }
    }

    public void SetStarsByNumber(string mode, string alphabet, int num, int val)
    {
        string key = "Stars_" + mode + "_" + alphabet + "_" + num;

        int prevVal = GetStarsByNumber(mode, alphabet, num);
        
        PlayerPrefs.SetInt(key, val);

        if (val > prevVal) {
            int diff = val - prevVal;
            SetStarsByAlphabet(mode, alphabet, diff + GetStarsByAlphabet(mode, alphabet));
            SetStarsByMode(mode, diff + GetStarsByMode(mode));
        }
    }

#endregion

#region DAILY_DATE

    const string DAILY_DATE_KEY = "DailyDate";

    const string DAILY_DATE_DEFAULT = "30/04/2020";

    public string GetDailyDate()
    {
        if (PlayerPrefs.HasKey(DAILY_DATE_KEY)) {
            return PlayerPrefs.GetString(DAILY_DATE_KEY);
        } else {
            PlayerPrefs.SetString(DAILY_DATE_KEY, DAILY_DATE_DEFAULT);
            return DAILY_DATE_DEFAULT;
        }
    }

    public void SetDailyDate(string val)
    {
        PlayerPrefs.SetString(DAILY_DATE_KEY, val);
    }

#endregion

#region DAILY_STREAK

    const string DAILY_STREAK_KEY = "DailyStreak";

    public int GetDailyStreak()
    {
        if (PlayerPrefs.HasKey(DAILY_STREAK_KEY)) {
            return PlayerPrefs.GetInt(DAILY_STREAK_KEY);
        } else {
            PlayerPrefs.SetInt(DAILY_STREAK_KEY, 0);
            return 0;
        }
    }

    public void SetDailyStreak(int val)
    {
        PlayerPrefs.SetInt(DAILY_STREAK_KEY, val);
    }

#endregion

}
