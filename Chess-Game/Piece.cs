using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess_Game
{
    enum MYCOLOR { WHITE, BLACK };

    abstract class Piece
    {
        MYCOLOR Color;
        string PictureName;

        public Piece(MYCOLOR c, string n)
        {
            this.Color = c;
            this.PictureName = n;
        }

        public MYCOLOR getColor()
        {
            return this.Color;
        }

        public abstract bool isLegalMove(int sRow, int sCol, int eRow, int eCol, Piece[][] Ps);

        public void Draw(Cell C)
        {
            C.Image = Image.FromFile("..\\..\\Resources\\" + PictureName);
        }

        public static bool isVertical(int sRow, int sCol, int eRow, int eCol)
        {
            return sCol == eCol;
        }

        public static bool isHorizontal(int sRow, int sCol, int eRow, int eCol)
        {
            return sRow == eRow;
        }

        public static bool isDiagonal(int sRow, int sCol, int eRow, int eCol)
        {
            return Math.Abs(sRow - eRow) ==  Math.Abs(sCol - eCol);
        }
    }
}
