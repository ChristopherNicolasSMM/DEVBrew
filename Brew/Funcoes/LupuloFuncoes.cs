using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Brew.Funcoes
{
    class LupuloFuncoes
    {
        public int selecionaTipo(String tipo)
        {
            if (tipo == "Amargor")
            {
                return 0;
            }
            else if (tipo == "Aroma")
            {
                return 1;
            }
            else if (tipo == "Ambos")
            {
                return 2;
            }
            return -1;
            
        }



        
        public int selecionaForma(String forma)
        {
            if (forma == "Pellet")
            {
                return 0;
            }
            if (forma == "Plug")
            {
                return 1;
            }
            if (forma == "Flor")
            {
                return 2;
            }
            if (forma == "Chá / Extrato")
            {
                return 3;
            }
            return -1;
        }

    }
}
