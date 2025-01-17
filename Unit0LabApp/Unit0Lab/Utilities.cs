using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit0Lab
{
    /// <summary>
    /// a repository of static methods for reading data and useful calculation
    /// </summary>
    internal static class Utilities
    {
        /// <summary>
        /// reads positive decimal value
        /// </summary>
        /// <param name="prompt">name used in error messages</param>
        /// <returns>positive decimal</returns>
        public static decimal GetPositiveDecimal(string prompt)
        {
            bool gotIt = false;
            decimal result = 0;
            string input;
            while (!gotIt) // loops while gotIt is false
            {
                Console.WriteLine($"Enter {prompt}:"); // interpolated string
                input = Console.ReadLine() ?? "";
                if (Decimal.TryParse(input, out result))
                //if parse successful, the resulting value is put in the second
                //  arg and true returned
                //if not successful, returns false
                {
                    if (result > 0)
                    {
                        gotIt = true; // success
                    }
                    else
                    {
                        Console.WriteLine($"Error: {prompt} must be positive");
                    }
                }
                else // not a decimal
                {
                    Console.WriteLine($"Error: {prompt} must be a number");
                }
            }
            return result;
        }

        /// <summary>
        /// reads positive int value
        /// </summary>
        /// <param name="prompt">name used in error messages</param>
        /// <returns>positive int</returns>
        public static int GetPositiveInt(string prompt)
        {
            bool gotIt = false;
            int result = 0;
            string input;
            while (!gotIt) // loops while gotIt is false
            {
                Console.WriteLine($"Enter {prompt}:"); // interpolated string
                input = Console.ReadLine() ?? "";
                if (Int32.TryParse(input, out result))
                //if parse successful, the resulting value is put in the second
                //  arg and true returned
                //if not successful, returns false
                {
                    if (result > 0)
                    {
                        gotIt = true; // success
                    }
                    else
                    {
                        Console.WriteLine($"Error: {prompt} must be positive");
                    }
                }
                else // not an int
                {
                    Console.WriteLine($"Error: {prompt} must be a whole number");
                }
            }
            return result;
        }

        /// <summary>
        /// reads int value within range
        /// </summary>
        /// <param name="prompt">name used in error messages</param>
        /// <param name="minValue">minimum value for the range</param>
        /// <param name="maxValue">maximum value for the range</param>
        /// <returns>int value in range</returns>
        public static int GetIntInRange(string prompt, int minValue, int maxValue)
        {
            bool gotIt = false;
            int result = 0;
            string input;
            while (!gotIt) // loops while gotIt is false
            {
                Console.WriteLine($"Enter {prompt}:"); // interpolated string
                input = Console.ReadLine() ?? "";
                if (Int32.TryParse(input, out result))
                //if parse successful, the resulting value is put in the second
                //  arg and true returned
                //if not successful, returns false
                {
                    if (result >= minValue && result <= maxValue)
                    {
                        gotIt = true; // success
                    }
                    else
                    {
                        if (maxValue == Int32.MaxValue)
                            Console.WriteLine($"Error: {prompt} must be greater than or equal to {minValue}");
                        else if (minValue == Int32.MinValue)
                            Console.WriteLine($"Error: {prompt} must be less than or equal to {maxValue}");
                        else
                            Console.WriteLine($"Error: {prompt} must be between {minValue} and {maxValue}");
                    }
                }
                else // not an int
                {
                    Console.WriteLine($"Error: {prompt} must be a whole number");
                }
            }
            return result;
        }

    }// class
}// namespace