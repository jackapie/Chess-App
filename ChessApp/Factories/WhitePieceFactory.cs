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
      

        public override Piece Create(string piece)
        {
            switch (piece)
            {
                case "pawn":
                    return new WhitePawn();
                case "queen":
                    return new WhiteQueen();
                case "king":
                    return new WhiteKing();
                case "knight":
                    return new WhiteKnight();
                case "bishop":
                    return new WhiteBishop();
                case "rook":
                    return new WhiteRook();
            }

            return null;
        }
    }
}
