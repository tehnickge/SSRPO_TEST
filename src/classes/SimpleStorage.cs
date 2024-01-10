using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using src.classes;
using src.enums;

namespace src.classes
{
    public class SimpleStorage : IStorage
    {
        public Dictionary<Items, int> items = new Dictionary<Items, int>();
        public List<SimpleOrder>? simpleOrders = new List<SimpleOrder>()
        { new SimpleOrder(Items.MOLOTOK, 5),
        new SimpleOrder(Items.MOLOTOK, 5) };

        public void AppendStorage(Items item, int count)
    {
        if (this.items.ContainsKey(item))
        {
            items[item] += count;
        }
        else
        {
            items.TryAdd(item, count);
        }
    }
    public void AddOrder(Items item, int count)
    {
        this.simpleOrders.Add(new SimpleOrder(item, count));
    }
    public void MakeOrders()
    {
        foreach (var order in this.simpleOrders)
        {
            if (order.status != OrderStatus.INWORK) { continue; }
            Console.WriteLine($"выполняем заказ на {order.Item} кол-во:{order.Count}");
            if (this.items.ContainsKey(order.Item))
            {
                Console.WriteLine("soderjet");
                if (this.items[order.Item] >= order.Count)
                {
                    this.items[order.Item] -= order.Count;
                    order.status = OrderStatus.COMPLETE;
                }
                else
                {
                    AppendStorage(order.Item, (order.Count - this.items[order.Item]));
                    this.items[order.Item] -= order.Count;
                    order.status = OrderStatus.COMPLETE;

                }
            }
            else
            {
                Console.WriteLine("ne soderjet");
                AppendStorage(order.Item, order.Count);
                this.items[order.Item] -= order.Count;
                order.status = OrderStatus.COMPLETE;

            }
        }
    }
    }
}