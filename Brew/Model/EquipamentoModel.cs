using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;

namespace Brew.Model
{
    class EquipamentoModel
    {
        public ObjectId id { get; set; }
        public String Nome { get; set; }
        // Fervura
        public Double VolumeEquipamento { get; set; }
        public Double VolumeMostura { get; set; }
        public Double TaxaEvaporacao { get; set; }
        public Double VolumeLavagem { get; set; }
        public Double AguaAdicionadaFervura { get; set; }
        public Double VolumeFervura { get; set; }
        public Double VolumeFinal { get; set; }
        public Double EvaporacaoTotal { get; set; }
        public Double PerdaTrub { get; set; }
        // Fermentador
        public Double AguaAdicionadaFermentador { get; set; }
        public Double PerdaFermentador { get; set; }
        public Double VolumeEnvasado { get; set; }
        public String Envase { get; set; }

    }
}
