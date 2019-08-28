using POO;
using System;
using System.Collections.Generic;
using System.Text;

namespace Webservice
{
    class Relatorio
    {
        public decimal TributoGeral {get; private set;}
        public decimal SaldoGeral { get; private set; }

        public void Somar(Conta conta)
        {
            this.SaldoGeral += conta.Saldo;
        }

        public void SomarValor(decimal valor)
        {
            this.SaldoGeral += valor;
        }

        public void SomarValor(decimal valor1, decimal valor2)
        {
            this.SaldoGeral += (valor1 + valor2);
        }

        public void SomarTributos(ITributo conta)
        {
            this.TributoGeral += conta.CalcularTributo();
        }

    }
}
