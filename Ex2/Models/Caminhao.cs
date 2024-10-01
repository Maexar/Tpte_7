using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2.Models
{
    public class Caminhao : Veiculo
    {
        public decimal CapacidadeDeCarga { get; private set; }

        public Caminhao(string placa, string modelo, decimal precoPorDia, decimal capacidadeDeCarga)
            : base(placa, modelo, precoPorDia)
        {
            CapacidadeDeCarga = capacidadeDeCarga;
        }

        public override void ExibirDetalhes()
        {
            Console.WriteLine($"Caminhão: {Modelo}, Placa: {Placa}, Preço por Dia: {PrecoPorDia:C}, Capacidade de Carga: {CapacidadeDeCarga} toneladas");
        }
    }
}
