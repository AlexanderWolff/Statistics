using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Statistics
{
    class Mathematics
    {

        /// <summary>
        /// Returns array of length n containing random values bounded by specified limits 
        /// </summary>
        /// <param name="n">Length of list to be generated</param>
        /// <param name="low">Lower limit</param>
        /// <param name="high">Upper limit</param>
        public static double[] generateRandom(int n, int low, int high)
        {
            //Instantiate random value generator
            Random randomGenerator = new Random();

            //Populate list
            double[] numbers = new double[n];
            for (int i = 0; i < n; i++)
            {
                //Generate random integer
                numbers[i] = low+(randomGenerator.NextDouble()*high);
            }

            return numbers;
        }

        /// <summary>
        /// Returns the sum of a list of integer
        /// </summary>
        private static double calculateSum(List<double> integers)
        {
            double sum = 0;
            foreach(double integer in integers)
            {
                sum += integer;
            }

            return sum;
        }

        /// <summary>
        /// Returns the arithmetic sum of a list of integers
        /// </summary>
        public static double calculateMean(List<double> integers)
        {
            double sum = calculateSum(integers);

            double mean = sum / integers.Count;

            return mean;
        }

        /// <summary>
        /// Returns the square of the input number
        /// </summary>
        private static double square(double input)
        {
            return input * input;
        }

        /// <summary>
        /// Returns the varience of a list of integers
        /// </summary>
        private static double calculateVarience(List<double> numbers)
        {
            //Find Mean
            double mean = calculateMean(numbers);

            //Find each deviation
            List<double> deviations = new List<double>();

            foreach(double number in numbers)
            {
                double deviation = number - mean;

                deviations.Add( square(deviation) );
            }

            //return varience
            return calculateMean(deviations);
        }


        /// <summary>
        /// Returns the standard deviation of a list of integers
        /// https://en.wikipedia.org/wiki/Standard_deviation
        /// </summary>
        public static double calculateStandardDeviation(List<double> numbers)
        {
            //Find Variance
            double varience = calculateVarience(numbers);

            //Find Standard Deviation
            double standard_deviation = Math.Sqrt(varience);

            return standard_deviation;
        }

        /// <summary>
        /// Returns the amount of integers present within the specified limits
        /// </summary>
        /// <param name="integers">Integer list to sift through</param>
        /// <param name="low">Lower limit</param>
        /// <param name="high">Higher Limit</param>
        public static int getCount(List<double> numbers, int low, int high)
        {
            int count = 0;

            //Iterate through integer list
            foreach(double number in numbers)
            {
                //Determine if integer is within the correct bracket
                if(( number > low ) && ( number < high ) ) count++;
            }

            return count;
        }

    }
}
