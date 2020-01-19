using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnightsTourForm
{
    class NonIntelligentMethod:KnightsTourAbstract
    {
        public override int Touch { get; set; } //Line 11: Property is counter for Touches (Moves)
        public NonIntelligentMethod(int x, int y, Random rnd)
        {
            row = x; //user selected start row and column
            col = y;
            Touch = 1; // Touch is "1" on the chess board 
            chessBoard[row, col] = Touch; //Touch 1 assigned to chessboard where the knight starts from
            this.rnd = rnd;
        }

        //Method initializes list with randomized/shuffled order of all moves from 0 to 7 without repeats
        public override void reset_Move0to7List()
        {
            move0to7List.Clear();
            while (move0to7List.Count < 8)
            {
                int temp = rnd.Next(8);
                if (!move0to7List.Contains(temp))
                {
                    move0to7List.Add(temp);
                }
            }
        }

        //Outer loop: Each new knight move which requires a reset randomized Move Option List
        //Inner loop: At current position of knight, checks moves options from random list 
        //one by one until it finds one that is validated true and therefore allowed
        public override void startTrial()
        {

            bool availableMove = true;
            bool chooseFrom_Move0to7List = true;

            int indx;

            while (availableMove)
            {
                reset_Move0to7List();
                indx = 0;
                chooseFrom_Move0to7List = true;

                while (chooseFrom_Move0to7List)
                {
                    if (move0to7List[indx] == 0)
                    {
                        if (validateMove(row - 1, col + 2))
                        {
                            makeMove(0);
                            chooseFrom_Move0to7List = false;
                        }
                        else { indx++; }
                    }
                    else if (move0to7List[indx] == 1)
                    {
                        if (validateMove(row - 2, col + 1))
                        {
                            makeMove(1);
                            chooseFrom_Move0to7List = false;
                        }
                        else { indx++; }
                    }
                    else if (move0to7List[indx] == 2)
                    {
                        if (validateMove(row - 2, col - 1))
                        {
                            makeMove(2);
                            chooseFrom_Move0to7List = false;
                        }
                        else { indx++; }
                    }
                    else if (move0to7List[indx] == 3)
                    {
                        if (validateMove(row - 1, col - 2))
                        {
                            makeMove(3);
                            chooseFrom_Move0to7List = false;
                        }
                        else { indx++; }
                    }
                    else if (move0to7List[indx] == 4)
                    {
                        if (validateMove(row + 1, col - 2))
                        {
                            makeMove(4);
                            chooseFrom_Move0to7List = false;
                        }
                        else { indx++; }
                    }
                    else if (move0to7List[indx] == 5)
                    {
                        if (validateMove(row + 2, col - 1))
                        {
                            makeMove(5);
                            chooseFrom_Move0to7List = false;
                        }
                        else { indx++; }
                    }
                    else if (move0to7List[indx] == 6)
                    {
                        if (validateMove(row + 2, col + 1))
                        {
                            makeMove(6);
                            chooseFrom_Move0to7List = false;
                        }
                        else { indx++; }
                    }
                    else if (move0to7List[indx] == 7)
                    {
                        if (validateMove(row + 1, col + 2))
                        {
                            makeMove(7);
                            chooseFrom_Move0to7List = false;
                        }
                        else { indx++; }
                    }

                    if (indx == 8) //Move0to7List Out of bounds, therefore, no more available moves
                    {
                        chooseFrom_Move0to7List = false;
                        availableMove = false;
                    }
                }

            }

        }
        public override void makeMove(int moveNum)
        {
            base.makeMove(moveNum);
        }

    }
}
