using ChessApp.Location;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessApp
{
    public class BlackStartingLayout : IStartingLayout
    {
        public List<Thing> GetLayout()
        {
            var layout = new List<Thing>();

            layout.Add(MakeThing("pawn", "a7"));
            layout.Add(MakeThing("pawn", "b7"));
            layout.Add(MakeThing("pawn", "c7"));
            layout.Add(MakeThing("pawn", "d7"));
            layout.Add(MakeThing("pawn", "e7"));
            layout.Add(MakeThing("pawn", "f7"));
            layout.Add(MakeThing("pawn", "g7"));
            layout.Add(MakeThing("pawn", "h7"));
            layout.Add(MakeThing("rook", "a8"));
            layout.Add(MakeThing("rook", "h8"));
            layout.Add(MakeThing("knight", "b8"));
            layout.Add(MakeThing("knight", "g8"));
            layout.Add(MakeThing("bishop", "c8"));
            layout.Add(MakeThing("bishop", "f8"));
            layout.Add(MakeThing("queen", "d8"));
            layout.Add(MakeThing("king", "e8"));

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
