using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

// If a method is abstract, it must be overridden

namespace Overriding
{
    internal abstract class King
    {
        abstract public void WriteOutAgenda();
    }

    internal  class Prince : King
    {

        override public void WriteOutAgenda()
        {
            Console.WriteLine("Ride horses");
        }
    }

    class RoyalBaby : Prince
    {
        //public override void WriteOutAgenda()
        //{
        //    Console.WriteLine("Cry");
        //}
    }



    internal class Princess : King
    {
        public override void WriteOutAgenda()
        {
            Console.WriteLine("Do very important things");
        }
    }

    internal class Program
    {
        private static void Main(string[] args)
        {
            //King k = new King();
            //k.WriteOutAgenda();

            Console.WriteLine();

            Prince p = new Prince();
            p.WriteOutAgenda();

            Console.WriteLine();

            King k2 = new Prince();
            k2.WriteOutAgenda();

            List<King> royalOffspring = new List<King>();
            royalOffspring.Add(new Prince());
            royalOffspring.Add(new Princess());
            royalOffspring.Add(new Prince());
            royalOffspring.Add(new RoyalBaby());

            foreach (King child in royalOffspring)
            {
                child.WriteOutAgenda();
            }

            Console.WriteLine();

            Console.WriteLine("Press Any Key to Continue");
            Console.ReadKey();



        }
    }
}