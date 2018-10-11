using ChessApp.Board;
using ChessApp.Location;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessApp.Pieces
{
    class WhitePawn : Pawn
    {
       
        public override List<BoardSquare> ListPossibleMoves(ILocation location, List<List<BoardSquare>> board)
        {
            BoardSquare normalMove()
            {
                return board[location.y - 1][location.x];
            }

            var possibilities = new List<BoardSquare>();

            possibilities.Add(normalMove());

            return possibilities;
        }
    }
}
