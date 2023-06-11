using System;
using System.Globalization;
using System.Reflection.Metadata;

namespace ContaBancaria {
    internal class Conta {

        private string _titular;
        public int Numero { get; private set; }
        public double Saldo { get; private set; }

        public string Titular {
            get { return _titular; }
            set {
                if (value != null)
                    _titular = value;
            }
        }

        public Conta(string nome, int conta, double deposito) {
            _titular = nome;
            Numero = conta;
            Saldo = deposito;
        }
        public Conta(String nome, int conta) {
            _titular = nome;
            Numero = conta;
        }

        public void Depositar(double valor) {
            Saldo += valor;
        }

        public void Saque(double valor) {
            if(valor > 0 )
                Saldo -= (5 + valor);
        }

        public override string ToString() {
            return "Nome: " + Titular + ", número de conta: " + Numero + ", Saldo: R$" + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
