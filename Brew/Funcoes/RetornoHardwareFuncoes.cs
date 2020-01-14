using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Brew.Funcoes
{
    class RetornoHardwareFuncoes
    {
        Double value;
        private System.Windows.Forms.WebBrowser webBrowser;

        public Double getReturn(System.Windows.Forms.WebBrowser _webBrowser, string _porta)
        {
            this.webBrowser = _webBrowser;
            String ret = this.webBrowser.Document.GetElementById(_porta).GetAttribute("value");

            if (this.webBrowser.Document.GetElementById(_porta).GetAttribute("value") != null)
            {
                value = Convert.ToDouble(this.webBrowser.Document.GetElementById(_porta).GetAttribute("value"));
            }
            else
            {
                value = 0.0;
            }

            return value;
        }
    }
}
