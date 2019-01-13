﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace IOApp
{

    public class Rootobject
    {
        public Player[] Player { get; set; }
    }

    public class Player
    {
        [JsonProperty(PropertyName = "first_name")]
        public string FirstName { get; set; }
        [JsonProperty(PropertyName = "id")]
        public int Id { get; set; }
        [JsonProperty(PropertyName = "points_per_game")]
        public string points_per_game { get; set; }
        [JsonProperty(PropertyName = "second_name")]
        public string SecondName { get; set; }
        [JsonProperty(PropertyName = "team_name")]
        public string TeamName { get; set; }
        [JsonProperty(PropertyName = "total_points")]
        public int TotalPoints { get; set; }
    }

}
