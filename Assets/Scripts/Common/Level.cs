using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level : MonoBehaviour
{
    KeyManager keyMan;

    /* Data */

    protected const sbyte X = 1;
    protected const sbyte A = 2;
    protected const sbyte B = 3;
    protected const sbyte C = 4;
    protected const sbyte D = 5;

    public const sbyte DATA_BOUND_EMPTY = 0;
    public const sbyte DATA_BOUND_BOUND = X;
    public const sbyte DATA_BOUND_CUBE_RED = A;
    public const sbyte DATA_BOUND_CUBE_GREEN = B;
    public const sbyte DATA_BOUND_CUBE_BLUE = C;
    public const sbyte DATA_BOUND_CUBE_YELLOW = D;

    public const int DATA_BOUND_ROW_SIZE = 10;
    public const int DATA_BOUND_COL_SIZE = 10;

    public const int DATA_STAR_SIZE = 2;
    public const int DATA_STAR_3_INDEX = 0;
    public const int DATA_STAR_2_INDEX = 1;

    public struct Data {
        public int size;
        public sbyte[,] bound;      /* Row, Col */
        public char[] hint;
        public sbyte[] stars;       /* 3 stars, 2 stars */
    }

    public Data[] data;

    /* Misc */

    public const int BOUND_64_ROW_SIZE = 8;
    public const int BOUND_64_COL_SIZE = 8;

    public const int BOUND_100_ROW_SIZE = 10;
    public const int BOUND_100_COL_SIZE = 10;

    public const int STAR_NUM = 3;

    /* Utility Methods */

    public int GetTotalLevels()
    {
        /* Minus 1 for index 0 */
        return data.Length - 1;
    }

    public int GetTotalStars()
    {
        return 3 * GetTotalLevels();
    }
}
