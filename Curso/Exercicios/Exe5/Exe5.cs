using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso.Exercicios.Exe5 {
    internal class Exe5 {
        public static void Executar() {
            Pessoa p1, p2;
            p1 = new Pessoa();
            p2 = new Pessoa();

            Console.WriteLine("Dados da primeira pessoa:");
            Console.Write("Nome:");
            p1.nome = Console.ReadLine();
            Console.Write("Idade:");
            p1.idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Dados da segunda pessoa:");
            Console.Write("Nome:");
            p2.nome = Console.ReadLine();
            Console.Write("Idade:");
            p2.idade = int.Parse(Console.ReadLine());

            if(p1.idade > p2.idade) {
                Console.WriteLine($"Pessoa mais velha: {p1.nome}");
            } else {
                Console.WriteLine($"Pessoa mais velha: {p2.nome}");
            }

             //tenario
            string x = p1.idade > p2.idade ? p1.nome : p2.nome;

            Console.WriteLine($"Pessoa mais velha: {x}");
        }
    }
}
