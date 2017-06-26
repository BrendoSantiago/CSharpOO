using System;

namespace POO
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            ContaCorrente cc = new ContaCorrente();
            ContaPoupanca cp = new ContaPoupanca();

            Console.WriteLine("Taxa de Movimento " + cc.TaxaMovimento);
            Console.WriteLine("Limite (Conta Corrente) R$ " + cc.Limite);
            Console.WriteLine("Limite (Conta Poupança) R$ " + cp.Limite);
            
            Console.ReadLine();
        }
    }
}