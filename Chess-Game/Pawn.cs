using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess_Game
{
    class Pawn : Piece
    {
        public Pawn(MYCOLOR c, string n) : base(c, n) { }

        public override bool isLegalMove(int sRow, int sCol, int eRow, int eCol, Piece[,] Ps)
        {
            int direction = (getColor() == MYCOLOR.WHITE) ? -1 : 1;
            MYCOLOR opposingColor = (getColor() == MYCOLOR.WHITE) ? MYCOLOR.BLACK : MYCOLOR.WHITE;

            // Move forward (one place)
            if (sCol == eCol && sRow + direction == eRow && Ps[eRow, eCol] == null)
            {
                return true;
            }
            // Move forward for the first time (two places)
            if (sCol == eCol && sRow + 2 * direction == eRow && sRow == ((getColor() == MYCOLOR.WHITE) ? 6 : 1)
                && Ps[sRow + direction, eCol] == null && Ps[eRow, eCol] == null)
            {
                return true;
            }
            // Capture an opponent's piece diagonally one square forward
            if (Math.Abs(eCol - sCol) == 1 && sRow + direction == eRow && Ps[eRow, eCol] != null && Ps[eRow, eCol].getColor() == opposingColor)
            {
                return true;
            }
            return false;
        }
    }
}
