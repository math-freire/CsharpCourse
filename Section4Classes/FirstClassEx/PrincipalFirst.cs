using System;

namespace FirstClassEx {
    internal class PrincipalFirst {
        static void Main(string[] args) {

            Pessoa a = new Pessoa();
            Pessoa b = new Pessoa();

            a.Nome = "Maria";
            a.Idade = 17;
            b.Nome = "João";
            b.Idade = 16;

            if (a.Idade < b.Idade)
                Console.WriteLine("Pessoa mais velha: " + b.Nome);
            else
                Console.WriteLine("Pessoa mais velha: " + a.Nome);
        }
    }
}