using System;
using System.Globalization;

namespace ContaBancaria {
    internal class ContaBancariaMain {
        static void Main(string[] args) {
       
            double deposit = 0;
            Conta cc;

            Console.Write("Entre com o número da conta: ");
            int num = int.Parse(Console.ReadLine());

            Console.Write("Entre com o titular da conta: ");
            string tit = Console.ReadLine();

            Console.Write("Haverá depósito inicial (s/n)? ");
            string resposta = Console.ReadLine().ToLower();


             // TODO: NECESSARIO TIRAR A CRIAÇÃO DOS OBJETOS DE DENTRO DOS IF ELSE
            if (resposta == "s") {
                Console.Write("Entre o valor de depósito inicial: ");
                deposit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                cc = new Conta(tit, num, deposit);
                Console.WriteLine(cc);
            } else {
                cc = new Conta(tit, num);
                Console.WriteLine(cc);
            }

            Console.Write("Entre um valor para depósito: ");
            cc.Depositar(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));
            Console.WriteLine("Dados atualizados");
            Console.WriteLine(cc);

            Console.Write("Entre um valor para saque: ");
            cc.Saque(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));
            Console.WriteLine("Dados atualizados");
            Console.WriteLine(cc);

        }
    }
}