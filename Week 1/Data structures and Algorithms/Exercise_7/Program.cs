using System;

namespace Exercise_7
{
    internal class Program
    {

        static double PredictFutureValue(double presentValue, double growthRate, int time)
        {
            if (time == 0) { 
                return presentValue;
            }

            return PredictFutureValue(presentValue, growthRate, time-1) * (1+growthRate);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the present ammout-->");
            double presentAmount = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the annual interest rate-->");
            double rate = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the time of investment-->");
            int time = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Fututre value after {time} years is : {PredictFutureValue(presentAmount,rate/100,time)} .");
        }
    }
}
