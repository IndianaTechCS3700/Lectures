using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

///
/// Problem: How do you provide a client access to 
/// elements in a collection, without exposing the 
/// structure of the collection. 
/// 
namespace _1._1_Iterator
{
    public class Iterator
    {
        private void ViewElements()
        {
            //List<int> myList = new List<int>();

            //List<int>.Enumerator myEnumerator = myList.GetEnumerator();
            //myEnumerator.MoveNext();

            int total = 0;
            LinkedList<int> newList = new LinkedList<int>();
            newList.AddLast(7);
            newList.AddLast(8);
            newList.AddLast(9);

            LinkedList<int>.Enumerator iterator = newList.GetEnumerator();
            total += iterator.Current;

            while (iterator.MoveNext())
            {
                total += iterator.Current;
            }

            //foreach (var item in newList)
            //{
            //    total += item;
            //}

            //for (int i = 0; i < newList.Count; i++)
            //{
            //    int foo = newList.ElementAt(i);
            //    total += foo;

            //}
        }
        
    }
}
