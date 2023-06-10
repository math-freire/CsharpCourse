using System;
using System.Globalization;


namespace Course {
    class Program {
        static void Main(string[] args) {

            string produto1 = "Computador";
            string produto2 = "Mesa de escritório";

            byte idade = 30;
            int codigo = 5290;
            char genero = 'M';

            double preco1 = 2100.0;
            double preco2 = 650.50;
            double medida = 53.234567;

            Console.WriteLine("Produtos:");
            Console.WriteLine($"{produto1}, cujo preço é ${preco1}");
            Console.WriteLine($"{produto2}, cujo preço é ${preco2}");
            Console.WriteLine();
            Console.WriteLine($"Registro: {idade} anos de idade, código {codigo} e gênero: {genero}"); // Método da interpolação
            Console.WriteLine();
            Console.WriteLine("Medida com oito casas decimais: " + medida); // Método da concatenação
            Console.WriteLine("Arredondando (três casas decimais): {0:F3}", medida); // Método PlaceHolder
            Console.WriteLine("Separador decimal invariant culture: " + medida.ToString("F3", CultureInfo.InvariantCulture));

            Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-");

            /*
            int n1 = int.Parse(Console.ReadLine());
            char ch = char.Parse(Console.ReadLine());
            double n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            string[] vet = Console.ReadLine().Split(' ');
            string nome = vet[0];
            char sexo = char.Parse(vet[1]);
            int idade2 = int.Parse(vet[2]);
            double altura = double.Parse(vet[3], CultureInfo.InvariantCulture);
            Console.WriteLine("Você digitou:");
            Console.WriteLine(n1);
            Console.WriteLine(ch);
            Console.WriteLine(n2.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(nome);
            Console.WriteLine(sexo);
            Console.WriteLine(idade2);
            Console.WriteLine(altura.ToString("F2", CultureInfo.InvariantCulture));

            Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-");
            */

            Console.WriteLine("Entre com seu nome completo: ");
            string nome = Console.ReadLine();
            Console.WriteLine("Quantos quartos tem sua casa? ");
            int quartos = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o preço de um produto: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture); // Leitura com separador decimal ponto (2.34)
            Console.WriteLine("Entre com seu último nome, idade e altura (mesma linha separado por espaços): ");
            string[] dadosPessoa = Console.ReadLine().Split(' ');
            string lastName = dadosPessoa[0];
            int idade3 = int.Parse(dadosPessoa[1]);
            double altura = double.Parse((dadosPessoa[2]), CultureInfo.InvariantCulture);

            Console.WriteLine("Aqui estão os dados digitados:");
            Console.WriteLine(nome);
            Console.WriteLine(quartos);
            Console.WriteLine(preco.ToString("F2", CultureInfo.InvariantCulture)); // Duas casas decimais no preço e separador por ponto
            Console.WriteLine(lastName);
            Console.WriteLine(idade3);
            Console.WriteLine(altura.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}