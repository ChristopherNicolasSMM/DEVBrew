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
    class EstiloDAO
    {
        static EstiloModel _Estilo;

        public static string ConnectionString
        {
            get
            {
                return ConfigurationManager.AppSettings["stringConexaoMongoDB"];
            }
        }


        public void CriarEstilo(EstiloModel _estilo)
        {

            MongoClient cliente = new MongoClient(ConnectionString);
            MongoServer server = cliente.GetServer();
            MongoDatabase database = server.GetDatabase("BrewCS");

            var colecao = database.GetCollection<EstiloModel>("Estilo");

            BsonDocument estilo = new BsonDocument {
                        { "_id", _estilo.id },
                        { "Nome", _estilo.Nome },
                        { "Numero", _estilo.Numero },
                        { "Categoria", _estilo.Categoria },
                        { "Tipo", _estilo.Tipo },
                        { "Guia", _estilo.Guia },
                        { "OGMax", _estilo.OGMax },
                        { "OGMin", _estilo.OGMin },
                        { "FGMax", _estilo.FGMax },
                        { "FGMin", _estilo.FGMin },
                        { "IBUMax", _estilo.IBUMax },
                        { "IBUMin", _estilo.IBUMin },
                        { "CarbonatacaoMax", _estilo.CarbonatacaoMax },
                        { "CarbonatacaoMin", _estilo.CarbonatacaoMin },
                        { "ABVMax", _estilo.ABVMax },
                        { "ABVMin", _estilo.ABVMin },
                        { "CORMax", _estilo.CORMax },
                        { "CORMin", _estilo.CORMin },
                        { "Descricao", _estilo.Descricao },
                        { "Perfil", _estilo.Perfil },
                        { "Ingredientes", _estilo.Ingredientes },
                        { "Exemplos", _estilo.Exemplos }
                        };

            if (_estilo.id == null)
            {
                colecao.Insert(estilo);
            }
            else if (_estilo.id != null)
            {

                colecao.Save(estilo);
            }

        }

        public IEnumerable<EstiloModel> GetTodosEstilos()
        {
            MongoClient cliente = new MongoClient(ConnectionString);
            MongoServer server = cliente.GetServer();
            MongoDatabase database = server.GetDatabase("BrewCS");

            var estiloLista = database.GetCollection<EstiloModel>("Estilo");

            var query = from e in estiloLista.AsQueryable<EstiloModel>()
                        select e;

            return query;
        }

        public IEnumerable<EstiloModel> GetEstilosPorNome(string nome)
        {
            MongoClient cliente = new MongoClient(ConnectionString);
            MongoServer server = cliente.GetServer();
            MongoDatabase database = server.GetDatabase("BrewCS");

            var estiloLista = database.GetCollection<EstiloModel>("Estilo");

            var query = from e in estiloLista.AsQueryable<EstiloModel>()
                        where e.Nome == nome
                        select e;

            return query;
        }

    }
}
