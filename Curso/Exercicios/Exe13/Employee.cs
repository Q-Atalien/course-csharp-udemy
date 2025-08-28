using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Curso.Exercicios.Exe13 {
    internal class Employee {
        private int Id { get; set; }
        private string Name { get; set; }
        private double Salary { get; set; }


        public Employee(int id, string name, double salary) {
            Id = id;
            Name = name;
            Salary = salary;
        }

        public void IncreaseSalary(double percentage) {

        }

        public override string ToString() {
            return $"{Id}, {Name}, {Salary}";
        }
    }
}
