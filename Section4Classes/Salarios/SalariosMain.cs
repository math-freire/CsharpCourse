using System.Globalization;

namespace Salarios {
    internal class SalariosMain {
        static void Main(string[] args) {

            Funcionario f1 = new Funcionario();

            Console.Write("Nome: ");
            f1.Nome = Console.ReadLine();
            Console.Write("Salário Bruto: ");
            f1.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Imposto: ");
            f1.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Funcionário: " + f1.Nome + ", Salário: $" + f1.SalarioLiquido().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine();

            Console.Write("Digite a porcentagem para aumentar o salário: ");
            f1.AumentarSalario(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));

            Console.WriteLine();
            Console.WriteLine("Dados autalizados\nNome: " + f1.Nome + ", Salário: $" + f1.SalarioLiquido().ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}