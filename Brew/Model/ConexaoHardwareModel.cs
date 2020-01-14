using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Brew.Model
{
    class ConexaoHardwareModel
    {

        public ObjectId id { get; set; }
        public string Dispositivo { get; set; }
        public Boolean Ativo { get; set; }

        // Configurações de Rede
        public string IP { get; set; }
        public string MascaraDeRede { get; set; }
        public string Gateway { get; set; }

        public string DDNS { get; set; }

        // Portas
        public List<PortaModel> Portas  { get; set; }
    }
}
