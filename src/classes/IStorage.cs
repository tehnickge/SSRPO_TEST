using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using src.enums;

namespace src.classes
{
    public interface IStorage
    {
        public void AppendStorage(Items item, int count);
        public void AddOrder(Items item, int count);
        public void MakeOrders();
    }
}