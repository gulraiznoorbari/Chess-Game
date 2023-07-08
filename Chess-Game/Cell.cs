using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
namespace Chess_Game
{
    class Cell : Button
    {
        public int rowIndex, colIndex;
        public MYCOLOR color;
        public Piece piece;

        public Cell(int rIndex, int cIndex, MYCOLOR c, Piece p, int width, int height, int dimension)
        {
            rowIndex = rIndex;
            colIndex = cIndex;
            color = c;
            piece = p;
            this.Width = width / dimension - 8;
            this.Height = height / dimension - 8;
            if (c == MYCOLOR.BLACK)
            {
                this.BackColor = Color.Gray;
            }
            if (piece != null)
            {
                piece.Draw(this);
            }
        }

        public void RemovePiece(Cell C)
        {
            C.Image = null;
        }
    }
}
