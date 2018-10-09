using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessApp.Players
{
    public class Player
    {
        //There are two players; black and white
        //Players have a list of pieces 
        //Each piece starts in a particular position on the board

        IStartingLayout StartingLayout;

        PieceFactory PieceFactory;

        public void SetUpPieces(ChessBoard board)
        {
            var layout = StartingLayout.GetLayout();

            foreach (var thing in layout)
            {
                board.AddPiece(PieceFactory.Create(thing.PieceType), thing.Location);
            }
        }

        public Player(string colour)
        {
            if (colour == "white")
            {
                StartingLayout = new WhiteStartingLayout();
                PieceFactory = new WhitePieceFactory();
            }
            if (colour == "black")
            {
                StartingLayout = new BlackStartingLayout();
                PieceFactory = new BlackPieceFactory();
            }

        }

    }
}
