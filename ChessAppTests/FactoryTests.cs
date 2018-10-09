using ChessApp;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChessAppTests
{
    [TestClass]
    public class FactoryTests
    {
        [TestMethod]
        public void CreateBlackPieceFactoryTest()
        {
            var pieceFactory = new BlackPieceFactory();
            Assert.IsNotNull(pieceFactory);

        }
        [TestMethod]
        public void BlackFactoryNullTest()
        {
            var pieceFactory = new BlackPieceFactory();
            var nullPiece = pieceFactory.Create("noPiece");

            Assert.IsNull(nullPiece);

        }

        [TestMethod]
        public void CreateWhitePieceFactoryTest()
        {
            var pieceFactory = new WhitePieceFactory();
            Assert.IsNotNull(pieceFactory);

        }

        [TestMethod]
        public void WhiteFactoryNullTest()
        {
            var pieceFactory = new WhitePieceFactory();
            var nullPiece = pieceFactory.Create("noPiece");

            Assert.IsNull(nullPiece);

        }
    }
}
