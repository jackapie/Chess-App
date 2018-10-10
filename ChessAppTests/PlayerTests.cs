using ChessApp;
using ChessApp.Location;
using ChessApp.Players;
using ChessAppTests.Mocks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ChessAppTests
{
    [TestClass]
    public class PlayerTests
    {
        [TestMethod]
        public void CreatePlayerTest()
        {
            var player = new MockPlayer();

            Assert.IsNotNull(player);
        }

        [TestMethod]
        public void SetUpPiecesTest()
        {
            var player = new MockPlayer();
            var board = new ChessBoard();
            player.SetUpPieces(board);
            //Should be a MockPiece at a7, ie y=1 and x=0
            Assert.IsNotNull(board.Board[1][0].BoardSquareContent);
        }

        



    }
}
