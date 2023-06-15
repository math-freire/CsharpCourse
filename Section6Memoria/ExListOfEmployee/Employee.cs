using System;
using System.Collections.Generic;

namespace ExListOfEmployee {
    internal class Employee {

        public int Id { get; private set; }
        public string Name { get; set; }
        public double Salary { get; private set; }

        public void IncreaseSalary(double percentage) {
            Salary += Salary * percentage / 100;
        }

    }
}
