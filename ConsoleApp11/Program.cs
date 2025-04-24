using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    class Program
    {
        delegate int Operation(int x, int y);
        static void Main(string[] args)
        {
            Operation del = new Operation(Add); // делегат указывает на метод Add
            int result = del.Invoke(4, 5);
            Console.WriteLine(result);
            

            del = Diff; // теперь делегат указывает на метод Diff
            result = del(4, 5);
            Console.WriteLine(result);

            del = Multiply; // теперь делегат указывает на метод Multiply
            result = del(4, 5);
            Console.WriteLine(result);

            del = Division; // теперь делегат указывает на метод Division
            result = del(4, 5);
            Console.WriteLine(result);
            Console.ReadKey();
        }
        private static int Add(int x, int y)
        {
            return x + y;
        }
        private static int Diff(int x, int y)
        {
            return x - y;
        }
        private static int Multiply(int x, int y)
        {
            return x * y;
        }
        private static int Division(int x, int y)
        {
            return x / y;
        }
        

    }
}
