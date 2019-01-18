//-----------------------------------------------------------------------
// <copyright file="HarmonicNum.cs" company="Brigdelabz">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace Functional
{
    using System;

    /// <summary>
    /// this class is used to generate harmonic numbers
    /// </summary>
    public class Harmonicnum
    {
        /// <summary>
        /// Harmonics this instance.
        /// </summary>
        public void Harmonic()
        {
            try
            {
                //// take the number of user of up to nth harmonic 
                Console.WriteLine("enter the Nth harmonic number");
                int n = Utility.GetInt();
                float num = 0;
                for (int i = 1; i <= n; i++)
                {
                    //// calculate the values of given number
                    num = num + (float)(1.0 / i);
                }
                //// printed the values for upto to given number
                Console.WriteLine(" the Nth harmonic number is " + num);
                Console.ReadLine();
            }
            catch (NotFiniteNumberException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
