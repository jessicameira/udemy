using System;
using System.Collections.Generic;
using System.Text;
using udemy_secao9_aula115.entities.Enums;

namespace udemy_secao9_aula115.entities
{
    class order
    {
        public int Id { get; set; }
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }

        public override string ToString()
        {
            return Id
                + ", "
                + Moment
                +", "
                + Status;
        }
    }
}
