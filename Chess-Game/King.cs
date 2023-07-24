using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess_Game
{
    class King : Piece
    {
        public King(MYCOLOR c, string n) : base(c, n) { }

        public override bool isLegalMove(int sRow, int sCol, int eRow, int eCol, Piece[,] Ps)
        {
            MYCOLOR opposingColor = (getColor() == MYCOLOR.WHITE) ? MYCOLOR.BLACK : MYCOLOR.WHITE;

            if (Math.Abs(sRow - eRow) <= 1 && Math.Abs(sCol - eCol) <= 1)
            {
                if (Ps[eRow, eCol] == null || Ps[eRow, eCol].getColor() == opposingColor)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
