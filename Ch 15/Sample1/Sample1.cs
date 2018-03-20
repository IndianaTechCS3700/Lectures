using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sample1
{
    /// <summary>
    /// The Parent Class
    /// </summary>
    class Parent
    {
        virtual public void Something() { }
    }

    /// <summary>
    /// The Child class
    /// </summary>
    class Child : Parent
    {
        override public void Something() { }
    }


    /// <summary>
    /// The Main program class
    /// </summary>
    class Sample1
    {
        /// <summary>
        /// Tests the specified p.
        /// </summary>
        /// <param name="p">The p.</param>
        static void Test(Parent p)
        {
            Console.WriteLine("Parent");
        }

        /// <summary>
        /// Tests the specified c.
        /// </summary>
        /// <param name="c">The c.</param>
        static void Test(Child c)
        {
            Console.WriteLine("Child");
        }

        /// <summary>
        /// Mains the specified args.
        /// </summary>
        /// <param name="args">The args.</param>
        static void Main(string[] args)
        {
            Parent p1 = new Parent();
            Test(p1);

            Child c1 = new Child();
            Test(c1);


            Parent p = new Child();

            /// Which method will get called?
            Test(p);

            p.Something();

            Console.WriteLine("Press Any Key to Continue");
            Console.ReadKey();
        }
    }
}
// Note that resolution is almost always performed at compile time,
// based on static types, and not dynamic values.
