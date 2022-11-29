using System;

namespace ЛАБ2_УП
{
    class Program
    {
        static void Main(string[] args)
        {
            double x;
            double y;
            Console.Write("X = ");
            while (!double.TryParse(Console.ReadLine(), out x))
                Console.WriteLine("Некорректный ввод значения");
            Console.Write("Y = ");
            while (!double.TryParse(Console.ReadLine(), out y))
                Console.WriteLine("Некорректный ввод значения");
            if (y > 0 || y < -100 || x > 100 || x < -100 || 1 / 2 * x * y > 5000)
                Console.WriteLine("Вне");
            else if (y < 0 && y > -100 && x < 100 && x > -100 && 1 / 2 * x * y < 5000)
                Console.WriteLine("Внутри");
            else Console.WriteLine("На границе");
        }
    }
}
