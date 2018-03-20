using System;
using System.Collections.Generic;

namespace _8_5_Interfaces_and_Abstract_Classes
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            MethodInfo myMethod = new MethodInfo() { MethodName = "Add", Complexity = 7, Lines = 10, Statments = 8 };

            IMethodInfoPrinter printer;

            //printer = new IMethodInfoPrinter();

            printer = new MethodInfoCSVPrinter();
            printer.PrintLegend();
            printer.PrintToScreen(myMethod);

            Console.ReadKey();
        }
    }

    //internal interface IMethodInfoPrinter
    //{
    //    void PrintToScreen(MethodInfo method);

    //    void PrintLegend();
    //}

    abstract class IMethodInfoPrinter
    {
        public abstract void PrintToScreen(MethodInfo method);

        public virtual void PrintLegend()
        {
            Console.WriteLine("Legend");
        }
    }

    internal class MethodInfoCSVPrinter : IMethodInfoPrinter
    {
        public override void PrintToScreen(MethodInfo method)
        {
            Console.WriteLine("{0}, {1}, {2}, {3}", method.MethodName, method.Complexity, method.Statments, method.Lines);
        }

        //public override void PrintLegend()
        //{
        //}
    }

    internal class MethodInfoTablePrinter : IMethodInfoPrinter
    {
        public override void PrintToScreen(MethodInfo method)
        {
            Console.WriteLine("{0} \t {1} \t {2} \t {3}", method.MethodName, method.Complexity, method.Statments, method.Lines);
        }

        public override void PrintLegend()
        {
            List<MethodInfo> myList = new List<MethodInfo>();
            myList.Sort();
        }
    }

    internal class MethodInfo  
    {
        public string MethodName { get; set; }

        public int Complexity { get; set; }

        public int Statments { get; set; }

        public int Lines { get; set; }

        public int CompareTo(MethodInfo other)
        {
            return this.Lines.CompareTo(other.Lines);
        }
    }
}