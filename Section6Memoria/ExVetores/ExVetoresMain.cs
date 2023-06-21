
namespace ExVetores {
    internal class ExVetoresMain {
        static void Main(string[] args) {

            Estudante[] quartos = new Estudante[10];

            Console.Write("Quantos quartos serão alugados? ");
            int qtd = int.Parse(Console.ReadLine());

            for (int i = 0; i < qtd; i++) {

                Console.WriteLine();
                Console.WriteLine($"#{i+1} aluguel:");

                Console.Write("Quarto desejado: ");
                int numQuarto = int.Parse(Console.ReadLine());
                quartos[numQuarto] = new Estudante();
                Console.Write($"Nome do estudante que ficará no quarto {numQuarto}: ");
                quartos[numQuarto].Nome = Console.ReadLine();
                Console.Write("Digite o email do estudante: ");
                quartos[numQuarto].Email = Console.ReadLine();
            }

            Console.WriteLine();
            Console.WriteLine("Lista quartos alugados");
            for (int i = 0; i < quartos.Length; i++) {
                if (quartos[i] != null)
                    Console.WriteLine($"Quarto {i + 1}: " + quartos[i]);
                else
                    Console.WriteLine($"Quarto {i + 1} está disponível!");
            }
        }
    }
}