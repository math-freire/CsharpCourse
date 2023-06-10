using System;
using System.Globalization;

namespace Notas {
    internal class Aluno {

        public string Nome;
        public double Nota1, Nota2, Nota3;

        public double NotaFinal() {
            return Nota1 + Nota2 + Nota3;
        }

        public string Situacao() {
            if (NotaFinal() < 60.0) {
                double faltando = 100 - NotaFinal();
                return "REPROVADO\nFALTARAM " + faltando + " PONTOS";
            } else
                return "APROVADO";

        }

        public override string ToString() {
            return "Nome: " + Nome +
                "\nNota final: " + NotaFinal().ToString("F2", CultureInfo.InvariantCulture) +
                "\n" + Situacao();
        }
    }
}
