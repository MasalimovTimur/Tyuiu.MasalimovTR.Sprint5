using System.Diagnostics;
using Tyuiu.MasalimovTR.Sprint5.Task0.V25.Lib;
using System.IO;

namespace Tyuiu.MasalimovTR.Sprint5.Task0.V25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #5 | Выполнил: Масалимов Т.Р. | РППб-24-1";
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Задание #0                                                              *");
            Console.WriteLine("* Вариант #25                                                              *");
            Console.WriteLine("* Выполнил: Масалимов Тимур Рyсланович | РППб-24-1                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* КАРТИНКА                                                                *");      
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Результат:");
            int x = 3;
            string res = ds.SaveToFileTextData(x);
        }
    }
}
