using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Brew.Mensagens
{
    class Mensagem
    {
        public void sucessoSalvar()
        {
            MessageBox.Show("Dados salvos com sucesso.", "Concluido",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public void camposNaoPreenchidos()
        {
            MessageBox.Show("Preencha os campos obrigatórios, existem campos não preenchidos.", "ALERTA",
                       MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }
        public void senhasDiferentes()
        {
            MessageBox.Show("As senhas estão diferentes ou nulas, favor preencher com senhas iguais.", "ALERTA",
            MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

    }
}
