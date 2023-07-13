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

        public static bool IsVerticalPathClear(int sRow, int sCol, int eRow, int eCol, Piece[,] Ps)
        {
            if (!IsVertical(sRow, sCol, eRow, eCol))
                return false;

            int start = Math.Min(sRow, sCol);
            int end = Math.Max(sRow, sCol);
            for (int i = start; i < end; i++)
            {
                if (Ps[i, sCol] != null)
                {
                    return false;
                }
            }
            return true;
        }

        public static bool IsHorizontal(int sRow, int sCol, int eRow, int eCol)
        {
            return sRow == eRow;
        }

        public static bool IsHorizontalPathClear(int sRow, int sCol, int eRow, int eCol, Piece[,] Ps)
        {
            if (!IsHorizontal(sRow, sCol, eRow, eCol))
                return false;

            int start = Math.Min(eRow, eCol);
            int end = Math.Max(eRow, eCol);
            for (int i = start; i < end; i++)
            {
                if (Ps[sRow, i] != null)
                    return false;
            }
            return true;
        }

        public static bool IsDiagonal(int sRow, int sCol, int eRow, int eCol)
        {
            return Math.Abs(sRow - eRow) ==  Math.Abs(sCol - eCol);
        }

        public static bool IsDiagonalPathClear(int sRow, int sCol, int eRow, int eCol, Piece[,] Ps)
        {
            if (!IsDiagonal(sRow, sCol, eRow, eCol))
                return false;

            int startRow = Math.Min(sRow, eRow);
            int endRow = Math.Max(sRow, eRow);
            int startCol = Math.Min(sCol, eCol);
            int endCol = Math.Max(sCol, eCol);

            int row = startRow;
            int col = startCol;

            while (row < endRow && col < endCol)
            {
                if (Ps[row, col] != null)
                    return false;
                row++;
                col++;
            }
            return true;
        }
    }
}
