using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ch17BracketExample
{
    abstract class BracketScoreCalculator
    {
        private BracketScoreCalculator() { }

        protected int rank = 0;

        Bracket actual;

        public BracketScoreCalculator(Bracket actual)
        {
            this.actual = actual;
        }

        public abstract int CalculateScore(Bracket picks);
    }
}