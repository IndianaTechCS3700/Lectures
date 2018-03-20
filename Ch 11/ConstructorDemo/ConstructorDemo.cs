using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConstructorDemo
{
    class Grandparent
    {
        public Grandparent()
        {
            Console.WriteLine("Constructing Grandparent");
        }
    }
    class Parent : Grandparent
    {
        public Parent()
        {
            Console.WriteLine("Constructing Parent");
        }
    }
    class Child : Parent
    {
        public Child()
        {
            Console.WriteLine("Constructing Child");
        }
    }
    class ConstructorDemo
    {
        static void Main(string[] args)
        {
            Grandparent abe = new Grandparent();
            Parent homer = new Parent();
            Child bart = new Child();

            Console.ReadKey();
        }
    }
}
