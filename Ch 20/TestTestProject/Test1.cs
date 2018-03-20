using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestTestProject
{
    [TestClass]
    public class Test1
    {
        [TestMethod]
        public void TestMethod1()
        {
            List<int> myList = new List<int>();

            myList.Add(3);
            myList.Add(4);
            myList.Add(5);

            Assert.AreEqual(3, myList.Count);

            myList.Sort();
            Assert.AreEqual(3, myList.First());
        }
    }
}
