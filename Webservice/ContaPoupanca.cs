using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    class ContaPoupanca : Conta
    {
        public override void Depositar(decimal valor)
        {
            base.Saldo += valor;
        }

    }
}
