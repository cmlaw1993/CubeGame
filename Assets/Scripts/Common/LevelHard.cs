using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelHard : Level
{
    public LevelHard()
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

            /* Level 1 */   new Data() {       /** diabolical */

                                size =  100,

                                bound = new sbyte[,] {
                                            { X, X, X, X, X, X, X, X, X, X },
                                            { X, 0, 0, X, X, X, 0, A, 0, X },
                                            { 0, 0, 0, X, X, 0, C, 0, B, X },
                                            { 0, 0, X, X, X, 0, 0, D, 0, X },
                                            { 0, X, X, X, 0, 0, 0, 0, X, X },
                                            { 0, X, X, 0, 0, 0, X, X, X, X },
                                            { 0, 0, 0, 0, 0, X, X, X, 0, 0 },
                                            { 0, 0, 0, 0, X, X, X, 0, 0, 0 },
                                            { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                                            { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }
                                        },

                                hint =  new char[]                  { 'D','L','D','R','U','R','U' },

                                stars = new sbyte[DATA_STAR_SIZE]   { 7, 10 },
                            },
        };
    }
}

