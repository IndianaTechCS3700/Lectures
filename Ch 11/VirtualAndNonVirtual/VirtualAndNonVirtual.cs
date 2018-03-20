using System;

namespace VirtualAndNonVirtual
{
    internal class Mammal
    {
        virtual public void Speak()
        {
            Console.WriteLine("<some sound/>");
        }
    }

    internal class Dog : Mammal
    {
        override public void Speak()
        {
            //base.Speak();
            Console.WriteLine("Woof");
        }
    }

    internal class VirtualAndNonVirtual
    {
        private static void Main(string[] args)
        {
            Dog fido = new Dog();

            fido.Speak();

            Mammal pet = fido;
            pet.Speak();

            Console.ReadKey();
        }
    }
}