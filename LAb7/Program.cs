using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Math;

namespace Lab7
{
    class Program
    {
        static void Main(string[] args)
        {
            double s = 1;
            for(int i = 1; i <= 10; i++)
            {
                double p = 1;
                for (int j = 1; j <= 5; j++) 
                {
                    p *= (Abs(Sin(i) * Cos(j))) /( i + j);
                }
                s *= p;
            }
            Console.WriteLine(s);
        }
    }
}