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
    public partial class Receita : Form
    {
        public Receita()
        {
            InitializeComponent();
            AtualizaLBPProgresbarEstilo();
        }

        LupuloModel lupuloSelecionado = new LupuloModel();
        ReceitaModel receita = new ReceitaModel();
        Ingredientes ingrediente;
        RampaModel rampa;
        RampaModel etapaFermentacao;
        ConversaoFuncoes converteUnidades;
        private Mensagem ms = new Mensagem();

        IEnumerable<MalteModel> malteCollection;
        IEnumerable<LupuloModel> lupuloCollection;
        IEnumerable<LeveduraModel> leveduraCollection;
        IEnumerable<CervejeiroModel> cervejeiroCollection;
        IEnumerable<AdjuntoModel> adjuntoCollection;
        IEnumerable<EstiloModel> estiloCollection;
        List<MalteModel> malteModelList;
        List<LupuloModel> lupuloModelList;
        List<LeveduraModel> leveduraModelList;
        List<CervejeiroModel> cervejeiroModelList;
        List<AdjuntoModel> adjuntoModelList;
        List<EstiloModel> estiloModelList;


        private void PopularListaModels()
        {

            //MalteDAO malteDAO = new MalteDAO();
            // malteCollection = malteDAO.GetTodosMalte();

            // LupuloDAO lupuloDAO = new LupuloDAO();
            // lupuloCollection = lupuloDAO.GetTodosLupulos();

            //LeveduraDAO leveduraDAO = new LeveduraDAO();
            //leveduraCollection = leveduraDAO.GetTodosLeveduras();


            EstiloDAO estiloDAO = new EstiloDAO();
            estiloCollection = estiloDAO.GetTodosEstilos();
            foreach (var _estilo in estiloCollection)
            {
                estilotbx.Items.Add(_estilo.Nome);
            }

            CervejeiroDAO cervejeiroDAO = new CervejeiroDAO();
            cervejeiroCollection = cervejeiroDAO.GetTodosCervejeiros();
            foreach (var _cervejeiroModelList in cervejeiroCollection)
            {
                cervejeirotbx.Items.Add(_cervejeiroModelList.Nome);
            }
        }

        private void LimpaCampos()
        {
            nometbx.Text = "";
            tempoFervuratbx.Text = "";
            litragemtbx.Text = "";
            versaotbx.Text = "";
            volumePreFervuratbx.Text = "";
            volumePosFervuratbx.Text = "";
            estimativaABVtbx.Text = "";
            estimativaCORtbx.Text = "";
            estimativaFGtbx.Text = "";
            estimativaIBUtbx.Text = "";
            estimativaOGtbx.Text = "";
            realABVtbx.Text = "";
            realCORtbx.Text = "";
            realFGtbx.Text = "";
            realIBUtbx.Text = "";
            realOGtbx.Text = "";
            notastbx.Text = "";
            cervejeirotbx.SelectedIndex = -1;
            tipotbx.SelectedIndex = -1;
            estilotbx.SelectedIndex = -1;
            pesquisatbx.Text = "";
            celulasNecessariastbx.Text = "";
            volumeAtivacaotbx.Text = "";
            //volumeRecomendadotbx.Text = "";
            recomendacaotbx.Text = "";

            gvIngredientes.Rows.Clear();
            gvRampa.Rows.Clear();
            gvFermentacao.Rows.Clear();

        }

        private void sairbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tab1_Click(object sender, EventArgs e)
        {

        }

        private void Receita_Load(object sender, EventArgs e)
        {
            PopularListaModels();
            getReceitas();
        }

        private void Lupulotbn_Click(object sender, EventArgs e)
        {
            ingrediente = new Ingredientes();
            Lupulo lupulo = new Lupulo(false, ingrediente);
            lupulo.ShowDialog();
            PopulaGridIngredientes(ingrediente);
        }
        private void Maltebtn_Click(object sender, EventArgs e)
        {
            ingrediente = new Ingredientes();
            Malte malte = new Malte(false, ingrediente);
            malte.ShowDialog();
            PopulaGridIngredientes(ingrediente);
        }

        private void Leveduratbn_Click(object sender, EventArgs e)
        {
            ingrediente = new Ingredientes();
            Levedura levedura = new Levedura(false, ingrediente);
            levedura.ShowDialog();
            PopulaGridIngredientes(ingrediente);
        }

        private void Adjuntotbn_Click(object sender, EventArgs e)
        {
            ingrediente = new Ingredientes();
            Adjunto adjunto = new Adjunto(false, ingrediente);
            adjunto.ShowDialog();
            PopulaGridIngredientes(ingrediente);
        }

        private void PopulaGridIngredientes(Ingredientes _ingrediente)
        {
            if (_ingrediente.Descricao != "")
            {
                DataGridViewRow gvIgredienteSelecionado = (DataGridViewRow)gvIngredientes.Rows[0].Clone();

                gvIgredienteSelecionado.Cells[0].Value = gerarOrdenacaoGrid(gvIngredientes);
                gvIgredienteSelecionado.Cells[1].Value = _ingrediente.Quantidade;
                gvIgredienteSelecionado.Cells[2].Value = _ingrediente.Unidade;
                gvIgredienteSelecionado.Cells[3].Value = _ingrediente.Descricao;
                gvIgredienteSelecionado.Cells[5].Value = _ingrediente.Marca;
                gvIgredienteSelecionado.Cells[6].Value = _ingrediente.Tipo;
                gvIgredienteSelecionado.Cells[7].Value = _ingrediente.PercentualIBU;
                gvIgredienteSelecionado.Cells[8].Value = _ingrediente.Volume;
                gvIgredienteSelecionado.Cells[9].Value = _ingrediente.Custo;
                gvIgredienteSelecionado.Cells[10].Value = _ingrediente.TipoDoIngrediente;
                gvIngredientes.Rows.Add(gvIgredienteSelecionado);
            }
        }

        private ReceitaModel setReceita()
        {
            NunConvFuncao nunFuncao = new NunConvFuncao();
            if (receita.id == null)
            {
                receita = new ReceitaModel();
            }

            if (gvIngredientes.Rows != null)
            {
                List<Ingredientes> ingredientesList = new List<Ingredientes>();
                foreach (DataGridViewRow row in gvIngredientes.Rows)
                {
                    if (row.Cells["Descricao"].Value != null)
                    {
                        ingrediente = new Ingredientes();
                        ingrediente.Ordem = Convert.ToInt32(nunFuncao.Converter(row.Cells["Ordem"].Value));
                        ingrediente.Quantidade = Convert.ToInt32(nunFuncao.Converter(row.Cells["Quantidade"].Value));
                        ingrediente.Descricao = Convert.ToString(nunFuncao.Converter(row.Cells["Descricao"].Value));
                        ingrediente.TempoAdicao = Convert.ToString(row.Cells["TempoAdicao"].Value);
                        ingrediente.Tipo = Convert.ToString(row.Cells["Tipo"].Value);
                        //ingrediente.PercentualIBU = Convert.ToDouble(row.Cells["IBU"].Value);
                        ingrediente.PercentualIBU = Convert.ToDouble(nunFuncao.Converter(row.Cells["IBU"].Value));
                        ingrediente.Volume = Convert.ToDouble(nunFuncao.Converter(row.Cells["Volume"].Value));
                        ingrediente.Custo = Convert.ToDouble(nunFuncao.Converter(row.Cells["Custo"].Value));
                        ingrediente.TipoDoIngrediente = Convert.ToString(row.Cells["TipoDoIngrediente"].Value);
                        ingredientesList.Add(ingrediente);
                    }
                }
                if (ingredientesList != null)
                {
                    receita.Ingredientes = ingredientesList;
                }
            }

            if (gvRampa.Rows != null)
            {
                List<RampaModel> rampaList = new List<RampaModel>();
                foreach (DataGridViewRow row in gvRampa.Rows)
                {
                    if (row.Cells["RDescricao"].Value != null)
                    {
                        rampa = new RampaModel();
                        rampa.Descricao = Convert.ToString(row.Cells["RDescricao"].Value);
                        rampa.Temperatura = Convert.ToDouble(nunFuncao.Converter(row.Cells["RTemperatura"].Value));
                        rampa.Duracao = Convert.ToString(row.Cells["RDuracao"].Value);
                        rampaList.Add(rampa);
                    }
                }
                if (rampaList != null)
                {
                    receita.Rampas = rampaList;
                }
            }

            if (gvFermentacao.Rows != null)
            {
                List<RampaModel> fermentacaoList = new List<RampaModel>();
                foreach (DataGridViewRow row in gvFermentacao.Rows)
                {
                    if (row.Cells["FDescricao"].Value != null)
                    {
                        etapaFermentacao = new RampaModel();
                        etapaFermentacao.Descricao = Convert.ToString(row.Cells["FDescricao"].Value);
                        etapaFermentacao.Temperatura = Convert.ToDouble(nunFuncao.Converter(row.Cells["FTemperatura"].Value));
                        etapaFermentacao.Duracao = Convert.ToString(row.Cells["FDuracao"].Value);
                        fermentacaoList.Add(etapaFermentacao);
                    }
                }
                if (fermentacaoList != null)
                {
                    receita.Fermentacao = fermentacaoList;
                }
            }

            receita.Nome = nometbx.Text;
            //receita.Cervejeiro = cervejeirotbx.SelectedIndex
            receita.Tipo = tipotbx.Text;
            //receita.Estilo = estilotbx.Text;
            receita.Litragem = Convert.ToDouble(nunFuncao.Converter(litragemtbx.Text));
            receita.Versao = Convert.ToDouble(nunFuncao.Converter(versaotbx.Text));
            receita.Data = Convert.ToDateTime(databx.Text);
            receita.VolPreFervura = Convert.ToDouble(nunFuncao.Converter(volumePosFervuratbx.Text));
            receita.VolPosFervura = Convert.ToDouble(nunFuncao.Converter(volumePosFervuratbx.Text));
            //receita.Cor = Convert.ToDouble(estimativaCORtbx.Text);
            receita.ABV = Convert.ToDouble(nunFuncao.Converter(realABVtbx.Text));
            receita.Notas = notastbx.Text;
            //receita.Eficiencia 
            receita.DuracaoFervura = tempoFervuratbx.Text;
            receita.OGBrix = Convert.ToDouble(nunFuncao.Converter(realOGtbx.Text));
            receita.FGBrix = Convert.ToDouble(nunFuncao.Converter(realFGtbx.Text));
            receita.CelulasNecessarias = Convert.ToDouble(nunFuncao.Converter(celulasNecessariastbx.Text));
            receita.VolumeAtivacao = Convert.ToDouble(nunFuncao.Converter(volumeAtivacaotbx.Text));
            //receita.VolumeRecomendado = Convert.ToDouble(nunFuncao.Converter(volumeRecomendadotbx.Text));
            receita.RecomendacaoGramas = Convert.ToDouble(nunFuncao.Converter(recomendacaotbx.Text));

            return receita;
        }

        private void Salva_Click(object sender, EventArgs e)
        {
            if (nometbx.Text != null)
            {
                receita = setReceita();
                if (receita != null)
                {
                    ReceitaDAO dao = new ReceitaDAO();
                    dao.CriarReceita(receita);
                }
                else
                {
                    ms.camposNaoPreenchidos();
                }
            }
            else
            {
                ms.camposNaoPreenchidos();
            }
        }

        private void PopulaGridRampa(RampaModel _rampa)
        {
            DataGridViewRow gvRampaSelecionada = (DataGridViewRow)gvRampa.Rows[0].Clone();
            gvRampaSelecionada.Cells[0].Value = _rampa.Descricao;
            gvRampaSelecionada.Cells[1].Value = _rampa.Temperatura;
            gvRampaSelecionada.Cells[2].Value = _rampa.Duracao;
            gvIngredientes.Rows.Add(gvRampaSelecionada);
        }

        private void PopulaGridFermentacao(RampaModel _etapaFermentacao)
        {
            DataGridViewRow gvEtapaFermentacao = (DataGridViewRow)gvFermentacao.Rows[0].Clone();
            gvEtapaFermentacao.Cells[0].Value = _etapaFermentacao.Descricao;
            gvEtapaFermentacao.Cells[1].Value = _etapaFermentacao.Temperatura;
            gvEtapaFermentacao.Cells[2].Value = _etapaFermentacao.Duracao;
            gvIngredientes.Rows.Add(gvEtapaFermentacao);
        }

        private void Pesquisabtn_Click(object sender, EventArgs e)
        {
            getReceitas();
        }
        private void getReceitas()
        {
            lvReceita.Items.Clear();
            ReceitaDAO dao = new ReceitaDAO();
            var consulta = dao.GetTodasReceitas();

            lvReceita.GridLines = true;
            lvReceita.FullRowSelect = true;
            lvReceita.Columns.Add("Receita", 480);
            lvReceita.Columns.Add("Cervejeiro", 320);

            foreach (var _receita in consulta)
            {
                string[] arr = new string[2];
                ListViewItem itm;
                arr[0] = _receita.Nome;
                arr[1] = Convert.ToString(_receita.Versao);
                itm = new ListViewItem(arr);
                lvReceita.Items.Add(itm);
            }
        }


        private void Aguatbn_Click(object sender, EventArgs e)
        {

        }

        private void LvReceita_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            String nomeReceita = "";
            foreach (ListViewItem item in lvReceita.SelectedItems)
            {
                nomeReceita = item.Text;
            }
            ReceitaDAO dao = new ReceitaDAO();
            var consulta = dao.GetReceitaPorNome(nomeReceita);
            foreach (var _receita in consulta)
            {
                receita.id = _receita.id;


                nometbx.Text = _receita.Nome;
                tempoFervuratbx.Text = Convert.ToString(_receita.DuracaoFervura);
                litragemtbx.Text = Convert.ToString(_receita.Litragem);
                versaotbx.Text = Convert.ToString(_receita.Versao);
                volumePreFervuratbx.Text = Convert.ToString(_receita.VolPreFervura);
                volumePosFervuratbx.Text = Convert.ToString(_receita.VolPosFervura);
                realABVtbx.Text = Convert.ToString(_receita.ABV);
                realCORtbx.Text = Convert.ToString(_receita.Cor);
                notastbx.Text = _receita.Notas;

                gvIngredientes.Rows.Clear();

                if (_receita.Ingredientes != null)
                {
                    foreach (var ingrediente in _receita.Ingredientes)
                    {
                        PopulaGridIngredientes(ingrediente);
                    }
                }
                if (_receita.Rampas != null)
                {
                    foreach (var rampa in _receita.Rampas)
                    {
                        PopulaGridRampa(rampa);
                    }
                }
                if (_receita.Fermentacao != null)
                {
                    foreach (var fermentacao in _receita.Fermentacao)
                    {
                        PopulaGridFermentacao(fermentacao);
                    }
                }
                tabControl.SelectedTab = parametroTab;
            }
        }
        private int gerarOrdenacaoGrid(DataGridView _grid)
        {
            return Convert.ToInt16(_grid.Rows.Count.ToString());
        }

        private void calcularParametros()
        {
            if (nometbx.Text == "" || litragemtbx.Text == "0" ||
                volumePreFervuratbx.Text == "0" || volumePosFervuratbx.Text == "0" || realOGtbx.Text == "0")
            {
                ms.camposNaoPreenchidos();
            }
            else
            {
                ConversaoFuncoes converteUnidades = new ConversaoFuncoes();
                Double totalMalte = 0.0; //Total Mate(base seca)
                                         //Double quantidadeMalte = 0.0; //Quantidade de malte utilizado
                Double potencialMedio = 0.0; //Potencial Médio
                Double teorSolidoSoluvel = 0.0; //Teor de sólidos solúveis
                                                //Double agua = 0.0;
                Double concentracaoFinalIdealKgSS = 0.0; //Concentração Final Ideal
                Double concentracaoFinalIdeal = 0.0; //Concentração Final Ideal
                Double ogEsperado = 0.0; //OG esperado
                Double ogReal = 0.0; //OG real
                                     //Double volumeFinal = 0.0; //Volume final
                Double rendimentoMalte = 0.0; //Rendimento Malte
                Double rendimentoLitros = 0.0; //Rendimento Litros
                Double rendimentoTotal = 0.0; //Rendimento total
                string tipoMalte = "";
                string nomeMalte = "";

                NunConvFuncao nunFuncao = new NunConvFuncao();


                //***********************************************************************************************************
                // Inicio percorrer listagem de ingredientes e realizar calculos de insumos
                //***********************************************************************************************************

                if (gvIngredientes.Rows != null)
                {
                    ingrediente = new Ingredientes();

                    foreach (DataGridViewRow row in gvIngredientes.Rows)
                    {
                        if (row.Cells["Descricao"].Value != null)
                        {
                            string insumo = Convert.ToString(row.Cells["TipoDoIngrediente"].Value);
                            String nomeInsumo = Convert.ToString(nunFuncao.Converter(row.Cells["Descricao"].Value));
                            //***********************************************************************************************************
                            // Calculo rendimentos Malte
                            //***********************************************************************************************************
                            if (insumo == "Malte")
                            {
                                totalMalte += Convert.ToDouble(row.Cells["Quantidade"].Value);
                                MalteDAO dao = new MalteDAO();
                                MalteFuncoes funcao = new MalteFuncoes();

                                malteCollection = null;
                                malteCollection = dao.GetMaltesPorNome(nomeInsumo);

                                foreach (var _malte in malteCollection)
                                {
                                    potencialMedio += (_malte.Aproveitamento * 0.01) * totalMalte;
                                }
                                potencialMedio = potencialMedio / totalMalte;
                                totalMalte = totalMalte * 0.96; // Retira 4% do valor total
                                teorSolidoSoluvel = potencialMedio * totalMalte;
                                concentracaoFinalIdealKgSS = (potencialMedio * totalMalte) / Convert.ToDouble(litragemtbx.Text);
                                concentracaoFinalIdeal = concentracaoFinalIdealKgSS * 100;
                                ogEsperado = (1000 + concentracaoFinalIdeal * 4) / 1000;

                                estimativaOGtbx.Text = Convert.ToString(converteUnidades.GravityParaBrix(ogEsperado));

                                rendimentoMalte = (1 - converteUnidades.BrixParaGravity(Convert.ToDouble(realOGtbx.Text))) / (1 - ogEsperado);
                                eficienciaMalteTxt.Text = Convert.ToString(rendimentoMalte * 100);

                                rendimentoLitros = Convert.ToDouble(volumePosFervuratbx.Text) / Convert.ToDouble(litragemtbx.Text);
                                eficienciaVolumeTxt.Text = Convert.ToString(rendimentoLitros * 100);

                                rendimentoTotal = rendimentoLitros * rendimentoMalte;
                                eficienciaTotalTxt.Text = Convert.ToString(rendimentoTotal * 100);
                            }
                            //***********************************************************************************************************
                            // Calculo IBU
                            //***********************************************************************************************************
                            else if (insumo == "Lupulo")
                            {
                                LupuloDAO lupuloDao = new LupuloDAO();
                                lupuloCollection = null;
                                lupuloCollection = lupuloDao.GetLupulosPorNome(nomeInsumo);
                                CalculoIBU calcIBU = new CalculoIBU();
                                foreach (var _lupulo in lupuloCollection)
                                {
                                    estimativaIBUtbx.Text = Convert.ToString(
                                       calcIBU.CalculaIBU(
                                           Convert.ToDouble(row.Cells["Quantidade"].Value),
                                           calcIBU.Utilizacao(Convert.ToString(row.Cells["TempoAdicao"].Value), _lupulo.Forma),
                                           (_lupulo.AcidoAlfa / 100),
                                           Convert.ToDouble(volumePreFervuratbx.Text),
                                           calcIBU.DencidadeCorrigida(Convert.ToDouble(realOGtbx.Text)))).Substring(0, 5);
                                }
                            }
                            //***********************************************************************************************************
                            // Calculo Adjunto
                            //***********************************************************************************************************
                            else if (insumo == "Adjunto")
                            { }
                            //***********************************************************************************************************
                            // Calculo Ação e viabilização na recomendação de leveduras e atenuação de dencidade final
                            //***********************************************************************************************************
                            else if (insumo == "Levedura")
                            {

                                LeveduraDAO leveduraoDao = new LeveduraDAO();
                                leveduraCollection = null;
                                leveduraCollection = leveduraoDao.GetLevedurasPorNome(nomeInsumo);
                                //CalculoIBU calcIBU = new CalculoIBU();
                                foreach (var _levedurao in leveduraCollection)
                                {
                                    Double celulasNecessarias =
                                       ((Convert.ToDouble(pitchRateLb.Text) * 1000000)
                                       *
                                       ((Convert.ToDouble(volumePosFervuratbx.Text) * 1000) * Convert.ToDouble(realOGtbx.Text))
                                       / 1000000000);

                                    celulasNecessariastbx.Text = Convert.ToString(celulasNecessarias).Substring(0,4);

                                    Double recomendacao = celulasNecessarias / (_levedurao.CelulasPacote / (_levedurao.Viabilidade / 100));

                                    recomendacaotbx.Text = Convert.ToString(recomendacao).Substring(0,3);

                                    leveduraPacotesNecessariosTxt.Text = Convert.ToString(recomendacao / _levedurao.GramasPacote).Substring(0, 2);

                                    volumeAtivacaotbx.Text = Convert.ToString(recomendacao * 0.4).Substring(0,3);

                                }


                            }
                        }
                    }
                }

                //***********************************************************************************************************
                //***************Final percorrer listagem de ingredientes e realizar calculos de insumos*********************
                //***********************************************************************************************************

                //***********************************************************************************************************
                // Calculo teor de alcool
                //***********************************************************************************************************
                CalculoSimples calculoSimples = new CalculoSimples();
                realABVtbx.Text = Convert.ToString(calculoSimples.abv(Convert.ToDouble(realOGtbx.Text), Convert.ToDouble(realFGtbx.Text)));
                estimativaABVtbx.Text = Convert.ToString(calculoSimples.abv(Convert.ToDouble(estimativaOGtbx.Text), Convert.ToDouble(estimativaFGtbx.Text)));













            }
        }

        private void GvIngredientes_EditModeChanged(object sender, EventArgs e)
        {
            //calcularParametros();
        }

        private void GvIngredientes_RegionChanged(object sender, EventArgs e)
        {
            // calcularParametros();
        }

        private void AtualizarCalculosTxt_Click(object sender, EventArgs e)
        {
            calcularParametros();
            AtualizaLBPProgresbarEstilo();
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }
        private void IniciarProgresbarEstilo()
        {/*
            ibuMinimoPgb.SetState(3);
            ibuRealPgb.SetState(1);
            ibuMaximoPgb.SetState(2);

            abvMinimoPgb.SetState(3);
            abvRealPgb.SetState(1);
            abvMaximoPgb.SetState(2);

            corEBCMinimoPgb.SetState(3);
            corEBCRealPgb.SetState(1);
            corEBCMaximoPgb.SetState(2);
            AtualizaLBPProgresbarEstilo();*/
        }
        private void AtualizaLBPProgresbarEstilo()
        {
            // Caso estiver com o valor real utilizar o valor estimado
            // Receita pode ainda não ter executado uma única vez e ser 
            // apenas para testes de elaboração e correção.
            if (realIBUtbx.Text == "" || realIBUtbx.Text == " ")
            {
                realIBUtbx.Text = estimativaIBUtbx.Text;
            }

            if (realABVtbx.Text == "" || realABVtbx.Text == " ")
            {
                realABVtbx.Text = estimativaABVtbx.Text;
            }

            if (realCORtbx.Text == "" || realCORtbx.Text == " ")
            {
                realCORtbx.Text = estimativaCORtbx.Text;
            }
            //Preenche parametros com base no estilo
            EstiloDAO dao = new EstiloDAO();
            EstiloFuncoes funcao = new EstiloFuncoes();
            estiloCollection = null;
            estiloCollection = dao.GetEstilosPorNome(estilotbx.Text);
            foreach (var _estilo in estiloCollection)
            {
                ibuMaximoPgb.Value = Convert.ToInt32(_estilo.IBUMax);
                ibuMinimoPgb.Value = Convert.ToInt32(_estilo.IBUMin);

                abvMaximoPgb.Value = Convert.ToInt32(_estilo.ABVMax);
                abvMinimoPgb.Value = Convert.ToInt32(_estilo.ABVMin);

                corEBCMaximoPgb.Value = Convert.ToInt32(_estilo.CORMax);
                corEBCMinimoPgb.Value = Convert.ToInt32(_estilo.CORMin);

                // atualiza legendas de texto para simplificar o usuário.
                ibuMinimoLb.Text = Convert.ToString(_estilo.IBUMin);
                ibuMaximoLb.Text = Convert.ToString(_estilo.IBUMax);
                abvMinimoLb.Text = Convert.ToString(_estilo.ABVMin);
                abvMaximoLb.Text = Convert.ToString(_estilo.ABVMax);
                corEBCMinimoLb.Text = Convert.ToString(_estilo.CORMin);
                corEBCMaximoLb.Text = Convert.ToString(_estilo.CORMax);

                familiaLeveduraLb.Visible = true;
                familiaLeveduraLb.Text = _estilo.Perfil;

                if (_estilo.Perfil == "Lager")
                {
                    taxaPithMTcB.Maximum = 150;
                    taxaPithMTcB.Minimum = 100;
                }
                else
                {
                    taxaPithMTcB.Maximum = 75;
                    taxaPithMTcB.Minimum = 50;
                }
                taxaPithMTcB.Value = taxaPithMTcB.Minimum;
                pitchRateLb.Text = Convert.ToString(Convert.ToDouble(taxaPithMTcB.Value / 100)).Substring(0, 3);
                calculosLeveduraGPL.Enabled = true;
            }

            //Preenche valores reais
            ibuRealPgb.Value = Convert.ToInt32(Convert.ToDouble(realIBUtbx.Text));
            abvRealPgb.Value = Convert.ToInt32(Convert.ToDouble(realABVtbx.Text));
            corEBCRealPgb.Value = Convert.ToInt32(Convert.ToDouble(realCORtbx.Text));

            // atualiza legendas de texto para simplificar o usuário.
            ibuRealLb.Text = Convert.ToString(ibuRealPgb.Value);
            abvRealLb.Text = Convert.ToString(abvRealPgb.Value);
            corEBCRealLb.Text = Convert.ToString(corEBCRealPgb.Value);
        }

        private void Estilotbx_DropDownClosed(object sender, EventArgs e)
        {
            AtualizaLBPProgresbarEstilo();

        }

        private void TaxaPithMTcB_ValueChanged(object sender, EventArgs e)
        {
            pitchRateLb.Text = Convert.ToString(Convert.ToDouble(taxaPithMTcB.Value / 100)).Substring(0, 3);
        }

        private void label69_Click(object sender, EventArgs e)
        {

        }
    }
}
