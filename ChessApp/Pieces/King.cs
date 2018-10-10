using ChessApp.Location;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessApp
{
    public abstract class King : Piece
    {
        public override bool ValidMove(ILocation startLocation, ILocation endLocation)
        {
            var endX = endLocation.x;
            var startX = startLocation.x;
            var endY = endLocation.y;
            var startY = startLocation.y;
                        
            if (endX == startX && endY == startY)
            {
                return false;
            }

            if (Valid(endX, startX)|| Valid(endY, startY))
            {
                return true;
            }
            return false;
        }

        bool Valid(int endValue,  int startValue)
        {
            if(endValue < 0|| endValue > 7)
            {
                return false;
            }

            if (endValue == startValue||endValue == startValue +1 || endValue == startValue - 1)
            {
                return true;
            }
            return false;
        }
    }
}
