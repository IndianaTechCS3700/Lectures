using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PolymorphicVariables
{
    /// <summary>
    /// Much of the power of object-oriented languages derives form 
    /// the ability of objects to change their behavior dynamically
    /// at run time.
    /// </summary>
    abstract class Animal
    {
        abstract public void Speak();
    }

    class Mammal : Animal
    {
        public override void Speak() { Console.WriteLine("<some sound/>"); }
    }

    class Dog : Mammal
    {
        public override void Speak() { Bark(); }

        public void Bark() { Console.WriteLine("Woof"); }
    }

    class Cat : Mammal
	{
        public override void Speak() { Console.WriteLine("Meow"); }
	}



    class PolymorphicVariables
    {
        static void Main(string[] args)
        {
            //Assignment();
            //MessagePassing();
            ReversePolymorphism();
            //ReversePolymorphism_DownCasting();

            Console.ReadKey();
        }



        /// <summary>
        /// In a statically typed languages we say the class of the 
        /// declaration is the static class for the variable, while 
        /// the class of the value it currently holds is 
        /// the dynamic class.
        /// </summary>
        private static void Assignment()
        {
            Animal pet;
            Dog fido;
            Cat fluffy;

            //Animal beast = new Animal();
            Animal beast = new Mammal();
            beast = new Dog();
            beast = new Cat();

            
            pet = new Dog(); // types can take subtypes
            fido = new Dog();
            fluffy = new Cat();

            pet = fido; // types can take existing instances of subtypes

            Mammal mammal = new Dog();

            //Dog dog = new Mammal(); // substypes can't take the parent type


            Mammal mammal2 = new Cat(); // The static type of mammal2 is Mammal
            // The dynamic type is Cat

            mammal2 = new Dog();         // The dynamic type is now dog
            // The static type is still Mammal

        }

        /// <summary>
        /// In a statically typed object-oriented language, the 
        /// legality of a message is determined at compile time, 
        /// based on the static class.
        /// </summary>
        private static void MessagePassing()
        {
            Mammal pet = new Dog();
            //pet.Bark();
            pet.Speak();

            Dog fido = new Dog();
            fido.Bark();
        }

        /// <summary>
        /// Polymorphism says we can assign a value from a child class 
        /// to an instance of the parent class, but can this assignment 
        /// then be reversed?  
        /// </summary>
        private static void ReversePolymorphism()
        {

            Dog fido = new Dog();
            Mammal pet = fido;

            //Dog rover = pet;

            Animal beast = new Mammal();

            beast.Speak();

            beast = new Dog();
            beast.Speak();

            beast = new Cat();
            beast.Speak();

          
            Animal[] creatures = new Animal[] { new Cat(), new Dog(), new Dog(),
                new Mammal() };


            foreach(Animal creature in creatures)
            {
                creature.Speak();
            }

        }

        /// <summary>
        /// Most languages provide a way to test for the dynamic type 
        /// and to safly downcast a variable.
        /// </summary>
        private static void ReversePolymorphism_DownCasting()
        {

            Dog fido = new Dog();
            Mammal pet = fido;

            // direct assignment is illegal
            //Dog rover = pet;

            // You can directly cast an object to another type...
            Dog rover = (Dog)pet;
            rover.Bark();

            // but this can be problematic
            pet = new Cat();
            rover = (Dog)pet;

            // so you have to handle the exception
            try
            {
                rover = (Dog)pet;
            }
            catch (InvalidCastException)
            {
                rover = null; // but this is a mess
            }

            // there is a better way
            if (pet is Dog)
            {
                rover = pet as Dog;
            }

            rover = pet as Dog;
            if (rover == null)
            {
                //handle error
            }
        }

        private void test()
        {
            Animal c = new Cat();

            c = new Dog();

            c = new Cat();

            c = new Dog();
        }
    }
}
