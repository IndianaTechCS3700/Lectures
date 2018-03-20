using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sample3
{
    /// <summary>
    /// A redefinition occurs when a child class changes the type signature of a method in the parent class.
    /// </summary>
    class Parent
    {
        public void example(int a)
        {
            Console.WriteLine("in parent method");
        }
    }

    class Child : Parent
    {
        public void example(int a, int b)
        {
            base.example(a);
            Console.WriteLine("in child method");
        }
    }

    class Sample3
    {
        static void Main(string[] args)
        {
            Child aChild = new Child();
            aChild.example(3);

            Parent p = new Child();
            p.example(7);

            Console.WriteLine("Press Any Key to Continue");
            Console.ReadKey();

        }
    }
}