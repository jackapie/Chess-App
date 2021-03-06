﻿using ChessApp.Location;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChessAppTests.Mocks
{
    class MockLocation : ILocation
    {
        public int x { get; protected set; }
        public int y { get; protected set; }

        public MockLocation(int y, int x)
        {
            this.x = x;
            this.y = y;
        }
    }
}
