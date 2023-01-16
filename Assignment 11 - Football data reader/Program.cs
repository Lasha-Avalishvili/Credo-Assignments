using System;
using System.Linq;

namespace Assignment_11___Football_data_reader
{
    class Program
    {
        static void Main(string[] args)
        {
            var filePath = "/Users/lenno/Desktop/football_results.csv";
            var reader = new FootballDataReader();
            var games = reader.Read(filePath);

            

        }
    }
}
