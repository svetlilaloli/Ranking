using System;
using System.Collections.Generic;
using System.Linq;

namespace Ranking
{
    class Ranking
    {
        static void Main()
        {
            string command = Console.ReadLine();
            Dictionary<string, string> contests = new Dictionary<string, string>();
            Dictionary<string, Dictionary<string, int>> users = new Dictionary<string, Dictionary<string, int>>();

            while (command != "end of contests")
            {
                string[] currentContest = command.Split(':');
                string contest = currentContest[0];
                string password = currentContest[1];

                if (!contests.ContainsKey(contest))
                {
                    contests.Add(contest, password);
                }

                command = Console.ReadLine();
            }
            command = Console.ReadLine();
            while (command != "end of submissions")
            {
                string[] submission = command.Split(new char[] { '=', '>' }, StringSplitOptions.RemoveEmptyEntries);
                string contest = submission[0];
                string password = submission[1];
                string user = submission[2];
                int points = int.Parse(submission[3]);

                if (contests.ContainsKey(contest))
                {
                    if (contests[contest] == password)
                    {
                        if (users.ContainsKey(user))
                        {
                            if (users[user].ContainsKey(contest))
                            {
                                if (users[user][contest] < points)
                                {
                                    users[user][contest] = points;
                                }
                            }
                            else
                            {
                                users[user].Add(contest, points);
                            }
                        }
                        else
                        {
                            users.Add(user, new Dictionary<string, int>());
                            users[user].Add(contest, points);
                        }
                    }
                }
                command = Console.ReadLine();
            }

            int totalPoints = users.Values.Max(x => x.Values.Sum());
            string bestCandidate = " ";

            foreach (var user in users)
            {
                int points = user.Value.Values.Sum();
                if (points == totalPoints)
                {
                    bestCandidate = user.Key;
                }
            }

            Console.WriteLine($"Best candidate is {bestCandidate} with total {totalPoints} points.");
            Console.WriteLine("Ranking:");
            foreach (var user in users.OrderBy(x => x.Key))
            {
                Console.WriteLine(user.Key);
                foreach (var contest in user.Value.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"#  {contest.Key} -> {contest.Value}");
                }
            }
        }
    }
}
