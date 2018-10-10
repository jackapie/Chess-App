using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessApp.Players
{
    public abstract class Player
    {
        //There are two players; black and white
        //Players have a list of pieces 
        //Each piece starts in a particular position on the board

        protected abstract IStartingLayout StartingLayout { get; }

        protected abstract PieceFactory PieceFactory { get; }

        public void SetUpPieces(ChessBoard board)
        {
            var layout = StartingLayout.GetLayout();

            foreach (var whatWhere in layout)
            {
                board.AddPiece(PieceFactory.Create(whatWhere.PieceType), whatWhere.Location);
            }
        }



    }
}
