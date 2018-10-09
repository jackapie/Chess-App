using ChessApp;
using ChessApp.Location;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChessAppTests.Mocks
{
    class MockStartingLayout : IStartingLayout
    {
        public List<Thing> GetLayout()
        {
            var layout = new List<Thing>();

            layout.Add(MakeThing("mockPiece", "a7"));

            return layout;
        }

        Thing MakeThing(string pieceType, string location)
        {
            var thing = new Thing();
            thing.PieceType = pieceType;
            ILocation chessLocation = new ChessLocation(location);
            thing.Location = chessLocation;
            return thing;
        }
    }
}
