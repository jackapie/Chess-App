using ChessApp.Location;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessApp
{
    abstract class Queen : Piece
    {
        public override bool ValidMove(ILocation startLocation, ILocation endLocation)
        {
            return false;
        }
    }
}
