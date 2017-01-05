using System;

namespace ConsoleApplication1
{
    class Program
    {
        static int ErrorExit0(string error)
        {
            Console.WriteLine(error);
            Console.ReadKey();
            Environment.Exit(0);
            return 0;
        }
        static double checkDouble(string name)
        {
            double x;
            string error = String.Format("Ошибка. {0} введено не правильно. Перезагрузить консоль, пожалуйста.", name);
            Console.WriteLine($"Введите {name}:", name);
            return (double.TryParse(Console.ReadLine(), out x)) ? x : ErrorExit0(error);
        }
        static void Main(string[] args)
        {
            double x = checkDouble("X"), y = checkDouble("Y");
            string success = "Точка входит в область", fail = "Точка не входит в область";
            string answer = (((Math.Pow(x, 2) + Math.Pow(y, 2)) <= 1 && x <= 0 && y <= 0) || ((0 <= x && x <= 1) && (0 <= y && y <= 1))) ? success : fail;
            Console.WriteLine(answer);
            Console.ReadKey();

        }
    }
}
