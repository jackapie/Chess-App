using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessApp
{
    public class PieceFactory
    {
        public Piece CreatePawn()
        {
            var pawn = new Pawn();
            return pawn;
        }
        public Piece CreateKing()
        {
            var king = new King();
            return king;
        }
        public Piece CreateQueen()
        {
            var queen = new Queen();
            return queen;
        }
        public Piece CreateKnight()
        {
            var knight = new Knight();
            return knight;
        }
        public Piece CreateBishop()
        {
            var bishop = new Bishop();
            return bishop;
        }
        public Piece CreateRook()
        {
            var rook = new Rook();
            return rook;
        }
    }
}
