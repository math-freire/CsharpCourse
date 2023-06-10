

using System.Globalization;

namespace ProdutosEmEstoque;
class EstoqueMain {
    static void Main(string[] args) {

        Produto p = new Produto();

        Console.WriteLine("Entre os dados do produto:");
        Console.Write("Nome: ");
        p.Nome = Console.ReadLine();
        Console.Write("Preço: $");
        p.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        Console.Write("Quantidade no estoque: ");
        p.Quantidade = int.Parse(Console.ReadLine());

        Console.WriteLine();
        Console.WriteLine("Dados do produto: " + p);

        Console.Write("\nDigite o número de produtos a serem adicionados no estoque: ");
        int qtd = int.Parse(Console.ReadLine());
        p.AdicionarProduto(qtd);

        Console.WriteLine("\nDados atualizados: " + p);

        Console.Write("\nDigite o número de produtos a serem removidos do estoque: ");
        qtd = int.Parse(Console.ReadLine());
        p.RemoverProduto(qtd);

        Console.WriteLine("\nDados atualizados: " + p);
    }
}