using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sample
{
    public enum Suits
    {
        Hearts,
        Diamonds,
        Spades,
        Clubs
    }


    public class PlayingCard 
    {

        private int rank;
        private Suits suit;

        public int Rank
        {
            get
            {
                return rank;
            }
            set
            {
                rank = value;
            }
        }

        public Suits Suit
        {
            get
            {
                return suit;
            }
        }

        public PlayingCard(int rank, Suits suit)
        {
            this.rank = rank;
            this.suit = suit;
        }

        public PlayingCard(PlayingCard cardToCopyFrom)
        {
            this.rank = cardToCopyFrom.Rank;
            this.suit = cardToCopyFrom.Suit;
            this.IsFaceUp = cardToCopyFrom.IsFaceUp;
        }

        public bool IsFaceUp { get; set; }

        #region equality

        public bool Equals(PlayingCard pc)
        {
            return Equals(pc as object);
        }

        public override bool Equals(object obj)
        {
            bool equal = false;

            if (!(obj is PlayingCard))
            {
                return false;
            }

            PlayingCard cardToCompareThisCardTo = obj as PlayingCard;

                equal = this.Rank == cardToCompareThisCardTo.Rank &&
                        this.Suit == cardToCompareThisCardTo.Suit &&
                        this.IsFaceUp == cardToCompareThisCardTo.IsFaceUp;

            return equal;
        }

        #endregion equality
    }
}