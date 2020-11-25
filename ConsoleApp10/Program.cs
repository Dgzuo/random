using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        {
            int points = 100;
            Random r = new Random();
            while (true)
                {
                Console.WriteLine($"У вас {points} Очков");
                Console.Write("В ведите число от 2 до 12: ");
                int userNumber = int.Parse(Console.ReadLine());
                Console.Write("Ваша ставка: ");
                int rate = int.Parse(Console.ReadLine());
                int num1 = r.Next(1, 6);
                int num2 = r.Next(1, 6);
                int summ = num1 + num2;
                if (summ < 7 && userNumber < 7)
                {
                    Console.WriteLine($"Вы выиграли:  {rate} Очков");
                    points += rate;
                }
                else if (summ > 7 && userNumber > 7)
                {
                    Console.WriteLine($"Вы выиграли {rate} Очков");
                    points += rate;
                }
                else if (summ == userNumber)
                {
                    Console.WriteLine($"Вы выиграли {rate * 4} Очков");
                    points += rate * 4;
                }
                else
                {
                    Console.WriteLine($"Вы проиграли{rate} очков");
                    points -= rate;
                }

            }
        }
    }
}
