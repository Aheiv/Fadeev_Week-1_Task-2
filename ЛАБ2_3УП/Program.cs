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
            int i = 0;
            Console.Write("Введите начало диапазона: ");
            while (!int.TryParse(Console.ReadLine(), out a))
                Console.WriteLine("Некорректный ввод данных!");
            Console.Write("Введите конец диапазона: ");
            while (!int.TryParse(Console.ReadLine(), out b) || a > b)
                Console.WriteLine("Некорректный ввод данных!");
            Console.Write("Введите цифру, на которую должны оканчиваться числа: ");
            while (!int.TryParse(Console.ReadLine(), out x) || x < 0 || x > 9)
                Console.WriteLine("Некорректный ввод данных!");
            Console.Write("Диапазон чисел, оканчивающихся на цифру " + x + " через цикл for: ");
            for (i = a; i < b+1; i++)
            {
                if (Math.Abs(i) % 10 == x) Console.Write(i + ",");
                else continue;
            }
            i = a;
            Console.Write("\nДиапазон чисел, оканчивающихся на цифру " + x + " через цикл while: ");
            while (i < b+1)
            {
                if (Math.Abs(i) % 10 == x)
                {
                    Console.Write(i + ",");
                    i++;
                }
                else 
                {
                    i++;
                    continue;
                }
            }
            i = a;
            Console.Write("\nДиапазон чисел, оканчивающихся на цифру " + x + " через цикл do...while: ");
            do
            {
                if (Math.Abs(i) % 10 == x)
                {
                    Console.Write(i + ",");
                    i++;
                }
                else
                {
                    i++;
                    continue;
                }
            } while (i < b + 1);
        }
    }
}
