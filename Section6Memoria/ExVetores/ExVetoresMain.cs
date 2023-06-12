
namespace ExVetores {
    internal class ExVetoresMain {
        static void Main(string[] args) {

            Estudante[] quartos = new Estudante[10];

            Console.Write("Quantos quartos serão alugados? ");
            int qtd = int.Parse(Console.ReadLine());

            for (int i = 0; i < qtd; i++) {
                quartos[i] = new Estudante();

                Console.Write($"Nome do estudante que ficará no quarto {i+1}: ");
                quartos[i].Nome = Console.ReadLine();
                Console.Write("Digite o email do estudante: ");
                quartos[i].Email = Console.ReadLine();
            }

            Console.WriteLine();
            Console.WriteLine("Lista quartos alugados");
            for (int i = 0; i < quartos.Length; i++) {
                Console.WriteLine(quartos[i]);
            }
        }
    }
}