using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso.Class {
    internal class Class9 {
        static double Pi = 3.14;

        public static void Executar() {
            Console.WriteLine("Digite valor do raio: ");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double circuferencia = Circuferencia(raio);
            double volume = Volume(raio);

            Console.WriteLine("Circuferência: " + circuferencia.ToString("F2", CultureInfo.InvariantCulture)
                + "\nVolume: " + volume.ToString("F2", CultureInfo.InvariantCulture)
                + "\nValor de PI: " + Pi.ToString("F2", CultureInfo.InvariantCulture));

        }

        static double Circuferencia(double raio) {
            return 2.0 * Pi * raio;
        }

        static double Volume(double raio) {
            return 4.0 / 3.0 * Pi * Math.Pow(raio, 3);
        }
    }
}
