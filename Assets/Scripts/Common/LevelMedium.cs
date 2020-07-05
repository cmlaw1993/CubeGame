using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelMedium : Level
{
    public LevelMedium()
    {
        data = new Data[] {

            /* Level 0 */   new Data() {

                                size =  100,

                                bound = new sbyte[,] {
                                            { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                                            { 0, 0, A, 0, 0, 0, 0, D, 0, 0 },
                                            { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                                            { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                                            { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                                            { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                                            { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                                            { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                                            { 0, 0, B, 0, 0, 0, 0, C, 0, 0 },
                                            { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }
                                        },

                                hint =  new char[]                  { 'U','L' },

                                stars = new sbyte[DATA_STAR_SIZE]   { 2, 3 },
                            },

            /* Level 1 */   new Data() {

                                size =  64,

                                bound = new sbyte[,] {
                                            { 8, 8, 8, 8, 8, 8, 8, 8, 8, 8 },
                                            { 8, X, X, X, X, X, X, X, X, 8 },
                                            { 8, X, 0, X, X, 0, A, 0, X, 8 },
                                            { 8, X, 0, X, 0, C, 0, D, X, 8 },
                                            { 8, X, X, X, 0, 0, B, 0, X, 8 },
                                            { 8, X, X, 0, 0, 0, 0, X, X, 8 },
                                            { 8, X, 0, 0, 0, X, X, X, X, 8 },
                                            { 8, X, 0, 0, X, X, 0, 0, X, 8 },
                                            { 8, X, X, X, X, X, X, X, X, 8 },
                                            { 8, 8, 8, 8, 8, 8, 8, 8, 8, 8 }
                                        },

                                hint =  new char[]                  { 'L','D','L','D','L','D' },

                                stars = new sbyte[DATA_STAR_SIZE]   { 6, 7 },
                            },
        };
    }
}

