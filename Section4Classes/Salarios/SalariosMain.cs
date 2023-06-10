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

            Console.WriteLine(f1);

            Console.Write("\nDigite a porcentagem para aumentar o salário: ");
            f1.AumentarSalario(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));

            Console.WriteLine("\nDados autalizados");
            Console.WriteLine(f1);
        }
    }
}