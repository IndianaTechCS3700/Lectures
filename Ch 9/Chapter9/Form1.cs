using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Chapter9
{
    /// <summary>
    /// This class represents the window that displays the game.
    /// </summary>
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.components = new System.ComponentModel.Container();
            this.Text = "Solitaire";
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(392, 373);
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            Game.mouseDown(e.X, e.Y);
            this.Invalidate(); // force screen redraw
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            Graphics g = pe.Graphics;
            CardView cv = new WinFormsCardView(g);
            Game.paint(cv);
        }
    }
}