using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso.Exercicios {
    internal class Exe1 {
        

        public static void Executar() {
            Console.WriteLine("Exe1");

            Console.WriteLine("Coloque valor 1");
            int vA = int.Parse(Console.ReadLine());
            Console.WriteLine("Coloque valor 2");
            int vB = int.Parse(Console.ReadLine());

            Console.WriteLine($"Resultado\n{vA} + {vB} = {vA + vB}");

            Console.WriteLine("Exe2");

            Console.WriteLine("Digite o valor para calculo de area de circulo");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double result = Math.PI * Math.Pow(raio, 2);

            Console.WriteLine($"{result}");

            Console.WriteLine("Exe3");

            Console.WriteLine("Valor 1");
            int valueA = int.Parse(Console.ReadLine());
            Console.WriteLine("Valor 2");
            int valueB = int.Parse(Console.ReadLine());
            Console.WriteLine("Valor 3");
            int valueC = int.Parse(Console.ReadLine());
            Console.WriteLine("Valor 4");
            int valueD = int.Parse(Console.ReadLine());

            Console.WriteLine($"Diferença de valor de produto = {valueA * valueB - valueC * valueD}");

            Console.WriteLine("Exe4");

            Console.WriteLine("Digite seu código");
            int cod = int.Parse(Console.ReadLine());
            Console.WriteLine("Quantas horas trabalhadas?");
            int hrsTra = int.Parse(Console.ReadLine());
            Console.WriteLine("Qual o valor de suas horas?");
            double vlrHr = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double salario = hrsTra * vlrHr;

            Console.WriteLine($"Código cliente: {cod}\n Salário: {salario.ToString("F2")}");

            Console.WriteLine("Exe5");

            Console.WriteLine("Escreva o cód, a qtd de roupa e o valor:");
            string[] p1 = Console.ReadLine().Split(" ");
            Console.WriteLine("Escreva o cód, a qtd de roupa e o valor:");
            string[] p2 = Console.ReadLine().Split(" ");

            double vlrP1 = int.Parse(p1[1]) * double.Parse(p1[2], CultureInfo.InvariantCulture);
            Console.WriteLine(vlrP1);
            double vlrP2 = int.Parse(p2[1]) * double.Parse(p2[2], CultureInfo.InvariantCulture);
            Console.WriteLine(vlrP2);
            Console.WriteLine($"Valor a pagar: {vlrP1 + vlrP2}");

            Console.WriteLine("Exe6");

            Console.WriteLine("Digite 3 valores decimais");
            string[] vlrDecimal = Console.ReadLine().Split(" ");

            double a = double.Parse(vlrDecimal[0], CultureInfo.InvariantCulture);
            double b = double.Parse(vlrDecimal[1], CultureInfo.InvariantCulture);
            double c = double.Parse(vlrDecimal[2], CultureInfo.InvariantCulture);

            double trl = a * c / 2;
            double cir = Math.PI * Math.Pow(c, 2);
            double tra = (a + b) * c / 2;
            double qdd = Math.Pow(b, 2);
            double ret = a * b;

            Console.WriteLine($"Triângulo: {trl.ToString("F3", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Círculo: {cir.ToString("F3", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Trapézio: {tra.ToString("F3", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Quadrado: {qdd.ToString("F3", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Retângulo: {ret.ToString("F3", CultureInfo.InvariantCulture)}");

        }
    }
}
