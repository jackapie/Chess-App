using ChessApp;
using ChessApp.Board;
using ChessAppTests.Mocks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace ChessAppTests
{
    [TestClass]
    public class ChessBoardTests
    {
        [TestMethod]
        public void CreateChessBoardTest()
        {
            var chessBoard = new ChessBoard();

            Assert.IsNotNull(chessBoard);
        }

        [TestMethod]
        public void CreateBoardSquare()
        {
            var boardSquare = new BoardSquare();
            Assert.IsNotNull(boardSquare);
        }

        [TestMethod]
        public void CheckNumberBoardSquares()
        {
            var chessBoard = new ChessBoard();

            //All the following statements do the same in slightly different ways.
            //They check that the number of boardsquares in the board is equal to 64.
            //Note the use of lambda expressions
            Assert.AreEqual(64, chessBoard.Board.Sum(row => row.Count));
            Assert.AreEqual(64, chessBoard.Board.SelectMany(row => row).ToList().Count);
            Assert.AreEqual(64, chessBoard.Board.Select(row => row.Count).Sum());

        }

        [TestMethod]
        public void AddPieceToBoardSquareTest()
        {
            var boardSquare = new BoardSquare();
            var piece = new MockPiece();

            boardSquare.AddPiece(piece);

            Assert.AreEqual(piece, boardSquare.BoardSquareContent);
        }

        [TestMethod]
        public void RemovePieceFromBoardSquareTest()
        {
            var boardSquare = new BoardSquare();
            var piece = new MockPiece();

            boardSquare.AddPiece(piece);

            boardSquare.RemovePiece();

            Assert.AreEqual(null, boardSquare.BoardSquareContent);
        }



    }
}
