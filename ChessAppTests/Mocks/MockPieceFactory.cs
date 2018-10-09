using ChessApp;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChessAppTests.Mocks
{
    class MockPieceFactory : PieceFactory
    {
        public override Piece Create(string piece)
        {

            return new MockPiece();
        }
    }
}

