using System;
using System.Collections.Generic;
using System.Text;

namespace CricketSystemCSharp
{
    public class ScorecardController
    {
        private Commentry _commentry;
        private Scorecard _scorecard;
        private ScorecardSevice _scorecardSevice;

        public ScorecardController()
        {
            _commentry = new Commentry();
            _scorecard = new Scorecard();
            _scorecardSevice = new ScorecardSevice();
        }

        public void CalculateScorecard(int run)
        {
            _scorecard.Commentry = _commentry.CommentryLoad(run);
            Scorecard.Run += run;
            Scorecard.Ball++;
            _scorecard.TotalOver = _scorecardSevice.CheckOverStatus();
            _scorecardSevice.DisplayScorecard(_scorecard);
        }
    }
}
