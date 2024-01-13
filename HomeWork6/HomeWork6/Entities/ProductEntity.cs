using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork6.Entities
{
    internal class ProductEntity
    {
        public ProductEntity(string name, int cost)
        {
            Name = name;
            Cost = cost;
        }

        public string Name { get; set; }
        public int Cost { get; set; }
    }
}
