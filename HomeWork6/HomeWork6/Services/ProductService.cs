using HomeWork6.Entities;
using HomeWork6.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork6.Services
{
    internal class ProductService
    {
        public ProductEntity[] GetFilledCart(ProductsStorage storage) 
        {
            int itemsQuantity = new Random().Next(1, 11);
            ProductEntity[] cart = new ProductEntity[itemsQuantity];

            for (int i = 0; i < cart.Length; i++)
            {
                cart[i] = storage.GetProducts()[new Random().Next(0, 100)];
            }

            return cart;
        }
    }
}
