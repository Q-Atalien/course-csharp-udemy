using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso.Class {
    internal class Class3 {
        public static void Executar() {
            Console.WriteLine("Qual o seu nome completo:");
            string nome = Console.ReadLine();

            Console.WriteLine("Quantos quartos tem em casa?");
            int quartos = int.Parse(Console.ReadLine());

            Console.WriteLine("Qual sua renda mensal?");
            double renda = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Segundo nome, idade e altura na mesma linha. Por favor!");
            string[] v = Console.ReadLine().Split(' ');
            string sobrenome = v[0];
            int idade = int.Parse(v[1]);
            double altura = double.Parse(v[2], CultureInfo.InvariantCulture);

            Console.WriteLine("-----Resultados-----");
            Console.WriteLine($"Você é {nome} tem {quartos} quartos em sua casa\n" +
                $"Sua renda é: {renda.ToString("F2", CultureInfo.InvariantCulture)}\n" +
                $"----------Registro---------\n" +
                $"Sobrenome {sobrenome}, idade {idade} e altura {altura.ToString("F2", CultureInfo.InvariantCulture)}.\n" +
                $"---------------------------");

        }
    }
}
