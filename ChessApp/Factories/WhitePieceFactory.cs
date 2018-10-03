using ChessApp.Pieces;
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
            var whitePawn = new WhitePawn();
            return whitePawn;
        }
        public override Piece CreateKing()
        {
            var whiteKing = new WhiteKing();
            return whiteKing;
        }
        public override Piece CreateQueen()
        {
            var whiteQueen = new WhiteQueen();
            return whiteQueen;
        }
        public override Piece CreateKnight()
        {
            var whiteKnight = new WhiteKnight();
            return whiteKnight;
        }
        public override Piece CreateBishop()
        {
            var whiteBishop = new WhiteBishop();
            return whiteBishop;
        }
        public override Piece CreateRook()
        {
            var whiteRook = new WhiteRook();
            return whiteRook;
        }
    }
}
