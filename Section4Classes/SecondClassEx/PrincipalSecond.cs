using System;
using System.Globalization;

namespace SecondClassEx {
    internal class PrincipalFirst {
        static void Main(string[] args) {

            Pessoa a = new Pessoa();
            Pessoa b = new Pessoa();

            a.Nome = "Carlos Silva";
            a.Salario = 6300.00;
            b.Nome = "Ana Marques";
            b.Salario = 6700.00;

            double media = (a.Salario + b.Salario) / 2.0;
            Console.WriteLine("Salário médio = R$" + media.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}