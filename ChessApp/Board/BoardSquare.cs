using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessApp.Board
{
    public class BoardSquare
    {
        public Piece BoardSquareContent {get; protected set;}


        public void AddPiece(Piece piece)
        {
            BoardSquareContent = piece;
        }

        public void RemovePiece()
        {
            BoardSquareContent = null;
        }
    }
}
