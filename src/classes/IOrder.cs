using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using src.enums;


namespace src.classes
{
    public interface IOrder
    {
        public int Count { get; set; }
        public OrderStatus status { get; set; }
        public Items Item { get; set; }
    }
}