using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _23._1._4_B_ClassLevelVsObjectLevelVisibility
{
    class Changeling
    {
        private int myValue;

        public void ChangeMe(int newValue)
        {
            myValue = newValue;
        }

        public void ChangeOther(Changeling other, int newValue)
        {
            other.myValue = newValue;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Changeling first = new Changeling();
            Changeling second = new Changeling();

            //first.myValue = 6;
            first.ChangeMe(7);
            second.ChangeOther(first, 8);
        }
    }
}
