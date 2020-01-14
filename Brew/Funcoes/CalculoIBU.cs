using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Brew.Funcoes
{
    class CalculoIBU
    {
        private ConversaoFuncoes conv = new ConversaoFuncoes();

        public Double Utilizacao(string _tempo, string _forma)
        {
            int minutos = Convert.ToInt32(_tempo.Substring(0, 2));
            switch (_forma)
            {
                case "Pellet":
                    if (minutos <= 9)
                    {
                        return 0.06;
                    }
                    else if (minutos <= 19)
                    {
                        return 0.15;
                    }
                    else if (minutos <= 29)
                    {
                        return 0.19;
                    }
                    else if (minutos <= 44)
                    {
                        return 0.24;
                    }
                    else if (minutos <= 59)
                    {
                        return 0.27;
                    }
                    else if (minutos <= 74)
                    {
                        return 0.30;
                    }
                    else if (minutos >= 75)
                    {
                        return 0.34;
                    }
                    break;
                case "Plug":
                    if (minutos <= 9)
                    {
                        return 0.06;
                    }
                    else if (minutos <= 19)
                    {
                        return 0.15;
                    }
                    else if (minutos <= 29)
                    {
                        return 0.19;
                    }
                    else if (minutos <= 44)
                    {
                        return 0.24;
                    }
                    else if (minutos <= 59)
                    {
                        return 0.27;
                    }
                    else if (minutos <= 74)
                    {
                        return 0.30;
                    }
                    else if (minutos >= 75)
                    {
                        return 0.34;
                    }
                    break;
                case "Flor":
                    if (minutos <= 9)
                    {
                        return 0.05;
                    }
                    else if (minutos <= 19)
                    {
                        return 0.12;
                    }
                    else if (minutos <= 29)
                    {
                        return 0.15;
                    }
                    else if (minutos <= 44)
                    {
                        return 0.19;
                    }
                    else if (minutos <= 59)
                    {
                        return 0.22;
                    }
                    else if (minutos <= 74)
                    {
                        return 0.24;
                    }
                    else if (minutos >= 75)
                    {
                        return 0.27;
                    }
                    break;
                case "Extrato":
                    if (minutos <= 9)
                    {
                        return 0.06;
                    }
                    else if (minutos <= 19)
                    {
                        return 0.15;
                    }
                    else if (minutos <= 29)
                    {
                        return 0.19;
                    }
                    else if (minutos <= 44)
                    {
                        return 0.24;
                    }
                    else if (minutos <= 59)
                    {
                        return 0.27;
                    }
                    else if (minutos <= 74)
                    {
                        return 0.30;
                    }
                    else if (minutos >= 75)
                    {
                        return 0.34;
                    }
                    break;
            }
            return 1.0;
            /*
            Tempo    |Flor |Pallet
            00 a 09  |05   |06
            10 a 19  |12   |15
            20 a 29  |15   |19
            30 a 44  |19   |24
            45 a 59  |22   |27
            60 a 74  |24   |30
            75       |27   |34
            */
        }

        public Double DencidadeCorrigida(Double _OGBrix)
        {
            Double gravidadeFervura = conv.BrixParaGravity(_OGBrix);
            //Cg = 1 + ((gravidadeFervura – 1, 050) / 0,2)
            if (gravidadeFervura <= 1.050)
            {
                return 1;
            }
            return 1 + (( gravidadeFervura - 1.050 ) / 0.2 );
        }
        public Double CalculaIBU(double _quantidade, Double _utilizacao, Double _acidoAlfa, Double _volume, Double _dencidadeCorrigida)
        {
            //IBU = (Wg * U% * A% * 1000) / ( Vl * Cg)
            return _quantidade * _utilizacao * _acidoAlfa * 1000 / _volume * _dencidadeCorrigida;
        }

    }
}
