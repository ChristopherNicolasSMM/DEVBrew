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
    class LupuloDAO
    {
        static LupuloModel _Lupulo;

        public static string ConnectionString
        {
            get
            {
                return ConfigurationManager.AppSettings["stringConexaoMongoDB"];
            }
        }


        public void CriarLupulo(LupuloModel _lupulo)
        {

            MongoClient cliente = new MongoClient(ConnectionString);
            MongoServer server = cliente.GetServer();
            MongoDatabase database = server.GetDatabase("BrewCS");

            var colecao = database.GetCollection<LupuloModel>("Lupulo");

            BsonDocument lupulo = new BsonDocument {
                        { "_id", _lupulo.id },
                        { "Nome", _lupulo.Nome },
                        { "Origem", _lupulo.Origem },
                        { "Tipo", _lupulo.Tipo },
                        { "Forma", _lupulo.Forma },
                        { "AcidoAlfa", _lupulo.AcidoAlfa },
                        { "AcidoBeta", _lupulo.AcidoBeta },
                        { "Ilustracao", _lupulo.Ilustracao },
                        { "Preco", _lupulo.Preco },
                        { "Notas", _lupulo.Notas }
                        };

            if (_lupulo.id == null)
            {
                colecao.Insert(lupulo);
            }
            else if (_lupulo.id != null)
            {

                colecao.Save(lupulo);
            }

        }

        public IEnumerable<LupuloModel> GetTodosLupulos()
        {
            MongoClient cliente = new MongoClient(ConnectionString);
            MongoServer server = cliente.GetServer();
            MongoDatabase database = server.GetDatabase("BrewCS");

            var lupuloLista = database.GetCollection<LupuloModel>("Lupulo");

            var query = from e in lupuloLista.AsQueryable<LupuloModel>()
                        select e;

            return query;
        }

        public IEnumerable<LupuloModel> GetLupulosPorNome(string nome)
        {
            MongoClient cliente = new MongoClient(ConnectionString);
            MongoServer server = cliente.GetServer();
            MongoDatabase database = server.GetDatabase("BrewCS");

            var lupuloLista = database.GetCollection<LupuloModel>("Lupulo");

            var query = from e in lupuloLista.AsQueryable<LupuloModel>()
                        where e.Nome == nome
                        select e;

            return query;
        }


    }
}
