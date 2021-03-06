﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment01
{

    class Program01
    {

        /// <summary>
        /// Assignment 1 (Console Application)
        /// Several numbers are entered until number 0 is stated.
        /// Calculate and print the average of the positive numbers.
        /// </summary>
        static void Main(string[] args)
        {
            // Use a dot as decimal seperator unaffected by os locale settings
            System.Globalization.CultureInfo customCulture = (System.Globalization.CultureInfo)System.Threading.Thread.CurrentThread.CurrentCulture.Clone();
            customCulture.NumberFormat.NumberDecimalSeparator = ".";
            System.Threading.Thread.CurrentThread.CurrentCulture = customCulture;

            // Declare and set iterator and sum; make loop exitable
            int i = 0;
            int sum = 0;
            int stop = 0;
            
            while (stop == 0)
            {
                // Parse user input
                Console.Write("Enter a number: ");
                string userInput = Console.ReadLine();
                int inputInt = int.Parse(userInput);

                double result = 0;

                // Calculate result once 0 is entered
                if (userInput == "0")
                {
                    // Calculate average of positive inputs
                    if (i != 0)
                    {
                        result = Convert.ToDouble(sum) / Convert.ToDouble(i);
                    }

                    // Output result
                    Console.Write("Average of all positive numbers is: ");
                    Console.WriteLine(result.ToString("0.00"));

                    // Get out of loop
                    stop = 1;
                }

                // Sum up positive inputs
                if (inputInt > 0)
                {
                    i++;
                    sum += inputInt;
                }
            }
            Console.ReadKey();
        }
    }
}
