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

namespace Brew
{
    public partial class Cervejeiro : Form
    {
        private CervejeiroModel modelCervejeiro;
        private Mensagem ms = new Mensagem();
        Image ImagemIlustracao;
        string binarioIlustracao;
        ImagemFuncoes imgFunc = new ImagemFuncoes();
        public Cervejeiro()
        {
            InitializeComponent();
            modelCervejeiro = new CervejeiroModel();

        }

        private void limpaSenha()
        {
            senha2tbx.Text = "";
            senhatbx.Text = "";
        }

        private void limpaCampos()
        {
            limpaSenha();
            nometbx.Text = "";
            emailtbx.Text = "";
            whatsapptbx.Text = "";
            senhatbx.Text = "";
            senha2tbx.Text = "";
            ilustacao.Image.Dispose();            
        }

        private void sairbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void salva_Click(object sender, EventArgs e)
        {
            if (nometbx.Text != "")
            {
                CervejeiroDAO dao = new CervejeiroDAO();
                if (senhatbx.Text == senha2tbx.Text && senhatbx.Text != "")
                {
                    if (modelCervejeiro.id == null)
                    {
                        modelCervejeiro = new CervejeiroModel();
                    }
                    modelCervejeiro.Nome = nometbx.Text;
                    modelCervejeiro.Email = emailtbx.Text;
                    modelCervejeiro.Senha = senhatbx.Text;
                    modelCervejeiro.Whatsapp = whatsapptbx.Text;
                    modelCervejeiro.Ilustracao = binarioIlustracao;
                    dao.CriarCervejeiro(modelCervejeiro);
                    limpaCampos();
                    ms.sucessoSalvar();
                }
                else
                {
                    ms.senhasDiferentes();
                    limpaSenha();
                }
            }
            else
            {
                ms.camposNaoPreenchidos();
            }
            
        }

        private void pesquisabtn_Click(object sender, EventArgs e)
        {
            CervejeiroDAO dao = new CervejeiroDAO();

            if (string.IsNullOrWhiteSpace(pesquisatbx.Text))
            {
                lv.Items.Clear();
                var consulta = dao.GetTodosCervejeiros();
                foreach (var _cervejeiro in consulta)
                {
                    string[] arr = new string[4];
                    ListViewItem itm;

                    arr[0] = _cervejeiro.Nome;
                    arr[1] = _cervejeiro.Email;
                    arr[2] = _cervejeiro.Whatsapp;
                    itm = new ListViewItem(arr);
                    lv.Items.Add(itm);
                }
            }
            else
            {
                lv.Items.Clear();
                var consulta = dao.GetCervejeirosPorNome(pesquisatbx.Text);
                foreach (var _cervejeiro in consulta)
                {
                    string[] arr = new string[4];
                    ListViewItem itm;

                    arr[0] = _cervejeiro.Nome;
                    arr[1] = _cervejeiro.Email;
                    arr[2] = _cervejeiro.Whatsapp;
                    itm = new ListViewItem(arr);
                    lv.Items.Add(itm);
                }

            }
        }

        private void Cervejeiro_Load(object sender, EventArgs e)
        {
            
            lv.GridLines = true;
            lv.FullRowSelect = true;
            lv.Columns.Add("Nome", 200);
            lv.Columns.Add("Email", 150);
            lv.Columns.Add("Whatsapp", 150);
        }

        private void lv_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void lv_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            String nomeCervejeiro = "";
            foreach (ListViewItem item in lv.SelectedItems)
            {
                nomeCervejeiro = item.Text;
            }
            CervejeiroDAO dao = new CervejeiroDAO();
            var consulta = dao.GetCervejeirosPorNome(nomeCervejeiro);
            foreach (var _cervejeiro in consulta)
            {
                nometbx.Text = _cervejeiro.Nome;
                emailtbx.Text = _cervejeiro.Email;
                senhatbx.Text = _cervejeiro.Senha;
                whatsapptbx.Text = _cervejeiro.Whatsapp;
                ilustacao.Image = imgFunc.Base64ToImage(_cervejeiro.Ilustracao);
                modelCervejeiro = _cervejeiro;
            }
        }

        private void label6_Click(object sender, EventArgs e)
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
