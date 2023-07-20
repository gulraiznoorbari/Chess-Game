using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess_Game
{
    class Knight : Piece
    {
        public Knight(MYCOLOR c, string n) : base(c, n) { }

        public override bool isLegalMove(int sRow, int sCol, int eRow, int eCol, Piece[,] Ps)
        {
            MYCOLOR opposingColor = (getColor() == MYCOLOR.WHITE) ? MYCOLOR.BLACK : MYCOLOR.WHITE;

            if (isLShapedMove(sRow, sCol, eRow, eCol))
            {
                if (Ps[eRow, eCol] == null || Ps[eRow, eCol].getColor() == opposingColor)
                {
                    return true;
                }
            }
            return false;
        }

        public static bool isLShapedMove(int sRow, int sCol, int eRow, int eCol)
        {
            int RowDiff = Math.Abs(eRow - sRow);
            int ColDiff = Math.Abs(eCol - sCol);

            if ((RowDiff == 2 && ColDiff == 1) || (RowDiff == 1 && ColDiff == 2))
            {
                return true;
            }
            return false;
        }
    }
}
