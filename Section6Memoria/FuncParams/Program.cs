using Course;

namespace FuncParams {
    internal class Program {
        static void Main(string[] args) {
            int result = Calculator.Sum(10, 20, 30, 40);
            int res2 = Calculator.Sum(1, 2, 3, 4, 5, 6, 7, 8, 9, 10);

            Console.WriteLine(result);
            Console.WriteLine(res2);
        }
    }
}