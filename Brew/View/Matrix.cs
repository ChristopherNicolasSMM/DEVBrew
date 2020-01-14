using Brew.Funcoes;
using Brew.Mensagens;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Brew.View
{
    public partial class Matrix : Form
    {
        public Matrix()
        {
            InitializeComponent();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cervejeiroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cervejeiro cervejeiro = new Cervejeiro();
            cervejeiro.ShowDialog();
        }

        private void lupuloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Lupulo lupulo = new Lupulo(true, null);
            lupulo.Show();
        }

        private void malteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Malte malte = new Malte(true, null);
            malte.Show();
        }

        private void leveduraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Levedura levedura = new Levedura(true, null);
            levedura.ShowDialog();
        }

        private void receitasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Receita receita = new Receita();
            receita.Show();
        }

        private void adjuntoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Adjunto adjunto = new Adjunto(true, null);
            adjunto.Show();
        }

        private void equipamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Equipamento equipamento = new Equipamento();
            equipamento.ShowDialog();
        }

        private void estiloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Estilo estilo = new Estilo();
            estilo.ShowDialog();
        }

        private void ConexãoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void InternetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConexaoHardware conexaoHardware = new ConexaoHardware();
            conexaoHardware.ShowDialog();
        }

        private void SerialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Conexao conexao = new Conexao();
            conexao.ShowDialog();
        }

        private void PainelDeOperaçõesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PainelOperacoes painel = new PainelOperacoes();
            painel.ShowDialog();
        }

        private void TesteToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void TesteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ExemploComponente comp = new ExemploComponente();
            comp.ShowDialog();
            //MensagemForm msg = new MensagemForm("","Testando classe de mensagem... Click em ok para sair...","","",1 );
            //msg.ShowDialog();
        }

        private void Matrix_Load(object sender, EventArgs e)
        {
          
        }
    }
}
