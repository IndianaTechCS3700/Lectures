using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Overriding
{
    class King
    {
        virtual public void WriteOutAgenda()
        {
            Console.WriteLine("Rule Contry");
        }
    }

    class Prince : King
    {
        override public void WriteOutAgenda()
        {
            Console.WriteLine("Ride horses");
            base.WriteOutAgenda();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            King k = new King();
            k.WriteOutAgenda();

            Console.WriteLine();

            Prince p = new Prince();
            p.WriteOutAgenda();

            Console.WriteLine();

            King k2 = new Prince();
            k2.WriteOutAgenda();

            Console.WriteLine();

            Console.WriteLine("Press Any Key to Continue");
            Console.ReadKey();
        }
    }
}

// some obscure languages use refinement by default