using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TempletedClasses
{
    class Pair<T> 
    {
        public T First { get; set; }
        public T Second { get; set; }

        public Pair()
        {

        }

        public Pair(T first, T second)
        {
            First = first;
            Second = second;
        }

        public string GetConcatinatedString()
        {
            return First.ToString() + Second.ToString();
        }

        //public T Max()
        //{
        //    if (First.CompareTo(Second) > 0)
        //        return First;

        //    return Second;
        //}
    }

    class TemplatedClass
    {
        static void Main(string[] args)
        {
            Pair<int> intPair = new Pair<int>();
            Pair<int> intPair2 = new Pair<int>(3, 4);

            Pair<float> floatPair = new Pair<float>(7.0f, 8);

            int firstNum = intPair.First;
            intPair.First = 7;
            Console.WriteLine(intPair2.Second);

            Pair<string> stringPair = new Pair<string>();
            Pair<string> stringPair2 = new Pair<string>("one", "two");

            //stringPair.First = 7;

            Pair<TemplatedClass> tPair = new Pair<TemplatedClass>();

            List<int> foo = new List<int>();
            Stack<int> stack = new Stack<int>();
            Dictionary<string, int> d = new Dictionary<string, int>();

            Console.ReadKey();
        }
    }
}
