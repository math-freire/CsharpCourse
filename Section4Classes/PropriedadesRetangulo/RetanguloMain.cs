using System.Globalization;

namespace PropriedadesRetangulo {
    internal class RetanguloMain {
        static void Main(string[] args) {

            Retangulo r1 = new Retangulo();

            Console.Write("Entre com a largura do retângulo: ");
            r1.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Agora entre com a altura: ");
            r1.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine(r1);
        }
    }
}