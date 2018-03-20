using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Overriding
{
    sealed class King
    {
        public void WriteOutAgenda()
        {
            Console.WriteLine("Rule Country");
        }
    }

    //class Prince : King
    //{
    //}

    class Program
    {
        static void Main(string[] args)
        {
            //            King k = new King();
            //            k.WriteOutAgenda();

            //            Console.WriteLine();

            //            Prince p = new Prince();
            //            p.WriteOutAgenda();

            //            Console.WriteLine();

            //            King k2 = new Prince();
            //            k2.WriteOutAgenda();

            //            Console.WriteLine();

            //            Console.WriteLine("Press Any Key to Continue");
            //            Console.ReadKey();
        }
    }
}