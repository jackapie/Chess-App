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
        public List<WhatWhere> GetLayout()
        {
            var layout = new List<WhatWhere>();

            layout.Add(AssignPosition("pawn", "a7"));
            layout.Add(AssignPosition("pawn", "b7"));
            layout.Add(AssignPosition("pawn", "c7"));
            layout.Add(AssignPosition("pawn", "d7"));
            layout.Add(AssignPosition("pawn", "e7"));
            layout.Add(AssignPosition("pawn", "f7"));
            layout.Add(AssignPosition("pawn", "g7"));
            layout.Add(AssignPosition("pawn", "h7"));
            layout.Add(AssignPosition("rook", "a8"));
            layout.Add(AssignPosition("rook", "h8"));
            layout.Add(AssignPosition("knight", "b8"));
            layout.Add(AssignPosition("knight", "g8"));
            layout.Add(AssignPosition("bishop", "c8"));
            layout.Add(AssignPosition("bishop", "f8"));
            layout.Add(AssignPosition("queen", "d8"));
            layout.Add(AssignPosition("king", "e8"));

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
