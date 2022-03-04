using System;
using System.Collections.Generic;
using System.Linq;

namespace SquareSolution // Note: actual namespace depends on the project name.
{
    public class Program
    {
        public static double prevNum = 1, NumToSqrt = 0, CurNum = 1, k = 2, E = 0.05;

        public static double Sqrt(double n)
        {
            prevNum = CurNum;
            CurNum = (1 / k) * ((k - 1) * prevNum + (NumToSqrt / Math.Pow(prevNum, k - 1)));
            Console.WriteLine(CurNum);
            if (Math.Abs(CurNum - prevNum) > E)
            {
                return Sqrt(CurNum);
            }
            else
            {
                return 0;
            }
        }



        public static void Main(string[] args)
        {
            Console.WriteLine("Введите число:");
            NumToSqrt = Convert.ToDouble(Console.ReadLine());
            Sqrt(NumToSqrt);

        }
    }
}