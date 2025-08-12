using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso.Exercicios {
    internal class Exe3 {
        public static void Executar() {
            //Console.WriteLine("-----Exe1-----");
            //Console.WriteLine("Digite sua senha");

            //int senha = int.Parse(Console.ReadLine());

            //while (senha != 2002) {
            //    Console.WriteLine("Senha incorreta! \nDigite novamente: ");
            //    senha = int.Parse(Console.ReadLine());
            //}

            //Console.WriteLine("Acesso permitido");

            //Console.WriteLine("-----Exe2-----");
            //Console.WriteLine("Digite dois valores");
            //string[] quadrante = Console.ReadLine().Split(" ");
            //int x = int.Parse(quadrante[0]);
            //int y = int.Parse(quadrante[1]);

            //while (x != 0 || y != 0) { 
            //    if (x > 0 && y > 0) {
            //        Console.WriteLine("Primeiro");
            //    }else if (x > 0 && y < 0) {
            //        Console.WriteLine("Quarto");
            //    }else if (x < 0 && y < 0) {
            //        Console.WriteLine("Terceiro");
            //    } else {
            //        Console.WriteLine("Segundo");
            //    }

            //    Console.WriteLine("Digite dois valores");
            //    quadrante = Console.ReadLine().Split(" ");
            //    x = int.Parse(quadrante[0]);
            //    y = int.Parse(quadrante[1]);
            //}

            Console.WriteLine("-----Exe3-----");
            Console.WriteLine("-----\nEscolha um número:\n" +
                "1. Álcool \n2. Gasolina \n3. Diesel\n4. Fim\n-----");

            int cod = int.Parse(Console.ReadLine());
            int a = 0, g = 0, d = 0;

            while ( cod != 4) {
                if( cod > 4 || cod < 0) {
                    Console.WriteLine("Número inválido!");
                } else if ( cod == 1) {
                    a++;
                } else if (cod == 2) {
                    g++;
                } else {
                    d++;
                }

                Console.WriteLine("-----\nEscolha um número:\n" +
                "1. Álcool \n2. Gasolina \n3. Diesel\n4. Fim\n-----");
                cod = int.Parse(Console.ReadLine());
            }

            Console.WriteLine($"Muito Obrigada!\nAlcool: {a}\r\nGasolina: {g}\r\nDiesel: {d}");
        }
    }
}
