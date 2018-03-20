using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


//Like overloading, there are two distinct methods with the same name. But there are 
//differences:

// * Overriding only occurs in the context of the parent/child relationship
// * The type signatures must match
// * Overridden methods are sometimes combined together
// * Overriding is resolved at run-time, not at compile time.


//In some languages (Smalltalk, Java) overriding occurs automatically when
//a child class redefines a method with the same name and type signature.

//In some languages (C++) overriding will only occur if the parent class
//has declared the method in some special way (example, keyword virtual).

//In some languages (Object Pascal) overriding will only occur if the child
//class declares the method in some special way (example, keyword override).

//In some languages (C#, Delphi) overriding will only occur if both the
//parent and the child class declare the method in some special way.


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
        }

        public override string ToString()
        {
            return "I'm a prince, I'm a prince!!!";
        }

    } 

    class Program
    {
        static void Main(string[] args)
        {
            King k = new King();
            k.WriteOutAgenda();

            Prince p = new Prince();
            p.WriteOutAgenda();

            King k2 = new Prince();
            k2.WriteOutAgenda();

            Console.WriteLine(k2.ToString());
            
            Console.WriteLine("Press Any Key to Continue");
            Console.ReadKey();
        }
    }
}

//There are a number of reasons to use replacement of methods.

// * The method in the parent class is abstract, it must be replaced.
// * The method in the parent class is a default method, not appropriate for all situations.
// * The method in the parent can be more efficiently executed in the child.



//The down side of replacement semantics is that there is no guarantee
//that the child class will have any meaning at all similar to the
//parent class.

//For example, a child class could redefine sqrt to compute
//the cube root of its argument.

//This goes back to the difference between subclasses and subtypes.

//A refinement makes this more difficult to do, since whatever the parent
//does is guaranteed to be part of the child.  This is why most languages
//use refinement semantics for constructors.
