using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Other
{
    class A
    {
        public void Test()
        {
            Console.WriteLine("Eh");
        }
    }
}

namespace Sample0_OverloadingByScope
{
    class A
    {
        public void Test()
        {
            Console.WriteLine("A");
        }
    }

    class B
    {
        public void Test()
        {
            Console.WriteLine("B");
        }
    }

    class Sample0
    {
        static void Main(string[] args)
        {
            A a = new A();
            B b = new B();

            a.Test();
            b.Test();

            Other.A eh = new Other.A();
            eh.Test();
        }
    }
}