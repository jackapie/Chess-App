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
        
        public override Piece Create(string piece)
        {
            switch (piece)
            {
                case "pawn":
                    return new BlackPawn();
                case "queen":
                    return new BlackQueen();
                case "king":
                    return new BlackKing();
                case "knight":
                    return new BlackKnight();
                case "bishop":
                    return new BlackBishop();
                case "rook":
                    return new BlackRook();
            }

            return null;
        }
    }
}
