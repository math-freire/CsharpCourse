

namespace Salarios {
    internal class Funcionario {

        public string Nome;
        public double SalarioBruto;
        public double Imposto;

        public void AumentarSalario(double porcentagem) {
            SalarioBruto += (SalarioBruto * (porcentagem / 100));
        }

        public double SalarioLiquido() {
            return SalarioBruto - Imposto;
        }

    }
}

