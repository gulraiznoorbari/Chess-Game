using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess_Game
{
    class Queen : Piece
    {
        public Queen(MYCOLOR c, string n) : base(c, n) { }

        public override bool isLegalMove(int sRow, int sCol, int eRow, int eCol, Piece[,] Ps)
        {
            if (IsVerticalPathClear(sRow, sCol, eRow, eCol, Ps))
            {
                return true;
            }
            if (IsHorizontalPathClear(sRow, sCol, eRow, eCol, Ps))
            {
                return true;
            }
            if (IsDiagonalPathClear(sRow, sCol, eRow, eCol, Ps))
            {
                return true;
            }
            return false;
        }
    }
}
