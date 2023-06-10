

using System.Globalization;

namespace PropriedadesRetangulo {
    internal class Retangulo {

        public double Largura;
        public double Altura;

        public double Area() {
            return Largura * Altura;
        }

        public double Perimetro() {
            return 2.0 * (Largura + Altura);
        }

        public double Diagonal() {
            return Math.Sqrt(Largura * Largura + Altura * Altura);
        }

        public override string ToString() {
            return
                  "\nAREA: " + Area().ToString("F2", CultureInfo.InvariantCulture)
                + "\nPERIMETRO: " + Perimetro().ToString("F2", CultureInfo.InvariantCulture)
                + "\nDIAGONAL: " + Diagonal().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
