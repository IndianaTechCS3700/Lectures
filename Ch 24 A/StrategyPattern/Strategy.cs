using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/// Sorts example

///
/// Problem: Allow the client the choice of many alternatives,
/// but each is complex, and you don't want to include code for all.
///

namespace Strategy
{
    interface IStrategy
    {
        void Execute();
    }

    internal class ConcreteStrategyA : IStrategy
    {
        public void Execute()
        {
            Console.WriteLine("Called ConcreteStrategyA.Execute()");
        }
    }

    internal class ConcreteStrategyB : IStrategy
    {
        public void Execute()
        {
            Console.WriteLine("Called ConcreteStrategyB.Execute()");
        }
    }

    internal class ConcreteStrategyC : IStrategy
    {
        public void Execute()
        {
            Console.WriteLine("Called ConcreteStrategyC.Execute()");
        }
    }

    internal class Context
    {
        IStrategy strategy;

        public Context(IStrategy strategy)
        {
            this.strategy = strategy;
        }

        public void UpdateContext(IStrategy strategy)
        {
            this.strategy = strategy;
        }

        public void Execute()
        {
            strategy.Execute();
        }
    }

    internal class MainApp
    {
        private static void Main()
        {
            Context anObject;

            // Three contexts following different strategies
            anObject = new Context(new ConcreteStrategyA());
            anObject.Execute();

            anObject.UpdateContext(new ConcreteStrategyB());
            anObject.Execute();

            anObject.UpdateContext(new ConcreteStrategyC());
            anObject.Execute();

            Console.ReadKey();
        }
    }
}

/// The characteristic feature of the strategy pattern is that the server presents the client
/// with a number of choices, typically expressed as different implementations
/// of a common interface. The client selects one of the alternatives and gives
/// it back to the server.