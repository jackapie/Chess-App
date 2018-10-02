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
        public void CreatePawnTest()
        {
            var pieceFactory = new PieceFactory();
            
            var pawn = pieceFactory.CreatePawn();
            Assert.IsNotNull(pawn);
        }

        [TestMethod]
        public void CreateKingTest()
        {
            var pieceFactory = new PieceFactory();
            var king = pieceFactory.CreateKing();
            Assert.IsNotNull(king);
        }

        [TestMethod]
        public void CreateQueenTest()
        {
            var pieceFactory = new PieceFactory();
            var queen = pieceFactory.CreateQueen();
            Assert.IsNotNull(queen);
        }

        [TestMethod]
        public void CreateKnightTest()
        {
            var pieceFactory = new PieceFactory();
            var knight = pieceFactory.CreateKnight();
            Assert.IsNotNull(knight);
        }

        [TestMethod]
        public void CreateBishopTest()
        {
            var pieceFactory = new PieceFactory();
            var bishop = pieceFactory.CreateBishop();
            Assert.IsNotNull(bishop);
        }

        [TestMethod]
        public void CreateRookTest()
        {
            var pieceFactory = new PieceFactory();
            var rook = pieceFactory.CreateRook();
            Assert.IsNotNull(rook);
        }

        [TestMethod]
        public void CreatePieceFactoryTest()
        {
            var pieceFactory = new PieceFactory();
            Assert.IsNotNull(pieceFactory);

        }
    }
}
