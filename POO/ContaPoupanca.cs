using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    public class ContaPoupanca
    {
        private int agencia;
        private int numeroConta;
        private decimal saldo;

        void Sacar(decimal valor)
        {
            saldo -= valor;
        }

        void Depositar (decimal valor)
        {
            saldo += valor;
        }
    }
}