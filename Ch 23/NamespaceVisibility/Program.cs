using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//using MyNamespace;

namespace MyNamespace
{
    class First
    {
        public int Data { get; set; }

    }
}



namespace NamespaceVisibility
{
    class Second
    {
        public void GetData()
        {
            MyNamespace.First f = new MyNamespace.First();
            int x = f.Data;
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            MyNamespace.First f = new MyNamespace.First();

            Second s = new Second();
            s.GetData();
        }
    }
}
