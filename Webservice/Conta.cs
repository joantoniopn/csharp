using System;

namespace POO
{
    public abstract class Conta
    {
        public int Agencia { get; private set; }
        public int NumeroConta { get; private set; }
        public decimal Saldo { get; protected set; }
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

        public virtual void Sacar(decimal valor)
        {
            Saldo -= valor;
        }

        public abstract void Depositar(decimal valor);
    }
}
