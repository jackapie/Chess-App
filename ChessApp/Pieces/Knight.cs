using ChessApp.Board;
using ChessApp.Location;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessApp
{
    class Knight : Piece
    {
       
        public override List<BoardSquare> ListPossibleMoves(ILocation location, List<List<BoardSquare>> board)
        {
            BoardSquare move(int changeX, int changeY)
            {
                return board[location.y + changeY][location.x + changeX];
            }

            var possibilities = new List<BoardSquare>
            {
                move(1, -2),
                move(2, -1),
                move(2, 1),
                move(1, 2),
                move(-1, 2),
                move(-2, 1),
                move(-2, -1),
                move(-1, -2)
            };


            return possibilities;
        }
    }
}
