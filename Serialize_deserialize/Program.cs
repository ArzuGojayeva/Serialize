using Newtonsoft.Json;

namespace Serialize_deserialize
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Prouduct product = new Prouduct() {Id=1, Name = "Samsung", Price = 720 };
            Prouduct product1 = new Prouduct() { Id = 2, Name = "Honor", Price = 500 };
            Prouduct product2 = new Prouduct() { Id=3, Name ="Xiaomi",Price = 400};

            OrderItem item = new OrderItem() { Id = 1, product = product, Count = 3 };
            item.TotalPrice = product.Price * item.Count;
            OrderItem item1 = new OrderItem() { Id = 2, product =product1, Count = 2 };
            item1.TotalPrice = product1.Price * item1.Count;
            OrderItem item2 = new OrderItem() { Id = 3, product = product2, Count = 4 };
            item2.TotalPrice = product2.Price * item2.Count;

            List<OrderItem> orders = new List<OrderItem>() { item, item1, item2 };
            Order order=new Order() { Id=1,orderItems=orders};
            var result=JsonConvert.SerializeObject(order);

            using(var streamWriter = new StreamWriter(@"C:\Users\hp\OneDrive\Desktop\17 april\Serialize_deserialize\fayl.json"))
            {
                streamWriter.WriteLine(result);
            }
        }
    }
}