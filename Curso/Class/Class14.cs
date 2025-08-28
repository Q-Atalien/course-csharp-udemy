using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Curso.Class {
    internal class Class14 {
        public static void Executar() {
            Console.Write("Digite o número de pessoas: ");
            int quantidadePessoas = int.Parse(Console.ReadLine());

            double[] alturas = new double[quantidadePessoas];

            for (int i = 0; i < alturas.Length; i++) {
                Console.Write("Digite a altura da " + (i + 1) + "° pessoa: ");
                alturas[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            double soma = 0.0;

            foreach (double altura in alturas) {
                soma += altura;
            }

            double media = soma / quantidadePessoas;

            Console.WriteLine("Altura média = " + media.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
