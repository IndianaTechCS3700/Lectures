using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chapter9
{
    /// <summary>
    /// This represents the pile of cards where the user places discarded cards
    /// </summary>
    public class DiscardPile : CardPile
    {
        public DiscardPile(int x, int y) : base(x, y) { }

        public override void addCard(PlayingCard aCard)
        {
            if (!aCard.isFaceUp)
            { aCard.flip(); }
            base.addCard(aCard);
        }

        public override void select(int tx, int ty)
        {
            if (isEmpty) { return; }
            PlayingCard topCard = pop;
            for (int i = 0; i < 4; i++)
            {
                if (Game.suitPile(i).canTake(topCard))
                {
                    Game.suitPile(i).addCard(topCard);
                    return;
                }
            }

            for (int i = 0; i < 7; i++)
            {
                if (Game.tableau(i).canTake(topCard))
                {
                    Game.tableau(i).addCard(topCard);
                    return;
                }
            }
            // nobody can use it, put it back on our stack
            addCard(topCard);
        }
    }
}