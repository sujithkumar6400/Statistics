using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_1
{
    class WeightedMean
    {
        static void Main(string[] args)
        {
            int numberCount = Convert.ToInt32(Console.ReadLine());
            string numberArray = Console.ReadLine();
            string weightArray = Console.ReadLine();
            double weightSum = 0, sumOfWeightandNumbers = 0, weightedMean = 0;
            for(int i = 0; i< numberCount; i++)
            {
                weightSum += Convert.ToInt32(weightArray.Split(' ')[i]);
                sumOfWeightandNumbers += Convert.ToInt32(numberArray.Split(' ')[i]) * Convert.ToInt32(weightArray.Split(' ')[i]);
            }
            weightedMean = sumOfWeightandNumbers / weightSum;
            Console.WriteLine(weightedMean.ToString("N1"));

        }
    }
}
