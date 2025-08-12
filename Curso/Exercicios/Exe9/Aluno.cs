using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Curso.Exercicios.Exe9 {
    internal class Aluno {
        public string Nome;
        public double NotaA, NotaB, NotaC;

        public double NotaFinal() {
            return NotaA + NotaB + NotaC;
        }

        public string AlunoAprovado() {

            if (NotaFinal() >= 60.00) {
                return "\nAprovado";
            } else {
                double faltaPontos = 60.00 - NotaFinal();
                return $"\nReprovado\nFaltaram {faltaPontos.ToString("F2", CultureInfo.InvariantCulture)} Pontos";
            }

        }

        public override string ToString() {
            return "Nota final = "
                + NotaFinal().ToString("F2", CultureInfo.InvariantCulture)
                + AlunoAprovado();
        }
    }
}
