﻿using System;
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
    }
}