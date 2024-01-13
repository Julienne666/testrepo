using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork6.Entities
{
    internal class BillEntity
    {
        public Guid Id { get; set; }
        public string ShopName {  get; set; }
        public DateTime Date { get; set; }
        public ProductEntity[] Products {  get; set; }
        public int TotalPrice { get; set; }
    }
}
