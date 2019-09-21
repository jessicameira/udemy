using System;
using System.Collections.Generic;
using System.Text;

namespace udemy_secao9_aula122.Entities.Enums
{
    enum OrderStatus : int
    {
        PendingPayment,
        Processing,
        Shipped,
        Delivered
    }
}
