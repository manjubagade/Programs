//-----------------------------------------------------------------------
// <copyright file="PrimeFactor.cs" company="bridgelabz">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace Functional
{
    using System;

    /// <summary>
    /// this class is used to find prime factors of a given number
    /// </summary>
    public class PrimeFactor
     {
        /// <summary>
        /// Primes the factors.
        /// </summary>
        public void Prime_Factors()
        {
            try
            {
                //// take the input of user
                Console.WriteLine("enter number to find prime factors");
                int num = Utility.GetInt();
                for (int i = 1; i <= num; i++)
                {
                    int c = 0;
                    for (int j = 1; j <= i; j++)
                    {
                        if (i % j == 0)
                        {
                            c++;
                        }
                    }

                    if (c == 2)
                    {
                        int values = 1;
                        while (num % i == 0)
                        {
                            if (values == 1)
                            {
                                Console.WriteLine(i);
                                values++;
                                    
                            }
                            num=num/i;
                        }
                    }
                }

                Console.ReadLine();
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
