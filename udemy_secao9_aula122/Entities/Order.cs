using System;
using System.Collections.Generic;
using udemy_secao9_aula122.Entities.Enums;
using System.Globalization;
using System.Text;

namespace udemy_secao9_aula122.Entities
{
    class Order
    {
        public DateTime Moment { get; set; }
        public OrderStatus StatusOrder { get; set; }
        public List<OrderItem> Itens { get; set; } = new List<OrderItem>();
        public Client client { get; set; }

        public Order()
        {
        }

        public Order(OrderStatus statusOrder, Client client)
        {
            Moment = DateTime.Now;
            StatusOrder = statusOrder;
            this.client = client;
        }

        public void AddItem(OrderItem item)
        {
            Itens.Add(item);
        }
        public void RemoveItem(OrderItem item)
        {
            Itens.Remove(item);
        }
        public double Total()
        {
            double sum = 0.0;
            foreach (OrderItem item in Itens)
            {
                sum += item.SubTotal();
            }
            return sum;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Order moment: " + Moment.ToString("dd/MM/yyyy HH:mm:ss"));
            sb.AppendLine("Order status: " + StatusOrder);
            sb.AppendLine("Client: " + client);
            sb.AppendLine("Order items:");
            foreach (OrderItem item in Itens)
            {
                sb.AppendLine(item.ToString());
            }
            sb.AppendLine("Total price: $" + Total().ToString("F2", CultureInfo.InvariantCulture));
            return sb.ToString();
        }
    }
}
