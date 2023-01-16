using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_11___Football_data_reader.Models
{
    public class Game
    {
        public DateTime Date { get; set; }
        public string HomeTeam { get; set; }
        public string AwayTeam { get; set; }

        private int? homeScore;                 /// making properties nullable (I have older version of c#)
        public int? HomeScore                    
        {
            get { return homeScore; }
            set { homeScore = value; }
        }
        private int? awayScore;

        public int? AwayScore
        {
            get { return awayScore; }
            set { awayScore = value; }
        }
        public string Tournament { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public bool Neutral { get; set; }
    }
}
