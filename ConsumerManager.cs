using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class ConsumerManager
    {
        public void consumerAdd(Consumer consumer)
        {
            Console.WriteLine(consumer.ID+" "+consumer.name+" "+consumer.surname +" added.");

        }

        public void consumerDelete(Consumer consumer)
        {
            Console.WriteLine(consumer.ID + " " + consumer.name + " " + consumer.surname + " deleted.");
        }

        public void consumerList(Consumer consumer)
        {
            Console.WriteLine(consumer.ID + " " + consumer.name + " " + consumer.surname + " listed.");
        }


    }
}
