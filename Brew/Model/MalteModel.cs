using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;

namespace Brew.Model
{
    class MalteModel
    {
        public ObjectId id { get; set; }
        public String Nome { get; set; }
        public String Origem { get; set; }
        public String Fabricante { get; set; }
        public String Tipo { get; set; }
        public int QuantidadeMax { get; set; }
        public int Cor { get; set; }
        public Boolean UsarMostura { get; set; }
        public Boolean UsarFervura { get; set; }
        public Boolean NaoFermentavel { get; set; }
        public Double PotencialSG { get; set; }
        public Double Aproveitamento { get; set; }
        public Double PoderDiastatico { get; set; }
        public Double Proteina { get; set; }
        public Double ExtratoIBU { get; set; }
        public String Notas { get; set; }
        public String Ilustracao { get; set; }
        public Double Preco { get; set; }
    }
    
}
