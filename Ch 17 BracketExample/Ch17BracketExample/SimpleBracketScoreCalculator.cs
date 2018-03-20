using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ch17BracketExample
{
    class SimpleBracketScoreCalculator : BracketScoreCalculator
    {
        public SimpleBracketScoreCalculator(Bracket actual)
            : base(actual)
        {
        }

        public override int CalculateScore(Bracket picks)
        {
            this.rank = 7;
            return 10;
        }
    }
}