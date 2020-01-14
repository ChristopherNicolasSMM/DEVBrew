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
    public partial class Lupulo : Form
    {
        public Lupulo(Boolean _permitirEditar, Ingredientes _ingrediente)
        {
            InitializeComponent();
            modelLupulo = new LupuloModel();
            this.permitirEditar = _permitirEditar;
            this.ingrediente = new Ingredientes();
            this.ingrediente = _ingrediente;
        }
        private Mensagem ms = new Mensagem();
        LupuloModel modelLupulo = new LupuloModel();
        Image ImagemIlustracao;
        string binarioIlustracao;
        ImagemFuncoes imgFunc = new ImagemFuncoes();
        Ingredientes ingrediente;
        private Boolean permitirEditar;

        private void limpaCampos()
        {
            nometbx.Text = "";
            origemtbx.Text = "";
            acidoAlfatbx.Text = "";
            acidoBetatbx.Text = "";
            formatbx.SelectedIndex = -1;
            tipotbx.SelectedIndex = -1;
            notastbx.Text = "";
            ilustacao.Image.Dispose();
            precoTxt.Text = "";
        }


        //Inicio Metodos criados automaticamente
        private void sairbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void salva_Click(object sender, EventArgs e)
        {
            if (nometbx.Text != "" || acidoBetatbx.Text != null || acidoAlfatbx.Text != null)
            {
                LupuloDAO dao = new LupuloDAO();

                if (modelLupulo.id == null)
                {
                    modelLupulo = new LupuloModel();
                }
                modelLupulo.Nome = nometbx.Text;
                modelLupulo.Origem = origemtbx.Text;
                modelLupulo.Tipo = tipotbx.Text;
                modelLupulo.Forma = formatbx.Text;
                modelLupulo.AcidoAlfa = Convert.ToDouble(acidoAlfatbx.Text);
                modelLupulo.AcidoBeta = Convert.ToDouble(acidoBetatbx.Text);
                modelLupulo.Notas = notastbx.Text;
                modelLupulo.Ilustracao = binarioIlustracao;
                modelLupulo.Preco = Convert.ToDouble(precoTxt.Text);
                dao.CriarLupulo(modelLupulo);
                limpaCampos();
                ms.sucessoSalvar();
            }

            else
            {
                ms.camposNaoPreenchidos();
            }
        }

        private void pesquisabtn_Click(object sender, EventArgs e)
        {

            LupuloDAO dao = new LupuloDAO();

            if (string.IsNullOrWhiteSpace(pesquisatbx.Text))
            {
                lvLupulo.Items.Clear();
                var consulta = dao.GetTodosLupulos();
                foreach (var _lupulo in consulta)
                {
                    string[] arr = new string[6];
                    ListViewItem itm;
                    arr[0] = _lupulo.Nome;
                    arr[1] = _lupulo.Origem;
                    arr[2] = _lupulo.Tipo;
                    arr[3] = _lupulo.Forma;
                    arr[4] = Convert.ToString(_lupulo.AcidoAlfa);
                    arr[5] = Convert.ToString(_lupulo.AcidoBeta);
                    itm = new ListViewItem(arr);
                    lvLupulo.Items.Add(itm);
                }
            }
            else
            {
                lvLupulo.Items.Clear();
                var consulta = dao.GetLupulosPorNome(pesquisatbx.Text);
                foreach (var _lupulo in consulta)
                {
                    string[] arr = new string[6];
                    ListViewItem itm;
                    arr[0] = _lupulo.Nome;
                    arr[1] = _lupulo.Origem;
                    arr[2] = _lupulo.Tipo;
                    arr[3] = _lupulo.Forma;
                    arr[4] = Convert.ToString(_lupulo.AcidoAlfa);
                    arr[5] = Convert.ToString(_lupulo.AcidoBeta);
                    itm = new ListViewItem(arr);
                    lvLupulo.Items.Add(itm);
                }

            }
        }

        private void Lupulo_Load(object sender, EventArgs e)
        {
            lvLupulo.GridLines = true;
            lvLupulo.FullRowSelect = true;
            lvLupulo.Columns.Add("Nome", 150);
            lvLupulo.Columns.Add("Origem", 150);
            lvLupulo.Columns.Add("Tipo", 100);
            lvLupulo.Columns.Add("Forma", 100);
            lvLupulo.Columns.Add("A.A.", 50);
            lvLupulo.Columns.Add("A.B", 50);
            habilitaTabEdicao();
        }

        private void lvLupulo_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            String nomeLupulo = "";
            foreach (ListViewItem item in lvLupulo.SelectedItems)
            {
                nomeLupulo = item.Text;
            }
            LupuloDAO dao = new LupuloDAO();
            LupuloFuncoes funcao = new LupuloFuncoes();
            var consulta = dao.GetLupulosPorNome(nomeLupulo);
            foreach (var _lupulo in consulta)
            {
                nometbx.Text = _lupulo.Nome;
                origemtbx.Text = _lupulo.Origem;
                acidoAlfatbx.Text = Convert.ToString(_lupulo.AcidoAlfa);
                acidoBetatbx.Text = Convert.ToString(_lupulo.AcidoBeta);
                formatbx.SelectedIndex = funcao.selecionaForma(_lupulo.Forma);
                tipotbx.SelectedIndex = funcao.selecionaTipo(_lupulo.Tipo);
                notastbx.Text = _lupulo.Notas;
                ilustacao.Image = imgFunc.Base64ToImage(_lupulo.Ilustracao);
                precoTxt.Text = Convert.ToString(_lupulo.Preco);
                modelLupulo = _lupulo;
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

        private void UtilizatBtn_Click(object sender, EventArgs e)
        {

            String nomeLupulo = "";
            foreach (ListViewItem item in lvLupulo.SelectedItems)
            {
                nomeLupulo = item.Text;
            }
            LupuloDAO dao = new LupuloDAO();
            LupuloFuncoes funcao = new LupuloFuncoes();
            var consulta = dao.GetLupulosPorNome(nomeLupulo);

            if (consulta != null)
            {
                foreach (var _lupulo in consulta)
                {
                    this.ingrediente.Descricao = _lupulo.Nome;
                    this.ingrediente.Tipo = _lupulo.Tipo;
                    this.ingrediente.PercentualIBU = _lupulo.AcidoAlfa;
                    this.ingrediente.Marca = "Origem: " + _lupulo.Origem;
                    this.ingrediente.Quantidade = 1.0;
                    this.ingrediente.Unidade = "g";
                    this.ingrediente.Custo = _lupulo.Preco;
                    this.ingrediente.TempoAdicao = "60:00";
                    this.ingrediente.TipoDoIngrediente = "Lupulo";
                }
            }

            this.Close();
        }

        private void LvLupulo_SelectedIndexChanged(object sender, EventArgs e)
        {

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
