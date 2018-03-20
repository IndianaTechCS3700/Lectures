using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _5_4
{
    /// <summary>
    /// In most programming languages objects must be created dynamically,
    /// usually using the new operator:
    /// </summary>
    internal class Program
    {
        private static void Main(string[] args)
        {
            Example1();

            Example2();

            Example3();
        }

        private static void Example1()
        {
            // Simply names a new variable
            PlayingCard yourCard;
            //yourCard.Rank = 8;

            // creates a new object
            PlayingCard myCard = new PlayingCard();
            myCard.Rank = 7;

            PlayingCard mySecondCard = new PlayingCard();
            mySecondCard.Rank = 8;

            int number;

        }

        private static void Example2()
        {
            PlayingCard[] cardCollection;

            // Declaring the array only allocates memory for the pointers
            PlayingCard[] deck = new PlayingCard[52];

            for (int i = 0; i < 52; i++)
            {
                // you must allocate memory for each item in the array
                deck[i] = new PlayingCard();
            }

            Console.WriteLine(deck[0].Rank);
        }

        private static void Example3()
        {
            PlayingCard[] hand = new PlayingCard[5] { new PlayingCard(),
                new PlayingCard(), new PlayingCard(), new PlayingCard(),
                new PlayingCard(), };

            int[] myList = { 3, 5, 7, 9, 11 };
        }
    }

    internal class PlayingCard
    {
        public int Rank { get; set; }

        public bool IsFaceUp { get; set; }

        public void Flip()
        {
            IsFaceUp = !IsFaceUp;
        }
    }
}