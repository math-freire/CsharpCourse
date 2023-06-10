namespace Section4Classes {
    class Triangulo {

        // Atributos da classe
        public double A;
        public double B;
        public double C;

        // Métodos da classe
        public double Area() {
            double p = (A + B + C) / 2.0;
            return Math.Sqrt(p*(p-A)*(p-B)*(p-C));
        }

    }
}
