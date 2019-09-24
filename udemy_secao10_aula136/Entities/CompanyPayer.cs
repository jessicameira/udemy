using System;
using System.Globalization;

namespace udemy_secao10_aula136.Entities
{
    class CompanyPayer :Payers
    {
        public int Employees { get; set; }

        public CompanyPayer()
        {
        }

        public CompanyPayer(string name, double anualIncome, int employees)
            :base (name,anualIncome)
        {
            Employees = employees;
        }

        public override double TaxePay()
        {
            double tax = 0.0;
            if (Employees <10)
            {
                tax = AnualIncome * 0.16;
            }
            else
            {
                tax = AnualIncome * 0.14;
            }
            return tax;
        }
        public override string ToString()
        {
            return Name
                + " - "
                + TaxePay().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
