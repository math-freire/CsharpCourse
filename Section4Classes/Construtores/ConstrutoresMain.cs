using System.Globalization;

namespace ProdutosEmEstoque;
class ConstrutoresMain {
    static void Main(string[] args) {

        Console.WriteLine("Entre os dados do produto:");
        Console.Write("Nome: ");
        string nome = Console.ReadLine();
        Console.Write("Preço: $");
        double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        Console.Write("Quantidade no estoque: ");
        int quantidade = int.Parse(Console.ReadLine());

        Produto p = new Produto(nome, preco, quantidade);

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