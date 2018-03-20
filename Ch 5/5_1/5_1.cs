using System;

namespace _5_1
{
    /// <summary>
    /// Messages are not Function Calls
    /// 
    /// Three parts of the 
    /// The message receiver
    /// The message selector
    /// An optional list of arguments
    /// </summary>
    class Greeter
    {
        virtual public string GetGreeting()
        {
            return "Hello";
        }
    }

    #region // Sample Class
    class SpanishGreeter : Greeter
    {
        public override string GetGreeting()
        {
            return "Hola"; 

        }
    }
    #endregion
    class Program
    {
        /// <summary>
        /// What is the output of this program?
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Greeter myGreeter = GetGreeter();

            string greeting = myGreeter.GetGreeting();

            Console.WriteLine(greeting);

            Console.WriteLine();
            Console.WriteLine("Press Any Key To Continue");
            Console.ReadKey();
        }

        private static Greeter GetGreeter()
        {
            return new SpanishGreeter();
        }
    }
}



