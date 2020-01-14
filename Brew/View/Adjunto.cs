using Brew.DAO;
using Brew.Funcoes;
using Brew.Mensagens;
using Brew.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Brew.View
{
    public partial class Adjunto : Form
    {
        public Adjunto(Boolean _permitirEditar, Ingredientes _ingrediente)
        {
            this.permitirEditar = _permitirEditar;
            InitializeComponent();
            modelAdjunto = new AdjuntoModel();
        }
        Ingredientes ingrediente;
        private Boolean permitirEditar;
        private Mensagem ms = new Mensagem();
        AdjuntoModel modelAdjunto = new AdjuntoModel();
        Image ImagemIlustracao;
        string binarioIlustracao;
        ImagemFuncoes imgFunc = new ImagemFuncoes();

        private void limpaCampos()
        {
            nometbx.Text = "";
            tipotbx.SelectedIndex = -1;
            indicacaotbx.Text = "";
            quantidadetbx.Text = "";
            usarParatbx.Text = "";
            tempotbx.Text = "";
            notastbx.Text = "";
            ilustacao.Image.Dispose();
            precoTxt.Text = "";
        }

        //*******************************************************************************
        private void salva_Click(object sender, EventArgs e)
        {
            if (nometbx.Text != "")
            {
                AdjuntoDAO dao = new AdjuntoDAO();

                if (modelAdjunto.id == null)
                {
                    modelAdjunto = new AdjuntoModel();
                }
                modelAdjunto.Nome = nometbx.Text;
                modelAdjunto.Tipo = tipotbx.Text;
                modelAdjunto.Indicacao = indicacaotbx.Text;
                modelAdjunto.Quantidade = Convert.ToDouble(quantidadetbx.Text);
                modelAdjunto.UsarPara = usarParatbx.Text;
                modelAdjunto.Tempo = tempotbx.Text;
                modelAdjunto.Notas = notastbx.Text;
                modelAdjunto.Ilustracao = binarioIlustracao;
                modelAdjunto.Preco = Convert.ToDouble(precoTxt.Text);

                dao.CriarAdjunto(modelAdjunto);
                limpaCampos();
                ms.sucessoSalvar();
            }

            else
            {
                ms.camposNaoPreenchidos();
            }
        }

        private void sairbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pesquisabtn_Click(object sender, EventArgs e)
        {
            AdjuntoDAO dao = new AdjuntoDAO();

            if (string.IsNullOrWhiteSpace(pesquisatbx.Text))
            {
                lvAdjunto.Items.Clear();
                var consulta = dao.GetTodosAdjuntos();
                foreach (var _adjunto in consulta)
                {
                    string[] arr = new string[3];
                    ListViewItem itm;
                    arr[0] = _adjunto.Nome;
                    arr[1] = _adjunto.Tipo;
                    arr[2] = _adjunto.Indicacao;
                    itm = new ListViewItem(arr);
                    lvAdjunto.Items.Add(itm);
                }
            }
            else
            {
                lvAdjunto.Items.Clear();
                var consulta = dao.GetAdjuntosPorNome(pesquisatbx.Text);
                foreach (var _adjunto in consulta)
                {
                    string[] arr = new string[3];
                    ListViewItem itm;
                    arr[0] = _adjunto.Nome;
                    arr[1] = _adjunto.Tipo;
                    arr[2] = _adjunto.Indicacao;
                    itm = new ListViewItem(arr);
                    lvAdjunto.Items.Add(itm);
                }

            }
        }

        private void lvAdjunto_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            String nomeAdjunto = "";
            foreach (ListViewItem item in lvAdjunto.SelectedItems)
            {
                nomeAdjunto = item.Text;
            }
            AdjuntoDAO dao = new AdjuntoDAO();
            //    AdjuntoFuncoes funcao = new AdjuntoFuncoes();
            var consulta = dao.GetAdjuntosPorNome(nomeAdjunto);
            foreach (var _adjunto in consulta)
            {
                nometbx.Text = _adjunto.Nome;
                tipotbx.Text = _adjunto.Tipo;
                indicacaotbx.Text = _adjunto.Indicacao;
                quantidadetbx.Text = Convert.ToString(_adjunto.Quantidade);
                usarParatbx.Text = _adjunto.UsarPara;
                tempotbx.Text = _adjunto.Tempo;
                notastbx.Text = _adjunto.Notas;
                ilustacao.Image = imgFunc.Base64ToImage(_adjunto.Ilustracao);
                precoTxt.Text = Convert.ToString(_adjunto.Preco);
                modelAdjunto = _adjunto;

            }
        }

        private void Adjunto_Load(object sender, EventArgs e)
        {
            lvAdjunto.GridLines = true;
            lvAdjunto.FullRowSelect = true;
            lvAdjunto.Columns.Add("Nome", 150);
            lvAdjunto.Columns.Add("Tipo", 80);
            lvAdjunto.Columns.Add("Indicação", 230);
            habilitaTabEdicao();
        }

        private void UtilizatBtn_Click(object sender, EventArgs e)
        {
            String nomeAdjunto = "";
            foreach (ListViewItem item in lvAdjunto.SelectedItems)
            {
                nomeAdjunto = item.Text;
            }
            AdjuntoDAO dao = new AdjuntoDAO();
            var consulta = dao.GetAdjuntosPorNome(nomeAdjunto);
            foreach (var _adjunto in consulta)
            {
                ingrediente.Descricao = _adjunto.Nome;
                ingrediente.Tipo = _adjunto.Tipo;
                ingrediente.Marca = "Indicação: " +  _adjunto.Indicacao;
                ingrediente.Quantidade = 1.0;
                ingrediente.Unidade = "g";
            }
        }

        private void habilitaTabEdicao()
        {
            if (this.permitirEditar == true)
            {
                if (tabControl.TabPages.Count < 2)
                {
                    tabControl.TabPages.Add(tab1);
                }
                utilizatBtn.Visible = false;
            }
            else
            {
                tabControl.TabPages.Remove(tab1);
            }
        }

        private void Ilustacao_Click(object sender, EventArgs e)
        {
            openFileDialog.CheckFileExists = true;
            openFileDialog.CheckPathExists = true;
            //openFileDialog.FilterIndex = 2;
            openFileDialog.RestoreDirectory = true;
            openFileDialog.ReadOnlyChecked = true;
            openFileDialog.ShowReadOnly = true;

            openFileDialog.Filter = "*.jpg|*.jpg|*.bmp|*.bmp|*.gif|*.gif|*.png|*.png";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    ImagemIlustracao = Image.FromFile(openFileDialog.FileName);

                    binarioIlustracao = imgFunc.ImageToBase64(ImagemIlustracao, ImageFormat.Gif);
                    ilustacao.Image = ImagemIlustracao;
                }
                catch (System.Security.SecurityException ex)
                {
                    // O usuário  não possui permissão para ler arquivos
                    MessageBox.Show("Erro de segurança Contate o administrador de segurança da rede.\n\n" +
                                                "Mensagem : " + ex.Message + "\n\n" +
                                                "Detalhes (enviar ao suporte):\n\n" + ex.StackTrace);
                }
                catch (Exception ex)
                {
                    // Não pode carregar a imagem (problemas de permissão)
                    MessageBox.Show("Não é possível exibir a imagem : " + openFileDialog.FileName
                                               + ". Você pode não ter permissão para ler o arquivo , ou " +
                                               " ele pode estar corrompido.\n\nErro reportado : " + ex.Message);
                }
            }
        }
    }
}
