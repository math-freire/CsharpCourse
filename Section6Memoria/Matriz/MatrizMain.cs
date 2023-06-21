namespace Matriz {
    internal class MatrizMain {
        static void Main(string[] args) {

            Console.Write("Entre com a ordem da matriz: ");
            int n = int.Parse(Console.ReadLine());

            int[,] mat = new int[n, n];
            int negativo = 0;
            int[] diagonalPrincipal = new int[n];

            for (int i = 0; i < n; i++) {
                for (int j = 0; j < n; j++) {

                    Console.Write($"{i}x{j}: ");
                    mat[i, j] = int.Parse(Console.ReadLine());

                    if (mat[i, j] < 0)
                        negativo++;

                    if (i == j)
                        diagonalPrincipal[i] = mat[i, j];
                }
            }


            Console.WriteLine("Diagonal principal:");
            for(int i  = 0; i < n; i++) {
                Console.Write(diagonalPrincipal[i] + " ");
            }
            Console.WriteLine();

            Console.WriteLine("Qtd. de números negativos: " + negativo);
        }
    }
}
