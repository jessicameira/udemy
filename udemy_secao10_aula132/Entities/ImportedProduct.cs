using System;
using udemy_secao10_aula132.Entities;
using System.Globalization;

namespace udemy_secao10_aula132.Entities
{
    class ImportedProduct :Product
    {
        public double CustomsFee { get; set; }

        public ImportedProduct()
        {
        }

        public ImportedProduct(string name, double price, double customsFee) :base(name,price)
        {
            CustomsFee = customsFee;
        }
        public double TotalPrice()
        {
            return Price + CustomsFee;
        }
        public override string priceTag()
        {
            return Name
                + " - R$"
                + TotalPrice().ToString("F2", CultureInfo.InvariantCulture)
                + " Custom Fee: R$"
                + CustomsFee.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
