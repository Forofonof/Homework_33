using System;
using System.Collections.Generic;
internal class Program
{
    static void Main(string[] args)
    {
        Random random = new Random();

        int minimumClientPayments = 199;
        int MaximumClientPayments = 2499;
        int userBalance = 0;

        Queue<int> clientPayments = new Queue<int>();

        clientPayments.Enqueue(random.Next(minimumClientPayments, MaximumClientPayments));
        clientPayments.Enqueue(random.Next(minimumClientPayments, MaximumClientPayments));
        clientPayments.Enqueue(random.Next(minimumClientPayments, MaximumClientPayments));
        clientPayments.Enqueue(random.Next(minimumClientPayments, MaximumClientPayments));
        clientPayments.Enqueue(random.Next(minimumClientPayments, MaximumClientPayments));
        clientPayments.Enqueue(random.Next(minimumClientPayments, MaximumClientPayments));
        clientPayments.Enqueue(random.Next(minimumClientPayments, MaximumClientPayments));

        Console.WriteLine("Нажмите любую кнопку, чтобы обслужить клиента");

        while (clientPayments.Count > 0)
        {
            Console.ReadKey();
            Console.Clear();

            userBalance += clientPayments.Dequeue();

            Console.WriteLine($"Вы обслужили клиента! Осталось ещё - {clientPayments.Count} клиентов(а).");
            Console.WriteLine($"Ваш баланс составляет: {userBalance} рублей.");
        }
    }
}