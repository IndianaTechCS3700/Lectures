using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _8_4_Overridding_and_Virtual_Methods
{
    /// <summary>
    /// With overriding and substitution, we have a situation where a variable is
    /// declared as the parent type but has the state and behavior of the child type.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            MethodInfo myMethod = new MethodInfo() { MethodName = "Add", Complexity = 7, Lines = 10, Statments = 8 };

            //MethodInfoPrinter printer = new MethodInfoPrinter();
            //printer.PrintToScreen(myMethod);

            //printer = new MethodInfoTablePrinter();
            //printer.PrintToScreen(myMethod);

            MethodInfoPrinter printer = GetPrinter();
            printer.PrintToScreen(myMethod);


            //Console.WriteLine(printer.ToString());
            //Console.WriteLine(5.ToString());

            Console.ReadKey();
        }

        public static MethodInfoPrinter GetPrinter()
        {
            Console.WriteLine("Which output format do you want?");
            Console.WriteLine("1) Standard");
            Console.WriteLine("2) Table");
            string choice = Console.ReadLine();
            if (choice == "2")
            {
                return new MethodInfoTablePrinter();
            }
            else
            {
                return new MethodInfoPrinter();
            }
        }
    }

    class MethodInfoPrinter
    {
        public virtual void PrintToScreen(MethodInfo method)
        {
            Console.WriteLine("{0}, {1}, {2}, {3}", method.MethodName, method.Complexity, method.Statments, method.Lines);
        }
    }

    class MethodInfoTablePrinter : MethodInfoPrinter
    {
        public override void PrintToScreen(MethodInfo method)
        {
            Console.WriteLine("{0} \t {1} \t {2} \t {3}", method.MethodName, method.Complexity, method.Statments, method.Lines);
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