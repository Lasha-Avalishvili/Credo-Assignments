using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Assignment_11___Football_data_reader.Models;

namespace Assignment_11___Football_data_reader
{
    class FootballDataReader
    {
        public List<Game> Read(string filePath)
        {
            var lines = ReadLines(filePath);
            var games = ConvertToGamesList(lines);
            return games;
        }
        private string[] ReadLines(string filePath)
        {
            return File.ReadAllLines(filePath);
        }

        private List<Game> ConvertToGamesList (string[] lines)
        {
            var games = new List<Game>();
            for (int i = 1; i < lines.Length; i++)
            {
                var line = lines[i];
                var game = ConvertToGame(line);
                games.Add(game);

            }
            return games;
        }
        private Game ConvertToGame(string line)
        {
            var separators = new char[] { ',', ';' };
            var lineParts = line.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            if(lineParts[3] == "NA" || lineParts[4] == "NA")
            {
                return null;
            }


            var game1 = new Game();
            game1.Date = DateTime.ParseExact(lineParts[0], "yyyy-MM-dd", null);   /*Convert.ToDateTime(lineParts[0]);*/
            game1.HomeTeam = lineParts[1];
            game1.AwayTeam = lineParts[2];
            game1.Tournament = lineParts[5];
            game1.City = lineParts[6];
            game1.Country = lineParts[7];
            game1.Neutral = lineParts[8] == "TRUE" ? true : false;

            if (int.TryParse(lineParts[3], out var homeScore)) 
            {
                game1.HomeScore = homeScore;
            }

            if (int.TryParse(lineParts[4], out var awayScore))
            {
                game1.AwayScore = awayScore;
            }

            return game1;
        }

    }
}
