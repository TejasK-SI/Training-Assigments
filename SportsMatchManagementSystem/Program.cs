namespace SportsMatchManagementSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MatchManagement matchManagement = new MatchManagement();
            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("");
                Console.WriteLine("*********Sports Match Details Management System*********");
                Console.WriteLine("");
                Console.WriteLine("1. Add a Match");
                Console.WriteLine("2. Display All Matches");
                Console.WriteLine("3. Display Match by ID");
                Console.WriteLine("4. Update Match Score");
                Console.WriteLine("5. Remove a Match");
                Console.WriteLine("6. Exit");
                Console.WriteLine("");
                Console.WriteLine("********************************************************");
                Console.Write("Enter your choice: ");

                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        // Add a Match
                        Console.WriteLine("Enter match details:");
                        MatchDetails newMatch = new MatchDetails();
                        Console.Write("Match ID: ");
                        newMatch.MatchId = int.Parse(Console.ReadLine());
                        Console.Write("Sport: ");
                        newMatch.Sport = Console.ReadLine();
                        Console.Write("Date and Time (Format : yyyy-MM-dd HH:mm): ");
                        newMatch.MatchDateTime = DateTime.ParseExact(Console.ReadLine(), "yyyy-MM-dd HH:mm", null);
                        Console.Write("Location: ");
                        newMatch.Location = Console.ReadLine();
                        Console.Write("Home Team: ");
                        newMatch.HomeTeam = Console.ReadLine();
                        Console.Write("Away Team: ");
                        newMatch.AwayTeam = Console.ReadLine();
                        Console.Write("Home Team Score: ");
                        newMatch.HomeTeamScore = int.Parse(Console.ReadLine());
                        Console.Write("Away Team Score: ");
                        newMatch.AwayTeamScore = int.Parse(Console.ReadLine());

                        matchManagement.AddMatch(newMatch);
                        break;
                    case 2:
                        // Display All Matches
                        matchManagement.DisplayAllMatches();
                        break;
                    case 3:
                        // Display Match by ID
                        Console.Write("Enter Match ID: ");
                        int matchId = int.Parse(Console.ReadLine());
                        matchManagement.DisplayMatchById(matchId);
                        break;
                    case 4:
                        // Update Match Score
                        Console.Write("Enter Match ID: ");
                        int updateMatchId = int.Parse(Console.ReadLine());
                        Console.Write("Enter Home Team Score: ");
                        int homeTeamScore = int.Parse(Console.ReadLine());
                        Console.Write("Enter Away Team Score: ");
                        int awayTeamScore = int.Parse(Console.ReadLine());
                        matchManagement.UpdateMatchScore(updateMatchId, homeTeamScore, awayTeamScore);
                        break;
                    case 5:
                        // Remove a Match
                        Console.Write("Enter Match ID to remove: ");
                        int removeMatchId = int.Parse(Console.ReadLine());
                        matchManagement.RemoveMatch(removeMatchId);
                        break;
                    case 6:
                        // Exit
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }
    }
}