using HomeWork6.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork6.Services
{
    internal class OrderService
    {
        public BillEntity GetBill(ProductEntity[] products)
        {
            BillEntity bill = new BillEntity();
            bill.Id = Guid.NewGuid();
            bill.ShopName = "Julienne Fruits";
            bill.Date = DateTime.Now;
            bill.Products = products;
            bill.TotalPrice = GetTotalPrice(products);

            return bill;
        }

        private int GetTotalPrice(ProductEntity[] products)
        {
            int totalPrice = 0;
            foreach (ProductEntity product in products)
            {
                totalPrice = totalPrice + product.Cost;
            }

            return totalPrice;
        }
    }
}
