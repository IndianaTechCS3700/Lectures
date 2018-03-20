using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Ch21
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
            //Application.Run(new Form());

            double val = Math.Sqrt(42d);


            string myString = String.Format("{0} {1}", "one"
                ,"two" ,"two" ,"two" ,"two" ,"two" ,"two" ,"two" ,"two" ,"two" ,"two" ,"two" ,"two" ,"two" ,"two" ,"two" ,"two" ,"two" ,"two" ,"two" ,"two" ,"two" ,"two" ,"two" ,"two" ,"two" ,"two" ,"two" ,"two" ,"two" ,"two" ,"two" ,"two" ,"two" ,"two" ,"two" ,"two" ,"two" ,"two" ,"two" ,"two" ,"two" ,"two" ,"two" ,"two" ,"two" ,"two" ,"two" ,"two" ,"two" ,"two" ,"two" ,"two" ,"two" ,"two" ,"two" ,"two" ,"two" ,"two" ,"two" ,"two" ,"two" ,"two" ,"two" ,"two" ,"two" ,"two" ,"two" ,"two" ,"two" ,"two" ,"two" ,"two" ,"two" ,"two" ,"two" ,"two" ,"two" ,"two" ,"two" ,"two" ,"two" ,"two" ,"two" ,"two" ,"two" ,"two" ,"two" ,"two" ,"two" ,"two"
                ,"two"
                ,"two"
                ,"two"
                ,"two"
                ,"two"
                ,"two"
                ,"two"
                ,"two"
                ,"two"
                ,"two"
                ,"two"
                ,"two"
                ,"two"
                ,"two"
                ,"two"
                ); 
        }
    }
}
