using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    class Program
    {
        delegate void Message(); // 1. Обьявление делегата
        static void Main(string[] args)
        {
            if (DateTime.Now.Hour < 12)
            {
                Message message = Hello; // 2. Создание обьекта делегата
                message(); // 4. Вызываем обьект делегата
            }
            else
            {
                Message msg = Bye;
                msg();
            }
           
            Console.ReadKey();
        }
        static public void Hello() => Console.WriteLine("Доброе утро!");
        static public void Bye() => Console.WriteLine("Добрый вечер!");

    }
}
