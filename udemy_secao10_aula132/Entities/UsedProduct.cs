using System;
using udemy_secao10_aula132.Entities;
using System.Globalization;

namespace udemy_secao10_aula132.Entities
{
    class UsedProduct :Product
    {
        public DateTime ManufactureDate { get; set; }

        public UsedProduct()
        {
        }

        public UsedProduct(string name, double price, DateTime manufactureDate) :base(name,price)
        {
            ManufactureDate = manufactureDate;
        }
        public override string priceTag()
        {
            return Name
                + " (Used) - R$"
                + Price.ToString("F2", CultureInfo.InvariantCulture)
                + "Manufacture Date: (dd/MM/yyyy)"
                + ManufactureDate.ToString("dd/MM/yyyy");
        }
    }
}
