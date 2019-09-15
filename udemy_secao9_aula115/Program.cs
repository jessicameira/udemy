using System;
using udemy_secao9_aula115.entities;
using udemy_secao9_aula115.entities.Enums;

namespace udemy_secao9_aula115
{
    class Program
    {
        static void Main(string[] args)
        {
            order Order = new order
            {
                Id = 1080,
                Moment = DateTime.Now,
                Status = OrderStatus.PendingPayment
            };
            Console.WriteLine(Order);
            string txt = OrderStatus.PendingPayment.ToString();
            Console.WriteLine(txt);

            OrderStatus os = Enum.Parse<OrderStatus>("Delivered");
            Console.WriteLine(os);
        }
    }
}
