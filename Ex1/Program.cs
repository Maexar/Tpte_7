using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ex1.Models;

namespace ex1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente cc = new ContaCorrente(123, "João", 1000.0m, 2.0m);
            cc.Depositar(200.0m);
            cc.Sacar(100.0m);
            Console.WriteLine(cc);

            ContaPoupanca cp = new ContaPoupanca(456, "Maria", 1500.0m, 1.5m);
            cp.Depositar(300.0m);
            cp.AdicionarJuros();
            cp.Sacar(200.0m);
            Console.WriteLine(cp);

            ContaInvestimento ci = new ContaInvestimento(789, "Carlos", 2000.0m, 3.0m);
            ci.Depositar(500.0m);
            ci.AdicionarRetorno();
            ci.Sacar(300.0m);
            Console.WriteLine(ci);

        }
    }
}
