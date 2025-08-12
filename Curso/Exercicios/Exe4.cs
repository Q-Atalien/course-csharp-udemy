using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso.Exercicios {
    internal class Exe4 {
        public static void Executar() {
            Console.WriteLine("-----Exe 1-----");
            Console.WriteLine("Digite um número");

            int x = int.Parse(Console.ReadLine());

            for (int i = 1; i <= x; i++) {
                if (i % 2 == 1) {
                    Console.WriteLine($"Ímpar {i}");
                }
            }

            Console.WriteLine("-----Exe 2-----");
            Console.WriteLine("Digite um número:");
            int n = int.Parse(Console.ReadLine());

            int dentro = 0, fora = 0;

            for (int i = 1; i <= n; i++) {
                Console.WriteLine("Digite um número:");
                int vlr = int.Parse(Console.ReadLine());
                if (vlr >= 10 && vlr <= 20) {
                    dentro++;
                } else {
                    fora++;
                }
            }

            Console.WriteLine($"{dentro} in\n{fora} out");

            Console.WriteLine("-----Exe 3-----");
            Console.Write("Digite um número: ");
            int vlrI = int.Parse(Console.ReadLine());

            for (int i = 0; i < vlrI; i++) {
                Console.WriteLine("Digite 3 valores");
                string[] teste = Console.ReadLine().Split(" ");

                double a = double.Parse(teste[0], CultureInfo.InvariantCulture);
                double b = double.Parse(teste[1], CultureInfo.InvariantCulture);
                double c = double.Parse(teste[2], CultureInfo.InvariantCulture);

                double media = (a * 2.0 + b * 3.0 + c * 5.0) / 10.0;

                Console.WriteLine(media.ToString("F1", CultureInfo.InvariantCulture));
            }

            Console.WriteLine("-----Exe 4-----");
            Console.Write("Digite número: ");
            int qtd = int.Parse(Console.ReadLine());

            for (int i = 0; i < qtd; i++) {
                Console.WriteLine("Dois numeros");
                string[] xn = Console.ReadLine().Split(" ");

                double x1 = double.Parse(xn[0]);
                double n1 = double.Parse(xn[1]);

                if (n1 == 0) {
                    Console.WriteLine("Divisão impossivel");
                } else {
                    double r = x1 / n1;
                    Console.WriteLine(r.ToString("F1", CultureInfo.InvariantCulture));
                }

            }

            Console.WriteLine("-----Exe 5-----");
            Console.Write("Digite número: ");
            int vlrN = int.Parse(Console.ReadLine());
            int fatorial = vlrN;

            if (vlrN == 0) {
                Console.WriteLine(1);

            } else {
                for (int i = vlrN - 1; i != 0; i--) {

                    fatorial *= i;
                }
            }

            Console.WriteLine(fatorial);

            Console.WriteLine("-----Exe 6-----");
            Console.WriteLine("Digite um número");
            int numero = int.Parse(Console.ReadLine());

            for (int i = 1; i <= numero; i++) {
                if (numero % i == 0) {
                    Console.WriteLine(i);
                }
            }

            Console.WriteLine("-----Exe 7-----");
            Console.Write("Digite um número positivo: ");
            int numPos = int.Parse(Console.ReadLine());

            for (int i = 1; i <= numPos; i++) {
                Console.WriteLine($"{i} {Math.Pow(i, 2)} {Math.Pow(i, 3)}");
            }

        }
    }
}
