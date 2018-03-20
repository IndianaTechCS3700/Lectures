using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _3_Proxy
{
    class DataProvider
    {
        virtual public int GetData()
        {
            return 309134708;
        }
    }

    class NetworkDataProviderProxy : DataProvider
    {
        override public int GetData()
        {
            int value = 1234;

            // Establish server connection
            // Get Value from server
            // Check 

            return value;
        }

    }

    class Proxy
    {
        static void Main(string[] args)
        {
            //DataProvider dp = DataProviderFacotry.GetDataProvider();

            //dp.GetData();
        }
    }
}


// Can look similar to adapter and decorator