using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _10_2_Subtypes
{
    /// <remarks>
    /// * To assert that one class is a subclass of another is to simply 
    ///   say it was built using inheritance. It is a statement concerning 
    ///   how it was constructed.
    ///   
    /// * To assert that one class is a subtype of another is to say that 
    ///   it preserves the purpose of the original. It is a statement 
    ///   concerning meaning. 
    /// </remarks>
    class Program
    {
        /// What is a type? 
        /// * A Set of Values
        /// * A Set of Operations
        /// * A Set of Properties
        ///
        static void Main(string[] args)
        {
            //Stack stringStack = new Stack();

            /// Subclasses are not Necessarily Subtypes
            Stack stringStack = new NonStack();

            StackTest(stringStack);

            Console.WriteLine("Press Any Key To Continue");
            Console.ReadKey();
        }

        private static void StackTest(Stack stringStack)
        {
            stringStack.Push("one");
            stringStack.Push("two");
            stringStack.Push("three");

            

            string current = stringStack.Top();

            while (current != null)
            {
                Console.WriteLine(current);
                stringStack.Pop();
                current = stringStack.Top();
            }
        }
    }
}

/// It is trivial to determine if one class is a subclass of another.
/// It is extremely difficult to define meaning, and even if you can 
///  it is almost always impossible to determine if one class 
///  preserves the meaning of another. 
