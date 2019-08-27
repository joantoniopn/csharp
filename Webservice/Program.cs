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
            ContaPoupanca cp = new ContaPoupanca();

            cc.Saldo = 1000;
            cc.Sacar(200);

            cp.Saldo = 1000;
            cp.Sacar(200);

            Console.WriteLine(cc.Saldo);
            Console.WriteLine(cp.Saldo);

            Console.ReadKey();
        }
    }
}
