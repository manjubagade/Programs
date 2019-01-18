//-----------------------------------------------------------------------
// <copyright file="FlipCoin.cs" company="BridgeLabz">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace Functional
{
    using System;

    /// <summary>
    /// this class is used to find number of heads and tails
    /// this class is used to find number of heads and tails
    /// </summary>
    public class FlipCoin
    {
        /// <summary>
        /// Flips this instance.
        /// </summary>
        public void Flip()
        {
            try
            {
                ////take the input from user for times to flip a coin
                Console.WriteLine("enter number of times to flip");
                int t = Convert.ToInt32(Console.ReadLine());
                Random rd = new Random();
                int h = 0;
                int ta = 0;
                for (int i = 1; i <= t; i++)
                {
                    int val = rd.Next(1, 3);
                    if (val < 1.5)
                    {
                        h++;
                    }
                    else
                    {
                        ta++;
                    }
                }
                //// print valuses of head values 
                Console.WriteLine(h);
                //// print valuss of  tails
                Console.WriteLine(ta);
                Console.WriteLine(" percentage is tails " + ((ta * 100) / t));
                Console.WriteLine(" percentage is heads " + ((h * 100) / t));
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
