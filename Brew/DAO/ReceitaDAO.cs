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
    class ReceitaDAO
    {
        public static string ConnectionString
        {
            get
            {
                return ConfigurationManager.AppSettings["stringConexaoMongoDB"];
            }
        }

        public void CriarReceita(ReceitaModel _receita)
        {

            MongoClient cliente = new MongoClient(ConnectionString);
            MongoServer server = cliente.GetServer();
            MongoDatabase database = server.GetDatabase("BrewCS");

            var colecao = database.GetCollection<ReceitaModel>("Receita");

            BsonArray _bsoCervejeiro = new BsonArray();
            BsonArray _bsoIngredientes = new BsonArray();
            BsonArray _bsoRampas = new BsonArray();
            BsonArray _bsoFermentacao = new BsonArray();
            
            if (_receita.Ingredientes != null)
            {
                foreach (var ingrediente in _receita.Ingredientes)
                {
                    BsonDocument ingredientesArray = new BsonDocument
                {
                    { "Ordem", ingrediente.Ordem  },
                    { "Quantidade", ingrediente.Quantidade  },
                    { "Descricao", ingrediente.Descricao },
                    { "Tipo", ingrediente.Tipo  },
                    { "Custo", ingrediente.Custo  }
                };
                    _bsoIngredientes.Add(ingredientesArray);
                }
            }


            if (_receita.Rampas != null)
            {
                foreach (var rampa in _receita.Rampas)
                {
                    BsonDocument rampaArray = new BsonDocument
                {
                    { "Descricao", rampa.Descricao  },
                    { "Duracao", rampa.Duracao  },
                    { "Temperatura", rampa.Temperatura }
                    //{ "Observacao", rampa.Observacao  }
                };
                    _bsoRampas.Add(rampaArray);
                }
            }

            if (_receita.Fermentacao != null)
            {
                foreach (var etapaFermentacao in _receita.Fermentacao)
                {
                    BsonDocument fermentacaoArray = new BsonDocument
                {
                    { "Descricao", etapaFermentacao.Descricao  },
                    { "Duracao", etapaFermentacao.Duracao  },
                    { "Temperatura", etapaFermentacao.Temperatura }
                    //{ "Observacao", etapaFermentacao.Observacao  }
                };
                    _bsoFermentacao.Add(fermentacaoArray);
                }
            }
            


            BsonDocument receita = new BsonDocument {
                        { "_id", _receita.id },
                        { "Nome", _receita.Nome },
                        { "Cervejeiro", _receita.Cervejeiro },
                        { "Tipo", _receita.Tipo },
                        { "Litragem", _receita.Litragem },
                        { "Versao", _receita.Versao },
                        { "Data", _receita.Data },
                        { "VolPreFervura", _receita.VolPreFervura },
                        { "VolPosFervura", _receita.VolPosFervura },
                        { "VolumeApurado", _receita.VolumeApurado },
                        { "Cor", _receita.Cor },
                        { "ABV", _receita.ABV },
                        { "IBU", _receita.IBU },
                        { "Eficiencia", _receita.Eficiencia },
                        { "DuracaoFervura", _receita.DuracaoFervura },

                        { "Ingredientes", _bsoIngredientes },
                        { "Rampas", _bsoRampas },
                        { "Fermentacao", _bsoFermentacao },

                        { "OGBrix", _receita.OGBrix },
                        { "FGBrix", _receita.FGBrix },
                        { "CelulasNecessarias", _receita.CelulasNecessarias },
                        { "VolumeAtivacao", _receita.VolumeAtivacao },
                        { "VolumeRecomendado", _receita.VolumeRecomendado },
                        { "RecomendacaoGramas", _receita.RecomendacaoGramas }
                        };

            ObjectId Nulo = new ObjectId();
            if (_receita.id == null || _receita.id == Nulo)
            {
                colecao.Insert(receita);
            }
            else if (_receita.id != null)
            {

                colecao.Save(receita);
            }
        }
        
        public IEnumerable<ReceitaModel> GetTodasReceitas()
        {
            MongoClient cliente = new MongoClient(ConnectionString);
            MongoServer server = cliente.GetServer();
            MongoDatabase database = server.GetDatabase("BrewCS");

            var receiraLista = database.GetCollection<ReceitaModel>("Receita");

            var query = from e in receiraLista.AsQueryable<ReceitaModel>()
                        select e;
            return query;
        }

        public IEnumerable<ReceitaModel> GetReceitaPorNome(string _nome)
        {
            MongoClient cliente = new MongoClient(ConnectionString);
            MongoServer server = cliente.GetServer();
            MongoDatabase database = server.GetDatabase("BrewCS");

            var receiraLista = database.GetCollection<ReceitaModel>("Receita");

            var query = from e in receiraLista.AsQueryable<ReceitaModel>()
                        where e.Nome == _nome
                        select e;
            return query;
        }
    }
}
