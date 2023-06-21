namespace ExMatriz {
    internal class ExMatrizMain {
        static void Main(string[] args) {

            // Tell the neighbors of a chosen number

            // Matrix dimensions
            Console.Write("Lines: ");
            int m = int.Parse(Console.ReadLine());
            Console.Write("Collums: ");
            int n = int.Parse(Console.ReadLine());

            int[,] matriz = new int[m, n];

            // Matrix reading
            for (int i = 0; i < m; i++) {
                for (int j = 0; j < n; j++) {
                    Console.Write($"{i}x{j}: ");
                    matriz[i, j] = int.Parse(Console.ReadLine());
                }
            }

            Console.Write("Number to search: ");
            int num = int.Parse(Console.ReadLine());

            for (int i = 0; i < m; i++) {
                for (int j = 0; j < n; j++) {

                    if (matriz[i, j] == num) {
                        Console.WriteLine($"Position: {i}x{j}");
                        // Left neighbor
                        if (j > 0)
                            Console.WriteLine("Left: " + matriz[i, j - 1]);

                        // Right neighbor (-1 because it starts at 0)
                        if (j < n - 1)
                            Console.WriteLine("Right: " + matriz[i, j + 1]);

                        // Neighbor below (-1 because it starts at 0)
                        if (i < m - 1)
                            Console.WriteLine("Below: " + matriz[i + 1, j]);

                        // Neighbor above
                        if (i > 0)
                            Console.WriteLine("Above: " + matriz[i - 1, j]);

                        Console.WriteLine();
                    }
                }
            }
        }
    }
}