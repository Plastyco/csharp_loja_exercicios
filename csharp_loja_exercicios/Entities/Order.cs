using csharp_loja_exercicios.Entities.Enums;
using System.Text;
using System.Globalization;

namespace csharp_loja_exercicios.Entities
{
    internal class Order
    {
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
        public Client Client { get; set; }
        public List<OrderItem> Items { get; set; } = new List<OrderItem>();

        public Order()
        {

        }

        public Order(DateTime moment, OrderStatus status, Client client)
        {
            Moment = moment;
            Status = status;
            Client = client;
        }

        public void AddItem(OrderItem item)
        {
            Items.Add(item);
        }

        public void RemoveItem(OrderItem item)
        {
            Items.Remove(item);
        }

        public double Total()
        {
            double total = 0;
            foreach (OrderItem oi in Items)
            {
                total += oi.SubTotal();
            }
            return total;
        }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine("Order summary:");
            stringBuilder.Append("Order moment: ");
            stringBuilder.AppendLine(Moment.ToString());
            stringBuilder.Append("Order status: ");
            stringBuilder.AppendLine(Status.ToString());
            stringBuilder.Append("Client: ");
            stringBuilder.AppendLine(Client.ToString());
            stringBuilder.AppendLine("Order items: ");
            foreach (OrderItem orderItem in Items)
            {
                stringBuilder.AppendLine(orderItem.ToString());
            }
            stringBuilder.Append($"Total price: {Total().ToString("F2", CultureInfo.InvariantCulture)}R$");

            return stringBuilder.ToString();
        }
    }
}
