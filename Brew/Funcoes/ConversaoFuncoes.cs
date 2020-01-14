using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Brew.Funcoes
{
    class ConversaoFuncoes
    {
        public void ConverterUniversal(string _unidade, string _referencia, Double _valor)
        {
            if (_referencia == "V")//  Volume
            {
                switch (_unidade)
                {
                    case "L":
                        break;

                    case "ml":
                        break;
                }
            }
            else if (_referencia == "M")// Massa
            {
                switch (_unidade)
                {
                    case "Kg":
                        break;

                    case "g":
                        break;
                }
            }
        }

        public Double BrixParaGravity(Double _brix)
        {
            //SG = (Brix / (258.6-((Brix / 258.2)*227.1))) + 1
            return (_brix / (258.6 - ((_brix / 258.2) * 227.1))) + 1;
        }
        public Double GravityParaBrix(Double _gravity)
        {
            //Brix = (((182.4601 * SG -775.6821) * SG +1262.7794) * SG -669.5622)
            return (((182.4601 * _gravity - 775.6821) * _gravity + 1262.7794) * _gravity - 669.5622);
        }
    }
}
