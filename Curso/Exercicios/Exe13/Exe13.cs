using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;

namespace Curso.Exercicios.Exe13 {
    internal class Exe13 {
        public static void Executar() {
            Console.Write("How many employees will be registered? ");
            int recordQuantity = int.Parse(Console.ReadLine());

            List<Employee> employees = new List<Employee>();

            for (int i = 0; i < recordQuantity; i++) {
                Console.WriteLine($"Employee #{i}");
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Salary: ");
                double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                employees.Add(new Employee(id, name, salary));
            }
        }
    
    }
}
