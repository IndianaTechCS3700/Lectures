using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ch_20
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            List<int> myList = new List<int>() { 1, 3, 5, 7, 9, 11, 13, 15, 17, 19 };

            List<int>.Enumerator visitor = myList.GetEnumerator();

            while (visitor.Current < 16)
            {
                Console.WriteLine(visitor.Current);
                visitor.MoveNext();
            }

            

            //List<int>.Enumerator enumerator = new List<int>.Enumerator();
            //do
            //{
            //    Console.WriteLine(enumerator.Current);
            //} while (enumerator.MoveNext() == true);

            Console.WriteLine("Press Any Key To Continue");
            Console.ReadKey();
        }
    }
}