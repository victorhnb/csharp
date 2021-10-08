﻿using Enumeracoes.Entities;
using Enumeracoes.Entities.Enums;
using System;

namespace Enumeracoes
{
    class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order {
                Id = 1080,
                Moment = System.DateTime.Now,
                Status = OrderStatus.PendingPayment    
            
            };

            Console.WriteLine(order);

            string txt = OrderStatus.PendingPayment.ToString();
            OrderStatus os = Enum.Parse<OrderStatus>("Delivered");

            Console.WriteLine(os);
            Console.WriteLine(txt);




        }
    }
}
