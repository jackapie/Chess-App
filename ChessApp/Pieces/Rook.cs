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

            BoardSquare move(int changeX, int changeY)
            {
                return board[location.y + changeY][location.x + changeX];
            }

            var possibilities = new List<BoardSquare>();

            for (int i = 0; i < 8; i++)
            {
                var counter = i + 1;
                // moves must be in straight lines, but not diagonal
                //so either changeX or changeY must be zero
                possibilities.Add(move(counter, 0));
                possibilities.Add(move(0 - counter, 0));
                possibilities.Add(move(0, counter));
                possibilities.Add(move(0, 0 - counter));
            }

            return possibilities;
        }
    }
}
