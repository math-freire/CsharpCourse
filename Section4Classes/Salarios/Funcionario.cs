

using System.Globalization;

namespace Salarios {
    internal class Funcionario {

        public string Nome;
        public double SalarioBruto;
        public double Imposto;

        public void AumentarSalario(double porcentagem) {
            SalarioBruto += (SalarioBruto * porcentagem / 100);
        }

        public double SalarioLiquido() {
            return SalarioBruto - Imposto;
        }

        public override string ToString() {
            return "Nome: " + Nome + ", Salário: $" + SalarioLiquido().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}

