//-----------------------------------------------------------------------
// <copyright file="Program.cs" company="Bridgelabz">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace Functional
{
     using System;

    /// <summary>
    /// this class is used to run all the programs
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Defines the entry point of the application
        /// </summary>
        /// <param name="args">The arguments.</param>
      public static void Main(string[] args)
        {
            char condition;
            do
            {
                Console.WriteLine("PRESS 1   :   TO REPLACE THE STRING NAME");
                Console.WriteLine("PRESS 2   :   TO FLIPCOIN THE NUMBER");
                Console.WriteLine("PRESS 3   :   TO ENTER THE YEAP YEAR");
                Console.WriteLine("PRESS 4   :   TO  ENTER POWER OF 2");
                Console.WriteLine("PRESS 5   :   TO ENTER THE NUMBER TO HARMONIC");
                Console.WriteLine("PRESS 6   :   TO ENTER THE NUMBER TO PRIMEFACOR");
                Console.WriteLine("PRESS 7   :   TO ENTER THE NUMBERS OF GAMBLERS");
                Console.WriteLine("PRESS 8   :   TO ENTER THE COUPONS NUMBER");
                Console.WriteLine("PRESS 9   :   TO ENTER THE ARRAYS ELEMENTS");
                Console.WriteLine("PRESS 10  :   SUM OF THREE DIGIT ADD INTO ZEROS");
                Console.WriteLine("PRESS 11  :   FINDING THE DISTANCE FROM POINT TO ORIGION");
                Console.WriteLine("PRESS 12  :   FINDING THE PERMUTATIONS STRING");
                Console.WriteLine("PRESS 13  :   TO STOPWATCH");
                Console.WriteLine("PRESS 14  :   TO TIK TOC PROBLES ");
                Console.WriteLine("PRESS 15  :   TO QUEDRATIC ROOT");
                Console.WriteLine("PRESS 16  :   TO Windchill prg");
                int num = Convert.ToInt32(Console.ReadLine());
                switch (num)
                {
                    case 1:
                        ReplaceString rs = new ReplaceString();
                        rs.ReplaceString1();
                        break;
                    case 2:
                        FlipCoin fp = new FlipCoin();
                        fp.Flip();
                        break;
                    case 3:
                        LeapYear lp = new LeapYear();
                        lp.Leapyear();
                        break;
                    case 4:
                        PowerOf2 p2 = new PowerOf2();
                        p2.PowersOf2();
                        break;
                    case 5:
                        Harmonicnum hn = new Harmonicnum();
                        hn.Harmonic();
                        break;
                    case 6:
                        PrimeFactor pf = new PrimeFactor();
                        pf.Prime_Factors();
                        break;
                    case 7:
                        Gamblers g = new Gamblers();
                        g.Gambler1();
                        break;
                    case 8:
                        Coupons cp = new Coupons();
                        cp.CouponNum();
                        break;
                    case 9:
                        Arrays2 arr = new Arrays2();
                        arr.Array2D();
                        break;
                    case 10:
                        AddToZeros atz = new AddToZeros();
                        atz.Add3NumbersToZero();
                        break;
                    case 11:
                        Distance d = new Distance();
                        d.DistanceToOrigin();
                        break;
                    case 12:
                        Permutations pr = new Permutations();
                        pr.StartPermutation();
                        break;
                    case 13:
                        StopWatch sw = new StopWatch();
                        sw.ElapsedTime();
                        break;
                    case 14:
                        TicTacToe ttt = new TicTacToe();
                        ttt.TicTocToeGame();
                        break;
                    case 15:
                        Quedratic qd = new Quedratic();
                        qd.Roots();
                        break;
                    case 16:
                        WindChill wc = new WindChill();
                        wc.CalculateWindChill();
                        break;
                        }

                Console.WriteLine("ENTER Y TO CONTINUES N TO STOP ");
                condition = Convert.ToChar(Console.ReadLine());
            }
            while (condition == 'y');
        }
    }
}
