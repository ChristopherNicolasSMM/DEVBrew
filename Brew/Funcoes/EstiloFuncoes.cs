using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Brew.Funcoes
{
    class EstiloFuncoes
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
    }
}
