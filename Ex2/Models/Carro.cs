using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2.Models
{
    internal class Carro : Veiculo
    {
        public int NumeroDePortas { get; private set; }

        public Carro(string placa, string modelo, decimal precoPorDia, int numeroDePortas)
            : base(placa, modelo, precoPorDia)
        {
            NumeroDePortas = numeroDePortas;
        }

        public override void ExibirDetalhes()
        {
            Console.WriteLine($"Carro: {Modelo}, Placa: {Placa}, Preço por Dia: {PrecoPorDia:C}, Número de Portas: {NumeroDePortas}");
        }
    }
}
