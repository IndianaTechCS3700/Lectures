using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Animals
{
    public class Animal
    {
        public string Name { get; set; }
        public string Color { get; set; }
    }

    public class Dog : Animal
    {
        public bool CatchesFrisbee { get; set; }
    }

    public class Cat : Animal
    {
        public bool EatsMice { get; set; }
    }
}
