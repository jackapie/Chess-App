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
            //Moves in diagonal straight line, so changeX must equal changeY
            BoardSquare move(int change)
            {
                return board[location.y + change][location.x + change];
            }

            var possibilities = new List<BoardSquare>();
            
            //Distance limited by size of board
            for (int i = 0; i <8 ; i++)
            {
                var counter = i + 1;
                possibilities.Add(move(counter));
                possibilities.Add(move(0 - counter));
            }

            return possibilities;
        }
    }
}
