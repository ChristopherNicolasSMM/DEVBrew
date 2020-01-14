namespace Brew.View
{
    partial class ConexaoHardware
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConexaoHardware));
            this.panel3 = new System.Windows.Forms.Panel();
            this.salva = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.sairbtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gvPortas = new System.Windows.Forms.DataGridView();
            this.Funcao = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Porta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusCbx = new System.Windows.Forms.CheckBox();
            this.DDNSTbx = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.gatewayTbx = new System.Windows.Forms.MaskedTextBox();
            this.mascaraTbx = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dispositivoTbx = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ipTbx = new System.Windows.Forms.MaskedTextBox();
            this.lvDispositivos = new System.Windows.Forms.ListView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvPortas)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkTurquoise;
            this.panel3.Controls.Add(this.salva);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.sairbtn);
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(642, 38);
            this.panel3.TabIndex = 16;
            // 
            // salva
            // 
            this.salva.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("salva.BackgroundImage")));
            this.salva.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.salva.Location = new System.Drawing.Point(519, -1);
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
            this.label6.Location = new System.Drawing.Point(181, 7);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(233, 24);
            this.label6.TabIndex = 4;
            this.label6.Text = "Conexão com hardware";
            // 
            // sairbtn
            // 
            this.sairbtn.BackgroundImage = global::Brew.Properties.Resources.btSai;
            this.sairbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.sairbtn.Location = new System.Drawing.Point(580, -1);
            this.sairbtn.Name = "sairbtn";
            this.sairbtn.Size = new System.Drawing.Size(53, 40);
            this.sairbtn.TabIndex = 3;
            this.sairbtn.UseVisualStyleBackColor = true;
            this.sairbtn.Click += new System.EventHandler(this.Sairbtn_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gvPortas);
            this.panel1.Controls.Add(this.statusCbx);
            this.panel1.Controls.Add(this.DDNSTbx);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.gatewayTbx);
            this.panel1.Controls.Add(this.mascaraTbx);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.dispositivoTbx);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.ipTbx);
            this.panel1.Location = new System.Drawing.Point(12, 55);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(354, 383);
            this.panel1.TabIndex = 18;
            // 
            // gvPortas
            // 
            this.gvPortas.AllowUserToOrderColumns = true;
            this.gvPortas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvPortas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Funcao,
            this.Porta,
            this.Descricao});
            this.gvPortas.Location = new System.Drawing.Point(28, 182);
            this.gvPortas.Name = "gvPortas";
            this.gvPortas.Size = new System.Drawing.Size(296, 189);
            this.gvPortas.TabIndex = 12;
            this.gvPortas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GvPortas_CellContentClick);
            // 
            // Funcao
            // 
            this.Funcao.HeaderText = "Função";
            this.Funcao.Items.AddRange(new object[] {
            "Analogica",
            "Digital"});
            this.Funcao.Name = "Funcao";
            this.Funcao.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Funcao.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Funcao.Width = 60;
            // 
            // Porta
            // 
            this.Porta.HeaderText = "Pt.";
            this.Porta.Name = "Porta";
            this.Porta.Width = 30;
            // 
            // Descricao
            // 
            this.Descricao.HeaderText = "Descrição";
            this.Descricao.Name = "Descricao";
            this.Descricao.Width = 250;
            // 
            // statusCbx
            // 
            this.statusCbx.AutoSize = true;
            this.statusCbx.Location = new System.Drawing.Point(28, 159);
            this.statusCbx.Name = "statusCbx";
            this.statusCbx.Size = new System.Drawing.Size(50, 17);
            this.statusCbx.TabIndex = 11;
            this.statusCbx.Text = "Ativo";
            this.statusCbx.UseVisualStyleBackColor = true;
            // 
            // DDNSTbx
            // 
            this.DDNSTbx.Location = new System.Drawing.Point(185, 130);
            this.DDNSTbx.Mask = "999.999.999.999";
            this.DDNSTbx.Name = "DDNSTbx";
            this.DDNSTbx.Size = new System.Drawing.Size(140, 20);
            this.DDNSTbx.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(182, 114);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "DDNS";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(182, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Gateway";
            // 
            // gatewayTbx
            // 
            this.gatewayTbx.Location = new System.Drawing.Point(185, 82);
            this.gatewayTbx.Mask = "999.999.999.999";
            this.gatewayTbx.Name = "gatewayTbx";
            this.gatewayTbx.Size = new System.Drawing.Size(140, 20);
            this.gatewayTbx.TabIndex = 7;
            // 
            // mascaraTbx
            // 
            this.mascaraTbx.Location = new System.Drawing.Point(28, 130);
            this.mascaraTbx.Mask = "999.999.999.999";
            this.mascaraTbx.Name = "mascaraTbx";
            this.mascaraTbx.Size = new System.Drawing.Size(140, 20);
            this.mascaraTbx.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Nome do dispositivo";
            // 
            // dispositivoTbx
            // 
            this.dispositivoTbx.Location = new System.Drawing.Point(28, 34);
            this.dispositivoTbx.Name = "dispositivoTbx";
            this.dispositivoTbx.Size = new System.Drawing.Size(297, 20);
            this.dispositivoTbx.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Mascara de rede";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "IP";
            // 
            // ipTbx
            // 
            this.ipTbx.Location = new System.Drawing.Point(28, 82);
            this.ipTbx.Mask = "999.999.999.999";
            this.ipTbx.Name = "ipTbx";
            this.ipTbx.Size = new System.Drawing.Size(140, 20);
            this.ipTbx.TabIndex = 0;
            // 
            // lvDispositivos
            // 
            this.lvDispositivos.Location = new System.Drawing.Point(9, 34);
            this.lvDispositivos.Name = "lvDispositivos";
            this.lvDispositivos.Size = new System.Drawing.Size(221, 338);
            this.lvDispositivos.TabIndex = 19;
            this.lvDispositivos.UseCompatibleStateImageBehavior = false;
            this.lvDispositivos.SelectedIndexChanged += new System.EventHandler(this.LvDispositivos_SelectedIndexChanged);
            this.lvDispositivos.Click += new System.EventHandler(this.LvDispositivos_Click);
            this.lvDispositivos.DoubleClick += new System.EventHandler(this.LvDispositivos_DoubleClick);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.lvDispositivos);
            this.panel2.Location = new System.Drawing.Point(379, 56);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(240, 382);
            this.panel2.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Dispositivos cadastrados";
            // 
            // ConexaoHardware
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ConexaoHardware";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ConexaoHardware";
            this.Load += new System.EventHandler(this.ConexaoHardware_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvPortas)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button salva;
        private System.Windows.Forms.Button sairbtn;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MaskedTextBox ipTbx;
        private System.Windows.Forms.ListView lvDispositivos;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox dispositivoTbx;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox DDNSTbx;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox gatewayTbx;
        private System.Windows.Forms.MaskedTextBox mascaraTbx;
        private System.Windows.Forms.CheckBox statusCbx;
        private System.Windows.Forms.DataGridView gvPortas;
        private System.Windows.Forms.DataGridViewComboBoxColumn Funcao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Porta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descricao;
    }
}