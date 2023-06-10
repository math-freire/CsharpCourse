using System;
using System.Globalization;

namespace Notas {
    internal class Aluno {

        public string Nome;
        public double Nota1;
        public double Nota2;
        public double Nota3;

        public double Nota() {
            return Nota1 + Nota2 + Nota3;
        }

        public string Situacao() {
            if (Nota() < 60.0)
                return "REPROVADO";
            else
                return "APROVADO";
        }

        public override string ToString() {
            return "Nome: " + Nome +
                "\nNota final: " + Nota().ToString("F2", CultureInfo.InvariantCulture) +
                "\n" + Situacao();
        }
    }
}
