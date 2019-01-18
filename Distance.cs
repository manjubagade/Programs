//-----------------------------------------------------------------------
// <copyright file="Distance.cs" company="CompanyName">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace Functional
{
    using System;

    /// <summary>
    /// this class is used to find the distance from point to origin
    /// </summary>
   public class Distance
    {
        /// <summary>
        /// Distances from origin.
        /// </summary>
        public void DistanceToOrigin()
        {
            //// take the values of x from user inputs
            Console.WriteLine("enter the valus of x");
            int x = Utility.GetInt();
            Console.WriteLine("enter the value of y");
            int y = Utility.GetInt();
            double distance = Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));
            ////printing the distance from point to origin
            Console.WriteLine("the distance from origin to point is " + distance);
        }
    }
 }
