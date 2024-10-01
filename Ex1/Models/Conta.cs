using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex1.Models
{
    public abstract class Conta
    {
        public int Numero { get; private set; }
        public string Titular { get; private set; }
        public decimal Saldo { get; protected set; }

        public Conta(int numero, string titular, decimal saldoInicial)
        {
            Numero = numero;
            Titular = titular;
            Saldo = saldoInicial;
        }

        public abstract void Sacar(decimal valor);
        public abstract void Depositar(decimal valor);

        public override string ToString()
        {
            return $"{Numero} - {Titular} - Saldo: {Saldo:C}";
        }
    }
}
