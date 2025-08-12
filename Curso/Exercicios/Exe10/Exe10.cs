using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Curso.Exercicios.Exe10 {
    internal class Exe10 {
        public static void Executar() {
            Console.Write("Qual o valor da cotaçao: ");
            double cotacao = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Quantos dólares irá comprar: ");
            double dolares = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Valor a ser pago em reais = " + ConversorDeMoeda.ConverteMoeda(cotacao, dolares).ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
