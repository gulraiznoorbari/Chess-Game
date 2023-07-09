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
            throw new NotImplementedException();
        }
    }
}
