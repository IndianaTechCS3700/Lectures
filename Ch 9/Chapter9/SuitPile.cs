using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chapter9
{
    /// <summary>
    /// This class represents the pile of cards, organized by suit, placed in ascending order.
    /// </summary>
    public class SuitPile : CardPile
    {
        public SuitPile(int x, int y) : base(x, y) { }

        public override bool canTake(PlayingCard aCard)
        {
            if (isEmpty)
            { return (aCard.rank == 0); }
            PlayingCard topCard = top;
            return ((aCard.suit == topCard.suit) &&
               (aCard.rank == topCard.rank + 1));
        }
    }
}