using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Animals;

namespace _3_Generics
{
    class Generics
    {
        static void Main(string[] args)
        {
            List<Cat> catList = GetCatList();

            foreach (Cat cat in catList)
            {
                Console.WriteLine("{0, 10} {1}", cat.Name, cat.EatsMice);
            }

            //List<Cat>.Enumerator i = catList.GetEnumerator();

            //do
            //{
            //    Console.WriteLine("{0, 10} {1}", i.Current.Name, i.Current.EatsMice);
            //} while (i.MoveNext());
            
        }

        static List<Cat> GetCatList()
        {
            List<Cat> animalList = new List<Cat>();

            animalList.Add(new Cat() { Name = "Fluffy", EatsMice = true });
            animalList.Add(new Cat() { Name = "Garfield", EatsMice = false });
            animalList.Add(new Cat() { Name = "Simba", EatsMice = true });
            animalList.Add(new Cat() { Name = "Furball", EatsMice = false });

            return animalList;
        }
    }
}

// How could we have a heterogeneous collection with a generic list?
