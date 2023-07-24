using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess_Game
{
    class Bishop : Piece
    {
        public Bishop(MYCOLOR c, string n) : base(c, n) { }

        public override bool isLegalMove(int sRow, int sCol, int eRow, int eCol, Piece[,] Ps)
        {
            MYCOLOR opposingColor = (getColor() == MYCOLOR.WHITE) ? MYCOLOR.BLACK : MYCOLOR.WHITE;

            // Check if the move is diagonal and the diagonal path is clear
            if (IsDiagonalPathClear(sRow, sCol, eRow, eCol, Ps))
            {
                // Check if the ending position contains an opposing color piece
                if (Ps[eRow, eCol] == null || Ps[eRow, eCol].getColor() == opposingColor)
                    return true;
            }
            return false;
        }
    }
}
