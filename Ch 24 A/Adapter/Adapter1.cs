using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

///
/// Problem: You have a class the provides the functionality that you want
/// but it is not packed or named in the way that you need it
///
namespace Adapter
{
    /// <summary>
    /// This is the desired interface
    /// </summary>
    interface IReturnNum
    {
        double ReturnNum();
    }

    /// <summary>
    /// This class adapts the BCL random number generator to the IReturnNum interface
    /// </summary>
    internal class RandNumAdapter : IReturnNum
    {
        Random r = new Random((int)DateTime.Now.Ticks);

        public double ReturnNum()
        {
            double d = (double)r.Next();

            return d;
        }
    }

    /// <summary>
    /// This class outputs numbers
    /// </summary>
    internal class NumberPrinter
    {
        public void PrintNum(IReturnNum numberGenerator)
        {
            Console.WriteLine(numberGenerator.ReturnNum());
        }
    }

    internal class Adapter1
    {
        private static void Main(string[] args)
        {
            NumberPrinter np = new NumberPrinter();
            RandNumAdapter randomDoubleGenerator = new RandNumAdapter();

            for (int i = 0; i < 10; i++)
            {
                np.PrintNum(randomDoubleGenerator);
            }

            Console.ReadKey();
        }
    }
}