using System;

namespace ЛАБ2_4УП
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 8; i >= 4; --i, Console.WriteLine())
            {
                for (int j = 1; j <= i - 3; j++)
                {
                    Console.Write(" " + i);
                }
            }
        }
    }
}
