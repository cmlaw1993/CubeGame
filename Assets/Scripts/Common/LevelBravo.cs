using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelBravo : Level
{
    public LevelBravo()
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

            /* Level 0 */   new Data() {

                                size =  64,

                                bound = new sbyte[,] {
                                            { X, X, X, X, X, X, X, X, X, X, },
                                            { X, X, X, X, X, X, X, X, X, X, },
                                            { X, X, X, 0, 0, 0, 0, 0, X, X, },
                                            { X, X, 0, 0, 0, 0, 0, 0, X, X, },
                                            { X, X, 0, A, 0, X, 0, X, X, X, },
                                            { X, X, B, 0, 0, 0, 0, C, X, X, },
                                            { X, X, 0, 0, 0, 0, 0, D, X, X, },
                                            { X, X, X, X, 0, 0, 0, 0, X, X, },
                                            { X, X, X, X, X, X, X, X, X, X, },
                                            { X, X, X, X, X, X, X, X, X, X, },
                                        },

                                hint =  new char[]                  { 'D','L','U','R', },

                                stars = new sbyte[DATA_STAR_SIZE]   { 4, 5 },
                            },


            /* Level 17 */   new Data() {

                                size =  64,

                                bound = new sbyte[,] {
                                            { 8, 8, 8, 8, 8, 8, 8, 8, 8, 8 },
                                            { 8, X, X, X, X, X, X, X, X, 8 },
                                            { 8, X, X, X, X, X, X, X, X, 8 },
                                            { 8, X, X, 0, 0, 0, 0, 0, 0, 8 },
                                            { 8, X, X, 0, 0, 0, 0, 0, 0, 8 },
                                            { 8, X, X, 0, 0, X, 0, 0, 0, 8 },
                                            { 8, X, X, 0, 0, 0, X, 0, 0, 8 },
                                            { 8, X, X, X, 0, 0, 0, 0, 0, 8 },
                                            { 8, X, A, B, C, D, 0, 0, 0, 8 },
                                            { 8, 8, 8, 8, 8, 8, 8, 8, 8, 8 }
                                        },

                                hint =  new char[]                  { 'R','U','L','U' },

                                stars = new sbyte[DATA_STAR_SIZE]   { 4, 5 },
                            },

            /* Level 19 */  new Data() {
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

                                hint =  new char[]                  { 'L','U','L','D' },

                                stars = new sbyte[DATA_STAR_SIZE]   { 4, 5 },
                            },

            /* Level 20 */  new Data() {

                                size =  64,

                                bound = new sbyte[,] {
                                            { 8, 8, 8, 8, 8, 8, 8, 8, 8, 8 },
                                            { 8, 0, 0, 0, 0, X, 0, 0, 0, 8 },
                                            { 8, 0, 0, 0, 0, 0, 0, 0, 0, 8 },
                                            { 8, 0, 0, X, A, B, X, 0, 0, 8 },
                                            { 8, 0, 0, X, X, X, X, 0, 0, 8 },
                                            { 8, 0, 0, X, C, D, X, 0, 0, 8 },
                                            { 8, 0, 0, 0, 0, 0, 0, 0, 0, 8 },
                                            { 8, X, 0, 0, 0, 0, 0, 0, 0, 8 },
                                            { 8, X, 0, 0, 0, X, 0, 0, 0, 8 },
                                            { 8, 8, 8, 8, 8, 8, 8, 8, 8, 8 }
                                        },

                                hint =  new char[]                  { 'D','L','U','L' },

                                stars = new sbyte[DATA_STAR_SIZE]   { 4, 5 },
                            },

            /* Level 21 */   new Data() {

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


            /* Level 22 */   new Data() {

                                size =  64,

                                bound = new sbyte[,] {
                                            { 8, 8, 8, 8, 8, 8, 8, 8, 8, 8 },
                                            { 8, X, X, X, X, X, X, X, X, 8 },
                                            { 8, X, 0, 0, 0, 0, 0, 0, X, 8 },
                                            { 8, X, A, B, 0, 0, 0, 0, X, 8 },
                                            { 8, X, X, 0, 0, 0, 0, 0, X, 8 },
                                            { 8, X, 0, 0, 0, 0, 0, 0, X, 8 },
                                            { 8, X, C, 0, 0, 0, 0, 0, X, 8 },
                                            { 8, X, D, 0, 0, 0, 0, 0, X, 8 },
                                            { 8, X, X, X, X, X, X, X, X, 8 },
                                            { 8, 8, 8, 8, 8, 8, 8, 8, 8, 8 }
                                        },

                                hint =  new char[]                  { 'R','U','L','U' },

                                stars = new sbyte[DATA_STAR_SIZE]   { 4, 5 },
                            },

            /* Level 23 */   new Data() {

                                size =  64,

                                bound = new sbyte[,] {
                                            { 8, 8, 8, 8, 8, 8, 8, 8, 8, 8 },
                                            { 8, X, X, 0, 0, 0, X, 0, 0, 8 },
                                            { 8, X, 0, 0, 0, 0, 0, 0, 0, 8 },
                                            { 8, X, 0, 0, 0, 0, 0, 0, 0, 8 },
                                            { 8, X, 0, 0, 0, 0, 0, X, X, 8 },
                                            { 8, X, 0, 0, 0, 0, 0, X, X, 8 },
                                            { 8, X, 0, 0, 0, 0, 0, 0, 0, 8 },
                                            { 8, X, A, B, C, D, 0, 0, 0, 8 },
                                            { 8, X, X, X, X, X, X, X, X, 8 },
                                            { 8, 8, 8, 8, 8, 8, 8, 8, 8, 8 }
                                        },

                                hint =  new char[]                  { 'R','U','L','D' },

                                stars = new sbyte[DATA_STAR_SIZE]   { 4, 5 },
                            },

            /* Level 24 */   new Data() {

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

            /* Level 25 */   new Data() {

                                size =  64,

                                bound = new sbyte[,] {
                                            { 8, 8, 8, 8, 8, 8, 8, 8, 8, 8 },
                                            { 8, X, X, X, X, X, X, X, X, 8 },
                                            { 8, X, X, X, 0, 0, X, X, X, 8 },
                                            { 8, X, 0, 0, 0, 0, 0, 0, X, 8 },
                                            { 8, X, 0, 0, 0, 0, 0, 0, X, 8 },
                                            { 8, X, 0, 0, 0, 0, 0, 0, X, 8 },
                                            { 8, X, 0, 0, 0, 0, 0, 0, X, 8 },
                                            { 8, X, A, B, C, D, X, X, X, 8 },
                                            { 8, X, X, X, X, X, X, X, X, 8 },
                                            { 8, 8, 8, 8, 8, 8, 8, 8, 8, 8 }
                                        },

                                hint =  new char[]                  { 'U','R','D','L' },

                                stars = new sbyte[DATA_STAR_SIZE]   { 4, 6 },
                            },

            /* Level 26 */  new Data() {

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

            /* Level 27 */  new Data() {    /* Replace this ? */

                                size =  64,

                                bound = new sbyte[,] {
                                            { 8, 8, 8, 8, 8, 8, 8, 8, 8, 8 },
                                            { 8, X, X, 0, 0, 0, 0, 0, 0, 8 },
                                            { 8, 0, 0, 0, 0, 0, 0, 0, 0, 8 },
                                            { 8, 0, 0, X, A, B, X, 0, 0, 8 },
                                            { 8, 0, 0, X, X, X, X, 0, 0, 8 },
                                            { 8, 0, 0, X, X, X, X, 0, 0, 8 },
                                            { 8, 0, 0, X, C, D, X, 0, 0, 8 },
                                            { 8, 0, 0, 0, 0, 0, 0, 0, 0, 8 },
                                            { 8, 0, 0, 0, 0, 0, 0, X, X, 8 },
                                            { 8, 8, 8, 8, 8, 8, 8, 8, 8, 8 }
                                        },

                                hint =  new char[]                  { 'U','R','D','L' },

                                stars = new sbyte[DATA_STAR_SIZE]   { 4, 5 },
                            },

            /* Level 28 */   new Data() {

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

            /* Level 29 */   new Data() {

                                size =  64,

                                bound = new sbyte[,] {
                                            { 8, 8, 8, 8, 8, 8, 8, 8, 8, 8 },
                                            { 8, X, X, X, X, X, X, X, X, 8 },
                                            { 8, X, A, 0, 0, 0, 0, 0, X, 8 },
                                            { 8, X, B, 0, 0, 0, 0, 0, X, 8 },
                                            { 8, X, C, D, X, X, 0, 0, X, 8 },
                                            { 8, X, 0, 0, X, X, 0, 0, X, 8 },
                                            { 8, X, 0, 0, 0, 0, 0, 0, X, 8 },
                                            { 8, X, X, 0, 0, 0, 0, X, X, 8 },
                                            { 8, X, X, X, X, X, X, X, X, 8 },
                                            { 8, 8, 8, 8, 8, 8, 8, 8, 8, 8 }
                                        },

                                hint =  new char[]                  { 'R','D','R','U' },

                                stars = new sbyte[DATA_STAR_SIZE]   { 4, 5 },
                            },

            /* Level 30 */   new Data() {

                                size =  64,

                                bound = new sbyte[,] {
                                            { 8, 8, 8, 8, 8, 8, 8, 8, 8, 8 },
                                            { 8, X, X, X, X, X, X, X, X, 8 },
                                            { 8, X, C, 0, 0, 0, 0, 0, X, 8 },
                                            { 8, X, X, D, 0, 0, 0, 0, X, 8 },
                                            { 8, X, X, X, X, 0, 0, 0, X, 8 },
                                            { 8, X, X, 0, 0, 0, 0, 0, X, 8 },
                                            { 8, X, 0, 0, 0, 0, B, X, X, 8 },
                                            { 8, X, X, 0, 0, A, X, X, X, 8 },
                                            { 8, X, X, X, X, X, X, X, X, 8 },
                                            { 8, 8, 8, 8, 8, 8, 8, 8, 8, 8 }
                                        },

                                hint =  new char[]                  { 'L','U','R','U' },

                                stars = new sbyte[DATA_STAR_SIZE]   { 4, 5 },
                            },

            /* Level 31 */   new Data() {

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

            /* Level 32 */   new Data() {

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

            /* Level 33 */   new Data() {

                                size =  64,

                                bound = new sbyte[,] {
                                            { 8, 8, 8, 8, 8, 8, 8, 8, 8, 8 },
                                            { 8, X, X, X, X, X, X, X, X, 8 },
                                            { 8, X, 0, 0, A, 0, 0, X, X, 8 },
                                            { 8, X, 0, 0, B, 0, 0, C, X, 8 },
                                            { 8, X, X, X, X, X, 0, D, X, 8 },
                                            { 8, X, X, X, X, X, 0, 0, X, 8 },
                                            { 8, X, X, X, X, X, 0, 0, X, 8 },
                                            { 8, X, X, X, X, X, X, 0, X, 8 },
                                            { 8, X, X, X, X, X, X, X, X, 8 },
                                            { 8, 8, 8, 8, 8, 8, 8, 8, 8, 8 }
                                        },

                                hint =  new char[]                  { 'D','L','U','L' },

                                stars = new sbyte[DATA_STAR_SIZE]   { 4, 5 },
                            },

            /* Level 34 */   new Data() {

                                size =  64,

                                bound = new sbyte[,] {
                                            { 8, 8, 8, 8, 8, 8, 8, 8, 8, 8 },
                                            { 8, X, X, X, X, X, X, X, X, 8 },
                                            { 8, X, X, 0, 0, 0, 0, X, X, 8 },
                                            { 8, X, 0, 0, 0, 0, 0, 0, X, 8 },
                                            { 8, X, 0, 0, X, X, 0, 0, X, 8 },
                                            { 8, X, 0, 0, X, X, 0, 0, X, 8 },
                                            { 8, X, 0, C, X, X, 0, 0, X, 8 },
                                            { 8, X, 0, D, X, X, A, B, X, 8 },
                                            { 8, X, X, X, X, X, X, X, X, 8 },
                                            { 8, 8, 8, 8, 8, 8, 8, 8, 8, 8 }
                                        },

                                hint =  new char[]                  { 'L','U','L','D' },

                                stars = new sbyte[DATA_STAR_SIZE]   { 4, 5 },
                            },

            /* Level 35 */   new Data() {

                                size =  64,

                                bound = new sbyte[,] {
                                            { 8, 8, 8, 8, 8, 8, 8, 8, 8, 8 },
                                            { 8, 0, 0, 0, 0, 0, 0, 0, 0, 8 },
                                            { 8, 0, 0, X, X, X, X, 0, 0, 8 },
                                            { 8, 0, 0, X, X, X, X, 0, 0, 8 },
                                            { 8, 0, 0, X, A, B, 0, 0, 0, 8 },
                                            { 8, 0, 0, X, X, X, X, X, X, 8 },
                                            { 8, 0, 0, X, X, X, X, X, X, 8 },
                                            { 8, 0, 0, 0, 0, X, X, X, X, 8 },
                                            { 8, 0, 0, 0, C, D, X, X, X, 8 },
                                            { 8, 8, 8, 8, 8, 8, 8, 8, 8, 8 }
                                        },

                                hint =  new char[]                  { 'L','U','R','D' },

                                stars = new sbyte[DATA_STAR_SIZE]   { 4, 5 },
                            },

            /* Level 36 */  new Data() {

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

            /* Level 37 */   new Data() {

                                size =  64,

                                bound = new sbyte[,] {
                                            { 8, 8, 8, 8, 8, 8, 8, 8, 8, 8 },
                                            { 8, 0, 0, 0, 0, 0, A, B, X, 8 },
                                            { 8, X, 0, 0, 0, 0, 0, 0, X, 8 },
                                            { 8, X, X, X, X, 0, 0, 0, X, 8 },
                                            { 8, X, X, X, X, 0, 0, 0, D, 8 },
                                            { 8, 0, 0, C, X, X, 0, 0, 0, 8 },
                                            { 8, 0, 0, 0, 0, 0, 0, 0, 0, 8 },
                                            { 8, X, X, X, X, 0, 0, 0, 0, 8 },
                                            { 8, X, X, X, X, 0, 0, 0, 0, 8 },
                                            { 8, 8, 8, 8, 8, 8, 8, 8, 8, 8 }
                                        },

                                hint =  new char[]                  { 'L','D','R','D' },

                                stars = new sbyte[DATA_STAR_SIZE]   { 4, 5 },
                            },

            /* Level 38 */   new Data() {

                                size =  64,

                                bound = new sbyte[,] {
                                            { 8, 8, 8, 8, 8, 8, 8, 8, 8, 8 },
                                            { 8, X, X, X, 0, 0, 0, X, X, 8 },
                                            { 8, X, X, D, 0, 0, 0, X, X, 8 },
                                            { 8, 0, 0, 0, 0, 0, 0, X, X, 8 },
                                            { 8, A, 0, 0, X, 0, 0, X, X, 8 },
                                            { 8, X, X, X, X, 0, 0, 0, X, 8 },
                                            { 8, X, X, X, 0, 0, 0, 0, X, 8 },
                                            { 8, 0, 0, 0, 0, 0, 0, 0, X, 8 },
                                            { 8, B, 0, 0, 0, X, C, 0, X, 8 },
                                            { 8, 8, 8, 8, 8, 8, 8, 8, 8, 8 }
                                        },

                                hint =  new char[]                  { 'R','U','R','D' },

                                stars = new sbyte[DATA_STAR_SIZE]   { 4, 5 },
                            },

            /* Level 39 */   new Data() {

                                size =  64,

                                bound = new sbyte[,] {
                                            { 8, 8, 8, 8, 8, 8, 8, 8, 8, 8 },
                                            { 8, X, 0, 0, X, C, 0, X, X, 8 },
                                            { 8, X, 0, 0, 0, 0, 0, 0, 0, 8 },
                                            { 8, X, 0, 0, X, X, 0, 0, D, 8 },
                                            { 8, X, 0, 0, A, B, 0, X, X, 8 },
                                            { 8, X, 0, 0, 0, X, 0, X, X, 8 },
                                            { 8, 0, 0, 0, X, 0, 0, 0, 0, 8 },
                                            { 8, 0, 0, 0, 0, 0, 0, 0, 0, 8 },
                                            { 8, 0, 0, 0, 0, X, X, X, X, 8 },
                                            { 8, 8, 8, 8, 8, 8, 8, 8, 8, 8 }
                                        },

                                hint =  new char[]                  { 'L','D','L','D' },

                                stars = new sbyte[DATA_STAR_SIZE]   { 4, 5 },
                            },

            /* Level 40 */   new Data() {

                                size =  64,

                                bound = new sbyte[,] {
                                            { 8, 8, 8, 8, 8, 8, 8, 8, 8, 8 },
                                            { 8, 0, 0, 0, X, D, X, C, 0, 8 },
                                            { 8, 0, 0, 0, X, 0, X, 0, 0, 8 },
                                            { 8, 0, 0, 0, 0, 0, 0, 0, 0, 8 },
                                            { 8, 0, 0, 0, 0, 0, 0, 0, X, 8 },
                                            { 8, 0, 0, 0, X, X, X, X, X, 8 },
                                            { 8, X, 0, 0, 0, A, 0, B, 0, 8 },
                                            { 8, X, 0, 0, 0, 0, 0, 0, 0, 8 },
                                            { 8, X, 0, 0, 0, 0, 0, 0, X, 8 },
                                            { 8, 8, 8, 8, 8, 8, 8, 8, 8, 8 }
                                        },

                                hint =  new char[]                  { 'R','D','L','U' },

                                stars = new sbyte[DATA_STAR_SIZE]   { 4, 5 },
                            },





            /* Level 22 */   new Data() {   /* Replace this? */

                                size =  64,

                                bound = new sbyte[,] {
                                            { 8, 8, 8, 8, 8, 8, 8, 8, 8, 8 },
                                            { 8, X, X, X, X, X, X, X, X, 8 },
                                            { 8, X, X, X, X, X, 0, 0, X, 8 },
                                            { 8, X, X, 0, 0, 0, 0, 0, X, 8 },
                                            { 8, X, 0, 0, 0, 0, 0, X, X, 8 },
                                            { 8, X, 0, 0, X, 0, 0, X, X, 8 },
                                            { 8, X, 0, 0, X, C, 0, X, X, 8 },
                                            { 8, X, A, B, X, D, 0, X, X, 8 },
                                            { 8, X, X, X, X, X, X, X, X, 8 },
                                            { 8, 8, 8, 8, 8, 8, 8, 8, 8, 8 }
                                        },

                                hint =  new char[]                  { 'R','U','R','U' },

                                stars = new sbyte[DATA_STAR_SIZE]   { 4, 5 },
                            },

            /* Level 23 */   new Data() {   /* REeplace this ? */

                                size =  64,

                                bound = new sbyte[,] {
                                            { 8, 8, 8, 8, 8, 8, 8, 8, 8, 8 },
                                            { 8, X, X, X, X, X, X, X, X, 8 },
                                            { 8, X, X, C, 0, 0, 0, X, X, 8 },
                                            { 8, X, X, 0, D, 0, 0, 0, X, 8 },
                                            { 8, X, X, X, 0, 0, 0, 0, X, 8 },
                                            { 8, X, X, X, X, X, 0, 0, X, 8 },
                                            { 8, X, A, 0, 0, 0, 0, 0, X, 8 },
                                            { 8, X, B, 0, 0, 0, 0, X, X, 8 },
                                            { 8, X, X, X, X, X, X, X, X, 8 },
                                            { 8, 8, 8, 8, 8, 8, 8, 8, 8, 8 }
                                        },

                                hint =  new char[]                  { 'R','U','L','U' },

                                stars = new sbyte[DATA_STAR_SIZE]   { 4, 5 },
                            },


            /* Level XX */   new Data() {

                                size =  64,

                                bound = new sbyte[,] {
                                            { 8, 8, 8, 8, 8, 8, 8, 8, 8, 8 },
                                            { 8, 0, 0, 0, 0, 0, 0, 0, 0, 8 },
                                            { 8, 0, 0, 0, 0, 0, 0, 0, 0, 8 },
                                            { 8, 0, 0, 0, 0, 0, 0, 0, 0, 8 },
                                            { 8, 0, 0, 0, X, 0, 0, 0, 0, 8 },
                                            { 8, 0, 0, 0, 0, 0, 0, 0, 0, 8 },
                                            { 8, 0, 0, 0, 0, 0, 0, 0, 0, 8 },
                                            { 8, 0, 0, 0, 0, 0, 0, 0, 0, 8 },
                                            { 8, A, B, C, D, 0, X, 0, 0, 8 },
                                            { 8, 8, 8, 8, 8, 8, 8, 8, 8, 8 }
                                        },

                                hint =  new char[]                  { 'U','R','D','R' },

                                stars = new sbyte[DATA_STAR_SIZE]   { 4, 5 },
                            },

            /* Level 23 */   new Data() {

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
            
            /* Level 19 */  new Data() {

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

            /* Level 25 */  new Data() {

                                size =  64,

                                bound = new sbyte[,] {
                                            { 8, 8, 8, 8, 8, 8, 8, 8, 8, 8 },
                                            { 8, X, X, X, X, X, X, X, X, 8 },
                                            { 8, X, X, 0, 0, 0, D, 0, X, 8 },
                                            { 8, X, 0, 0, 0, 0, 0, C, X, 8 },
                                            { 8, X, 0, 0, 0, 0, 0, X, X, 8 },
                                            { 8, X, 0, 0, 0, 0, 0, X, X, 8 },
                                            { 8, X, 0, 0, 0, 0, 0, B, X, 8 },
                                            { 8, X, X, 0, 0, 0, A, 0, X, 8 },
                                            { 8, X, X, X, X, X, X, X, X, 8 },
                                            { 8, 8, 8, 8, 8, 8, 8, 8, 8, 8 }
                                        },

                                hint =  new char[]                  { 'L','U','R','U' },

                                stars = new sbyte[DATA_STAR_SIZE]   { 4, 5 },
                            },

            /* Level 20 */   new Data() {

                                size =  64,

                                bound = new sbyte[,] {
                                            { 8, 8, 8, 8, 8, 8, 8, 8, 8, 8 },
                                            { 8, 0, 0, 0, 0, 0, 0, 0, 0, 8 },
                                            { 8, 0, 0, A, B, C, D, 0, 0, 8 },
                                            { 8, 0, 0, 0, 0, 0, 0, 0, 0, 8 },
                                            { 8, 0, 0, X, X, X, X, 0, 0, 8 },
                                            { 8, 0, 0, X, X, X, X, 0, 0, 8 },
                                            { 8, 0, 0, 0, 0, 0, 0, 0, 0, 8 },
                                            { 8, 0, 0, 0, 0, 0, 0, 0, 0, 8 },
                                            { 8, X, 0, 0, 0, 0, 0, 0, X, 8 },
                                            { 8, 8, 8, 8, 8, 8, 8, 8, 8, 8 }
                                        },

                                hint =  new char[]                  { 'L','D','R','U' },

                                stars = new sbyte[DATA_STAR_SIZE]   { 4, 5 },
                            },
        };
    }
}