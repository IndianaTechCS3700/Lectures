using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch_4
{
    enum Suits { Spade, Diamond, Club, Heart };

    class PlayingCard
    {
        public Suits suit() { return suitValue; }
        //public int rank() { return rankValue; }
        public int rank
        {
            get { return rank; }
            set { rank = value; }
        }
        public void SetRank (int rank)
        {
            rankValue = rank;
        }
        private Suits suitValue;
        private int rankValue;
    }

}
