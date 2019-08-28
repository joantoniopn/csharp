using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Webservice;

namespace POO
{
    class ContaPoupanca : Conta, ITributo
    {
        public override void Depositar(decimal valor)
        {
            base.Saldo += valor;
        }

        public decimal CalcularTributo()
        {
            return Saldo * 0.02m;
        }
    }
}
