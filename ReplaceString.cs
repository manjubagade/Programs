//-----------------------------------------------------------------------
// <copyright file="ReplaceString.cs" company="CompanyName">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace Functional
{
    using System;

    /// <summary>
    /// this class is used to replace a string 
    /// </summary>
     public class ReplaceString
    {
        /// <summary>
        /// Replaces the string1.
        /// </summary>
         public void ReplaceString1()
        {
            try
            {
                Console.WriteLine("ENTER THE NAME TO BE REPLACE");
                //// take the string input from user
                string name = Console.ReadLine();
                string msg = "Hello <<UserName>>, How are you?";
                string fullMsg = msg.Replace("<<UserName>>", name);
                ////it will print the string that is replaced with "<<UserName>>"
                Console.WriteLine(fullMsg);
                Console.ReadLine();
            }
               catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
