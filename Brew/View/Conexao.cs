using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports; // necessário para ter acesso as portas 
using Brew.Model;

namespace Brew.View
{
    public partial class Conexao : Form
    {

        string RxString;
        List<PortaModel> portas = new List<PortaModel>();

        public Conexao()
        {
            InitializeComponent();
            timerCOM.Enabled = true;
        }


        private void atualizaListaCOMs()
        {
            int i;
            bool quantDiferente; //flag para sinalizar que a quantidade de portas mudou

            i = 0;
            quantDiferente = false;

            //se a quantidade de portas mudou
            if (comboBox1.Items.Count == SerialPort.GetPortNames().Length)
            {
                foreach (string s in SerialPort.GetPortNames())
                {
                    if (comboBox1.Items[i++].Equals(s) == false)
                    {
                        quantDiferente = true;
                    }
                }
            }
            else
            {
                quantDiferente = true;
            }

            //Se não foi detectado diferença
            if (quantDiferente == false)
            {
                return;                     //retorna
            }

            //limpa comboBox
            comboBox1.Items.Clear();

            //adiciona todas as COM diponíveis na lista
            foreach (string s in SerialPort.GetPortNames())
            {
                comboBox1.Items.Add(s);
            }
            //seleciona a primeira posição da lista
            comboBox1.SelectedIndex = 0;
        }


        private void BtConectar_Click(object sender, EventArgs e)
        {
            textBoxReceber.Text = "";
            if (serialPort1.IsOpen == false)
            {
                try
                {
                    serialPort1.PortName = comboBox1.Items[comboBox1.SelectedIndex].ToString();
                    serialPort1.Open();

                }
                catch
                {
                    return;

                }
                if (serialPort1.IsOpen)
                {
                    btConectar.Text = "Desconectar";
                    comboBox1.Enabled = false;

                }
            }
            else
            {

                try
                {
                    serialPort1.Close();
                    comboBox1.Enabled = true;
                    btConectar.Text = "Conectar";
                }
                catch
                {
                    return;
                }

            }

            if (serialPort1.IsOpen)
            {
                textBoxReceber.Text = "Conexão realizada com sucesso !";
                lbStatus.Text = ("Conectado!");
                lbStatus.ForeColor = System.Drawing.Color.Green;

            }
            else
            {
                textBoxReceber.Text = "Erro de comunicação com o dispositivo !";
                lbStatus.Text = ("Não esta conectado!");
                lbStatus.ForeColor = System.Drawing.Color.Red;
            }
        }

        private void Conexao_Load(object sender, EventArgs e)
        {
            timerCOM.Enabled = true;
        }

        private void timerCOM_Tick(object sender, EventArgs e) => atualizaListaCOMs();

        private void Conexao_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (serialPort1.IsOpen == true)// se porta aberta
            {
                serialPort1.Close(); //fecha a porta
            }
        }

        private void BtEnviar_Click(object sender, EventArgs e)
        {
            textBoxReceber.Text = "";
            if (serialPort1.IsOpen == true)
            {  //porta está aberta
                serialPort1.Write(textBoxEnviar.Text);  //envia o texto presente no textbox Enviar
            }
            else
            {
                textBoxReceber.Text = "Não há coneções abertas !";
            }
        }

        private void trataDadoRecebido(object sender, EventArgs e)
        {
            textBoxReceber.AppendText(RxString);
        }

        private void SerialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            RxString = serialPort1.ReadExisting();              //le o dado disponível na serial
            this.Invoke(new EventHandler(trataDadoRecebido));   //chama outra thread para escrever o dado no text box
        }

        private void Sairbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Salva_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
