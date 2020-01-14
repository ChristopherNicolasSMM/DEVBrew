using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Brew.Funcoes
{
    class CalculoSimples
    {
        public Double abv(Double _brixInicial, Double _brixFinal)
        {
            //%ABV = 131,25 * (OG – FG)
            ConversaoFuncoes conv = new ConversaoFuncoes();
            return (131.25 *
                (conv.BrixParaGravity(_brixInicial) -
                  conv.BrixParaGravity(_brixFinal)));
        }
    }
}
