using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chapter9
{
    /// <summary>
    /// This class defines the behavior to display a playing card
    /// </summary>
    public abstract class CardView
    {
        public abstract void display(PlayingCard aCard, int x, int y);

        public static int Width = 50;
        public static int Height = 70;
    }
}