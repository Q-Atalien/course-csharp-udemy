using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso.Exercicios.Exe11 {
    internal class Conta {
        private int numeroConta;
        private string nomeTitular;
        private double saldo;

        public Conta(int numeroConta, string nomeTitular) {
            this.numeroConta = numeroConta;
            this.nomeTitular = nomeTitular;
            this.saldo = 0.0;
        }

        public Conta(int numeroConta, string nomeTitular, double depositoInicial) : this(numeroConta, nomeTitular) {
            Deposito(depositoInicial);
        }


        public void Deposito(double deposito) {
            this.saldo += deposito;
        }

        public void Saque(double saque) {
            this.saldo = (this.saldo - saque) - 5;
        }

        override public string ToString() {
            return "Dados da conta:\n" 
                + "Conta: "
                + numeroConta
                + ", Titular: "
                + nomeTitular
                + ", Saldo: R$ "
                + saldo.ToString("F2", System.Globalization.CultureInfo.InvariantCulture);
        }
    }
}
