using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente cc = new ContaCorrente();

            cc.SetAgencia(2017);

            Console.WriteLine(cc.Agencia);
            Console.ReadLine();
        }
    }
}
