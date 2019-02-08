using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_0_Mean_Medium_Mode
{
    class Program
    {
        public static void Main(string[] args)
        {
            int numbers = Convert.ToInt32(Console.ReadLine());
            int[] numberArray = new int[numbers];
            string numarray = Console.ReadLine();
            for (int i = 0; i < numbers; i++)
            {
                numberArray[i] = Convert.ToInt32(numarray.Split(' ')[i]);
            }
            //int[] numberArray = { 64630, 11735, 14216, 99233, 14470, 4978, 73429, 38120, 51135, 67060 };
            Array.Sort(numberArray);
            Console.WriteLine(CalculateMean(numberArray));
            Console.WriteLine(CalculateMedium(numberArray));
            Console.WriteLine(CalculateMode(numberArray));

            Console.ReadKey();

        }

        private static double CalculateMean(int[] numberArray)
        {
            int lenght = numberArray.Length;
            double sum = 0;
            for (int i = 0; i < lenght; i++)
            {
                sum += numberArray[i];
            }
            return sum / lenght;
        }

        private static double CalculateMedium(int[] numberArray)
        {
            int lenght = numberArray.Length;
            double sum = 0;
            if (lenght % 2 == 0)
            {
                sum = numberArray[lenght / 2] + numberArray[lenght / 2 - 1];
                return sum / 2;
            }
            else
            {
                return numberArray[lenght / 2 + 1];
            }
        }

        private static double CalculateMode(int[] numberArray)
        {
            Dictionary<int, int> numbersWithCount = new Dictionary<int, int>();
            double mode = 0;
            for (int i = 0; i < numberArray.Length; i++)
            {
                if (numbersWithCount.ContainsKey(numberArray[i]))
                {
                    numbersWithCount[numberArray[i]]++;
                }
                else
                    numbersWithCount.Add(numberArray[i], 1);
            }

            return numbersWithCount.FirstOrDefault(x => x.Value.Equals(numbersWithCount.Values.Max())).Key;

        }
    }
}
