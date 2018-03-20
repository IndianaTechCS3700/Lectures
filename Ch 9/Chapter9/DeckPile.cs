using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chapter9
{
    /// <summary>
    /// This represents the pile of cards, randomly shuffle, from which the users draws a card
    /// </summary>
    public class DeckPile : CardPile
    {
        public DeckPile(int x, int y)
            : base(x, y)
        {
            // create the new deck
            // first put cards into a local array
            List<PlayingCard> aList = new List<PlayingCard>();
            for (int i = 0; i <= 12; i++)
            {
                aList.Add(new PlayingCard(Suits.Heart, i));
                aList.Add(new PlayingCard(Suits.Diamond, i));
                aList.Add(new PlayingCard(Suits.Spade, i));
                aList.Add(new PlayingCard(Suits.Club, i));
            }
            // then pull them out randomly
            Random myRandom = new Random();
            for (int count = 0; count < 52; count++)
            {
                int index = myRandom.Next(aList.Count);
                addCard((PlayingCard)aList[index]);
                aList.RemoveAt(index);

            }
        }

        public override void select(int tx, int ty)
        {
            if (isEmpty) { return; }
            Game.discardPile().addCard(pop);
        }
    }
}