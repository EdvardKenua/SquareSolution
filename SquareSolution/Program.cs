using System;
using System.Collections.Generic;
using System.Linq;

namespace SquareSolution // Note: actual namespace depends on the project name.
{
    public class Program
    {
        //public static double E = 0.05, z = 1, y = 1, x = 0, k = 2;
        //public static double Sqrt(double n)
        //{
        //    z = y;
        //    y = (1 / k) * ((k - 1) * z + (x / Math.Pow(z, k - 1))); TODO: Доработать формулу
        //    Console.WriteLine(y);
        //    if (Math.Abs(y - z) > E)
        //    {
        //        return Sqrt(y);
        //    }
        //    else
        //    {
        //        return 0;
        //    }
        //}


        public static void Main(string[] args)
        {
            double prevNum = 1, NumToSqrt = 0, CurNum = 1, k = 2, E = 0.05;
            Console.WriteLine("Введите X: ");
            NumToSqrt = Convert.ToDouble(Console.ReadLine());

            if (NumToSqrt > 0)
            {
                do
                {
                    prevNum = CurNum;
                    CurNum = (1 / k) * ((k - 1) * prevNum + (NumToSqrt / Math.Pow(prevNum, k-1)));
                    Console.WriteLine(CurNum);
                } while (Math.Abs(CurNum - prevNum) > E);
            }
        }
    }
}