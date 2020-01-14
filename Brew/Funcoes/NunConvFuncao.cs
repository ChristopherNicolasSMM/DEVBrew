using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Brew.Funcoes
{
    class NunConvFuncao
    {
        public Object Converter(Object _valorNumerico)
        {
            if (_valorNumerico == null || _valorNumerico == "" || _valorNumerico == " ")
            {
                _valorNumerico = 0;
            }
            return _valorNumerico;
        }
    }
}
