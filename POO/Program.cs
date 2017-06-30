using System;

namespace POO
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            try
            {
                int a = 10;
                int b = 2;

                int resultado = a / b;

                Console.WriteLine(resultado);

                int[] vetor = new int[] { 1, 2, 3 };
                Console.WriteLine(vetor[0]);
            }
            catch (System.DivideByZeroException)
            {
                Console.WriteLine("Erro: Divisão por zero!");
            }
            catch (System.IndexOutOfRangeException)
            {
                Console.WriteLine("Erro: Fora do índice da coleção!");
            }
            catch (Exception ex)
            {
                //Console.WriteLine(ex.GetType());
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Fim da Execução :)");
            }

            //ContaCorrente cc = new ContaCorrente();
            //ContaPoupanca cp = new ContaPoupanca();

            //cc.Depositar(1000);
            //cp.Depositar(1000);

            //cc.Sacar(200);
            //cp.Sacar(200);

            //Console.WriteLine("Taxa de Movimento " + cc.TaxaMovimento);
            //Console.WriteLine("Saldo (Conta Corrente) R$ " + cc.Saldo);
            //Console.WriteLine("Saldo (Conta Poupança) R$ " + cp.Saldo);

            //Relatorio rel = new Relatorio();
            //rel.Somar(cc);
            //rel.Somar(cp);

            //rel.SomarTributos(cp);

            //Console.WriteLine(rel.SaldoGeral);
            //Console.WriteLine(rel.TributoGeral);

            Console.ReadLine();
        }
    }
}