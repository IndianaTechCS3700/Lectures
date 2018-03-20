using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _8_6_1
{
    public class Class1
    {
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
