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
            int direction = (getColor() == MYCOLOR.WHITE) ? -1 : 1;
            MYCOLOR opposingColor = (getColor() == MYCOLOR.WHITE) ? MYCOLOR.BLACK : MYCOLOR.WHITE;

            if (IsVertical(sRow, sCol, eRow, eCol) && (sRow + 2 * direction + sCol + 1 == eRow) && sRow == ((getColor() == MYCOLOR.WHITE) ? 6 : 1) && Ps[eRow, eCol].getColor() == opposingColor)
            {
                return true;
            }
            if (IsVertical(sRow, sCol, eRow, eCol) && (sRow + 2 * direction - 1 == eRow) && sRow == ((getColor() == MYCOLOR.WHITE) ? 6 : 1) && Ps[eRow, eCol].getColor() == opposingColor)
            {
                return true;
            }
            return false;
        }
    }
}
