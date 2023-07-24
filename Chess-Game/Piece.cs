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

        public abstract bool isLegalMove(int sRow, int sCol, int eRow, int eCol, Piece[,] Ps);

        public void Draw(Cell C)
        {
            C.Image = Image.FromFile("..\\..\\Resources\\" + PictureName);
        }

        public static bool IsVertical(int sRow, int sCol, int eRow, int eCol)
        {
            return sCol == eCol;
        }

        public bool IsVerticalPathClear(int sRow, int sCol, int eRow, int eCol, Piece[,] Ps)
        {
            MYCOLOR opposingColor = (getColor() == MYCOLOR.WHITE) ? MYCOLOR.BLACK : MYCOLOR.WHITE;
            if (!IsVertical(sRow, sCol, eRow, eCol))
                return false;

            int start = Math.Min(sRow, eRow);
            int end = Math.Max(sRow, eRow);

            // Check if there is any piece of the same color in the path
            for (int i = start + 1; i < end; i++)
            {
                if (Ps[i, sCol] != null)
                    return false;
            }

            // Check if the ending position contains an opposing color piece
            if (Ps[eRow, eCol] == null || Ps[eRow, eCol].getColor() == opposingColor)
                return true;

            return false;
        }

        public static bool IsHorizontal(int sRow, int sCol, int eRow, int eCol)
        {
            return sRow == eRow;
        }

        public bool IsHorizontalPathClear(int sRow, int sCol, int eRow, int eCol, Piece[,] Ps)
        {
            MYCOLOR opposingColor = (getColor() == MYCOLOR.WHITE) ? MYCOLOR.BLACK : MYCOLOR.WHITE;
            if (!IsHorizontal(sRow, sCol, eRow, eCol))
                return false;

            int start = Math.Min(sCol, eCol);
            int end = Math.Max(sCol, eCol);

            // Check if there is any piece of the same color in the path
            for (int i = start + 1; i < end; i++)
            {
                if (Ps[sRow, i] != null)
                    return false;
            }

            // Check if the ending position contains an opposing color piece
            if (Ps[eRow, eCol] == null || Ps[eRow, eCol].getColor() == opposingColor)
                return true;

            return false;
        }

        public static bool IsDiagonal(int sRow, int sCol, int eRow, int eCol)
        {
            return Math.Abs(sRow - eRow) ==  Math.Abs(sCol - eCol);
        }

        public bool IsDiagonalPathClear(int sRow, int sCol, int eRow, int eCol, Piece[,] Ps)
        {
            MYCOLOR opposingColor = (getColor() == MYCOLOR.WHITE) ? MYCOLOR.BLACK : MYCOLOR.WHITE;

            if (!IsDiagonal(sRow, sCol, eRow, eCol))
                return false;

            int rowDirection = (eRow > sRow) ? 1 : -1;
            int colDirection = (eCol > sCol) ? 1 : -1;

            int row = sRow + rowDirection;
            int col = sCol + colDirection;

            while (row != eRow && col != eCol)
            {
                if (Ps[row, col] != null)
                    return false;
                row += rowDirection;
                col += colDirection;
            }
            // Check if the ending position contains an opposing color piece
            if (Ps[eRow, eCol] == null || Ps[eRow, eCol].getColor() == opposingColor)
                return true;

            return false;
        }
    }
}
