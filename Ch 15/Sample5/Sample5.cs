using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sample5
{
    class Sample5
    {
        static void Example(int w, int x, int y = 0, int z = 0)
        {
            Console.WriteLine("{0} {1} {2} {3}", w, x, y, z);
        }

        static void Example(params int[] args)
        {
            if (args.Length >= 3)
            {
                Console.Write(args[2]);
            }

            foreach (int i in args)
            {
                Console.WriteLine(i);
            }
        }

        //static void NewExample(string a, bool b, params object[] args)
        //{
        //}

        static void Example(int x, int y, int z)
        {
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);
        }

        static void Test(int a, int b, int c = 4, int d = 5)
        {
        }

        static void Main(string[] args)
        {
            Example(2, 3);
            Example(2, 3, 4);
            Example(2, 3, 4, 5, 6, 7);
            
            Example(1, 2, 3, 4, 5, 6, 7, 2, 3, 4, 5, 6, 7, 2, 3, 4, 5, 6, 7, 2, 3, 4, 5, 6, 7);

            Test(1, 2, 3, 4);
            Test(1, 2, 3);
            Test(1, 2);
            //Test(1);

            Test(1, 3, d: 7, c: 99);
            Test(1, 3, d: 7);

            //String.Format();

            Console.ReadKey();
        }
    }
}