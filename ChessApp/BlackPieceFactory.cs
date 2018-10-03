using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessApp
{
    public class BlackPieceFactory : PieceFactory
    {
        public override Piece CreatePawn()
        {
            var blackPawn = new Pawn();
            return blackPawn;
        }
        public override Piece CreateKing()
        {
            var blackKing = new King();
            return blackKing;
        }
        public override Piece CreateQueen()
        {
            var blackQueen = new Queen();
            return blackQueen;
        }
        public override Piece CreateKnight()
        {
            var blackKnight = new Knight();
            return blackKnight;
        }
        public override Piece CreateBishop()
        {
            var blackBishop = new Bishop();
            return blackBishop;
        }
        public override Piece CreateRook()
        {
            var blackRook = new Rook();
            return blackRook;
        }
    }
}
