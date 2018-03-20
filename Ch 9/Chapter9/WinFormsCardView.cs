using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace Chapter9
{
    /// <summary>
    /// This class defines the behavior to display a playing card using the Windows Forms API.
    /// </summary>
    public class WinFormsCardView : CardView
    {
        private Graphics g;

        public WinFormsCardView(Graphics aGraphicsObject)
        {
            g = aGraphicsObject;
        }

        public override void display(PlayingCard aCard, int x, int y)
        {
            if (aCard == null)
            {
                Pen myPen = new Pen(Color.Black, 2);
                Brush myBrush = new SolidBrush(Color.White);
                g.FillRectangle(myBrush, x, y, CardView.Width, CardView.Height);
                g.DrawRectangle(myPen, x, y, CardView.Width, CardView.Height);
            }
            else
            {
                paintCard(aCard, x, y);
            }
        }

        private void paintCard(PlayingCard aCard, int x, int y)
        {
            String[] names = { "A", "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K" };

            Pen myPen = new Pen(Color.Black, 2);
            Brush myBrush = new SolidBrush(Color.White);

            g.FillRectangle(myBrush, x, y, CardView.Width, CardView.Height);
            g.DrawRectangle(myPen, x, y, CardView.Width, CardView.Height);
            myPen.Dispose();
            myBrush.Dispose();

            if (aCard.isFaceUp)
            {
                if (aCard.color == Color.Red)
                {
                    myPen = new Pen(Color.Red, 1);
                    myBrush = new SolidBrush(Color.Red);
                }
                else
                {
                    myPen = new Pen(Color.Black, 1);
                    myBrush = new SolidBrush(Color.Black);
                }

                g.DrawString(names[aCard.rank], new Font("Times new Roman", 10), myBrush, x + 3, y + 7);

                if (aCard.suit == Suits.Heart)
                {
                    g.DrawLine(myPen, x + 25, y + 30, x + 35, y + 20);
                    g.DrawLine(myPen, x + 35, y + 20, x + 45, y + 30);
                    g.DrawLine(myPen, x + 45, y + 30, x + 25, y + 60);
                    g.DrawLine(myPen, x + 25, y + 60, x + 5, y + 30);
                    g.DrawLine(myPen, x + 5, y + 30, x + 15, y + 20);
                    g.DrawLine(myPen, x + 15, y + 20, x + 25, y + 30);
                }
                else if (aCard.suit == Suits.Spade)
                {
                    g.DrawLine(myPen, x + 25, y + 20, x + 40, y + 50);
                    g.DrawLine(myPen, x + 40, y + 50, x + 10, y + 50);
                    g.DrawLine(myPen, x + 10, y + 50, x + 25, y + 20);
                    g.DrawLine(myPen, x + 23, y + 45, x + 20, y + 60);
                    g.DrawLine(myPen, x + 20, y + 60, x + 30, y + 60);
                    g.DrawLine(myPen, x + 30, y + 60, x + 27, y + 45);
                }
                else if (aCard.suit == Suits.Diamond)
                {
                    g.DrawLine(myPen, x + 25, y + 20, x + 40, y + 40);
                    g.DrawLine(myPen, x + 40, y + 40, x + 25, y + 60);
                    g.DrawLine(myPen, x + 25, y + 60, x + 10, y + 40);
                    g.DrawLine(myPen, x + 10, y + 40, x + 25, y + 20);
                }
                else if (aCard.suit == Suits.Club)
                {
                    g.DrawEllipse(myPen, x + 20, y + 25, 10, 10);
                    g.DrawEllipse(myPen, x + 25, y + 35, 10, 10);
                    g.DrawEllipse(myPen, x + 15, y + 35, 10, 10);
                    g.DrawLine(myPen, x + 23, y + 45, x + 20, y + 55);
                    g.DrawLine(myPen, x + 20, y + 55, x + 30, y + 55);
                    g.DrawLine(myPen, x + 30, y + 55, x + 27, y + 45);
                }
            }
            else //face down
            {
                myPen = new Pen(Color.Green, 1);
                myBrush = new SolidBrush(Color.Green);

                g.DrawLine(myPen, x + 15, y + 5, x + 15, y + 65);
                g.DrawLine(myPen, x + 35, y + 5, x + 35, y + 65);
                g.DrawLine(myPen, x + 5, y + 20, x + 45, y + 20);
                g.DrawLine(myPen, x + 5, y + 35, x + 45, y + 35);
                g.DrawLine(myPen, x + 5, y + 50, x + 45, y + 50);
            }
        }
    }
}