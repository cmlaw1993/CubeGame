using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelDelta : Level
{
    public LevelDelta()
    {
        data = new Data[] {

            /* Level 0 */   new Data() {

                                size =  64,

                                bound = new sbyte[,] {
                                            { 8, 8, 8, 8, 8, 8, 8, 8, 8, 8 },
                                            { 8, X, X, X, X, X, X, X, X, 8 },
                                            { 8, X, 0, 0, 0, 0, 0, 0, X, 8 },
                                            { 8, X, 0, A, 0, 0, C, 0, X, 8 },
                                            { 8, X, 0, 0, 0, 0, 0, 0, X, 8 },
                                            { 8, X, 0, 0, 0, 0, 0, 0, X, 8 },
                                            { 8, X, 0, B, 0, 0, D, 0, X, 8 },
                                            { 8, X, 0, 0, 0, 0, 0, 0, X, 8 },
                                            { 8, X, X, X, X, X, X, X, X, 8 },
                                            { 8, 8, 8, 8, 8, 8, 8, 8, 8, 8 }
                                        },

                                hint =  new char[]                  { 'U','R' },

                                stars = new sbyte[DATA_STAR_SIZE]   { 1, 2 },
                            },
            
            

        };
    }
}