using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch_4
{
    class Program
    {
        static void Main(string[] args)
        {
            PlayingCard cardOne = new PlayingCard();
            cardOne.SetRank(1);
            //cardOne.rankValue = 11;
            cardOne.rank = 2;

            PlayingCard cardTwo = new PlayingCard();
            cardTwo.SetRank(2);
        }
    }
}
