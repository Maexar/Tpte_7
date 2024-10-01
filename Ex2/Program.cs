using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ex2.Models;

namespace Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            Carro carro = new Carro("ABC1234", "Ford Ka", 150.0m, 4);
            Moto moto = new Moto("XYZ5678", "Honda CB500", 100.0m, 500);
            Caminhao caminhao = new Caminhao("LMN9101", "Volvo FH", 300.0m, 20.0m);

            carro.ExibirDetalhes();
            moto.ExibirDetalhes();
            caminhao.ExibirDetalhes();

            Console.WriteLine(carro);
            Console.WriteLine(moto);
            Console.WriteLine(caminhao);
        }
    }
}