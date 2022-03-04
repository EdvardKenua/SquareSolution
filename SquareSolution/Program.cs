using System;
using System.Collections.Generic;
using System.Linq;

namespace SquareSolution // Note: actual namespace depends on the project name.
{
    public class Program
    {
        public static void Main(string[] args)
        {
            double prevNum = 1, NumToSqrt = 0, CurNum = 1, root = 2, E = 0.05;
            Console.WriteLine("Введите X: ");
            NumToSqrt = Convert.ToDouble(Console.ReadLine());

            if (NumToSqrt > 0)
            {
                do
                {
                    prevNum = CurNum;
                    CurNum = (1 / root) * ((root - 1) * prevNum + (NumToSqrt / Math.Pow(prevNum, root-1)));
                    Console.WriteLine(CurNum);
                } while (Math.Abs(CurNum-prevNum) > E);
            }
        }
    }
}