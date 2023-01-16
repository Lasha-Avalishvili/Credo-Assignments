using Assignment_11___Football_data_reader.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment_11___Football_data_reader
{
    class GameStatService
    {
        public void Calculate(List<Game> games)
        {
            CalculateCounts(games);
            CalculateTopTenScores(games);
        }

        private void CalculateTopTenScores(List<Game> games)
        {
            throw new NotImplementedException();
        }

        private static void CalculateCounts(List<Game> games)
        {
            var finishedGames = games.Count(g => g != null && g.AwayScore.HasValue && g.HomeScore.HasValue);
            var unfinishedGames = games.Count - finishedGames;
            Console.WriteLine($"Total finished games: {finishedGames}");
            Console.WriteLine($"Total unfinished games: {unfinishedGames}");
        }

    }
}
