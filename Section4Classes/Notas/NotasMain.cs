using System.Globalization;

namespace Notas {
    internal class NotasMain {
        static void Main(string[] args) {
            
            Aluno a1 = new Aluno();

            Console.Write("Digite o nome do aluno: ");
            a1.Nome = Console.ReadLine();

            Console.WriteLine("Digite as três notas do aluno:");
            a1.Nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            a1.Nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            a1.Nota3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine();
            Console.WriteLine(a1);
        }
        
    }
}