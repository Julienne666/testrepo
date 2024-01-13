using HomeWork6.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork6.Services
{
    internal class NotificationService
    {
        public void ShowPlacedOrder(BillEntity bill)
        {
            Console.WriteLine($"Bill id: {bill.Id}");
            Console.WriteLine($"Store name: {bill.ShopName}");
            Console.WriteLine($"Date: {bill.Date}");
            ShowItemsDetails(bill.Products);
            Console.WriteLine($"Total price: {bill.TotalPrice} uah");
        }

        private void ShowItemsDetails(ProductEntity[] products)
        {
            Console.WriteLine($"Items:");
            foreach (ProductEntity product in products)
            {
                Console.WriteLine($"{product.Name}: {product.Cost} uah");
            }
        }
    }
}
