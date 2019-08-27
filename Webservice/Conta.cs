using System;

namespace POO
{
    class Conta
    {
        int agencia;
        int numeroConta;
        decimal saldo;

        public int Agencia
        {
            get { return agencia; }
            private set
            {
                if (value > 0)
                {
                    agencia = value;
                }
            }
        }

        public int NumeroConta { get => numeroConta; set => numeroConta = value; }
        public decimal Saldo { get => saldo; set => saldo = value; }

        public void SetAgencia(int agencia)
        {
            if (agencia > 0)
            {
                this.agencia = agencia;
            }
        }

        void Sacar(decimal valor)
        {
            Saldo -= valor;
        }

        void Depositar(decimal valor)
        {
            Saldo += valor;
        }
    }
}
