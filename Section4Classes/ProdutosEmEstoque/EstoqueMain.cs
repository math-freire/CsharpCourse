

using System.Globalization;

namespace ProdutosEmEstoque;
class EstoqueMain {
    static void Main(string[] args) {

        Produto p = new Produto();

        Console.WriteLine("Entre os dados do produto:");
        Console.WriteLine("Nome: ");
        p.Nome = Console.ReadLine();
        Console.WriteLine("Preço: ");
        p.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        Console.WriteLine("Quantidade no estoque: ");
        p.Quantidade = int.Parse(Console.ReadLine();

        
    }
}