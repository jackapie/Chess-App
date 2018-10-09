using ChessApp;
using ChessApp.Players;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChessAppTests.Mocks
{
    class MockPlayer : Player
    {
        protected override IStartingLayout StartingLayout { get { return new MockStartingLayout(); } }

        protected override PieceFactory PieceFactory { get { return new MockPieceFactory(); } }
    }
}
