using Brew.DAO;
using Brew.Funcoes;
using Brew.Mensagens;
using Brew.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.Drawing.Design;
using System.Security;
using System.IO;

namespace Brew.View
{
    public partial class Malte : Form
    {
        public Malte(Boolean _permitirEditar, Ingredientes _ingrediente)
        {
            this.permitirEditar = _permitirEditar;
            InitializeComponent();
            modelMalte = new MalteModel();
            this.ingrediente = _ingrediente;
        }
        Ingredientes ingrediente;
        NunConvFuncao convFuncao = new NunConvFuncao();
        private Boolean permitirEditar;
        private Mensagem ms = new Mensagem();
        MalteModel modelMalte;
        IEnumerable<MalteModel> consulta;
        Image ImagemIlustracao;
        string binarioIlustracao;
        ImagemFuncoes imgFunc = new ImagemFuncoes();

        private void limpaCampos()
        {
            nometbx.Text = "";
            origemtbx.Text = "";
            fabricantetbx.Text = "";
            tipotbx.SelectedIndex = -1;
            quantidadeMaxtbx.Text = "";
            cortbx.Text = "";
            usarMosturacbx.Checked = false;
            usarFervuracbx.Checked = false;
            naofermentavelcbx.Checked = false;
            potencialSGtbx.Text = "";
            aproveitamentotbx.Text = "";
            poderDiastaticotbx.Text = "";
            proteinatbx.Text = "";
            extIBUtbx.Text = "";
            notastbx.Text = "";
            ilustacao.Image.Dispose();
            precoTxt.Text = "";

        }

        // inicio de metodos criados automaticamente.

        private void sairbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void salva_Click(object sender, EventArgs e)
        {
            if (nometbx.Text != "")
            {
                MalteDAO dao = new MalteDAO();

                if (modelMalte.id == null)
                {
                    modelMalte = new MalteModel();
                }
                modelMalte.Nome = nometbx.Text;
                modelMalte.Origem = origemtbx.Text;
                modelMalte.Fabricante = fabricantetbx.Text;
                modelMalte.Tipo = tipotbx.Text;
                modelMalte.QuantidadeMax = Convert.ToInt32(quantidadeMaxtbx.Text);
                modelMalte.Cor = Convert.ToInt32(cortbx.Text);
                modelMalte.UsarMostura = usarMosturacbx.Checked;
                modelMalte.UsarFervura = usarFervuracbx.Checked;
                modelMalte.NaoFermentavel = naofermentavelcbx.Checked;
                modelMalte.PotencialSG = Convert.ToDouble(potencialSGtbx.Text);
                modelMalte.Aproveitamento = Convert.ToDouble(aproveitamentotbx.Text);
                modelMalte.PoderDiastatico = Convert.ToDouble(poderDiastaticotbx.Text);
                modelMalte.Proteina = Convert.ToDouble(proteinatbx.Text);
                modelMalte.ExtratoIBU = Convert.ToDouble(extIBUtbx.Text);
                modelMalte.Notas = notastbx.Text;
                modelMalte.Ilustracao = binarioIlustracao;
                modelMalte.Preco = Convert.ToDouble(precoTxt.Text);
                dao.CriarMalte(modelMalte);
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
            MalteDAO dao = new MalteDAO();

            lvMalte.Items.Clear();
            if (string.IsNullOrWhiteSpace(pesquisatbx.Text))
            {
                consulta = null;
                consulta = dao.GetTodosMalte();

            }
            else
            {
                consulta = null;
                consulta = dao.GetMaltesPorNome(pesquisatbx.Text);
            }

            foreach (var _malte in consulta)
            {
                string[] arr = new string[5];
                ListViewItem itm;
                arr[0] = _malte.Nome;
                arr[1] = _malte.Origem;
                arr[2] = _malte.Tipo;
                arr[3] = _malte.Fabricante;
                arr[4] = Convert.ToString(_malte.Cor);
                itm = new ListViewItem(arr);
                lvMalte.Items.Add(itm);
            }

        }

        private void Malte_Load(object sender, EventArgs e)
        {
            lvMalte.GridLines = true;
            lvMalte.FullRowSelect = true;
            lvMalte.Columns.Add("Nome", 150);
            lvMalte.Columns.Add("Origem", 150);
            lvMalte.Columns.Add("Tipo", 100);
            lvMalte.Columns.Add("Fabricante", 100);
            lvMalte.Columns.Add("Cor", 50);
            habilitaTabEdicao();
        }

        private void lvMalte_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            String nomeMalte = "";
            foreach (ListViewItem item in lvMalte.SelectedItems)
            {
                nomeMalte = item.Text;
            }
            MalteDAO dao = new MalteDAO();
            MalteFuncoes funcao = new MalteFuncoes();
            consulta = null;
            consulta = dao.GetMaltesPorNome(nomeMalte);
            foreach (var _malte in consulta)
            {
                nometbx.Text = _malte.Nome;
                origemtbx.Text = _malte.Origem;
                fabricantetbx.Text = _malte.Fabricante;
                tipotbx.SelectedIndex = funcao.selecionaTipo(_malte.Tipo);
                quantidadeMaxtbx.Text = Convert.ToString(_malte.QuantidadeMax);
                cortbx.Text = Convert.ToString(_malte.Cor);
                usarMosturacbx.Checked = _malte.UsarMostura;
                usarFervuracbx.Checked = _malte.UsarFervura;
                naofermentavelcbx.Checked = _malte.NaoFermentavel;
                potencialSGtbx.Text = Convert.ToString(_malte.PotencialSG);
                aproveitamentotbx.Text = Convert.ToString(_malte.Aproveitamento);
                poderDiastaticotbx.Text = Convert.ToString(_malte.PoderDiastatico);
                proteinatbx.Text = Convert.ToString(_malte.Proteina);
                extIBUtbx.Text = Convert.ToString(_malte.ExtratoIBU);
                notastbx.Text = _malte.Notas;
                ilustacao.Image = imgFunc.Base64ToImage(_malte.Ilustracao);
                precoTxt.Text = Convert.ToString(_malte.Preco);
                modelMalte = _malte;


            }
            permitirEditar = true;
            habilitaTabEdicao();
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

            String nomeMalte = "";
            foreach (ListViewItem item in lvMalte.SelectedItems)
            {
                nomeMalte = item.Text;
            }
            MalteDAO dao = new MalteDAO();
            MalteFuncoes funcao = new MalteFuncoes();
            consulta = null;
            consulta = dao.GetMaltesPorNome(nomeMalte);

            foreach (var _malte in consulta)
            {
                ingrediente.Descricao = _malte.Nome;
                ingrediente.PercentualIBU = _malte.ExtratoIBU;
                ingrediente.Tipo = _malte.Tipo;
                ingrediente.Marca = _malte.Fabricante + _malte.Origem;
                ingrediente.Quantidade = 1.0;
                ingrediente.Unidade = "Kg";
                ingrediente.TipoDoIngrediente = "Malte";
            }
            this.Close();
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
                catch (SecurityException ex)
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
