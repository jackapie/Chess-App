using ChessApp.Board;
using ChessApp.Location;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessApp
{
    class Rook : Piece
    {
       
        public override List<BoardSquare> ListPossibleMoves(ILocation location, List<List<BoardSquare>> board)
        {
            return null;
        }
    }
}
