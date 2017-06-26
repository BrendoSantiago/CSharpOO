using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    public class ContaCorrente
    {
        private int agencia;
        private int numeroConta;
        private decimal saldo;
        decimal taxaMovimento;

        //Encapsulamento
        public int Agencia
        {
            get
            {
                return agencia;
            }

            private set
            {
                if (value > 0)
                    agencia = value;
            }
        }

        public ContaCorrente()
        {
            //agencia = 20;
        }

        public void SetAgencia(int agencia)
        {
            this.agencia = agencia;
        }

        void Sacar(decimal valor)
        {
            saldo -= valor;
        }

        void Depositar(decimal valor)
        {
            saldo += valor;
        }
    }
}