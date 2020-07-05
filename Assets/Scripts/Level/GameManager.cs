using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class GameManager : MonoBehaviour
{
    /* Key */

    KeyManager keyMan;

    /* Ads */

    AdManager adMan;

    string sceneAfterInterstitialAd;
    TouchMode modeAfterRewardedAd;

    /* IAP */

    IAPManager iapMan;

    /* Level */

    LevelCollection levelCollection;
    string levelMode;
    string levelAlphabet;
    int levelAlphabetInt;
    int levelNumber;

    /* UI */

    const float START_ANIMATION_DELAY = 1.25F;

    UIManager uiMan;

    float startAnimationStartTime;
    bool waitStartAnimation;

    /* Audio*/

    const float MOVE_START_TO_END_AUDIO_DELAY = 0.08F;
    const float MOVE_START_TO_END_AUDIO_PLAY_TIME = 0.1F;

    const float MOVE_PRE_END_TO_END_AUDIO_DELAY = 10.00F;
    const float MOVE_PRE_END_TO_END_AUDIO_PLAY_TIME = 2.10F;

    AudioManager audioMan;

    bool moveAudioPlayed;

    /* Camera */

    const float CAMERA_SIZE_64 = 11.0F;
    const float CAMERA_SIZE_100 = 14.0F;

    GameObject cam;

    /* Cubes */

    const int NUM_CUBES = 4;

    const int CUBE_RED = 0;
    const int CUBE_GREEN = 1;
    const int CUBE_BLUE = 2;
    const int CUBE_YELLOW = 3;

    string[] CUBE_NAME = new string[NUM_CUBES] { "CubeRed", "CubeGreen", "CubeBlue", "CubeYellow" };

    const float CUBE_START_COLOR_VALUE = 1.0F;
    const float CUBE_END_COLOR_VALUE = 0.8F;

    CubeMovement[] cube;

    Vector2[] cubeStartPos;
    Vector2[] cubeEndPos;
    Vector2[] cubeStartToEndDist;
    Vector2[] cubePreEndPos;
    Vector2[] cubeStartToPreEndDist;
    Vector2[] cubePreEndToEndDist;
    int cubeGreatestDist;
    
    /* Touch */

    const float TOUCH_FLING_DIRECTION_MULTIPLIER = 1.5F;
    const float TOUCH_FLING_DIRECTION_OFFSET = 20.0F;
    const float TOUCH_FLING_DECELERATION_SEC_PER_UNIT = 0.07F;
    const float TOUCH_FLING_WIN_DECELERATION_SEC_PER_UNIT = 2.0F;

    const float TOUCH_HOLD_TO_CANCEL_TIME = 0.4F;

    Vector2 TOUCH_DIRECTION_NONE = Vector2.zero;
    Vector2 TOUCH_DIRECTION_UP = new Vector2(0.0F, 1.0F);
    Vector2 TOUCH_DIRECTION_DOWN = new Vector2(0.0F, -1.0F);
    Vector2 TOUCH_DIRECTION_LEFT = new Vector2(-1.0F, 0.0F);
    Vector2 TOUCH_DIRECTION_RIGHT = new Vector2(1.0F, 0.0F);

    enum TouchMode {
        NONE = 0,
        START = 1,
        FLING_START_TO_END = 2,
        FLING_START_TO_PRE_END = 3,
        FLING_PRE_END_TO_END = 4,
        WIN = 5,
        ADS_INTERSTITIAL = 6,
        ADS_REWARDED = 8,
    }

    Vector2 touchDirection;
    Vector2 touchStartPos;
    Vector2 touchLastPos;
    float touchStartTime;
    float touchDecelStartTime;
    float touchHoldToCancelStartTime;

    TouchMode touchMode;

    /* Hint */

    const char HINT_UP = 'U';
    const char HINT_DOWN = 'D';
    const char HINT_LEFT = 'L';
    const char HINT_RIGHT = 'R';

    bool hintUsed;
    bool hintEnabled;

    /* Moves */

    Stack[] moves;

    /* Pause */

    bool pauseEnable;

    /* Win */

    bool winDoOnce;

    void Start()
    {
        /* Key */

        keyMan = GameObject.Find("KeyManager").GetComponent<KeyManager>();

        /* Ads */

        adMan = GameObject.Find("AdManager").GetComponent<AdManager>();

        sceneAfterInterstitialAd = "";
        modeAfterRewardedAd = TouchMode.NONE;

        /* IAP */

        iapMan = GameObject.Find("IAPManager").GetComponent<IAPManager>();

        /* Level */

        levelCollection = GameObject.Find("LevelCollection").GetComponent<LevelCollection>();
        levelMode = keyMan.GetLevelMode();
        levelAlphabet = keyMan.GetLevelAlphabet();
        levelAlphabetInt = levelCollection.GetAlphabet(levelAlphabet);
        levelNumber = keyMan.GetLevelNumber();

        if (levelMode == LevelCollection.LEVEL_MODE_RELAX
                || levelMode == LevelCollection.LEVEL_MODE_STAR) {
            keyMan.SetLevelModeLast(levelMode);
            keyMan.SetLevelAlphabetLast(levelAlphabet);
            keyMan.SetLevelNumberLast(levelNumber);
        }
        
        /* UI */

        uiMan = GameObject.Find("UIManager").GetComponent<UIManager>();

        startAnimationStartTime = Time.time;
        waitStartAnimation = true;

        /* Audio */

        audioMan = GameObject.Find("AudioManager").GetComponent<AudioManager>();

        moveAudioPlayed = false;

        /* Camera */

        cam = GameObject.Find("Camera");

        if (levelCollection.GetBoardSize(levelAlphabetInt, levelNumber) == 64)
            cam.GetComponent<Camera>().orthographicSize = CAMERA_SIZE_64;
        else
            cam.GetComponent<Camera>().orthographicSize = CAMERA_SIZE_100;

        /* Cube */

        cube = new CubeMovement[NUM_CUBES];

        cubeStartPos = new Vector2[NUM_CUBES];
        cubeEndPos = new Vector2[NUM_CUBES];
        cubeStartToEndDist = new Vector2[NUM_CUBES];
        cubePreEndPos = new Vector2[NUM_CUBES];
        cubeStartToPreEndDist = new Vector2[NUM_CUBES];
        cubePreEndToEndDist = new Vector2[NUM_CUBES];

        for (int i = 0; i < NUM_CUBES; i++) {

            cube[i] = GameObject.Find(CUBE_NAME[i]).GetComponent<CubeMovement>();
            cube[i].PlayCubeEnter();

            cubeStartPos[i] = Vector2.zero;
            cubeEndPos[i] = Vector2.zero;
            cubeStartToEndDist[i] = Vector2.zero;
            cubePreEndPos[i] = Vector2.zero;
            cubeStartToPreEndDist[i] = Vector2.zero;
            cubePreEndToEndDist[i] = Vector2.zero;
        }

        cubeGreatestDist = 0;

        for (int j = 0; j < Level.DATA_BOUND_ROW_SIZE; j++) {
            for (int k = 0; k < Level.DATA_BOUND_COL_SIZE; k++) {

                if (levelCollection.GetBound(levelAlphabetInt, levelNumber, j, k) == Level.DATA_BOUND_CUBE_RED)
                    cube[CUBE_RED].SetPosition(new Vector2(-4.5F + k, 4.5F - j));
                else if (levelCollection.GetBound(levelAlphabetInt, levelNumber, j, k) == Level.DATA_BOUND_CUBE_GREEN)
                    cube[CUBE_GREEN].SetPosition(new Vector2(-4.5F + k, 4.5F - j));
                else if (levelCollection.GetBound(levelAlphabetInt, levelNumber, j, k) == Level.DATA_BOUND_CUBE_BLUE)
                    cube[CUBE_BLUE].SetPosition(new Vector2(-4.5F + k, 4.5F - j));
                else if (levelCollection.GetBound(levelAlphabetInt, levelNumber, j, k) == Level.DATA_BOUND_CUBE_YELLOW)
                    cube[CUBE_YELLOW].SetPosition(new Vector2(-4.5F + k, 4.5F - j));
            }
        }

        /* Touch */

        touchDirection = TOUCH_DIRECTION_NONE;
        touchStartPos = Vector2.zero;
        touchLastPos = Vector2.zero;
        touchStartTime = 0.0F;
        touchDecelStartTime = 0.0F;
        touchHoldToCancelStartTime = 0.0F;

        touchMode = TouchMode.NONE;

        /* Hint */

        hintUsed = false;
        hintEnabled = false;

        /* Moves */

        moves = new Stack[NUM_CUBES];

        for (int i = 0; i < NUM_CUBES; i++) {
            Vector2 v = cube[i].GetCurrentPosition();
            moves[i] = new Stack();
            moves[i].Push(v);
        }
        
        /* Win */

        winDoOnce = false;

        /* Misc */

        pauseEnable = false;
    }

    void Update()
    {
        if (waitStartAnimation) {
            if (Time.time - startAnimationStartTime < START_ANIMATION_DELAY)
                return;

            waitStartAnimation = false;
        }

        UpdateHintAnimation();

        if (pauseEnable)
             return;

        if (touchMode == TouchMode.NONE)
            DoTouchModeNone();
        else if (touchMode == TouchMode.START)
            DoTouchModeStart();
        else if (touchMode == TouchMode.FLING_START_TO_END)
            DoTouchModeFlingStartToEnd();
        else if (touchMode == TouchMode.FLING_START_TO_PRE_END)
            DoTouchModeFlingStartToPreEnd();
        else if (touchMode == TouchMode.FLING_PRE_END_TO_END)
            DoTouchModeFlingPreEndToEnd();
        else if (touchMode == TouchMode.WIN)
            DoTouchModeWin();
        else if (touchMode == TouchMode.ADS_INTERSTITIAL)
            DoTouchModeAdsInterstitial();
        else if (touchMode == TouchMode.ADS_REWARDED)
            DoTouchModeAdsRewarded();
    }

#region GAME_STATES

    void DoTouchModeNone()
    {
        if (moveAudioPlayed) {
            if (Time.time - touchDecelStartTime < MOVE_START_TO_END_AUDIO_PLAY_TIME)
                return;
            else
                moveAudioPlayed = false;
        }
 
        uiMan.SetButtonTopAllInteractable(true);
        uiMan.SetButtonLeftAllInteractable(true);
        uiMan.SetButtonRightAllInteractable(true);

        if (Input.touchCount != 1)
            return;

        Touch touch = Input.GetTouch(0);

        if (touch.phase != TouchPhase.Began)
            return;

        if (EventSystem.current.IsPointerOverGameObject(touch.fingerId))
            return;

        uiMan.SetButtonTopAllInteractable(false);
        uiMan.SetButtonLeftAllInteractable(false);
        uiMan.SetButtonRightAllInteractable(false);

        touchDirection = TOUCH_DIRECTION_NONE;
        touchStartPos = touch.position;
        touchLastPos = touch.position;
        touchStartTime = Time.time;
        touchDecelStartTime = 0.0F;
        touchHoldToCancelStartTime = 0.0F;

        touchMode = TouchMode.START;
        return;
    }

    void DoTouchModeStart()
    {
        if (Input.touchCount != 1) {
            touchMode = TouchMode.NONE;
            return;
        }

        Touch touch = Input.GetTouch(0);

        if (touch.phase == TouchPhase.Began) {
            touchMode = TouchMode.NONE;
            return;
        }

        /* Fling cube in a certain direction */

        if (touch.phase == TouchPhase.Ended) {

            touchDirection = CalculateDirection(touchStartPos, touch.position,
                                                TOUCH_FLING_DIRECTION_MULTIPLIER,
                                                TOUCH_FLING_DIRECTION_OFFSET);

            bool cubeMoveLegal = false;
            cubeGreatestDist = 0;

            if (touchDirection != TOUCH_DIRECTION_NONE) {

                for (int i = 0; i < NUM_CUBES; i++) {

                    cubeStartPos[i] = cube[i].GetCurrentPosition();
                    cubeEndPos[i] = cube[i].GetMoveEndPosition(touchDirection);
                    cubeStartToEndDist[i] = Vector2.Distance(cubeStartPos[i], cubeEndPos[i]) * touchDirection;

                    if (cubeStartToEndDist[i] != Vector2.zero)
                        cubeMoveLegal = true;

                    if (cubeStartToEndDist[i].magnitude > cubeStartToEndDist[cubeGreatestDist].magnitude)
                        cubeGreatestDist = i;
                }

                cubePreEndPos[cubeGreatestDist] = cubeEndPos[cubeGreatestDist] - (touchDirection * 1.0F);
                cubeStartToPreEndDist[cubeGreatestDist] = Vector2.Distance(cubeStartPos[cubeGreatestDist], cubePreEndPos[cubeGreatestDist]) * touchDirection;
                cubePreEndToEndDist[cubeGreatestDist] = Vector2.Distance(cubePreEndPos[cubeGreatestDist], cubeEndPos[cubeGreatestDist]) * touchDirection;

                for (int i = 0; i < NUM_CUBES; i++) {

                    if (i == cubeGreatestDist)
                        continue;

                    cubePreEndPos[i] = cubeStartPos[i] + (cubeStartToPreEndDist[cubeGreatestDist].magnitude / cubeStartToEndDist[cubeGreatestDist].magnitude * cubeStartToEndDist[i].magnitude) * touchDirection;
                    cubeStartToPreEndDist[i] = Vector2.Distance(cubeStartPos[i], cubePreEndPos[i]) * touchDirection;
                    cubePreEndToEndDist[i] = Vector2.Distance(cubePreEndPos[i], cubeEndPos[i]) * touchDirection;
                }

                if ((!hintEnabled && cubeMoveLegal) || (hintEnabled && IsHintDirectionLegal(touchDirection))) {
                    touchDecelStartTime = Time.time;
                    if (IsWinningConditionMet(cubeEndPos))
                        touchMode = TouchMode.FLING_START_TO_PRE_END;
                    else
                        touchMode = TouchMode.FLING_START_TO_END;
                    return;
                }
            }

            touchMode = TouchMode.NONE;
            return;
        }

        /* Hold to cancel false swipe */

        if (touch.position == touchLastPos) {
            touchHoldToCancelStartTime += Time.deltaTime;
            if (touchHoldToCancelStartTime > TOUCH_HOLD_TO_CANCEL_TIME) {
                touchMode = TouchMode.NONE;
                return;
            }
        }

        /* Save current touch position */

        touchLastPos = touch.position;
    }

    void DoTouchModeFlingStartToEnd()
    {
        DecelerateCubesToEndPos(cubeStartToEndDist, cubeStartPos, cubeEndPos, cubeGreatestDist,
                                touchDirection, TOUCH_FLING_DECELERATION_SEC_PER_UNIT);

        if (AreCubesAtPos(cubeEndPos)) {
            IncrementMove();
            touchMode = TouchMode.NONE;
            return;
        }
    }

    void DoTouchModeFlingStartToPreEnd()
    {
        DecelerateCubesToEndPos(cubeStartToPreEndDist, cubeStartPos, cubePreEndPos, cubeGreatestDist,
                                touchDirection, TOUCH_FLING_DECELERATION_SEC_PER_UNIT);

        if (AreCubesAtPos(cubePreEndPos)) {

            if (hintEnabled) {
                uiMan.SetPanelHintOnActive(false);
                uiMan.SetPanelHintLRActive(false);
                uiMan.SetButtonLeftHintImage(false);
                uiMan.SetButtonRightHintImage(false);
                hintEnabled = false;
                hintEnabled = false;
            }

            uiMan.PlayPanelPreWinEnter();
            touchDecelStartTime = Time.time;
            touchMode = TouchMode.FLING_PRE_END_TO_END;
            return;
        }
    }

    void DoTouchModeFlingPreEndToEnd()
    {
        DecelerateCubesToEndPos(cubePreEndToEndDist, cubePreEndPos, cubeEndPos, cubeGreatestDist,
                                touchDirection, TOUCH_FLING_WIN_DECELERATION_SEC_PER_UNIT);

        if (AreCubesAtPos(cubeEndPos)) {
            IncrementMove();
            touchMode = TouchMode.WIN;
            return;
        }
    }

    void DoTouchModeWin()
    {
        if (moveAudioPlayed) {
            if (Time.time - touchDecelStartTime < MOVE_PRE_END_TO_END_AUDIO_PLAY_TIME)
                return;
            else
                moveAudioPlayed = false;
        }

        if (!winDoOnce) {

            if (levelMode == LevelCollection.LEVEL_MODE_STAR) {

                bool newRecord;
                int stars;

                int currentMoves = moves[0].Count - 1;
                int recordedMoves = keyMan.GetLevelMoves(levelMode, levelAlphabet, levelNumber);
                
                if (recordedMoves == KeyManager.LEVEL_MOVES_NONE || currentMoves < recordedMoves) {
                    newRecord = true;
                    keyMan.SetLevelMoves(levelMode, levelAlphabet, levelNumber, currentMoves);
                } else {
                    newRecord = false;
                }
                
                if (currentMoves <= levelCollection.Get3StarMoves(levelAlphabetInt, levelNumber))
                    stars = 3;
                else if (currentMoves <= levelCollection.Get2StarMoves(levelAlphabetInt, levelNumber))
                    stars = 2;
                else
                    stars = 1;

                if (stars > keyMan.GetStarsByNumber(levelMode, levelAlphabet, levelNumber))
                    keyMan.SetStarsByNumber(levelMode, levelAlphabet, levelNumber, stars);

                uiMan.PlayWinSequence(newRecord, stars);

            } else if (levelMode == LevelCollection.LEVEL_MODE_RELAX) {

                keyMan.SetStarsByNumber(levelMode, levelAlphabet, levelNumber, 1);

                /* The input variables are not important for Relax Mode */
                uiMan.PlayWinSequence(false, 0);

            } else if (levelMode == LevelCollection.LEVEL_MODE_DAILY) {

                int currentMoves = moves[0].Count - 1;
                int stars;

                if (currentMoves <= levelCollection.Get3StarMoves(levelAlphabetInt, levelNumber))
                    stars = 3;
                else if (currentMoves <= levelCollection.Get2StarMoves(levelAlphabetInt, levelNumber))
                    stars = 2;
                else
                    stars = 1;

                keyMan.SetDailyStreak(keyMan.GetDailyStreak() + stars);
                keyMan.SetDailyDate(DateTime.Now.ToString("dd/MM/yyyy"));

                /* The first input variable is not important for Daily Mode */
                uiMan.PlayWinSequence(false, stars);
            }

            if (levelMode == LevelCollection.LEVEL_MODE_RELAX
                    || levelMode == LevelCollection.LEVEL_MODE_STAR) {
                SetNextLevelAsLastLevel();
                UnlockNextLevel();
            }

            if (keyMan.GetAdFree() == KeyManager.AdFree.NOT_PURCHASED)
                adMan.DisplayBannerAd();

            winDoOnce = true;
        }
    }

    void DoTouchModeAdsInterstitial()
    {
        if (audioMan.IsPlaying())
            return;

        AdManager.InterstitialAdStatus status = adMan.GetInterstitialAdStatus();

        if (status == AdManager.InterstitialAdStatus.REQUEST_SUCCESS) {
            adMan.DisplayInterstitialAd();
            return;
        } else if (status == AdManager.InterstitialAdStatus.REQUEST_FAILED ||
                status == AdManager.InterstitialAdStatus.CLOSED) {

            adMan.DestroyInterstitialAd();
            adMan.RequestInterstitialAd();

            if (sceneAfterInterstitialAd == "Level") {
                LoadNextLevel();
                return;
            } else if (sceneAfterInterstitialAd == "ThisLevel") {
                SceneManager.LoadScene("Level");
                return;
            } else if (sceneAfterInterstitialAd == "MenuLevel") {
                SceneManager.LoadScene("MenuLevel");
                return;
            } else if (sceneAfterInterstitialAd == "MenuMain") {
                SceneManager.LoadScene("MenuMain");
            }
        } else {
            return;
        }
    }

    void DoTouchModeAdsRewarded()
    {
        if (audioMan.IsPlaying())
            return;

        AdManager.RewardedAdStatus status = adMan.GetRewardedAdStatus();

        if (status == AdManager.RewardedAdStatus.REQUEST_SUCCESS) {
            adMan.DisplayRewardedAd();
            return;
        } else if (status == AdManager.RewardedAdStatus.DISPLAY_FAILED ||
                status == AdManager.RewardedAdStatus.REQUEST_FAILED) {
            uiMan.PlayPanelAdConnectionEnter();
            adMan.DestroyRewardedAd();
            adMan.RequestRewardedAd();
            touchMode = modeAfterRewardedAd;
            return;
        } else if (status == AdManager.RewardedAdStatus.CLOSED) {
            if (adMan.GetRewardReceived()) {

                int newHintCount = keyMan.GetHintCount() + 1;

                keyMan.SetHintCount(newHintCount);
                uiMan.SetTextLeftLabelHint(newHintCount);
                uiMan.SetTextRightLabelHint(newHintCount);
                uiMan.SetButtonLeftHintActive();
                uiMan.SetButtonRightHintActive();
                uiMan.SetStoreHintCount(newHintCount);
                audioMan.PlayRewardAudio();
                uiMan.PlayPanelAdRewardEnter();
            } else {
                uiMan.SetPanelAdAllActiveFalse();
            }
            adMan.ClearRewardReceived();
            adMan.DestroyRewardedAd();
            adMan.RequestRewardedAd();
            touchMode = modeAfterRewardedAd;
            return;
        } else {
            return;
        }
    }

#endregion

#region CUBE_MOVEMENT

    Vector2 CalculateDirection(Vector2 start, Vector2 end, float multiplier, float offset)
    {
        Vector2 dist = end - start;

        if (Mathf.Abs(dist.y) > (Mathf.Abs(dist.x) * multiplier) &&
                Mathf.Abs(dist.y) > offset) {
            if (dist.y > 0.0F)
                return TOUCH_DIRECTION_UP;
            else if (dist.y < 0.0F)
                return TOUCH_DIRECTION_DOWN;
        } else if (Mathf.Abs(dist.x) > (Mathf.Abs(dist.y) * multiplier) &&
                Mathf.Abs(dist.x) > offset) {
            if (dist.x > 0.0F)
                return TOUCH_DIRECTION_RIGHT;
            else if (dist.x < 0.0F)
                return TOUCH_DIRECTION_LEFT;
        }

        return TOUCH_DIRECTION_NONE;
    }

    bool IsHintDirectionLegal(Vector2 direction)
    {
        int moveCount = moves[0].Count - 1;
        char hint = levelCollection.GetHint(levelAlphabetInt, levelNumber, moveCount);

        if ((touchDirection == TOUCH_DIRECTION_UP && hint == 'U') ||
                (touchDirection == TOUCH_DIRECTION_DOWN && hint == 'D') ||
                (touchDirection == TOUCH_DIRECTION_LEFT && hint == 'L') ||
                (touchDirection == TOUCH_DIRECTION_RIGHT && hint == 'R'))            
            return true;
        return false;
    }

    void DecelerateCubesToEndPos(Vector2[] startToEndDist, Vector2[] startPosition, Vector2[] finalPosition,
                                 int greatestDistIdx, Vector2 direction, float timePerUnit)
    {
        float greatestDist = startToEndDist[greatestDistIdx].magnitude;
        float travelTime = greatestDist * timePerUnit;

        float moveAudioPlayTime = 0.0F;

        /* Play move audio */

        if (touchMode == TouchMode.FLING_START_TO_END) {

            moveAudioPlayTime = Mathf.Max(travelTime - MOVE_START_TO_END_AUDIO_DELAY, 0.0F);

            if (!moveAudioPlayed) {
                if (Time.time - touchDecelStartTime >= moveAudioPlayTime) {
                    audioMan.PlayMoveStartToEndAudio();
                    moveAudioPlayed = true;
                }
            }

        } else if (touchMode == TouchMode.FLING_PRE_END_TO_END) {

            moveAudioPlayTime = Mathf.Max(travelTime - MOVE_PRE_END_TO_END_AUDIO_DELAY, 0.0F);

            if (!moveAudioPlayed) {
                if (Time.time - touchDecelStartTime >= moveAudioPlayTime) {
                    audioMan.PlayMovePreEndToEndAudio();
                    moveAudioPlayed = true;
                }
            }
        }

        /* Set position */

        for (int i = 0; i < NUM_CUBES; i++) {

            if (startToEndDist[i].magnitude == 0.0F)
                continue;

            float startSpeed = (2.0F * startToEndDist[i].magnitude) / travelTime;
            float deceleration = -(startSpeed * startSpeed) / (2 * startToEndDist[i].magnitude);
            float deltaTime = Mathf.Min(Time.time - touchDecelStartTime, travelTime);
            float distance = (startSpeed * deltaTime) + ((0.5F * deceleration) * (deltaTime * deltaTime));

            Vector2 movePosition = startPosition[i] + distance * direction;
            
            if (touchDirection == TOUCH_DIRECTION_UP) {
                if (movePosition.y > finalPosition[i].y)
                    movePosition.y = finalPosition[i].y;
            } else if (touchDirection == TOUCH_DIRECTION_DOWN) {
                if (movePosition.y < finalPosition[i].y)
                    movePosition.y = finalPosition[i].y;
            } else if (touchDirection == TOUCH_DIRECTION_LEFT) {
                if (movePosition.x < finalPosition[i].x)
                    movePosition.x = finalPosition[i].x;
            } else if (touchDirection == TOUCH_DIRECTION_RIGHT) {
                if (movePosition.x > finalPosition[i].x)
                    movePosition.x = finalPosition[i].x;
            }

            cube[i].SetPosition(movePosition);
        }
    }

    bool AreCubesAtPos(Vector2[] position)
    {
        for (int i = 0; i < NUM_CUBES; i++) {
            if (cube[i].GetCurrentPosition() != position[i])
                return false;
        }
        return true;
    }

    bool IsWinningConditionMet(Vector2[] cubePosition)
    {
        float[,,] edges = new float[4, 4, 2];
        float[] hitTally = new float[4];

        for (int i = 0; i < NUM_CUBES; i++) {

            Vector2 pos = cubePosition[i];
            float posX = pos.x;
            float posY = pos.y;

            edges[i, 0, 0] = posX;
            edges[i, 0, 1] = posY + 0.5F;
            edges[i, 1, 0] = posX + 0.5F;
            edges[i, 1, 1] = posY;
            edges[i, 2, 0] = posX;
            edges[i, 2, 1] = posY - 0.5F;
            edges[i, 3, 0] = posX - 0.5F;
            edges[i, 3, 1] = posY;
        }

        for (int i = 0; i < 4; i++)
            hitTally[0] = 0;
        
        for (int i = 0; i < 4; i++) {
            for (int j = 0; j < 4; j++) {
                for (int k = 0; k < 4; k++) {
                    for (int l = 0; l < 4; l++) {

                        if (i == k)
                            continue;

                        if (Mathf.Abs(edges[i, j, 0] - edges[k, l, 0]) <= 0.05f &&
                                Mathf.Abs(edges[i, j, 1] - edges[k, l, 1]) <= 0.05f)
                            hitTally[i]++;
                    }
                }
            }
        }

        for (int i = 0; i < 4; i++) {
            if (hitTally[i] != 2)
                return false;
        }

        return true;
    }

#endregion

#region MOVES_AND_HINTS

    void IncrementMove()
    {
        for (int i = 0; i < NUM_CUBES; i++)
            moves[i].Push(cubeStartPos[i]);

        uiMan.SetTextTopCurrent(moves[0].Count - 1);
    }

    void DecrementMove()
    {
        if (moves[0].Count == 1)
            return;

        for (int i = 0; i < NUM_CUBES; i++)
            cube[i].SetPosition((Vector2)moves[i].Pop());

        uiMan.SetTextTopCurrent(moves[0].Count - 1);
    }

    void ResetMove()
    {
        for (int i = 0; i < NUM_CUBES; i++) {
            while (moves[i].Count != 1)
                moves[i].Pop();
            cube[i].SetPosition((Vector2)moves[i].Peek());
        }

        uiMan.SetTextTopCurrent(moves[0].Count - 1);
    }

    void UpdateHintAnimation()
    {
        /* Do not handle for these touch modes they needs their own special
           handling. */
        if (touchMode == TouchMode.FLING_START_TO_PRE_END ||
                touchMode == TouchMode.FLING_PRE_END_TO_END ||
                touchMode == TouchMode.WIN)
            return;

        if (pauseEnable || !hintEnabled) {
            uiMan.SetPanelHintLRActive(false);
            return;
        }

        char hint = levelCollection.GetHint(levelAlphabetInt, levelNumber, moves[0].Count - 1);
        
        if (hint == 'U')
            uiMan.PlayPanelHintMoveUp();
        else if (hint == 'D')
            uiMan.PlayPanelHintMoveDown();
        else if (hint == 'L')
            uiMan.PlayPanelHintMoveLeft();
        else if (hint == 'R')
            uiMan.PlayPanelHintMoveRight();
    }

#endregion

#region LEVEL_HANDLING

    void SetNextLevelAsLastLevel()
    {
        if (levelNumber == levelCollection.GetNumLevelForAlphabet(levelAlphabet)) {

            /* If this is the last level within the alphabet group */

            int nextAlphabetInt = levelAlphabetInt + 1;

            if (nextAlphabetInt < LevelCollection.NUM_ALPHABETS) {
                string nextAlphabet = levelCollection.GetAlphabet(nextAlphabetInt);
                keyMan.SetLevelModeLast(levelMode);
                keyMan.SetLevelAlphabetLast(nextAlphabet);
                keyMan.SetLevelNumberLast(1);
            } else {
                /* Do nothing for the last level in the last alphabet */
            }

        } else {
            keyMan.SetLevelModeLast(levelMode);
            keyMan.SetLevelAlphabetLast(levelAlphabet);
            keyMan.SetLevelNumberLast(levelNumber + 1);
        }
    }

    void UnlockNextLevel()
    {
        if (levelNumber == levelCollection.GetNumLevelForAlphabet(levelAlphabet)) {

            /* If this is the last level within the alphabet group */

            int nextAlphabetInt = levelAlphabetInt + 1;

            if (nextAlphabetInt < LevelCollection.NUM_ALPHABETS) {
                string nextAlphabet = levelCollection.GetAlphabet(nextAlphabetInt);
                keyMan.SetLevelLocked(levelMode, nextAlphabet, 1, KeyManager.LevelLock.UNLOCKED);
            } else {
                /* Do nothing for the last level in the last alphabet */
            }

        } else {
            keyMan.SetLevelLocked(levelMode, levelAlphabet, levelNumber + 1, KeyManager.LevelLock.UNLOCKED);
        }
    }

    void LoadPreviousLevel()
    {
        keyMan.SetLevelNumber(levelNumber - 1);
        adMan.DestroyBannerAd();
        SceneManager.LoadScene("Level");
    }

    void LoadNextLevel()
    {
        keyMan.SetLevelNumber(levelNumber + 1);
        SceneManager.LoadScene("Level");
    }

#endregion

#region PANEL_TOP_BUTTONS

    public void OnButtonTopPrevPressed()
    {
        adMan.DestroyBannerAd();
        LoadPreviousLevel();
    }

    public void OnButtonTopNextPressed()
    {
        adMan.DestroyBannerAd();
        LoadNextLevel();
    }

#endregion

#region PANEL_LEFT_AND_RIGHT_BUTTONS

    public void OnButtonLRUndoPressed()
    {
        DecrementMove();
    }

    public void OnButtonLRResetPressed()
    {
        ResetMove();
    }

    public void OnButtonLRHintPressed()
    {
        if (hintEnabled) {
            uiMan.PlayPanelHintOnExit();
            uiMan.SetButtonLeftHintImage(false);
            uiMan.SetButtonRightHintImage(false);
            hintEnabled = false;
            return;
        }

        int hintCount = keyMan.GetHintCount();

        if (hintUsed || hintCount > 0) {
            
            if (!hintUsed) {
                hintCount--;
                keyMan.SetHintCount(hintCount);
                uiMan.SetTextLeftLabelHint(hintCount);
                uiMan.SetTextRightLabelHint(hintCount);
            }

            uiMan.PlayPanelHintOnEnter();
            uiMan.SetButtonLeftHintImage(true);
            uiMan.SetButtonRightHintImage(true);
            
            ResetMove();

            hintUsed = true;
            hintEnabled = true;

        } else {

            /* Handle no hint situation */
        }
    }

    public void OnButtonLRPausePressed()
    {
        pauseEnable = true;
    }

#endregion

#region PANEL_PAUSE_BUTTONS

    public void OnButtonPauseMenuPressed()
    {
        SceneManager.LoadScene("MenuLevel");
    }

    public void OnButtonPauseAudioPressed()
    {
        audioMan.OnButtonAudioPressed();
    }

    public void OnButtonPauseResumePressed()
    {
        pauseEnable = false;
    }

#endregion

#region PANEL_WIN_BUTTONS

    public void OnButtonWinMenuPressed()
    {
        if (keyMan.GetAdFree() == KeyManager.AdFree.NOT_PURCHASED) {
            uiMan.SetPanelAdActiveTrue();
            adMan.DestroyBannerAd();
            adMan.RequestInterstitialAd();
            if (levelMode == LevelCollection.LEVEL_MODE_DAILY)
                sceneAfterInterstitialAd = "MenuMain";
            else
                sceneAfterInterstitialAd = "MenuLevel";
            touchMode = TouchMode.ADS_INTERSTITIAL;
        } else {
            if (levelMode == LevelCollection.LEVEL_MODE_DAILY)
                SceneManager.LoadScene("MenuMain");
            else
                SceneManager.LoadScene("MenuLevel");
        }
    }

    public void OnButtonWinHintAdPressed()
    {
        uiMan.SetPanelAdActiveTrue();
        adMan.ClearRewardReceived();
        adMan.RequestRewardedAd();
        modeAfterRewardedAd = TouchMode.WIN;
        touchMode = TouchMode.ADS_REWARDED;
    }

    public void OnButtonWinNextPressed()
    {
        if (keyMan.GetAdFree() == KeyManager.AdFree.NOT_PURCHASED) {
            uiMan.SetPanelAdActiveTrue();
            adMan.DestroyBannerAd();
            adMan.RequestInterstitialAd();
            sceneAfterInterstitialAd = "Level";
            touchMode = TouchMode.ADS_INTERSTITIAL;
        } else {
            adMan.DestroyBannerAd();
            LoadNextLevel();
        }
    }

    public void OnButtonWinReplayPressed()
    {
        if (keyMan.GetAdFree() == KeyManager.AdFree.NOT_PURCHASED) {
            uiMan.SetPanelAdActiveTrue();
            adMan.DestroyBannerAd();
            adMan.RequestInterstitialAd();
            sceneAfterInterstitialAd = "ThisLevel";
            touchMode = TouchMode.ADS_INTERSTITIAL;
        } else {
            adMan.DestroyBannerAd();
            SceneManager.LoadScene("Level");
        }
    }

#endregion

#region STORE_BUTTONS

    public void OnButtonStoreHintAdPressed()
    {
        uiMan.SetPanelAdActiveTrue();
        adMan.ClearRewardReceived();
        adMan.RequestRewardedAd();
        modeAfterRewardedAd = TouchMode.NONE;
        touchMode = TouchMode.ADS_REWARDED;
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

    /* Play Button Audio */

    public void PlayButtonAudio()
    {
        audioMan.PlayButtonAudio();
    }


}
