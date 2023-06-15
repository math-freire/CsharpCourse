using System;
using System.Collections.Generic;
using System.Globalization;

namespace ExListOfEmployee {
    internal class Employee {

        public Employee(string name, int id, double salary) {
            Name = name;
            Id = id;
            Salary = salary;
        }

        public int Id { get; private set; }
        public string Name { get; set; }
        public double Salary { get; private set; }

        public void IncreaseSalary(double percentage) {
            Salary += Salary * percentage / 100;
        }

        public override string ToString() {
            return $"Name: {Name}, Id: {Id}, Salary: {Salary.ToString("F2", CultureInfo.InvariantCulture)}";
        }

    }
}
