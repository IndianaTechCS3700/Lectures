using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Sample;

namespace ConsoleApplication1
{
    class Assignment
    {
        static void Main(string[] args)
        {
            PlayingCard cardOne = new PlayingCard(3, Suits.Diamonds);
            cardOne.IsFaceUp = true;
            PrintCardInfo("card one", cardOne);

            Console.WriteLine();

            //PlayingCard cardTwo = new PlayingCard(cardOne);
            PlayingCard cardTwo = cardOne;

            cardTwo.IsFaceUp = false;
            PrintCardInfo("card one", cardOne);
            PrintCardInfo("card two", cardTwo);

            Console.WriteLine("Press Any Key To Continue");
            Console.ReadKey();
        }

        private static void PrintCardInfo(String name, PlayingCard card)
        {
            Console.WriteLine("{0, -10}: {1, -5} {2, -10} {3}", name, card.Rank, card.Suit, IsFaceUp(card.IsFaceUp));
        }

        private static string IsFaceUp(bool isFaceUp)
        {
            if (isFaceUp)
            {
                return "Face Up";
            }

            return "Face Down";
        }
    }
}