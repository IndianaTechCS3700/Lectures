using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication2
{
    class myClass
    {
        Double x;
        Double y;
        Double z;

        string s;
        String st;
    }

    class Program
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();
            int x = Convert.ToInt32(line);

            x = int.Parse(line);

            bool z = int.TryParse(line, out x);

            //StackOverflow();
        }

        static protected void StackOverflow()
        {
            myClass l = new myClass();
            myClass m = new myClass();

            StackOverflow();
        }
    }
}