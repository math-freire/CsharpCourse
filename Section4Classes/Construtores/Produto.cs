using System.Globalization;

namespace ProdutosEmEstoque {
    internal class Produto {

        private string _nome;
        private double _preco;
        private int _quantidade;

        public Produto(string nome, double preco, int quantidade) {
            _nome = nome;
            _preco = preco;
            _quantidade = quantidade;
        }

        public Produto(string nome, double preco) {
            _nome = nome;
            _preco = preco;
            _quantidade = 0; // Opcional, pois já começa com 0
        }

        public string Nome {
            get { return _nome; }
            set {
                if (_nome != null && _nome.Length > 1)
                    _nome = value;
            }
        }

        public double Preco {
            get { return _preco; }
        }

        public int Quantidade {
            get { return _quantidade; }
        }

        public void AdicionarProduto(int quantidade) {
            _quantidade += quantidade;
        }

        public void RemoverProduto(int quantidade) {
            _quantidade -= quantidade;
        }

        public double ValorTotalEmEstoque() {
            return _preco * _quantidade;
        }

        public override string ToString() {
            return _nome + ", $" + Preco.ToString("F2", CultureInfo.InvariantCulture)
                + ", " + _quantidade + " unidades, Total: $"
                + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
