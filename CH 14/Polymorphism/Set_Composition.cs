using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Polymorphism
{
    internal class Set_Composition
    {
        private List<long> theData = new List<long>();

        public Set_Composition() { }

        public int Size()
        {
            return theData.Count;
        }

        public bool Contains(int x)
        {
            return theData.Contains(x);
        }

        public int Count()
        {
            return theData.Count();
        }


        public void Add(int x)
        {
            if (!theData.Contains(x))
            {
                theData.Add(x);
            }
        }

        public void Add(long x)
        {
            if (!theData.Contains(x))
            {
                theData.Add(x);
            }
        }

        public long Sum()
        {
            long sum = 0;

            foreach (long i in theData)
            {
                sum += i;
            }

            return sum;
        }
    }
}