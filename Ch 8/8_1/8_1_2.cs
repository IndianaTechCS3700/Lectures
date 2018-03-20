using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _8_1
{
    internal class client
    {
        public void main()
        {
            Parent parent = new Parent();
            char a = parent.Alpha();
            //char b = parent.Beta();
            //char c = parent.Gamma();

            Child child = new Child();
            char A = child.Alpha();
            //char B = child.Beta();
            //char C = child.Gamma();

            A = child.GetA();
            //B = child.GetB();
            //C = child.GetC();
        }
    }

    class Parent
    {
        private void example()
        {
            char b = Beta();
        }

        public char Alpha()
        {
            return 'a';
        }

        protected char Beta()
        {
            return 'b';
        }

        private char Gamma()
        {
            return 'g';
        }
    }

    class Child : Parent
    {
        public void example()
        {
            char a = this.Alpha();
            char b = this.Beta();
            //char c = this.Gamma();
        }

        public char GetA()
        {
            return 'A';
        }

        protected char GetB()
        {
            return 'B';
        }

        private char GetC()
        {
            return 'C';
        }
    }
}