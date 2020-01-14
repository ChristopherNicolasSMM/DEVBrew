using Brew.DAO;
using Brew.Funcoes;
using Brew.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Brew.View
{
    public partial class PainelOperacoes : Form
    {
        public PainelOperacoes()
        {
            InitializeComponent();
            label = aGauge1.GaugeLabels.FindByName("GaugeLabel1");
            alert = aGauge1.GaugeRanges.FindByName("AlertRange");
            aGauge1.ValueInRangeChanged += AGauge1_ValueInRangeChanged;
            ConexaoHardwareDAO hardwareDAO = new ConexaoHardwareDAO();
            hardwareCollection = hardwareDAO.GetTodasConexoes();
            foreach (var _hardwareModelList in hardwareCollection)
            {
                hardwareDisponivelcbx.Items.Add(_hardwareModelList.Dispositivo);
            }
            ReceitaDAO receitaDAO = new ReceitaDAO();
            receitasCollection = receitaDAO.GetTodasReceitas();
            foreach (var _receitasModelList in receitasCollection)
            {
                receitaCb.Items.Add(_receitasModelList.Nome);
            }
            pnlAcoes.Enabled = false;
            pnlLog.Enabled = false;
        }
        IEnumerable<ConexaoHardwareModel> hardwareCollection;
        IEnumerable<ReceitaModel> receitasCollection;
        private System.Windows.Forms.AGaugeLabel label;
        private System.Windows.Forms.AGaugeRange alert;
        private ConexaoHardwareModel hardwareModel;

        private List<PortaModel> portas;
        private PortaModel porta;
        private int temporizadorContador;

        private void AGauge1_ValueInRangeChanged(object sender, ValueInRangeChangedEventArgs e)
        {

        }


        private void PainelOperacoes_Load(object sender, EventArgs e)
        {/*
            webBrowser1.Navigate("192.168.137.12");
            while (webBrowser1.ReadyState != WebBrowserReadyState.Complete)
            {
                System.Threading.Thread.Sleep(TimeSpan.FromSeconds(10));
                Application.DoEvents();
            }
            //webBrowser1.Document.GetElementById("UserName").SetAttribute("value", "usuarioxyz");
            //porta.Porta = webBrowser1.Document.GetElementById("P2").GetAttribute("value");*/

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void TestaGaugebtn_Click(object sender, EventArgs e)
        {
            aGauge1.GaugeRanges.Add(new AGaugeRange(Color.Blue, 40, 60));
        }

        private void TrackBar1_ValueChanged(object sender, EventArgs e)
        {
            //aGauge1.Value = trackBar1.Value;
        }

        private void AGauge1_ValueChanged(object sender, EventArgs e)
        {
            label.Text = aGauge1.Value.ToString();
        }

        private void aGauge1_ValueInRangeChanged(object sender, System.Windows.Forms.ValueInRangeChangedEventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("InRange Event.");
            if (e.Range == alert)
            {
                // panel1.BackColor = e.InRange ? Color.Red : Color.FromKnownColor(KnownColor.Control);
            }
        }

        private void Sairbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EntradaDeAguabtn_Click(object sender, EventArgs e)
        {
            setComandoHardware("P5=5");
        }

        private void PainelDeAcao(object sender, EventArgs e)
        {

            //setComandoHardware("P5=5");
        }

        private void setComandoHardware(String _parametro)
        {
            if (hardwareModel.IP != null)
            {

                //string urlAddress = "http://" + hardwareModel.IP + "/?" + _parametro;
                string urlAddress = "http://localhost" + "/?" + _parametro;
                urlAddress.Replace(',', '.');
                RetornoHardwareFuncoes retorno = new RetornoHardwareFuncoes();

                webBrowser1.Navigate(urlAddress);

                while (webBrowser1.ReadyState != WebBrowserReadyState.Complete)
                {
                    System.Threading.Thread.Sleep(TimeSpan.FromSeconds(1));
                    Application.DoEvents();
                }
                if (hardwareModel.Portas != null)
                {
                    foreach (var item in hardwareModel.Portas)
                    {
                        try
                        {
                            if (item.Funcao == "Digital")
                            {
                                string tratativaDigital = webBrowser1.Document.GetElementById(item.Porta).GetAttribute("checked");
                                if (tratativaDigital == null)
                                {
                                    item.Valor = 0.0;
                                }
                                else
                                {
                                    if (Convert.ToBoolean(tratativaDigital))
                                    {
                                        item.Valor = 1.0;
                                    }
                                    else
                                    {
                                        item.Valor = 0.0;
                                    }
                                }
                            }
                            else if (item.Funcao == "Analogica")
                            {
                                string tratativaAnalogico = webBrowser1.Document.GetElementById(item.Porta).GetAttribute("value");
                                if (tratativaAnalogico == null)
                                {
                                    item.Valor = 0.0;
                                }
                                else
                                {
                                    item.Valor = Convert.ToDouble(tratativaAnalogico);
                                }
                            }
                        }
                        catch (Exception E)
                        {

                            //throw; Menssagem erro ao estabelecer conexão com o Hardware
                        }

                    }
                }
            }
        }
        private void getRetornoHTML()
        {

        }

        private void setHardware()
        {
            hardwareModel = new ConexaoHardwareModel();
            ConexaoHardwareDAO dao = new ConexaoHardwareDAO();
            var consulta = dao.GetConexaoPorDispositivo(hardwareDisponivelcbx.Text);
            if (consulta != null)
            {
                foreach (var _conexaoHardware in consulta)
                {
                    hardwareModel.id = _conexaoHardware.id;

                    hardwareModel.Dispositivo = _conexaoHardware.Dispositivo;
                    hardwareModel.IP = _conexaoHardware.IP;
                    hardwareModel.Gateway = _conexaoHardware.Gateway;
                    hardwareModel.MascaraDeRede = _conexaoHardware.MascaraDeRede;
                    hardwareModel.DDNS = _conexaoHardware.DDNS;
                    hardwareModel.Ativo = _conexaoHardware.Ativo;
                    if (_conexaoHardware.Portas != null)
                    {
                        List<PortaModel> portaList = new List<PortaModel>();
                        foreach (var item in _conexaoHardware.Portas)
                        {
                            PortaModel portaHardware = new PortaModel();
                            portaHardware.Funcao = item.Funcao;
                            portaHardware.Porta = item.Porta;
                            portaHardware.Descricao = item.Descricao;
                            portaList.Add(portaHardware);
                        }
                        hardwareModel.Portas = portaList;
                    }
                }
                statusConexaoLb.Text = "Hardware Selecionado.";
                statusConexaoLb.ForeColor = System.Drawing.Color.Green;
                //pnlAcoes.Enabled = true;
                pnlLog.Enabled = true;

            }
            else
            {
                statusConexaoLb.ForeColor = System.Drawing.Color.Red;
                statusConexaoLb.Text = "Não há dispositivo selecionado!";
                pnlAcoes.Enabled = false;
                pnlLog.Enabled = false;
            }
        }

        private void HardwareDisponivelcbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            setHardware();
        }

        private void PnlLog_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            ReceitaDAO receitaDao = new ReceitaDAO();
            ReceitaModel receitaModel = new ReceitaModel();
            RampaModel rampaMosturacao;
            Ingredientes adicaoLupulo;
            List<Ingredientes> adicoesDeLupulagem = new List<Ingredientes>();
            List<RampaModel> rampaMosturacaoList = new List<RampaModel>();

            var consulta = receitaDao.GetReceitaPorNome(receitaCb.SelectedText);
            if (consulta != null)
            {
                foreach (var _receita in consulta)
                {
                    receitaModel.Nome = _receita.Nome;
                    receitaModel.DuracaoFervura = _receita.DuracaoFervura;
                    receitaModel.Litragem = _receita.Litragem;
                    receitaModel.Versao = _receita.Versao;
                    receitaModel.VolPreFervura = _receita.VolPreFervura;
                    receitaModel.VolPosFervura = _receita.VolPosFervura;
                    receitaModel.ABV = _receita.ABV;
                    receitaModel.Cor = _receita.Cor;
                    receitaModel.Notas = _receita.Notas;
                    if (_receita.Rampas != null)
                    {
                        _receita.Rampas.Sort();
                        foreach (var item in _receita.Rampas)
                        {
                            rampaMosturacao = new RampaModel();
                            rampaMosturacao.Descricao = item.Descricao;
                            rampaMosturacao.Duracao = item.Duracao;
                            rampaMosturacao.Temperatura = item.Temperatura;
                            rampaMosturacaoList.Add(rampaMosturacao);
                        }
                    }
                    if (_receita.Ingredientes != null)
                    {
                        foreach (var item in _receita.Ingredientes)
                        {
                            if (item.Tipo == "")
                            {
                                adicaoLupulo = new Ingredientes();
                                adicaoLupulo.Quantidade = item.Quantidade;
                                adicaoLupulo.Unidade = item.Unidade;
                                //adicaoLupulo.Tempo
                                adicoesDeLupulagem.Add(adicaoLupulo);
                            }
                        }
                    }

                    //Carregar àgua
                    while (true)
                    {

                    }
                    //Processo de Rampas de temperatura
                    foreach (var item in _receita.Rampas)
                    {
                        while (true)//Controlar via rampas diretamente
                        {

                        }
                    }
                    /*
                     Após mostura implementar lavagem do malte
                     */

                    //Fervura e adição de lupulos
                    foreach (var item in _receita.Rampas)
                    {
                        while (true)//Usar variável: DuracaoFervura controle de tempo
                        {

                        }
                    }

                    /*
                     Após fervura implementar chamado para Whirlpool
                     Solicitar acionamento para Chiller
                     */

                    // Executar procedimento chiller


                    // Aviso termino do processo, solicitar limpeza de equipamento.
                }

                pnlAcoes.Enabled = true;
                pnlLog.Enabled = true;
            }
            else
            {
                //Mensagem de erro:
                //Não foi possível recuperar a receita.
                //Verifique conexão com banco de dados!
                //Caso erro persistir contacte o administrador e, ou programador.
            }

        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            if (temporizador.Enabled == false)
            {
                temporizadorContador = 0;
                temporizador.Interval = 1000;
                temporizador.Enabled = true;
                temporizador.Start();
            }

            if (temporizadorContador >= 10)
            {
                temporizador.Stop();
                temporizador.Dispose();
            }
        }

        private void Temporizador_Tick(object sender, EventArgs e)
        {
            temporizadorContador += 1;
        }
    }
}

