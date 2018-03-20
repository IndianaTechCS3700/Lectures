using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharpInheritenceAndInterfaces
{
    /// <summary>
    /// This class represents information about a code block
    /// </summary>
    class CodeInfo
    {
        public int Statements { get; set; }

        public int Comments { get; set; }

        public int Lines { get; set; }
    } // end class CodeInfo

    /// <summary>
    /// This class represents information about a method
    /// </summary>
    class MethodInfo : CodeInfo, IComparable<MethodInfo>
    {
        public string MethodName { get; set; }

        public int CompareTo(MethodInfo other)
        {
            if (this.Statements == other.Statements)
            {
                return 0;
            }

            else if (this.Statements < other.Statements)
            {
                return -1;
            }

            return 1;
        }
    } // end class MethodInfo

    /// <summary>
    /// Create three method info objects, sort them and display them
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            //List<MethodInfo> methodList = new List<MethodInfo>();
            var methodList = new List<MethodInfo>();

            MethodInfo a = new MethodInfo() { Statements = 17, Lines = 21, Comments = 10, MethodName = "A" };
            methodList.Add(a);
            MethodInfo c = new MethodInfo() { Statements = 22, Lines = 26, Comments = 15, MethodName = "C" };
            methodList.Add(c);
            MethodInfo b = new MethodInfo() { Statements = 27, Lines = 30, Comments = 12, MethodName = "B" };
            methodList.Add(b);

            // Sort the list using the icomparable interface
            methodList.Sort();

            // Assign the values into IComparable variables
            IComparable<MethodInfo> first = a;
            IComparable<MethodInfo> second = b;

            // Call a method on the IComparable Interface
            first.CompareTo(second as MethodInfo);

            // Assign a variable into a CodeInfo variable
            CodeInfo x = a;

            // Call the properties of the CodeInfo class
            foreach (MethodInfo method in methodList)
            {
                Console.WriteLine("{0} : {1}", method.MethodName, method.Statements);
            }

            Console.ReadKey();
        } // end Main
    } // end class Program
} // end namespace CSharpInheritenceAndInterfaces