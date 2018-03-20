using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _5_6
{
    /// <summary>
    /// A constructor is a function that is implicitly invoked when a new object is created.
    /// The constructor performs whatever actions are necessary in order to initialize the object.
    ///
    /// In C++, Java, C# a constructor is a function with the same name as the class.
    /// In Python constructors are all named __init__
    /// In Delphi, Objective-C, constructors have special syntax, but can be named anything.
    /// </summary>
    public class Program
    {
        private static void Main(string[] args)
        {
            PlayingCard myCard;

            myCard = new PlayingCard();
            myCard = new PlayingCard(7);
            myCard = new PlayingCard(5, false, Suit.Diamond);
        }


    }

    public enum Suit
    {
        Heart,
        Diamond,
        Club,
        Spade
    }

    /// <summary>
    /// Constructors are often overloaded, meaning there are a number of functions with the same name.
    /// They are differentiated by the type signature, and the arguments used in the function call or declaration
    /// </summary>
    public class PlayingCard
    {
        private int rank = 1;
        private bool isFaceUp = false;
        private Suit suit = Suit.Heart;

        public PlayingCard()
        {
            rank = 2;
            isFaceUp = true;
        }

        public PlayingCard(int rank)
        {
            this.rank = rank;
        }

        public PlayingCard(int rank, bool isFaceUp, Suit suit)
        {
            this.rank = rank;
            this.isFaceUp = isFaceUp;
            this.suit = suit;
        }
    }
}