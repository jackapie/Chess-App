using ChessApp;
using ChessApp.Board;
using ChessApp.Location;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChessAppTests.Mocks
{
    class MockPiece : Piece
    {
       

        public override List<BoardSquare> ListPossibleMoves(ILocation location, List<List<BoardSquare>> board)
        {
            BoardSquare position(int changeX, int changeY)
            {
                return board[location.y + changeY][location.x + changeX];
            }

            var possibilities = new List<BoardSquare>();

            possibilities.Add(position(1, 1));

            return possibilities;
        }
    }
}
