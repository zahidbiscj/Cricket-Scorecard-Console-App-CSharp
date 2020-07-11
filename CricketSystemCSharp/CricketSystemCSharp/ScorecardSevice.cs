using System;
using System.Collections.Generic;
using System.Text;

namespace CricketSystemCSharp
{
    public class ScorecardSevice
    {
        public void DisplayScorecard(Scorecard scorecard)
        {
            Console.WriteLine($"Commentry : {scorecard.Commentry} \nRun = {Scorecard.Run}\nWicket = {Scorecard.Wicket}");
            Console.WriteLine($"Total Score : {Scorecard.Run}/{Scorecard.Wicket} {scorecard.TotalOver} Overs");
        }

        public string CheckOverStatus()
        {
            if (Scorecard.Ball == 6)
            {
                Scorecard.Over++;
                Scorecard.Ball = 0;
            }
            return $"{Scorecard.Over}.{Scorecard.Ball}";
        }

        public void CheckExtrasGiven(ExtrasEnum extras)
        {
            if(extras != ExtrasEnum.NoExtras)
            {
                Scorecard.Run++;
            }
            else
            {
                Scorecard.Ball++;
            }
        }

        public void WicketGoneStatus(WicketEnum wicket)
        {
            // Runout hole out othoba jodi Noball Na hoy ebong kono wicket zay taile out
            if((wicket == WicketEnum.RunOut) || (Scorecard.IsNoBall == false) && !(wicket == WicketEnum.NotOut))
            {
                Scorecard.Wicket++;
            }
        }

        public void PreviousBallExtrasGiven(ExtrasEnum extras)
        {
            // (Jodi noball hoy ) || (Noball Jodi thake + Wide hoy)
            if(extras == ExtrasEnum.NoBall || (Scorecard.IsNoBall == true  && extras == ExtrasEnum.Wide))
            {
                Scorecard.IsNoBall = true;
            }
            // Jodi ager ball noball na hoy ebong ei ball wide ba noball na hoy taile noball false 
            if(!(Scorecard.IsNoBall == true) && (extras == ExtrasEnum.Wide) ||(extras == ExtrasEnum.NoBall))
            {
                Scorecard.IsNoBall = false;
            }
        }
    }
}
