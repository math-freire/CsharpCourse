using System;

namespace ExVetores {
    internal class Estudante {

        public string Nome { get; set; }
        public string Email { get; set; }

        public override string ToString() {
            return "Nome: " + Nome + ", email: " + Email;
        }
    }
}
