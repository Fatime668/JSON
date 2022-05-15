using Files.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace Files
{
    class Program
    {
        static void Main(string[] args)
        {
            Computer computer = new Computer {Id = 1,Brand = "ASUS",Ram = "8GB",GraphicCard = "RTX2090",Price = 3000.20 };
            Computer computer1 = new Computer {Id = 2,Brand = "ACer",Ram = "8GB",GraphicCard = "UHDGraphics",Price = 1500.20 };
            Computer computer2 = new Computer {Id = 3,Brand = "MSI",Ram = "32GB",GraphicCard = "RTX2090",Price = 3000.20 };
            Computer computer3 = new Computer {Id = 4,Brand = "LENOVO",Ram = "8GB",GraphicCard = "AMD RZYEN 7",Price = 5000.20 };

            OrderItem orderItem = new OrderItem {Id = 1,Computer = computer,Price=computer.Price };
            OrderItem orderItem1 = new OrderItem {Id = 2,Computer = computer1,Price=computer1.Price };
            OrderItem orderItem2 = new OrderItem {Id = 3,Computer = computer2,Price=computer2.Price };
            OrderItem orderItem3 = new OrderItem {Id = 4,Computer = computer3,Price=computer3.Price };

            Order order = new Order
            {
                Id = 1,
                OrderItems = new System.Collections.Generic.List<OrderItem>()
            {
                orderItem,
                orderItem1,
                orderItem2,
                orderItem3
            },
                TotalPrice = 12500.50,
            };
            //Console.WriteLine(order.OrderItems[1].Price);

            var orderStr = JsonConvert.SerializeObject(order);
            //Console.WriteLine(orderStr);

            //using (StreamWriter streamWriter = new StreamWriter(@"C:\Users\user\source\repos\Files\Files\Datas\data.json",true))
            //{
            //    streamWriter.Write(orderStr);
            //};
            //List<OrderItem> orderItems = new List<OrderItem>()
            //{
            //    orderItem,
            //    orderItem1,
            //    orderItem2,
            //    orderItem3
            //};
            string result;
            using (StreamReader sr = new StreamReader(@"C:\Users\user\source\repos\Files\Files\Datas\data.json"))
            {
                result = sr.ReadLine();
            }
            Order orderDesc = JsonConvert.DeserializeObject<Order>(result);
            Console.WriteLine(orderDesc.TotalPrice);
            foreach (var item in orderDesc.OrderItems)
            {
                Console.WriteLine(item.Computer.Brand);
            }
        }
    }
}
