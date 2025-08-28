using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso.Exercicios.Exe11 {
    internal class Exe11 {
        public static void Executar() {
            Console.Write("Entre o número da conta: ");
            int numeroConta = int.Parse(Console.ReadLine());

            Console.Write("Entre o titular da conta: ");
            string titularConta = Console.ReadLine();

            Console.Write("Haverá depósito inicial (s/n)? ");
            char resposta = char.Parse(Console.ReadLine().ToLower());

            Conta conta;
            if (resposta == 's') {
                Console.Write("Entre com o valor de depósito inicial: ");
                double depositoInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                conta = new Conta(numeroConta, titularConta, depositoInicial);

            } else {
                conta = new Conta(numeroConta, titularConta);

            }

            Console.WriteLine();
            Console.WriteLine(conta);

            Console.WriteLine();
            Console.Write("Entre com valor para depósito: ");
            double deposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Deposito(deposito);
            Console.WriteLine(conta);

            Console.WriteLine();
            Console.Write("Entre com valor para saque: ");
            double saque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Saque(saque);
            Console.WriteLine(conta);

        }
    }
}
