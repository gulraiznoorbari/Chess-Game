using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chess_Game
{
    class Cell : Button
    {
        public int rowIndex, colIndex;
        MYCOLOR color;
        Piece piece;

        public Cell(int rIndex, int cIndex, MYCOLOR c, Piece p, int width, int height, int dimension)
        {
            rowIndex = rIndex;
            colIndex = cIndex;
            color = c;
            piece = p;
            this.Width = width / dimension - 9;
            this.Height = height / dimension - 9;
        }
    }
}
