using HomeWork6.Entities;
using HomeWork6.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork6.Services
{
    internal class ShopService
    {
        public void Run()
        {
            ProductsStorage storage = new ProductsStorage();

            ProductService productService = new ProductService();
            ProductEntity[] cart = productService.GetFilledCart(storage);

            OrderService orderService = new OrderService();
            BillEntity bill = orderService.GetBill(cart);

            NotificationService notificationService = new NotificationService();
            notificationService.ShowPlacedOrder(bill);
        }
    }
}
