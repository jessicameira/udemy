using System.Globalization;
using System.Collections.Generic;

namespace udemy_secao10_aula130.Entities
{
    class Employee
    {
        public string Name { get; set; }
        public int Hours { get; set; }
        public double ValuePerHour { get; set; }

        public Employee()
        {
        }

        public Employee(string name, int hours, double valuePerHour)
        {
            Name = name;
            Hours = hours;
            ValuePerHour = valuePerHour;
        }

        public virtual double Payment()
        {
            double sum = 0.0;
            sum = Hours* ValuePerHour;
            return sum;
        }
    }
}
