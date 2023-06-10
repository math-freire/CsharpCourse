using System;
using System.Globalization;

namespace ExConversaoMoeda {
    internal class ConversorMain {
        static void Main(string[] args) {

            Console.Write("Qual a cotação do dólar? ");
            double cot = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantos dólares você vai comprar? ");
            double dol = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Valor a ser pago em reais: R$" + ConversorDeMoeda.ConverterMoeda(cot, dol).ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}