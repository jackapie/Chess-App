using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessApp.Players
{
    class BlackPlayer : Player
    {
        protected override PieceFactory PieceFactory { get { return new BlackPieceFactory(); } }

        protected override IStartingLayout StartingLayout { get { return new BlackStartingLayout(); } }
    }
}
