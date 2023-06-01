using System;

namespace Stopwatch
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch stopwatch = new Stopwatch();

            try
            {
                stopwatch.Start();
                // Perform some operation or wait for a certain period of time
                System.Threading.Thread.Sleep(2000); // Simulating a delay of 2 seconds
                stopwatch.Stop();
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }

            Console.ReadLine();
        }
    }
}
