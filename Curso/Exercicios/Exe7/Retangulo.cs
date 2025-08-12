using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Curso.Exercicios.Exe7 {
    internal class Retangulo {
        public double Largura;
        public double Altura;

        public double Area () {
            return Largura * Altura;
        }

        public double Perimetro () {
            return 2 * (Altura + Largura);
        }

        public double Diagonal () {
            return Math.Sqrt(Math.Pow(Largura, 2) + Math.Pow(Altura, 2));
        }

        public override string ToString() {
            return "Area = "
                + Area().ToString("F2", CultureInfo.InvariantCulture)
                + "\nPerímetro = "
                + Perimetro().ToString("F2", CultureInfo.InvariantCulture)
                + "\n                                                                                                           Diagonal = "
                + Diagonal().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
