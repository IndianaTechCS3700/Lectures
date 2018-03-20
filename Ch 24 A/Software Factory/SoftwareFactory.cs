using System;
using System.Collections.Generic;
using System.Text;

///
/// Problem: How do you simplify the manipulation 
/// of many different implementations of the same 
/// interface. 
/// 

namespace Software_Factory
{
    class CollectionCreator
    {
        public ICollection<int> GetCorrectCollection(bool needLessThanTenItems)
        {
            ICollection<int> correctCollection;

            if (needLessThanTenItems)
            {
                correctCollection = new int[10];
            }
            else
            {
                correctCollection = new List<int>();
            }

            return correctCollection;
        }
    }

    class SoftwareFactory
    {
        static void Main(string[] args)
        {
            CollectionCreator cc = new CollectionCreator();

            ICollection<int> collection= cc.GetCorrectCollection(true);

            collection.Add(6);
            collection.Add(7);

            int numberOfItems = collection.Count;

            
        }
    }
}
