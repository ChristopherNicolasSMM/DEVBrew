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
    public partial class Equipamento : Form
    {
        public Equipamento()
        {
            InitializeComponent();
            modelEquipamento = new EquipamentoModel();
        }
        private Mensagem ms = new Mensagem();
        EquipamentoModel modelEquipamento;
        IEnumerable<EquipamentoModel> consulta;

        private void limpaCampos()
        {
            nometbx.Text = "";
        }

        // inicio de metodos criados automaticamente.


        private void salva_Click(object sender, EventArgs e)
        {
            if (nometbx.Text != "")
            {
                EquipamentoDAO dao = new EquipamentoDAO();

                if (modelEquipamento.id == null)
                {
                    modelEquipamento = new EquipamentoModel();
                }
                modelEquipamento.Nome = nometbx.Text;
                modelEquipamento.AguaAdicionadaFermentador = Convert.ToDouble(aguaAdicionadaFermentadortbx.Text );
                modelEquipamento.AguaAdicionadaFervura =     Convert.ToDouble(aguaAdicionadaFervuratbx.Text     );
                modelEquipamento.Envase = envasetbx.Text;
                modelEquipamento.VolumeEnvasado =            Convert.ToDouble(volumeEnvasadotbx.Text            );
                modelEquipamento.VolumeEquipamento =         Convert.ToDouble(volumeEquipamentotbx.Text         );
                modelEquipamento.VolumeFervura =             Convert.ToDouble(volumeFervuratbx.Text             );
                modelEquipamento.VolumeFinal = 0; //          Convert.ToDouble(volumeFinaltbx.Text               );
                modelEquipamento.VolumeLavagem =             Convert.ToDouble(volumeAguaLavagemtbx.Text         );
                modelEquipamento.VolumeMostura =             Convert.ToDouble(volumeMosturatbx.Text             );
                modelEquipamento.TaxaEvaporacao =            Convert.ToDouble(taxaEvaporacaotbx.Text            );
                modelEquipamento.PerdaFermentador =          Convert.ToDouble(perdaFermentadortbx.Text          );
                modelEquipamento.PerdaTrub =                 Convert.ToDouble(perdaTrubtbx.Text                 );
                dao.CriarEquipamento(modelEquipamento);
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
            EquipamentoDAO dao = new EquipamentoDAO();

            lvEquipamento.Items.Clear();
            if (string.IsNullOrWhiteSpace(pesquisatbx.Text))
            {
                consulta = null;
                consulta = dao.GetTodosEquipamento();

            }
            else
            {
                consulta = null;
                consulta = dao.GetEquipamentosPorNome(pesquisatbx.Text);
            }

            foreach (var _equipamento in consulta)
            {
                string[] arr = new string[2];
                ListViewItem itm;
                arr[0] = _equipamento.Nome;
                arr[1] = Convert.ToString(_equipamento.VolumeEquipamento);
                itm = new ListViewItem(arr);
                lvEquipamento.Items.Add(itm);
            }

        }

        private void Equipamento_Load(object sender, EventArgs e)
        {
            lvEquipamento.GridLines = true;
            lvEquipamento.FullRowSelect = true;
            lvEquipamento.Columns.Add("Nome", 2550);
            lvEquipamento.Columns.Add("Volume", 150);

        }

        private void lvEquipamento_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            String nomeEquipamento = "";
            foreach (ListViewItem item in lvEquipamento.SelectedItems)
            {
                nomeEquipamento = item.Text;
            }
            EquipamentoDAO dao = new EquipamentoDAO();
       //     EquipamentoFuncoes funcao = new EquipamentoFuncoes();
            consulta = null;
            consulta = dao.GetEquipamentosPorNome(nomeEquipamento);
            foreach (var _equipamento in consulta)
            {
                nometbx.Text = _equipamento.Nome;
                aguaAdicionadaFermentadortbx.Text = Convert.ToString(_equipamento.AguaAdicionadaFermentador);
                aguaAdicionadaFervuratbx.Text = Convert.ToString(_equipamento.AguaAdicionadaFervura);
                envasetbx.Text = _equipamento.Envase;
                volumeEnvasadotbx.Text = Convert.ToString(_equipamento.VolumeEnvasado);
                volumeEquipamentotbx.Text = Convert.ToString(_equipamento.VolumeEquipamento);
                volumeFervuratbx.Text = Convert.ToString(_equipamento.VolumeFervura);
                volumeFinaltbx.Text = Convert.ToString(_equipamento.VolumeFinal);
                volumeAguaLavagemtbx.Text = Convert.ToString(_equipamento.VolumeLavagem);
                volumeMosturatbx.Text = Convert.ToString(_equipamento.VolumeMostura);
                taxaEvaporacaotbx.Text = Convert.ToString(_equipamento.TaxaEvaporacao);
                perdaFermentadortbx.Text = Convert.ToString(_equipamento.PerdaFermentador);
                perdaTrubtbx.Text = Convert.ToString(_equipamento.PerdaTrub);
                evaporacaoTotaltbx.Text = Convert.ToString(_equipamento.EvaporacaoTotal);
                modelEquipamento = _equipamento;
            }
        }

        private void sairbtn_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
