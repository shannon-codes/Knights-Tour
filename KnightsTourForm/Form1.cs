using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace KnightsTourForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbMethod.SelectedIndex = 0;
            tbRow.Text = "0";
            tbColumn.Text = "0";
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            rtbOrder.Clear(); //clear rich text box

            string method;
            int row, col, numOfTrials;
            
            try
            {
                method = cmbMethod.SelectedItem.ToString();
                row = Convert.ToInt32(tbRow.Text);
                col = Convert.ToInt32(tbColumn.Text);
                numOfTrials = Convert.ToInt32(tbNumTrials.Text);

                if ((tbRow.Text == "") || (tbColumn.Text == "") || (tbNumTrials.Text == ""))
                {
                    MessageBox.Show("No empty boxes", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (!(row >= 0 && row <= 7 && col >= 0 && col <= 7 && numOfTrials>0))
                {
                    MessageBox.Show("Row and Column values must be between 0 and 7\n" +
                        "Number of Trials must be greater than 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    Random rnd = new Random(); //Create the Random object seed only once for entire Program
                    String output = null;

                    if (method == "Non-Intelligent") /***************method=="Non-Intelligent Method"*************/
                    {
                        
                        if (numOfTrials==1)
                        {
                            NonIntelligentMethod n1 = new NonIntelligentMethod(row, col, rnd);
                            n1.startTrial();
                            int[,] chessBoard = n1.getChessBoard();
                            displayOrderOfMoves(chessBoard);
                            output += "Trial 1 : The knight was able to successfully touch " + n1.Touch + " squares.\n";

                        }
                        else
                        {
                            for (int trial = 1; trial < numOfTrials + 1; trial++)
                            {
                                NonIntelligentMethod n1 = new NonIntelligentMethod(row, col, rnd);
                                n1.startTrial();
                                output += "Trial " + trial + " : The knight was able to successfully touch " + n1.Touch + " squares.\n";
                            }
                        }
                        
                        rtbOutcomes.Text=output;

                        using (StreamWriter writer = new StreamWriter("ShannonNonIntelligentMethod.txt"))
                        {
                            writer.WriteLine(output);
                        }
                    }
                    else /***************method=="HeuristicsMethod"***********************/
                    {
                        if (numOfTrials == 1)
                        {
                            HeuristicsMethod h1 = new HeuristicsMethod(row, col, rnd);
                            h1.startTrial();
                            int[,] chessBoard = h1.getChessBoard();
                            displayOrderOfMoves(chessBoard);
                            output += "Trial 1 : The knight was able to successfully touch " + h1.Touch + " squares.\n";
                        }
                        else
                        {
                            for (int trial = 1; trial < numOfTrials + 1; trial++)
                            {
                                HeuristicsMethod h1 = new HeuristicsMethod(row, col, rnd);
                                h1.startTrial();
                                output += "Trial " + trial + " : The knight was able to successfully touch " + h1.Touch + " squares.\n";
                            }
                        }

                        rtbOutcomes.Text = output;

                        using (StreamWriter writer = new StreamWriter("ShannonHeuristicsMethod.txt"))
                        {
                            writer.WriteLine(output);
                        }
                    }

                }
            }
            catch (FormatException ex)
            {
                string msg = ex.Message.ToString();
                string caption = "Enter Integer Value Only";
                MessageBox.Show(msg, caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }
           
        public void displayOrderOfMoves(int [,] chessBoard)
        {
            int i, j;
            for (i = 0; i < chessBoard.GetLength(0); i++)
            {
                for (j = 0; j < chessBoard.GetLength(1); j++)
                {
                    rtbOrder.AppendText(string.Format("{0,4}", chessBoard[i, j]));
                }
                rtbOrder.AppendText("\n");
            }
        }
    }
}
