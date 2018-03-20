using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Polymorphism
{
    class Set_Inheritance : List<long>
    {
        public new void Add(int x)
        {
            if (!this.Contains(x))
            {
                base.Add(x);
            }
        }

        public new void Add(long x)
        {
            if (!this.Contains(x))
            {
                base.Add(x);
            }
        }

        public long Sum()
        {
            long sum = 0;

            foreach (var i in this)
            {
                sum += i;
            }

            return sum;
        }
    }
}