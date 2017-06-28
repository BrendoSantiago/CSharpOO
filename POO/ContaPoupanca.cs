using System;

namespace POO
{
    public class ContaPoupanca : Conta, ITributo
    {
        public ContaPoupanca() : base(75.00m)
        {
                
        }

        public override void Depositar(decimal valor)
        {
            base.Saldo += valor;
        }

        public decimal CalcularTributo()
        {
            return base.Saldo * 0.02m;
        }
    }
}