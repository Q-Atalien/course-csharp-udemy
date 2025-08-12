using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Curso.Exercicios.Exe8 {
    internal class Exe8 {
        public static void Executar() {
            Funcionario f = new Funcionario();

            Console.Write("Digite nome do funcionário: ");
            f.Nome = Console.ReadLine();

            Console.Write("\nDigite o salário do funcionário: ");
            f.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("\nDigite os descontos de imposto: ");
            f.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine(f);

            Console.Write("\nDigite a porcentagem para aumentar o salário: ");
            f.AumentarSalario(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));

            Console.WriteLine("\nDados atualizados:\n" + f);
        }
    }
}
