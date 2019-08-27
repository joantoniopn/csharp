using POO;
using System;
using System.Collections.Generic;
using System.Text;

namespace Webservice
{
    class Relatorio
    {
        public decimal SaldoGeral { get; private set; }

        public void Somar(Conta conta)
        {
            this.SaldoGeral += conta.Saldo;
        }

    }
}
