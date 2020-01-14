using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;

namespace Brew.Model
{
    class CervejeiroModel
    {
       
        public ObjectId id { get; set; }
        public String Nome { get; set; }
        public String Email { get; set; }
        public String Senha { get; set; }
        public String Whatsapp { get; set; }
        public String Ilustracao { get; set; }
        
    }
}
