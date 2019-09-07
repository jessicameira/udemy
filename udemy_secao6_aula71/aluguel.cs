using System;
using System.Collections.Generic;
using System.Text;

namespace udemy_secao6_aula71
{
    class aluguel
    {
        public string NomeEstudante { get; set; }
        public string EmailEstudante { get; set; }
        public int NumeroQuarto { get; set; }

        public aluguel(string nomeEstudante, string emailEstudante, int numeroquarto)
        {
            NomeEstudante = nomeEstudante;
            EmailEstudante = emailEstudante;
            NumeroQuarto = numeroquarto;
        }

        public override string ToString()
        {
            return NumeroQuarto
                + ", "
                + NomeEstudante
                + ", Email: "
                + EmailEstudante;
        }
    }
}
