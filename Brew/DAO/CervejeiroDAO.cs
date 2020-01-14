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
    class CervejeiroDAO
    {
        static CervejeiroModel _cervejeiro;

        public static string ConnectionString
        {
            get
            {
                return ConfigurationManager.AppSettings["stringConexaoMongoDB"];
            }
        }


        public void CriarCervejeiro(CervejeiroModel _cervejeiro)
        {
            
                MongoClient cliente = new MongoClient(ConnectionString);
                MongoServer server = cliente.GetServer();
                MongoDatabase database = server.GetDatabase("BrewCS");

                var colecao = database.GetCollection<CervejeiroModel>("Cervejeiro");

                BsonDocument cervejeiro = new BsonDocument {
                        { "_id", _cervejeiro.id },
                        { "Nome", _cervejeiro.Nome },
                        { "Email", _cervejeiro.Email },
                        { "Senha", _cervejeiro.Senha },
                        { "Whatsapp", _cervejeiro.Whatsapp }
                        };

            if (_cervejeiro.id == null)
            {
                colecao.Insert(cervejeiro);
            }
            else if (_cervejeiro.id != null)
            {

                colecao.Save(cervejeiro);
            }

        }

        public IEnumerable<CervejeiroModel> GetTodosCervejeiros()
        {
          //  CervejeiroModel cervejeiros = new CervejeiroModel();
            MongoClient cliente = new MongoClient(ConnectionString);
            MongoServer server = cliente.GetServer();
            MongoDatabase database = server.GetDatabase("BrewCS");

            //cervejeiros = database.GetCollection<CervejeiroModel>("Cervejeiro");
             var cervejeirosLista = database.GetCollection<CervejeiroModel>("Cervejeiro");

            var query = from e in cervejeirosLista.AsQueryable<CervejeiroModel>()
                        select e;

            return query;
        }

        public IEnumerable<CervejeiroModel> GetCervejeirosPorNome(string nome)
        {
            MongoClient cliente = new MongoClient(ConnectionString);
            MongoServer server = cliente.GetServer();
            MongoDatabase database = server.GetDatabase("BrewCS");

            var cervejeirosLista = database.GetCollection<CervejeiroModel>("Cervejeiro");

            var query = from e in cervejeirosLista.AsQueryable<CervejeiroModel>()
                        where e.Nome == nome
                        select e;

            return query;
        }
    }
}
