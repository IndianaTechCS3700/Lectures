using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


//In most languages that have constructors, a constructor will always use refinement.

//This guarantees that whatever initialization the parent class performs will always 
//be included as part of the initialization of the child class.


namespace ConstructorRefinement
{
    class King
    {
        protected object country;
        protected string name;

        public King()
        {
            country = new object();
            Console.WriteLine("King is constructed");
        }

        public King(string rulerName)
        {
            this.name = rulerName;
        }

        virtual public void WriteOutAgenda()
        {
            Console.WriteLine("Rule Contry");
        }
    }

    class Prince : King
    {
        public Prince()
        {
            Console.WriteLine("Prince is constructed");
        }

        public Prince(string rulerName)
            : base(rulerName)
        {
        }

        override public void WriteOutAgenda()
        {
            Console.WriteLine("Ride horses");
        }

    } 

    class Program
    {
        static void Main(string[] args)
        {
            King k = new King();

            Console.WriteLine();

            Prince p = new Prince();

            Console.WriteLine();

            King k2 = new Prince();
            
            Console.WriteLine();

            Console.WriteLine("Press Any Key to Continue");
            Console.ReadKey();
        }
    }
}
