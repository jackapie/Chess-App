using ChessApp;
using ChessApp.Board;
using ChessApp.Location;
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

        [TestMethod]
        public void AddPieceToLocation()
        {
            var chessBoard = new ChessBoard();

            var piece = new MockPiece();

            ILocation location = new MockLocation(3,6);
           
            chessBoard.AddPiece(piece, location);

            var content = chessBoard.Board[location.y][location.x].BoardSquareContent;

            Assert.AreEqual(piece, content);
        }

        [TestMethod]
        public void GetChessLocationTest()
        {
            var chessBoard = new ChessBoard();
            ILocation chessLocation = new ChessLocation("a1");

            Assert.AreEqual(0, chessLocation.x);
            Assert.AreEqual(7, chessLocation.y);
        }

        [TestMethod]
        public void GetChessLocationTest2()
        {
            var chessBoard = new ChessBoard();
            ILocation chessLocation = new ChessLocation("h8");

            Assert.AreEqual(7, chessLocation.x);
            Assert.AreEqual(0, chessLocation.y);
        }

        [TestMethod]
        public void MovePieceTest()
        {
            //Setup board with MockPiece at a7/Board[1][0]
            var player = new MockPlayer();
            var board = new ChessBoard();
            player.SetUpPieces(board);
            //Move MockPiece to b6/Board[2][1] (y=2, x=1)

            ILocation startLocation = new MockLocation(1, 0);
            ILocation endLocation = new MockLocation(2, 1);

            board.MovePiece(startLocation, endLocation);

            Assert.IsNull(board.Board[1][0].BoardSquareContent);
            Assert.IsNotNull(board.Board[2][1].BoardSquareContent);
        }


    }
}
