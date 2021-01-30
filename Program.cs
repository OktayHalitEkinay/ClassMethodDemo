using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            ConsumerManager consumerManager = new ConsumerManager();
            Consumer consumer = new Consumer();


            Console.WriteLine("-------------------CUSTOMER LOGIN-------------------");
            Console.Write("Please enter CUSTOMER name:");
            consumer.name = Console.ReadLine();

            Console.Write("Please enter CUSTOMER surname:");
            consumer.surname = Console.ReadLine();

            consumer.ID = random.Next(1000, 5000);
            Console.WriteLine("ID of the consumer is:{0}", consumer.ID);

            Console.WriteLine();
            Console.WriteLine("-------------------AFTER THE METHODS ARE CALLED-------------------");


            consumerManager.consumerAdd(consumer);
            consumerManager.consumerDelete(consumer);
            consumerManager.consumerList(consumer);


        }
    }
}
