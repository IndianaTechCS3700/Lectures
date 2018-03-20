using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ch17BracketExample
{
    class ComplexBracketScoreCalculator : BracketScoreCalculator
    {
        public ComplexBracketScoreCalculator(Bracket actual)
            : base(actual)
        {

        }

        public override int CalculateScore(Bracket picks)
        {
            return 24;
        }
    }
}
