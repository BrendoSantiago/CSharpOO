using System;

namespace POO
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            ContaCorrente cc = new ContaCorrente();
            ContaPoupanca cp = new ContaPoupanca();

            cc.Depositar(1000);
            cp.Depositar(1000);

            cc.Sacar(200);
            cp.Sacar(200);

            Console.WriteLine("Taxa de Movimento " + cc.TaxaMovimento);
            Console.WriteLine("Saldo (Conta Corrente) R$ " + cc.Saldo);
            Console.WriteLine("Saldo (Conta Poupança) R$ " + cp.Saldo);

            Relatorio rel = new Relatorio();
            rel.Somar(cc);
            rel.Somar(cp);

            rel.SomarTributos(cp);

            Console.WriteLine(rel.SaldoGeral);
            Console.WriteLine(rel.TributoGeral);
            
            Console.ReadLine();
        }
    }
}