using System;

namespace ЛАБ2_2УП
{
    class Program
    {
        static void Main(string[] args)
        {

            int NMonths; // кол-во месяцев

            Console.Write("Введите кол-во месяцев:");
            while (!int.TryParse(Console.ReadLine(), out NMonths) || NMonths < 0)
                Console.WriteLine("Некорректный ввод данных");
            Console.WriteLine("Начальная дата: {0:yyyy/MM/dd}", DateTime.Now);

            switch (1 > 0)
            {
                case true:
                    var oldDate = DateTime.Now.AddMonths(-NMonths);
                    Console.WriteLine("конечная дата: {0:yyyy/MM/dd}", oldDate);
                    break;
            }
        }
    }
}
