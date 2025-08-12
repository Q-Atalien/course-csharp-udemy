using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso.Class {
    internal class Class2 {
        public static void Executar() {
            Console.WriteLine("Digite seu nome");
            string frase = Console.ReadLine();

            Console.WriteLine($"Seu Nome É: {frase}");
            Console.WriteLine("----------Digite uma cor por vez------------");

            string x = Console.ReadLine();
            string y = Console.ReadLine();
            string z = Console.ReadLine();
            Console.WriteLine("-----------Digite três frutas-----------");
            string[] vet = Console.ReadLine().Split(' ');
            string a = vet[0];
            string b = vet[1];
            string c = vet[2];
            Console.WriteLine("-----Resultado-----");
            Console.WriteLine($"Você digitou \n{x} \n{y} \n{z}");
            Console.WriteLine($"{a} {b} {c}");
        }
    }
}
