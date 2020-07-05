using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelDemo : Level
{
	public LevelDemo()
	{
		data = new Data[] {

			/* Puzzle 0 */	new Data() {

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

								stars = new sbyte[DATA_STAR_SIZE]   { 1, 2 },
							},

            /* Puzzle 15 */	new Data() {

								size =  64,

								bound = new sbyte[,] {
											{ X, X, X, X, X, X, X, X, X, X, },
                                            { X, X, X, X, X, X, X, X, X, X, },
											{ X, X, 0, 0, 0, 0, 0, 0, X, X, },
											{ X, X, 0, 0, 0, 0, 0, 0, X, X, },
											{ X, X, 0, 0, 0, 0, 0, A, X, X, },
											{ X, X, 0, 0, B, 0, 0, X, X, X, },
											{ X, X, 0, C, 0, 0, 0, 0, X, X, },
											{ X, X, 0, 0, D, 0, 0, 0, X, X, },
                                            { X, X, X, X, X, X, X, X, X, X, },
											{ X, X, X, X, X, X, X, X, X, X, },
										},

								hint =  new char[]                  { 'D','L','D','R','D', },

								stars = new sbyte[DATA_STAR_SIZE]   { 5, 6 },
							},

            /* Puzzle 1 */	new Data() {

								size =  64,

								bound = new sbyte[,] {
											{ X, X, X, X, X, X, X, X, X, X, },
											{ X, X, X, 0, 0, X, 0, X, X, X, },
											{ X, X, X, 0, 0, 0, 0, X, X, X, },
											{ X, X, X, 0, 0, 0, 0, 0, X, X, },
											{ X, X, 0, X, 0, 0, 0, 0, X, X, },
											{ X, X, A, B, C, D, 0, X, X, X, },
											{ X, X, X, X, 0, 0, 0, 0, X, X, },
											{ X, X, 0, 0, 0, 0, 0, 0, X, X, },
											{ X, X, X, 0, 0, 0, 0, 0, X, X, },
											{ X, X, X, X, X, X, X, X, X, X, },
										},

								hint =  new char[]                  { 'U','R','D','R','D', },

								stars = new sbyte[DATA_STAR_SIZE]   { 5, 6 },
							},

			/* Puzzle 2 */	new Data() {

								size =  64,

								bound = new sbyte[,] {
											{ X, X, X, X, X, X, X, X, X, X, },
											{ X, 0, 0, 0, X, 0, X, X, X, X, },
											{ X, 0, 0, 0, 0, 0, X, X, X, X, },
											{ X, A, X, 0, 0, 0, 0, 0, X, X, },
											{ X, 0, X, X, 0, 0, 0, 0, X, X, },
											{ X, 0, X, X, X, 0, 0, 0, B, X, },
											{ X, 0, 0, 0, X, 0, 0, 0, 0, X, },
											{ X, 0, C, 0, X, 0, 0, 0, 0, X, },
											{ X, 0, 0, 0, D, 0, 0, 0, 0, X, },
											{ X, X, X, X, X, X, X, X, X, X, },
										},

								hint =  new char[]                  { 'U','R','D','R','D', },

								stars = new sbyte[DATA_STAR_SIZE]   { 5, 6 },
							},

			/* Puzzle 3 */	new Data() {

								size =  64,

								bound = new sbyte[,] {
											{ X, X, X, X, X, X, X, X, X, X, },
											{ X, X, 0, 0, 0, 0, 0, 0, 0, X, },
											{ X, 0, A, 0, 0, 0, B, 0, X, X, },
											{ X, 0, 0, 0, C, 0, 0, 0, 0, X, },
											{ X, 0, 0, 0, 0, 0, 0, 0, 0, X, },
											{ X, 0, 0, 0, 0, 0, 0, 0, 0, X, },
											{ X, 0, 0, 0, 0, 0, 0, 0, 0, X, },
											{ X, 0, 0, D, 0, 0, 0, 0, 0, X, },
											{ X, 0, 0, X, 0, 0, 0, 0, 0, X, },
											{ X, X, X, X, X, X, X, X, X, X, },
										},

								hint =  new char[]                  { 'R','U','L','D','L', },

								stars = new sbyte[DATA_STAR_SIZE]   { 5, 6 },
							},

			/* Puzzle 4 */	new Data() {

								size =  64,

								bound = new sbyte[,] {
											{ X, X, X, X, X, X, X, X, X, X, },
											{ X, X, X, X, A, B, 0, 0, 0, X, },
											{ X, X, 0, 0, 0, 0, 0, 0, 0, X, },
											{ X, X, X, 0, 0, 0, X, 0, 0, X, },
											{ X, X, 0, 0, 0, 0, 0, 0, 0, X, },
											{ X, X, 0, 0, 0, 0, 0, 0, X, X, },
											{ X, X, X, X, 0, 0, 0, 0, 0, X, },
											{ X, X, X, 0, 0, 0, 0, 0, 0, X, },
											{ X, X, 0, C, 0, 0, D, 0, 0, X, },
											{ X, X, X, X, X, X, X, X, X, X, },
										},

								hint =  new char[]                  { 'R','U','L','U','R', },

								stars = new sbyte[DATA_STAR_SIZE]   { 5, 6 },
							},

			/* Puzzle 5 */	new Data() {

								size =  64,

								bound = new sbyte[,] {
											{ X, X, X, X, X, X, X, X, X, X, },
											{ X, 0, A, 0, 0, 0, 0, 0, 0, X, },
											{ X, B, 0, 0, 0, 0, 0, 0, 0, X, },
											{ X, 0, 0, X, 0, 0, 0, 0, 0, X, },
											{ X, 0, 0, X, 0, 0, 0, 0, 0, X, },
											{ X, 0, 0, 0, 0, 0, 0, 0, 0, X, },
											{ X, 0, 0, 0, 0, 0, 0, 0, 0, X, },
											{ X, 0, 0, 0, 0, 0, 0, 0, C, X, },
											{ X, 0, 0, 0, 0, 0, 0, D, 0, X, },
											{ X, X, X, X, X, X, X, X, X, X, },
										},

								hint =  new char[]                  { 'L','U','R','U','L', },

								stars = new sbyte[DATA_STAR_SIZE]   { 5, 6 },
							},

			/* Puzzle 6 */	new Data() {

								size =  64,

								bound = new sbyte[,] {
											{ X, X, X, X, X, X, X, X, X, X, },
											{ X, 0, 0, 0, A, 0, 0, 0, B, X, },
											{ X, 0, 0, 0, 0, 0, 0, 0, C, X, },
											{ X, 0, 0, 0, 0, 0, 0, 0, 0, X, },
											{ X, X, 0, X, 0, 0, 0, 0, 0, X, },
											{ X, 0, 0, 0, 0, 0, 0, 0, X, X, },
											{ X, 0, X, 0, 0, 0, 0, 0, 0, X, },
											{ X, 0, 0, X, 0, 0, 0, D, 0, X, },
											{ X, 0, 0, 0, 0, 0, 0, 0, 0, X, },
											{ X, X, X, X, X, X, X, X, X, X, },
										},

								hint =  new char[]                  { 'U','L','D','R','U', },

								stars = new sbyte[DATA_STAR_SIZE]   { 5, 6 },
							},

			/* Puzzle 7 */	new Data() {

								size =  64,

								bound = new sbyte[,] {
											{ X, X, X, X, X, X, X, X, X, X, },
											{ X, 0, 0, 0, 0, A, B, C, D, X, },
											{ X, 0, 0, 0, 0, 0, 0, 0, 0, X, },
											{ X, 0, 0, 0, 0, 0, 0, 0, X, X, },
											{ X, 0, 0, 0, 0, 0, 0, 0, 0, X, },
											{ X, 0, 0, 0, 0, 0, 0, 0, 0, X, },
											{ X, 0, 0, 0, 0, 0, X, 0, X, X, },
											{ X, 0, 0, 0, 0, 0, 0, 0, 0, X, },
											{ X, 0, 0, 0, 0, 0, 0, 0, 0, X, },
											{ X, X, X, X, X, X, X, X, X, X, },
										},

								hint =  new char[]                  { 'D','L','U','R','U', },

								stars = new sbyte[DATA_STAR_SIZE]   { 5, 6 },
							},

			/* Puzzle 8 */	new Data() {

								size =  64,

								bound = new sbyte[,] {
											{ X, X, X, X, X, X, X, X, X, X, },
											{ X, X, X, 0, X, 0, 0, 0, 0, X, },
											{ X, X, 0, 0, 0, 0, 0, 0, X, X, },
											{ X, 0, 0, 0, 0, 0, 0, 0, X, X, },
											{ X, 0, 0, 0, 0, 0, 0, 0, X, X, },
											{ X, 0, X, 0, 0, 0, 0, 0, X, X, },
											{ X, X, 0, 0, 0, X, 0, 0, 0, X, },
											{ X, 0, 0, 0, X, X, 0, 0, 0, X, },
											{ X, A, B, C, D, 0, 0, 0, 0, X, },
											{ X, X, X, X, X, X, X, X, X, X, },
										},

								hint =  new char[]                  { 'U','R','D','L','D', },

								stars = new sbyte[DATA_STAR_SIZE]   { 5, 6 },
							},

			/* Puzzle 9 */	new Data() {

								size =  64,

								bound = new sbyte[,] {
											{ X, X, X, X, X, X, X, X, X, X, },
											{ X, X, X, X, X, X, X, X, X, X, },
											{ X, X, 0, 0, 0, 0, 0, 0, X, X, },
											{ X, X, 0, A, 0, 0, 0, 0, X, X, },
											{ X, X, 0, 0, 0, 0, 0, B, X, X, },
											{ X, X, 0, 0, X, 0, X, 0, X, X, },
											{ X, X, C, 0, D, 0, 0, 0, X, X, },
											{ X, X, 0, 0, 0, 0, 0, 0, X, X, },
                                            { X, X, X, X, X, X, X, X, X, X, },
											{ X, X, X, X, X, X, X, X, X, X, },
										},

								hint =  new char[]                  { 'D','R','U','L','U', },

								stars = new sbyte[DATA_STAR_SIZE]   { 5, 6 },
							},

			/* Puzzle 10 */	new Data() {

								size =  64,

								bound = new sbyte[,] {
											{ X, X, X, X, X, X, X, X, X, X, },
											{ X, X, 0, 0, 0, 0, 0, X, X, X, },
											{ X, X, X, X, 0, 0, 0, 0, X, X, },
											{ X, X, 0, 0, 0, 0, 0, 0, X, X, },
											{ X, X, 0, 0, 0, A, X, B, X, X, },
											{ X, X, 0, 0, 0, X, X, X, X, X, },
											{ X, X, 0, 0, 0, C, X, D, X, X, },
											{ X, X, 0, 0, 0, 0, 0, 0, X, X, },
											{ X, X, 0, 0, 0, 0, 0, X, X, X, },
											{ X, X, X, X, X, X, X, X, X, X, },
										},

								hint =  new char[]                  { 'L','U','L','D','L', },

								stars = new sbyte[DATA_STAR_SIZE]   { 5, 6 },
							},

			/* Puzzle 11 */	new Data() {

								size =  64,

								bound = new sbyte[,] {
											{ X, X, X, X, X, X, X, X, X, X, },
											{ X, 0, 0, 0, 0, 0, 0, 0, 0, X, },
											{ X, 0, 0, 0, 0, 0, 0, 0, 0, X, },
											{ X, 0, 0, 0, 0, 0, 0, 0, 0, X, },
											{ X, X, 0, A, X, B, 0, 0, 0, X, },
											{ X, 0, 0, X, X, X, 0, 0, 0, X, },
											{ X, 0, 0, C, X, D, 0, 0, 0, X, },
											{ X, 0, 0, 0, 0, 0, 0, 0, 0, X, },
											{ X, X, 0, 0, 0, 0, 0, 0, 0, X, },
											{ X, X, X, X, X, X, X, X, X, X, },
										},

								hint =  new char[]                  { 'R','D','L','D','R', },

								stars = new sbyte[DATA_STAR_SIZE]   { 5, 6 },
							},

			/* Puzzle 12 */	new Data() {

								size =  64,

								bound = new sbyte[,] {
											{ X, X, X, X, X, X, X, X, X, X, },
											{ X, 0, 0, 0, 0, 0, 0, 0, 0, X, },
											{ X, 0, A, 0, 0, 0, 0, 0, B, X, },
											{ X, 0, 0, 0, X, 0, 0, 0, 0, X, },
											{ X, 0, 0, C, 0, 0, 0, 0, 0, X, },
											{ X, 0, 0, 0, 0, 0, X, D, 0, X, },
											{ X, 0, 0, 0, 0, 0, 0, 0, 0, X, },
											{ X, 0, 0, 0, 0, 0, 0, 0, 0, X, },
											{ X, 0, 0, 0, 0, X, 0, 0, 0, X, },
											{ X, X, X, X, X, X, X, X, X, X, },
										},

								hint =  new char[]                  { 'R','U','L','D','L', },

								stars = new sbyte[DATA_STAR_SIZE]   { 5, 6 },
							},

			/* Puzzle 13 */	new Data() {

								size =  64,

								bound = new sbyte[,] {
											{ X, X, X, X, X, X, X, X, X, X, },
											{ X, 0, 0, 0, 0, 0, 0, A, 0, X, },
											{ X, 0, 0, 0, 0, 0, 0, 0, 0, X, },
											{ X, 0, 0, 0, 0, 0, X, B, 0, X, },
											{ X, 0, 0, 0, 0, 0, X, 0, 0, X, },
											{ X, 0, 0, 0, 0, 0, 0, X, 0, X, },
											{ X, 0, 0, 0, X, 0, 0, 0, 0, X, },
											{ X, 0, 0, 0, 0, 0, 0, 0, 0, X, },
											{ X, X, 0, C, X, X, 0, D, 0, X, },
											{ X, X, X, X, X, X, X, X, X, X, },
										},

								hint =  new char[]                  { 'U','L','D','L','U', },

								stars = new sbyte[DATA_STAR_SIZE]   { 5, 6 },
							},

			/* Puzzle 14 */	new Data() {

								size =  64,

								bound = new sbyte[,] {
											{ X, X, X, X, X, X, X, X, X, X, },
											{ X, 0, 0, 0, 0, 0, 0, 0, 0, X, },
											{ X, 0, X, A, X, 0, X, 0, 0, X, },
											{ X, 0, B, X, C, 0, 0, 0, 0, X, },
											{ X, 0, X, D, X, 0, 0, 0, 0, X, },
											{ X, X, 0, 0, 0, 0, 0, 0, 0, X, },
											{ X, 0, 0, 0, 0, 0, 0, 0, X, X, },
											{ X, 0, 0, 0, 0, 0, 0, 0, 0, X, },
											{ X, 0, 0, 0, 0, 0, 0, 0, 0, X, },
											{ X, X, X, X, X, X, X, X, X, X, },
										},

								hint =  new char[]                  { 'D','L','U','R','U', },

								stars = new sbyte[DATA_STAR_SIZE]   { 5, 6 },
							},



			/* Puzzle 16 */	new Data() {

								size =  64,

								bound = new sbyte[,] {
											{ X, X, X, X, X, X, X, X, X, X, },
											{ X, 0, 0, X, X, X, X, X, X, X, },
											{ X, 0, 0, X, X, X, X, X, X, X, },
											{ X, 0, 0, X, X, X, X, X, X, X, },
											{ X, 0, 0, 0, 0, 0, 0, 0, 0, X, },
											{ X, 0, 0, 0, 0, 0, 0, X, A, X, },
											{ X, 0, 0, X, X, X, 0, B, X, X, },
											{ X, 0, 0, 0, 0, 0, C, 0, 0, X, },
											{ X, 0, 0, 0, 0, D, 0, X, 0, X, },
											{ X, X, X, X, X, X, X, X, X, X, },
										},

								hint =  new char[]                  { 'D','R','U','L','U', },

								stars = new sbyte[DATA_STAR_SIZE]   { 5, 6 },
							},

			/* Puzzle 17 */	new Data() {

								size =  64,

								bound = new sbyte[,] {
											{ X, X, X, X, X, X, X, X, X, X, },
											{ X, 0, 0, 0, 0, 0, X, 0, 0, X, },
											{ X, 0, 0, 0, 0, 0, 0, 0, 0, X, },
											{ X, 0, 0, 0, 0, 0, X, 0, 0, X, },
											{ X, 0, 0, 0, 0, 0, 0, 0, 0, X, },
											{ X, 0, 0, 0, 0, X, 0, 0, A, X, },
											{ X, 0, 0, 0, 0, 0, 0, B, 0, X, },
											{ X, 0, 0, 0, 0, 0, C, 0, 0, X, },
											{ X, 0, 0, 0, 0, D, 0, 0, 0, X, },
											{ X, X, X, X, X, X, X, X, X, X, },
										},

								hint =  new char[]                  { 'R','U','L','D','L', },

								stars = new sbyte[DATA_STAR_SIZE]   { 5, 6 },
							},

			/* Puzzle 18 */	new Data() {

								size =  64,

								bound = new sbyte[,] {
											{ X, X, X, X, X, X, X, X, X, X, },
											{ X, A, 0, 0, 0, 0, X, 0, 0, X, },
											{ X, B, 0, 0, 0, 0, 0, 0, 0, X, },
											{ X, C, 0, 0, 0, 0, 0, 0, 0, X, },
											{ X, D, 0, 0, 0, 0, 0, 0, 0, X, },
											{ X, 0, 0, 0, 0, 0, 0, 0, 0, X, },
											{ X, 0, 0, 0, 0, 0, 0, 0, 0, X, },
											{ X, 0, 0, 0, 0, X, 0, 0, 0, X, },
											{ X, 0, 0, 0, 0, 0, 0, 0, 0, X, },
											{ X, X, X, X, X, X, X, X, X, X, },
										},

								hint =  new char[]                  { 'R','D','L','U','L', },

								stars = new sbyte[DATA_STAR_SIZE]   { 5, 6 },
							},

			/* Puzzle 19 */	new Data() {

								size =  64,

								bound = new sbyte[,] {
											{ X, X, X, X, X, X, X, X, X, X, },
											{ X, A, 0, 0, X, 0, 0, 0, X, X, },
											{ X, 0, 0, 0, 0, 0, B, 0, C, X, },
											{ X, X, X, 0, 0, 0, 0, 0, X, X, },
											{ X, D, 0, 0, 0, X, 0, 0, 0, X, },
											{ X, 0, 0, X, X, 0, 0, 0, 0, X, },
											{ X, 0, 0, 0, X, 0, 0, X, X, X, },
											{ X, 0, 0, 0, 0, 0, 0, X, X, X, },
											{ X, 0, 0, 0, 0, 0, 0, X, X, X, },
											{ X, X, X, X, X, X, X, X, X, X, },
										},

								hint =  new char[]                  { 'L','U','R','U','L', },

								stars = new sbyte[DATA_STAR_SIZE]   { 5, 6 },
							},

            /* Puzzle 20 */	new Data() {

								size =  64,

								bound = new sbyte[,] {
											{ X, X, X, X, X, X, X, X, X, X, },
											{ X, X, 0, 0, A, X, B, X, X, X, },
											{ X, X, 0, 0, 0, 0, 0, 0, X, X, },
											{ X, X, 0, X, 0, X, X, 0, 0, X, },
											{ X, X, 0, X, 0, X, X, 0, 0, X, },
											{ X, X, 0, X, 0, X, X, 0, 0, X, },
											{ X, 0, 0, X, 0, 0, 0, 0, 0, X, },
											{ X, 0, 0, 0, X, X, 0, C, 0, X, },
											{ X, 0, 0, 0, D, 0, 0, 0, X, X, },
											{ X, X, X, X, X, X, X, X, X, X, },
										},

								hint =  new char[]                  { 'U','L','D','L','D', },

								stars = new sbyte[DATA_STAR_SIZE]   { 5, 6 },
							},
		};
	}
}




