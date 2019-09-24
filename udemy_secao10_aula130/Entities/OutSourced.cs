using System.Globalization;
using System.Collections.Generic;

namespace udemy_secao10_aula130.Entities
{
    class OutSourced : Employee
    {
        public double AdditionalCharge { get; set; }

        public OutSourced()
        {
        }

        public OutSourced(string name, int hours, double valueperhour, double additionalCharge) :base(name,hours,valueperhour)
        {
            AdditionalCharge = additionalCharge;
        }
        public override double Payment()
        {
            return base.Payment() + 1.1 * AdditionalCharge;

        }
    }

}
