using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelCollection : MonoBehaviour
{
    public const int NUM_MODES = 3;

    public const string LEVEL_MODE_RELAX = "Relax";
    public const string LEVEL_MODE_STAR = "Star";
    public const string LEVEL_MODE_DAILY = "Daily";

    string[] LEVEL_MODE = new string[] {
        LEVEL_MODE_RELAX,
        LEVEL_MODE_STAR,
        LEVEL_MODE_DAILY
    };

    public const int NUM_ALPHABETS = 5;

    public const string LEVEL_ALPHABET_DEMO = "Demo";
    public const string LEVEL_ALPHABET_ALPHA = "Alpha";
    public const string LEVEL_ALPHABET_BRAVO = "Bravo";
    public const string LEVEL_ALPHABET_CHARLIE = "Charlie";
    public const string LEVEL_ALPHABET_DELTA = "Delta";

    string[] LEVEL_ALPHABET = new string[] 
    {   LEVEL_ALPHABET_DEMO,
        LEVEL_ALPHABET_ALPHA,
        LEVEL_ALPHABET_BRAVO,
        LEVEL_ALPHABET_CHARLIE,
        LEVEL_ALPHABET_DELTA
    };

    Level[] level;

    LevelDemo levelDemo;
    LevelAlpha levelAlpha;
    LevelBravo levelBravo;
    LevelCharlie levelCharlie;
    LevelDelta levelDelta;

    void Awake()
    {
        level = new Level[NUM_ALPHABETS];

        level[0] = GameObject.Find("LevelCollection").GetComponent<LevelDemo>();
        level[1] = GameObject.Find("LevelCollection").GetComponent<LevelAlpha>();
        level[2] = GameObject.Find("LevelCollection").GetComponent<LevelBravo>();
        level[3] = GameObject.Find("LevelCollection").GetComponent<LevelCharlie>();
        level[4] = GameObject.Find("LevelCollection").GetComponent<LevelDelta>();
    }

    /* Mode */

    public string GetMode(int index)
    {
        return LEVEL_MODE[index];
    }

    public int GetMode(string mode)
    {
        for (int i = 0; i < NUM_MODES; i++) {
            if (LEVEL_MODE[i] == mode)
                return i;
        }
        return 0;
    }

    /* Alphabet */

    public string GetAlphabet(int index)
    {
        return LEVEL_ALPHABET[index];
    }

    public int GetAlphabet(string alphabet)
    {
        for (int i = 0; i < NUM_ALPHABETS; i++) {
            if (LEVEL_ALPHABET[i] == alphabet)
                return i;
        }
        return 0;
    }

    /* Num Levels */

    public int GetNumLevelForAlphabet(string alphabet)
    {
        return level[GetAlphabet(alphabet)].GetTotalLevels();
    }

    public int GetNumLevelForAllAlphabets()
    {
        int ret = 0;

        for (int i = 0; i < NUM_ALPHABETS; i++)
            ret += level[i].GetTotalLevels();
        
        return ret;
    }

    /* Star */

    public int GetNumStarsPerLevel(string mode)
    {
        if (mode == LEVEL_MODE_RELAX)
            return 1;
        else if (mode == LEVEL_MODE_STAR)
            return 3;

        return 0;
    }

    /* Data */

    public int GetBoardSize(int alphabet, int num)
    {
        return level[alphabet].data[num].size;
    }

    public int GetBound(int alphabet, int num, int row, int col)
    {
        return level[alphabet].data[num].bound[row, col];
    }

    public int Get3StarMoves(int alphabet, int num)
    {
        return level[alphabet].data[num].stars[Level.DATA_STAR_3_INDEX];
    }

    public int Get2StarMoves(int alphabet, int num)
    {
        return level[alphabet].data[num].stars[Level.DATA_STAR_2_INDEX];
    }

    public char GetHint(int alphabet, int num, int index)
    {
        return level[alphabet].data[num].hint[index];
    }

}
