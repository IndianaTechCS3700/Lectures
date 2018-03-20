using System;
using System.Windows.Forms;

namespace Ch21
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Text = "Clicked";
            //button1.Text = string.Format("Clicked at {0}", DateTime.Now);
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            button1.Text = "Loaded";
        }

        private void button1_ControlAdded(object sender, ControlEventArgs e)
        {

        }
    }
}