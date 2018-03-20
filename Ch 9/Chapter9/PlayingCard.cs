using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

//A good example of the use of inheritance and overriding
//Built out of classes for cards, card piles, and the game application.
//
// Note
//The constructor for the class
//Properties for faceup, rank and suit
//Qualification of Enumerated Data Types
//This class has no explicit information about application, can be easily moved to new applications.

namespace Chapter9
{
    /// <summary>
    /// This represents a standard playing card
    /// </summary>
    public class PlayingCard
    {

        public PlayingCard()
        {
            s = Suits.Club;
            r = 9;
            faceUp = false;
        }

        public PlayingCard(Suits sv, int rv, bool isFaceUp)
        {
            s = sv;
            r = rv;
            faceUp = isFaceUp;
        }

        public PlayingCard(Suits sv, int rv)
        {
            s = sv;
            r = rv;
            faceUp = false;
        }

        public bool isFaceUp
        {
            get { return faceUp; }
        }

        public void flip()
        {
            faceUp = !faceUp;
        }

        public int rank
        {
            get { return r; }
        }

        public Suits suit
        {
            get { return s; }
        }

        public Color color
        {
            get
            {
                if (suit == Suits.Heart || suit == Suits.Diamond)
                { return Color.Red; }
                return Color.Black;
            }
        }

        private bool faceUp;
        private int r;
        private Suits s;
    }
}