using ChessApp;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ChessAppTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CreateChessBoardTest()
        {
            var chessBoard = new ChessBoard();

            Assert.IsNotNull(chessBoard);
        }

        [TestMethod]
        public void CreateWhitePawnTest()
        {
            var pieceFactory = new WhitePieceFactory();
            
            var whitePawn = pieceFactory.CreatePawn();
            Assert.IsNotNull(whitePawn);
        }

        [TestMethod]
        public void CreateWhiteKingTest()
        {
            var pieceFactory = new WhitePieceFactory();
            var whiteKing = pieceFactory.CreateKing();
            Assert.IsNotNull(whiteKing);
        }

        [TestMethod]
        public void CreateWhiteQueenTest()
        {
            var pieceFactory = new WhitePieceFactory();
            var whiteQueen = pieceFactory.CreateQueen();
            Assert.IsNotNull(whiteQueen);
        }

        [TestMethod]
        public void CreateWhiteKnightTest()
        {
            var pieceFactory = new WhitePieceFactory();
            var whiteKnight = pieceFactory.CreateKnight();
            Assert.IsNotNull(whiteKnight);
        }

        [TestMethod]
        public void CreateWhiteBishopTest()
        {
            var pieceFactory = new WhitePieceFactory();
            var whiteBishop = pieceFactory.CreateBishop();
            Assert.IsNotNull(whiteBishop);
        }

        [TestMethod]
        public void CreateWhiteRookTest()
        {
            var pieceFactory = new WhitePieceFactory();
            var whiteRook = pieceFactory.CreateRook();
            Assert.IsNotNull(whiteRook);
        }

        [TestMethod]
        public void CreateWhitePieceFactoryTest()
        {
            var pieceFactory = new WhitePieceFactory();
            Assert.IsNotNull(pieceFactory);

        }


        [TestMethod]
        public void CreateBlackPawnTest()
        {
            var pieceFactory = new BlackPieceFactory();

            var blackPawn = pieceFactory.CreatePawn();
            Assert.IsNotNull(blackPawn);
        }

        [TestMethod]
        public void CreateBlackKingTest()
        {
            var pieceFactory = new BlackPieceFactory();
            var blackKing = pieceFactory.CreateKing();
            Assert.IsNotNull(blackKing);
        }

        [TestMethod]
        public void CreateBlackQueenTest()
        {
            var pieceFactory = new BlackPieceFactory();
            var blackQueen = pieceFactory.CreateQueen();
            Assert.IsNotNull(blackQueen);
        }

        [TestMethod]
        public void CreateBlackKnightTest()
        {
            var pieceFactory = new BlackPieceFactory();
            var blackKnight = pieceFactory.CreateKnight();
            Assert.IsNotNull(blackKnight);
        }

        [TestMethod]
        public void CreateBlackBishopTest()
        {
            var pieceFactory = new BlackPieceFactory();
            var blackBishop = pieceFactory.CreateBishop();
            Assert.IsNotNull(blackBishop);
        }

        [TestMethod]
        public void CreateBlackRookTest()
        {
            var pieceFactory = new BlackPieceFactory();
            var blackRook = pieceFactory.CreateRook();
            Assert.IsNotNull(blackRook);
        }

        [TestMethod]
        public void CreateBlackPieceFactoryTest()
        {
            var pieceFactory = new BlackPieceFactory();
            Assert.IsNotNull(pieceFactory);

        }
    }
}
