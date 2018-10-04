using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessApp.Players
{
    public class SetOfPieces
    {
        public Piece Piece { get; set; }
        public List<Piece> Pieces { get; set; }

        public SetOfPieces(string colour)
        {
            if (colour == "white")
            {
                var pieceFactory = new WhitePieceFactory();
                CreatePieces(pieceFactory);

            }

            if (colour == "black")
            {
                var pieceFactory = new BlackPieceFactory();
                CreatePieces(pieceFactory);
            }
        }

        private List<Piece> CreatePieces(PieceFactory pieceFactory)
        {
            Pieces = new List<Piece>();
            for (int i = 0; i < 8; i++)
            {
                var pawn = pieceFactory.CreatePawn();
                Pieces.Add(pawn);
            }
            for (int j = 0; j < 2; j++)
            {
                var bishop = pieceFactory.CreateBishop();
                var knight = pieceFactory.CreateKnight();
                var rook = pieceFactory.CreateRook();
                Pieces.Add(bishop);
                Pieces.Add(knight);
                Pieces.Add(rook);
            }
            var queen = pieceFactory.CreateQueen();
            var king = pieceFactory.CreateKing();
            Pieces.Add(queen);
            Pieces.Add(king);
            return Pieces;
        }
    }
}
