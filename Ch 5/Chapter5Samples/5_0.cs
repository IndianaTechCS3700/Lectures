using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _5_0
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDll.PlayingCard mycard = new MyDll.PlayingCard();
        }
    }
}

namespace MyDll
{
    class PlayingCard
    {
        public int Rank { get; set; }
        public bool isFaceUp { get; set; }

        //private int rank;
        //public int Rank
        //{
        //    get
        //    {
        //        return rank;
        //    }
        //    set
        //    {
        //        rank = value;
        //    }
        //}
    }
}

