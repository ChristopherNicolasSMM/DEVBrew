using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Brew.Model
{
    public class Ingredientes
    {
        public int Ordem { get; set; }
        public Double Quantidade { get; set; }
        public string Unidade { get; set; }
        public string Descricao { get; set; }
        public string Marca { get; set; }
        public string Tipo { get; set; }
        public string TempoAdicao { get; set; }
        public Double PercentualIBU { get; set; }
        public Double Volume { get; set; }
        //public Double Estoque { get; set; }
        public Double Custo { get; set; }
        public String TipoDoIngrediente { get; set; }
    }
}
