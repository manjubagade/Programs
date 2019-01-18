//-----------------------------------------------------------------------
// <copyright file="AddToZeros.cs" company="bridgelabz">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace Functional
{
    using System;

    /// <summary>
    /// this class is used to add the three numbers in array 
    /// </summary>
    public class AddToZeros
    {
        /// <summary>
        /// Add3s the numbers to zero.
        /// </summary>
        public void Add3NumbersToZero()
        {
            try
            {
                Console.WriteLine("enter the number of elements");
                int num = Utility.GetInt();
                int[] array = new int[num];
                ////taking the array elements from console
                Console.WriteLine("enter array elements");
                ////this loop is used for storing the array elements
                for (int i = 0; i < num; i++)
                {
                    array[i] = Utility.GetInt();
                }

                int sum = 0;
                for (int i = 0; i < num; i++)
                {
                    for (int j = 0; j < num - 1; j++)
                    {
                        for (int k = 0; k < num - 2; k++)
                        {
                            if (array[i] + array[j] + array[k] == 0)
                            {
                                sum++;
                                Console.WriteLine(" distinct   triplets " + array[i] + "," + array[j] + "," + array[k]);
                            }
                        }
                    }
                }

                Console.WriteLine();
                Console.WriteLine("number of distinct triplets " + sum);
                Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}