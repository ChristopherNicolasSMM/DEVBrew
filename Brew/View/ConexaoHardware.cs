using Brew.DAO;
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
    public partial class ConexaoHardware : Form
    {
        private ConexaoHardwareModel conexaoHardwareModel = new ConexaoHardwareModel();
        private Mensagem ms = new Mensagem();
        public ConexaoHardware()
        {
            InitializeComponent();
            conexaoHardwareModel = new ConexaoHardwareModel();
        }

        private void LimpaTela()
        {
            dispositivoTbx.Text = "";
            ipTbx.Text = "";
            gatewayTbx.Text = "";
            mascaraTbx.Text = "";
            DDNSTbx.Text = "";
            statusCbx.Checked = false;
            gvPortas.Rows.Clear();

        }

        private void Sairbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Salva_Click(object sender, EventArgs e)
        {
            if (dispositivoTbx.Text != "" || ipTbx.Text != null || mascaraTbx.Text != null)
            {
                ConexaoHardwareDAO dao = new ConexaoHardwareDAO();
                PortaModel portaModel;

                if (conexaoHardwareModel.id == null)
                {
                    conexaoHardwareModel = new ConexaoHardwareModel();
                }
                conexaoHardwareModel.Dispositivo = dispositivoTbx.Text;
                conexaoHardwareModel.IP = ipTbx.Text;
                conexaoHardwareModel.Gateway = gatewayTbx.Text;
                conexaoHardwareModel.MascaraDeRede = mascaraTbx.Text;
                conexaoHardwareModel.DDNS = DDNSTbx.Text;
                conexaoHardwareModel.Ativo = statusCbx.Checked;

                List<PortaModel> listPortas = new List<PortaModel>();

                if (gvPortas.Rows != null )
                {
                    foreach (DataGridViewRow row in gvPortas.Rows)
                    {
                        if (row.Cells["Porta"].Value != null)
                        {
                        portaModel = new PortaModel();
                        portaModel.Funcao = Convert.ToString(row.Cells["Funcao"].Value);
                        portaModel.Porta  = Convert.ToString(row.Cells["Porta"].Value);
                        portaModel.Descricao = Convert.ToString(row.Cells["Descricao"].Value);
                        listPortas.Add(portaModel);
                        }
                    }
                    if (listPortas != null)
                    {
                        conexaoHardwareModel.Portas = listPortas;
                    }
                }
                dao.CriarConexao(conexaoHardwareModel);
                LimpaTela();
                ms.sucessoSalvar();
            }
            else
            {
                ms.camposNaoPreenchidos();
            }
            getDispositivos();
        }

        private void ConexaoHardware_Load(object sender, EventArgs e)
        {
            lvDispositivos.GridLines = true;
            lvDispositivos.FullRowSelect = true;
            lvDispositivos.Columns.Add("Dispositivo", 60);
            lvDispositivos.Columns.Add("Ativo", 20);
            getDispositivos();

        }

        private void getDispositivos()
        {

            ConexaoHardwareDAO dao = new ConexaoHardwareDAO();

            lvDispositivos.Items.Clear();
                var consulta = dao.GetTodasConexoes();
                foreach (var _conexaoHardware in consulta)
                {
                    string[] arr = new string[2];
                    ListViewItem itm;
                    arr[0] = _conexaoHardware.Dispositivo;
                    arr[1] = Convert.ToString(_conexaoHardware.Ativo);
                    itm = new ListViewItem(arr);
                    lvDispositivos.Items.Add(itm);
                }
          

         }

        private void LvDispositivos_DoubleClick(object sender, EventArgs e)
        {
            LimpaTela();
            String nomeDispositivo = "";
            foreach (ListViewItem item in lvDispositivos.SelectedItems)
            {
                nomeDispositivo = item.Text;
            }
            ConexaoHardwareDAO dao = new ConexaoHardwareDAO();
            var consulta = dao.GetConexaoPorDispositivo(nomeDispositivo);
            foreach (var _conexaoHardware in consulta)
            {
                conexaoHardwareModel.id = _conexaoHardware.id;

                dispositivoTbx.Text = _conexaoHardware.Dispositivo;
                ipTbx.Text = _conexaoHardware.IP;
                gatewayTbx.Text = _conexaoHardware.Gateway;
                mascaraTbx.Text = _conexaoHardware.MascaraDeRede;
                DDNSTbx.Text = _conexaoHardware.DDNS;
                statusCbx.Checked = _conexaoHardware.Ativo;

                gvPortas.Rows.Clear();
                foreach (var item in _conexaoHardware.Portas)
                {
                    DataGridViewRow gvPortasLinha = (DataGridViewRow)gvPortas.Rows[0].Clone();
                    gvPortasLinha.Cells[0].Value = item.Funcao;
                    gvPortasLinha.Cells[1].Value = item.Porta;
                    gvPortasLinha.Cells[2].Value = item.Descricao;
                    gvPortas.Rows.Add(gvPortasLinha);
                }
            }
        }

        private void LvDispositivos_Click(object sender, EventArgs e)
        {

        }

        private void GvPortas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void LvDispositivos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
    }
