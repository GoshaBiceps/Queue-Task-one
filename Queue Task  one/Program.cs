using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Queue_Task__one
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<int> costsPurchases = CreateQueue();
            int account = 0;
            int clientNumber = 1;
            int money;
          
            while (costsPurchases.Count > 0)
            {
                
                account = ServeCustomers(costsPurchases, account, out money);
                Console.WriteLine($"{clientNumber++} клиент сделал покупки на сумму {money} рублей.");
                Console.WriteLine($"В кассе - {account} рублей.");
                Console.ReadKey();
                Console.Clear();
            }
        }
        static int ServeCustomers(Queue<int> costsPurchases, int account, out int money)
        {
            money = costsPurchases.Dequeue();
            account += money;

            return account;
        }

        static Queue<int> CreateQueue()
        {
            Queue<int> clients = new Queue<int>();
            Random random = new Random();
            int maxValue = 1000;

            Console.WriteLine("Введите количество клиентов в очереди: ");
            string userInput = Console.ReadLine();

            if (int.TryParse(userInput, out int number))
            {
                for (int i = 0; i < number; i++)
                {
                    clients.Enqueue(random.Next(maxValue));
                }
            }

            return clients;
        }
    }
}
