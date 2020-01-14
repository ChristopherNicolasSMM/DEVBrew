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
    class LeveduraDAO
    {
        static LeveduraModel _levedura;

        public static string ConnectionString
        {
            get
            {
                return ConfigurationManager.AppSettings["stringConexaoMongoDB"];
            }
        }


        public void CriarLevedura(LeveduraModel _levedura)
        {

            MongoClient cliente = new MongoClient(ConnectionString);
            MongoServer server = cliente.GetServer();
            MongoDatabase database = server.GetDatabase("BrewCS");

            var colecao = database.GetCollection<LeveduraModel>("Levedura");

            BsonDocument levedura = new BsonDocument {
                        { "_id", _levedura.id },
                        { "Nome", _levedura.Nome },
                        { "Laboratorio", _levedura.Laboratorio },
                        { "ProdutoNSigla", _levedura.ProdutoNSigla },
                        { "Tipo", _levedura.Tipo },
                        { "Forma", _levedura.Forma },
                        { "Floculacao", _levedura.Floculacao },
                        { "AtenuacaoMax", _levedura.AtenuacaoMax },
                        { "AtenuacaoMin", _levedura.AtenuacaoMin },
                        { "TemperaturaMax", _levedura.TemperaturaMax },
                        { "TemperaturaMin", _levedura.TemperaturaMin },
                        { "CelulasPacote", _levedura.CelulasPacote },
                        { "Indicacao", _levedura.Indicacao },
                        { "Viabilidade", _levedura.Viabilidade },
                        { "GramasPacote", _levedura.GramasPacote },
                        { "Ilustracao", _levedura.Ilustracao },
                        { "Preco", _levedura.Preco },
                        { "Notas", _levedura.Notas }
                        };

            if (_levedura.id == null)
            {
                colecao.Insert(levedura);
            }
            else if (_levedura.id != null)
            {
                colecao.Save(levedura);
            }

        }

        public IEnumerable<LeveduraModel> GetTodosLeveduras()
        {
            MongoClient cliente = new MongoClient(ConnectionString);
            MongoServer server = cliente.GetServer();
            MongoDatabase database = server.GetDatabase("BrewCS");

            var leveduraLista = database.GetCollection<LeveduraModel>("Levedura");

            var query = from e in leveduraLista.AsQueryable<LeveduraModel>()
                        select e;

            return query;
        }

        public IEnumerable<LeveduraModel> GetLevedurasPorNome(string nome)
        {
            MongoClient cliente = new MongoClient(ConnectionString);
            MongoServer server = cliente.GetServer();
            MongoDatabase database = server.GetDatabase("BrewCS");

            var leveduraLista = database.GetCollection<LeveduraModel>("Levedura");

            var query = from e in leveduraLista.AsQueryable<LeveduraModel>()
                        where e.Nome == nome
                        select e;

            return query;
        }
    }
}
