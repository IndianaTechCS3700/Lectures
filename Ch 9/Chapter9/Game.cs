using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chapter9
{
    /// <summary>
    /// This class is responsible for running the game.
    /// </summary>
    public class Game 
    {
        static Game()
        {
            allPiles = new CardPile[13];
            allPiles[0] = new DeckPile(335, 5);
            allPiles[1] = new DiscardPile(268, 5);
            for (int i = 0; i < 4; i++)
            {
                allPiles[2 + i] = new SuitPile(15 + 60 * i, 5);
            }
            for (int i = 0; i < 7; i++)
            {
                allPiles[6 + i] = new TablePile(5 + 55 * i, 80, i + 1);
            }
        }

        public static void paint(CardView cv)
        {
            for (int i = 0; i < 13; i++)
            {
                allPiles[i].display(cv);
            }
        }

        public static void mouseDown(int x, int y)
        {
            for (int i = 0; i < 13; i++)
            {
                if (allPiles[i].includes(x, y))
                {
                    allPiles[i].select(x, y);
                }
            }
        }

        public static CardPile deckPile() { return allPiles[0]; }

        public static CardPile discardPile() { return allPiles[1]; }

        public static CardPile tableau(int index) { return allPiles[6 + index]; }

        public static CardPile suitPile(int index) { return allPiles[2 + index]; }

        private static CardPile[] allPiles;
    }
}

// Note that the array allPiles is declared as an array of CardPile, but holds values from child classes
// When paint is called, the method display invoked will be the appropriate one for each type of pile, not the method in CardPile.
// Similarly, in mouseDown, different piles will use different implementations of includes and select
// Because these methods are static, they can be accessed using only the class name (we saw this earlier). There actually is no instance of Game, only the one class object.