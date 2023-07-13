﻿using System;
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
            if (IsDiagonal(sRow, sCol, eRow, eCol) && IsDiagonalPathClear(sRow, sCol, eRow, eCol, Ps))
            {
                return true;
            }
            return false;
        }
    }
}
