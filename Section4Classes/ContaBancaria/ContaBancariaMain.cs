using System;

namespace ContaBancaria {
    internal class ContaBancariaMain {
        static void Main(string[] args) {

            int num;
            string tit;
            double deposit = 0;

            Console.Write("Entre com o número da conta: ");
            num = int.Parse(Console.ReadLine());

            Console.Write("Entre com o titular da conta: ");
            tit = Console.ReadLine();

            Console.Write("Haverá depósito inicial (s/n)? ");
            string resposta = Console.ReadLine();
            if (resposta == "s") {
                Console.Write("Entre o valor de depósito inicial: ");
                deposit = double.Parse(Console.ReadLine());
                Conta c = new Conta(tit, num, deposit);
                Console.WriteLine(c);
            } else {
                Conta c = new Conta(tit, num);
                Console.WriteLine(c);
            }

            Console.WriteLine();


        }
    }
}