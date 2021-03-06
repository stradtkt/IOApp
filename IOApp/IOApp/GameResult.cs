﻿using System;
using System.Collections.Generic;
using System.Text;

namespace IOApp
{
    class GameResult
    {
        public DateTime GameDate { get; set; }
        public string TeamName { get; set; }
        public HomeOrAway HomeOrAway { get; set; }
        public int Goals { get; set; }
        public int GoalAttenpts { get; set; }
        public int ShotsOnGoal { get; set; }
        public int ShotsOffGoal { get; set; }
        public double PossessionPercent { get; set; }
        public double ConversionRate
        {
            get
            {
               return (double)Goals / (double)GoalAttenpts;
            }
        }
    }
    public enum HomeOrAway
    {
        Home,
        Away
    }
}
