using System;

namespace POO
{
    class Conta
    {
        public int Agencia { get; private set; }
        public int NumeroConta { get; private set; }
        public decimal Saldo { get; private set; }
        public decimal Limite { get; private set; }

        public Conta()
        {
            Limite = 1000;
        }

        public Conta(decimal limite)
        {
            Limite = limite;
        }

        public void SetAgencia(int agencia)
        {
            if (agencia > 0)
            {
                Agencia = agencia;
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
