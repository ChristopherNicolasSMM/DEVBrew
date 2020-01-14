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

namespace Brew.View
{
    public partial class Estilo : Form
    {
        public Estilo()
        {
            InitializeComponent();
            modelEstilo = new EstiloModel();
        }
        private Mensagem ms = new Mensagem();
        EstiloModel modelEstilo;
        IEnumerable<EstiloModel> consulta;


        private void limpaCampos()
        {
            nometbx.Text = "";
            numerotbx.Text = "";
            categoriatbx.Text = "";
            tipotbx.SelectedIndex = -1;
            guiatbx.Text = "";
            OGMaxtbx.Text = "";
            OGMintbx.Text = "";
            IBUMaxtbx.Text = "";
            IBUMintbx.Text = "";
            carbonatacaoMaxtbx.Text = "";
            carbonatacaoMintbx.Text = "";
            ABVMaxtbx.Text = "";
            ABVMintbx.Text = "";
            CORMaxtbx.Text = "";
            CORMintbx.Text = "";
            descricaotbx.Text = "";
            perfiltbx.Text = "";
            ingredientestbx.Text = "";
            exemplostbx.Text = "";

        }

        //****************************************************************************
        private void salva_Click(object sender, EventArgs e)
        {
            
            if (nometbx.Text != "")
            {
                EstiloDAO dao = new EstiloDAO();

                if (modelEstilo.id == null)
                {
                    modelEstilo = new EstiloModel();
                }
                modelEstilo.Nome = nometbx.Text;
                modelEstilo.Numero = numerotbx.Text;
                modelEstilo.Categoria = categoriatbx.Text;
                modelEstilo.Tipo = tipotbx.Text;
                modelEstilo.Guia = guiatbx.Text;
                modelEstilo.OGMax = Convert.ToDouble(OGMaxtbx.Text);
                modelEstilo.OGMin = Convert.ToDouble(OGMintbx.Text);
                modelEstilo.FGMax = Convert.ToDouble(FGMaxtbx.Text);
                modelEstilo.FGMin = Convert.ToDouble(FGMintbx.Text);
                modelEstilo.IBUMax = Convert.ToDouble(IBUMaxtbx.Text);
                modelEstilo.IBUMin = Convert.ToDouble(IBUMintbx.Text);
                modelEstilo.CarbonatacaoMax = Convert.ToDouble(carbonatacaoMaxtbx.Text);
                modelEstilo.CarbonatacaoMin = Convert.ToDouble(carbonatacaoMintbx.Text);
                modelEstilo.ABVMax = Convert.ToDouble(ABVMaxtbx.Text);
                modelEstilo.ABVMin = Convert.ToDouble(ABVMintbx.Text);
                modelEstilo.CORMax = Convert.ToDouble(CORMaxtbx.Text);
                modelEstilo.CORMin = Convert.ToDouble(CORMintbx.Text);
                modelEstilo.Descricao = descricaotbx.Text;
                modelEstilo.Perfil = perfiltbx.Text;
                modelEstilo.Ingredientes = ingredientestbx.Text;
                modelEstilo.Exemplos = exemplostbx.Text;
                dao.CriarEstilo(modelEstilo);
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
            EstiloDAO dao = new EstiloDAO();

            lvEstilo.Items.Clear();
            if (string.IsNullOrWhiteSpace(pesquisatbx.Text))
            {
                consulta = null;
                consulta = dao.GetTodosEstilos();

            }
            else
            {
                consulta = null;
                consulta = dao.GetEstilosPorNome(pesquisatbx.Text);
            }

            foreach (var _estilo in consulta)
            {
                string[] arr = new string[4];
                ListViewItem itm;
                arr[0] = _estilo.Nome;
                arr[1] = _estilo.Categoria;
                arr[2] = _estilo.Tipo;
                arr[3] = _estilo.Descricao;
                itm = new ListViewItem(arr);
                lvEstilo.Items.Add(itm);
            }
        }

        private void Estilo_Load(object sender, EventArgs e)
        {
            lvEstilo.GridLines = true;
            lvEstilo.FullRowSelect = true;
            lvEstilo.Columns.Add("Nome", 150);
            lvEstilo.Columns.Add("Categoria", 200);
            lvEstilo.Columns.Add("Tipo", 80);
            lvEstilo.Columns.Add("Descricao", 300);
        }

        private void lvEstilo_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            String nomeEstilo = "";
            foreach (ListViewItem item in lvEstilo.SelectedItems)
            {
                nomeEstilo = item.Text;
            }
            EstiloDAO dao = new EstiloDAO();
            EstiloFuncoes funcao = new EstiloFuncoes();
            consulta = null;
            consulta = dao.GetEstilosPorNome(nomeEstilo);
            foreach (var _estilo in consulta)
            {
                nometbx.Text = _estilo.Nome;
                numerotbx.Text = _estilo.Numero;
                categoriatbx.Text = _estilo.Categoria;
                tipotbx.Text = _estilo.Tipo;
                guiatbx.Text = _estilo.Guia;
                OGMaxtbx.Text = Convert.ToString(_estilo.OGMax);
                OGMintbx.Text = Convert.ToString(_estilo.OGMin);
                FGMaxtbx.Text = Convert.ToString(_estilo.FGMax);
                FGMintbx.Text = Convert.ToString(_estilo.FGMin);
                IBUMaxtbx.Text = Convert.ToString(_estilo.IBUMax);
                IBUMintbx.Text = Convert.ToString(_estilo.IBUMin);
                carbonatacaoMaxtbx.Text = Convert.ToString(_estilo.CarbonatacaoMax);
                carbonatacaoMintbx.Text = Convert.ToString(_estilo.CarbonatacaoMin);
                ABVMaxtbx.Text = Convert.ToString(_estilo.ABVMax);
                ABVMintbx.Text = Convert.ToString(_estilo.ABVMin);
                CORMaxtbx.Text = Convert.ToString(_estilo.CORMax);
                CORMintbx.Text = Convert.ToString(_estilo.CORMin);
                descricaotbx.Text = _estilo.Descricao ;
                perfiltbx.Text = _estilo.Perfil;
                ingredientestbx.Text = _estilo.Ingredientes;
                exemplostbx.Text = _estilo.Exemplos;
                modelEstilo = _estilo;
            }
        }

        private void sairbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
