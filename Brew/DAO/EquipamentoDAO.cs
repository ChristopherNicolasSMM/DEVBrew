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
    class EquipamentoDAO
    {
        static EquipamentoModel _equipamento;

        public static string ConnectionString
        {
            get
            {
                return ConfigurationManager.AppSettings["stringConexaoMongoDB"];
            }
        }


        public void CriarEquipamento(EquipamentoModel _equipamento)
        {

            MongoClient cliente = new MongoClient(ConnectionString);
            MongoServer server = cliente.GetServer();
            MongoDatabase database = server.GetDatabase("BrewCS");

            var colecao = database.GetCollection<EquipamentoModel>("Equipamento");

            BsonDocument equipamento = new BsonDocument {
                        { "_id", _equipamento.id },
                        { "Nome", _equipamento.Nome },
                        { "Envase", _equipamento.Envase },
                        { "VolumeEquipamento", _equipamento.VolumeEquipamento },
                        { "VolumeMostura", _equipamento.VolumeMostura },
                        { "TaxaEvaporacao", _equipamento.TaxaEvaporacao },
                        { "VolumeLavagem", _equipamento.VolumeLavagem },
                        { "AguaAdicionadaFervura", _equipamento.AguaAdicionadaFervura },
                        { "VolumeFervura", _equipamento.VolumeFervura },
                        { "VolumeFinal", _equipamento.VolumeFinal },
                        { "EvaporacaoTotal", _equipamento.EvaporacaoTotal },
                        { "PerdaTrub", _equipamento.PerdaTrub },
                        { "AguaAdicionadaFermentador", _equipamento.AguaAdicionadaFermentador },
                        { "PerdaFermentador", _equipamento.PerdaFermentador },
                        { "VolumeEnvasado", _equipamento.VolumeEnvasado }
                        };
            
            if (_equipamento.id == null)
            {
                colecao.Insert(equipamento);
            }
            else if (_equipamento.id != null)
            {
                colecao.Save(equipamento);
            }

        }

        public IEnumerable<EquipamentoModel> GetTodosEquipamento()
        {
            MongoClient cliente = new MongoClient(ConnectionString);
            MongoServer server = cliente.GetServer();
            MongoDatabase database = server.GetDatabase("BrewCS");

            var equipamentoLista = database.GetCollection<EquipamentoModel>("Equipamento");

            var query = from e in equipamentoLista.AsQueryable<EquipamentoModel>()
                        select e;

            return query;
        }

        public IEnumerable<EquipamentoModel> GetEquipamentosPorNome(string nome)
        {
            MongoClient cliente = new MongoClient(ConnectionString);
            MongoServer server = cliente.GetServer();
            MongoDatabase database = server.GetDatabase("BrewCS");

            var equipamentoLista = database.GetCollection<EquipamentoModel>("Equipamento");

            var query = from e in equipamentoLista.AsQueryable<EquipamentoModel>()
                        where e.Nome == nome
                        select e;

            return query;
        }
    }
}
