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
    class AdjuntoDAO
    {
        static AdjuntoModel _Adjunto;

        public static string ConnectionString
        {
            get
            {
                return ConfigurationManager.AppSettings["stringConexaoMongoDB"];
            }
        }


        public void CriarAdjunto(AdjuntoModel _adjunto)
        {

            MongoClient cliente = new MongoClient(ConnectionString);
            MongoServer server = cliente.GetServer();
            MongoDatabase database = server.GetDatabase("BrewCS");

            var colecao = database.GetCollection<AdjuntoModel>("Adjunto");

            BsonDocument adjunto = new BsonDocument {
                        { "_id", _adjunto.id },
                        { "Nome", _adjunto.Nome },
                        { "Tipo", _adjunto.Tipo },
                        { "Indicacao", _adjunto.Indicacao },
                        { "Quantidade", _adjunto.Quantidade },
                        { "UsarPara", _adjunto.UsarPara },
                        { "Tempo", _adjunto.Tempo },
                        { "Ilustracao", _adjunto.Ilustracao },
                        { "Preco", _adjunto.Preco },
                        { "Notas", _adjunto.Notas }

                        };

            if (_adjunto.id == null)
            {
                colecao.Insert(adjunto);
            }
            else if (_adjunto.id != null)
            {
                colecao.Save(adjunto);
            }

        }

        public IEnumerable<AdjuntoModel> GetTodosAdjuntos()
        {
            MongoClient cliente = new MongoClient(ConnectionString);
            MongoServer server = cliente.GetServer();
            MongoDatabase database = server.GetDatabase("BrewCS");

            var adjuntoLista = database.GetCollection<AdjuntoModel>("Adjunto");

            var query = from e in adjuntoLista.AsQueryable<AdjuntoModel>()
                        select e;

            return query;
        }

        public IEnumerable<AdjuntoModel> GetAdjuntosPorNome(string nome)
        {
            MongoClient cliente = new MongoClient(ConnectionString);
            MongoServer server = cliente.GetServer();
            MongoDatabase database = server.GetDatabase("BrewCS");

            var adjuntoLista = database.GetCollection<AdjuntoModel>("Adjunto");

            var query = from e in adjuntoLista.AsQueryable<AdjuntoModel>()
                        where e.Nome == nome
                        select e;

            return query;
        }
    }
}
