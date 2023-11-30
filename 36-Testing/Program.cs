using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _36_Testing
{
    internal class Program
    {
        // USE THIS FILE FOR TESTING AND EXPERIMENTATION

        static void Main(string[] args)
        {
            // Write your code here
            double x = 1;
            double y = 0;

            for (double i = 0; i > -1; i=x+y)
            {
                Console.WriteLine(i);
                y = x;
                x = i;
                Thread.Sleep(25);
            }


            // Wait for input before ending
            Console.ReadLine();
        }
    }
}
