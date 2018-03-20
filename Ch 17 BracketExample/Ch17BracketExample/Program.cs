using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ch17BracketExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Bracket actual = GetActualBracket();
            Bracket picks = GetPicksBracket();

            BracketScoreCalculator calculator = GetScoreCalculator(actual);

            int score = calculator.CalculateScore(picks);

            Console.WriteLine(score);

            Console.WriteLine("Press Any Key To Continue");
            Console.ReadKey();

            BracketScoreCalculator alpha = new SimpleBracketScoreCalculator(actual);
            BracketScoreCalculator beta = new ComplexBracketScoreCalculator(actual);
        }

        private static BracketScoreCalculator GetScoreCalculator(Bracket actual)
        {
            Console.WriteLine("Which scoring strategy to you want to use?");
            Console.WriteLine("1: Simple");
            Console.WriteLine("2: Complex");

            int strategy = Convert.ToInt32(Console.ReadLine());

            if (strategy == 1)
            {
                return new SimpleBracketScoreCalculator(actual);
            }
            else
            {
                return new ComplexBracketScoreCalculator(actual);
            }
        }

        private static Bracket GetActualBracket()
        {
            return new Bracket();
        }

        private static Bracket GetPicksBracket()
        {
            return new Bracket();
        }
    }
}