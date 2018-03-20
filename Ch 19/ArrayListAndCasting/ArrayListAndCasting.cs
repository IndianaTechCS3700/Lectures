using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Animals;



///Collection classes are simple to write in dynamically 
///typed languages, Since all variables are polymorphic.

///Containers simply hold values in variables (which can hold anything), 
///and when they are removed from the container they can be assigned 
///to any variable.

///Dynamically typed languages have historically come with a rich 
///set of container classes in their standard library.


namespace ArrayListAndCasting
{
    class ArrayListAndCasting
    {
        static void Main(string[] args)
        {
            ArrayList animalList = GetCatList();
            //ArrayList animalList = GetCatList2();
            //ArrayList animalList = GetCatList3();

            foreach (object catObject in animalList)
            {
                //Console.WriteLine(catObject.Name); 

                Cat cat = catObject as Cat;

                Console.WriteLine("{0, 10} {1}", cat.Name, cat.EatsMice);
            }

            Console.ReadKey();
        }

        static ArrayList GetCatList()
        {
            ArrayList animalList = new ArrayList();

            animalList.Add(new Cat() { Name = "Fluffy", EatsMice = true });
            animalList.Add(new Cat() { Name = "Garfield", EatsMice = false });
            animalList.Add(new Cat() { Name = "Simba", EatsMice = true });
            animalList.Add(new Cat() { Name = "Furball", EatsMice = false });

            return animalList;
        }

        static ArrayList GetCatList2()
        {
            ArrayList animalList = new ArrayList();

            animalList.Add(new Cat() { Name = "Fluffy", EatsMice = true });
            animalList.Add(new Dog() { Name = "Rover", CatchesFrisbee=true });
            animalList.Add(new Cat() { Name = "Simba", EatsMice = true });
            animalList.Add(new Dog() { Name = "Nemo", CatchesFrisbee = false });

            return animalList;
        }

        static ArrayList GetCatList3()
        {
            ArrayList animalList = new ArrayList();

            animalList.Add(new Cat() { Name = "Fluffy", EatsMice = true });
            animalList.Add(7);
            animalList.Add(true);
            animalList.Add(new Dog() { Name = "Nemo", CatchesFrisbee = false });

            return animalList;
        }
    }
}
