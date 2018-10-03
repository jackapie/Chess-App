using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessApp
{
    public class WhitePieceFactory : PieceFactory
    {
        public override Piece CreatePawn()
        {
            var whitePawn = new Pawn();
            return whitePawn;
        }
        public override Piece CreateKing()
        {
            var whiteKing = new King();
            return whiteKing;
        }
        public override Piece CreateQueen()
        {
            var whiteQueen = new Queen();
            return whiteQueen;
        }
        public override Piece CreateKnight()
        {
            var whiteKnight = new Knight();
            return whiteKnight;
        }
        public override Piece CreateBishop()
        {
            var whiteBishop = new Bishop();
            return whiteBishop;
        }
        public override Piece CreateRook()
        {
            var whiteRook = new Rook();
            return whiteRook;
        }
    }
}
