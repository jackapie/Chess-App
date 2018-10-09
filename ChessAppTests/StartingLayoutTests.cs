using ChessApp;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChessAppTests
{
    [TestClass]
    public class StartingLayoutTests
    {
        [TestMethod]
        public void CreateWhiteStartingLayout()
        {
            var whiteStartingLayout = new WhiteStartingLayout();

            Assert.IsNotNull(whiteStartingLayout);
        }
        [TestMethod]
        public void CreateBlackStartingLayout()
        {
            var blackStartingLayout = new BlackStartingLayout();

            Assert.IsNotNull(blackStartingLayout);
        }

        [TestMethod]
        public void WhiteGetLayoutTest()
        {
            var whiteStartingLayout = new WhiteStartingLayout();
            var layout = whiteStartingLayout.GetLayout();

            Assert.AreEqual(16, layout.Count);
        }
        [TestMethod]
        public void BlackGetLayoutTest()
        {
            var blackStartingLayout = new BlackStartingLayout();
            var layout = blackStartingLayout.GetLayout();

            Assert.AreEqual(16, layout.Count);
        }


    }
}
