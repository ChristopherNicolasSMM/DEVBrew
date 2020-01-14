using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;

namespace Brew.Model
{
    class LupuloModel
    {
        public ObjectId id { get; set; }
        public String Nome { get; set; }
        public String Origem { get; set; }
        public String Notas { get; set; }
        public String Tipo { get; set; }
        public String Forma { get; set; }
        public Double AcidoAlfa { get; set; }
        public Double AcidoBeta { get; set; }
        public String Ilustracao { get; set; }
        public Double Preco { get; set; }
    }
}
