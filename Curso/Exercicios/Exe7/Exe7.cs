using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Curso.Exercicios.Exe7 {
    internal class Exe7 {
        public static void Executar() {
            Retangulo r = new Retangulo();

            Console.WriteLine("Digite a Largura do Retângulo:");
            r.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Digite a altura do Retângulo:");
            r.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine(r);
        }
    }
}
