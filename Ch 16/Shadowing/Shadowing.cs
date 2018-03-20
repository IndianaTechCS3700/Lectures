using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//It is common in programming languages for one declaration of a variable
//to shadow a previous variable of the same name:


namespace Overriding
{
    class King
    {
        virtual public void WriteOutAgenda()
        {
            Console.WriteLine("Rule Contry");
        }

        public int x = 7;

        virtual public void Identify()
        {
            Console.WriteLine("King");
        }
    }

    class Prince : King
    {
        override public void WriteOutAgenda()
        {
            Console.WriteLine("Ride horses");
        }

        public int x = 40;

        new public void Identify()
        {
            Console.WriteLine("Prince");
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            King k = new King();
            Console.WriteLine(k.x);

            Console.WriteLine();

            Prince p = new Prince();
            Console.WriteLine(p.x);

            Console.WriteLine();

            King k2 = new Prince();
            Console.WriteLine(k2.x);

            Console.WriteLine();

            k.Identify();
            p.Identify();
            k2.Identify();

            Console.WriteLine("Press Any Key to Continue");
            Console.ReadKey();
        }
    }
}

//Shadowing can be resolved at compile time, does not require any run-time search.


//Overriding

//The type signatures are the same in both parent and child classes,
//and the method is declared as virtual in the parent class.


//Shadowing

//The type signatures are the same in both parent and child classes,
//but the method was not declared as virtual in the parent class.


//Redefinition

//The type signature in the child class differs 
//from that given in the parent class.

