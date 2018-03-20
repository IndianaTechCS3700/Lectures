using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

///
/// How do you facilitate creation of complex systems 
/// from simple parts?
///

namespace Composite
{
    interface IExpression
    {
        int GetValue();
    }

    public class IntAdapter : IExpression
    {
        private int value;

        public IntAdapter(int initialValue)
        {
            value = initialValue;
        }

        public int GetValue()
        {
            return value;
        }
    }

    class AdditionExpression : IExpression
    {
        IExpression left;
        IExpression right;

        public AdditionExpression(IExpression left, IExpression right)
        {
            this.left = left;
            this.right = right;
        }

        public int GetValue()
        {
            return left.GetValue() + right.GetValue();
        }

    }


    class Program
    {
        static void Main(string[] args)
        {
            int result;
            IExpression exp;

            exp = new AdditionExpression(new IntAdapter(6), new IntAdapter(7));
            result = exp.GetValue();
            Console.WriteLine(result);

            /////

            IntAdapter six = new IntAdapter(6);
            IntAdapter seven = new IntAdapter(7);
            IntAdapter eight = new IntAdapter(8);

            AdditionExpression partOne = new AdditionExpression(six, seven);
            AdditionExpression partTwo = new AdditionExpression(eight, six);

            exp = new AdditionExpression(partOne, partTwo);
            result = exp.GetValue();
            Console.WriteLine(result);

            Console.ReadKey();
        }
    }
}
