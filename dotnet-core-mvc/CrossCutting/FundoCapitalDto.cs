using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotnet_core_mvc.CrossCutting
{
    public class FundoCapitalDto
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public decimal ValorNecessario { get; set; }
        public decimal ValorAtual { get; set; }
        public DateTime? DataResgate { get; set; }
    }
}
