using HomeWork6.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork6.Repository
{
    public class ProductsStorage
    {
        internal ProductEntity[] _products = new ProductEntity[100];

        public ProductsStorage()
        {
            FillProducts();
        }

        internal ProductEntity[] GetProducts()
        {
            return _products;
        }

        private void FillProducts()
        {
            string[] fruitNames = { "Apple", "Banana", "Orange", "Grapes", "Mango", "Strawberry", "Watermelon", "Pineapple", "Kiwi", "Peach",
                            "Cherry", "Blueberry", "Raspberry", "Pear", "Plum", "Apricot", "Fig", "Cantaloupe", "Honeydew", "Lemon",
                            "Lime", "Avocado", "Coconut", "Pomegranate", "Blackberry", "Papaya", "Passion Fruit", "Dragon Fruit", "Guava",
                            "Persimmon", "Cranberry", "Raisin", "Date", "Grapefruit", "Tangerine", "Kumquat", "Nectarine", "Raspberry",
                            "Currant", "Melon", "Lychee", "Star Fruit", "Quince", "Clementine", "Mulberry", "Soursop", "Cucumber",
                            "Pomelo", "Salmonberry", "Boysenberry", "Cactus Fruit", "Acai Berry", "Cranberry", "Elderberry", "Gooseberry",
                            "Loquat", "Mandarin Orange", "Passion Fruit", "Persimmon", "Pineberry", "Plantain", "Tamarillo", "Uvaia",
                            "Feijoa", "Pawpaw", "Sapote", "Mamey Sapote", "Ackee", "Barberry", "Bilberry", "Chayote", "Damson", "Durian",
                            "Feijoa", "Jambul", "Lingonberry", "Nance", "Pawpaw", "Salak", "Sapote", "Surinam Cherry", "Tamarind", "Yuzu", "Lychee",
                            "Star Fruit", "Quince", "Mangoosteen", "Horned Melon", "Chokeberry", "Nance", "Jackfruit", "Rambutan", "Jabuticaba",
                            "Ugli Fruit", "Blackcurrant", "Loganberry", "Jaboticaba", "Pawpaw", "Feijoa", "Durian", "Jujube"};

            int[] fruitCosts = { 15, 10, 12, 20, 25, 8, 30, 40, 18, 22,
                         14, 11, 13, 19, 24, 9, 28, 38, 17, 21,
                         16, 26, 35, 42, 23, 7, 33, 45, 19, 20,
                         27, 32, 36, 16, 14, 31, 40, 37, 44, 39,
                         18, 15, 13, 22, 28, 34, 41, 19, 26, 29,
                         23, 35, 39, 42, 17, 30, 31, 48, 21, 33,
                         27, 29, 38, 43, 36, 41, 37, 40, 47, 49,
                         16, 25, 26, 33, 30, 39, 32, 46, 28, 30,
                         14, 42, 43, 49, 38, 43, 44, 45, 47, 50,
                         15, 22, 31, 34, 40, 41, 45, 48, 19, 32 };

            for (int i = 0; i < _products.Length; i++)
            {
                // Use modulo to cycle through the fruit names and costs
                string fruitName = fruitNames[i];
                int fruitCost = fruitCosts[i];

                _products[i] = new ProductEntity(fruitName, fruitCost);
            }
        }

    }
}
