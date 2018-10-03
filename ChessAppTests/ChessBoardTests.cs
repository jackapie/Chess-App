using ChessApp;
using Microsoft.VisualStudio.TestTools.UnitTesting;

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




    }
}
