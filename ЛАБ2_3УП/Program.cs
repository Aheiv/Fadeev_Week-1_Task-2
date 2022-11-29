using System;

namespace ЛАБ2_3УП
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            int b;
            int x;
            Console.Write("Введите начало диапазона: ");
            while (!int.TryParse(Console.ReadLine(), out a))
                Console.WriteLine("Некорректный ввод данных!");
            Console.Write("Введите конец диапазона: ");
            while (!int.TryParse(Console.ReadLine(), out b) || a > b)
                Console.WriteLine("Некорректный ввод данных!");
            Console.Write("Введите цифру, на которую должны оканчиваться числа: ");
            while (!int.TryParse(Console.ReadLine(), out x) || x < 0)
                Console.WriteLine("Некорректный ввод данных!");
            Console.Write("Диапазон чисел, оканчивающихся на цифру " + x + ": ");
            for (int i = a; i < b+1; i++)
            {
                if (Math.Abs(i) % 10 == x) Console.Write(i + ",");
                else continue;
            }
        }
    }
}
