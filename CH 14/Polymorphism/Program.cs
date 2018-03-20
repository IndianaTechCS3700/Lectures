using System.Collections.Generic;

namespace Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            List<long> mySet = new Set_Inheritance();
            mySet.Add(7);

            Set_Inheritance si = new Set_Inheritance();
            si.Add(7);
            si.RemoveAt(1);


            PrintList(mySet);
            PrintList(si);

            Set_Composition sc = new Set_Composition();
            sc.Add(7);
            int count = sc.Count();

            //sc.RemoveAt(1);

            //PrintList(sc);
        }

        private static void PrintList(List<long> theList)
        {
            // interesting code here
        }
    }
}