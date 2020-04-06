using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratorio3
{
    class Producto
    {
        private string nameP;
        private int price;
        private string brand;
        private int stock;
        private int id;

        public string NameP { get => nameP; set => nameP = value; }
        public int Price { get => price; set => price = value; }
        public string Brand { get => brand; set => brand = value; }
        public int Stock { get => stock; set => stock = value; }
        public int Id { get => id; set => id = value; }

        public Producto(string nameP, int price, string brand, int stock, int id)
        {
            this.nameP = nameP;
            this.price = price;
            this.brand = brand;
            this.stock = stock;
            this.id = id;
        }
        public int revisarStock(Producto product)
        {
            int stockProduct = product.stock;
            return stock;
        }
    }
}
