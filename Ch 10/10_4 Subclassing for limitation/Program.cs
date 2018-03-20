using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _10_4_Subclassing_for_limitation
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack stackOne = new Stack();
            Stack stackTwo = new Stack();


            stackOne.Sort();
            stackOne.Insert(0, "one");

            Console.WriteLine(stackOne.Count);

            List<string> myList = new Stack();

            myList.Insert(0, "one");

        }
    }
}
