using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _8_3_Subclass_and_Substitution
{
    /// <summary>
    /// * Instances of the subclass must possess all data areas associated with the 
    ///   parent class.
    /// * Instances of the subclass must implement, through inheritance at least 
    ///   (if not explicitly overridden) all functionality defined for the parent class. 
    ///   (They can also define new functionality, but that is unimportant for the 
    ///   present argument).
    ///   
    /// * Thus, an instance of a child class can mimic the behavior of the parent 
    ///   class. It therefore seems reasonable that a variable declared as a parent, 
    ///   should be able to hold a value generated from the child class. 
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            MethodInfo myMethod = new MethodInfo() { MethodName = "Add", Complexity = 7, Lines = 10, Statments = 8 };

            MethodInfoPrinter printer = new MethodInfoPrinter();
            //MethodInfoPrinter printer = new MethodInfoPdfPrinter();
            printer.PrintToScreen(myMethod);


            Console.ReadKey();

        }
    }

    class MethodInfoPrinter
    {
        public void PrintToScreen(MethodInfo method)
        {
            Console.WriteLine("{0}, {1}, {2}, {3}", method.MethodName, method.Complexity, method.Statments, method.Lines);
        }
    }

    class MethodInfoPdfPrinter : MethodInfoPrinter
    {
        public void PrintToPDF(MethodInfo method)
        {
            // write PDF
        }
    }

    class MethodInfo
    {
        public string MethodName { get; set; }
        public int Complexity { get; set; }
        public int Statments { get; set; }
        public int Lines { get; set; }

    }
}
/// Why is an instance of a child class able to be a assigned to a variable of the
/// parent class?