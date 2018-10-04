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

        [TestMethod]
        public void SetOfPiecesTest()
        {
            var setOfPieces = new SetOfPieces("white");
            Assert.IsNotNull(setOfPieces);
        }

        [TestMethod]
        public void ListOfWhitePiecesTest()
        {
            var setOfPieces = new SetOfPieces("white");
            Assert.AreEqual(16, setOfPieces.Pieces.Count);
            
        }

        [TestMethod]
        public void ListOfBlackPiecesTest()
        {
            var setOfPieces = new SetOfPieces("black");

            Assert.AreEqual(16, setOfPieces.Pieces.Count);
        }


    }
}
