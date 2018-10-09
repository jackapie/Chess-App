using ChessApp.Location;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessApp
{
    public class WhiteStartingLayout : IStartingLayout
    {
        public List<Thing> GetLayout()
        {
            var layout = new List<Thing>();

            layout.Add(MakeThing("pawn", "a2"));
            layout.Add(MakeThing("pawn", "b2"));
            layout.Add(MakeThing("pawn", "c2"));
            layout.Add(MakeThing("pawn", "d2"));
            layout.Add(MakeThing("pawn", "e2"));
            layout.Add(MakeThing("pawn", "f2"));
            layout.Add(MakeThing("pawn", "g2"));
            layout.Add(MakeThing("pawn", "h2"));
            layout.Add(MakeThing("rook", "a1"));
            layout.Add(MakeThing("rook", "h1"));
            layout.Add(MakeThing("knight", "b1"));
            layout.Add(MakeThing("knight", "g1"));
            layout.Add(MakeThing("bishop", "c1"));
            layout.Add(MakeThing("bishop", "f1"));
            layout.Add(MakeThing("queen", "d1"));
            layout.Add(MakeThing("king", "e1"));

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
