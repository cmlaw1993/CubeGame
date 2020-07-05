using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelEasy : Level
{
    public LevelEasy()
    {
        data = new Data[] {

            /* Level 0 */   new Data() {

                                size =  64,

                                // bound = new sbyte[,] {
                                //             { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                                //             { 0, X, A, 0, 0, 0, 0, D, X, 0 },
                                //             { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                                //             { 0, X, 0, 0, X, 0, X, 0, X, 0 },
                                //             { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                                //             { 0, 0, 0, 0, X, 0, X, 0, 0, 0 },
                                //             { 0, X, 0, 0, 0, 0, 0, 0, X, 0 },
                                //             { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                                //             { 0, X, B, 0, 0, 0, 0, C, X, 0 },
                                //             { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }
                                //         },

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

                                hint =  new char[]                  { 'U' },

                                stars = new sbyte[DATA_STAR_SIZE]   { 1, 2 },
                            },

// 9
#region EMPTY_TYPE

            /* Level X */   new Data() {        /* QA OK */

                                size =  64,

                                bound = new sbyte[,] {
                                            { 8, 8, 8, 8, 8, 8, 8, 8, 8, 8 },
                                            { 8, X, X, 0, A, 0, X, X, X, 8 },
                                            { 8, X, X, 0, 0, 0, X, X, X, 8 },
                                            { 8, 0, 0, 0, B, 0, X, X, X, 8 },
                                            { 8, 0, 0, 0, 0, 0, 0, 0, 0, 8 },
                                            { 8, X, 0, 0, 0, 0, C, 0, D, 8 },
                                            { 8, X, 0, 0, 0, 0, 0, 0, X, 8 },
                                            { 8, 0, 0, 0, 0, 0, 0, X, X, 8 },
                                            { 8, 0, 0, 0, 0, 0, 0, X, X, 8 },
                                            { 8, 8, 8, 8, 8, 8, 8, 8, 8, 8 }
                                        },

                                hint =  new char[]                  { 'R','D','L','D' },

                                stars = new sbyte[DATA_STAR_SIZE]   { 4, 6 },
                            },

            /* Level X */   new Data() {        /* QA OK */

                                size =  64,

                                bound = new sbyte[,] {
                                            { 8, 8, 8, 8, 8, 8, 8, 8, 8, 8 },
                                            { 8, X, X, 0, X, X, X, X, X, 8 },
                                            { 8, X, 0, 0, 0, X, X, X, X, 8 },
                                            { 8, X, 0, 0, 0, 0, 0, X, X, 8 },
                                            { 8, X, 0, 0, 0, 0, 0, X, X, 8 },
                                            { 8, X, A, 0, 0, 0, 0, 0, X, 8 },
                                            { 8, X, X, B, 0, 0, 0, 0, X, 8 },
                                            { 8, X, X, X, C, D, X, X, X, 8 },
                                            { 8, X, X, X, X, X, X, X, X, 8 },
                                            { 8, 8, 8, 8, 8, 8, 8, 8, 8, 8 }
                                        },

                                hint =  new char[]                  { 'U','L','D','R','D' },

                                stars = new sbyte[DATA_STAR_SIZE]   { 5, 6 },
                            },

            /* Level X */   new Data() {        /* QA OK */

                                size =  64,

                                bound = new sbyte[,] {
                                            { 8, 8, 8, 8, 8, 8, 8, 8, 8, 8 },
                                            { 8, X, X, X, X, X, X, X, X, 8 },
                                            { 8, X, X, 0, 0, X, 0, X, X, 8 },
                                            { 8, X, X, 0, 0, 0, 0, 0, X, 8 },
                                            { 8, X, X, 0, 0, 0, 0, 0, X, 8 },
                                            { 8, X, X, 0, 0, 0, 0, 0, X, 8 },
                                            { 8, X, 0, 0, 0, 0, 0, X, X, 8 },
                                            { 8, X, A, B, C, D, 0, 0, X, 8 },
                                            { 8, X, X, X, X, X, X, X, X, 8 },
                                            { 8, 8, 8, 8, 8, 8, 8, 8, 8, 8 }
                                        },

                                hint =  new char[]                  { 'U','R','D','R','U','R','D','L','D' },

                                stars = new sbyte[DATA_STAR_SIZE]   { 9, 10 },
                            },

            /* Level X */   new Data() {        /* QA OK */

                                size =  64,

                                bound = new sbyte[,] {
                                            { 8, 8, 8, 8, 8, 8, 8, 8, 8, 8 },
                                            { 8, X, X, X, X, X, X, X, X, 8 },
                                            { 8, X, 0, 0, 0, X, 0, X, X, 8 },
                                            { 8, X, 0, 0, 0, 0, 0, 0, X, 8 },
                                            { 8, X, A, 0, 0, 0, 0, 0, X, 8 },
                                            { 8, X, 0, B, 0, 0, 0, 0, X, 8 },
                                            { 8, X, 0, 0, C, 0, 0, 0, X, 8 },
                                            { 8, X, 0, 0, 0, D, 0, X, X, 8 },
                                            { 8, X, X, X, X, X, X, X, X, 8 },
                                            { 8, 8, 8, 8, 8, 8, 8, 8, 8, 8 }
                                        },

                                hint =  new char[]                  { 'U','R','D','R','U','R','D','L' },

                                stars = new sbyte[DATA_STAR_SIZE]   { 8, 10 },
                            },

            /* Level X */   new Data() {        /* QA OK */

                                size =  64,

                                bound = new sbyte[,] {
                                            { 8, 8, 8, 8, 8, 8, 8, 8, 8, 8 },
                                            { 8, X, X, X, X, X, X, X, X, 8 },
                                            { 8, X, 0, 0, A, 0, B, 0, X, 8 },
                                            { 8, X, 0, 0, 0, 0, 0, 0, X, 8 },
                                            { 8, X, 0, C, X, 0, X, D, X, 8 },
                                            { 8, X, 0, 0, 0, 0, 0, 0, X, 8 },
                                            { 8, X, 0, 0, 0, 0, 0, 0, X, 8 },
                                            { 8, X, 0, 0, 0, 0, 0, 0, X, 8 },
                                            { 8, X, X, X, X, X, X, X, X, 8 },
                                            { 8, 8, 8, 8, 8, 8, 8, 8, 8, 8 }
                                        },

                                hint =  new char[]                  { 'D','L','D' },

                                stars = new sbyte[DATA_STAR_SIZE]   { 3, 4 },
                            },

            /* Level X */   new Data() {        /* QA OK */

                                size =  64,

                                bound = new sbyte[,] {
                                            { 8, 8, 8, 8, 8, 8, 8, 8, 8, 8 },
                                            { 8, X, X, X, X, X, X, X, X, 8 },
                                            { 8, X, 0, 0, 0, 0, 0, X, X, 8 },
                                            { 8, X, 0, 0, 0, 0, 0, 0, X, 8 },
                                            { 8, X, 0, 0, 0, 0, 0, 0, X, 8 },
                                            { 8, X, 0, 0, 0, 0, 0, A, X, 8 },
                                            { 8, X, C, 0, 0, 0, 0, X, X, 8 },
                                            { 8, X, D, 0, 0, 0, B, X, X, 8 },
                                            { 8, X, X, X, X, X, X, X, X, 8 },
                                            { 8, 8, 8, 8, 8, 8, 8, 8, 8, 8 }
                                        },

                                hint =  new char[]                  { 'U','L' },

                                stars = new sbyte[DATA_STAR_SIZE]   { 2, 3 },
                            },

            /* Level X */   new Data() {        /* QA OK */

                                size =  64,

                                bound = new sbyte[,] {
                                            { 8, 8, 8, 8, 8, 8, 8, 8, 8, 8 },
                                            { 8, X, X, X, X, X, X, X, X, 8 },
                                            { 8, X, 0, 0, 0, 0, 0, 0, X, 8 },
                                            { 8, X, 0, A, 0, B, 0, 0, X, 8 },
                                            { 8, X, 0, 0, 0, 0, 0, 0, X, 8 },
                                            { 8, X, 0, 0, 0, 0, 0, 0, X, 8 },
                                            { 8, X, 0, 0, 0, C, 0, D, X, 8 },
                                            { 8, X, 0, 0, 0, 0, 0, 0, X, 8 },
                                            { 8, X, X, X, X, X, X, X, X, 8 },
                                            { 8, 8, 8, 8, 8, 8, 8, 8, 8, 8 }
                                        },

                                hint =  new char[]                  { 'L','U' },

                                stars = new sbyte[DATA_STAR_SIZE]   { 2, 3 },
                            },

            /* Level X */   new Data() {        /* QA OK */

                                size =  64,

                                bound = new sbyte[,] {
                                            { 8, 8, 8, 8, 8, 8, 8, 8, 8, 8 },
                                            { 8, X, X, X, X, X, X, X, X, 8 },
                                            { 8, X, X, X, X, X, X, X, X, 8 },
                                            { 8, X, A, 0, 0, 0, 0, C, X, 8 },
                                            { 8, X, 0, 0, 0, 0, 0, 0, X, 8 },
                                            { 8, X, 0, 0, 0, 0, 0, 0, X, 8 },
                                            { 8, X, B, 0, 0, 0, 0, D, X, 8 },
                                            { 8, X, X, X, X, X, X, X, X, 8 },
                                            { 8, X, X, X, X, X, X, X, X, 8 },
                                            { 8, 8, 8, 8, 8, 8, 8, 8, 8, 8 }
                                        },

                                hint =  new char[]                  { 'U','R' },

                                stars = new sbyte[DATA_STAR_SIZE]   { 2, 3 },
                            },

            /* Level X */   new Data() {        /* QA OK */

                                size =  64,

                                bound = new sbyte[,] {
                                            { 8, 8, 8, 8, 8, 8, 8, 8, 8, 8 },
                                            { 8, X, X, X, X, X, X, X, X, 8 },
                                            { 8, X, X, X, X, X, X, X, X, 8 },
                                            { 8, X, 0, 0, 0, 0, 0, 0, X, 8 },
                                            { 8, X, 0, A, 0, 0, C, 0, X, 8 },
                                            { 8, X, 0, B, 0, 0, D, 0, X, 8 },
                                            { 8, X, 0, 0, 0, 0, 0, 0, X, 8 },
                                            { 8, X, X, X, X, X, X, X, X, 8 },
                                            { 8, X, X, X, X, X, X, X, X, 8 },
                                            { 8, 8, 8, 8, 8, 8, 8, 8, 8, 8 }
                                        },

                                hint =  new char[]                  { 'R' },

                                stars = new sbyte[DATA_STAR_SIZE]   { 1, 2 },
                            },

#endregion

// 25
#region L_U_Z_TYPE

            /* Level X */   new Data() {        /* QA OK */

                                size =  64,

                                bound = new sbyte[,] {
                                            { 8, 8, 8, 8, 8, 8, 8, 8, 8, 8 },
                                            { 8, X, X, X, X, X, X, X, X, 8 },
                                            { 8, X, X, X, X, X, 0, B, X, 8 },
                                            { 8, X, X, X, X, X, 0, C, X, 8 },
                                            { 8, X, X, X, X, X, A, D, X, 8 },
                                            { 8, X, X, X, X, X, 0, 0, X, 8 },
                                            { 8, X, 0, 0, 0, 0, 0, 0, X, 8 },
                                            { 8, X, 0, 0, 0, 0, 0, X, X, 8 },
                                            { 8, X, X, X, X, X, X, X, X, 8 },
                                            { 8, 8, 8, 8, 8, 8, 8, 8, 8, 8 }
                                        },

                                hint =  new char[]                  { 'D','L','D','L' },

                                stars = new sbyte[DATA_STAR_SIZE]   { 4, 5 },
                            },

            /* Level X */   new Data() {        /* QA OK */

                                size =  64,

                                bound = new sbyte[,] {
                                            { 8, 8, 8, 8, 8, 8, 8, 8, 8, 8 },
                                            { 8, A, 0, 0, 0, X, 0, 0, 0, 8 },
                                            { 8, B, 0, 0, X, X, 0, 0, 0, 8 },
                                            { 8, 0, X, X, X, 0, 0, X, 0, 8 },
                                            { 8, 0, 0, 0, X, 0, 0, X, 0, 8 },
                                            { 8, 0, 0, 0, X, 0, X, X, 0, 8 },
                                            { 8, X, 0, X, X, 0, X, X, 0, 8 },
                                            { 8, X, 0, 0, 0, 0, X, C, 0, 8 },
                                            { 8, X, 0, 0, 0, 0, X, D, 0, 8 },
                                            { 8, 8, 8, 8, 8, 8, 8, 8, 8, 8 }
                                        },

                                hint =  new char[]                  { 'R','U','L','D','L','D','L','U','L','U','R','U','L','U','R','D','L' },

                                stars = new sbyte[DATA_STAR_SIZE]   { 17, 19 },
                            },

            /* Level X */   new Data() {        /* QA OK */

                                size =  64,

                                bound = new sbyte[,] {
                                            { 8, 8, 8, 8, 8, 8, 8, 8, 8, 8 },
                                            { 8, A, 0, X, X, X, 0, 0, 0, 8 },
                                            { 8, B, 0, X, X, 0, 0, 0, 0, 8 },
                                            { 8, 0, X, X, X, 0, 0, X, 0, 8 },
                                            { 8, 0, 0, X, X, 0, 0, X, 0, 8 },
                                            { 8, 0, 0, 0, X, 0, X, X, 0, 8 },
                                            { 8, X, 0, 0, X, 0, X, X, 0, 8 },
                                            { 8, X, 0, 0, 0, 0, X, C, 0, 8 },
                                            { 8, X, 0, 0, 0, 0, X, D, 0, 8 },
                                            { 8, 8, 8, 8, 8, 8, 8, 8, 8, 8 }
                                        },

                                hint =  new char[]                  { 'D','R','D','R','U','R','U','R' },

                                stars = new sbyte[DATA_STAR_SIZE]   { 8, 9 },
                            },

            /* Level X */   new Data() {        /* QA OK */

                                size =  64,

                                bound = new sbyte[,] {
                                            { 8, 8, 8, 8, 8, 8, 8, 8, 8, 8 },
                                            { 8, A, 0, 0, X, X, 0, C, 0, 8 },
                                            { 8, B, 0, 0, X, X, 0, D, 0, 8 },
                                            { 8, X, X, 0, X, 0, 0, X, 0, 8 },
                                            { 8, X, 0, 0, X, 0, 0, X, 0, 8 },
                                            { 8, X, 0, 0, X, 0, 0, X, 0, 8 },
                                            { 8, X, 0, X, X, 0, 0, X, 0, 8 },
                                            { 8, X, 0, 0, 0, 0, X, 0, 0, 8 },
                                            { 8, X, 0, 0, 0, 0, X, 0, 0, 8 },
                                            { 8, 8, 8, 8, 8, 8, 8, 8, 8, 8 }
                                        },

                                hint =  new char[]                  { 'L','D','R','D','L','D','R' },

                                stars = new sbyte[DATA_STAR_SIZE]   { 7, 9 },
                            },

            /* Level X */   new Data() {        /* QA OK */

                                size =  64,

                                bound = new sbyte[,] {
                                            { 8, 8, 8, 8, 8, 8, 8, 8, 8, 8 },
                                            { 8, 0, 0, 0, 0, 0, 0, 0, 0, 8 },
                                            { 8, 0, 0, X, X, X, X, C, D, 8 },
                                            { 8, 0, 0, 0, 0, X, X, X, X, 8 },
                                            { 8, X, X, 0, 0, X, X, 0, 0, 8 },
                                            { 8, X, X, 0, 0, 0, 0, 0, 0, 8 },
                                            { 8, X, X, X, X, X, X, 0, 0, 8 },
                                            { 8, X, X, 0, 0, 0, 0, 0, 0, 8 },
                                            { 8, A, B, 0, 0, X, X, X, X, 8 },
                                            { 8, 8, 8, 8, 8, 8, 8, 8, 8, 8 }
                                        },

                                hint =  new char[]                  { 'U','L','D','R','D','R','U','R','D' },

                                stars = new sbyte[DATA_STAR_SIZE]   { 9, 10 },
                            },

            /* Level X */   new Data() {        /* QA OK */

                                size =  64,

                                bound = new sbyte[,] {
                                            { 8, 8, 8, 8, 8, 8, 8, 8, 8, 8 },
                                            { 8, 0, 0, 0, 0, 0, 0, 0, 0, 8 },
                                            { 8, 0, 0, X, X, X, X, C, D, 8 },
                                            { 8, 0, 0, X, X, X, X, X, X, 8 },
                                            { 8, 0, 0, X, X, X, X, X, X, 8 },
                                            { 8, 0, 0, 0, 0, 0, 0, 0, 0, 8 },
                                            { 8, X, X, X, X, X, X, 0, 0, 8 },
                                            { 8, X, X, 0, 0, 0, 0, 0, 0, 8 },
                                            { 8, A, B, 0, 0, X, X, X, X, 8 },
                                            { 8, 8, 8, 8, 8, 8, 8, 8, 8, 8 }
                                        },

                                hint =  new char[]                  { 'R','U','R','U','L','D' },

                                stars = new sbyte[DATA_STAR_SIZE]   { 6, 7 },
                            },

            /* Level X */   new Data() {        /* QA OK */

                                size =  64,

                                bound = new sbyte[,] {
                                            { 8, 8, 8, 8, 8, 8, 8, 8, 8, 8 },
                                            { 8, X, 0, 0, 0, 0, 0, D, X, 8 },
                                            { 8, X, 0, 0, 0, 0, 0, X, X, 8 },
                                            { 8, X, 0, 0, 0, 0, X, X, X, 8 },
                                            { 8, X, 0, 0, B, 0, 0, X, X, 8 },
                                            { 8, X, X, 0, 0, C, 0, 0, X, 8 },
                                            { 8, X, X, X, 0, 0, 0, 0, X, 8 },
                                            { 8, X, X, 0, 0, 0, 0, 0, X, 8 },
                                            { 8, X, A, 0, 0, 0, 0, 0, X, 8 },
                                            { 8, 8, 8, 8, 8, 8, 8, 8, 8, 8 }
                                        },

                                hint =  new char[]                  { 'U','L','D','R','D' },

                                stars = new sbyte[DATA_STAR_SIZE]   { 5, 6 },
                            },

            /* Level X */   new Data() {        /* QA OK */

                                size =  64,

                                bound = new sbyte[,] {
                                            { 8, 8, 8, 8, 8, 8, 8, 8, 8, 8 },
                                            { 8, X, X, 0, 0, 0, C, D, X, 8 },
                                            { 8, X, 0, 0, 0, 0, 0, X, X, 8 },
                                            { 8, X, 0, 0, 0, 0, X, X, X, 8 },
                                            { 8, X, 0, 0, 0, 0, 0, X, X, 8 },
                                            { 8, X, X, 0, 0, 0, 0, 0, X, 8 },
                                            { 8, X, X, X, 0, 0, 0, 0, X, 8 },
                                            { 8, X, X, 0, 0, 0, 0, 0, X, 8 },
                                            { 8, X, A, B, 0, 0, 0, 0, X, 8 },
                                            { 8, 8, 8, 8, 8, 8, 8, 8, 8, 8 }
                                        },

                                hint =  new char[]                  { 'D','L','D','R','D' },

                                stars = new sbyte[DATA_STAR_SIZE]   { 5, 6 },
                            },

            /* Level X */   new Data() {        /* QA OK */

                                size =  64,

                                bound = new sbyte[,] {
                                            { 8, 8, 8, 8, 8, 8, 8, 8, 8, 8 },
                                            { 8, X, 0, 0, 0, 0, 0, 0, X, 8 },
                                            { 8, X, 0, 0, 0, 0, X, X, X, 8 },
                                            { 8, X, 0, 0, 0, 0, X, X, X, 8 },
                                            { 8, X, X, X, 0, 0, 0, 0, X, 8 },
                                            { 8, X, X, X, 0, 0, 0, 0, X, 8 },
                                            { 8, X, X, X, 0, 0, 0, 0, X, 8 },
                                            { 8, X, 0, 0, 0, 0, 0, 0, X, 8 },
                                            { 8, X, A, B, C, D, 0, 0, X, 8 },
                                            { 8, 8, 8, 8, 8, 8, 8, 8, 8, 8 }
                                        },

                                hint =  new char[]                  { 'U','R','U','L','U' },

                                stars = new sbyte[DATA_STAR_SIZE]   { 5, 6 },
                            },

            /* Level X */   new Data() {

                                size =  64,

                                bound = new sbyte[,] {
                                            { 8, 8, 8, 8, 8, 8, 8, 8, 8, 8 },
                                            { 8, X, X, X, X, X, X, 0, 0, 8 },
                                            { 8, X, X, X, X, X, X, 0, 0, 8 },
                                            { 8, X, 0, 0, 0, 0, 0, 0, 0, 8 },
                                            { 8, X, X, 0, 0, 0, 0, 0, X, 8 },
                                            { 8, X, X, X, A, X, X, X, X, 8 },
                                            { 8, X, X, X, B, X, X, X, X, 8 },
                                            { 8, X, X, X, C, X, X, X, X, 8 },
                                            { 8, X, X, X, D, X, X, X, X, 8 },
                                            { 8, 8, 8, 8, 8, 8, 8, 8, 8, 8 }
                                        },

                                hint =  new char[]                  { 'U','R','U','R','U' },

                                stars = new sbyte[DATA_STAR_SIZE]   { 5, 6 },
                            },

            /* Level X */  new Data() {        /* QA OK */

                                size =  64,

                                bound = new sbyte[,] {
                                            { 8, 8, 8, 8, 8, 8, 8, 8, 8, 8 },
                                            { 8, X, X, X, X, X, X, X, X, 8 },
                                            { 8, X, X, X, 0, 0, 0, X, X, 8 },
                                            { 8, X, 0, 0, 0, 0, 0, 0, X, 8 },
                                            { 8, X, 0, D, X, X, 0, B, X, 8 },
                                            { 8, X, C, 0, X, X, A, 0, X, 8 },
                                            { 8, X, 0, 0, X, X, 0, 0, X, 8 },
                                            { 8, X, X, 0, X, X, 0, 0, X, 8 },
                                            { 8, X, X, X, X, X, X, X, X, 8 },
                                            { 8, 8, 8, 8, 8, 8, 8, 8, 8, 8 }
                                        },

                                hint =  new char[]                  { 'U','R','U','L','D','L','U' },

                                stars = new sbyte[DATA_STAR_SIZE]   { 7, 8 },
                            },

            /* Level X */   new Data() {        /* QA OK */

                                size =  64,

                                bound = new sbyte[,] {
                                            { 8, 8, 8, 8, 8, 8, 8, 8, 8, 8 },
                                            { 8, X, X, X, X, X, X, X, X, 8 },
                                            { 8, X, X, X, 0, 0, A, B, X, 8 },
                                            { 8, X, X, 0, 0, 0, 0, X, X, 8 },
                                            { 8, X, C, 0, 0, 0, X, X, X, 8 },
                                            { 8, X, D, 0, 0, 0, 0, X, X, 8 },
                                            { 8, X, X, 0, 0, 0, 0, 0, X, 8 },
                                            { 8, X, X, X, 0, 0, 0, 0, X, 8 },
                                            { 8, X, X, X, X, X, X, X, X, 8 },
                                            { 8, 8, 8, 8, 8, 8, 8, 8, 8, 8 }
                                        },

                                hint =  new char[]                  { 'R','D','L','D','R' },

                                stars = new sbyte[DATA_STAR_SIZE]   { 5, 6 },
                            },

            /* Level X */   new Data() {        /* QA OK */

                                size =  64,

                                bound = new sbyte[,] {
                                            { 8, 8, 8, 8, 8, 8, 8, 8, 8, 8 },
                                            { 8, X, X, X, X, X, X, X, X, 8 },
                                            { 8, X, X, X, 0, 0, A, B, X, 8 },
                                            { 8, X, X, 0, 0, 0, 0, X, X, 8 },
                                            { 8, X, 0, 0, 0, 0, X, X, X, 8 },
                                            { 8, X, C, 0, 0, 0, 0, X, X, 8 },
                                            { 8, X, X, D, 0, 0, 0, 0, X, 8 },
                                            { 8, X, X, X, 0, 0, 0, 0, X, 8 },
                                            { 8, X, X, X, X, X, X, X, X, 8 },
                                            { 8, 8, 8, 8, 8, 8, 8, 8, 8, 8 }
                                        },

                                hint =  new char[]                  { 'L','D','R','D', },

                                stars = new sbyte[DATA_STAR_SIZE]   { 4, 5 },
                            },

            /* Level X */  new Data() {        /* QA OK */

                                size =  64,

                                bound = new sbyte[,] {
                                            { 8, 8, 8, 8, 8, 8, 8, 8, 8, 8 },
                                            { 8, X, X, X, X, X, X, X, X, 8 },
                                            { 8, X, A, 0, 0, 0, D, X, X, 8 },
                                            { 8, X, 0, 0, C, 0, 0, 0, X, 8 },
                                            { 8, X, 0, 0, X, X, X, X, X, 8 },
                                            { 8, X, 0, 0, X, X, X, X, X, 8 },
                                            { 8, X, 0, B, X, X, X, X, X, 8 },
                                            { 8, X, X, 0, X, X, X, X, X, 8 },
                                            { 8, X, X, X, X, X, X, X, X, 8 },
                                            { 8, 8, 8, 8, 8, 8, 8, 8, 8, 8 }
                                        },

                                hint =  new char[]                  { 'D','L','U' },

                                stars = new sbyte[DATA_STAR_SIZE]   { 3, 4 },
                            },

            /* Level X */  new Data() {        /* QA OK */

                                size =  64,

                                bound = new sbyte[,] {
                                            { 8, 8, 8, 8, 8, 8, 8, 8, 8, 8 },
                                            { 8, X, X, 0, 0, 0, 0, C, X, 8 },
                                            { 8, X, X, 0, 0, 0, 0, 0, D, 8 },
                                            { 8, X, X, X, 0, 0, 0, 0, 0, 8 },
                                            { 8, X, X, X, X, X, X, 0, 0, 8 },
                                            { 8, A, B, X, X, X, X, 0, 0, 8 },
                                            { 8, 0, 0, X, X, X, X, 0, 0, 8 },
                                            { 8, 0, 0, 0, 0, 0, 0, 0, 0, 8 },
                                            { 8, X, 0, 0, 0, 0, 0, 0, X, 8 },
                                            { 8, 8, 8, 8, 8, 8, 8, 8, 8, 8 }
                                        },

                                hint =  new char[]                  { 'L','D','R','U','L','U' },

                                stars = new sbyte[DATA_STAR_SIZE]   { 6, 7 },
                            },

            /* Level X */   new Data() {        /* QA OK */

                                size =  64,

                                bound = new sbyte[,] {
                                            { 8, 8, 8, 8, 8, 8, 8, 8, 8, 8 },
                                            { 8, X, X, 0, 0, 0, 0, C, X, 8 },
                                            { 8, X, X, 0, 0, 0, 0, 0, D, 8 },
                                            { 8, X, X, X, 0, 0, 0, 0, 0, 8 },
                                            { 8, X, X, X, X, X, X, 0, 0, 8 },
                                            { 8, X, X, X, X, X, X, 0, 0, 8 },
                                            { 8, X, X, X, X, X, X, 0, 0, 8 },
                                            { 8, A, 0, 0, 0, 0, 0, 0, 0, 8 },
                                            { 8, X, B, 0, 0, 0, 0, 0, X, 8 },
                                            { 8, 8, 8, 8, 8, 8, 8, 8, 8, 8 }
                                        },

                                hint =  new char[]                  { 'R','U','L','U' },

                                stars = new sbyte[DATA_STAR_SIZE]   { 4, 5 },
                            },

            /* Level X */   new Data() {

                                size =  64,

                                bound = new sbyte[,] {
                                            { 8, 8, 8, 8, 8, 8, 8, 8, 8, 8 },
                                            { 8, X, X, X, X, X, X, X, X, 8 },
                                            { 8, X, X, X, X, X, X, X, X, 8 },
                                            { 8, A, B, C, D, X, X, X, X, 8 },
                                            { 8, X, X, 0, 0, 0, 0, X, X, 8 },
                                            { 8, X, X, X, X, 0, 0, 0, 0, 8 },
                                            { 8, X, X, X, X, X, X, 0, 0, 8 },
                                            { 8, X, X, X, X, X, X, X, X, 8 },
                                            { 8, X, X, X, X, X, X, X, X, 8 },
                                            { 8, 8, 8, 8, 8, 8, 8, 8, 8, 8 }
                                        },

                                hint =  new char[]                  { 'D','R','D','R','D','R' },

                                stars = new sbyte[DATA_STAR_SIZE]   { 6, 7 },
                            },

            /* Level X */   new Data() {        /* QA OK */

                                size =  64,

                                bound = new sbyte[,] {
                                            { 8, 8, 8, 8, 8, 8, 8, 8, 8, 8 },
                                            { 8, X, X, X, X, X, X, X, X, 8 },
                                            { 8, X, X, X, X, X, X, X, X, 8 },
                                            { 8, X, X, X, X, 0, B, X, X, 8 },
                                            { 8, X, X, X, X, A, 0, X, X, 8 },
                                            { 8, X, X, C, 0, 0, 0, X, X, 8 },
                                            { 8, X, X, 0, D, 0, 0, X, X, 8 },
                                            { 8, X, X, X, X, X, X, X, X, 8 },
                                            { 8, X, X, X, X, X, X, X, X, 8 },
                                            { 8, 8, 8, 8, 8, 8, 8, 8, 8, 8 }
                                        },

                                hint =  new char[]                  { 'U','R','U' },

                                stars = new sbyte[DATA_STAR_SIZE]   { 3, 4 },
                            },

            /* Level X */  new Data() {        /* QA OK */

                                size =  64,

                                bound = new sbyte[,] {
                                            { 8, 8, 8, 8, 8, 8, 8, 8, 8, 8 },
                                            { 8, X, X, X, X, X, X, X, X, 8 },
                                            { 8, X, X, X, X, X, X, X, X, 8 },
                                            { 8, X, X, 0, A, X, X, X, X, 8 },
                                            { 8, X, X, 0, B, X, X, X, X, 8 },
                                            { 8, X, X, 0, 0, C, D, 0, X, 8 },
                                            { 8, X, X, 0, 0, 0, 0, X, X, 8 },
                                            { 8, X, X, X, X, X, X, X, X, 8 },
                                            { 8, X, X, X, X, X, X, X, X, 8 },
                                            { 8, 8, 8, 8, 8, 8, 8, 8, 8, 8 }
                                        },

                                hint =  new char[]                  { 'R','D','L' },

                                stars = new sbyte[DATA_STAR_SIZE]   { 3, 4 },
                            },

            /* Level X */  new Data() {        /* QA OK */

                                size =  64,

                                bound = new sbyte[,] {
                                            { 8, 8, 8, 8, 8, 8, 8, 8, 8, 8 },
                                            { 8, X, X, X, X, X, X, X, X, 8 },
                                            { 8, X, X, X, X, 0, X, X, X, 8 },
                                            { 8, X, 0, A, 0, 0, X, X, X, 8 },
                                            { 8, X, 0, B, 0, 0, X, X, X, 8 },
                                            { 8, X, X, X, 0, 0, X, X, X, 8 },
                                            { 8, X, X, X, 0, C, 0, X, X, 8 },
                                            { 8, X, X, X, 0, D, 0, X, X, 8 },
                                            { 8, X, X, X, X, X, X, X, X, 8 },
                                            { 8, 8, 8, 8, 8, 8, 8, 8, 8, 8 }
                                        },

                                hint =  new char[]                  { 'R','D' },

                                stars = new sbyte[DATA_STAR_SIZE]   { 2, 3 },
                            },

            /* Level X */  new Data() {        /* QA OK */

                                size =  64,

                                bound = new sbyte[,] {
                                            { 8, 8, 8, 8, 8, 8, 8, 8, 8, 8 },
                                            { 8, X, X, X, X, X, X, X, X, 8 },
                                            { 8, X, X, X, X, X, X, 0, X, 8 },
                                            { 8, X, X, X, X, X, C, 0, X, 8 },
                                            { 8, X, 0, 0, 0, 0, 0, D, X, 8 },
                                            { 8, X, 0, B, 0, 0, 0, 0, X, 8 },
                                            { 8, X, A, 0, X, X, X, X, X, 8 },
                                            { 8, X, X, 0, X, X, X, X, X, 8 },
                                            { 8, X, X, X, X, X, X, X, X, 8 },
                                            { 8, 8, 8, 8, 8, 8, 8, 8, 8, 8 }
                                        },

                                hint =  new char[]                  { 'D','L','U' },

                                stars = new sbyte[DATA_STAR_SIZE]   { 3, 7 },
                            },

            /* Level X */  new Data() {        /* QA OK */

                                size =  64,

                                bound = new sbyte[,] {
                                            { 8, 8, 8, 8, 8, 8, 8, 8, 8, 8 },
                                            { 8, X, X, X, X, X, X, X, X, 8 },
                                            { 8, A, 0, 0, 0, X, X, X, X, 8 },
                                            { 8, 0, B, 0, 0, X, X, C, D, 8 },
                                            { 8, X, X, 0, 0, X, X, 0, 0, 8 },
                                            { 8, X, X, 0, 0, X, X, 0, 0, 8 },
                                            { 8, X, X, 0, 0, 0, 0, 0, 0, 8 },
                                            { 8, X, X, X, X, X, X, 0, 0, 8 },
                                            { 8, X, X, X, X, X, X, X, X, 8 },
                                            { 8, 8, 8, 8, 8, 8, 8, 8, 8, 8 }
                                        },

                                hint =  new char[]                  { 'D','R','D','R' },

                                stars = new sbyte[DATA_STAR_SIZE]   { 4, 5 },
                            },

            /* Level X */   new Data() {        /* QA OK */

                                size =  64,

                                bound = new sbyte[,] {
                                            { 8, 8, 8, 8, 8, 8, 8, 8, 8, 8 },
                                            { 8, X, X, X, X, X, X, X, X, 8 },
                                            { 8, X, C, D, 0, 0, 0, 0, X, 8 },
                                            { 8, X, 0, 0, 0, 0, 0, 0, X, 8 },
                                            { 8, X, X, X, X, 0, 0, 0, X, 8 },
                                            { 8, X, X, X, X, 0, 0, 0, X, 8 },
                                            { 8, X, A, 0, 0, 0, 0, 0, X, 8 },
                                            { 8, X, X, B, 0, 0, 0, X, X, 8 },
                                            { 8, X, X, X, X, X, X, X, X, 8 },
                                            { 8, 8, 8, 8, 8, 8, 8, 8, 8, 8 }
                                        },

                                hint =  new char[]                  { 'R','U' },

                                stars = new sbyte[DATA_STAR_SIZE]   { 2, 3 },
                            },

            /* Level X */  new Data() {        /* QA OK */

                                size =  64,

                                bound = new sbyte[,] {
                                            { 8, 8, 8, 8, 8, 8, 8, 8, 8, 8 },
                                            { 8, X, X, X, X, X, X, X, X, 8 },
                                            { 8, X, X, X, X, X, X, X, X, 8 },
                                            { 8, X, A, B, X, X, C, D, X, 8 },
                                            { 8, X, 0, 0, X, X, 0, 0, X, 8 },
                                            { 8, X, 0, 0, X, X, 0, 0, X, 8 },
                                            { 8, X, 0, 0, 0, 0, 0, 0, X, 8 },
                                            { 8, X, X, X, X, X, X, X, X, 8 },
                                            { 8, X, X, X, X, X, X, X, X, 8 },
                                            { 8, 8, 8, 8, 8, 8, 8, 8, 8, 8 }
                                        },

                                hint =  new char[]                  { 'D','R','U','R','U' },

                                stars = new sbyte[DATA_STAR_SIZE]   { 5, 6 },
                            },

            /* Level X */  new Data() {

                                size =  64,

                                bound = new sbyte[,] {
                                            { 8, 8, 8, 8, 8, 8, 8, 8, 8, 8 },
                                            { 8, X, X, X, X, X, X, X, X, 8 },
                                            { 8, X, X, X, X, X, X, X, X, 8 },
                                            { 8, X, X, B, X, X, X, C, X, 8 },
                                            { 8, X, 0, 0, X, X, 0, 0, X, 8 },
                                            { 8, X, 0, A, X, X, 0, D, X, 8 },
                                            { 8, X, 0, 0, 0, 0, 0, 0, X, 8 },
                                            { 8, X, X, X, X, X, X, X, X, 8 },
                                            { 8, X, X, X, X, X, X, X, X, 8 },
                                            { 8, 8, 8, 8, 8, 8, 8, 8, 8, 8 }
                                        },

                                hint =  new char[]                  { 'D','R','U','R','U' },

                                stars = new sbyte[DATA_STAR_SIZE]   { 5, 6 },
                            },

            /* Level X */   new Data() {        /* QA OK */

                                size =  64,

                                bound = new sbyte[,] {
                                            { 8, 8, 8, 8, 8, 8, 8, 8, 8, 8 },
                                            { 8, X, X, X, X, X, X, X, X, 8 },
                                            { 8, X, X, X, X, X, 0, 0, X, 8 },
                                            { 8, A, B, 0, 0, X, 0, 0, 0, 8 },
                                            { 8, X, X, 0, 0, X, C, D, 0, 8 },
                                            { 8, X, X, 0, 0, X, 0, 0, 0, 8 },
                                            { 8, X, X, 0, 0, 0, 0, X, X, 8 },
                                            { 8, X, X, X, 0, 0, 0, X, X, 8 },
                                            { 8, X, X, X, X, X, X, X, X, 8 },
                                            { 8, 8, 8, 8, 8, 8, 8, 8, 8, 8 }
                                        },

                                hint =  new char[]                  { 'R','D','R','U','L' },

                                stars = new sbyte[DATA_STAR_SIZE]   { 5, 6 },
                            },

#endregion

// 1
#region P_TYPE

            /* Level XX */   new Data() {        /* QA OK */

                                size =  64,

                                bound = new sbyte[,] {
                                            { 8, 8, 8, 8, 8, 8, 8, 8, 8, 8 },
                                            { 8, X, X, X, X, X, X, X, X, 8 },
                                            { 8, X, X, 0, 0, 0, 0, X, X, 8 },
                                            { 8, X, 0, 0, 0, 0, 0, X, X, 8 },
                                            { 8, X, 0, 0, 0, 0, X, X, X, 8 },
                                            { 8, X, 0, 0, X, X, X, X, X, 8 },
                                            { 8, X, 0, 0, 0, 0, X, X, X, 8 },
                                            { 8, X, X, A, B, C, D, 0, X, 8 },
                                            { 8, X, X, X, X, X, X, X, X, 8 },
                                            { 8, 8, 8, 8, 8, 8, 8, 8, 8, 8 }
                                        },

                                hint =  new char[]                  { 'U','L','U','R','U' },

                                stars = new sbyte[DATA_STAR_SIZE]   { 5, 8 },
                            },

#endregion

// 10
#region CORNER_STEP_TYPE

            /* Level XX */   new Data() {        /* QA OK */

                                size =  64,

                                bound = new sbyte[,] {
                                            { 8, 8, 8, 8, 8, 8, 8, 8, 8, 8 },
                                            { 8, 0, 0, 0, 0, X, X, X, X, 8 },
                                            { 8, X, X, 0, 0, X, X, X, X, 8 },
                                            { 8, X, X, 0, 0, X, X, X, X, 8 },
                                            { 8, X, X, 0, 0, X, X, X, X, 8 },
                                            { 8, 0, 0, 0, 0, A, B, C, D, 8 },
                                            { 8, 0, 0, 0, 0, X, X, X, X, 8 },
                                            { 8, X, X, 0, 0, X, X, X, X, 8 },
                                            { 8, X, 0, 0, 0, 0, 0, X, X, 8 },
                                            { 8, 8, 8, 8, 8, 8, 8, 8, 8, 8 }
                                        },

                                hint =  new char[]                  { 'L','U','L','D','R','D' },

                                stars = new sbyte[DATA_STAR_SIZE]   { 6, 7 },
                            },

            /* Level XX */   new Data() {        /* QA OK */

                                size =  64,

                                bound = new sbyte[,] {
                                            { 8, 8, 8, 8, 8, 8, 8, 8, 8, 8 },
                                            { 8, X, X, X, A, X, X, X, X, 8 },
                                            { 8, X, X, X, B, X, X, X, X, 8 },
                                            { 8, X, X, X, C, X, X, X, X, 8 },
                                            { 8, X, X, X, D, X, X, X, X, 8 },
                                            { 8, X, 0, 0, 0, 0, 0, X, X, 8 },
                                            { 8, X, 0, 0, 0, 0, 0, 0, X, 8 },
                                            { 8, X, 0, 0, 0, X, 0, 0, X, 8 },
                                            { 8, X, 0, 0, 0, X, X, X, X, 8 },
                                            { 8, 8, 8, 8, 8, 8, 8, 8, 8, 8 }
                                        },

                                hint =  new char[]                  { 'D','R','D','L','U','R','D','R' },

                                stars = new sbyte[DATA_STAR_SIZE]   { 8, 9 },
                            },

            /* Level XX */   new Data() {        /* QA OK */

                                size =  64,

                                bound = new sbyte[,] {
                                            { 8, 8, 8, 8, 8, 8, 8, 8, 8, 8 },
                                            { 8, X, X, X, X, 0, 0, X, X, 8 },
                                            { 8, X, X, X, X, 0, 0, X, X, 8 },
                                            { 8, X, X, X, X, 0, 0, X, X, 8 },
                                            { 8, A, B, C, D, 0, 0, 0, 0, 8 },
                                            { 8, X, X, X, X, 0, 0, 0, 0, 8 },
                                            { 8, X, X, X, X, 0, 0, X, X, 8 },
                                            { 8, X, X, 0, 0, 0, 0, X, X, 8 },
                                            { 8, X, X, X, 0, 0, X, X, X, 8 },
                                            { 8, 8, 8, 8, 8, 8, 8, 8, 8, 8 }
                                        },

                                hint =  new char[]                  { 'R','D','L','U','R','U' },

                                stars = new sbyte[DATA_STAR_SIZE]   { 6, 7 },
                            },

            /* Level XX */   new Data() {        /* QA OK */

                                size =  64,

                                bound = new sbyte[,] {
                                            { 8, 8, 8, 8, 8, 8, 8, 8, 8, 8 },
                                            { 8, X, X, X, X, A, X, X, X, 8 },
                                            { 8, X, X, X, X, B, X, X, X, 8 },
                                            { 8, 0, X, X, X, C, X, X, 0, 8 },
                                            { 8, 0, X, X, X, D, X, X, 0, 8 },
                                            { 8, 0, 0, 0, 0, 0, 0, 0, 0, 8 },
                                            { 8, 0, 0, 0, 0, 0, 0, 0, 0, 8 },
                                            { 8, X, X, X, 0, 0, X, X, X, 8 },
                                            { 8, X, X, X, 0, 0, X, X, X, 8 },
                                            { 8, 8, 8, 8, 8, 8, 8, 8, 8, 8 }
                                        },

                                hint =  new char[]                  { 'D','L','U','R','D','L' },

                                stars = new sbyte[DATA_STAR_SIZE]   { 6, 7 },
                            },

            /* Level XX */   new Data() {        /* QA OK */

                                size =  64,

                                bound = new sbyte[,] {
                                            { 8, 8, 8, 8, 8, 8, 8, 8, 8, 8 },
                                            { 8, X, X, X, 0, 0, X, X, X, 8 },
                                            { 8, X, X, C, 0, 0, X, X, X, 8 },
                                            { 8, X, B, 0, 0, 0, X, X, D, 8 },
                                            { 8, A, 0, 0, 0, 0, X, X, 0, 8 },
                                            { 8, 0, 0, 0, 0, 0, 0, 0, 0, 8 },
                                            { 8, 0, 0, 0, 0, 0, 0, 0, 0, 8 },
                                            { 8, X, X, X, X, 0, 0, X, X, 8 },
                                            { 8, X, X, X, X, 0, 0, X, X, 8 },
                                            { 8, 8, 8, 8, 8, 8, 8, 8, 8, 8 }
                                        },

                                hint =  new char[]                  { 'D','L','U','R','D','R','U','L','D','L' },

                                stars = new sbyte[DATA_STAR_SIZE]   { 10, 12 },
                            },

            /* Level XX */   new Data() {        /* QA OK */

                                size =  64,

                                bound = new sbyte[,] {
                                            { 8, 8, 8, 8, 8, 8, 8, 8, 8, 8 },
                                            { 8, X, X, 0, 0, 0, 0, X, X, 8 },
                                            { 8, X, X, X, X, 0, 0, X, X, 8 },
                                            { 8, X, X, X, X, 0, 0, 0, 0, 8 },
                                            { 8, 0, 0, 0, D, 0, 0, 0, 0, 8 },
                                            { 8, 0, B, C, X, 0, 0, X, X, 8 },
                                            { 8, 0, 0, X, X, 0, 0, X, X, 8 },
                                            { 8, A, X, X, X, 0, 0, X, X, 8 },
                                            { 8, X, X, X, X, 0, 0, X, X, 8 },
                                            { 8, 8, 8, 8, 8, 8, 8, 8, 8, 8 }
                                        },

                                hint =  new char[]                  { 'U','R','U','L','D','R','D' },

                                stars = new sbyte[DATA_STAR_SIZE]   { 7, 8 },
                            },

            /* Level XX */   new Data() {        /* QA OK */

                                size =  64,

                                bound = new sbyte[,] {
                                            { 8, 8, 8, 8, 8, 8, 8, 8, 8, 8 },
                                            { 8, X, X, X, 0, 0, 0, X, X, 8 },
                                            { 8, X, X, 0, 0, 0, 0, X, X, 8 },
                                            { 8, X, 0, 0, 0, 0, 0, X, X, 8 },
                                            { 8, 0, 0, 0, 0, 0, 0, X, X, 8 },
                                            { 8, 0, 0, 0, 0, 0, 0, 0, 0, 8 },
                                            { 8, 0, 0, 0, 0, A, B, C, D, 8 },
                                            { 8, X, X, X, X, X, 0, 0, X, 8 },
                                            { 8, X, X, X, X, X, 0, 0, X, 8 },
                                            { 8, 8, 8, 8, 8, 8, 8, 8, 8, 8 }
                                        },

                                hint =  new char[]                  { 'L','U','R','D','R','U' },

                                stars = new sbyte[DATA_STAR_SIZE]   { 6, 8 },
                            },

            /* Level X */   new Data() {        /* QA OK */

                                size =  64,

                                bound = new sbyte[,] {
                                            { 8, 8, 8, 8, 8, 8, 8, 8, 8, 8 },
                                            { 8, X, X, X, X, X, X, X, X, 8 },
                                            { 8, X, 0, X, X, X, X, X, X, 8 },
                                            { 8, X, 0, 0, 0, 0, 0, 0, X, 8 },
                                            { 8, X, 0, 0, 0, 0, 0, 0, X, 8 },
                                            { 8, X, 0, 0, 0, 0, 0, 0, X, 8 },
                                            { 8, X, A, B, 0, 0, 0, 0, X, 8 },
                                            { 8, X, X, X, C, D, 0, X, X, 8 },
                                            { 8, X, X, X, X, X, X, X, X, 8 },
                                            { 8, 8, 8, 8, 8, 8, 8, 8, 8, 8 }
                                        },

                                hint =  new char[]                  { 'U','L','D','R','U' },

                                stars = new sbyte[DATA_STAR_SIZE]   { 5, 6 },
                            },

            /* Level X */   new Data() {        /* QA OK */

                                size =  64,

                                bound = new sbyte[,] {
                                            { 8, 8, 8, 8, 8, 8, 8, 8, 8, 8 },
                                            { 8, X, X, X, X, X, X, X, X, 8 },
                                            { 8, X, 0, X, 0, X, X, X, X, 8 },
                                            { 8, X, 0, 0, 0, 0, 0, 0, X, 8 },
                                            { 8, X, 0, 0, 0, 0, 0, 0, X, 8 },
                                            { 8, X, 0, 0, 0, 0, 0, 0, X, 8 },
                                            { 8, X, 0, 0, 0, 0, 0, 0, X, 8 },
                                            { 8, X, A, B, C, D, X, X, X, 8 },
                                            { 8, X, X, X, X, X, X, X, X, 8 },
                                            { 8, 8, 8, 8, 8, 8, 8, 8, 8, 8 }
                                        },

                                hint =  new char[]                  { 'U','R','D','L' },

                                stars = new sbyte[DATA_STAR_SIZE]   { 4, 5 },
                            },
            
            /* Level X */   new Data() {        /* QA OK */

                                size =  64,

                                bound = new sbyte[,] {
                                            { 8, 8, 8, 8, 8, 8, 8, 8, 8, 8 },
                                            { 8, X, X, X, X, X, X, X, X, 8 },
                                            { 8, X, X, X, A, 0, 0, 0, X, 8 },
                                            { 8, X, 0, 0, 0, B, C, 0, X, 8 },
                                            { 8, X, 0, 0, 0, 0, 0, D, X, 8 },
                                            { 8, X, 0, 0, 0, 0, 0, 0, X, 8 },
                                            { 8, X, 0, 0, 0, 0, 0, 0, X, 8 },
                                            { 8, X, 0, 0, 0, 0, 0, 0, X, 8 },
                                            { 8, X, X, X, X, X, X, X, X, 8 },
                                            { 8, 8, 8, 8, 8, 8, 8, 8, 8, 8 }
                                        },

                                hint =  new char[]                  { 'D','L','U','R' },

                                stars = new sbyte[DATA_STAR_SIZE]   { 4, 6 },
                            },

#endregion

// 6
#region MIDDLE_STEP_TYPE

            /* Level X */  new Data() {        /* QA OK */

                                size =  64,

                                bound = new sbyte[,] {
                                            { 8, 8, 8, 8, 8, 8, 8, 8, 8, 8 },
                                            { 8, X, X, X, X, X, X, X, X, 8 },
                                            { 8, X, 0, X, A, B, X, 0, X, 8 },
                                            { 8, 0, 0, 0, 0, 0, 0, 0, X, 8 },
                                            { 8, 0, 0, 0, 0, 0, 0, 0, X, 8 },
                                            { 8, 0, 0, 0, 0, 0, 0, 0, X, 8 },
                                            { 8, X, C, 0, X, X, D, 0, X, 8 },
                                            { 8, X, X, X, X, X, X, X, X, 8 },
                                            { 8, X, X, X, X, X, X, X, X, 8 },
                                            { 8, 8, 8, 8, 8, 8, 8, 8, 8, 8 }
                                        },

                                hint =  new char[]                  { 'D','R','U','R','D','R' },

                                stars = new sbyte[DATA_STAR_SIZE]   { 6, 7 },
                            },

            /* Level X */  new Data() {        /* QA OK */

                                size =  64,

                                bound = new sbyte[,] {
                                            { 8, 8, 8, 8, 8, 8, 8, 8, 8, 8 },
                                            { 8, X, X, X, X, X, X, X, X, 8 },
                                            { 8, X, 0, X, A, B, X, 0, X, 8 },
                                            { 8, X, 0, 0, 0, 0, 0, 0, X, 8 },
                                            { 8, X, 0, 0, 0, 0, 0, 0, X, 8 },
                                            { 8, X, 0, 0, 0, 0, 0, 0, X, 8 },
                                            { 8, X, C, 0, X, X, D, X, X, 8 },
                                            { 8, X, X, X, X, X, X, X, X, 8 },
                                            { 8, X, X, X, X, X, X, X, X, 8 },
                                            { 8, 8, 8, 8, 8, 8, 8, 8, 8, 8 }
                                        },

                                hint =  new char[]                  { 'R','U','L','D','L' },

                                stars = new sbyte[DATA_STAR_SIZE]   { 5, 6 },
                            },

            /* Level X */  new Data() {        /* QA OK */

                                size =  64,

                                bound = new sbyte[,] {
                                            { 8, 8, 8, 8, 8, 8, 8, 8, 8, 8 },
                                            { 8, X, X, X, X, X, X, X, X, 8 },
                                            { 8, X, X, 0, X, X, 0, X, X, 8 },
                                            { 8, X, X, 0, 0, 0, 0, X, X, 8 },
                                            { 8, X, 0, 0, 0, 0, 0, 0, X, 8 },
                                            { 8, X, A, 0, 0, 0, 0, D, X, 8 },
                                            { 8, X, 0, B, X, X, C, 0, X, 8 },
                                            { 8, X, X, X, X, X, X, X, X, 8 },
                                            { 8, X, X, X, X, X, X, X, X, 8 },
                                            { 8, 8, 8, 8, 8, 8, 8, 8, 8, 8 }
                                        },

                                hint =  new char[]                  { 'U','R','D','L','U','R','D' },

                                stars = new sbyte[DATA_STAR_SIZE]   { 7, 9 },
                            },

            /* Level X */   new Data() {        /* QA OK */

                                size =  64,

                                bound = new sbyte[,] {
                                            { 8, 8, 8, 8, 8, 8, 8, 8, 8, 8 },
                                            { 8, X, X, X, X, X, X, X, X, 8 },
                                            { 8, X, X, X, X, X, X, X, X, 8 },
                                            { 8, X, 0, 0, 0, 0, 0, 0, X, 8 },
                                            { 8, X, 0, 0, 0, 0, 0, 0, X, 8 },
                                            { 8, X, 0, B, 0, 0, C, 0, X, 8 },
                                            { 8, X, A, 0, X, X, 0, D, X, 8 },
                                            { 8, X, X, X, X, X, X, X, X, 8 },
                                            { 8, X, X, X, X, X, X, X, X, 8 },
                                            { 8, 8, 8, 8, 8, 8, 8, 8, 8, 8 }
                                        },

                                hint =  new char[]                  { 'U','R','D','R' },

                                stars = new sbyte[DATA_STAR_SIZE]   { 4, 5 },
                            },

             /* Level X */  new Data() {        /* QA OK */

                                size =  64,

                                bound = new sbyte[,] {
                                            { 8, 8, 8, 8, 8, 8, 8, 8, 8, 8 },
                                            { 8, X, X, X, X, X, X, X, X, 8 },
                                            { 8, X, X, X, X, X, X, X, X, 8 },
                                            { 8, X, X, 0, 0, 0, 0, X, X, 8 },
                                            { 8, X, 0, 0, 0, 0, 0, 0, X, 8 },
                                            { 8, X, A, 0, 0, 0, 0, D, X, 8 },
                                            { 8, X, 0, B, X, X, C, 0, X, 8 },
                                            { 8, X, X, X, X, X, X, X, X, 8 },
                                            { 8, X, X, X, X, X, X, X, X, 8 },
                                            { 8, 8, 8, 8, 8, 8, 8, 8, 8, 8 }
                                        },

                                hint =  new char[]                  { 'U','R','D','R' },

                                stars = new sbyte[DATA_STAR_SIZE]   { 4, 5 },
                            },

            /* Level 23 */  new Data() {        /* QA OK */

                                size =  64,

                                bound = new sbyte[,] {
                                            { 8, 8, 8, 8, 8, 8, 8, 8, 8, 8 },
                                            { 8, X, X, X, X, X, X, X, X, 8 },
                                            { 8, X, X, 0, X, X, X, X, X, 8 },
                                            { 8, X, X, 0, 0, 0, 0, X, X, 8 },
                                            { 8, X, 0, 0, 0, 0, 0, 0, X, 8 },
                                            { 8, X, A, 0, 0, 0, 0, D, X, 8 },
                                            { 8, X, 0, B, X, X, C, 0, X, 8 },
                                            { 8, X, X, X, X, X, X, X, X, 8 },
                                            { 8, X, X, X, X, X, X, X, X, 8 },
                                            { 8, 8, 8, 8, 8, 8, 8, 8, 8, 8 }
                                        },

                                hint =  new char[]                  { 'R','U','L','D' },

                                stars = new sbyte[DATA_STAR_SIZE]   { 4, 6 },
                            },

#endregion

// 5
#region MIRROR_TYPE

            /* Level X */  new Data() {        /* QA OK */

                                size =  64,

                                bound = new sbyte[,] {
                                            { 8, 8, 8, 8, 8, 8, 8, 8, 8, 8 },
                                            { 8, X, X, X, X, X, X, X, X, 8 },
                                            { 8, X, 0, 0, 0, 0, 0, X, X, 8 },
                                            { 8, X, 0, 0, 0, 0, 0, 0, X, 8 },
                                            { 8, X, 0, 0, 0, 0, 0, 0, X, 8 },
                                            { 8, X, 0, 0, 0, 0, 0, 0, X, 8 },
                                            { 8, X, A, B, 0, 0, 0, 0, X, 8 },
                                            { 8, X, X, C, D, 0, 0, X, X, 8 },
                                            { 8, X, X, X, X, X, X, X, X, 8 },
                                            { 8, 8, 8, 8, 8, 8, 8, 8, 8, 8 }
                                        },

                                hint =  new char[]                  { 'R','U','L' },

                                stars = new sbyte[DATA_STAR_SIZE]   { 3, 4 },
                            },

            /* Level X */  new Data() {        /* QA OK */

                                size =  64,

                                bound = new sbyte[,] {
                                            { 8, 8, 8, 8, 8, 8, 8, 8, 8, 8 },
                                            { 8, X, X, X, A, 0, X, X, X, 8 },
                                            { 8, X, X, B, 0, 0, 0, X, X, 8 },
                                            { 8, X, C, 0, 0, 0, 0, 0, X, 8 },
                                            { 8, D, 0, 0, 0, 0, 0, 0, 0, 8 },
                                            { 8, 0, 0, 0, 0, 0, 0, 0, 0, 8 },
                                            { 8, 0, 0, 0, 0, 0, 0, 0, 0, 8 },
                                            { 8, 0, 0, 0, 0, 0, 0, X, X, 8 },
                                            { 8, 0, 0, 0, 0, 0, 0, X, X, 8 },
                                            { 8, 8, 8, 8, 8, 8, 8, 8, 8, 8 }
                                        },

                                hint =  new char[]                  { 'R','D','L','D' },

                                stars = new sbyte[DATA_STAR_SIZE]   { 4, 5 },
                            },

            /* Level X */  new Data() {        /* QA OK */

                                size =  64,

                                bound = new sbyte[,] {
                                            { 8, 8, 8, 8, 8, 8, 8, 8, 8, 8 },
                                            { 8, X, X, 0, 0, A, 0, 0, 0, 8 },
                                            { 8, X, X, 0, 0, 0, B, 0, 0, 8 },
                                            { 8, 0, 0, 0, 0, 0, 0, C, 0, 8 },
                                            { 8, 0, 0, 0, 0, 0, 0, 0, D, 8 },
                                            { 8, 0, 0, 0, 0, 0, 0, 0, 0, 8 },
                                            { 8, 0, 0, 0, 0, 0, 0, 0, 0, 8 },
                                            { 8, X, X, 0, 0, 0, 0, X, X, 8 },
                                            { 8, X, X, 0, 0, 0, 0, X, X, 8 },
                                            { 8, 8, 8, 8, 8, 8, 8, 8, 8, 8 }
                                        },

                                hint =  new char[]                  { 'L','D','R','U','R' },

                                stars = new sbyte[DATA_STAR_SIZE]   { 5, 6 },
                            },

            /* Level X */  new Data() {        /* QA OK */

                                size =  64,

                                bound = new sbyte[,] {
                                            { 8, 8, 8, 8, 8, 8, 8, 8, 8, 8 },
                                            { 8, X, X, X, A, 0, X, X, X, 8 },
                                            { 8, X, X, B, 0, 0, 0, X, X, 8 },
                                            { 8, X, C, 0, 0, 0, 0, 0, X, 8 },
                                            { 8, D, 0, 0, 0, 0, 0, 0, 0, 8 },
                                            { 8, X, X, 0, 0, 0, 0, 0, 0, 8 },
                                            { 8, X, X, 0, 0, 0, 0, 0, X, 8 },
                                            { 8, 0, 0, 0, 0, 0, 0, X, X, 8 },
                                            { 8, 0, 0, 0, 0, 0, X, X, X, 8 },
                                            { 8, 8, 8, 8, 8, 8, 8, 8, 8, 8 }
                                        },

                                hint =  new char[]                  { 'R','D','L','D','L' },

                                stars = new sbyte[DATA_STAR_SIZE]   { 5, 6 },
                            },

            /* Level X */  new Data() {        /* QA OK */

                                size =  64,

                                bound = new sbyte[,] {
                                            { 8, 8, 8, 8, 8, 8, 8, 8, 8, 8 },
                                            { 8, X, X, X, 0, 0, X, X, X, 8 },
                                            { 8, X, X, X, 0, 0, 0, X, X, 8 },
                                            { 8, X, X, X, 0, 0, 0, 0, X, 8 },
                                            { 8, D, C, B, A, 0, 0, 0, 0, 8 },
                                            { 8, X, X, 0, 0, 0, 0, 0, 0, 8 },
                                            { 8, X, X, 0, 0, 0, 0, 0, X, 8 },
                                            { 8, 0, 0, 0, 0, 0, 0, X, X, 8 },
                                            { 8, 0, 0, 0, 0, 0, X, X, X, 8 },
                                            { 8, 8, 8, 8, 8, 8, 8, 8, 8, 8 }
                                        },

                                hint =  new char[]                  { 'R','D','L','D','L' },

                                stars = new sbyte[DATA_STAR_SIZE]   { 5, 6 },
                            },
#endregion

// 11
#region DONUT_TYPE

            /* Level X */   new Data() {        /* QA OK */

                                size =  64,

                                bound = new sbyte[,] {
                                            { 8, 8, 8, 8, 8, 8, 8, 8, 8, 8 },
                                            { 8, X, X, X, 0, 0, 0, 0, A, 8 },
                                            { 8, X, X, 0, 0, 0, 0, 0, B, 8 },
                                            { 8, X, 0, 0, 0, 0, 0, 0, C, 8 },
                                            { 8, 0, 0, 0, 0, 0, 0, 0, D, 8 },
                                            { 8, 0, 0, 0, 0, X, X, 0, 0, 8 },
                                            { 8, X, 0, 0, 0, X, X, 0, 0, 8 },
                                            { 8, X, X, 0, 0, 0, 0, 0, X, 8 },
                                            { 8, X, X, X, 0, 0, 0, 0, X, 8 },
                                            { 8, 8, 8, 8, 8, 8, 8, 8, 8, 8 }
                                        },

                                hint =  new char[]                  { 'L','D','R','U','R' },

                                stars = new sbyte[DATA_STAR_SIZE]   { 5, 6 },
                            },

            /* Level XX */   new Data() {        /* QA OK */

                                size =  64,

                                bound = new sbyte[,] {
                                            { 8, 8, 8, 8, 8, 8, 8, 8, 8, 8 },
                                            { 8, A, B, C, D, 0, 0, 0, 0, 8 },
                                            { 8, 0, 0, 0, 0, 0, 0, 0, 0, 8 },
                                            { 8, 0, X, X, X, 0, 0, 0, 0, 8 },
                                            { 8, 0, X, X, X, 0, 0, 0, 0, 8 },
                                            { 8, 0, 0, 0, 0, 0, 0, 0, 0, 8 },
                                            { 8, 0, 0, 0, 0, 0, 0, 0, X, 8 },
                                            { 8, 0, 0, 0, 0, 0, 0, X, X, 8 },
                                            { 8, 0, 0, 0, 0, 0, X, X, X, 8 },
                                            { 8, 8, 8, 8, 8, 8, 8, 8, 8, 8 }
                                        },

                                hint =  new char[]                  { 'R','D','L','U','R','U','R' },

                                stars = new sbyte[DATA_STAR_SIZE]   { 7, 8 },
                            },


            /* Level XX */   new Data() {        /* QA OK */

                                size =  64,

                                bound = new sbyte[,] {
                                            { 8, 8, 8, 8, 8, 8, 8, 8, 8, 8 },
                                            { 8, X, X, 0, 0, 0, 0, X, X, 8 },
                                            { 8, X, 0, 0, 0, 0, 0, 0, X, 8 },
                                            { 8, 0, 0, 0, 0, 0, 0, 0, 0, 8 },
                                            { 8, 0, 0, 0, 0, 0, 0, 0, 0, 8 },
                                            { 8, 0, 0, X, X, X, X, 0, 0, 8 },
                                            { 8, 0, 0, X, X, X, X, 0, 0, 8 },
                                            { 8, 0, 0, 0, X, X, X, 0, 0, 8 },
                                            { 8, X, A, B, C, D, X, X, X, 8 },
                                            { 8, 8, 8, 8, 8, 8, 8, 8, 8, 8 }
                                        },

                                hint =  new char[]                  { 'U','L','U','L','U','R','D' },

                                stars = new sbyte[DATA_STAR_SIZE]   { 7, 8 },
                            },

            /* Level X */   new Data() {        /* QA OK */

                                size =  64,

                                bound = new sbyte[,] {
                                            { 8, 8, 8, 8, 8, 8, 8, 8, 8, 8 },
                                            { 8, X, X, X, 0, 0, X, X, X, 8 },
                                            { 8, X, X, 0, 0, 0, 0, X, X, 8 },
                                            { 8, X, 0, 0, 0, 0, 0, 0, X, 8 },
                                            { 8, 0, 0, 0, 0, 0, 0, 0, 0, 8 },
                                            { 8, 0, 0, 0, 0, 0, 0, 0, 0, 8 },
                                            { 8, 0, 0, X, X, 0, 0, 0, 0, 8 },
                                            { 8, 0, 0, X, X, 0, 0, 0, 0, 8 },
                                            { 8, 0, 0, 0, 0, A, B, C, D, 8 },
                                            { 8, 8, 8, 8, 8, 8, 8, 8, 8, 8 }
                                        },

                                hint =  new char[]                  { 'L','U','R','D' },

                                stars = new sbyte[DATA_STAR_SIZE]   { 4, 5 },
                            },

            /* Level X */   new Data() {        /* QA OK */

                                size =  64,

                                bound = new sbyte[,] {
                                            { 8, 8, 8, 8, 8, 8, 8, 8, 8, 8 },
                                            { 8, X, 0, 0, 0, 0, 0, 0, A, 8 },
                                            { 8, 0, 0, 0, 0, 0, 0, 0, B, 8 },
                                            { 8, 0, 0, X, X, X, 0, 0, X, 8 },
                                            { 8, 0, 0, X, C, 0, 0, 0, X, 8 },
                                            { 8, 0, 0, X, D, 0, 0, 0, 0, 8 },
                                            { 8, 0, 0, X, 0, X, X, 0, 0, 8 },
                                            { 8, 0, 0, X, 0, X, X, 0, 0, 8 },
                                            { 8, 0, 0, 0, 0, 0, 0, 0, 0, 8 },
                                            { 8, 8, 8, 8, 8, 8, 8, 8, 8, 8 }
                                        },

                                hint =  new char[]                  { 'R','D','L','D' },

                                stars = new sbyte[DATA_STAR_SIZE]   { 4, 5 },
                            },

            /* Level X */   new Data() {        /* QA OK */

                                size =  64,

                                bound = new sbyte[,] {
                                            { 8, 8, 8, 8, 8, 8, 8, 8, 8, 8 },
                                            { 8, X, X, X, 0, 0, 0, 0, A, 8 },
                                            { 8, X, X, 0, 0, 0, 0, 0, B, 8 },
                                            { 8, X, 0, 0, 0, 0, 0, 0, C, 8 },
                                            { 8, 0, 0, 0, 0, 0, 0, 0, D, 8 },
                                            { 8, 0, 0, X, X, X, X, 0, 0, 8 },
                                            { 8, 0, 0, X, X, X, X, 0, 0, 8 },
                                            { 8, 0, 0, X, X, X, X, 0, 0, 8 },
                                            { 8, 0, 0, 0, 0, 0, 0, 0, 0, 8 },
                                            { 8, 8, 8, 8, 8, 8, 8, 8, 8, 8 }
                                        },

                                hint =  new char[]                  { 'L','D','R','D' },

                                stars = new sbyte[DATA_STAR_SIZE]   { 4, 5 },
                            },


            /* Level X */   new Data() {        /* QA OK */

                                size =  64,

                                bound = new sbyte[,] {
                                            { 8, 8, 8, 8, 8, 8, 8, 8, 8, 8 },
                                            { 8, X, 0, 0, 0, 0, 0, 0, A, 8 },
                                            { 8, 0, 0, 0, 0, 0, 0, 0, B, 8 },
                                            { 8, 0, 0, X, X, X, 0, 0, X, 8 },
                                            { 8, 0, 0, X, C, 0, 0, 0, X, 8 },
                                            { 8, 0, 0, X, D, 0, 0, 0, 0, 8 },
                                            { 8, 0, 0, X, X, X, X, 0, 0, 8 },
                                            { 8, 0, 0, X, X, X, X, 0, 0, 8 },
                                            { 8, 0, 0, 0, 0, 0, 0, 0, 0, 8 },
                                            { 8, 8, 8, 8, 8, 8, 8, 8, 8, 8 }
                                        },

                                hint =  new char[]                  { 'L','D','R','D' },

                                stars = new sbyte[DATA_STAR_SIZE]   { 4, 5 },
                            },

            /* Level X */   new Data() {        /* QA OK */

                                size =  64,

                                bound = new sbyte[,] {
                                            { 8, 8, 8, 8, 8, 8, 8, 8, 8, 8 },
                                            { 8, 0, 0, A, B, C, D, 0, 0, 8 },
                                            { 8, 0, 0, 0, 0, 0, 0, 0, 0, 8 },
                                            { 8, 0, 0, 0, 0, 0, 0, 0, 0, 8 },
                                            { 8, 0, 0, X, X, X, X, 0, 0, 8 },
                                            { 8, 0, 0, X, X, X, X, 0, 0, 8 },
                                            { 8, 0, 0, 0, 0, 0, 0, 0, 0, 8 },
                                            { 8, 0, 0, 0, 0, 0, 0, 0, 0, 8 },
                                            { 8, 0, 0, 0, 0, 0, 0, 0, 0, 8 },
                                            { 8, 8, 8, 8, 8, 8, 8, 8, 8, 8 }
                                        },

                                hint =  new char[]                  { 'R','D','R','D' },

                                stars = new sbyte[DATA_STAR_SIZE]   { 4, 5 },
                            },

            /* Level X */  new Data() {        /* QA OK */

                                size =  64,

                                bound = new sbyte[,] {
                                            { 8, 8, 8, 8, 8, 8, 8, 8, 8, 8 },
                                            { 8, X, X, X, X, X, X, X, X, 8 },
                                            { 8, X, X, X, 0, 0, 0, X, X, 8 },
                                            { 8, X, 0, 0, 0, 0, 0, 0, X, 8 },
                                            { 8, X, 0, B, X, X, 0, 0, X, 8 },
                                            { 8, X, A, 0, X, X, 0, 0, X, 8 },
                                            { 8, X, 0, 0, 0, 0, 0, 0, X, 8 },
                                            { 8, X, X, 0, 0, 0, C, D, X, 8 },
                                            { 8, X, X, X, X, X, X, X, X, 8 },
                                            { 8, 8, 8, 8, 8, 8, 8, 8, 8, 8 }
                                        },

                                hint =  new char[]                  { 'D','L','U','L','U' },

                                stars = new sbyte[DATA_STAR_SIZE]   { 5, 6 },
                            },

            /* Level X */  new Data() {        /* QA OK */

                                size =  64,

                                bound = new sbyte[,] {
                                            { 8, 8, 8, 8, 8, 8, 8, 8, 8, 8 },
                                            { 8, X, X, X, X, X, X, X, X, 8 },
                                            { 8, X, X, X, 0, 0, 0, 0, X, 8 },
                                            { 8, X, 0, 0, 0, 0, 0, 0, X, 8 },
                                            { 8, X, 0, B, X, X, 0, C, X, 8 },
                                            { 8, X, A, 0, X, X, 0, D, X, 8 },
                                            { 8, X, 0, 0, 0, 0, 0, 0, X, 8 },
                                            { 8, X, X, 0, 0, 0, 0, 0, X, 8 },
                                            { 8, X, X, X, X, X, X, X, X, 8 },
                                            { 8, 8, 8, 8, 8, 8, 8, 8, 8, 8 }
                                        },

                                hint =  new char[]                  { 'D','R' },

                                stars = new sbyte[DATA_STAR_SIZE]   { 2, 3 },
                            },

            /* Level X */  new Data() {        /* QA OK */

                                size =  64,

                                bound = new sbyte[,] {
                                            { 8, 8, 8, 8, 8, 8, 8, 8, 8, 8 },
                                            { 8, X, X, X, X, X, X, X, X, 8 },
                                            { 8, X, X, 0, 0, 0, 0, X, X, 8 },
                                            { 8, X, 0, 0, 0, 0, 0, 0, X, 8 },
                                            { 8, X, 0, B, X, X, 0, C, X, 8 },
                                            { 8, X, A, 0, X, X, D, 0, X, 8 },
                                            { 8, X, X, 0, 0, 0, 0, X, X, 8 },
                                            { 8, X, X, 0, 0, 0, 0, X, X, 8 },
                                            { 8, X, X, X, X, X, X, X, X, 8 },
                                            { 8, 8, 8, 8, 8, 8, 8, 8, 8, 8 }
                                        },

                                hint =  new char[]                  { 'R','D','L','D','L' },

                                stars = new sbyte[DATA_STAR_SIZE]   { 5, 6 },
                            },

#endregion

// 1
#region THREE_SQUARES

            /* Level 22 */   new Data() {        /* QA OK */

                                size =  64,

                                bound = new sbyte[,] {
                                            { 8, 8, 8, 8, 8, 8, 8, 8, 8, 8 },
                                            { 8, X, X, X, X, X, X, X, X, 8 },
                                            { 8, X, X, X, X, X, X, X, X, 8 },
                                            { 8, X, X, X, 0, A, 0, X, X, 8 },
                                            { 8, X, X, 0, C, 0, D, X, X, 8 },
                                            { 8, X, X, 0, 0, B, 0, X, X, 8 },
                                            { 8, X, 0, 0, 0, 0, X, X, X, 8 },
                                            { 8, X, 0, 0, X, X, X, X, X, 8 },
                                            { 8, X, X, X, X, X, X, X, X, 8 },
                                            { 8, 8, 8, 8, 8, 8, 8, 8, 8, 8 }
                                        },

                                hint =  new char[]                  { 'D','L','D','L' },

                                stars = new sbyte[DATA_STAR_SIZE]   { 4, 5 },
                            },

#endregion

// 1
#region SQUEEZE_TO_SQUARE

            /* Level XX */   new Data() {        /* QA OK */

                                size =  64,

                                bound = new sbyte[,] {
                                            { 8, 8, 8, 8, 8, 8, 8, 8, 8, 8 },
                                            { 8, X, X, X, X, X, X, X, X, 8 },
                                            { 8, X, X, X, X, X, X, X, X, 8 },
                                            { 8, X, X, X, X, X, X, X, X, 8 },
                                            { 8, X, A, B, C, D, 0, 0, X, 8 },
                                            { 8, X, 0, 0, 0, X, 0, 0, X, 8 },
                                            { 8, X, X, X, X, X, X, X, X, 8 },
                                            { 8, X, X, X, X, X, X, X, X, 8 },
                                            { 8, X, X, X, X, X, X, X, X, 8 },
                                            { 8, 8, 8, 8, 8, 8, 8, 8, 8, 8 }
                                        },

                                hint =  new char[]                  { 'R','D','R','U','R','D','R' },

                                stars = new sbyte[DATA_STAR_SIZE]   { 7, 8 },
                            },

#endregion

// 1
#region UNIQUE_0

            /* Level 25 */  new Data() {        /* QA OK */

                                size =  64,

                                bound = new sbyte[,] {
                                            { 8, 8, 8, 8, 8, 8, 8, 8, 8, 8 },
                                            { 8, X, X, X, X, X, X, X, X, 8 },
                                            { 8, X, X, X, X, X, X, 0, X, 8 },
                                            { 8, X, X, X, X, X, A, B, X, 8 },
                                            { 8, X, 0, 0, 0, 0, 0, 0, X, 8 },
                                            { 8, X, 0, 0, 0, 0, X, X, X, 8 },
                                            { 8, X, X, X, C, D, 0, 0, X, 8 },
                                            { 8, X, X, X, X, X, X, X, X, 8 },
                                            { 8, X, X, X, X, X, X, X, X, 8 },
                                            { 8, 8, 8, 8, 8, 8, 8, 8, 8, 8 }
                                        },

                                hint =  new char[]                  { 'U','L','D','L' },

                                stars = new sbyte[DATA_STAR_SIZE]   { 4, 5 },
                            },

#endregion

// 7
#region UNIQUE_1

            /* Level X */   new Data() {        /* QA OK */

                                size =  64,

                                bound = new sbyte[,] {
                                            { 8, 8, 8, 8, 8, 8, 8, 8, 8, 8 },
                                            { 8, X, X, X, X, 0, 0, X, X, 8 },
                                            { 8, X, X, X, X, 0, 0, X, X, 8 },
                                            { 8, X, X, X, X, 0, 0, X, X, 8 },
                                            { 8, X, X, X, X, 0, 0, X, X, 8 },
                                            { 8, X, X, 0, 0, 0, 0, 0, 0, 8 },
                                            { 8, 0, 0, 0, 0, 0, 0, X, X, 8 },
                                            { 8, 0, 0, 0, 0, 0, 0, X, X, 8 },
                                            { 8, A, B, C, D, 0, 0, 0, 0, 8 },
                                            { 8, 8, 8, 8, 8, 8, 8, 8, 8, 8 }
                                        },

                                hint =  new char[]                  { 'R','U','L','U','R','D' },

                                stars = new sbyte[DATA_STAR_SIZE]   { 6, 7 },
                            },

            /* Level XX */   new Data() {       /* QA OK */

                                size =  64,

                                bound = new sbyte[,] {
                                            { 8, 8, 8, 8, 8, 8, 8, 8, 8, 8 },
                                            { 8, X, X, X, X, X, X, X, X, 8 },
                                            { 8, X, X, 0, 0, 0, X, X, X, 8 },
                                            { 8, X, 0, 0, A, B, X, X, X, 8 },
                                            { 8, 0, 0, 0, 0, 0, X, X, X, 8 },
                                            { 8, X, 0, 0, X, X, X, X, X, 8 },
                                            { 8, 0, C, D, 0, 0, 0, X, X, 8 },
                                            { 8, X, 0, 0, 0, 0, 0, 0, 0, 8 },
                                            { 8, X, X, X, X, X, X, X, X, 8 },
                                            { 8, 8, 8, 8, 8, 8, 8, 8, 8, 8 }
                                        },

                                hint =  new char[]                  { 'D','R','U','L','U','R' },

                                stars = new sbyte[DATA_STAR_SIZE]   { 6, 7 },
                            },

            /* Level X */   new Data() {       /* QA OK */

                                size =  64,

                                bound = new sbyte[,] {
                                            { 8, 8, 8, 8, 8, 8, 8, 8, 8, 8 },
                                            { 8, X, X, X, X, X, X, X, X, 8 },
                                            { 8, X, X, X, A, B, X, X, X, 8 },
                                            { 8, X, X, X, 0, 0, X, X, X, 8 },
                                            { 8, X, 0, 0, 0, 0, 0, 0, X, 8 },
                                            { 8, X, 0, 0, 0, 0, X, X, X, 8 },
                                            { 8, X, 0, 0, 0, 0, X, X, X, 8 },
                                            { 8, X, 0, 0, 0, 0, C, D, X, 8 },
                                            { 8, X, X, X, X, X, X, X, X, 8 },
                                            { 8, 8, 8, 8, 8, 8, 8, 8, 8, 8 }
                                        },

                                hint =  new char[]                  { 'L','U','R','D','L','D' },

                                stars = new sbyte[DATA_STAR_SIZE]   { 6, 7 },
                            },

            /* Level X */  new Data() {       /* QA OK */

                                size =  64,

                                bound = new sbyte[,] {
                                            { 8, 8, 8, 8, 8, 8, 8, 8, 8, 8 },
                                            { 8, X, X, X, X, X, X, X, X, 8 },
                                            { 8, X, X, 0, 0, 0, X, X, X, 8 },
                                            { 8, X, 0, 0, 0, 0, 0, X, X, 8 },
                                            { 8, X, 0, 0, 0, D, 0, X, X, 8 },
                                            { 8, X, X, X, C, 0, 0, X, X, 8 },
                                            { 8, X, 0, B, 0, 0, 0, X, X, 8 },
                                            { 8, X, A, 0, 0, 0, 0, 0, 0, 8 },
                                            { 8, X, X, X, X, X, X, X, X, 8 },
                                            { 8, 8, 8, 8, 8, 8, 8, 8, 8, 8 }
                                        },

                                hint =  new char[]                  { 'D','R','U','L','U','R','D' },

                                stars = new sbyte[DATA_STAR_SIZE]   { 7, 9 },
                            },

            /* Level X */  new Data() {       /* QA OK */

                                size =  64,

                                bound = new sbyte[,] {
                                            { 8, 8, 8, 8, 8, 8, 8, 8, 8, 8 },
                                            { 8, X, X, X, X, X, X, X, X, 8 },
                                            { 8, X, X, 0, 0, X, X, X, X, 8 },
                                            { 8, X, 0, 0, C, 0, X, X, X, 8 },
                                            { 8, X, 0, B, 0, 0, X, X, X, 8 },
                                            { 8, X, A, 0, 0, D, X, X, X, 8 },
                                            { 8, X, 0, 0, 0, 0, X, X, X, 8 },
                                            { 8, X, 0, 0, 0, 0, 0, 0, X, 8 },
                                            { 8, X, X, X, X, X, X, X, X, 8 },
                                            { 8, 8, 8, 8, 8, 8, 8, 8, 8, 8 }
                                        },

                                hint =  new char[]                  { 'D','R','U','L','D' },

                                stars = new sbyte[DATA_STAR_SIZE]   { 5, 6 },
                            },


            /* Level X */  new Data() {       /* QA OK */

                                size =  64,

                                bound = new sbyte[,] {
                                            { 8, 8, 8, 8, 8, 8, 8, 8, 8, 8 },
                                            { 8, X, X, X, X, X, X, X, X, 8 },
                                            { 8, X, X, X, 0, 0, X, X, X, 8 },
                                            { 8, X, X, 0, 0, 0, 0, X, X, 8 },
                                            { 8, X, X, 0, 0, 0, 0, X, X, 8 },
                                            { 8, X, X, X, X, 0, 0, X, X, 8 },
                                            { 8, X, X, 0, 0, 0, 0, X, X, 8 },
                                            { 8, X, X, A, B, C, D, X, X, 8 },
                                            { 8, X, X, X, X, X, X, X, X, 8 },
                                            { 8, 8, 8, 8, 8, 8, 8, 8, 8, 8 }
                                        },

                                hint =  new char[]                  { 'U','R','D' },

                                stars = new sbyte[DATA_STAR_SIZE]   { 3, 4 },
                            },

            /* Level XX */   new Data() {       /* QA OK */

                                size =  64,

                                bound = new sbyte[,] {
                                            { 8, 8, 8, 8, 8, 8, 8, 8, 8, 8 },
                                            { 8, X, X, X, X, X, X, X, X, 8 },
                                            { 8, X, 0, 0, 0, 0, X, X, X, 8 },
                                            { 8, X, 0, 0, 0, D, X, X, X, 8 },
                                            { 8, X, 0, B, C, 0, X, X, X, 8 },
                                            { 8, X, A, 0, 0, 0, X, X, X, 8 },
                                            { 8, X, 0, 0, 0, 0, X, X, X, 8 },
                                            { 8, X, 0, 0, 0, 0, 0, 0, X, 8 },
                                            { 8, X, X, X, X, X, X, X, X, 8 },
                                            { 8, 8, 8, 8, 8, 8, 8, 8, 8, 8 }
                                        },

                                hint =  new char[]                  { 'D','R','U','L','D' },

                                stars = new sbyte[DATA_STAR_SIZE]   { 5, 6 },
                            },

#endregion

// 2
#region UNIQUE_2

            /* Level X */   new Data() {       /* QA OK */

                                size =  64,

                                bound = new sbyte[,] {
                                            { 8, 8, 8, 8, 8, 8, 8, 8, 8, 8 },
                                            { 8, 0, 0, X, 0, X, X, X, X, 8 },
                                            { 8, A, 0, 0, B, 0, X, X, X, 8 },
                                            { 8, 0, 0, 0, 0, 0, 0, 0, 0, 8 },
                                            { 8, 0, X, X, 0, X, X, 0, 0, 8 },
                                            { 8, X, 0, X, X, 0, X, 0, 0, 8 },
                                            { 8, 0, 0, 0, 0, 0, 0, 0, 0, 8 },
                                            { 8, C, 0, X, D, 0, X, 0, 0, 8 },
                                            { 8, X, 0, X, X, 0, X, 0, 0, 8 },
                                            { 8, 8, 8, 8, 8, 8, 8, 8, 8, 8 }
                                        },

                                hint =  new char[]                  { 'L','U','R','U','L','U' },

                                stars = new sbyte[DATA_STAR_SIZE]   { 6, 7 },
                            },

            /* Level X */   new Data() {       /* QA OK */

                                size =  64,

                                bound = new sbyte[,] {
                                            { 8, 8, 8, 8, 8, 8, 8, 8, 8, 8 },
                                            { 8, X, X, X, X, X, X, X, X, 8 },
                                            { 8, A, X, X, X, X, B, X, X, 8 },
                                            { 8, 0, 0, 0, 0, 0, 0, 0, 0, 8 },
                                            { 8, X, X, X, X, X, X, 0, 0, 8 },
                                            { 8, X, X, X, X, X, X, 0, 0, 8 },
                                            { 8, 0, 0, 0, 0, 0, 0, 0, 0, 8 },
                                            { 8, C, X, X, X, X, D, 0, 0, 8 },
                                            { 8, X, X, X, X, X, X, 0, 0, 8 },
                                            { 8, 8, 8, 8, 8, 8, 8, 8, 8, 8 }
                                        },

                                hint =  new char[]                  { 'U','R','D','R','D' },

                                stars = new sbyte[DATA_STAR_SIZE]   { 5, 6 },
                            },

#endregion

            /* Level 4 */   new Data() {

                                size =  100,

                                bound = new sbyte[,] {
                                            { X, X, X, X, X, X, X, X, X, X },
                                            { X, X, X, X, X, X, X, X, X, X },
                                            { 0, 0, X, X, X, 0, 0, 0, X, X },
                                            { 0, 0, X, X, 0, 0, 0, 0, X, X },
                                            { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                                            { X, X, 0, 0, 0, 0, 0, 0, 0, X },
                                            { X, X, A, X, X, X, C, X, X, X },
                                            { X, X, B, X, X, X, D, X, X, X },
                                            { X, X, X, X, X, X, X, X, X, X },
                                            { X, X, X, X, X, X, X, X, X, X }
                                        },

                                hint =  new char[]                  { 'U','R','U','L','D','L','U','L','U' },

                                stars = new sbyte[DATA_STAR_SIZE]   { 9, 10 },
                            },

            /* Level X */   new Data() {

                                size =  64,

                                bound = new sbyte[,] {
                                            { 8, 8, 8, 8, 8, 8, 8, 8, 8, 8 },
                                            { 8, X, 0, 0, 0, 0, 0, 0, 0, 8 },
                                            { 8, X, 0, 0, X, X, X, 0, 0, 8 },
                                            { 8, X, 0, 0, 0, 0, 0, 0, 0, 8 },
                                            { 8, X, X, 0, 0, 0, 0, 0, 0, 8 },
                                            { 8, X, X, X, 0, 0, X, X, X, 8 },
                                            { 8, X, X, X, 0, 0, X, X, X, 8 },
                                            { 8, X, A, B, C, 0, X, X, X, 8 },
                                            { 8, X, X, X, D, X, X, X, X, 8 },
                                            { 8, 8, 8, 8, 8, 8, 8, 8, 8, 8 }
                                        },

                                hint =  new char[]                  { 'U','L','U','R','U','R','U' },

                                stars = new sbyte[DATA_STAR_SIZE]   { 7, 8 },
                            },
            
            /* Level 34 */   new Data() {

                                size =  64,

                                bound = new sbyte[,] {
                                            { 8, 8, 8, 8, 8, 8, 8, 8, 8, 8 },
                                            { 8, 0, 0, 0, 0, 0, 0, 0, 0, 8 },
                                            { 8, 0, 0, X, X, X, X, 0, 0, 8 },
                                            { 8, 0, 0, X, 0, 0, X, 0, 0, 8 },
                                            { 8, 0, 0, X, A, B, 0, 0, 0, 8 },
                                            { 8, 0, 0, X, 0, 0, X, 0, 0, 8 },
                                            { 8, 0, 0, X, X, X, X, X, X, 8 },
                                            { 8, 0, 0, 0, X, 0, X, X, X, 8 },
                                            { 8, 0, 0, 0, C, D, X, X, X, 8 },
                                            { 8, 8, 8, 8, 8, 8, 8, 8, 8, 8 }
                                        },

                                hint =  new char[]                  { 'R','D','L','U','R','D','R','D' },

                                stars = new sbyte[DATA_STAR_SIZE]   { 8, 9 },
                            },

            /* Level 0 */   new Data() {

                                size =  64,

                                bound = new sbyte[,] {
                                            { 8, 8, 8, 8, 8, 8, 8, 8, 8, 8 },
                                            { 8, 0, 0, 0, 0, X, X, X, X, 8 },
                                            { 8, 0, 0, 0, 0, 0, 0, 0, 0, 8 },
                                            { 8, 0, 0, 0, 0, X, X, 0, 0, 8 },
                                            { 8, X, X, 0, 0, 0, 0, 0, 0, 8 },
                                            { 8, X, 0, 0, X, 0, 0, 0, 0, 8 },
                                            { 8, X, 0, 0, 0, 0, 0, X, X, 8 },
                                            { 8, 0, 0, 0, 0, 0, X, 0, 0, 8 },
                                            { 8, 0, A, 0, B, 0, C, 0, D, 8 },
                                            { 8, 8, 8, 8, 8, 8, 8, 8, 8, 8 }
                                        },

                                hint =  new char[]                  { 'L','U','R','U','R','U','L' },

                                stars = new sbyte[DATA_STAR_SIZE]   { 7, 8 },
                            },

            /* Level 0 */   new Data() {

                                size =  64,

                                bound = new sbyte[,] {
                                            { 8, 8, 8, 8, 8, 8, 8, 8, 8, 8 },
                                            { 8, X, X, X, X, X, X, X, X, 8 },
                                            { 8, X, X, X, 0, 0, 0, X, X, 8 },
                                            { 8, X, X, 0, 0, A, 0, X, X, 8 },
                                            { 8, 0, 0, 0, 0, B, 0, 0, 0, 8 },
                                            { 8, 0, 0, X, X, X, X, X, X, 8 },
                                            { 8, 0, 0, X, X, 0, 0, 0, 0, 8 },
                                            { 8, 0, 0, X, X, 0, C, X, 0, 8 },
                                            { 8, 0, 0, 0, 0, 0, D, 0, 0, 8 },
                                            { 8, 8, 8, 8, 8, 8, 8, 8, 8, 8 }
                                        },

                                hint =  new char[]                  { 'U','L','D','R','D','L','D' },

                                stars = new sbyte[DATA_STAR_SIZE]   { 7, 8 },
                            },

            /* Level 0 */   new Data() {

                                size =  64,

                                bound = new sbyte[,] {
                                            { 8, 8, 8, 8, 8, 8, 8, 8, 8, 8 },
                                            { 8, X, X, 0, 0, 0, 0, 0, 0, 8 },
                                            { 8, X, X, 0, 0, 0, 0, 0, 0, 8 },
                                            { 8, X, X, X, X, X, X, 0, 0, 8 },
                                            { 8, 0, 0, X, X, X, 0, 0, 0, 8 },
                                            { 8, 0, 0, 0, X, 0, 0, 0, 0, 8 },
                                            { 8, 0, 0, 0, 0, 0, 0, 0, 0, 8 },
                                            { 8, 0, 0, 0, 0, 0, 0, 0, X, 8 },
                                            { 8, 0, A, B, C, D, 0, 0, X, 8 },
                                            { 8, 8, 8, 8, 8, 8, 8, 8, 8, 8 }
                                        },

                                hint =  new char[]                  { 'U','R','U','L','D','R','U' },

                                stars = new sbyte[DATA_STAR_SIZE]   { 7, 8 },
                            },

            /* Level 0 */   new Data() {

                                size =  64,

                                bound = new sbyte[,] {
                                            { 8, 8, 8, 8, 8, 8, 8, 8, 8, 8 },
                                            { 8, 0, 0, 0, 0, 0, 0, C, D, 8 },
                                            { 8, 0, 0, 0, X, 0, 0, 0, 0, 8 },
                                            { 8, 0, 0, 0, X, 0, 0, X, X, 8 },
                                            { 8, 0, 0, 0, X, 0, 0, 0, 0, 8 },
                                            { 8, 0, 0, X, X, X, X, 0, 0, 8 },
                                            { 8, X, X, X, 0, 0, 0, 0, 0, 8 },
                                            { 8, 0, 0, 0, 0, 0, 0, 0, X, 8 },
                                            { 8, X, X, A, B, 0, 0, X, X, 8 },
                                            { 8, 8, 8, 8, 8, 8, 8, 8, 8, 8 }
                                        },

                                hint =  new char[]                  { 'D','L','D','R','U','R','U' },

                                stars = new sbyte[DATA_STAR_SIZE]   { 7, 8 },
                            }, 

            /* Level 0 */   new Data() {

                                size =  64,

                                bound = new sbyte[,] {
                                            { 8, 8, 8, 8, 8, 8, 8, 8, 8, 8 },
                                            { 8, 0, 0, 0, 0, 0, 0, C, D, 8 },
                                            { 8, 0, 0, 0, X, 0, 0, 0, 0, 8 },
                                            { 8, 0, 0, 0, X, 0, 0, X, X, 8 },
                                            { 8, 0, 0, 0, X, 0, 0, 0, 0, 8 },
                                            { 8, 0, 0, 0, X, X, X, 0, 0, 8 },
                                            { 8, X, X, X, 0, 0, 0, 0, 0, 8 },
                                            { 8, X, 0, 0, 0, 0, 0, 0, 0, 8 },
                                            { 8, A, B, 0, 0, 0, 0, 0, X, 8 },
                                            { 8, 8, 8, 8, 8, 8, 8, 8, 8, 8 }
                                        },

                                hint =  new char[]                  { 'U','R','U','L','U','R','D','L','D' },

                                stars = new sbyte[DATA_STAR_SIZE]   { 9, 10 },
                            },

            /* Level 0 */   new Data() {

                                size =  64,

                                bound = new sbyte[,] {
                                            { 8, 8, 8, 8, 8, 8, 8, 8, 8, 8 },
                                            { 8, 0, 0, 0, 0, 0, 0, C, D, 8 },
                                            { 8, 0, 0, 0, X, 0, 0, 0, 0, 8 },
                                            { 8, 0, 0, 0, X, 0, 0, X, X, 8 },
                                            { 8, 0, 0, 0, X, 0, 0, 0, 0, 8 },
                                            { 8, 0, 0, X, X, X, X, 0, 0, 8 },
                                            { 8, X, X, 0, 0, 0, 0, 0, 0, 8 },
                                            { 8, 0, 0, 0, 0, 0, 0, X, X, 8 },
                                            { 8, A, B, 0, 0, 0, 0, 0, 0, 8 },
                                            { 8, 8, 8, 8, 8, 8, 8, 8, 8, 8 }
                                        },

                                hint =  new char[]                  { 'D','L','D','R','D','L','U','R','U','R','D' },

                                stars = new sbyte[DATA_STAR_SIZE]   { 10, 11 },
                            },

            /* Level 0 */   new Data() {

                                size =  64,

                                bound = new sbyte[,] {
                                            { 8, 8, 8, 8, 8, 8, 8, 8, 8, 8 },
                                            { 8, X, X, X, 0, 0, 0, X, X, 8 },
                                            { 8, X, X, 0, 0, 0, 0, 0, X, 8 },
                                            { 8, 0, 0, 0, 0, 0, X, X, X, 8 },
                                            { 8, 0, 0, 0, 0, 0, 0, X, X, 8 },
                                            { 8, 0, 0, 0, 0, 0, 0, X, X, 8 },
                                            { 8, 0, X, 0, 0, 0, 0, X, X, 8 },
                                            { 8, A, X, X, X, C, 0, X, X, 8 },
                                            { 8, B, X, X, X, D, 0, X, X, 8 },
                                            { 8, 8, 8, 8, 8, 8, 8, 8, 8, 8 }
                                        },

                                hint =  new char[]                  { 'U','R','D','L','D','R','D' },

                                stars = new sbyte[DATA_STAR_SIZE]   { 7, 8 },
                            },

            /* Level 27 */  new Data() {

                                size =  64,

                                bound = new sbyte[,] {
                                            { 8, 8, 8, 8, 8, 8, 8, 8, 8, 8 },
                                            { 8, X, X, X, X, X, 0, X, X, 8 },
                                            { 8, X, X, X, X, X, 0, X, X, 8 },
                                            { 8, X, X, X, X, 0, 0, X, X, 8 },
                                            { 8, X, X, X, X, 0, 0, X, X, 8 },
                                            { 8, 0, 0, 0, 0, A, X, X, X, 8 },
                                            { 8, X, 0, 0, 0, B, X, X, X, 8 },
                                            { 8, X, X, 0, 0, C, X, X, X, 8 },
                                            { 8, X, X, 0, 0, D, X, X, X, 8 },
                                            { 8, 8, 8, 8, 8, 8, 8, 8, 8, 8 }
                                        },

                                hint =  new char[]                  { 'U','R','U','D','L','D','L' },

                                stars = new sbyte[DATA_STAR_SIZE]   { 7, 8 },
                            },

            /* Level 27 */  new Data() {

                                size =  100,

                                bound = new sbyte[,] {
                                            { 0, 0, 0, 0, 0, 0, 0, X, X, 0 },
                                            { 0, 0, 0, 0, 0, 0, X, X, X, 0 },
                                            { 0, 0, 0, 0, 0, 0, X, X, 0, 0 },
                                            { 0, 0, 0, X, X, X, X, X, 0, 0 },
                                            { 0, 0, 0, A, X, C, 0, 0, 0, X },
                                            { 0, 0, 0, B, X, D, 0, 0, 0, X },
                                            { 0, 0, 0, X, X, X, 0, 0, 0, X },
                                            { 0, 0, 0, 0, 0, 0, 0, 0, 0, X },
                                            { 0, 0, 0, 0, 0, 0, 0, 0, 0, X },
                                            { 0, 0, 0, 0, 0, 0, 0, 0, 0, X }
                                        },

                                hint =  new char[]                  { 'L','D','R','U','R','U','D','L','D','L' },

                                stars = new sbyte[DATA_STAR_SIZE]   { 10, 11 },
                            },


                 /* Level 23 */   new Data() {

                                size =  64,

                                bound = new sbyte[,] {
                                            { 8, 8, 8, 8, 8, 8, 8, 8, 8, 8 },
                                            { 8, 0, 0, 0, 0, X, X, X, X, 8 },
                                            { 8, 0, 0, 0, 0, X, X, X, 0, 8 },
                                            { 8, 0, 0, 0, 0, X, X, 0, 0, 8 },
                                            { 8, 0, 0, 0, 0, 0, 0, 0, 0, 8 },
                                            { 8, X, X, 0, 0, 0, 0, 0, 0, 8 },
                                            { 8, 0, X, 0, 0, 0, 0, 0, 0, 8 },
                                            { 8, 0, 0, 0, 0, 0, 0, 0, 0, 8 },
                                            { 8, A, B, C, D, 0, 0, 0, 0, 8 },
                                            { 8, 8, 8, 8, 8, 8, 8, 8, 8, 8 }
                                        },

                                hint =  new char[]                  { 'R','U','L','D','R','D','L' },

                                stars = new sbyte[DATA_STAR_SIZE]   { 6, 7 },
                            },

            /* Level 0 */   new Data() {

                                size =  64,

                                bound = new sbyte[,] {
                                            { 8, 8, 8, 8, 8, 8, 8, 8, 8, 8 },
                                            { 8, X, X, 0, 0, 0, 0, 0, 0, 8 },
                                            { 8, X, 0, 0, A, B, 0, 0, 0, 8 },
                                            { 8, X, X, X, X, X, 0, 0, 0, 8 },
                                            { 8, 0, 0, 0, 0, 0, 0, X, X, 8 },
                                            { 8, 0, 0, 0, 0, 0, 0, X, X, 8 },
                                            { 8, 0, 0, X, X, 0, 0, X, X, 8 },
                                            { 8, 0, 0, 0, X, 0, 0, X, X, 8 },
                                            { 8, 0, 0, C, D, 0, 0, X, X, 8 },
                                            { 8, 8, 8, 8, 8, 8, 8, 8, 8, 8 }
                                        },

                                hint =  new char[]                  { 'U','L','D','L','U','R','U','R' },

                                stars = new sbyte[DATA_STAR_SIZE]   { 8, 9 },
                            },

            /* Level 0 */   new Data() {

                                size =  64,

                                bound = new sbyte[,] {
                                            { 8, 8, 8, 8, 8, 8, 8, 8, 8, 8 },
                                            { 8, X, X, X, X, X, X, C, D, 8 },
                                            { 8, X, X, X, X, X, X, 0, 0, 8 },
                                            { 8, X, X, 0, 0, X, X, 0, 0, 8 },
                                            { 8, X, X, A, 0, 0, 0, 0, 0, 8 },
                                            { 8, X, X, B, 0, 0, 0, 0, 0, 8 },
                                            { 8, X, X, 0, 0, X, X, X, X, 8 },
                                            { 8, 0, 0, 0, 0, X, X, X, X, 8 },
                                            { 8, 0, 0, 0, 0, 0, X, X, X, 8 },
                                            { 8, 8, 8, 8, 8, 8, 8, 8, 8, 8 }
                                        },

                                hint =  new char[]                  { 'D','R','D','L','U','R','D' },

                                stars = new sbyte[DATA_STAR_SIZE]   { 7, 8 },
                            },

            /* Level X */  new Data() {

                                size =  64,

                                bound = new sbyte[,] {
                                            { 8, 8, 8, 8, 8, 8, 8, 8, 8, 8 },
                                            { 8, 0, 0, A, B, C, D, 0, 0, 8 },
                                            { 8, 0, 0, 0, 0, 0, 0, 0, 0, 8 },
                                            { 8, 0, 0, X, 0, 0, X, 0, 0, 8 },
                                            { 8, 0, 0, X, X, X, X, 0, 0, 8 },
                                            { 8, 0, 0, X, X, X, X, 0, 0, 8 },
                                            { 8, 0, 0, X, 0, 0, 0, 0, 0, 8 },
                                            { 8, X, X, X, 0, 0, 0, X, X, 8 },
                                            { 8, X, X, X, X, X, X, X, X, 8 },
                                            { 8, 8, 8, 8, 8, 8, 8, 8, 8, 8 }
                                        },

                                hint =  new char[]                  { 'D','R','D','L','U','R','D' },

                                stars = new sbyte[DATA_STAR_SIZE]   { 7, 8 },
                            },

                /* Level 0 */   new Data() {

                                size =  100,

                                bound = new sbyte[,] {
                                            { X, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                                            { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                                            { 0, 0, X, X, X, X, X, X, 0, X },
                                            { 0, 0, X, 0, X, 0, 0, 0, 0, X },
                                            { 0, 0, X, 0, 0, 0, 0, 0, 0, X },
                                            { 0, 0, X, 0, 0, 0, 0, 0, 0, 0 },
                                            { 0, 0, X, 0, 0, 0, 0, 0, 0, 0 },
                                            { 0, 0, X, A, 0, X, B, 0, X, X },
                                            { 0, 0, 0, 0, 0, 0, 0, 0, X, X },
                                            { 0, 0, X, 0, C, X, 0, D, X, X }
                                        },

                                hint =  new char[]                  { 'L','D','L','D','R','U','R','U' },

                                stars = new sbyte[DATA_STAR_SIZE]   { 8, 9 },
                            },

                /* Level 0 */   new Data() {    /* Rotate and change starting position */

                                size =  64,

                                bound = new sbyte[,] {
                                            { 8, 8, 8, 8, 8, 8, 8, 8, 8, 8 },
                                            { 8, X, X, X, X, X, 0, 0, 0, 8 },
                                            { 8, X, X, X, X, 0, 0, 0, 0, 8 },
                                            { 8, X, 0, 0, 0, 0, 0, X, 0, 8 },
                                            { 8, 0, 0, 0, 0, 0, 0, X, 0, 8 },
                                            { 8, A, B, C, D, 0, 0, 0, 0, 8 },
                                            { 8, 0, 0, 0, 0, 0, 0, 0, 0, 8 },
                                            { 8, 0, 0, 0, 0, 0, 0, 0, 0, 8 },
                                            { 8, X, X, X, X, 0, 0, X, X, 8 },
                                            { 8, 8, 8, 8, 8, 8, 8, 8, 8, 8 }
                                        },

                                hint =  new char[]                  { 'R','D','L','U','R','U','R' },

                                stars = new sbyte[DATA_STAR_SIZE]   { 7, 8 },
                            },

                /* Level XX */   new Data() {

                                size =  64,

                                bound = new sbyte[,] {
                                            { 8, 8, 8, 8, 8, 8, 8, 8, 8, 8 },
                                            { 8, 0, 0, 0, 0, 0, X, 0, 0, 8 },
                                            { 8, 0, 0, X, X, X, X, 0, 0, 8 },
                                            { 8, 0, 0, 0, 0, 0, X, 0, 0, 8 },
                                            { 8, 0, 0, X, X, X, X, 0, 0, 8 },
                                            { 8, A, 0, 0, 0, 0, 0, 0, 0, 8 },
                                            { 8, B, 0, 0, 0, 0, 0, 0, 0, 8 },
                                            { 8, C, 0, 0, 0, 0, 0, 0, 0, 8 },
                                            { 8, D, 0, 0, 0, 0, 0, 0, 0, 8 },
                                            { 8, 8, 8, 8, 8, 8, 8, 8, 8, 8 }
                                        },

                                hint =  new char[]                  { 'U','R','D','R','U','L','D','R' },

                                stars = new sbyte[DATA_STAR_SIZE]   { 8, 9 },
                            },

                /* Level XX */   new Data() {

                                size =  64,

                                bound = new sbyte[,] {
                                            { 8, 8, 8, 8, 8, 8, 8, 8, 8, 8 },
                                            { 8, 0, 0, 0, 0, 0, 0, X, X, 8 },
                                            { 8, 0, A, B, 0, 0, 0, 0, 0, 8 },
                                            { 8, X, X, X, 0, 0, X, 0, 0, 8 },
                                            { 8, 0, 0, 0, 0, 0, X, 0, 0, 8 },
                                            { 8, X, C, D, X, X, X, 0, 0, 8 },
                                            { 8, X, 0, 0, X, X, 0, 0, 0, 8 },
                                            { 8, 0, 0, 0, 0, 0, 0, 0, 0, 8 },
                                            { 8, 0, 0, 0, 0, 0, 0, 0, 0, 8 },
                                            { 8, 8, 8, 8, 8, 8, 8, 8, 8, 8 }
                                        },

                                hint =  new char[]                  { 'R','D','L','U','R','U','L' },

                                stars = new sbyte[DATA_STAR_SIZE]   { 7, 8 },
                            },

//             /* Level XX */   new Data() {

//                                 size =  64,

//                                 bound = new sbyte[,] {
//                                             { 8, 8, 8, 8, 8, 8, 8, 8, 8, 8 },
//                                             { 8, X, X, X, X, X, X, X, X, 8 },
//                                             { 8, X, X, X, X, X, X, X, X, 8 },
//                                             { 8, X, X, X, X, X, X, X, X, 8 },
//                                             { 8, X, X, X, X, X, X, X, X, 8 },
//                                             { 8, X, X, X, X, X, X, X, X, 8 },
//                                             { 8, X, X, X, X, X, X, X, X, 8 },
//                                             { 8, X, X, X, X, X, X, X, X, 8 },
//                                             { 8, X, X, X, X, X, X, X, X, 8 },
//                                             { 8, 8, 8, 8, 8, 8, 8, 8, 8, 8 }
//                                         },

//                                 hint =  new char[]                  { 'L','D','R','U','R' },

//                                 stars = new sbyte[DATA_STAR_SIZE]   { 4, 5 },
//                             },

//             /* Level XX */   new Data() {

//                                 size =  64,

//                                 bound = new sbyte[,] {
//                                             { 8, 8, 8, 8, 8, 8, 8, 8, 8, 8 },
//                                             { 8, 0, 0, 0, 0, 0, 0, 0, 0, 8 },
//                                             { 8, 0, 0, 0, 0, 0, 0, 0, 0, 8 },
//                                             { 8, 0, 0, 0, 0, 0, 0, 0, 0, 8 },
//                                             { 8, 0, 0, 0, 0, 0, 0, 0, 0, 8 },
//                                             { 8, 0, 0, 0, 0, 0, 0, 0, 0, 8 },
//                                             { 8, 0, 0, 0, 0, 0, 0, 0, 0, 8 },
//                                             { 8, 0, 0, 0, 0, 0, 0, 0, 0, 8 },
//                                             { 8, 0, 0, 0, 0, 0, 0, 0, 0, 8 },
//                                             { 8, 8, 8, 8, 8, 8, 8, 8, 8, 8 }
//                                         },

//                                 hint =  new char[]                  { 'L','D','R','U','R' },

//                                 stars = new sbyte[DATA_STAR_SIZE]   { 4, 5 },
//                             },

        };
    }
}
