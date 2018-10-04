using ChessApp;
using ChessApp.Board;
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


    }
}
