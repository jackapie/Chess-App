﻿using ChessApp.Board;
using ChessApp.Location;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessApp
{
    public abstract class Piece
    {
        //Each piece should have:
        //A position on the board
        //Permissable moves

        

        public abstract List<BoardSquare> ListPossibleMoves(ILocation location, List<List<BoardSquare>> board);
    }
}
