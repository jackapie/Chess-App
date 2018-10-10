using ChessApp;
using ChessApp.Location;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChessAppTests.Mocks
{
    class MockStartingLayout : IStartingLayout
    {
        public List<WhatWhere> GetLayout()
        {
            var layout = new List<WhatWhere>();

            layout.Add(AssignPosition("mockPiece", "a7"));

            return layout;
        }

        WhatWhere AssignPosition(string pieceType, string location)
        {
            var assignment = new WhatWhere();
            assignment.PieceType = pieceType;
            ILocation chessLocation = new ChessLocation(location);
            assignment.Location = chessLocation;
            return assignment;
        }
    }
}
