using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessApp
{
    public abstract class PieceFactory
    {
        public abstract Piece CreatePawn();

        public abstract Piece CreateKing();

        public abstract Piece CreateQueen();

        public abstract Piece CreateKnight();

        public abstract Piece CreateBishop();

        public abstract Piece CreateRook();
    }
}
