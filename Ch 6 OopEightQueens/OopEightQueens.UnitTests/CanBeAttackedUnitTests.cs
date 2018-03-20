using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace OopEightQueens.UnitTests
{
    [TestClass]
    public class CanBeAttackedUnitTests
    {
        [TestMethod]
        public void OnTheBackslashDiaganol()
        {
            var lastQueen = GenerateBoard(new List<int> { 0, 1, 2 });

            Assert.IsTrue(lastQueen.CanBeAttacked(3,3));
        }

        [TestMethod]
        public void OnTheForwardslashDiaganol()
        {
            var lastQueen = GenerateBoard(new List<int> { 3, 2, 1 });

            Assert.IsTrue(lastQueen.CanBeAttacked(0, 3));
        }

        [TestMethod]
        public void OnTheSameRow()
        {
            var lastQueen = GenerateBoard(new List<int> { 0, 1, 2 });

            Assert.IsTrue(lastQueen.CanBeAttacked(1, 3));
        }

        [TestMethod]
        public void Safe_One()
        {
            var lastQueen = GenerateBoard(new List<int> { 2, 0, 3 });

            Assert.IsFalse(lastQueen.CanBeAttacked(1, 3));
        }

        [TestMethod]
        public void Safe_Two()
        {
            var lastQueen = GenerateBoard(new List<int> { 1, 3, 0 });

            Assert.IsFalse(lastQueen.CanBeAttacked(2, 3));
        }

        private Queen GenerateBoard(List<int> coords)
        {
            Queen lastQueen = null;

            for (int i = 0; i < coords.Count; i++)
            {
                lastQueen = new Queen(i, coords[i], lastQueen);
            } 
            
            return lastQueen;
        }
    }
}
