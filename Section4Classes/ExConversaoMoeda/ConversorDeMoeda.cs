using System;
using System.Globalization;

namespace ExConversaoMoeda {
    class ConversorDeMoeda {

        static double Iof = 0.06;

        // O método pode ser static pois não usa nenhum instância do objeto para realizar sua lógica
        public static double ConverterMoeda(double cotacao, double qtdMoedaOrigem) {
            return (qtdMoedaOrigem * cotacao) + (qtdMoedaOrigem * cotacao) * Iof;
        }
    }
}
