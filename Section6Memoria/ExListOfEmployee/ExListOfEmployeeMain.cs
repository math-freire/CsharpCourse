using System.Globalization;

namespace ExListOfEmployee {
    internal class ExListOfEmployeeMain {
        static void Main(string[] args) {
            
            List<Employee> list = new List<Employee>();

            Console.Write("How many employees will be registered? ");
            int qtd = int.Parse(Console.ReadLine());
            for (int i = 0; i < qtd; i++) {
                Console.WriteLine($"Employee #{i+1}");
                Console.Write("Name: ");
                string name_aux = Console.ReadLine();
                Console.Write("Id: ");
                int id_aux = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Salary: ");
                double salary_aux = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Employee p1 = new Employee(name_aux, id_aux, salary_aux);
                list.Add(p1);
            }

            foreach (Employee p in list) {
                Console.WriteLine(p);
            }

        }
    }
}