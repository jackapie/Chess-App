using ChessApp;
using ChessApp.Location;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChessAppTests.Mocks
{
    class MockPiece : Piece
    {
        public override bool ValidMove(ILocation startLocation, ILocation endLocation)
        {
            return true;
        }
    }
}
