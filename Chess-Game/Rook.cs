using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess_Game
{
    class Rook : Piece
    {
        public Rook(MYCOLOR c, string n) : base(c, n) { }

        public override bool isLegalMove(int sRow, int sCol, int eRow, int eCol, Piece[,] Ps)
        {
            if (IsVertical(sRow, sCol, eRow, eCol) && IsVerticalPathClear(sRow, sCol, eRow, eCol, Ps))
            {
                return true;
            }
            if (IsHorizontal(sRow, sCol, eRow, eCol) && IsHorizontalPathClear(sRow, sCol, eRow, eCol, Ps))
            {
                return true;
            }
            return false;
        }
    }
}
