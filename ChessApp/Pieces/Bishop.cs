using ChessApp.Board;
using ChessApp.Location;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessApp
{
    class Bishop : Piece
    {
       
        public override List<BoardSquare> ListPossibleMoves(ILocation location, List<List<BoardSquare>> board)
        {
            BoardSquare position(int change)
            {
                return board[location.y + change][location.x + change];
            }

            var possibilities = new List<BoardSquare>();

            for (int i = 0; i <8 ; i++)
            {
                var counter = i + 1;
                possibilities.Add(position(counter));
                possibilities.Add(position(0 - counter));
            }

            return possibilities;
        }
    }
}
