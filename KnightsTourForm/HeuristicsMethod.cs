using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnightsTourForm
{
    class HeuristicsMethod:KnightsTourAbstract
    {
        public override int Touch { get; set; }

        private int[,] accessNumbersBoard = new int[8, 8] { //Store Heuristics Accessibility Numbers 
                { 2, 3, 4, 4, 4, 4, 3, 2 },
                { 3, 4, 6, 6, 6, 6, 4, 3 },
                { 4, 6, 8, 8, 8, 8, 6, 4 },
                { 4, 6, 8, 8, 8, 8, 6, 4 },
                { 4, 6, 8, 8, 8, 8, 6, 4 },
                { 4, 6, 8, 8, 8, 8, 6, 4 },
                { 3, 4, 6, 6, 6, 6, 4, 3 },
                { 2, 3, 4, 4, 4, 4, 3, 2 } };

        private List<int> accessNumList = new List<int>();
        public HeuristicsMethod(int x, int y, Random rnd)
        {
            row = x;
            col = y;
            Touch = 1;
            chessBoard[row, col] = Touch;
            this.rnd = rnd;
        }

        // Method to Initialize/Populate 2 Lists 
        // (1) "move0to7List": Validated each possible move and stores it 
        // (2) "accessNumList": For each Validated possible move, store it's corresponding Accessibility Number 
        public override void reset_Move0to7List()
        {
            move0to7List.Clear();
            accessNumList.Clear();

            if (validateMove(row - 1, col + 2))
            {
                move0to7List.Add(0);
                accessNumList.Add(accessNumbersBoard[row - 1, col + 2]);
            }
            if (validateMove(row - 2, col + 1))
            {
                move0to7List.Add(1);
                accessNumList.Add(accessNumbersBoard[row - 2, col + 1]);
            }

            if (validateMove(row - 2, col - 1))
            {
                move0to7List.Add(2);
                accessNumList.Add(accessNumbersBoard[row - 2, col - 1]);
            }
            if (validateMove(row - 1, col - 2))
            {
                move0to7List.Add(3);
                accessNumList.Add(accessNumbersBoard[row - 1, col - 2]);
            }
            if (validateMove(row + 1, col - 2))
            {
                move0to7List.Add(4);
                accessNumList.Add(accessNumbersBoard[row + 1, col - 2]);
            }
            if (validateMove(row + 2, col - 1))
            {
                move0to7List.Add(5);
                accessNumList.Add(accessNumbersBoard[row + 2, col - 1]);
            }
            if (validateMove(row + 2, col + 1))
            {
                move0to7List.Add(6);
                accessNumList.Add(accessNumbersBoard[row + 2, col + 1]);
            }
            if (validateMove(row + 1, col + 2))
            {
                move0to7List.Add(7);
                accessNumList.Add(accessNumbersBoard[row + 1, col + 2]);
            }
        }

        //Method startTrial()
        //Outer loop: For each new move, it resets the Move0to7List and corresponding accessNumList
        //Inner Loop: Finds index of minimum accessibility number, which is corresponding move number 
                    // at the same index in Move0to7List
        public override void startTrial()
        {
            bool availableMove = true;

            while (availableMove)
            {
                reset_Move0to7List();
              
                if (accessNumList.Count > 1)
                {
                    int min_indx = 0;
                    for (int i = 1; i < accessNumList.Count; i++)
                    {
                        if (accessNumList[i] < accessNumList[min_indx])
                        {
                            min_indx = i;
                        }
                        else if (accessNumList[i] == accessNumList[min_indx])
                        {
                            if (rnd.Next(2) == 0)
                            {
                                min_indx = i;
                            }
                        }
                    }

                    makeMove(move0to7List[min_indx]);
                }
                else if (accessNumList.Count == 1)
                {
                    makeMove(move0to7List[0]);
                }
                else // accessNumList.Count==0 Therefore, no more allowable moves exist
                {
                    availableMove = false;
                }
            }
        }
    }
}
