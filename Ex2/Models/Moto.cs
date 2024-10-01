using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2.Models
{
    public class Moto : Veiculo
    {
        public int Cilindradas { get; private set; }

        public Moto(string placa, string modelo, decimal precoPorDia, int cilindradas)
            : base(placa, modelo, precoPorDia)
        {
            Cilindradas = cilindradas;
        }

        public override void ExibirDetalhes()
        {
            Console.WriteLine($"Moto: {Modelo}, Placa: {Placa}, Preço por Dia: {PrecoPorDia:C}, Cilindradas: {Cilindradas}");
        }
    }
}
