using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso.Exercicios.Exe10 {
    internal class ConversorDeMoeda {

        public static int iof = 6;

        public static double ConverteMoeda(double cotacao, double dolares) {
            double valorASerPago = dolares * cotacao;
            double acrescimoIOF = (valorASerPago * iof) / 100;

            return  valorASerPago + acrescimoIOF;

        }
    }
}
