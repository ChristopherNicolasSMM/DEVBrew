using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver.Builders;
using MongoDB.Driver;
using MongoDB.Driver.Linq;
using MongoDB.Bson;
using Brew.Model;
using System.Configuration;

namespace Brew.DAO
{
    class ConexaoHardwareDAO
    {
        static ConexaoHardwareModel _conexaoHardware;

        public static string ConnectionString
        {
            get
            {
                return ConfigurationManager.AppSettings["stringConexaoMongoDB"];
            }
        }


        public void CriarConexao(ConexaoHardwareModel _conexaoHardware)
        {
            MongoClient cliente = new MongoClient(ConnectionString);
            MongoServer server = cliente.GetServer();
            MongoDatabase database = server.GetDatabase("BrewCS");

            var colecao = database.GetCollection<ConexaoHardwareModel>("ConexaoHardware");


            BsonArray _bsoPortas = new BsonArray();

            if (_conexaoHardware.Portas != null)
            {
                foreach (var porta in _conexaoHardware.Portas)
                {
                    BsonDocument portaArray = new BsonDocument
                {
                    { "Funcao", porta.Funcao  },
                    { "Porta", porta.Porta  },
                    { "Valor", porta.Valor  },
                    { "Descricao", porta.Descricao  }
                };
                    _bsoPortas.Add(portaArray);
                }
            }

            BsonDocument ConexaoHardware = new BsonDocument {
                        { "_id", _conexaoHardware.id  },
                        { "Dispositivo", _conexaoHardware.Dispositivo  },
                        { "Ativo", _conexaoHardware.Ativo  },
                        { "IP", _conexaoHardware.IP  },
                        { "MascaraDeRede", _conexaoHardware.MascaraDeRede  },
                        { "Gateway", _conexaoHardware.Gateway  },
                        { "DDNS", _conexaoHardware.DDNS },
                        { "Portas" ,  _bsoPortas  }
                        };

            if (_conexaoHardware.Dispositivo == null)
            {
                colecao.Insert(ConexaoHardware);
            }
            else if (_conexaoHardware.Dispositivo != null)
            {

                colecao.Save(ConexaoHardware);
            }
        }

        public IEnumerable<ConexaoHardwareModel> GetTodasConexoes()
        {
            MongoClient cliente = new MongoClient(ConnectionString);
            MongoServer server = cliente.GetServer();
            MongoDatabase database = server.GetDatabase("BrewCS");

            var conexaosLista = database.GetCollection<ConexaoHardwareModel>("ConexaoHardware");

            var query = from e in conexaosLista.AsQueryable<ConexaoHardwareModel>()
                        select e;

            return query;
        }

        public IEnumerable<ConexaoHardwareModel> GetConexaoPorDispositivo(string dispositivo)
        {
            MongoClient cliente = new MongoClient(ConnectionString);
            MongoServer server = cliente.GetServer();
            MongoDatabase database = server.GetDatabase("BrewCS");

            var conexaosLista = database.GetCollection<ConexaoHardwareModel>("ConexaoHardware");

            var query = from e in conexaosLista.AsQueryable<ConexaoHardwareModel>()
                        where e.Dispositivo == dispositivo
                        select e;

            return query;
        }
    }
}
