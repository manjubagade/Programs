//-----------------------------------------------------------------------
// <copyright file="Quedratic.cs" company="bridgelabz">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace Functional
{
    using System;

    /// <summary>
    /// this class is used for finding quadratic equation roots
    /// </summary>
    public class Quedratic
    {
        /// <summary>
        /// Roots this instance.
        /// </summary>
        public void Roots()
        {
            try
            {
                ////taking the value of a from console
                Console.WriteLine("entee the value of A");
                double a = Utility.GetDouble();
                ////taking the value of b from console
                Console.WriteLine("enter the value of B");
                double b = Utility.GetDouble();
                ////taking the value of c from console
                Console.WriteLine("enter the values of C");
                double c = Utility.GetDouble();
                ////formula to calculate b*b - 4*a*c
                Console.WriteLine("Quadratic equation: " + a + "x*X" + " + " + b + "x" + "+" + c);
                ////Calculate the discriminants
                double delta = (b * b) - (4 * a * c);
                ////For calculating roots we have to cal sqrt of discriminants
                ////so here we have used static methods to cal sqrt of math class
                double d = Math.Sqrt(delta);
                Console.WriteLine("delta values " + delta);
                ////formula to cal roots of quadratic equations
                double root1 = (-b + d) / (2 * a);
                double root2 = (-b - d) / (2 * a);
                Console.WriteLine("Root1 = " + root1);
                Console.WriteLine("Root2 = " + root2);
            } 
            catch (Exception e)
                {
                Console.WriteLine(e.Message);
            }
        }
    }
}
