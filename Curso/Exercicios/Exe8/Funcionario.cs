using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Curso.Exercicios.Exe8 {
    internal class Funcionario {
        public string Nome;
        public double SalarioBruto;
        public double Imposto;

        public double SalarioLiquido() {
            return SalarioBruto - Imposto;
        }

        public void AumentarSalario(double vlrPorcentagem ) {
            SalarioBruto = SalarioBruto * (1 + vlrPorcentagem / 100);
        }

        public override string ToString() {
            return "\nFuncionário: "
                + Nome
                +", R$ "
                + SalarioLiquido().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
