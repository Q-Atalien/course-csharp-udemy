using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso.Exercicios.Exe12 {
    internal class Exe12 {
        public static void Executar() {

            Console.Write("Quantos quartos serão alugados? ");
            int quantidadeReserva = int.Parse(Console.ReadLine());

            Reserva[] reservas = new Reserva[10];

            for (int i = 0; i < quantidadeReserva; i++) {
                Console.WriteLine();

                Console.WriteLine($"Aluguel #{i + 1}: ");
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Quarto: ");
                int quarto = int.Parse(Console.ReadLine());

                reservas[quarto] = new Reserva {
                    Nome = nome,
                    Email = email,
                    Quarto = quarto
                };
            }

            Console.WriteLine();
            Console.WriteLine("Quartos ocupados:");
            foreach (Reserva reserva in reservas) {
                Console.WriteLine(reserva);

            }
        }
    }
}
