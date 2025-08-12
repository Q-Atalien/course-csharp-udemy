using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Curso.Exercicios.Exe9 {
    internal class Exe9 {
        public static void Executar() {
            Aluno a = new Aluno();

            Console.Write("Digite nome do aluno: ");
            a.Nome = Console.ReadLine();

            Console.WriteLine("Digite as 3 notas do aluno: ");
            a.NotaA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            a.NotaB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            a.NotaC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine(a);

        }
    }
}
