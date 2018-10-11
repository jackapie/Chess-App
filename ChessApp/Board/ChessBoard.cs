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

        List<BoardSquare> GetPossibleMoves(ILocation location, List<List<BoardSquare>> Board)
        {
            var piece = GetPiece(location);

            var possibleMoves = piece.ListPossibleMoves(location, Board);
            return possibleMoves;
        }

        bool IsPossibleMove(ILocation startLocation, ILocation endLocation)
        {
           if( GetPossibleMoves(startLocation, Board).Contains(Board[endLocation.y][endLocation.x]))
            {
                return true;
            }
            return false;
        }

        bool ValidSquare(ILocation location)
        {
            if (location.x >= 0 && location.x < 8
                && location.y >= 0 && location.y < 8)
            {
                return true;
            }
            return false;
        }
        public void MovePiece(ILocation startLocation, ILocation endLocation)
        {
            var piece = GetPiece(startLocation);
           
            if (ValidSquare(endLocation) && IsPossibleMove(startLocation, endLocation))
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
