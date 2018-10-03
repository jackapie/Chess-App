using ChessApp.Pieces;
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
            var blackPawn = new BlackPawn();
            return blackPawn;
        }
        public override Piece CreateKing()
        {
            var blackKing = new BlackKing();
            return blackKing;
        }
        public override Piece CreateQueen()
        {
            var blackQueen = new BlackQueen();
            return blackQueen;
        }
        public override Piece CreateKnight()
        {
            var blackKnight = new BlackKnight();
            return blackKnight;
        }
        public override Piece CreateBishop()
        {
            var blackBishop = new BlackBishop();
            return blackBishop;
        }
        public override Piece CreateRook()
        {
            var blackRook = new BlackRook();
            return blackRook;
        }
    }
}
