using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;

namespace Brew.Model
{
    class EstiloModel
    {
        public ObjectId id { get; set; }
        public String Nome { get; set; }
        public String Numero { get; set; }
        public String Categoria { get; set; }
        public String Tipo { get; set; }
        public String Guia { get; set; }
        public Double OGMax { get; set; }
        public Double OGMin { get; set; }
        public Double FGMax { get; set; }
        public Double FGMin { get; set; }
        public Double IBUMax { get; set; }
        public Double IBUMin { get; set; }
        public Double CarbonatacaoMax { get; set; }
        public Double CarbonatacaoMin { get; set; }
        public Double ABVMax { get; set; }
        public Double ABVMin { get; set; }
        public Double CORMax { get; set; }
        public Double CORMin { get; set; }
        public String Descricao { get; set; }
        public String Perfil { get; set; }
        public String Ingredientes { get; set; }
        public String Exemplos { get; set; }
    }
}
