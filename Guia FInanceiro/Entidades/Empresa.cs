using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia_FInanceiro
{
    public class Empresa
    {
        public string? Cod { get; set; }
        public string? NomeEmpresa { get; set; }
        public decimal? Dy { get; set; }
        public decimal? Preco { get; set; }
        public decimal? PrecoTeto { get; set; }
        public decimal? PercentualSeguranca { get; set; }

        public string? Tipo { get; set; }
    }
}
