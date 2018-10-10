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
        public List<WhatWhere> GetLayout()
        {
            var layout = new List<WhatWhere>();

            layout.Add(AssignPosition("pawn", "a2"));
            layout.Add(AssignPosition("pawn", "b2"));
            layout.Add(AssignPosition("pawn", "c2"));
            layout.Add(AssignPosition("pawn", "d2"));
            layout.Add(AssignPosition("pawn", "e2"));
            layout.Add(AssignPosition("pawn", "f2"));
            layout.Add(AssignPosition("pawn", "g2"));
            layout.Add(AssignPosition("pawn", "h2"));
            layout.Add(AssignPosition("rook", "a1"));
            layout.Add(AssignPosition("rook", "h1"));
            layout.Add(AssignPosition("knight", "b1"));
            layout.Add(AssignPosition("knight", "g1"));
            layout.Add(AssignPosition("bishop", "c1"));
            layout.Add(AssignPosition("bishop", "f1"));
            layout.Add(AssignPosition("queen", "d1"));
            layout.Add(AssignPosition("king", "e1"));

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
