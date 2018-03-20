using System;
using System.Collections;
using System.Linq;
using System.Text;

using Animals;

namespace _2_HeterogeneousCollections
{
    class HeterogeneousCollections
    {
        static void Main(string[] args)
        {
            ArrayList animalList = GetAnimalList();

            foreach (object item in animalList)
            {
                if (item is Cat)
                {
                    Console.WriteLine("{0, 10} {1}", ((Cat)item).Name, 
                        ((Cat)item).EatsMice);
                }
                if (item is Dog)
                {
                    Console.WriteLine("{0, 10} {1}", ((Dog)item).Name, 
                        ((Dog)item).CatchesFrisbee);
                }
            }

            Console.ReadKey();
        }

        static ArrayList GetAnimalList()
        {
            ArrayList animalList = new ArrayList();

            animalList.Add(new Cat() { Name = "Fluffy", EatsMice = true });
            animalList.Add(new Dog() { Name = "Rover", CatchesFrisbee = true });
            animalList.Add(new Cat() { Name = "Simba", EatsMice = true });
            animalList.Add(new Dog() { Name = "Nemo", CatchesFrisbee = false });

            return animalList;
        }
    }
}
