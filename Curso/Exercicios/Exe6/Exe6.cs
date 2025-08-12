using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso.Exercicios.Exe6 {
    internal class Exe6 {
        public static void Executar() {
            Salario f1, f2;
            f1 = new Salario();
            f2 = new Salario();

            Console.WriteLine("Dados do primeiro funcionário:");
            Console.Write("Nome:");
            f1.nome = Console.ReadLine();
            Console.Write("Salário:");
            f1.salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Dados do segundo funcionário:");
            Console.Write("Nome:");
            f2.nome = Console.ReadLine();
            Console.Write("Salário:");
            f2.salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double media = (f2.salario + f1.salario)/2.0;
            Console.WriteLine($"Salário médio: {media:f2}");

        }
    }
}
