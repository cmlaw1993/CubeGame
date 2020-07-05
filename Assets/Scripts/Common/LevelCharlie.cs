using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelCharlie : Level
{
    public LevelCharlie()
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

#region NUM_1_TO_10___36__RANDOM

            /* Level 0 */   new Data() {

                                size =  64,

                                bound = new sbyte[,] {
                                            { X, X, X, X, X, X, X, X, X, X, },
                                            { X, X, X, X, X, X, X, X, X, X, },
                                            { X, X, X, X, X, X, 0, X, X, X, },
                                            { X, X, X, A, B, X, 0, C, X, X, },
                                            { X, X, X, 0, D, X, X, 0, X, X, },
                                            { X, X, X, X, 0, 0, 0, 0, X, X, },
                                            { X, X, X, X, X, X, 0, X, X, X, },
                                            { X, X, X, X, X, X, 0, X, X, X, },
                                            { X, X, X, X, X, X, X, X, X, X, },
                                            { X, X, X, X, X, X, X, X, X, X, },
                                        },

                                hint =  new char[]                  { 'D','L','U','L','U', },

                                stars = new sbyte[DATA_STAR_SIZE]   { 5, 6 },
                            },

            /* Level 0 */   new Data() {

                                size =  64,

                                bound = new sbyte[,] {
                                            { X, X, X, X, X, X, X, X, X, X, },
                                            { X, X, X, X, X, X, X, X, X, X, },
                                            { X, X, 0, A, X, 0, 0, 0, X, X, },
                                            { X, X, 0, 0, 0, 0, 0, B, X, X, },
                                            { X, X, 0, X, 0, 0, 0, 0, X, X, },
                                            { X, X, 0, 0, 0, 0, 0, X, X, X, },
                                            { X, X, C, 0, 0, 0, 0, 0, X, X, },
                                            { X, X, 0, D, 0, 0, 0, X, X, X, },
                                            { X, X, X, X, X, X, X, X, X, X, },
                                            { X, X, X, X, X, X, X, X, X, X, },
                                        },

                                hint =  new char[]                  { 'L','D','R','D','L', },

                                stars = new sbyte[DATA_STAR_SIZE]   { 5, 6 },
                            },

            /* Level 0 */   new Data() {

                                size =  64,

                                bound = new sbyte[,] {
                                            { X, X, X, X, X, X, X, X, X, X, },
                                            { X, X, X, X, X, X, X, X, X, X, },
                                            { X, X, 0, 0, 0, 0, 0, 0, X, X, },
                                            { X, X, 0, A, 0, 0, X, 0, X, X, },
                                            { X, X, 0, 0, 0, 0, 0, 0, X, X, },
                                            { X, X, B, 0, X, 0, 0, X, X, X, },
                                            { X, X, 0, 0, 0, X, 0, 0, X, X, },
                                            { X, X, 0, 0, C, X, D, 0, X, X, },
                                            { X, X, X, X, X, X, X, X, X, X, },
                                            { X, X, X, X, X, X, X, X, X, X, },
                                        },

                                hint =  new char[]                  { 'U','L','D','R','D', },

                                stars = new sbyte[DATA_STAR_SIZE]   { 5, 6 },
                            },

            /* Level 0 */   new Data() {

                                size =  64,

                                bound = new sbyte[,] {
                                            { X, X, X, X, X, X, X, X, X, X, },
                                            { X, X, X, X, X, X, X, X, X, X, },
                                            { X, X, 0, A, 0, X, 0, 0, X, X, },
                                            { X, X, B, 0, 0, 0, X, C, X, X, },
                                            { X, X, 0, 0, X, 0, D, 0, X, X, },
                                            { X, X, 0, 0, 0, 0, 0, X, X, X, },
                                            { X, X, X, 0, 0, 0, 0, 0, X, X, },
                                            { X, X, 0, X, 0, 0, 0, 0, X, X, },
                                            { X, X, X, X, X, X, X, X, X, X, },
                                            { X, X, X, X, X, X, X, X, X, X, },
                                        },

                                hint =  new char[]                  { 'D','L','D','R','D', },

                                stars = new sbyte[DATA_STAR_SIZE]   { 5, 6 },
                            },

            /* Level 0 */   new Data() {

                                size =  64,

                                bound = new sbyte[,] {
                                            { X, X, X, X, X, X, X, X, X, X, },
                                            { X, X, X, X, X, X, X, X, X, X, },
                                            { X, X, A, 0, 0, 0, 0, 0, X, X, },
                                            { X, X, 0, 0, 0, B, 0, X, X, X, },
                                            { X, X, 0, 0, 0, 0, C, 0, X, X, },
                                            { X, X, X, 0, X, 0, 0, 0, X, X, },
                                            { X, X, 0, X, 0, 0, 0, 0, X, X, },
                                            { X, X, 0, 0, 0, 0, D, 0, X, X, },
                                            { X, X, X, X, X, X, X, X, X, X, },
                                            { X, X, X, X, X, X, X, X, X, X, },
                                        },

                                hint =  new char[]                  { 'U','L','D','L','U', },

                                stars = new sbyte[DATA_STAR_SIZE]   { 5, 6 },
                            },

            /* Level 0 */   new Data() {

                                size =  64,

                                bound = new sbyte[,] {
                                            { X, X, X, X, X, X, X, X, X, X, },
                                            { X, X, X, X, X, X, X, X, X, X, },
                                            { X, X, 0, 0, 0, 0, 0, 0, X, X, },
                                            { X, X, X, 0, 0, 0, 0, 0, X, X, },
                                            { X, X, X, 0, 0, 0, X, 0, X, X, },
                                            { X, X, X, A, X, X, 0, 0, X, X, },
                                            { X, X, 0, B, X, 0, 0, C, X, X, },
                                            { X, X, D, 0, X, X, 0, 0, X, X, },
                                            { X, X, X, X, X, X, X, X, X, X, },
                                            { X, X, X, X, X, X, X, X, X, X, },
                                        },

                                hint =  new char[]                  { 'L','U','R','U','R', },

                                stars = new sbyte[DATA_STAR_SIZE]   { 5, 6 },
                            },

            /* Level 0 */   new Data() {

                                size =  64,

                                bound = new sbyte[,] {
                                            { X, X, X, X, X, X, X, X, X, X, },
                                            { X, X, X, X, X, X, X, X, X, X, },
                                            { X, X, X, 0, 0, 0, 0, 0, X, X, },
                                            { X, X, 0, X, 0, 0, 0, 0, X, X, },
                                            { X, X, A, B, 0, X, 0, 0, X, X, },
                                            { X, X, C, 0, 0, X, 0, 0, X, X, },
                                            { X, X, 0, 0, 0, X, 0, 0, X, X, },
                                            { X, X, D, 0, X, 0, 0, 0, X, X, },
                                            { X, X, X, X, X, X, X, X, X, X, },
                                            { X, X, X, X, X, X, X, X, X, X, },
                                        },

                                hint =  new char[]                  { 'R','U','R','U','R', },

                                stars = new sbyte[DATA_STAR_SIZE]   { 5, 6 },
                            },

            /* Level 0 */   new Data() {

                                size =  64,

                                bound = new sbyte[,] {
                                            { X, X, X, X, X, X, X, X, X, X, },
                                            { X, X, X, X, X, X, X, X, X, X, },
                                            { X, X, 0, 0, 0, X, 0, 0, X, X, },
                                            { X, X, 0, 0, 0, A, X, X, X, X, },
                                            { X, X, 0, 0, 0, 0, 0, 0, X, X, },
                                            { X, X, 0, X, 0, 0, 0, 0, X, X, },
                                            { X, X, 0, 0, B, X, 0, X, X, X, },
                                            { X, X, X, 0, 0, C, 0, D, X, X, },
                                            { X, X, X, X, X, X, X, X, X, X, },
                                            { X, X, X, X, X, X, X, X, X, X, },
                                        },

                                hint =  new char[]                  { 'L','U','R','U','L', },

                                stars = new sbyte[DATA_STAR_SIZE]   { 5, 6 },
                            },

            /* Level 0 */   new Data() {

                                size =  64,

                                bound = new sbyte[,] {
                                            { X, X, X, X, X, X, X, X, X, X, },
                                            { X, X, X, X, X, X, X, X, X, X, },
                                            { X, X, X, X, X, X, X, X, X, X, },
                                            { X, X, X, X, X, A, B, 0, X, X, },
                                            { X, X, 0, X, X, C, X, 0, X, X, },
                                            { X, X, 0, X, 0, 0, 0, X, X, X, },
                                            { X, X, 0, 0, 0, D, 0, X, X, X, },
                                            { X, X, 0, 0, 0, X, 0, 0, X, X, },
                                            { X, X, X, X, X, X, X, X, X, X, },
                                            { X, X, X, X, X, X, X, X, X, X, },
                                        },

                                hint =  new char[]                  { 'L','D','L','D','L', },

                                stars = new sbyte[DATA_STAR_SIZE]   { 5, 6 },
                            },

            /* Level 0 */   new Data() {

                                size =  64,

                                bound = new sbyte[,] {
                                            { X, X, X, X, X, X, X, X, X, X, },
                                            { X, X, X, X, X, X, X, X, X, X, },
                                            { X, X, X, 0, 0, 0, A, 0, X, X, },
                                            { X, X, X, X, X, X, X, 0, X, X, },
                                            { X, X, 0, X, X, 0, X, B, X, X, },
                                            { X, X, 0, C, 0, 0, 0, 0, X, X, },
                                            { X, X, X, X, X, 0, D, 0, X, X, },
                                            { X, X, X, X, X, X, 0, X, X, X, },
                                            { X, X, X, X, X, X, X, X, X, X, },
                                            { X, X, X, X, X, X, X, X, X, X, },
                                        },

                                hint =  new char[]                  { 'R','D','L','D','R', },

                                stars = new sbyte[DATA_STAR_SIZE]   { 5, 6 },
                            },

#endregion

#region NUM_21_TO_30___64__RANDOM

            /* Level 0 */   new Data() {

                                size =  64,

                                bound = new sbyte[,] {
                                            { X, X, X, X, X, X, X, X, X, X, },
                                            { X, 0, 0, A, 0, 0, 0, 0, 0, X, },
                                            { X, 0, 0, 0, 0, B, 0, 0, 0, X, },
                                            { X, 0, 0, C, 0, 0, 0, 0, 0, X, },
                                            { X, 0, 0, 0, 0, X, 0, 0, 0, X, },
                                            { X, 0, 0, X, 0, 0, 0, 0, 0, X, },
                                            { X, 0, 0, X, 0, D, 0, 0, 0, X, },
                                            { X, 0, 0, 0, 0, 0, 0, 0, 0, X, },
                                            { X, 0, 0, 0, 0, 0, 0, 0, 0, X, },
                                            { X, X, X, X, X, X, X, X, X, X, },
                                        },

                                hint =  new char[]                  { 'R','D','L','U','L', },

                                stars = new sbyte[DATA_STAR_SIZE]   { 5, 6 },
                            },

            /* Level 0 */   new Data() {

                                size =  64,

                                bound = new sbyte[,] {
                                            { X, X, X, X, X, X, X, X, X, X, },
                                            { X, 0, 0, 0, 0, 0, 0, 0, 0, X, },
                                            { X, A, 0, X, B, 0, 0, 0, 0, X, },
                                            { X, X, 0, 0, 0, X, 0, 0, X, X, },
                                            { X, C, 0, 0, X, X, 0, 0, 0, X, },
                                            { X, 0, 0, D, 0, 0, X, 0, 0, X, },
                                            { X, X, 0, 0, X, 0, 0, 0, 0, X, },
                                            { X, 0, 0, 0, 0, 0, 0, 0, 0, X, },
                                            { X, 0, 0, 0, 0, X, X, 0, 0, X, },
                                            { X, X, X, X, X, X, X, X, X, X, },
                                        },

                                hint =  new char[]                  { 'D','R','D','L','D', },

                                stars = new sbyte[DATA_STAR_SIZE]   { 5, 6 },
                            },

            /* Level 0 */   new Data() {

                                size =  64,

                                bound = new sbyte[,] {
                                            { X, X, X, X, X, X, X, X, X, X, },
                                            { X, 0, 0, 0, 0, 0, 0, 0, 0, X, },
                                            { X, 0, 0, A, X, 0, 0, 0, 0, X, },
                                            { X, 0, 0, 0, 0, 0, 0, 0, B, X, },
                                            { X, 0, 0, 0, 0, 0, X, 0, X, X, },
                                            { X, 0, 0, 0, X, 0, X, X, 0, X, },
                                            { X, X, X, 0, C, 0, 0, 0, 0, X, },
                                            { X, 0, 0, 0, 0, 0, 0, 0, 0, X, },
                                            { X, 0, X, X, 0, 0, 0, 0, D, X, },
                                            { X, X, X, X, X, X, X, X, X, X, },
                                        },

                                hint =  new char[]                  { 'L','D','R','D','R', },

                                stars = new sbyte[DATA_STAR_SIZE]   { 5, 6 },
                            },

            /* Level 0 */   new Data() {

                                size =  64,

                                bound = new sbyte[,] {
                                            { X, X, X, X, X, X, X, X, X, X, },
                                            { X, 0, 0, A, 0, 0, 0, 0, 0, X, },
                                            { X, 0, 0, B, 0, 0, 0, 0, 0, X, },
                                            { X, X, 0, C, 0, 0, 0, 0, 0, X, },
                                            { X, 0, 0, 0, 0, 0, 0, 0, 0, X, },
                                            { X, 0, 0, 0, 0, 0, 0, 0, 0, X, },
                                            { X, 0, 0, 0, 0, 0, 0, 0, 0, X, },
                                            { X, 0, 0, 0, 0, 0, 0, 0, 0, X, },
                                            { X, D, 0, 0, 0, 0, 0, 0, 0, X, },
                                            { X, X, X, X, X, X, X, X, X, X, },
                                        },

                                hint =  new char[]                  { 'D','R','U','L','U', },

                                stars = new sbyte[DATA_STAR_SIZE]   { 5, 6 },
                            },

            /* Level 0 */   new Data() {

                                size =  64,

                                bound = new sbyte[,] {
                                            { X, X, X, X, X, X, X, X, X, X, },
                                            { X, 0, 0, X, 0, 0, 0, 0, X, X, },
                                            { X, 0, X, A, 0, 0, 0, 0, 0, X, },
                                            { X, 0, B, 0, 0, X, 0, C, 0, X, },
                                            { X, 0, D, X, 0, 0, 0, 0, 0, X, },
                                            { X, 0, 0, 0, 0, 0, 0, X, X, X, },
                                            { X, 0, X, 0, 0, 0, 0, 0, 0, X, },
                                            { X, 0, 0, 0, 0, 0, 0, 0, 0, X, },
                                            { X, 0, 0, 0, 0, 0, X, X, 0, X, },
                                            { X, X, X, X, X, X, X, X, X, X, },
                                        },

                                hint =  new char[]                  { 'R','D','L','D','L', },

                                stars = new sbyte[DATA_STAR_SIZE]   { 5, 6 },
                            },

            /* Level 0 */   new Data() {

                                size =  64,

                                bound = new sbyte[,] {
                                            { X, X, X, X, X, X, X, X, X, X, },
                                            { X, 0, 0, 0, X, 0, 0, X, 0, X, },
                                            { X, 0, 0, 0, A, 0, 0, X, 0, X, },
                                            { X, 0, X, 0, 0, X, 0, X, X, X, },
                                            { X, 0, X, 0, 0, 0, X, 0, B, X, },
                                            { X, 0, 0, X, 0, 0, 0, 0, 0, X, },
                                            { X, X, X, X, 0, 0, 0, 0, C, X, },
                                            { X, 0, 0, 0, 0, 0, 0, 0, X, X, },
                                            { X, D, 0, 0, X, 0, 0, 0, 0, X, },
                                            { X, X, X, X, X, X, X, X, X, X, },
                                        },

                                hint =  new char[]                  { 'D','R','U','R','U', },

                                stars = new sbyte[DATA_STAR_SIZE]   { 5, 6 },
                            },

            /* Level 0 */   new Data() {

                                size =  64,

                                bound = new sbyte[,] {
                                            { X, X, X, X, X, X, X, X, X, X, },
                                            { X, 0, 0, 0, 0, 0, 0, 0, 0, X, },
                                            { X, 0, 0, 0, A, 0, 0, 0, X, X, },
                                            { X, 0, 0, 0, 0, 0, 0, 0, X, X, },
                                            { X, 0, 0, 0, 0, 0, B, 0, X, X, },
                                            { X, 0, 0, 0, 0, X, 0, 0, 0, X, },
                                            { X, 0, 0, 0, 0, 0, 0, X, 0, X, },
                                            { X, 0, 0, 0, 0, 0, 0, 0, C, X, },
                                            { X, 0, 0, 0, 0, X, D, 0, 0, X, },
                                            { X, X, X, X, X, X, X, X, X, X, },
                                        },

                                hint =  new char[]                  { 'R','D','L','U','L', },

                                stars = new sbyte[DATA_STAR_SIZE]   { 5, 6 },
                            },

            /* Level 0 */   new Data() {

                                size =  64,

                                bound = new sbyte[,] {
                                            { X, X, X, X, X, X, X, X, X, X, },
                                            { X, X, A, X, X, 0, B, 0, 0, X, },
                                            { X, 0, 0, X, X, 0, 0, 0, C, X, },
                                            { X, 0, 0, X, 0, 0, X, X, 0, X, },
                                            { X, 0, 0, X, 0, 0, X, 0, 0, X, },
                                            { X, 0, 0, D, 0, 0, 0, 0, X, X, },
                                            { X, 0, 0, 0, 0, 0, 0, 0, 0, X, },
                                            { X, 0, 0, 0, 0, 0, 0, 0, 0, X, },
                                            { X, 0, 0, 0, 0, 0, X, X, 0, X, },
                                            { X, X, X, X, X, X, X, X, X, X, },
                                        },

                                hint =  new char[]                  { 'R','U','L','D','L', },

                                stars = new sbyte[DATA_STAR_SIZE]   { 5, 6 },
                            },

#endregion

            /* Level 18 */  new Data() {

                                size =  64,

                                bound = new sbyte[,] {
                                            { 8, 8, 8, 8, 8, 8, 8, 8, 8, 8 },
                                            { 8, X, X, X, 0, 0, X, X, X, 8 },
                                            { 8, X, X, 0, 0, 0, 0, X, X, 8 },
                                            { 8, X, 0, 0, 0, 0, 0, 0, X, 8 },
                                            { 8, 0, 0, 0, 0, 0, 0, 0, 0, 8 },
                                            { 8, A, 0, 0, 0, 0, 0, 0, 0, 8 },
                                            { 8, 0, B, 0, 0, 0, 0, 0, 0, 8 },
                                            { 8, 0, 0, C, 0, 0, 0, X, X, 8 },
                                            { 8, 0, 0, 0, D, 0, 0, X, X, 8 },
                                            { 8, 8, 8, 8, 8, 8, 8, 8, 8, 8 }
                                        },

                                hint =  new char[]                  { 'U','R','D','L','D' },

                                stars = new sbyte[DATA_STAR_SIZE]   { 5, 6 },
                            },


            /* Level 0 */   new Data() {

                                size =  100,

                                bound = new sbyte[,] {
                                            { X, 0, 0, 0, 0, X, 0, X, X, X, },
                                            { X, 0, 0, 0, 0, X, 0, X, X, X, },
                                            { 0, 0, 0, 0, 0, 0, 0, X, X, X, },
                                            { X, 0, 0, X, A, 0, 0, 0, 0, X, },
                                            { B, 0, X, X, 0, 0, 0, 0, X, X, },
                                            { 0, 0, X, 0, 0, 0, 0, X, X, X, },
                                            { 0, 0, 0, 0, 0, 0, 0, C, 0, 0, },
                                            { 0, 0, 0, 0, 0, 0, 0, 0, 0, X, },
                                            { 0, 0, 0, 0, D, 0, X, X, 0, X, },
                                            { X, 0, 0, 0, 0, X, X, 0, 0, 0, },
                                        },

                                hint =  new char[]                  { 'U','R' },

                                stars = new sbyte[DATA_STAR_SIZE]   { 1, 2 },
                            },

            /* Level X */  new Data() {

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

            /* Level 0 */   new Data() {

                                size =  64,

                                bound = new sbyte[,] {
                                            { 8, 8, 8, 8, 8, 8, 8, 8, 8, 8 },
                                            { 8, X, X, X, X, X, X, X, X, 8 },
                                            { 8, X, X, 0, 0, 0, 0, X, X, 8 },
                                            { 8, X, 0, 0, 0, 0, 0, X, X, 8 },
                                            { 8, X, 0, X, A, X, 0, X, X, 8 },
                                            { 8, X, 0, 0, B, 0, 0, X, X, 8 },
                                            { 8, X, 0, 0, C, 0, 0, X, X, 8 },
                                            { 8, X, 0, X, D, X, 0, X, X, 8 },
                                            { 8, X, X, X, X, X, X, X, X, 8 },
                                            { 8, 8, 8, 8, 8, 8, 8, 8, 8, 8 }
                                        },

                                hint =  new char[]                  { 'R','U','R' },

                                stars = new sbyte[DATA_STAR_SIZE]   { 3, 4 },
                            },
            

            /* Level XX */   new Data() {

                                size =  64,

                                bound = new sbyte[,] {
                                            { 8, 8, 8, 8, 8, 8, 8, 8, 8, 8 },
                                            { 8, X, X, X, X, X, X, X, X, 8 },
                                            { 8, 0, 0, 0, 0, 0, 0, X, X, 8 },
                                            { 8, 0, X, 0, X, 0, 0, X, X, 8 },
                                            { 8, 0, X, 0, X, 0, 0, X, A, 8 },
                                            { 8, 0, 0, 0, 0, 0, 0, X, B, 8 },
                                            { 8, 0, 0, 0, 0, 0, 0, C, D, 8 },
                                            { 8, X, X, X, 0, 0, 0, 0, 0, 8 },
                                            { 8, X, X, X, X, 0, 0, 0, X, 8 },
                                            { 8, 8, 8, 8, 8, 8, 8, 8, 8, 8 }
                                        },

                                hint =  new char[]                  { 'L','D','L','U','R','U' },

                                stars = new sbyte[DATA_STAR_SIZE]   { 6, 7 },
                            },

            /* Level XX */   new Data() {

                                size =  64,

                                bound = new sbyte[,] {
                                            { 8, 8, 8, 8, 8, 8, 8, 8, 8, 8 },
                                            { 8, 0, 0, 0, 0, 0, 0, X, X, 8 },
                                            { 8, 0, 0, 0, 0, 0, 0, 0, A, 8 },
                                            { 8, X, 0, X, X, 0, X, 0, B, 8 },
                                            { 8, 0, 0, X, 0, 0, X, 0, C, 8 },
                                            { 8, 0, 0, 0, 0, 0, 0, 0, D, 8 },
                                            { 8, 0, 0, 0, 0, X, 0, 0, 0, 8 },
                                            { 8, X, X, 0, 0, 0, 0, 0, 0, 8 },
                                            { 8, X, X, X, 0, 0, 0, 0, 0, 8 },
                                            { 8, 8, 8, 8, 8, 8, 8, 8, 8, 8 }
                                        },

                                hint =  new char[]                  { 'D','L','U','R','U','L' },

                                stars = new sbyte[DATA_STAR_SIZE]   { 6, 7 },
                            },

            /* Level 0 */   new Data() {

                                size =  64,

                                bound = new sbyte[,] {
                                            { 8, 8, 8, 8, 8, 8, 8, 8, 8, 8 },
                                            { 8, X, X, X, 0, 0, A, X, X, 8 },
                                            { 8, X, X, X, 0, 0, 0, C, X, 8 },
                                            { 8, X, X, 0, 0, X, 0, 0, X, 8 },
                                            { 8, X, 0, 0, 0, 0, 0, 0, X, 8 },
                                            { 8, X, 0, 0, 0, X, 0, 0, X, 8 },
                                            { 8, X, 0, 0, 0, 0, 0, 0, X, 8 },
                                            { 8, X, B, 0, 0, 0, 0, 0, X, 8 },
                                            { 8, X, X, D, 0, 0, 0, X, X, 8 },
                                            { 8, 8, 8, 8, 8, 8, 8, 8, 8, 8 }
                                        },

                                hint =  new char[]                  { 'D','L','U','R','U','L' },

                                stars = new sbyte[DATA_STAR_SIZE]   { 6, 7 },
                            },

            /* Level XX */   new Data() {

                                size =  64,

                                bound = new sbyte[,] {
                                            { 8, 8, 8, 8, 8, 8, 8, 8, 8, 8 },
                                            { 8, X, 0, 0, 0, 0, 0, 0, X, 8 },
                                            { 8, 0, 0, 0, 0, 0, 0, 0, 0, 8 },
                                            { 8, X, A, B, X, 0, 0, 0, 0, 8 },
                                            { 8, 0, 0, 0, C, D, 0, 0, 0, 8 },
                                            { 8, 0, 0, 0, 0, X, 0, 0, 0, 8 },
                                            { 8, X, 0, 0, 0, X, 0, 0, 0, 8 },
                                            { 8, X, X, 0, 0, X, 0, 0, 0, 8 },
                                            { 8, X, X, X, 0, X, X, 0, 0, 8 },
                                            { 8, 8, 8, 8, 8, 8, 8, 8, 8, 8 }
                                        },

                                hint =  new char[]                  { 'D','L','U','R','D','R' },

                                stars = new sbyte[DATA_STAR_SIZE]   { 6, 7 },
                            },

            /* Level XX */   new Data() {

                                size =  64,

                                bound = new sbyte[,] {
                                            { 8, 8, 8, 8, 8, 8, 8, 8, 8, 8 },
                                            { 8, X, 0, 0, 0, 0, 0, C, X, 8 },
                                            { 8, 0, 0, 0, 0, 0, 0, 0, D, 8 },
                                            { 8, 0, 0, X, X, X, 0, 0, 0, 8 },
                                            { 8, 0, 0, X, X, X, 0, 0, 0, 8 },
                                            { 8, 0, 0, X, X, X, X, 0, 0, 8 },
                                            { 8, 0, 0, X, X, X, X, X, X, 8 },
                                            { 8, 0, 0, 0, 0, 0, 0, 0, A, 8 },
                                            { 8, X, 0, 0, 0, 0, 0, B, X, 8 },
                                            { 8, 8, 8, 8, 8, 8, 8, 8, 8, 8 }
                                        },

                                hint =  new char[]                  { 'D','L','U','R','D','R' },

                                stars = new sbyte[DATA_STAR_SIZE]   { 6, 7 },
                            },

            /* Level XX */   new Data() {

                                size =  64,

                                bound = new sbyte[,] {
                                            { 8, 8, 8, 8, 8, 8, 8, 8, 8, 8 },
                                            { 8, X, D, 0, 0, 0, 0, 0, X, 8 },
                                            { 8, C, 0, 0, 0, 0, 0, 0, 0, 8 },
                                            { 8, 0, 0, 0, X, X, X, 0, 0, 8 },
                                            { 8, 0, 0, 0, 0, 0, X, 0, 0, 8 },
                                            { 8, 0, 0, 0, 0, 0, X, 0, 0, 8 },
                                            { 8, X, X, X, X, X, X, 0, 0, 8 },
                                            { 8, A, 0, 0, 0, 0, 0, 0, 0, 8 },
                                            { 8, X, B, 0, 0, 0, 0, 0, X, 8 },
                                            { 8, 8, 8, 8, 8, 8, 8, 8, 8, 8 }
                                        },

                                hint =  new char[]                  { 'D','R','U','L','D' },

                                stars = new sbyte[DATA_STAR_SIZE]   { 5, 6 },
                            },

            /* Level XX */   new Data() {

                                size =  64,

                                bound = new sbyte[,] {
                                            { 8, 8, 8, 8, 8, 8, 8, 8, 8, 8 },
                                            { 8, 0, 0, 0, 0, 0, 0, 0, 0, 8 },
                                            { 8, 0, 0, X, X, X, X, 0, 0, 8 },
                                            { 8, 0, 0, 0, A, B, 0, 0, 0, 8 },
                                            { 8, X, X, X, 0, 0, X, 0, 0, 8 },
                                            { 8, C, D, X, 0, 0, X, 0, 0, 8 },
                                            { 8, 0, 0, 0, 0, 0, X, 0, 0, 8 },
                                            { 8, X, X, X, 0, 0, 0, 0, 0, 8 },
                                            { 8, X, X, X, X, 0, 0, 0, X, 8 },
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
                                            { 8, X, 0, 0, 0, 0, 0, X, X, 8 },
                                            { 8, X, 0, 0, 0, 0, 0, X, X, 8 },
                                            { 8, X, A, 0, 0, 0, 0, 0, X, 8 },
                                            { 8, X, B, 0, X, X, 0, 0, X, 8 },
                                            { 8, X, C, 0, X, X, 0, 0, X, 8 },
                                            { 8, X, D, 0, X, 0, 0, 0, X, 8 },
                                            { 8, X, X, X, X, 0, 0, 0, X, 8 },
                                            { 8, 8, 8, 8, 8, 8, 8, 8, 8, 8 }
                                        },

                                hint =  new char[]                  { 'R','U','R','D','L','D' },

                                stars = new sbyte[DATA_STAR_SIZE]   { 6, 7 },
                            },

            /* Level X */  new Data() {

                                size =  64,

                                bound = new sbyte[,] {
                                            { 8, 8, 8, 8, 8, 8, 8, 8, 8, 8 },
                                            { 8, X, X, X, 0, 0, 0, 0, 0, 8 },
                                            { 8, X, 0, 0, 0, 0, 0, 0, 0, 8 },
                                            { 8, X, 0, 0, 0, X, X, 0, 0, 8 },
                                            { 8, X, 0, 0, 0, X, X, X, X, 8 },
                                            { 8, X, 0, 0, A, B, C, D, X, 8 },
                                            { 8, X, 0, 0, 0, 0, 0, 0, X, 8 },
                                            { 8, X, X, 0, 0, 0, 0, X, X, 8 },
                                            { 8, X, X, X, 0, 0, X, X, X, 8 },
                                            { 8, 8, 8, 8, 8, 8, 8, 8, 8, 8 }
                                        },

                                hint =  new char[]                  { 'R','D','L','U','R','U' },

                                stars = new sbyte[DATA_STAR_SIZE]   { 6, 7 },
                            },

            /* Level X */  new Data() {

                                size =  64,

                                bound = new sbyte[,] {
                                            { 8, 8, 8, 8, 8, 8, 8, 8, 8, 8 },
                                            { 8, X, X, X, 0, 0, 0, 0, X, 8 },
                                            { 8, X, 0, 0, 0, 0, 0, 0, X, 8 },
                                            { 8, X, 0, 0, 0, X, X, 0, X, 8 },
                                            { 8, X, 0, 0, 0, X, X, X, X, 8 },
                                            { 8, X, 0, 0, A, B, C, D, X, 8 },
                                            { 8, X, 0, 0, 0, 0, 0, 0, X, 8 },
                                            { 8, X, X, 0, 0, 0, 0, X, X, 8 },
                                            { 8, X, X, X, 0, 0, X, X, X, 8 },
                                            { 8, 8, 8, 8, 8, 8, 8, 8, 8, 8 }
                                        },

                                hint =  new char[]                  { 'U','R','D','L','U','R' },

                                stars = new sbyte[DATA_STAR_SIZE]   { 6, 7 },
                            },

            /* Level 1 */   new Data() {

                                size =  64,

                                bound = new sbyte[,] {
                                            { 8, 8, 8, 8, 8, 8, 8, 8, 8, 8 },
                                            { 8, X, X, X, X, X, X, X, X, 8 },
                                            { 8, X, X, X, X, 0, A, 0, X, 8 },
                                            { 8, X, X, X, 0, C, 0, D, X, 8 },
                                            { 8, X, X, X, 0, 0, B, 0, X, 8 },
                                            { 8, X, X, 0, 0, 0, 0, X, X, 8 },
                                            { 8, X, 0, 0, 0, X, X, X, X, 8 },
                                            { 8, X, 0, 0, X, X, X, X, X, 8 },
                                            { 8, X, X, X, X, X, X, X, X, 8 },
                                            { 8, 8, 8, 8, 8, 8, 8, 8, 8, 8 }
                                        },

                                hint =  new char[]                  { 'L','D','L','D','L','D' },

                                stars = new sbyte[DATA_STAR_SIZE]   { 6, 7 },
                            },

            /* Level 0 */   new Data() {

                                size =  64,

                                bound = new sbyte[,] {
                                            { 8, 8, 8, 8, 8, 8, 8, 8, 8, 8 },
                                            { 8, 0, 0, 0, 0, 0, X, X, X, 8 },
                                            { 8, 0, 0, 0, 0, 0, 0, 0, X, 8 },
                                            { 8, 0, 0, 0, 0, 0, 0, 0, X, 8 },
                                            { 8, 0, 0, 0, B, X, 0, 0, 0, 8 },
                                            { 8, 0, 0, A, X, C, X, 0, 0, 8 },
                                            { 8, X, X, X, D, 0, 0, X, 0, 8 },
                                            { 8, X, X, X, 0, 0, 0, 0, 0, 8 },
                                            { 8, X, X, X, X, 0, 0, 0, 0, 8 },
                                            { 8, 8, 8, 8, 8, 8, 8, 8, 8, 8 }
                                        },

                                hint =  new char[]                  { 'D','R','U','L','U','L' },

                                stars = new sbyte[DATA_STAR_SIZE]   { 6, 7 },
                            },

            /* Level 0 */   new Data() {

                                size =  64,

                                bound = new sbyte[,] {
                                            { 8, 8, 8, 8, 8, 8, 8, 8, 8, 8 },
                                            { 8, 0, 0, 0, 0, 0, 0, 0, 0, 8 },
                                            { 8, 0, 0, 0, 0, 0, 0, 0, 0, 8 },
                                            { 8, X, 0, X, B, X, 0, X, 0, 8 },
                                            { 8, X, 0, A, X, C, 0, X, 0, 8 },
                                            { 8, X, 0, X, D, X, 0, X, 0, 8 },
                                            { 8, X, X, X, 0, 0, 0, 0, 0, 8 },
                                            { 8, X, X, X, 0, 0, 0, 0, 0, 8 },
                                            { 8, X, X, X, X, 0, 0, 0, 0, 8 },
                                            { 8, 8, 8, 8, 8, 8, 8, 8, 8, 8 }
                                        },

                                hint =  new char[]                  { 'R','D','R','U','L','U' },

                                stars = new sbyte[DATA_STAR_SIZE]   { 6, 7 },
                            },

            /* Level 29 */   new Data() {

                                size =  64,

                                bound = new sbyte[,] {
                                            { 8, 8, 8, 8, 8, 8, 8, 8, 8, 8 },
                                            { 8, X, X, X, X, X, X, X, 0, 8 },
                                            { 8, X, X, X, X, X, X, 0, 0, 8 },
                                            { 8, C, 0, 0, 0, X, X, 0, 0, 8 },
                                            { 8, D, 0, 0, 0, 0, X, 0, 0, 8 },
                                            { 8, 0, 0, 0, 0, 0, 0, 0, B, 8 },
                                            { 8, 0, 0, X, 0, 0, 0, 0, A, 8 },
                                            { 8, X, X, X, 0, 0, 0, 0, X, 8 },
                                            { 8, X, X, X, 0, 0, 0, X, X, 8 },
                                            { 8, 8, 8, 8, 8, 8, 8, 8, 8, 8 }
                                        },

                                hint =  new char[]                  { 'U','L','D','L','U','L' },

                                stars = new sbyte[DATA_STAR_SIZE]   { 6, 7 },
                            },

            /* Level 28 */   new Data() {

                                size =  64,

                                bound = new sbyte[,] {
                                            { 8, 8, 8, 8, 8, 8, 8, 8, 8, 8 },
                                            { 8, X, 0, 0, 0, 0, X, X, X, 8 },
                                            { 8, 0, 0, 0, 0, 0, 0, X, X, 8 },
                                            { 8, 0, 0, 0, 0, 0, 0, X, X, 8 },
                                            { 8, X, X, 0, 0, 0, 0, X, X, 8 },
                                            { 8, 0, 0, 0, 0, 0, 0, X, X, 8 },
                                            { 8, 0, 0, 0, 0, 0, 0, 0, X, 8 },
                                            { 8, X, 0, 0, 0, 0, 0, 0, 0, 8 },
                                            { 8, A, B, C, D, 0, 0, 0, 0, 8 },
                                            { 8, 8, 8, 8, 8, 8, 8, 8, 8, 8 }
                                        },

                                hint =  new char[]                  { 'R','U','L','U','R','D' },

                                stars = new sbyte[DATA_STAR_SIZE]   { 6, 7 },
                            },

            /* Level 33 */   new Data() {

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

            /* Level 0 */   new Data() {

                                size =  64,

                                bound = new sbyte[,] {
                                            { 8, 8, 8, 8, 8, 8, 8, 8, 8, 8 },
                                            { 8, 0, 0, 0, 0, 0, 0, 0, 0, 8 },
                                            { 8, 0, 0, 0, 0, 0, 0, 0, 0, 8 },
                                            { 8, 0, 0, 0, 0, X, 0, 0, X, 8 },
                                            { 8, 0, 0, 0, X, 0, 0, X, 0, 8 },
                                            { 8, 0, 0, 0, 0, 0, 0, 0, 0, 8 },
                                            { 8, 0, 0, X, A, 0, X, B, 0, 8 },
                                            { 8, 0, 0, X, 0, 0, X, 0, 0, 8 },
                                            { 8, 0, 0, X, 0, C, X, 0, D, 8 },
                                            { 8, 8, 8, 8, 8, 8, 8, 8, 8, 8 }
                                        },

                                hint =  new char[]                  { 'L','U','L','U','L','U' },

                                stars = new sbyte[DATA_STAR_SIZE]   { 6, 7 },
                            },

            /* Level 0 */   new Data() {

                                size =  64,

                                bound = new sbyte[,] {
                                            { 8, 8, 8, 8, 8, 8, 8, 8, 8, 8 },
                                            { 8, 0, 0, 0, C, X, X, X, X, 8 },
                                            { 8, 0, 0, 0, D, X, X, X, X, 8 },
                                            { 8, X, 0, X, X, X, X, X, X, 8 },
                                            { 8, X, 0, X, 0, 0, 0, X, X, 8 },
                                            { 8, 0, 0, X, 0, X, 0, X, X, 8 },
                                            { 8, 0, 0, A, 0, 0, 0, X, 0, 8 },
                                            { 8, X, 0, 0, B, 0, 0, 0, 0, 8 },
                                            { 8, X, 0, 0, 0, 0, X, X, X, 8 },
                                            { 8, 8, 8, 8, 8, 8, 8, 8, 8, 8 }
                                        },

                                hint =  new char[]                  { 'R','U','L','D','L','U' },

                                stars = new sbyte[DATA_STAR_SIZE]   { 6, 7 },
                            },
            
            /* Level 0 */   new Data() {

                                size =  64,

                                bound = new sbyte[,] {
                                            { 8, 8, 8, 8, 8, 8, 8, 8, 8, 8 },
                                            { 8, X, X, 0, 0, 0, 0, 0, 0, 8 },
                                            { 8, 0, 0, 0, 0, 0, 0, X, X, 8 },
                                            { 8, 0, 0, 0, A, B, 0, X, X, 8 },
                                            { 8, 0, 0, 0, 0, 0, 0, X, X, 8 },
                                            { 8, 0, 0, 0, 0, 0, 0, 0, 0, 8 },
                                            { 8, X, X, 0, 0, C, D, 0, 0, 8 },
                                            { 8, 0, 0, 0, 0, 0, 0, X, X, 8 },
                                            { 8, 0, 0, 0, 0, 0, 0, X, X, 8 },
                                            { 8, 8, 8, 8, 8, 8, 8, 8, 8, 8 }
                                        },

                                hint =  new char[]                  { 'R','U','R','D','L','D' },

                                stars = new sbyte[DATA_STAR_SIZE]   { 6, 7 },
                            },

            /* Level 30 */   new Data() {

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

            /* Level XX */   new Data() {

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

            /* Level XX */   new Data() {

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

            /* Level 27 */  new Data() {

                                size =  64,

                                bound = new sbyte[,] {
                                            { 8, 8, 8, 8, 8, 8, 8, 8, 8, 8 },
                                            { 8, 0, 0, 0, 0, 0, 0, 0, 0, 8 },
                                            { 8, 0, 0, 0, 0, 0, 0, 0, 0, 8 },
                                            { 8, 0, 0, X, A, B, X, 0, 0, 8 },
                                            { 8, 0, 0, X, X, X, X, X, X, 8 },
                                            { 8, 0, 0, X, X, X, X, 0, 0, 8 },
                                            { 8, 0, 0, X, C, D, 0, 0, 0, 8 },
                                            { 8, 0, 0, 0, 0, 0, 0, 0, 0, 8 },
                                            { 8, 0, 0, 0, 0, 0, 0, 0, 0, 8 },
                                            { 8, 8, 8, 8, 8, 8, 8, 8, 8, 8 }
                                        },

                                hint =  new char[]                  { 'U','L','D','R','U','R' },

                                stars = new sbyte[DATA_STAR_SIZE]   { 6, 7 },
                            },

            /* Level X */  new Data() {

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

            /* Level 1 */   new Data() {

                                size =  64,

                                bound = new sbyte[,] {
                                            { 8, 8, 8, 8, 8, 8, 8, 8, 8, 8 },
                                            { 8, 0, 0, 0, 0, 0, 0, 0, 0, 8 },
                                            { 8, 0, 0, 0, 0, 0, 0, 0, 0, 8 },
                                            { 8, 0, X, B, X, 0, 0, 0, 0, 8 },
                                            { 8, 0, A, X, C, 0, 0, 0, 0, 8 },
                                            { 8, 0, X, D, X, 0, 0, 0, 0, 8 },
                                            { 8, 0, 0, 0, 0, 0, 0, 0, 0, 8 },
                                            { 8, 0, 0, 0, 0, 0, 0, 0, 0, 8 },
                                            { 8, 0, 0, X, 0, 0, 0, 0, 0, 8 },
                                            { 8, 8, 8, 8, 8, 8, 8, 8, 8, 8 }
                                        },

                                hint =  new char[]                  { 'L','U','R','D','R' },

                                stars = new sbyte[DATA_STAR_SIZE]   { 5, 6 },
                            },

            /* Level 2 */   new Data() {

                                size =  64,

                                bound = new sbyte[,] {
                                            { 8, 8, 8, 8, 8, 8, 8, 8, 8, 8 },
                                            { 8, 0, 0, 0, 0, 0, X, X, X, 8 },
                                            { 8, X, X, 0, 0, 0, 0, 0, 0, 8 },
                                            { 8, X, X, 0, 0, 0, 0, 0, 0, 8 },
                                            { 8, X, X, 0, 0, 0, 0, 0, 0, 8 },
                                            { 8, 0, 0, 0, 0, 0, 0, 0, 0, 8 },
                                            { 8, 0, 0, 0, 0, 0, 0, 0, 0, 8 },
                                            { 8, 0, 0, 0, 0, 0, 0, 0, 0, 8 },
                                            { 8, A, B, C, D, 0, X, X, X, 8 },
                                            { 8, 8, 8, 8, 8, 8, 8, 8, 8, 8 }
                                        },

                                hint =  new char[]                  { 'U','L','D','R','D' },

                                stars = new sbyte[DATA_STAR_SIZE]   { 5, 6 },
                            },

            /* Level 3 */   new Data() {

                                size =  64,

                                bound = new sbyte[,] {
                                            { 8, 8, 8, 8, 8, 8, 8, 8, 8, 8 },
                                            { 8, X, X, 0, 0, 0, 0, 0, X, 8 },
                                            { 8, X, X, 0, 0, 0, 0, 0, X, 8 },
                                            { 8, 0, 0, 0, 0, 0, 0, 0, 0, 8 },
                                            { 8, 0, 0, 0, 0, 0, 0, 0, 0, 8 },
                                            { 8, 0, 0, 0, X, 0, 0, X, X, 8 },
                                            { 8, 0, X, 0, 0, 0, 0, X, X, 8 },
                                            { 8, A, X, 0, C, D, 0, 0, 0, 8 },
                                            { 8, B, X, 0, 0, X, X, 0, 0, 8 },
                                            { 8, 8, 8, 8, 8, 8, 8, 8, 8, 8 }
                                        },

                                hint =  new char[]                  { 'D','L','U','R','D' },

                                stars = new sbyte[DATA_STAR_SIZE]   { 5, 6 },
                            },

            /* Level 4 */   new Data() {

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

            /* Level 5 */   new Data() {

                                size =  64,

                                bound = new sbyte[,] {
                                            { 8, 8, 8, 8, 8, 8, 8, 8, 8, 8 },
                                            { 8, X, X, X, 0, C, D, X, X, 8 },
                                            { 8, X, X, 0, 0, 0, 0, X, X, 8 },
                                            { 8, X, X, 0, 0, 0, 0, X, X, 8 },
                                            { 8, X, 0, 0, 0, 0, 0, 0, X, 8 },
                                            { 8, 0, 0, 0, 0, 0, 0, 0, X, 8 },
                                            { 8, 0, 0, 0, 0, X, X, X, X, 8 },
                                            { 8, 0, 0, 0, 0, 0, 0, 0, 0, 8 },
                                            { 8, 0, X, A, B, 0, 0, 0, 0, 8 },
                                            { 8, 8, 8, 8, 8, 8, 8, 8, 8, 8 }
                                        },

                                hint =  new char[]                  { 'D','L','U','R','D' },

                                stars = new sbyte[DATA_STAR_SIZE]   { 5, 6 },
                            },

            /* Level 6 */   new Data() {

                                size =  64,

                                bound = new sbyte[,] {
                                            { 8, 8, 8, 8, 8, 8, 8, 8, 8, 8 },
                                            { 8, 0, 0, 0, 0, 0, 0, 0, 0, 8 },
                                            { 8, X, X, 0, 0, 0, 0, 0, 0, 8 },
                                            { 8, 0, 0, 0, 0, 0, 0, 0, 0, 8 },
                                            { 8, 0, 0, 0, 0, 0, 0, X, X, 8 },
                                            { 8, 0, 0, 0, 0, 0, 0, 0, 0, 8 },
                                            { 8, 0, 0, 0, 0, 0, 0, 0, 0, 8 },
                                            { 8, 0, 0, 0, X, X, 0, 0, 0, 8 },
                                            { 8, 0, 0, A, B, C, D, 0, 0, 8 },
                                            { 8, 8, 8, 8, 8, 8, 8, 8, 8, 8 }
                                        },

                                hint =  new char[]                  { 'U','L','U','R','U' },

                                stars = new sbyte[DATA_STAR_SIZE]   { 5, 6 },
                            },

            /* Level 7 */   new Data() {

                                size =  64,

                                bound = new sbyte[,] {
                                            { 8, 8, 8, 8, 8, 8, 8, 8, 8, 8 },
                                            { 8, X, 0, 0, 0, 0, 0, 0, 0, 8 },
                                            { 8, 0, 0, 0, 0, 0, 0, 0, 0, 8 },
                                            { 8, 0, 0, 0, X, X, X, X, X, 8 },
                                            { 8, A, 0, 0, 0, X, X, 0, X, 8 },
                                            { 8, B, 0, 0, 0, 0, X, C, D, 8 },
                                            { 8, 0, 0, 0, X, X, X, 0, 0, 8 },
                                            { 8, 0, 0, 0, 0, 0, 0, 0, 0, 8 },
                                            { 8, X, 0, 0, 0, 0, 0, 0, 0, 8 },
                                            { 8, 8, 8, 8, 8, 8, 8, 8, 8, 8 }
                                        },

                                hint =  new char[]                  { 'R','D','L','U','R' },

                                stars = new sbyte[DATA_STAR_SIZE]   { 5, 6 },
                            },

            /* Level 8 */   new Data() {

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

            /* Level 9 */  new Data() {

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

            /* Level 10 */  new Data() {

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

            /* Level 11 */  new Data() {

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

            /* Level 12 */   new Data() {

                                size =  64,

                                bound = new sbyte[,] {
                                            { 8, 8, 8, 8, 8, 8, 8, 8, 8, 8 },
                                            { 8, X, X, X, A, 0, X, X, X, 8 },
                                            { 8, X, X, X, B, 0, X, X, X, 8 },
                                            { 8, X, X, 0, 0, 0, 0, X, X, 8 },
                                            { 8, X, X, 0, 0, 0, 0, X, X, 8 },
                                            { 8, X, 0, 0, 0, 0, 0, C, X, 8 },
                                            { 8, X, 0, 0, 0, 0, 0, D, X, 8 },
                                            { 8, X, X, X, 0, 0, 0, X, X, 8 },
                                            { 8, X, X, X, 0, 0, 0, X, X, 8 },
                                            { 8, 8, 8, 8, 8, 8, 8, 8, 8, 8 }
                                        },

                                hint =  new char[]                  { 'D','R','U','L','D' },

                                stars = new sbyte[DATA_STAR_SIZE]   { 5, 6 },
                            },

            /* Level 13 */   new Data() {

                                size =  64,

                                bound = new sbyte[,] {
                                            { 8, 8, 8, 8, 8, 8, 8, 8, 8, 8 },
                                            { 8, 0, 0, 0, 0, 0, 0, 0, 0, 8 },
                                            { 8, 0, 0, 0, 0, 0, 0, 0, 0, 8 },
                                            { 8, 0, 0, 0, 0, 0, 0, 0, X, 8 },
                                            { 8, 0, 0, 0, 0, 0, 0, 0, X, 8 },
                                            { 8, 0, 0, 0, X, 0, 0, 0, 0, 8 },
                                            { 8, 0, 0, 0, 0, 0, 0, 0, 0, 8 },
                                            { 8, A, X, 0, C, 0, 0, 0, 0, 8 },
                                            { 8, B, X, X, D, 0, 0, 0, 0, 8 },
                                            { 8, 8, 8, 8, 8, 8, 8, 8, 8, 8 }
                                        },

                                hint =  new char[]                  { 'U','L','U','R','U' },

                                stars = new sbyte[DATA_STAR_SIZE]   { 5, 6 },
                            },

            /* Level 14 */  new Data() {

                                size =  64,

                                bound = new sbyte[,] {
                                            { 8, 8, 8, 8, 8, 8, 8, 8, 8, 8 },
                                            { 8, 0, 0, 0, 0, 0, X, 0, X, 8 },
                                            { 8, 0, 0, 0, 0, X, 0, 0, 0, 8 },
                                            { 8, 0, 0, X, X, X, 0, 0, 0, 8 },
                                            { 8, X, 0, A, X, C, 0, 0, 0, 8 },
                                            { 8, 0, 0, B, X, D, 0, 0, X, 8 },
                                            { 8, 0, 0, X, X, X, 0, 0, X, 8 },
                                            { 8, 0, 0, 0, 0, 0, 0, 0, X, 8 },
                                            { 8, 0, 0, 0, 0, 0, X, X, X, 8 },
                                            { 8, 8, 8, 8, 8, 8, 8, 8, 8, 8 }
                                        },

                                hint =  new char[]                  { 'R','U','L','D','L' },

                                stars = new sbyte[DATA_STAR_SIZE]   { 5, 6 },
                            },

            /* Level 15 */  new Data() {

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

            /* Level 16 */   new Data() {

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

            /* Level 17 */   new Data() {

                                size =  64,

                                bound = new sbyte[,] {
                                            { 8, 8, 8, 8, 8, 8, 8, 8, 8, 8 },
                                            { 8, X, X, X, X, X, X, X, X, 8 },
                                            { 8, X, X, X, X, X, X, X, 0, 8 },
                                            { 8, A, B, 0, 0, X, X, X, 0, 8 },
                                            { 8, X, X, 0, 0, X, 0, C, 0, 8 },
                                            { 8, X, X, 0, 0, X, 0, D, 0, 8 },
                                            { 8, X, X, 0, 0, 0, 0, X, X, 8 },
                                            { 8, X, X, X, 0, 0, 0, X, X, 8 },
                                            { 8, X, X, X, X, X, X, X, X, 8 },
                                            { 8, 8, 8, 8, 8, 8, 8, 8, 8, 8 }
                                        },

                                hint =  new char[]                  { 'L','D','R','D','R' },

                                stars = new sbyte[DATA_STAR_SIZE]   { 5, 6 },
                            },

            /* Level 18 */   new Data() {

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
                                            { 8, X, A, B, C, D, X, X, X, 8 },
                                            { 8, 8, 8, 8, 8, 8, 8, 8, 8, 8 }
                                        },

                                hint =  new char[]                  { 'U','L','D','R','D' },

                                stars = new sbyte[DATA_STAR_SIZE]   { 5, 6 },
                            },

            /* Level 19 */   new Data() {

                                size =  64,

                                bound = new sbyte[,] {
                                            { 8, 8, 8, 8, 8, 8, 8, 8, 8, 8 },
                                            { 8, X, X, X, X, X, X, X, X, 8 },
                                            { 8, X, 0, 0, A, B, C, D, X, 8 },
                                            { 8, X, 0, 0, 0, 0, 0, 0, X, 8 },
                                            { 8, X, X, 0, 0, X, 0, 0, X, 8 },
                                            { 8, X, X, 0, 0, X, 0, 0, X, 8 },
                                            { 8, X, X, 0, 0, 0, 0, 0, X, 8 },
                                            { 8, X, X, 0, 0, 0, X, X, X, 8 },
                                            { 8, X, X, X, X, X, X, X, X, 8 },
                                            { 8, 8, 8, 8, 8, 8, 8, 8, 8, 8 }
                                        },

                                hint =  new char[]                  { 'L','D','R','D','L' },

                                stars = new sbyte[DATA_STAR_SIZE]   { 5, 6 },
                            },

            /* Level 20 */  new Data() {

                                size =  64,

                                bound = new sbyte[,] {
                                            { 8, 8, 8, 8, 8, 8, 8, 8, 8, 8 },
                                            { 8, 0, 0, 0, 0, 0, 0, 0, 0, 8 },
                                            { 8, 0, 0, X, X, X, X, 0, 0, 8 },
                                            { 8, X, 0, A, X, C, 0, 0, X, 8 },
                                            { 8, 0, 0, B, X, D, 0, 0, 0, 8 },
                                            { 8, 0, 0, X, X, X, X, 0, 0, 8 },
                                            { 8, 0, 0, 0, 0, 0, X, 0, 0, 8 },
                                            { 8, X, X, 0, 0, 0, 0, 0, 0, 8 },
                                            { 8, X, X, 0, 0, 0, 0, X, X, 8 },
                                            { 8, 8, 8, 8, 8, 8, 8, 8, 8, 8 }
                                        },

                                hint =  new char[]                  { 'L','D','R','D','L' },

                                stars = new sbyte[DATA_STAR_SIZE]   { 5, 6 },
                            },
            
            /* Level 21 */   new Data() {

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

            /* Level 22 */   new Data() {

                                size =  64,

                                bound = new sbyte[,] {
                                            { 8, 8, 8, 8, 8, 8, 8, 8, 8, 8 },
                                            { 8, X, X, D, 0, 0, 0, X, X, 8 },
                                            { 8, 0, 0, 0, 0, 0, 0, 0, 0, 8 },
                                            { 8, 0, 0, 0, X, 0, 0, 0, 0, 8 },
                                            { 8, A, 0, 0, X, 0, 0, 0, 0, 8 },
                                            { 8, X, X, X, X, 0, 0, X, X, 8 },
                                            { 8, X, X, X, 0, 0, 0, 0, 0, 8 },
                                            { 8, 0, 0, 0, 0, 0, 0, 0, 0, 8 },
                                            { 8, B, 0, 0, 0, X, X, C, 0, 8 },
                                            { 8, 8, 8, 8, 8, 8, 8, 8, 8, 8 }
                                        },

                                hint =  new char[]                  { 'R','U','R','D','R' },

                                stars = new sbyte[DATA_STAR_SIZE]   { 5, 6 },
                            },

            /* Level 23 */   new Data() {

                                size =  64,

                                bound = new sbyte[,] {
                                            { 8, 8, 8, 8, 8, 8, 8, 8, 8, 8 },
                                            { 8, 0, X, X, 0, 0, 0, 0, 0, 8 },
                                            { 8, 0, X, 0, 0, 0, 0, 0, 0, 8 },
                                            { 8, 0, 0, 0, 0, 0, 0, X, X, 8 },
                                            { 8, 0, 0, X, 0, 0, 0, 0, 0, 8 },
                                            { 8, 0, 0, A, 0, 0, 0, 0, 0, 8 },
                                            { 8, X, C, X, D, X, 0, 0, 0, 8 },
                                            { 8, 0, 0, B, 0, 0, 0, 0, X, 8 },
                                            { 8, 0, 0, X, 0, 0, 0, 0, 0, 8 },
                                            { 8, 8, 8, 8, 8, 8, 8, 8, 8, 8 }
                                        },

                                hint =  new char[]                  { 'U','R','U','L','U' },

                                stars = new sbyte[DATA_STAR_SIZE]   { 5, 6 },
                            },

            /* Level 24 */   new Data() {

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

            /* Level 25 */   new Data() {

                                size =  64,

                                bound = new sbyte[,] {
                                            { 8, 8, 8, 8, 8, 8, 8, 8, 8, 8 },
                                            { 8, 0, 0, 0, 0, 0, X, X, X, 8 },
                                            { 8, 0, 0, 0, 0, 0, 0, 0, 0, 8 },
                                            { 8, 0, 0, X, B, X, 0, 0, 0, 8 },
                                            { 8, 0, 0, A, X, C, 0, 0, 0, 8 },
                                            { 8, 0, 0, X, D, X, 0, 0, 0, 8 },
                                            { 8, 0, 0, 0, 0, 0, 0, 0, 0, 8 },
                                            { 8, 0, 0, 0, 0, 0, 0, 0, 0, 8 },
                                            { 8, 0, 0, X, 0, 0, 0, X, 0, 8 },
                                            { 8, 8, 8, 8, 8, 8, 8, 8, 8, 8 }
                                        },

                                hint =  new char[]                  { 'L','D','R','U','L' },

                                stars = new sbyte[DATA_STAR_SIZE]   { 5, 6 },
                            },

            /* Level 26 */  new Data() {

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

                                hint =  new char[]                  { 'L','D','L','U','L','D' },

                                stars = new sbyte[DATA_STAR_SIZE]   { 6, 7 },
                            },

            /* Level 27 */   new Data() {

                                size =  100,

                                bound = new sbyte[,] {
                                            { 0, 0, 0, 0, 0, 0, 0, 0, X, X },
                                            { 0, 0, 0, 0, 0, 0, 0, 0, X, X },
                                            { 0, 0, 0, 0, 0, 0, 0, 0, X, X },
                                            { 0, 0, 0, 0, 0, 0, 0, 0, X, X },
                                            { 0, 0, X, X, 0, 0, 0, 0, 0, 0 },
                                            { 0, 0, X, X, 0, 0, 0, 0, 0, 0 },
                                            { 0, 0, X, 0, 0, X, X, X, 0, 0 },
                                            { 0, 0, 0, 0, 0, 0, X, 0, 0, 0 },
                                            { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                                            { A, B, C, D, 0, 0, 0, 0, X, X },
                                        },

                                hint =  new char[]                  { 'U','R','D','R','D','L' },

                                stars = new sbyte[DATA_STAR_SIZE]   { 6, 7 },
                            },

            /* Level 28 */   new Data() {

                                size =  64,

                                bound = new sbyte[,] {
                                            { 8, 8, 8, 8, 8, 8, 8, 8, 8, 8 },
                                            { 8, 0, 0, 0, 0, 0, 0, 0, 0, 8 },
                                            { 8, 0, 0, 0, X, X, 0, 0, 0, 8 },
                                            { 8, 0, 0, 0, 0, 0, 0, 0, 0, 8 },
                                            { 8, 0, 0, 0, 0, 0, 0, 0, 0, 8 },
                                            { 8, 0, 0, 0, 0, 0, 0, 0, 0, 8 },
                                            { 8, 0, 0, 0, 0, 0, 0, 0, 0, 8 },
                                            { 8, A, 0, 0, X, X, X, 0, C, 8 },
                                            { 8, B, 0, X, X, X, X, 0, D, 8 },
                                            { 8, 8, 8, 8, 8, 8, 8, 8, 8, 8 }
                                        },

                                hint =  new char[]                  { 'U','L','U','L','D','L' },

                                stars = new sbyte[DATA_STAR_SIZE]   { 6, 7 },
                            },

            /* Level 29 */   new Data() {

                                size =  64,

                                bound = new sbyte[,] {
                                            { 8, 8, 8, 8, 8, 8, 8, 8, 8, 8 },
                                            { 8, X, X, 0, 0, C, D, X, X, 8 },
                                            { 8, X, X, 0, 0, 0, 0, X, X, 8 },
                                            { 8, X, X, X, 0, 0, 0, X, X, 8 },
                                            { 8, 0, 0, 0, 0, 0, 0, X, X, 8 },
                                            { 8, 0, 0, 0, 0, X, X, X, X, 8 },
                                            { 8, 0, 0, 0, 0, 0, 0, 0, 0, 8 },
                                            { 8, 0, 0, 0, 0, 0, 0, 0, 0, 8 },
                                            { 8, 0, X, A, B, 0, 0, 0, 0, 8 },
                                            { 8, 8, 8, 8, 8, 8, 8, 8, 8, 8 }
                                        },

                                hint =  new char[]                  { 'R','U','L','U','R','D' },

                                stars = new sbyte[DATA_STAR_SIZE]   { 6, 7 },
                            },

            /* Level 30 */   new Data() {

                                size =  64,

                                bound = new sbyte[,] {
                                            { 8, 8, 8, 8, 8, 8, 8, 8, 8, 8 },
                                            { 8, 0, 0, 0, 0, 0, 0, C, D, 8 },
                                            { 8, 0, 0, 0, X, 0, 0, 0, 0, 8 },
                                            { 8, 0, 0, 0, X, 0, 0, X, X, 8 },
                                            { 8, 0, 0, 0, X, 0, 0, 0, 0, 8 },
                                            { 8, 0, 0, 0, X, X, X, 0, 0, 8 },
                                            { 8, X, X, 0, 0, 0, 0, 0, 0, 8 },
                                            { 8, A, B, 0, 0, X, X, 0, 0, 8 },
                                            { 8, X, X, 0, 0, 0, 0, 0, 0, 8 },
                                            { 8, 8, 8, 8, 8, 8, 8, 8, 8, 8 }
                                        },

                                hint =  new char[]                  { 'R','D','L','D','R','D' },

                                stars = new sbyte[DATA_STAR_SIZE]   { 6, 7 },
                            },

            /* Level 31 */   new Data() {

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

            /* Level 32 */   new Data() {

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

            /* Level 33 */   new Data() {

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

            /* Level 34 */   new Data() {

                                size =  64,

                                bound = new sbyte[,] {
                                            { 8, 8, 8, 8, 8, 8, 8, 8, 8, 8 },
                                            { 8, 0, 0, 0, 0, 0, 0, 0, 0, 8 },
                                            { 8, X, C, D, 0, 0, 0, 0, 0, 8 },
                                            { 8, X, X, X, 0, 0, 0, 0, 0, 8 },
                                            { 8, X, X, X, 0, 0, 0, 0, 0, 8 },
                                            { 8, X, X, X, 0, 0, 0, 0, 0, 8 },
                                            { 8, X, X, X, 0, 0, 0, 0, 0, 8 },
                                            { 8, X, 0, 0, 0, 0, 0, 0, 0, 8 },
                                            { 8, A, B, 0, 0, 0, X, X, X, 8 },
                                            { 8, 8, 8, 8, 8, 8, 8, 8, 8, 8 }
                                        },

                                hint =  new char[]                  { 'U','R','U','L','D','R' },

                                stars = new sbyte[DATA_STAR_SIZE]   { 6, 7 },
                            },
 
            /* Level 35 */   new Data() {

                                size =  64,

                                bound = new sbyte[,] {
                                            { 8, 8, 8, 8, 8, 8, 8, 8, 8, 8 },
                                            { 8, X, X, 0, 0, 0, 0, 0, 0, 8 },
                                            { 8, X, X, 0, 0, X, X, 0, 0, 8 },
                                            { 8, X, 0, 0, 0, X, X, 0, 0, 8 },
                                            { 8, 0, 0, 0, 0, X, X, 0, 0, 8 },
                                            { 8, 0, 0, 0, 0, X, X, 0, 0, 8 },
                                            { 8, A, B, 0, 0, X, X, C, D, 8 },
                                            { 8, X, X, 0, 0, 0, 0, X, X, 8 },
                                            { 8, X, X, 0, 0, 0, 0, X, X, 8 },
                                            { 8, 8, 8, 8, 8, 8, 8, 8, 8, 8 }
                                        },

                                hint =  new char[]                  { 'R','D','R','U','L','D' },

                                stars = new sbyte[DATA_STAR_SIZE]   { 6, 7 },
                            },

            /* Level 36 */   new Data() {

                                size =  64,

                                bound = new sbyte[,] {
                                            { 8, 8, 8, 8, 8, 8, 8, 8, 8, 8 },
                                            { 8, 0, 0, 0, 0, 0, 0, X, X, 8 },
                                            { 8, 0, 0, 0, 0, 0, 0, X, X, 8 },
                                            { 8, 0, X, X, 0, 0, 0, 0, 0, 8 },
                                            { 8, 0, X, X, 0, 0, 0, 0, 0, 8 },
                                            { 8, 0, X, X, X, X, X, X, 0, 8 },
                                            { 8, 0, 0, 0, X, X, X, 0, 0, 8 },
                                            { 8, 0, 0, 0, 0, X, 0, 0, 0, 8 },
                                            { 8, 0, 0, A, B, C, D, 0, 0, 8 },
                                            { 8, 8, 8, 8, 8, 8, 8, 8, 8, 8 }
                                        },

                                hint =  new char[]                  { 'U','R','U','L','U','L' },

                                stars = new sbyte[DATA_STAR_SIZE]   { 6, 7 },
                            },

            /* Level 37 */   new Data() {

                                size =  64,

                                bound = new sbyte[,] {
                                            { 8, 8, 8, 8, 8, 8, 8, 8, 8, 8 },
                                            { 8, X, X, X, X, X, X, X, X, 8 },
                                            { 8, X, X, 0, X, X, 0, 0, X, 8 },
                                            { 8, X, 0, 0, X, X, 0, 0, X, 8 },
                                            { 8, X, 0, 0, X, X, 0, 0, X, 8 },
                                            { 8, X, C, D, 0, 0, 0, 0, X, 8 },
                                            { 8, X, A, 0, X, X, X, X, X, 8 },
                                            { 8, X, B, 0, X, X, X, X, X, 8 },
                                            { 8, X, X, X, X, X, X, X, X, 8 },
                                            { 8, 8, 8, 8, 8, 8, 8, 8, 8, 8 }
                                        },

                                hint =  new char[]                  { 'R','U','L','D','L','D' },

                                stars = new sbyte[DATA_STAR_SIZE]   { 6, 7 },
                            },

            /* Level 38 */   new Data() {

                                size =  64,

                                bound = new sbyte[,] {
                                            { 8, 8, 8, 8, 8, 8, 8, 8, 8, 8 },
                                            { 8, X, X, 0, X, A, 0, 0, X, 8 },
                                            { 8, X, 0, 0, 0, B, 0, 0, 0, 8 },
                                            { 8, 0, 0, X, X, 0, 0, 0, 0, 8 },
                                            { 8, 0, 0, X, X, 0, 0, 0, 0, 8 },
                                            { 8, 0, 0, 0, 0, 0, 0, 0, 0, 8 },
                                            { 8, X, X, 0, 0, 0, 0, X, X, 8 },
                                            { 8, X, X, 0, 0, 0, 0, C, D, 8 },
                                            { 8, X, X, X, 0, 0, 0, 0, X, 8 },
                                            { 8, 8, 8, 8, 8, 8, 8, 8, 8, 8 }
                                        },

                                hint =  new char[]                  { 'R','D','L','U','L','D' },

                                stars = new sbyte[DATA_STAR_SIZE]   { 6, 7 },
                            },

            /* Level 39 */   new Data() {

                                size =  64,

                                bound = new sbyte[,] {
                                            { 8, 8, 8, 8, 8, 8, 8, 8, 8, 8 },
                                            { 8, X, X, X, X, X, D, 0, 0, 8 },
                                            { 8, X, X, X, X, X, C, 0, 0, 8 },
                                            { 8, X, 0, 0, 0, 0, 0, 0, 0, 8 },
                                            { 8, 0, 0, 0, 0, 0, 0, 0, 0, 8 },
                                            { 8, 0, X, 0, 0, X, 0, X, 0, 8 },
                                            { 8, 0, X, 0, 0, X, 0, 0, 0, 8 },
                                            { 8, 0, X, 0, 0, X, 0, 0, 0, 8 },
                                            { 8, A, 0, 0, B, X, 0, X, 0, 8 },
                                            { 8, 8, 8, 8, 8, 8, 8, 8, 8, 8 }
                                        },

                                hint =  new char[]                  { 'U','R','D','L','U','R' },

                                stars = new sbyte[DATA_STAR_SIZE]   { 6, 7 },
                            },

            /* Level 40 */   new Data() {

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

            // /* Level X */   new Data() {

            //                     size =  64,

            //                     bound = new sbyte[,] {
            //                                 { 8, 8, 8, 8, 8, 8, 8, 8, 8, 8 },
            //                                 { 8, X, 0, 0, 0, 0, 0, 0, 0, 8 },
            //                                 { 8, X, 0, 0, X, X, X, 0, 0, 8 },
            //                                 { 8, X, 0, 0, 0, 0, 0, 0, 0, 8 },
            //                                 { 8, X, X, 0, 0, 0, 0, 0, X, 8 },
            //                                 { 8, X, X, X, A, X, X, X, X, 8 },
            //                                 { 8, X, X, X, B, X, X, X, X, 8 },
            //                                 { 8, X, X, X, C, X, X, X, X, 8 },
            //                                 { 8, X, X, X, D, X, X, X, X, 8 },
            //                                 { 8, 8, 8, 8, 8, 8, 8, 8, 8, 8 }
            //                             },

            //                     hint =  new char[]                  { 'U','R','U','R','U' },

            //                     stars = new sbyte[DATA_STAR_SIZE]   { 5, 6 },
            //                 },

            // /* Level X */  new Data() {

            //                     size =  64,

            //                     bound = new sbyte[,] {
            //                                 { 8, 8, 8, 8, 8, 8, 8, 8, 8, 8 },
            //                                 { 8, X, X, X, 0, 0, X, X, X, 8 },
            //                                 { 8, X, X, X, 0, 0, 0, X, X, 8 },
            //                                 { 8, X, X, X, 0, 0, 0, 0, X, 8 },
            //                                 { 8, D, C, B, A, 0, 0, 0, 0, 8 },
            //                                 { 8, X, X, 0, 0, 0, 0, 0, 0, 8 },
            //                                 { 8, X, X, 0, 0, 0, 0, 0, X, 8 },
            //                                 { 8, 0, 0, 0, 0, 0, 0, X, X, 8 },
            //                                 { 8, 0, 0, 0, 0, 0, X, X, X, 8 },
            //                                 { 8, 8, 8, 8, 8, 8, 8, 8, 8, 8 }
            //                             },

            //                     hint =  new char[]                  { 'R','D','L','D','L' },

            //                     stars = new sbyte[DATA_STAR_SIZE]   { 5, 6 },
            //                 },

            // /* Level X */  new Data() {

            //                     size =  64,

            //                     bound = new sbyte[,] {
            //                                 { 8, 8, 8, 8, 8, 8, 8, 8, 8, 8 },
            //                                 { 8, X, X, X, A, 0, X, X, X, 8 },
            //                                 { 8, X, X, B, 0, 0, 0, X, X, 8 },
            //                                 { 8, X, C, 0, 0, 0, 0, 0, X, 8 },
            //                                 { 8, D, 0, 0, 0, 0, 0, 0, 0, 8 },
            //                                 { 8, X, X, 0, 0, 0, 0, 0, 0, 8 },
            //                                 { 8, X, X, 0, 0, 0, 0, 0, X, 8 },
            //                                 { 8, 0, 0, 0, 0, 0, 0, X, X, 8 },
            //                                 { 8, 0, 0, 0, 0, 0, X, X, X, 8 },
            //                                 { 8, 8, 8, 8, 8, 8, 8, 8, 8, 8 }
            //                             },

            //                     hint =  new char[]                  { 'R','D','L','D','L' },

            //                     stars = new sbyte[DATA_STAR_SIZE]   { 5, 6 },
            //                 },

            // /* Level 0 */   new Data() {

            //                     size =  64,

            //                     bound = new sbyte[,] {
            //                                 { 8, 8, 8, 8, 8, 8, 8, 8, 8, 8 },
            //                                 { 8, X, X, 0, 0, 0, 0, 0, 0, 8 },
            //                                 { 8, X, X, 0, 0, 0, 0, 0, 0, 8 },
            //                                 { 8, 0, 0, 0, 0, 0, 0, 0, 0, 8 },
            //                                 { 8, 0, 0, 0, 0, X, X, X, X, 8 },
            //                                 { 8, 0, 0, 0, 0, 0, 0, X, X, 8 },
            //                                 { 8, X, X, 0, 0, 0, 0, 0, 0, 8 },
            //                                 { 8, X, X, X, 0, 0, 0, 0, 0, 8 },
            //                                 { 8, X, X, X, X, A, B, C, D, 8 },
            //                                 { 8, 8, 8, 8, 8, 8, 8, 8, 8, 8 }
            //                             },

            //                     hint =  new char[]                  { 'U','L','U','R','U' },

            //                     stars = new sbyte[DATA_STAR_SIZE]   { 5, 6 },
            //                 },


        };
    }
}