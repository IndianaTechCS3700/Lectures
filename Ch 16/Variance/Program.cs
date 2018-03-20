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
            //base.WriteOutAgenda();
            Console.WriteLine("Rule Contry");
        }

        virtual public King Clone(King k)
        {
            return k;
        }
    }

    class Prince : King
    {
        override public void WriteOutAgenda()
        {
            base.WriteOutAgenda();
            Console.WriteLine("Ride horses");
        }

        public override King Clone(King k)
        {
            return (King)new Prince();
            //return new Prince();
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