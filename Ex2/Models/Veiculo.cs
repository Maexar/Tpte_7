using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2.Models
{
    public abstract class Veiculo
    {
        public string Placa { get; private set; }
        public string Modelo { get; private set; }
        public decimal PrecoPorDia { get; private set; }

        protected Veiculo(string placa, string modelo, decimal precoPorDia)
        {
            Placa = placa;
            Modelo = modelo;
            PrecoPorDia = precoPorDia;
        }

        public abstract void ExibirDetalhes();

        public override string ToString()
        {
            return $"{Modelo} - Placa: {Placa} - Preço por Dia: {PrecoPorDia:C}";
        }
    }
}
