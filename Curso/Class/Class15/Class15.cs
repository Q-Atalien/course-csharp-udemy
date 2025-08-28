using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Net.Http.Headers;

namespace Curso.Class.Class15 {
    internal class Class15 {
        public static void Executar() {

            Console.Write("Quantos produtos irá cadastrar: ");
            int quantidadeProdutos = int.Parse(Console.ReadLine());

            Produto[] produtos = new Produto[quantidadeProdutos];

            for (int i = 0; i < quantidadeProdutos; i++) {
                Console.Write("Digite o nome do " + (i + 1) + "° produto: ");
                string nome = Console.ReadLine();

                Console.Write("Digite o preço do " + (i + 1) + "° produto: ");
                double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                produtos[i] = new Produto {
                    Nome = nome,
                    Preco = preco
                };
            }

            double soma = 0.0;

            foreach (Produto produto in produtos) {
                soma += produto.Preco;
            }

            double media = soma / quantidadeProdutos;

            Console.WriteLine("Media de valores: " + media.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
