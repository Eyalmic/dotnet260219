using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random engine = new Random();
            int secretNumber = engine.Next(100) + 1;
            int guess = 0;
            Console.WriteLine("A secret number has been generated, try to guess between 1-100!");
            int a = Convert.ToInt32(Console.ReadLine());
            while(a!=secretNumber)
            {
                if (a < secretNumber)
                {
                    Console.WriteLine("Too Small");
                }
                else
                {
                    Console.WriteLine("Too Big");
                }
                guess++;
                Console.WriteLine($"{guess} tries so far, try again!");
                a = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine($"Bingo! it took you {++guess} tries!");
        }
    }
}
