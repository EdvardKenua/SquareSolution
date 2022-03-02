using System;
using System.Collections.Generic;
using System.Linq;

namespace SquareSolution // Note: actual namespace depends on the project name.
{
    public class Program
    {
        //static double z = 1, k = 2, E = 0.001;

        //public static double Square(int number)
        //{
        //    double prevNum = 1;
        //    if (number - prevNum > E)
        //    {
                
        //        return number;
        //    }
        //    else
        //    {
        //        prevNum = Square(number - 1);
        //        Console.WriteLine(number);
        //        return (1 / k) * (k - 1) * prevNum + (number / Math.Pow(prevNum, k - 1));
                
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
                } while (Math.Abs(CurNum-prevNum) > E);
            }
        }
    }
}