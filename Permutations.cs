//-----------------------------------------------------------------------
// <copyright file="Permutations.cs" company="CompanyName">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace Functional
{
    using System;

    /// <summary>
    /// this class is used to find the permutations of a given string
    /// </summary>
    public class Permutations
    {
        /// <summary>
        /// Starts the permutation.
        /// </summary>
        public void StartPermutation()
        {
            Console.WriteLine("enter the string ");
            string s = Console.ReadLine();
            Permutation(s.ToCharArray(), 0);
            Console.ReadLine();
        }

        /// <summary>
        /// Swaps the specified character
        /// </summary>
        /// <param name="str"> the character </param>
        /// <param name="i">  the i </param>
        /// <param name="j"> the j </param>
        private static void Swap(char[] str, int i, int j)
        {
            char temp = str[i];
            str[i] = str[j];
            str[j] = temp;
        }

        // Recursive function to generate all permutations of a String  

        /// <summary>
        /// Permutation the specified character
        /// </summary>
        /// <param name="str">The character </param>
        /// <param name="c">Index of the current.</param>
        private static void Permutation(char[] str, int c)
        {
            if (c == str.Length - 1)
            {
                string s = new string(str);
                Console.WriteLine(s);
            }

            for (int i = c; i < str.Length; i++)
            {
                Swap(str, c, i);
                Permutation(str, c + 1);
                Swap(str, c, i);
            }
        }
    }
}
