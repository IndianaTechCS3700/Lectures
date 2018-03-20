using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _23._1._1_C_SequenceCoupling
{
    class Program
    {
        static void Main(string[] args)
        {
            System.IO.TextReader tw = new System.IO.StreamReader(@"C:\Temp.txt");

            //tw.ReadToEnd();

            string FristLine = tw.ReadLine();

            string restOfFile = tw.ReadToEnd();

            tw.Close();

        }
    }
}
