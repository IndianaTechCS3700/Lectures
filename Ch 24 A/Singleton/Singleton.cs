using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

///
/// Problem: You want to ensure that there is never more 
/// than one instance of a given class. 
/// 

namespace Singleton
{
    class Singleton
    {
        private Singleton() { }

        private static Singleton theOnlyInstance = null;

        public static Singleton GetTheOnlyInstance()
        {
            if (theOnlyInstance == null)
            {
                theOnlyInstance = new Singleton();
            }
            return theOnlyInstance;
        }

        public void Execute()
        {

            Console.WriteLine("Execution");
        }

        public int FavoriteNumber { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //Singleton s = new Singleton();
            Singleton s = Singleton.GetTheOnlyInstance();
            

            s.Execute();
            s.FavoriteNumber = 7;

            s.FavoriteNumber = 42;

            Console.ReadKey();


            
        }
    }
}
