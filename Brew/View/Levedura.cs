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
    public partial class Levedura : Form
    {
        public Levedura(Boolean _permitirEditar, Ingredientes _ingrediente)
        {
            InitializeComponent();
            modelLevedura = new LeveduraModel();
            this.permitirEditar = _permitirEditar;
            this.ingrediente = new Ingredientes();
            this.ingrediente = _ingrediente;
        }
        Ingredientes ingrediente;
        private Boolean permitirEditar;
        private Mensagem ms = new Mensagem();
        LeveduraModel modelLevedura;
        IEnumerable<LeveduraModel> consulta;
        Image ImagemIlustracao;
        string binarioIlustracao;
        ImagemFuncoes imgFunc = new ImagemFuncoes();

        private void limpaCampos()
        {
            nometbx.Text = "";
            laboratoriotbx.Text = "";
            produtoNSiglatbx.Text = "";
            formatbx.SelectedIndex = -1;
            tipotbx.SelectedIndex = -1;
            floculacaotbx.SelectedIndex = -1;
            atenuacaoMaxtbx.Text = "";
            atenuacaoMintbx.Text = "";
            temperaturaMaxtbx.Text = "";
            temperaturaMintbx.Text = "";
            celulasPacotetbx.Text = "";
            indicacoestbx.Text = "";
            notastbx.Text = "";
            ilustacao.Image.Dispose();
            precoTxt.Text = "";
        }

        private void sairbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void salva_Click(object sender, EventArgs e)
        {
            if (nometbx.Text != "")
            {
                LeveduraDAO dao = new LeveduraDAO();

                if (modelLevedura.id == null)
                {
                    modelLevedura = new LeveduraModel();
                }
                modelLevedura.Nome = nometbx.Text;
                modelLevedura.Laboratorio = laboratoriotbx.Text;
                modelLevedura.ProdutoNSigla = produtoNSiglatbx.Text;
                modelLevedura.Tipo = tipotbx.Text;
                modelLevedura.Forma = formatbx.Text;
                modelLevedura.Floculacao = floculacaotbx.Text;
                modelLevedura.AtenuacaoMax = Convert.ToInt32(atenuacaoMaxtbx.Text);
                modelLevedura.AtenuacaoMin = Convert.ToInt32(atenuacaoMintbx.Text);
                modelLevedura.TemperaturaMax = Convert.ToInt32(temperaturaMaxtbx.Text);
                modelLevedura.TemperaturaMin = Convert.ToInt32(temperaturaMintbx.Text);
                modelLevedura.CelulasPacote = Convert.ToInt32(celulasPacotetbx.Text);
                modelLevedura.Indicacao = indicacoestbx.Text;
                modelLevedura.Notas = notastbx.Text;
                modelLevedura.Ilustracao = binarioIlustracao;
                modelLevedura.Preco = Convert.ToDouble(precoTxt.Text);
                modelLevedura.Viabilidade = Convert.ToDouble(viabilidadeTxt.Text);
                modelLevedura.GramasPacote = Convert.ToDouble(gramasPacoteTxt.Text);
                dao.CriarLevedura(modelLevedura);
                limpaCampos();
                ms.sucessoSalvar();
            }

            else
            {
                ms.camposNaoPreenchidos();
            }
        }

        private void Levedura_Load(object sender, EventArgs e)
        {
            lvLevedura.GridLines = true;
            lvLevedura.FullRowSelect = true;
            lvLevedura.Columns.Add("Nome", 150);
            lvLevedura.Columns.Add("Laboratorio", 150);
            lvLevedura.Columns.Add("Sigla", 100);
            lvLevedura.Columns.Add("Cor", 50);
            habilitaTabEdicao();
        }

        private void pesquisabtn_Click(object sender, EventArgs e)
        {
            LeveduraDAO dao = new LeveduraDAO();

            lvLevedura.Items.Clear();
            if (string.IsNullOrWhiteSpace(pesquisatbx.Text))
            {
                consulta = null;
                consulta = dao.GetTodosLeveduras();

            }
            else
            {
                consulta = null;
                consulta = dao.GetLevedurasPorNome(pesquisatbx.Text);
            }

            foreach (var _levedura in consulta)
            {
                string[] arr = new string[3];
                ListViewItem itm;
                arr[0] = _levedura.Nome;
                arr[1] = _levedura.Laboratorio;
                arr[2] = _levedura.ProdutoNSigla;
                itm = new ListViewItem(arr);
                lvLevedura.Items.Add(itm);
            }
        }


        private void lvLevedura_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            String nomeLevedura = "";
            foreach (ListViewItem item in lvLevedura.SelectedItems)
            {
                nomeLevedura = item.Text;
            }
            LeveduraDAO dao = new LeveduraDAO();
            LeveduraFuncoes funcao = new LeveduraFuncoes();
            consulta = null;
            consulta = dao.GetLevedurasPorNome(nomeLevedura);
            foreach (var _levedura in consulta)
            {
                nometbx.Text = _levedura.Nome;
                laboratoriotbx.Text = _levedura.Laboratorio;
                produtoNSiglatbx.Text = _levedura.ProdutoNSigla;
                tipotbx.SelectedIndex = funcao.selecionaTipo(_levedura.Tipo);
                formatbx.SelectedIndex = funcao.selecionaForma(_levedura.Forma);
                floculacaotbx.SelectedIndex = funcao.selecionaFloculacao(_levedura.Floculacao);
                atenuacaoMaxtbx.Text = Convert.ToString(_levedura.AtenuacaoMax);
                atenuacaoMintbx.Text = Convert.ToString(_levedura.AtenuacaoMin);
                temperaturaMaxtbx.Text = Convert.ToString(_levedura.TemperaturaMax);
                temperaturaMintbx.Text = Convert.ToString(_levedura.TemperaturaMin);
                celulasPacotetbx.Text = Convert.ToString(_levedura.CelulasPacote);
                indicacoestbx.Text = _levedura.Indicacao;
                viabilidadeTxt.Text = Convert.ToString(_levedura.Viabilidade);
                gramasPacoteTxt.Text = Convert.ToString(_levedura.GramasPacote);
                notastbx.Text = _levedura.Notas;
                precoTxt.Text = Convert.ToString(_levedura.Preco);
                ilustacao.Image =  imgFunc.Base64ToImage(_levedura.Ilustracao);
                modelLevedura = _levedura;
            }
        }

        private void UtilizatBtn_Click(object sender, EventArgs e)
        {

            String nomeLevedura = "";
            foreach (ListViewItem item in lvLevedura.SelectedItems)
            {
                nomeLevedura = item.Text;
            }
            LeveduraDAO dao = new LeveduraDAO();
            LeveduraFuncoes funcao = new LeveduraFuncoes();
            consulta = null;
            consulta = dao.GetLevedurasPorNome(nomeLevedura);
            if (consulta != null)
            {
                foreach (var _levedura in consulta)
                {
                    this.ingrediente.Descricao = _levedura.Nome;
                    this.ingrediente.Marca = "Laboratório: " +  _levedura.Laboratorio;
                    this.ingrediente.Tipo = _levedura.Tipo;
                    this.ingrediente.Quantidade = 1.0;
                    this.ingrediente.Unidade = "Pkt";
                    this.ingrediente.TipoDoIngrediente = "Levedura";
                }
            }

            this.Close();
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
