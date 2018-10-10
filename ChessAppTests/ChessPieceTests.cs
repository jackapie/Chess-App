using ChessApp;
using ChessApp.Location;
using ChessAppTests.Mocks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChessAppTests
{
    [TestClass]
    public class ChessPieceTests
    {
        [TestMethod]
        public void CreateWhitePawnTest()
        {
            var pieceFactory = new WhitePieceFactory();

            var whitePawn = pieceFactory.Create("pawn");
            Assert.IsNotNull(whitePawn);
        }

        [TestMethod]
        public void CreateWhiteKingTest()
        {
            var pieceFactory = new WhitePieceFactory();
            var whiteKing = pieceFactory.Create("king");
            Assert.IsNotNull(whiteKing);
        }

        [TestMethod]
        public void CreateWhiteQueenTest()
        {
            var pieceFactory = new WhitePieceFactory();
            var whiteQueen = pieceFactory.Create("queen");
            Assert.IsNotNull(whiteQueen);
        }

        [TestMethod]
        public void CreateWhiteKnightTest()
        {
            var pieceFactory = new WhitePieceFactory();
            var whiteKnight = pieceFactory.Create("knight");
            Assert.IsNotNull(whiteKnight);
        }

        [TestMethod]
        public void CreateWhiteBishopTest()
        {
            var pieceFactory = new WhitePieceFactory();
            var whiteBishop = pieceFactory.Create("bishop");
            Assert.IsNotNull(whiteBishop);
        }

        [TestMethod]
        public void CreateWhiteRookTest()
        {
            var pieceFactory = new WhitePieceFactory();
            var whiteRook = pieceFactory.Create("rook");
            Assert.IsNotNull(whiteRook);
        }

                
        [TestMethod]
        public void CreateBlackPawnTest()
        {
            var pieceFactory = new BlackPieceFactory();

            var blackPawn = pieceFactory.Create("pawn");
            Assert.IsNotNull(blackPawn);
        }

        [TestMethod]
        public void CreateBlackKingTest()
        {
            var pieceFactory = new BlackPieceFactory();
            var blackKing = pieceFactory.Create("king");
            Assert.IsNotNull(blackKing);
        }

        [TestMethod]
        public void CreateBlackQueenTest()
        {
            var pieceFactory = new BlackPieceFactory();
            var blackQueen = pieceFactory.Create("queen");
            Assert.IsNotNull(blackQueen);
        }

        [TestMethod]
        public void CreateBlackKnightTest()
        {
            var pieceFactory = new BlackPieceFactory();
            var blackKnight = pieceFactory.Create("knight");
            Assert.IsNotNull(blackKnight);
        }

        [TestMethod]
        public void CreateBlackBishopTest()
        {
            var pieceFactory = new BlackPieceFactory();
            var blackBishop = pieceFactory.Create("bishop");
            Assert.IsNotNull(blackBishop);
        }

        [TestMethod]
        public void CreateBlackRookTest()
        {
            var pieceFactory = new BlackPieceFactory();
            var blackRook = pieceFactory.Create("rook");
            Assert.IsNotNull(blackRook);
        }

        [TestMethod]
        public void KingValidMoveTest()
        {
            var chessBoard = new ChessBoard();

            var piece = new MockKing();

            ILocation startLocation = new MockLocation(3, 6);

            chessBoard.AddPiece(piece, startLocation);

            ILocation endLocation = new MockLocation(4, 5);

            chessBoard.MovePiece(startLocation, endLocation);

            var content = chessBoard.Board[endLocation.y][endLocation.x].BoardSquareContent;
            Assert.AreEqual(piece, content);
        }

 
    }
}
