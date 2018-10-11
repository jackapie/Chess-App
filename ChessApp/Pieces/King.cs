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

            BoardSquare position(int changeX, int changeY)
            {
                return board[location.y + changeY][location.x + changeX];
            }

            var possibilities = new List<BoardSquare>();

            possibilities.Add(position(1, 0));
            possibilities.Add(position(1, 1));
            possibilities.Add(position(1, -1));
            possibilities.Add(position(0, 1));
            possibilities.Add(position(0, -1));
            possibilities.Add(position(-1, 0));
            possibilities.Add(position(-1, 1));
            possibilities.Add(position(-1, -1));


            return possibilities;
        }
    }
}
