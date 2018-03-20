using System;
using System.Collections.Generic;

namespace TempletedClasses
{
    internal class Pair<T> where T : IComparable<T>
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

        public int IsFirstGreaterThanSecond()
        {
            return First.CompareTo(Second);
        }

        public T Max()
        {
            if (First.CompareTo(Second) > 0)
                return First;

            return Second;
        }
    }

    internal class Program
    {
        private static void Main(string[] args)
        {
            Pair<int> intPair = new Pair<int>();
            Pair<int> intPair2 = new Pair<int>(3, 4);

            Pair<string> stringPair = new Pair<string>();
            Pair<string> stringPair2 = new Pair<string>("one", "two");

            //Pair<Program> programPair = new Pair<Program>();

            int x = intPair2.Max();

            string y = stringPair2.Max();

            Console.ReadKey();

            List<IComparable> myList = new List<IComparable>();
            System.Collections.Stack myStack = new System.Collections.Stack();

            System.Collections.Generic.Stack<int> otherStack = new Stack<int>();

            otherStack.Push(7);
        }
    }
}