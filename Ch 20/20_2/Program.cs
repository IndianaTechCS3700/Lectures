using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _20_2
{
    internal class Team
    {
        public string Name { get; set; }

        public int Seed { get; set; }

        public int TotalPoints { get; set; }
    }

    internal class Program
    {
        private static void Main(string[] args)
        {
            Team team1 = new Team() { Name = "Duke", Seed = 1, TotalPoints = 346 };
            Team team2 = new Team() { Name = "UNC", Seed = 2, TotalPoints = 329 };
            Team team3 = new Team() { Name = "Syracuse", Seed = 3, TotalPoints = 338 };

            List<Team> teams = new List<Team>();

            teams.Add(team3);
            teams.Add(team2);
            teams.Add(team1);

            //teams.Sort();
            //teams.Sort(CompareTeams);
            teams.Sort(new TeamComparer());

            foreach (var item in teams)
            {
                Console.WriteLine(item.Name);
            }

            Console.WriteLine("Press Any Key To Continue");
            Console.ReadKey();
        }

        private static int CompareTeams(Team alpha, Team beta)
        {
            return alpha.Name.CompareTo(beta.Name);
        }
    }

    internal class TeamComparer : IComparer<Team>
    {
        public int Compare(Team x, Team y)
        {
            return x.Seed.CompareTo(y.Seed);
        }
    }
}