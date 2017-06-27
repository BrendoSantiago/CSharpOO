using System;

namespace POO
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            ContaCorrente cc = new ContaCorrente();
            ContaPoupanca cp = new ContaPoupanca();

            cc.Saldo = 1000;
            cp.Saldo = 1000;

            cc.Sacar(200);
            cp.Sacar(200);

            Console.WriteLine("Taxa de Movimento " + cc.TaxaMovimento);
            Console.WriteLine("Limite (Conta Corrente) R$ " + cc.Saldo);
            Console.WriteLine("Limite (Conta Poupança) R$ " + cp.Saldo);
            
            Console.ReadLine();
        }
    }
}