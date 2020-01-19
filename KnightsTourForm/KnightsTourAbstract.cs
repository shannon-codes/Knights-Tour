using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnightsTourForm
{
    abstract class KnightsTourAbstract
    {

        protected int row; //current row position of knight
        protected int col; //current col position of knight
        public abstract int Touch { get; set; } // counter for Touches (Moves)
        protected List<int> move0to7List = new List<int>(); 
        protected int[,] chessBoard = new int[8, 8]; //All default array values = 0
        protected Random rnd;
        public abstract void reset_Move0to7List(); // Store knight's move options in a list
        public abstract void startTrial(); //Begins the chosen simulation method

        //Method sets the knight's new row/col position
        //and sets touch number of the chess board
        public virtual void makeMove(int moveNum) {     
            if (moveNum == 0)
            {
                row -= 1;
                col += 2;
                Touch++;
                chessBoard[row, col] = Touch;
            }
            else if (moveNum == 1)
            {
                row -= 2;
                col += 1;
                Touch++;
                chessBoard[row, col] = Touch;
            }
            else if (moveNum == 2)
            {
                row -= 2;
                col -= 1;
                Touch++;
                chessBoard[row, col] = Touch;
            }
            else if (moveNum == 3)
            {
                row -= 1;
                col -= 2;
                Touch++;
                chessBoard[row, col] = Touch;
            }
            else if (moveNum == 4)
            {
                row += 1;
                col -= 2;
                Touch++;
                chessBoard[row, col] = Touch;
            }
            else if (moveNum == 5)
            {
                row += 2;
                col -= 1;
                Touch++;
                chessBoard[row, col] = Touch;
            }
            else if (moveNum == 6)
            {
                row += 2;
                col += 1;
                Touch++;
                chessBoard[row, col] = Touch;
            }
            else //moveNum==7
            {
                row += 1;
                col += 2;
                Touch++;
                chessBoard[row, col] = Touch;
            }
        }
        // Method to validate two conditions for a proposed knight's Move  
        //(1) Within bounds of chessboard 8x8 array
        //(2) Not already touched or been at there before (position is still default value == 0)
        public virtual bool validateMove(int row, int col)
        {
            if (row >= 0 && row <= 7 && col >= 0 && col <= 7 && chessBoard[row, col] == 0)
            {
                return true;
            }
            else { return false; }
        }

        // Getter Method so chessBoard having knights order of moves can be retrieved and printed in the Form1.cs
        public int[,] getChessBoard()
        {
            return chessBoard;
        }
    }
}
