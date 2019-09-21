using System;
using System.Collections.Generic;
using System.Text;
using udemy_secao9_aula122.Entities;
using System.Globalization;

namespace udemy_secao9_aula122.Entities
{
    class OrderItem
    {
        public int Quantity { get; set; }
        public double PriceNew { get; set; }
        public Products Nameproduct { get; set; }

        public OrderItem()
        {
        }

        public OrderItem(int quantity, double priceNew, Products nameproduct)
        {
            Quantity = quantity;
            PriceNew = priceNew;
            Nameproduct = nameproduct;
        }

        public double SubTotal()
        {
            return Quantity * PriceNew;
        }

        public override string ToString()
        {
            return Nameproduct.NameProduto
                + ", " + PriceNew.ToString("F2", CultureInfo.InvariantCulture)
                + ", Quantity: " + Quantity
                + " Subtotal: " + SubTotal().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
