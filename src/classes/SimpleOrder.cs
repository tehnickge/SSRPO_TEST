using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using src.enums;

namespace src.classes
{
    public class SimpleOrder : IOrder
    {
        public int Count { get; set; }
        public OrderStatus status { get; set; }
        public Items Item { get; set; }
        public SimpleOrder(Items typeItem, int countItems)
        {
            this.Count = countItems;
            this.status = OrderStatus.INWORK;
            this.Item = typeItem;

        }
    }
}