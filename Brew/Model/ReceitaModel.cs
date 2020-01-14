using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Brew.Model
{
    class ReceitaModel
    {
        public ObjectId id { get; set; }
        public string Nome { get; set; }
        public ObjectId Cervejeiro { get; set; }
        public string Tipo { get; set; }
        public ObjectId Estilo { get; set; }
        public Double Litragem { get; set; }
        public Double Versao { get; set; }
        public DateTime Data { get; set; }
        public Double VolPreFervura { get; set; }
        public Double VolPosFervura { get; set; }
        public Double Cor { get; set; }
        public Double ABV { get; set; }
        public Double IBU { get; set; }
        public string Notas { get; set; }
        public Double Eficiencia { get; set; }
        public string DuracaoFervura { get; set; }
        public Double VolumeApurado { get; set; }
        public List<RampaModel> Rampas { get; set; }
        public List<RampaModel> Fermentacao { get; set; }
        public List<Ingredientes> Ingredientes { get; set; }
        public Double OGBrix { get; set; }
        public Double FGBrix { get; set; }
        public Double CelulasNecessarias { get; set; }
        public Double VolumeAtivacao { get; set; }
        public Double VolumeRecomendado { get; set; }
        public Double RecomendacaoGramas { get; set; }


    }
}
