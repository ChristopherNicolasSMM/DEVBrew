using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Brew.Mensagens
{
    public partial class MensagemForm : Form
    {
        private string retorno;
        public MensagemForm(string _retorno, string _msg1, string _msg2, string _msg3, int btns)
        {
            InitializeComponent();
            mensagemLb.Text = _msg1;
            mensagem2Lb.Text = _msg2;
            mensagem3Lb.Text = _msg3;
            if (btns == 1)
            {
                simBtn.Visible = false;
                naoBtn.Visible = false;
            }
            else if (btns == 2) {
                aceitarBtn.Visible = false;
            }
            this.retorno = _retorno;
        }

        private void NaoBtn_Click(object sender, EventArgs e)
        {
            this.retorno = "";
            this.Close();
        }

        private void SimBtn_Click(object sender, EventArgs e)
        {
            this.retorno = "X";
            this.Close();
        }

        private void AceitarBtn_Click(object sender, EventArgs e)
        {
            this.retorno = "X";
            this.Close();
        }
    }
}
