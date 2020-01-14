using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;

namespace Brew.Model
{
    class LeveduraModel
    {
        public ObjectId id { get; set; }
        public String Nome { get; set; }
        public String Laboratorio { get; set; }
        public String ProdutoNSigla { get; set; }
        public String Tipo { get; set; }
        public String Forma { get; set; }
        public String Floculacao { get; set; }
        public Int32 AtenuacaoMax { get; set; }
        public Int32 AtenuacaoMin { get; set; }
        public Int32 TemperaturaMax { get; set; }
        public Int32 TemperaturaMin { get; set; }
        public Int32 CelulasPacote { get; set; }
        public String Indicacao { get; set; }
        public Double Viabilidade { get; set; }
        public Double GramasPacote { get; set; }
        public String Notas { get; set; }
        public String Ilustracao { get; set; }
        public Double Preco { get; set; }
    }
}
