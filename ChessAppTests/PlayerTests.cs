using ChessApp;
using ChessApp.Players;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ChessAppTests
{
    [TestClass]
    public class PlayerTests
    {
        [TestMethod]
        public void CreatePlayerTest()
        {
            var player = new Player();

            Assert.IsNotNull(player);
        }

        public void SetOfPiecesTest()
        {
            var setOfPieces = new SetOfPieces();
            Assert.IsNotNull(setOfPieces);
        }




    }
}
