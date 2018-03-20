using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _6_Observer
{
    class DataProvider
    {
        public event EventHandler DataChanged;

        private int myValue;
        public int MyProperty
        {
            get
            { 
                return myValue; 
            }
            set 
            {
                if (value != myValue)
                {
                    myValue = value;
                    if (DataChanged != null)
                    {
                        DataChanged(this, EventArgs.Empty);
                    }
                }
                
            }
        }
    }


    class Observer
    {
        static void Main(string[] args)
        {
            DataProvider dp = new DataProvider();
            dp.DataChanged += new EventHandler(dp_DataChanged);
            dp.DataChanged += new EventHandler(dp_DataChanged2);

        }

        static void dp_DataChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        static void dp_DataChanged2(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }


    class Logger
    {
        public void Log(object sender, EventArgs e) { }
    }


    class Test
    {
        public void DoSomething(object sender, EventArgs e) { }

        public void Main()
        {
            DataProvider dp = new DataProvider();
            dp.DataChanged += new EventHandler(DoSomething);

            Logger L = new Logger();
            dp.DataChanged += new EventHandler(L.Log);
        }


    }
}
