using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso.Class.Class10 {
    internal class Class10 {


        public static void Executar() {

            Console.WriteLine("Digite valor do raio: ");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double circuferencia = Calculadora.Circuferencia(raio);
            double volume = Calculadora.Volume(raio);

            Console.WriteLine("Circuferência: " + circuferencia.ToString("F2", CultureInfo.InvariantCulture)
                + "\nVolume: " + volume.ToString("F2", CultureInfo.InvariantCulture)
                + "\nValor de PI: " + Calculadora.Pi.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
