using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _8_1
{
    /// <summary>
    /// Practical Meaning of Inheritance
    ///    * Data members in the parent are part of the child
    ///    * Behavior defined in the parent are part of the child
    /// Note that private aspects of the parent are part of the child,
    /// but are not accessible within the child class.
    ///
    /// Why do we use inheritance? Basically there are two major motivations:
    ///     * Reuse of code. Methods defined in the parent can be made available
    ///       to the child without rewriting. Makes it easy to create new abstractions.
    ///     * Reuse of concept. Methods described in the parent can be redefined and
    ///       overridden in the child. Although no code is shared between parent and
    ///       child, the concept embodied in the definition is shared.
    ///
    /// Inheritance is both Extension and Contraction
    ///     * Because the behavior of a child class is strictly larger than the
    ///       behavior of the parent, the child is an extension of the parent. (larger)
    ///     * Because the child can override behavior to make it fit a specialized
    ///       situation, the child is a contraction of the parent. (smaller)
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            MethodInfo myMethod = new MethodInfo() { MethodName = "Add", Complexity = 7, Lines = 10, Statments = 8 };

            MethodInfoPrinter printer = new MethodInfoPrinter();
            printer.PrintToScreen(myMethod);
            //printer.PrintToPDF(myMethod);

            MethodInfoPdfPrinter printer2 = new MethodInfoPdfPrinter();
            printer2.PrintToScreen(myMethod);
            printer2.PrintToPDF(myMethod);
            printer2.ToString();

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

/// What are the two major reasons for the use of inheritance?