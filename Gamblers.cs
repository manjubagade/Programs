//-----------------------------------------------------------------------
// <copyright file="Gamblers.cs" company="CompanyName">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace Functional
{
    using System;

    /// <summary>
    /// this class is used to find wins percentage 
    /// </summary>
    public class Gamblers
    {
        /// <summary>
        /// Gambler1s this instance.
        /// </summary>
        public void Gambler1()
        {
            try
            {
                //// take the values of stake from user
                Console.WriteLine("enter the values of stake");
                int stake = Utility.GetInt();
                //// take the values of goals from user
                Console.WriteLine("enter the values of goal");
                int goal = Utility.GetInt();
                //// take the values of times from user 
                Console.WriteLine("enter the values of times");
                int trials = Utility.GetInt();
                //// initial values of bets
                int bets = 0;
                //// initial values of wins
                int wins = 0;
                //// initial values of loose
                int loose = 0;
                //// creting the  random object
                Random r = new Random();
                for (int i = 0; i <= trials; i++)
                {
                    int cash = stake;
                    while (cash > 0 && cash < goal)
                    {
                        bets++;
                        if (r.Next(0, 2) < 0.5)
                        {
                            cash--;
                        }
                        else
                        {
                            cash++;
                        }
                    }

                    if (cash == goal)
                    {
                        wins++;
                    }
                    else
                    {
                        loose++;
                    }
                }
                //// print the values of wins and trilas
                Console.WriteLine(wins + " wins of " + trials);
                //// print the values of games wons parcetagess
                Console.WriteLine(" percentage of games wons " + ((100.0 * wins) / trials));
                //// print the values of games loose parcetages
                Console.WriteLine(" percentage of games loose " + ((100.0 * loose) / trials));
                //// printed the avarage of gamblers game
                Console.WriteLine(" average # bets " + ((1.0 * bets) / trials));
                Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
