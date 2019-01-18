//-----------------------------------------------------------------------
// <copyright file="LeapYear.cs" company="Bridgelabz">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace Functional
{
    using System;

    /// <summary>
    /// this class is used to find whether the given year is a leap year or not
    /// </summary>
    public class LeapYear
    {
        /// <summary>
        /// Leap year this instance.
        /// </summary>
        public void Leapyear()
        {
            try
            { 
                //// take the user to four digit num
                Console.WriteLine("enter year with four digits");
                string year = Console.ReadLine();
                //// if check the length of year
                if (year.Length == 4)
                {
                    int num = Convert.ToInt32(year);
                    if (((num % 4 == 0) && (num % 100 != 0)) || (num % 400 == 0))
                    {
                        //// print the year for given input
                        Console.WriteLine(num + " is a leap year");
                    }
                    else
                    {
                        //// print the year for given input
                        Console.WriteLine(num + " is not a leap year");
                    }
                }
                else
                { 
                    //// if year length length is not properly then print is message
                    Console.WriteLine("enter correct date");
                }

                Console.ReadLine();
            }
            catch (Exception e)
            { 
                Console.Write(e.Message);
            }
        }
    }
}
