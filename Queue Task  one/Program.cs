using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue_Task__one
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int account = 0;
            int[] tempArray = NumberGenerator();
            Queue<int> costsPurchases = new Queue<int>(tempArray);

            while(costsPurchases.Count > 0)
            {
                Console.WriteLine($"На счёте: {account}, Нажмите любую клавишу, чтобы обслужить клиента\n");
                Console.ReadKey();
                Console.Clear();

                account += costsPurchases.Dequeue();
                Console.WriteLine("\nКлиент обслужен! Деньги на поступили на счёт");
            }

        }

        static int[] NumberGenerator()
        {
            Random ramdom = new Random();

            int[] array = new int[ramdom.Next(Console.WindowWidth)];

            int numberMaximum = 3500;
            int numberMinimum = 1000;

            for (int i = 0; i < array.Length ; i++)
            {
                array[i] = ramdom.Next(numberMinimum, numberMaximum);
            }

            return array;
        }
    }
}
