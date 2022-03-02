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
            double z = 1, x = 0, y = 1, k = 2, E = 0.05, n = 0;
            Console.WriteLine("Введите X: ");
            x = Convert.ToDouble(Console.ReadLine());

            if (x > 0)
            {
                do
                {
                    z = y;
                    y = (1 / k) * ((k - 1) * z + (x / Math.Pow(z, k-1)));
                    Console.WriteLine(y);
                } while (Math.Abs(y-z) > E);
            }
        }
    }
}