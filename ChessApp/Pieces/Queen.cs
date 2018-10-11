using ChessApp.Board;
using ChessApp.Location;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessApp
{
    abstract class Queen : Piece
    {

        public override List<BoardSquare> ListPossibleMoves(ILocation location, List<List<BoardSquare>> board)
        {
            //Queens moves combine those ossible for rooks and those for bishops
            BoardSquare movePerpendicular(int changeX, int changeY)
            {
                return board[location.y + changeY][location.x + changeX];
            }

            var possibilities = new List<BoardSquare>();

            for (int i = 0; i < 8; i++)
            {
                var counter = i + 1;
              
                possibilities.Add(movePerpendicular(counter, 0));
                possibilities.Add(movePerpendicular(0 - counter, 0));
                possibilities.Add(movePerpendicular(0, counter));
                possibilities.Add(movePerpendicular(0, 0 - counter));
            }

            BoardSquare moveDiagonal(int change)
            {
                return board[location.y + change][location.x + change];
            }

            for (int j = 0; j < 8; j++)
            {
                var counter = j + 1;
                possibilities.Add(moveDiagonal(counter));
                possibilities.Add(moveDiagonal(0 - counter));
            }

            return possibilities;
        }
    }
}
