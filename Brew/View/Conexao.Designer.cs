namespace Brew.View
{
    partial class Conexao
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Conexao));
            this.panel3 = new System.Windows.Forms.Panel();
            this.salva = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.sairbtn = new System.Windows.Forms.Button();
            this.textBoxEnviar = new System.Windows.Forms.TextBox();
            this.btEnviar = new System.Windows.Forms.Button();
            this.btConectar = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBoxReceber = new System.Windows.Forms.TextBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.timerCOM = new System.Windows.Forms.Timer(this.components);
            this.lbStatus = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DimGray;
            this.panel3.Controls.Add(this.salva);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.sairbtn);
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(564, 40);
            this.panel3.TabIndex = 16;
            // 
            // salva
            // 
            this.salva.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("salva.BackgroundImage")));
            this.salva.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.salva.Location = new System.Drawing.Point(451, 0);
            this.salva.Name = "salva";
            this.salva.Size = new System.Drawing.Size(48, 40);
            this.salva.TabIndex = 0;
            this.salva.UseVisualStyleBackColor = true;
            this.salva.Click += new System.EventHandler(this.Salva_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label6.Location = new System.Drawing.Point(61, 6);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(347, 24);
            this.label6.TabIndex = 4;
            this.label6.Text = "Estabelecer conexão com hardware";
            // 
            // sairbtn
            // 
            this.sairbtn.BackgroundImage = global::Brew.Properties.Resources.btSai;
            this.sairbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.sairbtn.Location = new System.Drawing.Point(510, 0);
            this.sairbtn.Name = "sairbtn";
            this.sairbtn.Size = new System.Drawing.Size(53, 40);
            this.sairbtn.TabIndex = 3;
            this.sairbtn.UseVisualStyleBackColor = true;
            this.sairbtn.Click += new System.EventHandler(this.Sairbtn_Click);
            // 
            // textBoxEnviar
            // 
            this.textBoxEnviar.Location = new System.Drawing.Point(135, 147);
            this.textBoxEnviar.Name = "textBoxEnviar";
            this.textBoxEnviar.Size = new System.Drawing.Size(224, 20);
            this.textBoxEnviar.TabIndex = 17;
            // 
            // btEnviar
            // 
            this.btEnviar.Location = new System.Drawing.Point(26, 147);
            this.btEnviar.Name = "btEnviar";
            this.btEnviar.Size = new System.Drawing.Size(75, 23);
            this.btEnviar.TabIndex = 18;
            this.btEnviar.Text = "Enviar";
            this.btEnviar.UseVisualStyleBackColor = true;
            this.btEnviar.Click += new System.EventHandler(this.BtEnviar_Click);
            // 
            // btConectar
            // 
            this.btConectar.Location = new System.Drawing.Point(26, 88);
            this.btConectar.Name = "btConectar";
            this.btConectar.Size = new System.Drawing.Size(75, 23);
            this.btConectar.TabIndex = 19;
            this.btConectar.Text = "Conectar";
            this.btConectar.UseVisualStyleBackColor = true;
            this.btConectar.Click += new System.EventHandler(this.BtConectar_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(135, 90);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(190, 21);
            this.comboBox1.TabIndex = 20;
            // 
            // textBoxReceber
            // 
            this.textBoxReceber.Location = new System.Drawing.Point(26, 216);
            this.textBoxReceber.Multiline = true;
            this.textBoxReceber.Name = "textBoxReceber";
            this.textBoxReceber.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxReceber.Size = new System.Drawing.Size(506, 251);
            this.textBoxReceber.TabIndex = 21;
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.SerialPort1_DataReceived);
            // 
            // timerCOM
            // 
            this.timerCOM.Interval = 1000;
            this.timerCOM.Tick += new System.EventHandler(this.timerCOM_Tick);
            // 
            // lbStatus
            // 
            this.lbStatus.AutoSize = true;
            this.lbStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStatus.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbStatus.Location = new System.Drawing.Point(362, 90);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(142, 24);
            this.lbStatus.TabIndex = 22;
            this.lbStatus.Text = "Não Conectado";
            // 
            // Conexao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 491);
            this.Controls.Add(this.lbStatus);
            this.Controls.Add(this.textBoxReceber);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btConectar);
            this.Controls.Add(this.btEnviar);
            this.Controls.Add(this.textBoxEnviar);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Conexao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Conexao";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Conexao_FormClosed);
            this.Load += new System.EventHandler(this.Conexao_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button salva;
        private System.Windows.Forms.Button sairbtn;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxEnviar;
        private System.Windows.Forms.Button btEnviar;
        private System.Windows.Forms.Button btConectar;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBoxReceber;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Timer timerCOM;
        private System.Windows.Forms.Label lbStatus;
    }
}