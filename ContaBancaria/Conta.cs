using System;
using System.Globalization;

namespace ContaBancaria
{
    internal class Conta
    {
        public int Numero { get; private set; }
        public string Nome;
        public double Saldo { get; private set; }

        public Conta(int numero, string nome)
        {
            Numero = numero;
            Nome = nome;
        }
        public Conta(int conta, string nome, double saldo) : this(conta, nome)
        {
            Saldo = saldo;
        }
        public void Deposito(double deposito)
        {
            Saldo += deposito;
        }
        public void Saque(double quantia)
        {
            Saldo -= (quantia + 5.00);
        }

        public override string ToString()
        {
           return "Conta: " + Numero + ", " + Nome + ", seu saldo é: R$" + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
