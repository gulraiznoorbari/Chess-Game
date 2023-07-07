using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chess_Game
{
    public partial class Chess : Form
    {
        const int Dimension = 8;
        Piece[,] Pieces = new Piece[Dimension, Dimension];
        Cell[,] Cells = new Cell[Dimension, Dimension];


        public Chess()
        {
            InitializeComponent();
        }

        public void Init()
        {
            for(int row = 0; row < Dimension; row++)
            {
                for(int col = 0; col < Dimension; col++)
                {
                    if (row == 0 || row == 1)
                    {
                        Pieces[row, col] = new Pawn(MYCOLOR.BLACK, "B_Pawn"); 
                    }
                    if (row == 6 || row == 7)
                    {
                        Pieces[row, col] = new Pawn(MYCOLOR.WHITE, "W_Pawn");
                    }
                    else
                    {
                        Pieces[row, col] = null;
                    }
                    // ----------------------------------------------- //
                }
            }
        }

        private void PlayButton_Click(object sender, EventArgs e)
        {
            Init();
        }
    }
}
