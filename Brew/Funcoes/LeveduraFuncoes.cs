using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Brew.Funcoes
{
    class LeveduraFuncoes
    {
        public int selecionaTipo(String tipo)
        {
            if (tipo == "Ale")
            {
                return 0;
            }
            else if (tipo == "Lager")
            {
                return 1;
            }
            else if (tipo == "Hidromel")
            {
                return 2;
            }
            return -1;
        }


        public int selecionaForma(String forma)
        {
            if (forma == "Seca")
            {
                return 0;
            }
            else if (forma == "Liquida")
            {
                return 1;
            }
            else if (forma == "Cultura")
            {
                return 2;
            }
            return -1;
        }

        public int selecionaFloculacao(String floculacao)
        {
            if (floculacao == "Baixa")
            {
                return 0;
            }
            if (floculacao == "Media")
            {
                return 1;
            }
            if (floculacao == "Alta")
            {
                return 2;
            }
            if (floculacao == "Muito Alta")
            {
                return 3;
            }
            return -1;
        }
    }
}
