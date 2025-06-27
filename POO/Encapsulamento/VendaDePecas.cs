using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace Encapsulamento
{
    public class VendaDePecas
    {
        string IdVendedor { get; set; }
        int CodigoPeca { get; set; }
        double PrecoUnitario { get; set; }
        int QuantidadeVendida { get; set; }

        public VendaDePecas(string idVendedor, int codigoPeca, double precoUnitario, int quantidadeVendida)
        {
            IdVendedor = idVendedor;
            CodigoPeca = codigoPeca;
            PrecoUnitario = precoUnitario;
            QuantidadeVendida = quantidadeVendida;
        }

        public void ExibirDados()
        {
            Console.WriteLine($"{IdVendedor}|{CodigoPeca}|{PrecoUnitario}|{QuantidadeVendida}");
        }

        public void ComissaoVendedor()
        {
            double totalVenda = PrecoUnitario * QuantidadeVendida;
            double comissao = totalVenda * 0.05;
            Console.WriteLine($"Comissão do vendedor: R${comissao:F2}");

        }
    }
}