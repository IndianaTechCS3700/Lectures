using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Sample;

namespace IdentityVsEquality
{
    internal class IdentityVsEquality
    {
        private static void Main(string[] args)
        {
            PlayingCard cardOne = new PlayingCard(3, Suits.Diamonds);
            cardOne.IsFaceUp = false;

            PlayingCard cardTwo = new PlayingCard(3, Suits.Diamonds);
            cardTwo.IsFaceUp = false;

            Console.WriteLine("Replicas");
            Console.WriteLine("Are they equal: {0}", cardOne == cardTwo);
            Console.WriteLine("Are they equal: {0}", cardOne.Equals(cardTwo));
            Console.WriteLine("Are they equal: {0}", cardOne.Equals(74));
            Console.WriteLine("Are they equal: {0}", cardOne.Equals("74"));
            

            Console.WriteLine();

            cardTwo = cardOne;
            Console.WriteLine("Same Reference");
            Console.WriteLine("Are they equal: {0}", cardOne == cardTwo);
            Console.WriteLine("Are they equal: {0}", cardOne.Equals(cardTwo));

            Console.WriteLine("Press Any Key To Continue");
            Console.ReadKey();
        }
    }
}