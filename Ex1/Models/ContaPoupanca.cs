using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex1.Models
{
    public class ContaPoupanca : Conta
    {
        public decimal TaxaDeJuros { get; private set; }

        public ContaPoupanca(int numero, string titular, decimal saldoInicial, decimal taxaDeJuros)
            : base(numero, titular, saldoInicial)
        {
            TaxaDeJuros = taxaDeJuros;
        }

        public void AdicionarJuros()
        {
            var juros = Saldo * TaxaDeJuros / 100;
            Saldo += juros;
            Console.WriteLine($"Juros de {juros:C} adicionados. Novo saldo: {Saldo:C}");
        }

        public override void Sacar(decimal valor)
        {
            if (Saldo >= valor)
            {
                Saldo -= valor;
                Console.WriteLine($"Saque de {valor:C} realizado com sucesso.");
            }
            else
            {
                Console.WriteLine("Saldo insuficiente.");
            }
        }

        public override void Depositar(decimal valor)
        {
            Saldo += valor;
            Console.WriteLine($"Depósito de {valor:C} realizado com sucesso.");
        }
    }
}
