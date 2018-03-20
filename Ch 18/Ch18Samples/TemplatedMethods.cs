using System;

//The idea of a generic (or template) is yet another approach
//to software reuse.

//The time, the basic idea is to develop code by leave certain
//key types unspecified, to be filled in later.

//In many ways this is like a parameter that is filled with may
//different values.  Here, however, the parameters are types,
//and not values.

namespace Ch18Samples
{
    internal class TemplatedMethods
    {
        private static void Main(string[] args)
        {
            Concat<int>(2, 3);
            //Concat<int>("2", "3");
            Concat<string>("2", "3");

            Concat2<int, int>(4, 5);
            Concat2<float, float>(4.7f, 5.2f);
            Concat2<int, float>(4, 5.2f);

            Console.WriteLine(Concat(7, 8));
            Console.WriteLine(Concat(3.14, 2.75));
            Concat(2, 2.75);
            Concat("one", "two");

            Concat2("one", 2.0);

            Console.ReadKey();
        }

        //private static string Concat(object first, object second)
        //{
        //    return first.ToString() + second.ToString();
        //}

        private static string Concat<T>(T first, T second)
        {
            T third = first;
            return first.ToString() + second.ToString();
        }

        private static string Concat2<T, U>(T first, U second)
        {
            T third = first;
            return first.ToString() + second.ToString();
        }

        private static string Concat3<TAtype>(TAtype first, TAtype second)
        {
            TAtype third = first;
            return first.ToString() + second.ToString();
        }
    }
}