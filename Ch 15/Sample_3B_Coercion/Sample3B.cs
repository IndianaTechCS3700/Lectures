using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sample_3B_Coercion
{
    class Parent
    {

    }

    class Child : Parent
    {

    }

    class Sample3B
    {
        static private void Test(string x)
        {
            Console.WriteLine(x);
        }

        static private void Test(float x)
        {
            Console.WriteLine(x);
        }

        //static private void Test(int x)
        //{
        //    Console.WriteLine(x);
        //}

        static private void Test(Parent x)
        {
            Console.WriteLine(x);
        }

        static void Main(string[] args)
        {
            int intX = 0;

            Test(intX);

            //double val = 99.99;
            //Test(val);

            Test(new Child());



        }
    }
}
