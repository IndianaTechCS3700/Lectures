using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _23._1._1_A_Internal_Data_Coupling
{
    class Person
    {
        public string name;

    }

    class BlackBox
	{
        public void SetPerson(Person p)
        {
            p.name = "Lucy";
        }
	}


    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();
            p.name = "Larry";

            BlackBox whatDoIDo = new BlackBox();
            whatDoIDo.SetPerson(p);

            Set s = new Set();
            //int count = s.theData.Count;

            Console.WriteLine(p.name);


            Console.ReadKey();
        }
    }


    class Set
    {
        private List<int> theData = new List<int>();

        public void Add(int i)
        {
            if (!theData.Contains(i))
            {
                theData.Add(i);
            }
        }
    }
}
