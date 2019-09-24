using System;
using System.Globalization;

namespace udemy_secao10_aula136.Entities
{
    class IndividualPayer : Payers
    {
        public double Health { get; set; }

        public IndividualPayer()
        {
        }

        public IndividualPayer(string name, double anualIncome, double health)
            :base(name,anualIncome)
        {
            Health = health;
        }


        public override double TaxePay()
        {
            double tax = 0.0;
            if(AnualIncome < 20000.00)
            {
                if (Health != 0.0)
                {
                    tax = (AnualIncome * 0.15) - (Health * 0.50);
                }
                else
                {
                    tax = AnualIncome * 0.15;
                }
            }
            else
            {
                if(Health != 0)
                {
                    tax = (AnualIncome * 0.25) - (Health * 0.50);
                }
                else
                {
                    tax = AnualIncome * 0.25;
                }
                   
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
