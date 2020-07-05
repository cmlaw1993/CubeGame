using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelAlpha : Level
{
    public LevelAlpha()
    {
        data = new Data[] {

            /* Level 0 */   new Data() {

                                size =  64,

                                bound = new sbyte[,] {
                                            { X, X, X, X, X, X, X, X, X, X },
                                            { X, X, X, X, X, X, X, X, X, X },
                                            { X, X, 0, 0, 0, 0, 0, 0, X, X },
                                            { X, X, 0, A, 0, 0, C, 0, X, X },
                                            { X, X, 0, 0, 0, 0, 0, 0, X, X },
                                            { X, X, 0, 0, 0, 0, 0, 0, X, X },
                                            { X, X, 0, B, 0, 0, D, 0, X, X },
                                            { X, X, 0, 0, 0, 0, 0, 0, X, X },
                                            { X, X, X, X, X, X, X, X, X, X },
                                            { X, X, X, X, X, X, X, X, X, X },
                                        },

                                hint =  new char[]                  { 'U','R' },

                                stars = new sbyte[DATA_STAR_SIZE]   { 2, 3 },
                            },

            /* Level 1 */   new Data() {

                                size =  64,

                                bound = new sbyte[,] {
                                            { X, X, X, X, X, X, X, X, X, X },
                                            { X, X, X, X, X, X, X, X, X, X },
                                            { X, X, 0, 0, 0, 0, 0, 0, X, X },
                                            { X, X, 0, A, 0, 0, C, 0, X, X },
                                            { X, X, 0, 0, 0, 0, 0, 0, X, X },
                                            { X, X, 0, 0, 0, 0, 0, 0, X, X },
                                            { X, X, 0, B, 0, 0, D, 0, X, X },
                                            { X, X, 0, 0, 0, 0, 0, 0, X, X },
                                            { X, X, X, X, X, X, X, X, X, X },
                                            { X, X, X, X, X, X, X, X, X, X },
                                        },

                                hint =  new char[]                  { 'U','R' },

                                stars = new sbyte[DATA_STAR_SIZE]   { 2, 3 },
                            },

            /* Level 2 */   new Data() {

                                size =  64,

                                bound = new sbyte[,] {
                                            { X, X, X, X, X, X, X, X, X, X },
                                            { X, X, X, X, X, X, X, X, X, X },
                                            { X, X, X, X, X, X, X, X, X, X },
                                            { X, X, 0, 0, 0, 0, 0, 0, X, X },
                                            { X, X, 0, 0, 0, 0, 0, 0, X, X },
                                            { X, X, X, A, X, X, C, X, X, X },
                                            { X, X, X, B, X, X, D, X, X, X },
                                            { X, X, X, X, X, X, X, X, X, X },
                                            { X, X, X, X, X, X, X, X, X, X },
                                            { X, X, X, X, X, X, X, X, X, X },
                                        },

                                hint =  new char[]                  { 'U','R' },

                                stars = new sbyte[DATA_STAR_SIZE]   { 2, 3 },
                            },

            /* Level 3 */   new Data() {

                                size =  64,

                                bound = new sbyte[,] {
                                            { X, X, X, X, X, X, X, X, X, X },
                                            { X, X, X, X, X, X, X, X, X, X },
                                            { X, X, X, X, X, X, X, X, X, X },
                                            { X, X, X, X, X, C, D, X, X, X },
                                            { X, X, X, X, X, 0, 0, X, X, X },
                                            { X, X, X, 0, 0, 0, 0, X, X, X },
                                            { X, X, X, A, B, X, X, X, X, X },
                                            { X, X, X, X, X, X, X, X, X, X },
                                            { X, X, X, X, X, X, X, X, X, X },
                                            { X, X, X, X, X, X, X, X, X, X },
                                        },

                                hint =  new char[]                  { 'D','L' },

                                stars = new sbyte[DATA_STAR_SIZE]   { 2, 3 },
                            },

            /* Level 4 */   new Data() {

                                size =  64,

                                bound = new sbyte[,] {
                                            { X, X, X, X, X, X, X, X, X, X },
                                            { X, X, X, X, X, X, X, X, X, X },
                                            { X, X, X, X, X, X, X, X, X, X },
                                            { X, X, X, X, X, X, X, X, X, X },
                                            { X, X, A, B, C, D, 0, 0, X, X },
                                            { X, X, X, X, X, X, 0, 0, X, X },
                                            { X, X, X, X, X, X, X, X, X, X },
                                            { X, X, X, X, X, X, X, X, X, X },
                                            { X, X, X, X, X, X, X, X, X, X },
                                            { X, X, X, X, X, X, X, X, X, X },
                                        },

                                hint =  new char[]                  { 'R','D','R' },

                                stars = new sbyte[DATA_STAR_SIZE]   { 3, 4 },
                            },

            /* Level 5 */   new Data() {

                                size =  64,

                                bound = new sbyte[,] {
                                            { X, X, X, X, X, X, X, X, X, X },
                                            { X, X, X, X, X, X, X, X, X, X },
                                            { X, X, X, X, X, A, X, X, X, X },
                                            { X, X, X, X, X, B, X, X, X, X },
                                            { X, X, X, 0, 0, 0, 0, C, X, X },
                                            { X, X, X, 0, 0, 0, 0, D, X, X },
                                            { X, X, X, 0, 0, 0, X, X, X, X },
                                            { X, X, X, 0, 0, 0, X, X, X, X },
                                            { X, X, X, X, X, X, X, X, X, X },
                                            { X, X, X, X, X, X, X, X, X, X },
                                        },

                                hint =  new char[]                  { 'L','D','L' },

                                stars = new sbyte[DATA_STAR_SIZE]   { 3, 4 },
                            },

            /* Puzzle 6 */	new Data() {

								size =  64,

								bound = new sbyte[,] {
											{ X, X, X, X, X, X, X, X, X, X, },
											{ X, X, X, X, X, X, X, X, X, X, },
											{ X, X, 0, A, 0, 0, 0, X, X, X, },
											{ X, X, 0, B, 0, 0, 0, 0, X, X, },
											{ X, X, X, X, X, X, 0, 0, X, X, },
											{ X, X, X, X, X, X, 0, 0, X, X, },
											{ X, X, X, X, X, X, 0, C, X, X, },
											{ X, X, X, X, X, X, 0, D, X, X, },
											{ X, X, X, X, X, X, X, X, X, X, },
											{ X, X, X, X, X, X, X, X, X, X, },
										},

								hint =  new char[]                  { 'U','R','D', },

								stars = new sbyte[DATA_STAR_SIZE]   { 3, 4 },
							},
            
            /* Level 7 */  new Data() {

                                size =  64,

                                bound = new sbyte[,] {
                                            { X, X, X, X, X, X, X, X, X, X },
                                            { X, X, X, X, X, X, X, X, X, X },
                                            { X, X, X, 0, 0, X, X, X, X, X },
                                            { X, X, X, 0, 0, X, X, X, X, X },
                                            { X, X, X, 0, A, X, X, X, X, X },
                                            { X, X, X, 0, B, X, X, X, X, X },
                                            { X, X, X, 0, 0, C, D, 0, X, X },
                                            { X, X, X, 0, 0, 0, 0, X, X, X },
                                            { X, X, X, X, X, X, X, X, X, X },
                                            { X, X, X, X, X, X, X, X, X, X },
                                        },

                                hint =  new char[]                  { 'R','D','L' },

                                stars = new sbyte[DATA_STAR_SIZE]   { 3, 4 },
                            },

            /* Level 8 */   new Data() {

                                size =  64,

                                bound = new sbyte[,] {
                                            { X, X, X, X, X, X, X, X, X, X },
                                            { X, X, X, X, X, X, X, X, X, X },
                                            { X, X, A, B, 0, 0, 0, X, X, X },
                                            { X, X, 0, 0, 0, 0, 0, 0, X, X },
                                            { X, X, 0, X, X, X, 0, 0, X, X },
                                            { X, X, 0, X, X, X, 0, 0, X, X },
                                            { X, X, D, 0, 0, 0, 0, 0, X, X },
                                            { X, X, C, 0, 0, 0, 0, X, X, X },
                                            { X, X, X, X, X, X, X, X, X, X },
                                            { X, X, X, X, X, X, X, X, X, X },
                                        },

                                hint =  new char[]                  { 'R','U','L' },

                                stars = new sbyte[DATA_STAR_SIZE]   { 3, 4 },
                            },

			/* Puzzle 9 */	new Data() {

								size =  64,

								bound = new sbyte[,] {
											{ X, X, X, X, X, X, X, X, X, X, },
											{ X, X, X, X, X, X, X, X, X, X, },
											{ X, X, A, 0, 0, 0, 0, B, X, X, },
											{ X, X, X, 0, 0, 0, 0, 0, X, X, },
											{ X, X, 0, 0, X, X, 0, 0, X, X, },
											{ X, X, 0, 0, X, X, 0, 0, X, X, },
											{ X, X, 0, 0, 0, 0, 0, 0, X, X, },
											{ X, X, C, 0, 0, 0, D, X, X, X, },
											{ X, X, X, X, X, X, X, X, X, X, },
											{ X, X, X, X, X, X, X, X, X, X, },
										},

								hint =  new char[]                  { 'R','D','L', },

								stars = new sbyte[DATA_STAR_SIZE]   { 3, 4 },
							},

            /* Puzzle 10 */	new Data() {

								size =  64,

								bound = new sbyte[,] {
											{ X, X, X, X, X, X, X, X, X, X, },
											{ X, X, X, X, X, X, X, X, X, X, },
											{ X, X, X, 0, 0, 0, 0, X, X, X, },
											{ X, X, X, 0, 0, 0, 0, X, X, X, },
											{ X, X, X, 0, X, 0, A, X, X, X, },
											{ X, X, X, 0, 0, 0, B, X, X, X, },
											{ X, X, X, 0, 0, 0, C, X, X, X, },
											{ X, X, X, 0, X, 0, D, X, X, X, },
											{ X, X, X, X, X, X, X, X, X, X, },
											{ X, X, X, X, X, X, X, X, X, X, },
										},

								hint =  new char[]                  { 'L','U','L', },

								stars = new sbyte[DATA_STAR_SIZE]   { 3, 4 },
							},

            /* Puzzle 11 */	new Data() {

								size =  64,

								bound = new sbyte[,] {
											{ X, X, X, X, X, X, X, X, X, X, },
											{ X, X, X, X, X, X, X, X, X, X, },
											{ X, A, 0, 0, 0, 0, 0, 0, 0, X, },
											{ X, 0, 0, 0, B, 0, 0, 0, 0, X, },
											{ X, 0, 0, 0, 0, 0, 0, 0, 0, X, },
											{ X, 0, X, X, 0, C, 0, 0, 0, X, },
											{ X, 0, 0, D, X, X, 0, 0, 0, X, },
											{ X, 0, 0, 0, 0, 0, 0, 0, 0, X, },
											{ X, X, X, X, X, X, X, X, X, X, },
											{ X, X, X, X, X, X, X, X, X, X, },
										},

								hint =  new char[]                  { 'D','R','U', },

								stars = new sbyte[DATA_STAR_SIZE]   { 3, 4 },
							},

            /* Level 12 */   new Data() {

                                size =  64,

                                bound = new sbyte[,] {
                                            { X, X, X, X, X, X, X, X, X, X },
                                            { X, X, X, X, X, X, X, X, X, X },
                                            { X, X, 0, 0, A, 0, B, 0, X, X },
                                            { X, X, 0, 0, 0, 0, 0, 0, X, X },
                                            { X, X, 0, C, X, 0, X, D, X, X },
                                            { X, X, 0, 0, 0, 0, 0, 0, X, X },
                                            { X, X, 0, 0, 0, 0, 0, 0, X, X },
                                            { X, X, 0, 0, 0, 0, 0, 0, X, X },
                                            { X, X, X, X, X, X, X, X, X, X },
                                            { X, X, X, X, X, X, X, X, X, X },
                                        },

                                hint =  new char[]                  { 'D','L','D' },

                                stars = new sbyte[DATA_STAR_SIZE]   { 3, 4 },
                            },

            /* Level 13 */   new Data() {

                                size =  64,

                                bound = new sbyte[,] {
                                            { X, X, X, X, X, X, X, X, X, X, },
                                            { X, X, X, X, X, X, X, X, X, X, },
                                            { X, X, 0, A, 0, 0, 0, X, X, X, },
                                            { X, X, 0, 0, 0, B, 0, 0, X, X, },
                                            { X, X, 0, C, 0, X, 0, 0, X, X, },
                                            { X, X, 0, 0, 0, 0, 0, 0, X, X, },
                                            { X, X, 0, 0, 0, 0, 0, 0, X, X, },
                                            { X, X, 0, D, 0, X, 0, 0, X, X, },
                                            { X, X, X, X, X, X, X, X, X, X, },
                                            { X, X, X, X, X, X, X, X, X, X, },
                                        },

                                hint =  new char[]                  { 'R','U','L', },

                                stars = new sbyte[DATA_STAR_SIZE]   { 3, 4 },
                            },

            /* Level 14 */  new Data() {

                                size =  64,

                                bound = new sbyte[,] {
                                            { X, X, X, X, X, X, X, X, X, X },
                                            { X, X, X, X, X, X, X, X, X, X },
                                            { X, X, X, X, X, 0, 0, X, X, X },
                                            { X, X, X, X, 0, 0, 0, X, X, X },
                                            { X, X, X, 0, 0, 0, 0, 0, X, X },
                                            { X, X, 0, 0, 0, 0, 0, 0, X, X },
                                            { X, X, 0, 0, 0, 0, 0, 0, X, X },
                                            { X, X, A, B, C, D, 0, 0, X, X },
                                            { X, X, X, X, X, X, X, X, X, X },
                                            { X, X, X, X, X, X, X, X, X, X },
                                        },

                                hint =  new char[]                  { 'U','R','D' },

                                stars = new sbyte[DATA_STAR_SIZE]   { 3, 5 },
                            },

            /* Level 15 */  new Data() {

                                size =  64,

                                bound = new sbyte[,] {
                                            { X, X, X, X, X, X, X, X, X, X },
                                            { X, X, X, X, X, X, X, X, X, X },
                                            { X, X, 0, 0, 0, 0, 0, X, X, X },
                                            { X, X, 0, 0, 0, 0, 0, 0, X, X },
                                            { X, X, 0, 0, 0, 0, 0, 0, X, X },
                                            { X, X, 0, 0, 0, 0, 0, 0, X, X },
                                            { X, X, A, 0, 0, 0, 0, B, X, X },
                                            { X, X, X, C, 0, 0, D, X, X, X },
                                            { X, X, X, X, X, X, X, X, X, X },
                                            { X, X, X, X, X, X, X, X, X, X },
                                        },

                                hint =  new char[]                  { 'R','U','L' },

                                stars = new sbyte[DATA_STAR_SIZE]   { 3, 4 },
                            },

            /* Level 16 */  new Data() {

                                size =  64,

                                bound = new sbyte[,] {
                                            { X, X, X, X, X, X, X, X, X, X },
                                            { X, X, X, X, X, X, X, X, X, X },
                                            { X, X, X, X, X, X, X, 0, X, X },
                                            { X, X, X, X, X, X, C, 0, X, X },
                                            { X, X, 0, B, 0, 0, 0, 0, X, X },
                                            { X, X, 0, 0, 0, 0, 0, D, X, X },
                                            { X, X, A, 0, X, X, X, X, X, X },
                                            { X, X, X, 0, X, X, X, X, X, X },
                                            { X, X, X, X, X, X, X, X, X, X },
                                            { X, X, X, X, X, X, X, X, X, X },
                                        },

                                hint =  new char[]                  { 'D','L','U' },

                                stars = new sbyte[DATA_STAR_SIZE]   { 3, 4 },
                            },

            /* Level 17 */  new Data() {

                                size =  64,

                                bound = new sbyte[,] {
                                            { X, X, X, X, X, X, X, X, X, X },
                                            { X, X, X, X, X, X, X, X, X, X },
                                            { X, X, A, 0, 0, 0, D, X, X, X },
                                            { X, X, 0, 0, C, 0, 0, 0, X, X },
                                            { X, X, 0, 0, X, X, X, X, X, X },
                                            { X, X, 0, 0, X, X, X, X, X, X },
                                            { X, X, 0, B, X, X, X, X, X, X },
                                            { X, X, X, 0, X, X, X, X, X, X },
                                            { X, X, X, X, X, X, X, X, X, X },
                                            { X, X, X, X, X, X, X, X, X, X },
                                        },

                                hint =  new char[]                  { 'D','L','U' },

                                stars = new sbyte[DATA_STAR_SIZE]   { 3, 4 },
                            },

            /* Level 18 */   new Data() {

                                size =  64,

                                bound = new sbyte[,] {
                                            { X, X, X, X, X, X, X, X, X, X, },
                                            { X, X, X, X, X, X, X, X, X, X, },
                                            { X, X, X, X, 0, X, X, X, X, X, },
                                            { X, X, X, A, 0, X, X, X, X, X, },
                                            { X, X, X, 0, 0, X, X, X, X, X, },
                                            { X, X, X, X, B, X, X, X, X, X, },
                                            { X, X, X, C, D, 0, X, X, X, X, },
                                            { X, X, X, 0, 0, 0, X, X, X, X, },
                                            { X, X, X, X, X, X, X, X, X, X, },
                                            { X, X, X, X, X, X, X, X, X, X, },
                                        },

                                hint =  new char[]                  { 'D','R','D', },

                                stars = new sbyte[DATA_STAR_SIZE]   { 3, 4 },
                            },

            /* Puzzle 19 */	new Data() {

								size =  64,

								bound = new sbyte[,] {
											{ X, X, X, X, X, X, X, X, X, X, },
											{ X, X, X, X, X, X, X, X, X, X, },
											{ X, X, 0, 0, 0, 0, 0, 0, X, X, },
											{ X, X, A, 0, 0, X, 0, 0, X, X, },
											{ X, X, 0, 0, 0, 0, 0, B, X, X, },
											{ X, X, X, 0, 0, 0, 0, C, X, X, },
											{ X, X, D, 0, 0, 0, 0, X, X, X, },
											{ X, X, 0, 0, 0, 0, 0, 0, X, X, },
											{ X, X, X, X, X, X, X, X, X, X, },
											{ X, X, X, X, X, X, X, X, X, X, },
										},

								hint =  new char[]                  { 'U','R','U', },

								stars = new sbyte[DATA_STAR_SIZE]   { 3, 4 },
							},

            /* Level 20 */   new Data() {

                                size =  64,

                                bound = new sbyte[,] {
                                            { X, X, X, X, X, X, X, X, X, X, },
                                            { X, X, X, X, X, X, X, X, X, X, },
                                            { X, X, X, X, X, X, X, X, X, X, },
                                            { X, X, 0, 0, A, 0, 0, 0, 0, X, },
                                            { X, 0, 0, B, X, 0, 0, 0, 0, X, },
                                            { X, 0, C, X, 0, X, 0, 0, 0, X, },
                                            { X, D, 0, 0, 0, X, 0, X, 0, X, },
                                            { X, X, X, X, X, X, X, X, X, X, },
                                            { X, X, X, X, X, X, X, X, X, X, },
                                            { X, X, X, X, X, X, X, X, X, X, },
                                        },

                                hint =  new char[]                  { 'D','L','D'},

                                stars = new sbyte[DATA_STAR_SIZE]   { 3, 4 },
                            },

            /* Puzzle 21 */	new Data() {

								size =  64,

								bound = new sbyte[,] {
											{ X, X, X, X, X, X, X, X, X, X, },
											{ X, X, X, X, X, X, X, X, X, X, },
											{ X, X, 0, 0, A, 0, 0, 0, X, X, },
											{ X, X, 0, 0, 0, X, X, 0, X, X, },
											{ X, X, 0, 0, 0, 0, X, 0, X, X, },
											{ X, X, 0, B, 0, 0, 0, C, X, X, },
											{ X, X, 0, 0, X, 0, 0, X, X, X, },
											{ X, X, 0, 0, 0, 0, 0, D, X, X, },
											{ X, X, X, X, X, X, X, X, X, X, },
											{ X, X, X, X, X, X, X, X, X, X, },
										},

								hint =  new char[]                  { 'D','L','U', },

								stars = new sbyte[DATA_STAR_SIZE]   { 3, 4 },
							},

                /* Level 22 */   new Data() {

                                size =  64,

                                bound = new sbyte[,] {
                                            { X, X, X, X, X, X, X, X, X, X, },
                                            { X, X, X, X, X, X, X, X, X, X, },
                                            { X, X, 0, 0, 0, 0, A, 0, X, X, },                                                                                  
                                            { X, X, 0, 0, 0, 0, 0, 0, X, X, },                                                                                  
                                            { X, X, X, 0, 0, 0, 0, 0, X, X, },                                                                                  
                                            { X, X, 0, 0, 0, 0, B, 0, X, X, },                                                                                  
                                            { X, X, 0, 0, 0, 0, X, 0, X, X, },                                                                                  
                                            { X, X, 0, C, 0, D, 0, 0, X, X, },                                                                                  
                                            { X, X, X, X, X, X, X, X, X, X, },                                                                                  
                                            { X, X, X, X, X, X, X, X, X, X, },
                                        },

                                hint =  new char[]                  { 'D','L','D', },

                                stars = new sbyte[DATA_STAR_SIZE]   { 3, 4 },
                            },

            /* Level 23 */   new Data() {

                                size =  64,

                                bound = new sbyte[,] {
                                            { X, X, X, X, X, X, X, X, X, X },
                                            { X, X, X, X, X, X, X, X, X, X },
                                            { X, X, 0, 0, 0, 0, 0, 0, X, X },
                                            { X, X, 0, X, 0, 0, 0, 0, X, X },
                                            { X, X, 0, A, 0, 0, 0, 0, X, X },
                                            { X, X, C, X, D, X, 0, 0, X, X },
                                            { X, X, 0, B, 0, 0, 0, X, X, X },
                                            { X, X, 0, X, 0, 0, 0, 0, X, X },
                                            { X, X, X, X, X, X, X, X, X, X },
                                            { X, X, X, X, X, X, X, X, X, X },
                                        },

                                hint =  new char[]                  { 'U','R','U' },

                                stars = new sbyte[DATA_STAR_SIZE]   { 3, 4 },
                            },

            /* Level 24 */   new Data() {

                                size =  64,

                                bound = new sbyte[,] {
                                            { X, X, X, X, X, X, X, X, X, X },
                                            { X, X, X, X, X, X, X, X, X, X },
                                            { X, X, 0, 0, A, 0, 0, 0, X, X },
                                            { X, X, 0, 0, 0, 0, 0, D, X, X },
                                            { X, X, 0, C, 0, B, 0, X, X, X },
                                            { X, X, X, 0, 0, X, 0, 0, X, X },
                                            { X, X, X, 0, X, 0, 0, 0, X, X },
                                            { X, X, X, 0, 0, 0, 0, 0, X, X },
                                            { X, X, X, X, X, X, X, X, X, X },
                                            { X, X, X, X, X, X, X, X, X, X },
                                        },

                                hint =  new char[]                  { 'D','L','U' },

                                stars = new sbyte[DATA_STAR_SIZE]   { 3, 5 },
                            },

            /* Level 25 */   new Data() {

                                size =  64,

                                bound = new sbyte[,] {
                                            { X, X, X, X, X, X, X, X, X, X },
                                            { X, X, X, X, X, X, X, X, X, X },
                                            { X, X, X, 0, 0, D, 0, X, X, X },
                                            { X, X, 0, 0, 0, X, 0, A, X, X },
                                            { X, X, 0, 0, 0, C, 0, 0, X, X },
                                            { X, X, 0, 0, 0, X, B, 0, X, X },
                                            { X, X, 0, 0, 0, 0, 0, 0, X, X },
                                            { X, X, 0, 0, 0, 0, X, X, X, X },
                                            { X, X, X, X, X, X, X, X, X, X },
                                            { X, X, X, X, X, X, X, X, X, X },
                                        },

                                hint =  new char[]                  { 'D','L','D' },

                                stars = new sbyte[DATA_STAR_SIZE]   { 3, 5 },
                            },

			/* Puzzle 26 */	new Data() {

								size =  64,

								bound = new sbyte[,] {
											{ X, X, X, X, X, X, X, X, X, X, },
											{ X, X, X, X, X, X, X, X, X, X, },
											{ X, X, 0, 0, 0, 0, 0, 0, X, X, },
											{ X, X, A, 0, B, 0, 0, 0, X, X, },
											{ X, X, 0, 0, 0, 0, 0, X, X, X, },
											{ X, X, X, 0, 0, 0, 0, 0, X, X, },
											{ X, X, 0, 0, 0, 0, 0, 0, X, X, },
											{ X, X, 0, 0, C, 0, 0, D, X, X, },
											{ X, X, X, X, X, X, X, X, X, X, },
											{ X, X, X, X, X, X, X, X, X, X, },
										},

								hint =  new char[]                  { 'U','L','U', },

								stars = new sbyte[DATA_STAR_SIZE]   { 3, 4 },
							},

            /* Level 27 */   new Data() {

                                size =  64,

                                bound = new sbyte[,] {
                                            { X, X, X, X, X, X, X, X, X, X, },
                                            { X, X, X, X, X, X, X, X, X, X, },
                                            { X, X, 0, 0, 0, 0, A, X, X, X, },
                                            { X, X, 0, B, X, X, C, 0, X, X, },
                                            { X, X, X, 0, D, 0, 0, 0, X, X, },
                                            { X, X, 0, X, 0, 0, 0, 0, X, X, },
                                            { X, X, 0, 0, 0, 0, X, X, X, X, },
                                            { X, X, 0, 0, 0, 0, 0, 0, X, X, },
                                            { X, X, X, X, X, X, X, X, X, X, },
                                            { X, X, X, X, X, X, X, X, X, X, },
                                        },

                                hint =  new char[]                  { 'R','D','R', },

                                stars = new sbyte[DATA_STAR_SIZE]   { 3, 4 },
                            },

            /* Level 28 */   new Data() {

                                size =  64,

                                bound = new sbyte[,] {
                                            { X, X, X, X, X, X, X, X, X, X, },
                                            { X, X, X, X, X, X, X, X, X, X, },
                                            { X, X, A, 0, 0, X, B, X, X, X, },
                                            { X, X, 0, 0, 0, 0, 0, 0, X, X, },
                                            { X, X, 0, 0, 0, 0, 0, X, X, X, },
                                            { X, X, C, 0, 0, 0, 0, 0, X, X, },
                                            { X, X, 0, 0, 0, 0, 0, 0, X, X, },
                                            { X, X, 0, 0, X, 0, D, 0, X, X, },
                                            { X, X, X, X, X, X, X, X, X, X, },
                                            { X, X, X, X, X, X, X, X, X, X, },
                                        },

                                hint =  new char[]                  { 'R','D','R', },

                                stars = new sbyte[DATA_STAR_SIZE]   { 3, 4 },
                            },

            /* Level 29 */   new Data() {

                                size =  64,

                                bound = new sbyte[,] {
                                            { X, X, X, X, X, X, X, X, X, X, },
                                            { X, X, X, X, X, X, X, X, X, X, },
                                            { X, X, 0, 0, 0, X, 0, 0, X, X, },
                                            { X, X, 0, 0, A, 0, 0, 0, X, X, },
                                            { X, X, 0, 0, 0, 0, 0, 0, X, X, },
                                            { X, X, 0, B, 0, 0, 0, 0, X, X, },
                                            { X, X, 0, 0, 0, C, 0, X, X, X, },
                                            { X, X, X, 0, 0, 0, 0, D, X, X, },
                                            { X, X, X, X, X, X, X, X, X, X, },
                                            { X, X, X, X, X, X, X, X, X, X, },
                                        },

                                hint =  new char[]                  { 'U','L','U', },

                                stars = new sbyte[DATA_STAR_SIZE]   { 3, 4 },
                            },

            /* Level 30 */   new Data() {

                                size =  64,

                                bound = new sbyte[,] {
                                            { X, X, X, X, X, X, X, X, X, X },
                                            { X, X, X, X, X, X, X, X, X, X },
                                            { X, X, A, 0, 0, X, X, X, X, X },
                                            { X, X, 0, 0, 0, 0, 0, X, X, X },
                                            { X, X, 0, D, X, C, 0, 0, X, X },
                                            { X, X, X, 0, B, 0, 0, X, X, X },
                                            { X, X, 0, 0, 0, 0, 0, 0, X, X },
                                            { X, X, X, X, X, 0, 0, 0, X, X },
                                            { X, X, X, X, X, X, X, X, X, X },
                                            { X, X, X, X, X, X, X, X, X, X },
                                        },

                                hint =  new char[]                  { 'L','U','L' },

                                stars = new sbyte[DATA_STAR_SIZE]   { 3, 4 },
                            },

			/* Puzzle 31 */	new Data() {

								size =  64,

								bound = new sbyte[,] {
											{ X, X, X, X, X, X, X, X, X, X, },
											{ X, X, X, 0, A, B, C, D, X, X, },
											{ X, X, X, 0, 0, X, 0, 0, X, X, },
											{ X, X, X, X, 0, 0, 0, X, X, X, },
											{ X, X, X, X, X, 0, 0, 0, X, X, },
											{ X, X, X, X, 0, 0, 0, 0, X, X, },
											{ X, X, X, X, 0, 0, 0, X, X, X, },
											{ X, X, X, X, 0, 0, X, 0, X, X, },
											{ X, X, X, X, 0, 0, 0, 0, X, X, },
											{ X, X, X, X, X, X, X, X, X, X, },
										},

								hint =  new char[]                  { 'D','R','U', },

								stars = new sbyte[DATA_STAR_SIZE]   { 3, 4 },
							},

			/* Puzzle 32 */	new Data() {

								size =  64,

								bound = new sbyte[,] {
											{ X, X, X, X, X, X, X, X, X, X, },
											{ X, X, X, X, X, X, X, X, X, X, },
											{ X, X, 0, X, X, X, A, 0, X, X, },
											{ X, X, 0, 0, 0, 0, 0, 0, X, X, },
											{ X, X, 0, 0, X, 0, 0, 0, X, X, },
											{ X, X, B, 0, X, 0, 0, C, X, X, },
											{ X, X, X, X, 0, D, 0, X, X, X, },
											{ X, X, X, X, X, X, X, X, X, X, },
											{ X, X, X, X, X, X, X, X, X, X, },
											{ X, X, X, X, X, X, X, X, X, X, },
										},

								hint =  new char[]                  { 'R','U','R', },

								stars = new sbyte[DATA_STAR_SIZE]   { 3, 4 },
							},

			/* Puzzle 33 */	new Data() {

								size =  64,

								bound = new sbyte[,] {
											{ X, X, X, X, X, X, X, X, X, X, },
											{ X, X, X, X, X, X, X, X, X, X, },
											{ X, X, X, 0, 0, A, 0, X, X, X, },
											{ X, X, X, 0, B, 0, 0, X, X, X, },
											{ X, X, X, C, 0, 0, 0, X, X, X, },
											{ X, X, X, 0, 0, 0, 0, X, X, X, },
											{ X, X, X, 0, D, 0, 0, X, X, X, },
											{ X, X, X, X, X, 0, X, X, X, X, },
											{ X, X, X, X, X, X, X, X, X, X, },
											{ X, X, X, X, X, X, X, X, X, X, },
										},

								hint =  new char[]                  { 'D','R','U', },

								stars = new sbyte[DATA_STAR_SIZE]   { 3, 4 },
							},

			/* Puzzle 34 */	new Data() {

								size =  64,

								bound = new sbyte[,] {
											{ X, X, X, X, X, X, X, X, X, X, },
											{ X, X, X, X, X, X, X, X, X, X, },
                                            { X, X, X, X, X, X, X, X, X, X, },
											{ X, X, 0, 0, 0, X, X, 0, X, X, },
											{ X, X, 0, 0, 0, A, 0, 0, X, X, },
											{ X, X, 0, 0, 0, X, B, 0, X, X, },
											{ X, X, 0, C, 0, 0, 0, D, X, X, },
											{ X, X, X, X, X, X, X, X, X, X, },
											{ X, X, X, X, X, X, X, X, X, X, },
											{ X, X, X, X, X, X, X, X, X, X, },
										},

								hint =  new char[]                  { 'L','U','L', },

								stars = new sbyte[DATA_STAR_SIZE]   { 3, 4 },
							},

			/* Puzzle 35 */	new Data() {

								size =  64,

								bound = new sbyte[,] {
											{ X, X, X, X, X, X, X, X, X, X, },
											{ X, X, X, 0, 0, A, 0, X, X, X, },
											{ X, X, X, 0, 0, 0, 0, X, X, X, },
											{ X, X, X, X, 0, 0, 0, X, X, X, },
											{ X, X, X, X, 0, 0, 0, X, X, X, },
											{ X, X, X, X, 0, B, 0, X, X, X, },
											{ X, X, X, 0, 0, 0, 0, X, X, X, },
											{ X, X, X, C, 0, X, X, X, X, X, },
											{ X, X, X, 0, 0, D, X, X, X, X, },
											{ X, X, X, X, X, X, X, X, X, X, },
										},

								hint =  new char[]                  { 'D','L','D', },

								stars = new sbyte[DATA_STAR_SIZE]   { 3, 4 },
							},

            /* Puzzle 36 */	new Data() {

								size =  64,

								bound = new sbyte[,] {
											{ X, X, X, X, X, X, X, X, X, X, },
											{ X, X, X, X, X, X, 0, X, X, X, },
											{ X, X, X, X, X, X, 0, 0, X, X, },
											{ X, X, 0, 0, 0, 0, 0, X, X, X, },
											{ X, X, 0, 0, 0, 0, 0, 0, X, X, },
											{ X, X, 0, X, X, 0, 0, A, X, X, },
											{ X, X, 0, 0, X, 0, B, 0, X, X, },
											{ X, X, C, 0, 0, 0, 0, D, X, X, },
											{ X, X, X, X, X, X, X, X, X, X, },
											{ X, X, X, X, X, X, X, X, X, X, },
										},

								hint =  new char[]                  { 'U','R','D', },

								stars = new sbyte[DATA_STAR_SIZE]   { 3, 4 },
							},

            /* Level 37 */   new Data() {

                                size =  64,

                                bound = new sbyte[,] {
                                            { X, X, X, X, X, X, X, X, X, X, },
                                            { X, 0, 0, 0, 0, 0, 0, 0, 0, X, },
                                            { X, 0, 0, 0, 0, X, X, 0, 0, X, },
                                            { X, 0, 0, 0, A, X, X, X, 0, X, },
                                            { X, 0, 0, B, X, C, X, X, 0, X, },
                                            { X, 0, 0, X, D, 0, 0, 0, 0, X, },
                                            { X, 0, 0, 0, 0, 0, 0, X, X, X, },
                                            { X, 0, 0, 0, 0, X, X, X, X, X, },
                                            { X, X, 0, 0, X, X, X, X, X, X, },
                                            { X, X, X, X, X, X, X, X, X, X, },
                                        },

                                hint =  new char[]                  { 'L','D','L', },

                                stars = new sbyte[DATA_STAR_SIZE]   { 3, 4 },
                            },

            /* Puzzle 38 */	new Data() {

								size =  64,

								bound = new sbyte[,] {
											{ X, X, X, X, X, X, X, X, X, X, },
											{ X, 0, X, 0, 0, 0, 0, 0, 0, X, },
											{ X, 0, 0, 0, 0, 0, 0, A, 0, X, },
											{ X, 0, B, 0, X, 0, 0, X, 0, X, },
											{ X, 0, 0, 0, 0, X, X, 0, 0, X, },
											{ X, 0, 0, 0, X, X, X, X, 0, X, },
											{ X, 0, 0, 0, 0, X, X, C, 0, X, },
											{ X, 0, D, X, X, X, X, 0, 0, X, },
											{ X, 0, X, X, X, X, X, 0, 0, X, },
											{ X, X, X, X, X, X, X, X, X, X, },
										},

								hint =  new char[]                  { 'R','U','R', },

								stars = new sbyte[DATA_STAR_SIZE]   { 3, 4 },
							},

            /* Level 39 */   new Data() {

                                size =  64,

                                bound = new sbyte[,] {
                                            { X, X, X, X, X, X, X, X, X, X, },
                                            { X, 0, 0, X, 0, 0, 0, 0, 0, X, },
                                            { X, 0, 0, 0, 0, 0, 0, 0, 0, X, },
                                            { X, 0, A, 0, X, 0, 0, 0, 0, X, },
                                            { X, 0, 0, 0, 0, 0, X, 0, 0, X, },
                                            { X, 0, 0, 0, 0, 0, 0, B, C, X, },
                                            { X, 0, 0, D, 0, 0, 0, 0, 0, X, },
                                            { X, 0, 0, 0, 0, 0, 0, 0, 0, X, },
                                            { X, 0, 0, 0, 0, 0, 0, 0, 0, X, },
                                            { X, X, X, X, X, X, X, X, X, X, },
                                        },

                                hint =  new char[]                  { 'R','U','R', },

                                stars = new sbyte[DATA_STAR_SIZE]   { 3, 4 },
                            },

            /* Level 40 */   new Data() {

                                size =  64,

                                bound = new sbyte[,] {
                                            { X, X, X, X, X, X, X, X, X, X, },
                                            { X, 0, 0, 0, 0, 0, X, 0, X, X, },
                                            { X, 0, 0, 0, 0, A, 0, B, 0, X, },
                                            { X, 0, 0, X, 0, 0, 0, 0, X, X, },
                                            { X, 0, C, 0, 0, X, 0, 0, 0, X, },
                                            { X, X, 0, 0, 0, X, 0, 0, 0, X, },
                                            { X, 0, 0, 0, 0, 0, 0, 0, X, X, },
                                            { X, 0, 0, 0, X, 0, 0, D, 0, X, },
                                            { X, 0, 0, 0, 0, 0, 0, 0, 0, X, },
                                            { X, X, X, X, X, X, X, X, X, X, },
                                        },

                                hint =  new char[]                  { 'D','R','D', },

                                stars = new sbyte[DATA_STAR_SIZE]   { 3, 4 },
                            },

            /* Level 41 */   new Data() {

                                size =  64,

                                bound = new sbyte[,] {
                                            { X, X, X, X, X, X, X, X, X, X, },
                                            { X, 0, X, 0, 0, 0, 0, 0, 0, X, },
                                            { X, 0, X, 0, 0, 0, 0, 0, X, X, },
                                            { X, 0, X, 0, 0, A, 0, 0, X, X, },
                                            { X, 0, 0, 0, 0, 0, 0, 0, 0, X, },
                                            { X, 0, 0, 0, 0, X, 0, 0, 0, X, },
                                            { X, 0, 0, 0, 0, 0, 0, 0, 0, X, },
                                            { X, 0, 0, B, 0, 0, 0, 0, 0, X, },
                                            { X, C, 0, D, 0, 0, 0, 0, X, X, },
                                            { X, X, X, X, X, X, X, X, X, X, },    
                                        },

                                hint =  new char[]                  { 'R','D','L', },

                                stars = new sbyte[DATA_STAR_SIZE]   { 3, 4 },
                            },

			/* Puzzle 42 */	new Data() {

								size =  64,

								bound = new sbyte[,] {
											{ X, X, X, X, X, X, X, X, X, X, },
											{ X, X, 0, X, 0, X, 0, A, 0, X, },
											{ X, X, 0, 0, 0, 0, 0, 0, B, X, },
											{ X, 0, 0, 0, 0, 0, 0, 0, 0, X, },
											{ X, 0, 0, 0, 0, 0, 0, 0, 0, X, },
											{ X, 0, 0, 0, 0, 0, 0, 0, 0, X, },
											{ X, 0, 0, 0, 0, 0, 0, 0, 0, X, },
											{ X, C, 0, 0, 0, 0, 0, 0, 0, X, },
											{ X, 0, D, X, 0, 0, X, 0, X, X, },
											{ X, X, X, X, X, X, X, X, X, X, },
										},

								hint =  new char[]                  { 'L','D','L', },

								stars = new sbyte[DATA_STAR_SIZE]   { 3, 4 },
							},

             /* Level 43 */   new Data() {

                                size =  64,

                                bound = new sbyte[,] {
                                            { X, X, X, X, X, X, X, X, X, X, },
                                            { X, 0, 0, A, 0, 0, 0, 0, X, X, },
                                            { X, 0, B, X, X, 0, 0, 0, 0, X, },
                                            { X, C, 0, 0, 0, 0, 0, 0, 0, X, },
                                            { X, 0, 0, 0, 0, 0, 0, 0, 0, X, },
                                            { X, 0, 0, X, 0, 0, 0, 0, 0, X, },
                                            { X, 0, 0, 0, 0, 0, 0, 0, 0, X, },
                                            { X, X, 0, 0, 0, 0, 0, 0, 0, X, },
                                            { X, X, 0, 0, 0, 0, 0, 0, D, X, },
                                            { X, X, X, X, X, X, X, X, X, X, },
                                        },

                                hint =  new char[]                  { 'D','R','D', },

                                stars = new sbyte[DATA_STAR_SIZE]   { 3, 4 },
                            },
            
            /* Level 44 */   new Data() {

                                size =  64,

                                bound = new sbyte[,] {
                                            { X, X, X, X, X, X, X, X, X, X, },
                                            { X, 0, 0, 0, 0, 0, 0, 0, 0, X, },
                                            { X, X, 0, 0, 0, 0, A, B, 0, X, },
                                            { X, 0, 0, 0, 0, 0, 0, 0, 0, X, },
                                            { X, 0, 0, 0, 0, 0, 0, 0, 0, X, },
                                            { X, 0, 0, 0, X, 0, 0, 0, 0, X, },
                                            { X, 0, 0, 0, 0, 0, 0, 0, 0, X, },
                                            { X, 0, C, D, X, 0, 0, X, 0, X, },
                                            { X, X, 0, 0, X, X, X, X, X, X, },
                                            { X, X, X, X, X, X, X, X, X, X, },
                                        },

                                hint =  new char[]                  { 'L','D','R', },

                                stars = new sbyte[DATA_STAR_SIZE]   { 3, 4 },
                            },
            
            /* Level 45 */   new Data() {

                                size =  64,

                                bound = new sbyte[,] {
                                            { X, X, X, X, X, X, X, X, X, X, },
                                            { X, 0, 0, 0, 0, A, 0, 0, 0, X, },
                                            { X, 0, 0, X, X, X, 0, 0, B, X, },
                                            { X, 0, 0, 0, 0, 0, 0, X, X, X, },
                                            { X, 0, 0, 0, 0, 0, 0, 0, X, X, },
                                            { X, X, 0, 0, 0, C, X, 0, 0, X, },
                                            { X, X, 0, 0, 0, 0, 0, 0, 0, X, },
                                            { X, 0, 0, 0, 0, 0, 0, 0, 0, X, },
                                            { X, 0, 0, 0, 0, 0, D, 0, 0, X, },
                                            { X, X, X, X, X, X, X, X, X, X, },
                                        },

                                hint =  new char[]                  { 'U','L','U', },

                                stars = new sbyte[DATA_STAR_SIZE]   { 3, 4 },
                            },
         
            /* Puzzle 46 */	new Data() {

								size =  64,

								bound = new sbyte[,] {
											{ X, X, X, X, X, X, X, X, X, X, },
											{ X, 0, 0, A, 0, 0, 0, 0, X, X, },
											{ X, 0, 0, 0, 0, 0, 0, 0, 0, X, },
											{ X, 0, 0, 0, 0, 0, B, 0, C, X, },
											{ X, 0, 0, 0, 0, 0, 0, 0, 0, X, },
											{ X, 0, 0, 0, 0, 0, 0, 0, X, X, },
											{ X, 0, 0, 0, 0, D, X, 0, 0, X, },
											{ X, 0, 0, 0, 0, 0, X, 0, 0, X, },
											{ X, 0, 0, 0, X, 0, 0, X, 0, X, },
											{ X, X, X, X, X, X, X, X, X, X, },
										},

								hint =  new char[]                  { 'R','U','L', },

								stars = new sbyte[DATA_STAR_SIZE]   { 3, 4 },
							},

            /* Level 47 */   new Data() {

                                size =  64,

                                bound = new sbyte[,] {
                                            { X, X, X, X, X, X, X, X, X, X, },
                                            { X, X, 0, X, X, 0, 0, X, X, X, },
                                            { X, X, 0, X, 0, 0, 0, 0, 0, X, },
                                            { X, 0, 0, 0, 0, 0, 0, 0, A, X, },
                                            { X, 0, 0, 0, 0, 0, 0, 0, 0, X, },
                                            { X, 0, 0, 0, 0, 0, X, 0, 0, X, },
                                            { X, X, B, 0, C, X, X, 0, 0, X, },
                                            { X, 0, 0, X, 0, 0, D, 0, 0, X, },
                                            { X, 0, 0, 0, 0, X, 0, 0, X, X, },
                                            { X, X, X, X, X, X, X, X, X, X, },
                                        },

                                hint =  new char[]                  { 'R','U','R', },

                                stars = new sbyte[DATA_STAR_SIZE]   { 3, 4 },
                            },

            /* Level 48 */   new Data() {

                                size =  64,

                                bound = new sbyte[,] {
                                            { X, X, X, X, X, X, X, X, X, X, },
                                            { X, 0, A, 0, 0, 0, 0, 0, 0, X, },
                                            { X, 0, 0, 0, 0, 0, 0, B, 0, X, },
                                            { X, 0, 0, 0, 0, 0, 0, 0, X, X, },
                                            { X, 0, 0, C, 0, 0, 0, 0, X, X, },
                                            { X, 0, 0, X, 0, 0, 0, 0, 0, X, },
                                            { X, 0, 0, 0, X, X, X, D, 0, X, },
                                            { X, 0, 0, 0, 0, 0, 0, 0, 0, X, },
                                            { X, 0, X, 0, 0, X, 0, 0, 0, X, },
                                            { X, X, X, X, X, X, X, X, X, X, },
                                        },

                                hint =  new char[]                  { 'D','R','D', },

                                stars = new sbyte[DATA_STAR_SIZE]   { 3, 4 },
                            },

			/* Puzzle 49 */	new Data() {

								size =  64,

								bound = new sbyte[,] {
											{ X, X, X, X, X, X, X, X, X, X, },
											{ X, 0, 0, 0, 0, 0, 0, 0, 0, X, },
											{ X, 0, 0, X, 0, 0, 0, 0, A, X, },
											{ X, 0, 0, 0, 0, X, 0, X, 0, X, },
											{ X, 0, X, 0, 0, 0, 0, 0, 0, X, },
											{ X, 0, 0, 0, 0, 0, 0, 0, 0, X, },
											{ X, B, 0, 0, 0, X, C, 0, 0, X, },
											{ X, 0, 0, 0, 0, 0, X, 0, 0, X, },
											{ X, 0, 0, D, 0, X, X, 0, 0, X, },
											{ X, X, X, X, X, X, X, X, X, X, },
										},

								hint =  new char[]                  { 'R','U','R', },

								stars = new sbyte[DATA_STAR_SIZE]   { 3, 4 },
							},

            /* Puzzle 50 */	new Data() {

								size =  64,

								bound = new sbyte[,] {
											{ X, X, X, X, X, X, X, X, X, X, },
											{ X, 0, 0, 0, X, 0, 0, 0, 0, X, },
											{ X, A, 0, 0, 0, 0, 0, 0, 0, X, },
											{ X, 0, 0, X, 0, 0, 0, 0, 0, X, },
											{ X, 0, 0, 0, 0, X, 0, B, 0, X, },
											{ X, C, 0, X, D, 0, 0, 0, 0, X, },
											{ X, X, 0, 0, 0, 0, 0, 0, 0, X, },
											{ X, 0, 0, X, 0, X, X, X, 0, X, },
											{ X, X, 0, 0, 0, 0, 0, 0, 0, X, },
											{ X, X, X, X, X, X, X, X, X, X, },
										},

								hint =  new char[]                  { 'D','L','U', },

								stars = new sbyte[DATA_STAR_SIZE]   { 3, 4 },
							},


            // /* Level 1 */   new Data() {

            //                     size =  64,

            //                     bound = new sbyte[,] {
            //                                 { 8, 8, 8, 8, 8, 8, 8, 8, 8, 8 },
            //                                 { 8, X, X, X, X, X, X, X, X, 8 },
            //                                 { 8, X, X, X, X, X, X, X, X, 8 },
            //                                 { 8, X, X, X, X, X, X, X, X, 8 },
            //                                 { 8, X, 0, A, 0, 0, 0, C, X, 8 },
            //                                 { 8, X, 0, B, 0, 0, D, X, X, 8 },
            //                                 { 8, X, X, X, X, X, X, X, X, 8 },
            //                                 { 8, X, X, X, X, X, X, X, X, 8 },
            //                                 { 8, X, X, X, X, X, X, X, X, 8 },
            //                                 { 8, 8, 8, 8, 8, 8, 8, 8, 8, 8 }
            //                             },

            //                     hint =  new char[]                  { 'L' },

            //                     stars = new sbyte[DATA_STAR_SIZE]   { 1, 2 },
            //                 },

            // /* Level 2 */   new Data() {

            //                     size =  64,

            //                     bound = new sbyte[,] {
            //                                 { 8, 8, 8, 8, 8, 8, 8, 8, 8, 8 },
            //                                 { 8, X, X, X, X, X, X, X, X, 8 },
            //                                 { 8, X, 0, 0, 0, 0, 0, 0, X, 8 },
            //                                 { 8, X, 0, 0, C, 0, 0, D, X, 8 },
            //                                 { 8, X, 0, 0, 0, 0, 0, 0, X, 8 },
            //                                 { 8, X, 0, 0, 0, 0, 0, 0, X, 8 },
            //                                 { 8, X, A, 0, B, 0, 0, 0, X, 8 },
            //                                 { 8, X, 0, 0, 0, 0, 0, 0, X, 8 },
            //                                 { 8, X, X, X, X, X, X, X, X, 8 },
            //                                 { 8, 8, 8, 8, 8, 8, 8, 8, 8, 8 }
            //                             },

            //                     hint =  new char[]                  { 'R','U' },

            //                     stars = new sbyte[DATA_STAR_SIZE]   { 2, 3 },
            //                 },

            // /* Level 5 */  new Data() {

            //                     size =  64,

            //                     bound = new sbyte[,] {
            //                                 { 8, 8, 8, 8, 8, 8, 8, 8, 8, 8 },
            //                                 { 8, X, X, X, X, X, X, X, X, 8 },
            //                                 { 8, X, 0, B, X, X, X, C, X, 8 },
            //                                 { 8, X, A, 0, X, X, 0, D, X, 8 },
            //                                 { 8, X, 0, 0, X, X, 0, 0, X, 8 },
            //                                 { 8, X, 0, 0, X, X, 0, 0, X, 8 },
            //                                 { 8, X, 0, 0, 0, 0, 0, 0, X, 8 },
            //                                 { 8, X, X, 0, 0, 0, 0, 0, X, 8 },
            //                                 { 8, X, X, X, X, X, X, X, X, 8 },
            //                                 { 8, 8, 8, 8, 8, 8, 8, 8, 8, 8 }
            //                             },

            //                     hint =  new char[]                  { 'D','R' },

            //                     stars = new sbyte[DATA_STAR_SIZE]   { 2, 3 },
            //                 },
        
            // /* Level 41 */   new Data() {

            //                     size =  64,

            //                     bound = new sbyte[,] {
            //                                 { 8, 8, 8, 8, 8, 8, 8, 8, 8, 8 },
            //                                 { 8, X, X, X, X, X, X, X, X, 8 },
            //                                 { 8, X, X, X, X, X, 0, 0, X, 8 },
            //                                 { 8, X, X, 0, 0, 0, 0, 0, X, 8 },
            //                                 { 8, X, 0, 0, 0, 0, 0, X, X, 8 },
            //                                 { 8, X, 0, 0, X, C, D, X, X, 8 },
            //                                 { 8, X, 0, 0, X, X, X, X, X, 8 },
            //                                 { 8, X, A, B, X, X, X, X, X, 8 },
            //                                 { 8, X, X, X, X, X, X, X, X, 8 },
            //                                 { 8, 8, 8, 8, 8, 8, 8, 8, 8, 8 }
            //                             },

            //                     hint =  new char[]                  { 'U','R','U' },

            //                     stars = new sbyte[DATA_STAR_SIZE]   { 3, 4 },
            //                 },
        };
    }
}