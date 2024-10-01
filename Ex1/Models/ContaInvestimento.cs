using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex1.Models
{
    public class ContaInvestimento : Conta
    {
        public decimal TaxaDeRetorno { get; private set; }

        public ContaInvestimento(int numero, string titular, decimal saldoInicial, decimal taxaDeRetorno)
            : base(numero, titular, saldoInicial)
        {
            TaxaDeRetorno = taxaDeRetorno;
        }

        public void AdicionarRetorno()
        {
            var retorno = Saldo * TaxaDeRetorno / 100;
            Saldo += retorno;
            Console.WriteLine($"Retorno de {retorno:C} adicionado. Novo saldo: {Saldo:C}");
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
