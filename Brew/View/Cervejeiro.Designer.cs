namespace Brew
{
    partial class Cervejeiro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cervejeiro));
            this.label1 = new System.Windows.Forms.Label();
            this.nometbx = new System.Windows.Forms.TextBox();
            this.emailtbx = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.senhatbx = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.senha2tbx = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.whatsapptbx = new System.Windows.Forms.MaskedTextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.salva = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.sairbtn = new System.Windows.Forms.Button();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tab1 = new System.Windows.Forms.TabPage();
            this.ilustacao = new System.Windows.Forms.PictureBox();
            this.tab2 = new System.Windows.Forms.TabPage();
            this.lv = new System.Windows.Forms.ListView();
            this.label7 = new System.Windows.Forms.Label();
            this.pesquisatbx = new System.Windows.Forms.TextBox();
            this.pesquisabtn = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.label12 = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tab1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ilustacao)).BeginInit();
            this.tab2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome";
            // 
            // nometbx
            // 
            this.nometbx.Location = new System.Drawing.Point(18, 33);
            this.nometbx.Name = "nometbx";
            this.nometbx.Size = new System.Drawing.Size(257, 20);
            this.nometbx.TabIndex = 2;
            // 
            // emailtbx
            // 
            this.emailtbx.Location = new System.Drawing.Point(18, 80);
            this.emailtbx.Name = "emailtbx";
            this.emailtbx.Size = new System.Drawing.Size(257, 20);
            this.emailtbx.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "E-mail";
            // 
            // senhatbx
            // 
            this.senhatbx.Location = new System.Drawing.Point(18, 137);
            this.senhatbx.Name = "senhatbx";
            this.senhatbx.PasswordChar = '*';
            this.senhatbx.Size = new System.Drawing.Size(257, 20);
            this.senhatbx.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Senha";
            // 
            // senha2tbx
            // 
            this.senha2tbx.Location = new System.Drawing.Point(18, 195);
            this.senha2tbx.Name = "senha2tbx";
            this.senha2tbx.PasswordChar = '*';
            this.senha2tbx.Size = new System.Drawing.Size(257, 20);
            this.senha2tbx.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Repetir a Senha";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 230);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Whatsapp";
            // 
            // whatsapptbx
            // 
            this.whatsapptbx.Location = new System.Drawing.Point(18, 253);
            this.whatsapptbx.Mask = "+99(99)  0  -0000-0000";
            this.whatsapptbx.Name = "whatsapptbx";
            this.whatsapptbx.Size = new System.Drawing.Size(257, 20);
            this.whatsapptbx.TabIndex = 11;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Turquoise;
            this.panel3.Controls.Add(this.salva);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.sairbtn);
            this.panel3.Location = new System.Drawing.Point(-2, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(575, 40);
            this.panel3.TabIndex = 14;
            // 
            // salva
            // 
            this.salva.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("salva.BackgroundImage")));
            this.salva.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.salva.Location = new System.Drawing.Point(418, 0);
            this.salva.Name = "salva";
            this.salva.Size = new System.Drawing.Size(53, 40);
            this.salva.TabIndex = 0;
            this.salva.UseVisualStyleBackColor = true;
            this.salva.Click += new System.EventHandler(this.salva_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(213, 7);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 24);
            this.label6.TabIndex = 4;
            this.label6.Text = " Cervejeiro";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // sairbtn
            // 
            this.sairbtn.BackgroundImage = global::Brew.Properties.Resources.btSai;
            this.sairbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.sairbtn.Location = new System.Drawing.Point(477, 0);
            this.sairbtn.Name = "sairbtn";
            this.sairbtn.Size = new System.Drawing.Size(53, 40);
            this.sairbtn.TabIndex = 3;
            this.sairbtn.UseVisualStyleBackColor = true;
            this.sairbtn.Click += new System.EventHandler(this.sairbtn_Click);
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tab1);
            this.tabControl.Controls.Add(this.tab2);
            this.tabControl.Location = new System.Drawing.Point(7, 46);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(509, 324);
            this.tabControl.TabIndex = 15;
            // 
            // tab1
            // 
            this.tab1.Controls.Add(this.label12);
            this.tab1.Controls.Add(this.ilustacao);
            this.tab1.Controls.Add(this.whatsapptbx);
            this.tab1.Controls.Add(this.senha2tbx);
            this.tab1.Controls.Add(this.senhatbx);
            this.tab1.Controls.Add(this.label3);
            this.tab1.Controls.Add(this.label1);
            this.tab1.Controls.Add(this.emailtbx);
            this.tab1.Controls.Add(this.label5);
            this.tab1.Controls.Add(this.label4);
            this.tab1.Controls.Add(this.nometbx);
            this.tab1.Controls.Add(this.label2);
            this.tab1.Location = new System.Drawing.Point(4, 22);
            this.tab1.Name = "tab1";
            this.tab1.Padding = new System.Windows.Forms.Padding(3);
            this.tab1.Size = new System.Drawing.Size(501, 298);
            this.tab1.TabIndex = 0;
            this.tab1.Text = "Dados";
            this.tab1.UseVisualStyleBackColor = true;
            // 
            // ilustacao
            // 
            this.ilustacao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ilustacao.Location = new System.Drawing.Point(309, 33);
            this.ilustacao.Name = "ilustacao";
            this.ilustacao.Size = new System.Drawing.Size(162, 147);
            this.ilustacao.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ilustacao.TabIndex = 34;
            this.ilustacao.TabStop = false;
            // 
            // tab2
            // 
            this.tab2.Controls.Add(this.lv);
            this.tab2.Controls.Add(this.label7);
            this.tab2.Controls.Add(this.pesquisatbx);
            this.tab2.Controls.Add(this.pesquisabtn);
            this.tab2.Location = new System.Drawing.Point(4, 22);
            this.tab2.Name = "tab2";
            this.tab2.Padding = new System.Windows.Forms.Padding(3);
            this.tab2.Size = new System.Drawing.Size(501, 298);
            this.tab2.TabIndex = 1;
            this.tab2.Text = "Pesquisa";
            this.tab2.UseVisualStyleBackColor = true;
            // 
            // lv
            // 
            this.lv.Location = new System.Drawing.Point(10, 55);
            this.lv.Name = "lv";
            this.lv.Size = new System.Drawing.Size(471, 119);
            this.lv.TabIndex = 4;
            this.lv.UseCompatibleStateImageBehavior = false;
            this.lv.View = System.Windows.Forms.View.Details;
            this.lv.SelectedIndexChanged += new System.EventHandler(this.lv_SelectedIndexChanged);
            this.lv.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lv_MouseDoubleClick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(150, 20);
            this.label7.TabIndex = 2;
            this.label7.Text = "Pesquisar por nome";
            // 
            // pesquisatbx
            // 
            this.pesquisatbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pesquisatbx.Location = new System.Drawing.Point(162, 17);
            this.pesquisatbx.Name = "pesquisatbx";
            this.pesquisatbx.Size = new System.Drawing.Size(261, 26);
            this.pesquisatbx.TabIndex = 1;
            // 
            // pesquisabtn
            // 
            this.pesquisabtn.BackgroundImage = global::Brew.Properties.Resources.btPesquisa;
            this.pesquisabtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pesquisabtn.Location = new System.Drawing.Point(429, 10);
            this.pesquisabtn.Name = "pesquisabtn";
            this.pesquisabtn.Size = new System.Drawing.Size(52, 39);
            this.pesquisabtn.TabIndex = 0;
            this.pesquisabtn.UseVisualStyleBackColor = true;
            this.pesquisabtn.Click += new System.EventHandler(this.pesquisabtn_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "Insumo";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(306, 12);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(92, 13);
            this.label12.TabIndex = 36;
            this.label12.Text = "Foto do cervejeiro";
            // 
            // Cervejeiro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 387);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Cervejeiro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cervejeiro";
            this.Load += new System.EventHandler(this.Cervejeiro_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.tab1.ResumeLayout(false);
            this.tab1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ilustacao)).EndInit();
            this.tab2.ResumeLayout(false);
            this.tab2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button salva;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nometbx;
        private System.Windows.Forms.Button sairbtn;
        private System.Windows.Forms.TextBox emailtbx;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox senhatbx;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox senha2tbx;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox whatsapptbx;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tab1;
        private System.Windows.Forms.TabPage tab2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox pesquisatbx;
        private System.Windows.Forms.Button pesquisabtn;
        private System.Windows.Forms.ListView lv;
        private System.Windows.Forms.PictureBox ilustacao;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Label label12;
    }
}

