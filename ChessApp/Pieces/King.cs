using ChessApp.Board;
using ChessApp.Location;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessApp
{
    public abstract class King : Piece
    {
       

        public override List<BoardSquare> ListPossibleMoves(ILocation location, List<List<BoardSquare>> board)
        {

            BoardSquare move(int changeX, int changeY)
            {
                return board[location.y + changeY][location.x + changeX];
            }

            var possibilities = new List<BoardSquare>
            {
                move(1, 0),
                move(1, 1),
                move(1, -1),
                move(0, 1),
                move(0, -1),
                move(-1, 0),
                move(-1, 1),
                move(-1, -1)
            };


            return possibilities;
        }
    }
}
