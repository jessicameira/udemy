using System;
using System.Collections.Generic;
using System.Text;

namespace udemy_secao9_aula122.Entities
{
    class Client
    {
        public string NameClient { get; set; }
        public string EmailClient { get; set; }
        public DateTime BirthdayClient { get; set; }

        public Client()
        {
        }

        public Client(string nameClient, string emailClient, DateTime birthdayClient)
        {
            NameClient = nameClient;
            EmailClient = emailClient;
            BirthdayClient = birthdayClient;
        }
        public override string ToString()
        {
            return NameClient + ", " + BirthdayClient.ToString("dd/mm/yyyy") + ", " + EmailClient;
          
        }
    }
}
