using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Overloading
{
    internal enum Suit
    {
        Clubs,
        Diamonds,
        Hearts,
        Spades
    }

    internal class Program
    {
        private static void Main(string[] args)
        {
            PlayingCard card = new PlayingCard();
            PlayingCard sourceCard = new PlayingCard();


            sourceCard.Copy(4, Suit.Diamonds);


            card.Copy(sourceCard);

            Convert.ToInt16(false);
        }
    }

    class PlayingCard
    {
        private int rank;
        private Suit suit;

        public void Copy(int rank, Suit suit)
        {
            this.rank = rank;
            this.suit = suit;
        }

        public void Copy(PlayingCard source)
        {
            this.rank = source.rank;
            this.suit = source.suit;
        }
    }
}