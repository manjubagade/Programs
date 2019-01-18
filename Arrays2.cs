//-----------------------------------------------------------------------
// <copyright file="Arrays2.cs" company="CompanyName">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace Functional
{
    using System;

    /// <summary>
    /// this class is used to store array elements 
    /// </summary>
    public class Arrays2
     {
        /// <summary>
        /// Array2s the d.
        /// </summary>
        public void Array2D()
        {
            try
            {
                ////enter the size of row
                Console.WriteLine("enter the values of m");
                int m = Utility.GetInt();
                ////enter the size of coloumn
                Console.WriteLine("enter the values of n");
                int n = Utility.GetInt();
                string[,] a = new string[m, n];
                Console.WriteLine("enter array elementa");
                ////this is used for storing array elements 
                for (int i = 0; i <= m - 1; i++)
                {
                    for (int j = 0; j <= n - 1; j++)
                    {
                        a[i, j] = Console.ReadLine();
                    }
                }
                ////this loop is used for displaying array elements
                for (int i = 0; i <= m - 1; i++)
                {
                    ////for loop for iteration
                    for (int j = 0; j <= n - 1; j++)
                    {
                        Console.Write(a[i, j] + "     ");
                    }

                    Console.WriteLine();
                }

                Console.ReadLine();
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
