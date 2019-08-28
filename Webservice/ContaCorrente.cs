using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    class ContaCorrente : Conta
    {
        public decimal TaxaMovimento { get; private set; }

        public ContaCorrente() : base(999)
        {
            TaxaMovimento = 0.1m;
        }      

        public override void Sacar(decimal valor)
        {
            base.Sacar(valor + (TaxaMovimento * valor));
        }

        public override void Depositar(decimal valor)
        {
            base.Saldo += valor;
        }
    }
}
