using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex1.Models
{
    public class ContaCorrente : Conta
    {
        public decimal TaxaDeOperacao { get; private set; }

        public ContaCorrente(int numero, string titular, decimal saldoInicial, decimal taxaDeOperacao)
            : base(numero, titular, saldoInicial)
        {
            TaxaDeOperacao = taxaDeOperacao;
        }

        public override void Sacar(decimal valor)
        {
            if (Saldo >= valor + TaxaDeOperacao)
            {
                Saldo -= valor + TaxaDeOperacao;
                Console.WriteLine($"Saque de {valor:C} realizado com sucesso. Taxa de operação: {TaxaDeOperacao:C}");
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
