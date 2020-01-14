using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
using MongoDB.Driver.Linq;
using System.Configuration;
using MongoDB.Bson;
using Brew.Model;
using MongoDB.Driver.Builders;

namespace Brew.DAO
{
    class MalteDAO
    {
        static MalteModel _malte;

        public static string ConnectionString
        {
            get
            {
                return ConfigurationManager.AppSettings["stringConexaoMongoDB"];
            }
        }


        public void CriarMalte(MalteModel _malte)
        {

            MongoClient cliente = new MongoClient(ConnectionString);
            MongoServer server = cliente.GetServer();
            MongoDatabase database = server.GetDatabase("BrewCS");

            var colecao = database.GetCollection<MalteModel>("Malte");

            BsonDocument malte = new BsonDocument {
                        { "_id", _malte.id },
                        { "Nome", _malte.Nome },
                        { "Origem", _malte.Origem },
                        { "Fabricante", _malte.Fabricante },
                        { "Tipo", _malte.Tipo },
                        { "QuantidadeMax", _malte.QuantidadeMax },
                        { "Cor", _malte.Cor },
                        { "UsarMostura", _malte.UsarMostura },
                        { "UsarFervura", _malte.UsarFervura },
                        { "NaoFermentavel", _malte.NaoFermentavel },
                        { "PotencialSG", _malte.PotencialSG },
                        { "Aproveitamento", _malte.Aproveitamento },
                        { "PoderDiastatico", _malte.PoderDiastatico },
                        { "Proteina", _malte.Proteina },
                        { "ExtratoIBU", _malte.ExtratoIBU },
                        { "Preco", _malte.Preco },
                        { "Notas", _malte.Notas },
                        { "Ilustracao", _malte.Ilustracao }
                        };

            if (_malte.id == null)
            {
                colecao.Insert(malte);
            }
            else if (_malte.id != null)
            {

                colecao.Save(malte);
            }

        }

        public IEnumerable<MalteModel> GetTodosMalte()
        {
            MongoClient cliente = new MongoClient(ConnectionString);
            MongoServer server = cliente.GetServer();
            MongoDatabase database = server.GetDatabase("BrewCS");

            var malteLista = database.GetCollection<MalteModel>("Malte");

            var query = from e in malteLista.AsQueryable<MalteModel>()
                        select e;

            return query;
        }

        public IEnumerable<MalteModel> GetMaltesPorNome(string nome)
        {
            MongoClient cliente = new MongoClient(ConnectionString);
            MongoServer server = cliente.GetServer();
            MongoDatabase database = server.GetDatabase("BrewCS");

            var malteLista = database.GetCollection<MalteModel>("Malte");

            var query = from e in malteLista.AsQueryable<MalteModel>()
                        where e.Nome == nome
                        select e;

            return query;
        }

    }
}
