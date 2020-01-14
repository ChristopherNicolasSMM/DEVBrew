using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Brew.Funcoes
{
    class MalteFuncoes
    {
        public int selecionaTipo(String tipo)
        {
            if (tipo == "Grão")
            {
                return 0;
            }
            else if (tipo == "Extrato Seco")
            {
                return 1;
            }
            else if (tipo == "Extrato Liquido")
            {
                return 2;
            }
            else if (tipo == "Açucares")
            {
                return 3;
            }
            return -1;

        }

        public string retornaTipo(int tipo)
        {
            if (tipo == 0)
            {
                return "Grão";
            }
            else if (tipo == 1)
            {
                return "Extrato Seco";
            }
            else if (tipo == 2)
            {
                return "Extrato Liquido";
            }
            else if (tipo == 3)
            {
                return "Açucares";
            }
            return "";

        }
    }
}
