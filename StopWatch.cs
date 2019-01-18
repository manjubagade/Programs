//-----------------------------------------------------------------------
// <copyright file="Stopwatch.cs" company="CompanyName">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace Functional
{
    using System;

    /// <summary>
    /// this class is used to find the elapse time
    /// </summary>
    public class StopWatch
    {
        /// <summary>
        /// The start is used to store the start time
        /// </summary>
        private long starttime;

        /// <summary>
        /// The stop is used to store stop time
        /// </summary>
        private long stoptime;

        /// <summary>
        /// Elapsed the time.
        /// </summary>
        public void ElapsedTime()
        {
            Console.WriteLine("enter 1 to start the time ");
            ////is used to call start time method
            int i = Utility.GetInt();
            if (i == 1)
            {
                this.Start();
            }

            Console.WriteLine("enter 0 to stop the time ");
            ////is used to call stop time method
            int j = Utility.GetInt();
            if (j == 0)
            {
                this.Stop();
            }
            ////printing the elapse time
            Console.WriteLine("elapsed time is " + (this.stoptime - this.starttime));
            Console.ReadLine();
        }

        /// <summary>
        /// Starts this instance.
        /// </summary>
        public void Start()
        {
            ////this in build method is usd to take time from system in milliseconds
            this.starttime = DateTime.Now.Second;
            Console.WriteLine(this.starttime);
        }

        /// <summary>
        /// Stops this instance.
        /// </summary>
        public void Stop()
        {
            this.stoptime = DateTime.Now.Second;
            Console.WriteLine(this.stoptime);
        }
    }
}
