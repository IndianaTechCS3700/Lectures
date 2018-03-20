using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace OopEightQueens.UnitTests
{
    [TestClass]
    public class QueenTests
    {
        [TestMethod]
        public void WhenTheBoardSizeIsFive_ThereShouldBeAtLeastOneSolution()
        {
            ChessBoard.Size = 5;

            Queen lastQueen = null;

            for (int i = 0; i < ChessBoard.Size; i++)
            {
                lastQueen = new Queen(i, lastQueen);
            }


            var result = lastQueen.FindSolution();

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void WhenTheBoardSizeIsEight_ThereShouldBeAtLeastOneSolution()
        {
            ChessBoard.Size = 8;

            Queen lastQueen = null;

            for (int i = 0; i < ChessBoard.Size; i++)
            {
                lastQueen = new Queen(i, lastQueen);
            }


            var result = lastQueen.FindSolution();

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void WhenTheBoardSizeIsThree_ThereShouldNotBeASolution()
        {
            ChessBoard.Size = 3;

            Queen lastQueen = null;

            for (int i = 0; i < ChessBoard.Size; i++)
            {
                lastQueen = new Queen(i, lastQueen);
            }


            var result = lastQueen.FindSolution();

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void WhenTheBoardSizeIsTwo_ThereShouldNotBeASolution()
        {
            ChessBoard.Size = 2;

            Queen lastQueen = null;

            for (int i = 0; i < ChessBoard.Size; i++)
            {
                lastQueen = new Queen(i, lastQueen);
            }


            var result = lastQueen.FindSolution();

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void WhenTheBoardSizeIsFive_ThereShouldBeAtLeastThreeSolutions()
        {
            ChessBoard.Size = 5;

            Queen lastQueen = null;

            for (int i = 0; i < ChessBoard.Size; i++)
            {
                lastQueen = new Queen(i, lastQueen);
            }

            int count = 0;

            while (lastQueen.FindSolution())
            {
                count++;
                lastQueen.Advance();
            }


            Assert.IsTrue(count >= 3);
        }
    }
}
