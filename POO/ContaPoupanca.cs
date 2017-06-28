using System;

namespace POO
{
    public class ContaPoupanca : Conta
    {
        public ContaPoupanca() : base(75.00m)
        {
                
        }

        public override void Depositar(decimal valor)
        {
            base.Saldo += valor;
        }
    }
}