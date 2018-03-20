using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chapter9
{
    /// <summary>
    /// This represents a pile of cards from the main playing area.
    /// </summary>
    public class TablePile : CardPile
    {
        public TablePile(int x, int y, int c)
            : base(x, y)
        {
            // initialize our pile of cards
            for (int i = 0; i < c; i++)
            {
                addCard(Game.deckPile().pop);
            }
            top.flip();
        }

        public override bool canTake(PlayingCard aCard)
        {
            if (isEmpty) { return (aCard.rank == 12); }
            PlayingCard topCard = top;
            return ((aCard.color != topCard.color) &&
                (aCard.rank == topCard.rank - 1));
        }

        public override bool includes(int tx, int ty)
        {
            return ((x <= tx) && (tx <= x + CardView.Width) &&
                    (y <= ty));
        }

        public override void select(int tx, int ty)
        {
            if (isEmpty) { return; }
            // if face down, then flip
            PlayingCard topCard = top;
            if (!topCard.isFaceUp)
            {
                topCard.flip();
                return;
            }
            // else see if any suit pile can take card
            topCard = pop;
            for (int i = 0; i < 4; i++)
            {
                if (Game.suitPile(i).canTake(topCard))
                {
                    Game.suitPile(i).addCard(topCard);
                    return;
                }
            }
            // else see if any other table pile can take card
            for (int i = 0; i < 7; i++)
            {
                if (Game.tableau(i).canTake(topCard))
                {
                    Game.tableau(i).addCard(topCard);
                    return;
                }
            }
            addCard(topCard);
        }

        public override void display(CardView cv)
        {
            Object[] cardArray = pile.ToArray();
            int size = pile.Count;
            int hs = CardView.Height / 2; // half size
            int ty = y;
            for (int i = pile.Count - 1; i >= 0; i--)
            {
                cv.display((PlayingCard)cardArray[i], x, ty);
                ty += hs;
            }
        }
    }
}