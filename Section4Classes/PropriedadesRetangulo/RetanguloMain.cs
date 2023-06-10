using System.Globalization;

namespace PropriedadesRetangulo {
    internal class RetanguloMain {
        static void Main(string[] args) {

            Retangulo r1 = new Retangulo();

            Console.WriteLine("Entre com a largura e altura do retângulo (separado por enter): ");
            r1.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            r1.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine(r1);
        }
    }
}