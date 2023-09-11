using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsMatchManagementSystem
{
    internal class MatchManagement
    {
        private List<MatchDetails> matches = new List<MatchDetails>();

        public void AddMatch(MatchDetails match)
        {
            // Validate match properties before adding
            if (IsValidMatch(match))
            {
                matches.Add(match);
                Console.WriteLine("Match added successfully!");
            }
            else
            {
                Console.WriteLine("Match validation failed. Match not added.");
            }
        }

        public void DisplayAllMatches()
        {
            Console.WriteLine("List of matches:");
            foreach (var match in matches)
            {
                DisplayMatch(match);
            }
        }

        public void DisplayMatchById(int matchId)
        {
            var match = matches.FirstOrDefault(m => m.MatchId == matchId);
            if (match != null)
            {
                DisplayMatch(match);
            }
            else
            {
                Console.WriteLine("Match not found with the given ID.");
            }
        }

        public void UpdateMatchScore(int matchId, int homeTeamScore, int awayTeamScore)
        {
            var match = matches.FirstOrDefault(m => m.MatchId == matchId);
            if (match != null)
            {
                match.HomeTeamScore = homeTeamScore;
                match.AwayTeamScore = awayTeamScore;
                Console.WriteLine("Match scores updated successfully.");
            }
            else
            {
                Console.WriteLine("Match not found with the given ID. Score updation failed.");
            }
        }

        public void RemoveMatch(int matchId)
        {
            var match = matches.FirstOrDefault(m => m.MatchId == matchId);
            if (match != null)
            {
                matches.Remove(match);
                Console.WriteLine("Match removed successfully!");
            }
            else
            {
                Console.WriteLine("Match not found for given ID.");
            }
        }

        private bool IsValidMatch(MatchDetails match)
        {
            // Implement validation logic based on the criteria mentioned
            // You can add additional checks as needed
            if (match.MatchId <= 0 || matches.Any(m => m.MatchId == match.MatchId))
                return false;

            if (string.IsNullOrWhiteSpace(match.Sport))
                return false;

            if (match.MatchDateTime <= DateTime.Now)
                return false;

            if (string.IsNullOrWhiteSpace(match.Location))
                return false;

            if (string.IsNullOrWhiteSpace(match.HomeTeam) || string.IsNullOrWhiteSpace(match.AwayTeam) || match.HomeTeam == match.AwayTeam)
                return false;

            if (match.HomeTeamScore < 0 || match.AwayTeamScore < 0)
                return false;

            return true;
        }

        private void DisplayMatch(MatchDetails match)
        {
            Console.WriteLine("*******Match Details*******");
            Console.WriteLine($"Match ID: {match.MatchId}");
            Console.WriteLine($"Sport: {match.Sport}");
            Console.WriteLine($"Date & Time: {match.MatchDateTime}");
            Console.WriteLine($"Venue: {match.Location}");
            Console.WriteLine($"Home Team: {match.HomeTeam}");
            Console.WriteLine($"Home Team Score: {match.HomeTeamScore}");
            Console.WriteLine($"Away Team: {match.AwayTeam}");
            Console.WriteLine($"Away Team Score: {match.AwayTeamScore}");
            Console.WriteLine("***************************");
            Console.WriteLine();
        }
    }
}
