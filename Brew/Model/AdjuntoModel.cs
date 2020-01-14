using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;

namespace Brew.Model
{
    class AdjuntoModel
    {
        public ObjectId id { get; set; }
        public String Nome { get; set; }
        public String Tipo { get; set; }
        public String Indicacao { get; set; }
        public Double Quantidade { get; set; }
        public String UsarPara { get; set; }
        public String Tempo { get; set; }
        public String Notas { get; set; }
        public String Ilustracao { get; set; }
        public Double Preco { get; set; }
    }
}
