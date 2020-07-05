using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    public enum Difficulty
    {
        EASY = 0,
        MEDIUM = 1,
        HARD = 2
    }

    KeyManager keyMan;

    string fullName;
    int number;
    Difficulty difficulty;
    string difficultyString;

    Level level;

    int size;
    sbyte[,] bound;
    char[] hint;
    sbyte[] stars;

    /* Awake is called before start.  LevelManager implements awake as
       it needs to have priority over the others who doesn't. */

    void Awake()
    {
        // keyMan = GameObject.Find("KeyManager").GetComponent<KeyManager>();

        // /* Name, Number, Difficulty */

        // difficultyString = keyMan.GetLevelDifficulty();
        // number = keyMan.GetLevelNumber();

        // fullName = difficultyString + " - " + number;

        // if (difficultyString == "Easy")
        //     difficulty = Difficulty.EASY;
        // else if (difficultyString == "Medium")
        //     difficulty = Difficulty.MEDIUM;
        // else if (difficultyString == "Hard")
        //     difficulty = Difficulty.HARD;

        // /* Level */

        // if (difficulty == Difficulty.EASY)
        //     level = GameObject.Find("LevelEasy").GetComponent<LevelEasy>();
        // else if (difficulty == Difficulty.MEDIUM)
        //     level = GameObject.Find("LevelMedium").GetComponent<LevelMedium>();
        // else if (difficulty == Difficulty.HARD)
        //     level = GameObject.Find("LevelHard").GetComponent<LevelHard>();
        
        // /* Size, Bound, Hint, Stars */

        // size = level.data[number].size;

        // bound = new sbyte[Level.DATA_BOUND_ROW_SIZE, Level.DATA_BOUND_COL_SIZE];
        // for (int i = 0; i < Level.DATA_BOUND_ROW_SIZE; i++)
        //     for (int j = 0; j < Level.DATA_BOUND_COL_SIZE; j++)
        //         bound[i, j] = level.data[number].bound[i, j];

        // hint = new char[level.data[number].hint.Length];
        // for (int i = 0; i < hint.Length; i++)
        //     hint[i] = level.data[number].hint[i];

        // stars = new sbyte[Level.DATA_STAR_SIZE];
        // for (int i = 0; i < Level.DATA_STAR_SIZE; i++)
        //     stars[i] = level.data[number].stars[i];
    }

    public string GetFullName()
    {
        return fullName;
    }

    public int GetNumber()
    {
        return number;
    }

    public Difficulty GetDifficulty()
    {
        return difficulty;
    }

    public string GetDifficultyString()
    {
       return difficultyString;
    }

    public int GetSize()
    {
        return size;
    }

    public sbyte GetBound(int row, int col)
    {
        return 0;
//        return bound[row, col];
    }

    public char GetHint(int index)
    {
        return 'A';
      //  return hint[index];
    }

    public int GetStars3()
    {
        return 0;
       // return (int)stars[Level.DATA_STAR_3_INDEX];
    }

    public int GetStars2()
    {
        return 0;
      //  return (int)stars[Level.DATA_STAR_2_INDEX];
    }

    public int GetLevelStars()
    {
        return 0;
   //     return keyMan.GetLevelStars(difficultyString, number);
    }

    public void SetLevelStars(int val)
    {
    //    keyMan.SetLevelStars(difficultyString, number, val);
    }

    public int GetLevelMoves()
    {
        return 0;
   //     return keyMan.GetLevelMoves(difficultyString, number);
    }

    public void SetLevelMoves(int val)
    {
    //    keyMan.SetLevelMoves(difficultyString, number, val);
    }

    public int GetLastLevelNumber()
    {
        return 0;
     //   return level.data.Length - 1;
    }

}
