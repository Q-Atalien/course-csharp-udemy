using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso.Exercicios {
    internal class Exe2 {
        public static void Executar() {

            Console.WriteLine("-----Ex 1-----");
            Console.WriteLine("Digite um número:");

            int n = int.Parse(Console.ReadLine());
            if (n <= 0) {
                Console.WriteLine("É negativo");

            } else {
                Console.WriteLine("Não é negativo");
            }

            Console.WriteLine("-----Ex 2-----");
            Console.WriteLine("Digite um número:");

            int num = int.Parse(Console.ReadLine());

            if (num % 2 == 0) {
                Console.WriteLine("Par");
            } else {
                Console.WriteLine("Impar");
            }


            Console.WriteLine("-----Ex 3-----");

            Console.WriteLine("Digite um número:");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite um número:");
            int b = int.Parse(Console.ReadLine());

            if (a >= b) {
                if (a % b == 0) {
                    Console.WriteLine("É múltiplo");
                } else {
                    Console.WriteLine("Não é múltiplo");
                }
            } else {
                if (b % a == 0) {
                    Console.WriteLine("É múltiplo");
                } else {
                    Console.WriteLine("Não é múltiplo");
                }
            }

            Console.WriteLine("-----Ex 4-----");
            Console.WriteLine("Digite dois número de 0 a 23:");
            string[] horas = Console.ReadLine().Split(" ");
            int hora1 = int.Parse(horas[0]);
            int hora2 = int.Parse(horas[1]);

            if (hora1 == 0) hora1 = 24;
            if (hora2 == 0) hora2 = 24;

            if (hora1 == hora2) {
                Console.WriteLine("O JOGO DUROU 24 HORA(S)");
            } else if (hora1 > hora2) {
                int vlrHora1 = 24 - hora1;
                int result = vlrHora1 + hora2;
                Console.WriteLine($"O JOGO DUROU {result} HORA(S)");
            } else {
                int vlrHora1 = hora1 - hora2;
                Console.WriteLine($"O JOGO DUROU {Math.Abs(vlrHora1)} HORA(S)");
            }

            Console.WriteLine("-----Ex 5-----");
            Console.WriteLine("Digite código e quatidade do produto");
            string[] pedido = Console.ReadLine().Split(" ");

            int cod = int.Parse(pedido[0]);
            int qtd = int.Parse(pedido[1]);

            if (cod == 1) {
                double vlr = 4.00;
                Console.WriteLine($"Total: R${vlr * qtd}");

            } else if (cod == 2) {
                double vlr = 4.50;
                Console.WriteLine($"Total: R${vlr * qtd}");

            } else if (cod == 3) {
                double vlr = 5.00;
                Console.WriteLine($"Total: R${vlr * qtd}");

            } else if (cod == 4) {
                double vlr = 2.00;
                Console.WriteLine($"Total: R${vlr * qtd}");

            } else {
                double vlr = 1.50;
                Console.WriteLine($"Total: R${vlr * qtd}");

            }

            Console.WriteLine("-----Ex 6-----");
            Console.WriteLine("Digite um valor decimal");
            double valores = double.Parse(Console.ReadLine());

            if (valores < 0 || valores > 100) {
                Console.WriteLine("Fora de intervalo");
            } else if (valores <= 25) {
                Console.WriteLine("Intervalo 0, 25");
            } else if (valores <= 50) {
                Console.WriteLine("Intervalo 25, 50");
            } else if (valores <= 75) {
                Console.WriteLine("Intervalo 50, 75");
            } else if (valores <= 100) {
                Console.WriteLine("Intervalo 75, 100");
            }

            Console.WriteLine("-----Ex 7-----");
            Console.WriteLine("Digiste dois valores decimais");
            string[] vlrFlutuante = Console.ReadLine().Split(" ");

            double x = double.Parse(vlrFlutuante[0]);
            double y = double.Parse(vlrFlutuante[1]);

            if (x > 0 && y > 0) {
                Console.WriteLine("Q1");
            } else if (x < 0 && y > 0) {
                Console.WriteLine("Q2");
            } else if (x > 0 && y < 0) {
                Console.WriteLine("Q4");
            } else if (x == 0 && y == 0) {
                Console.WriteLine("Origem");
            } else {
                Console.WriteLine("Q3");
            }

            Console.WriteLine("-----Ex 8-----");
            Console.WriteLine("Digite sua renda:");
            double renda = double.Parse(Console.ReadLine());


            if (renda < 2000.00) {
                Console.WriteLine("Isento");
            } else {
                if (renda > 2000.00 && renda < 3000.00) {
                    double v = renda - 2000.00;
                    double r = v * 8 / 100;
                    Console.WriteLine($"R$ {r:F2}");
                }

                if (renda > 3000.00 && renda < 4500.00) {
                    double v = renda - 3000.00;
                    double r = v * 18 / 100 + 80;
                    Console.WriteLine($"R$ {r:F2}");
                }

                if (renda > 4500.00) {
                    double v = renda - 4500.00;
                    double r = v * 28 / 100 + 270 + 80;
                    Console.WriteLine($"R$ {r:F2}");
                }
            }
        }
    }
}
