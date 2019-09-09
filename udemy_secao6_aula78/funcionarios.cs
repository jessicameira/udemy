using System;
using System.Collections.Generic;
using System.Globalization;

namespace udemy_secao6_aula78
{
    class funcionarios
    {
        public int Id { get; set; }
        public string Nome { get; set; }

        public double Salario { get; set; }

        public funcionarios()
        {
        }

        public funcionarios(int id, double salario)
        {
            Id = id;
            Salario = salario;
        }

        public funcionarios(int id, string nome, double salario)
        {
            Id = id;
            Nome = nome;
            Salario = salario;
        }

        public void aumentoSalario(double salario)
        {
            Salario += Salario * salario / 100;
        }

        public override string ToString()
        {
            return "Id "
                + Id
                + ", Nome: "
                + Nome
                + ", Salario: $"
                + Salario.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
