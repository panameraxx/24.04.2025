using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    class Program
    {
        public static double Average(double m, double n)
        {
            double sum = 0;
            int count = 0;
            for (double i = m; i <= n; i++)
            {
                sum += i;
                count++;
            }
            return sum / count;
        }
        public delegate double AverageDelegate(double m, double n);

        static void Main(string[] args)
        {
            AverageDelegate avg = new AverageDelegate(Average);

            double res = avg(15, 30);
            Console.WriteLine(res);

            double res1 = avg(200, 400);
            Console.WriteLine(res1);

            double res2 = avg(10, 30);
            Console.WriteLine(res2);
            Console.ReadKey();
        }
    }

}


