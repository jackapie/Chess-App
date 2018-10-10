using ChessApp.Board;
using ChessApp.Location;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessApp
{
    public class ChessBoard
    {
        public List<List<BoardSquare>> Board { get; set; }

        public ChessBoard()
        {
            Board = new List<List<BoardSquare>>();
            for (int i = 0; i < 8; i++)
            {
                var row = new List<BoardSquare>();

                for (int j = 0; j < 8; j++)
                {
                    var square = new BoardSquare();
                    row.Add(square);
                }
                Board.Add(row);
            }
        }

        public void AddPiece(Piece piece, ILocation location)
        {
            Board[location.y][location.x].AddPiece(piece);
        }

        public void RemovePiece(ILocation location)
        {
            
            Board[location.y][location.x].RemovePiece();
        }

        public Piece GetPiece(ILocation location)
        {
            return Board[location.y][location.x].BoardSquareContent;
        }

        public void MovePiece(ILocation startLocation, ILocation endLocation)
        {
            var piece = GetPiece(startLocation);
            if (piece.ValidMove(startLocation, endLocation))
            {
                RemovePiece(startLocation);
                AddPiece(piece, endLocation);
            }
            else
            { //some error message
            }
        }
    }
}
