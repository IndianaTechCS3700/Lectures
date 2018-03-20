using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//We abstract the common behavior and place it into a parent class (for example, managing the pile of cards).

//We use overriding to specialize the behavior that is specific to each class.
//(for example, what it means when the pile is selected)..

//Since some piles share behavior that in other piles is overridden, the parent class can provide a default
//behavior that can sometimes be changed (for example, drawing).
namespace Chapter9
{
    /// <summary>
    /// This class represents a pile of playing cards
    /// </summary>
    public abstract class CardPile
    {
        public CardPile(int xl, int yl)
        {
            x = xl;
            y = yl;
            pile = new Stack<PlayingCard>();
        }

        public PlayingCard top
        { get { return pile.Peek(); } }

        public bool isEmpty
        { get { return pile.Count == 0; } }

        public PlayingCard pop
        { get { return pile.Pop(); } }

        // the following are sometimes overridden
        public virtual bool includes(int tx, int ty)
        {
            return ((x <= tx) && (tx <= x + CardView.Width) &&
                (y <= ty) && (ty <= y + CardView.Height));
        }

        public virtual void select(int tx, int ty)
        {
            // do nothing--override
        }

        public virtual void addCard(PlayingCard aCard)
        { pile.Push(aCard); }

        public virtual void display(CardView cv)
        {
            if (isEmpty)
            {
                cv.display(null, x, y);
            }
            else
            {
                cv.display((PlayingCard)pile.Peek(), x, y);
            }
        }

        public virtual bool canTake(PlayingCard aCard)
        { return false; }

        protected int x, y; // coordinates of the card pile
        protected Stack<PlayingCard> pile; // card pile data
    }

    class CrazyPile : CardPile
    {
        public CrazyPile(int x, int y)
            : base(x, y)
        {

        }

        public override void addCard(PlayingCard aCard)
        {
        }
    }
}

//The keyword virtual indicating which methods may be overridden.
//Potentially overridden methods have nevertheless been given a default behavior
//We have written isEmpty and pop as properties
//The data fields have been protected

