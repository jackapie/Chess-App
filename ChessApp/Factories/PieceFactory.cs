﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessApp
{
    public abstract class PieceFactory
    {
        public abstract Piece Create(string piece);
    }
}
