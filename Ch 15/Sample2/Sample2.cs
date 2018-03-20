using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sample2
{
    /// <summary>
    /// Overloading based on signatures
    /// 
    /// A different type of overloading allows multiple implementations in the
    /// same scope to be resolved using type signatures.

    /// </summary>
    class Sample2
    {
        static void Overloaded(int x, float y)
        {
            Console.WriteLine("One");
        }

        static void Overloaded(float x, float y)
        {
            Console.WriteLine("Two");
        }

        static void Overloaded(int x, int y)
        {
            Console.WriteLine("Three");
        }

        static void Main(string[] args)
        {
            int myInt = 7;
            float myFloat = 8.0F;

            Overloaded((float)myInt, myFloat);

            Console.WriteLine("Press Any Key to Continue");
            Console.ReadKey();
        }
    }

    ///
    /// Note that resolution is almost always performed at compile time,
    /// based on static types, and not dynamic values.

}
