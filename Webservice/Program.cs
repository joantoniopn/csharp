using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Webservice;

namespace POO
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente cc = new ContaCorrente();
            ContaPoupanca cp = new ContaPoupanca();

            cc.Depositar(1000);
            cc.Sacar(200);

            cp.Depositar(1000);
            cp.Sacar(200);

            Console.WriteLine(cc.Saldo);
            Console.WriteLine(cp.Saldo);


            Relatorio rel = new Relatorio();
            rel.Somar(cc);
            rel.Somar(cp);

            Console.WriteLine(rel.SaldoGeral);

            rel.SomarValor(10);
            rel.SomarValor(10,10);

            Console.ReadKey();
        }
    }
}
