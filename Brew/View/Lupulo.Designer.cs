namespace Brew.View
{
    partial class Lupulo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Lupulo));
            this.panel3 = new System.Windows.Forms.Panel();
            this.utilizatBtn = new System.Windows.Forms.Button();
            this.salva = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.sairbtn = new System.Windows.Forms.Button();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tab1 = new System.Windows.Forms.TabPage();
            this.label12 = new System.Windows.Forms.Label();
            this.ilustacao = new System.Windows.Forms.PictureBox();
            this.label11 = new System.Windows.Forms.Label();
            this.formatbx = new System.Windows.Forms.ComboBox();
            this.precoTxt = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tipotbx = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.notastbx = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.acidoBetatbx = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.acidoAlfatbx = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.origemtbx = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.nometbx = new System.Windows.Forms.TextBox();
            this.tab2 = new System.Windows.Forms.TabPage();
            this.lvLupulo = new System.Windows.Forms.ListView();
            this.label7 = new System.Windows.Forms.Label();
            this.pesquisatbx = new System.Windows.Forms.TextBox();
            this.pesquisabtn = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.panel3.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tab1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ilustacao)).BeginInit();
            this.tab2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LimeGreen;
            this.panel3.Controls.Add(this.utilizatBtn);
            this.panel3.Controls.Add(this.salva);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.sairbtn);
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(563, 40);
            this.panel3.TabIndex = 15;
            // 
            // utilizatBtn
            // 
            this.utilizatBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.utilizatBtn.Image = global::Brew.Properties.Resources.btConfirma;
            this.utilizatBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.utilizatBtn.Location = new System.Drawing.Point(0, 0);
            this.utilizatBtn.Name = "utilizatBtn";
            this.utilizatBtn.Size = new System.Drawing.Size(82, 41);
            this.utilizatBtn.TabIndex = 18;
            this.utilizatBtn.Text = "Utilizar";
            this.utilizatBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.utilizatBtn.UseVisualStyleBackColor = true;
            this.utilizatBtn.Click += new System.EventHandler(this.UtilizatBtn_Click);
            // 
            // salva
            // 
            this.salva.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("salva.BackgroundImage")));
            this.salva.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.salva.Location = new System.Drawing.Point(450, 0);
            this.salva.Name = "salva";
            this.salva.Size = new System.Drawing.Size(48, 40);
            this.salva.TabIndex = 9;
            this.salva.UseVisualStyleBackColor = true;
            this.salva.Click += new System.EventHandler(this.salva_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(236, 7);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 24);
            this.label6.TabIndex = 4;
            this.label6.Text = "Lupulo";
            // 
            // sairbtn
            // 
            this.sairbtn.BackgroundImage = global::Brew.Properties.Resources.btSai;
            this.sairbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.sairbtn.Location = new System.Drawing.Point(510, 0);
            this.sairbtn.Name = "sairbtn";
            this.sairbtn.Size = new System.Drawing.Size(53, 40);
            this.sairbtn.TabIndex = 10;
            this.sairbtn.UseVisualStyleBackColor = true;
            this.sairbtn.Click += new System.EventHandler(this.sairbtn_Click);
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tab1);
            this.tabControl.Controls.Add(this.tab2);
            this.tabControl.Location = new System.Drawing.Point(1, 59);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(558, 390);
            this.tabControl.TabIndex = 17;
            // 
            // tab1
            // 
            this.tab1.Controls.Add(this.label12);
            this.tab1.Controls.Add(this.ilustacao);
            this.tab1.Controls.Add(this.label11);
            this.tab1.Controls.Add(this.formatbx);
            this.tab1.Controls.Add(this.precoTxt);
            this.tab1.Controls.Add(this.label10);
            this.tab1.Controls.Add(this.tipotbx);
            this.tab1.Controls.Add(this.label9);
            this.tab1.Controls.Add(this.notastbx);
            this.tab1.Controls.Add(this.label8);
            this.tab1.Controls.Add(this.label5);
            this.tab1.Controls.Add(this.label4);
            this.tab1.Controls.Add(this.acidoBetatbx);
            this.tab1.Controls.Add(this.label3);
            this.tab1.Controls.Add(this.acidoAlfatbx);
            this.tab1.Controls.Add(this.label2);
            this.tab1.Controls.Add(this.origemtbx);
            this.tab1.Controls.Add(this.label1);
            this.tab1.Controls.Add(this.nometbx);
            this.tab1.Location = new System.Drawing.Point(4, 22);
            this.tab1.Name = "tab1";
            this.tab1.Padding = new System.Windows.Forms.Padding(3);
            this.tab1.Size = new System.Drawing.Size(550, 364);
            this.tab1.TabIndex = 0;
            this.tab1.Text = "Dados";
            this.tab1.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(367, 69);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(104, 13);
            this.label12.TabIndex = 36;
            this.label12.Text = "Ilustração do insumo";
            // 
            // ilustacao
            // 
            this.ilustacao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ilustacao.Location = new System.Drawing.Point(370, 94);
            this.ilustacao.Name = "ilustacao";
            this.ilustacao.Size = new System.Drawing.Size(162, 147);
            this.ilustacao.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ilustacao.TabIndex = 34;
            this.ilustacao.TabStop = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(215, 165);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(21, 13);
            this.label11.TabIndex = 25;
            this.label11.Text = "R$";
            // 
            // formatbx
            // 
            this.formatbx.FormattingEnabled = true;
            this.formatbx.Items.AddRange(new object[] {
            "Pellet",
            "Plug",
            "Flor",
            "Extrato"});
            this.formatbx.Location = new System.Drawing.Point(18, 161);
            this.formatbx.Name = "formatbx";
            this.formatbx.Size = new System.Drawing.Size(166, 21);
            this.formatbx.TabIndex = 6;
            // 
            // precoTxt
            // 
            this.precoTxt.Location = new System.Drawing.Point(211, 162);
            this.precoTxt.Name = "precoTxt";
            this.precoTxt.Size = new System.Drawing.Size(124, 20);
            this.precoTxt.TabIndex = 7;
            this.precoTxt.Text = "0";
            this.precoTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(208, 134);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 13);
            this.label10.TabIndex = 23;
            this.label10.Text = "Preço por g";
            // 
            // tipotbx
            // 
            this.tipotbx.FormattingEnabled = true;
            this.tipotbx.Items.AddRange(new object[] {
            "Amargor",
            "Aroma",
            "Ambos"});
            this.tipotbx.Location = new System.Drawing.Point(18, 93);
            this.tipotbx.Name = "tipotbx";
            this.tipotbx.Size = new System.Drawing.Size(166, 21);
            this.tipotbx.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(15, 235);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 13);
            this.label9.TabIndex = 13;
            this.label9.Text = "Notas";
            // 
            // notastbx
            // 
            this.notastbx.Location = new System.Drawing.Point(18, 251);
            this.notastbx.Multiline = true;
            this.notastbx.Name = "notastbx";
            this.notastbx.Size = new System.Drawing.Size(514, 104);
            this.notastbx.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 134);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Forma";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Tipo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(276, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Beta Ácido";
            // 
            // acidoBetatbx
            // 
            this.acidoBetatbx.Location = new System.Drawing.Point(279, 94);
            this.acidoBetatbx.Name = "acidoBetatbx";
            this.acidoBetatbx.Size = new System.Drawing.Size(52, 20);
            this.acidoBetatbx.TabIndex = 5;
            this.acidoBetatbx.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(208, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Ácido Alfa";
            // 
            // acidoAlfatbx
            // 
            this.acidoAlfatbx.Location = new System.Drawing.Point(211, 94);
            this.acidoAlfatbx.Name = "acidoAlfatbx";
            this.acidoAlfatbx.Size = new System.Drawing.Size(52, 20);
            this.acidoAlfatbx.TabIndex = 4;
            this.acidoAlfatbx.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(285, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Origem";
            // 
            // origemtbx
            // 
            this.origemtbx.Location = new System.Drawing.Point(288, 33);
            this.origemtbx.Name = "origemtbx";
            this.origemtbx.Size = new System.Drawing.Size(244, 20);
            this.origemtbx.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome";
            // 
            // nometbx
            // 
            this.nometbx.Location = new System.Drawing.Point(18, 33);
            this.nometbx.Name = "nometbx";
            this.nometbx.Size = new System.Drawing.Size(244, 20);
            this.nometbx.TabIndex = 1;
            // 
            // tab2
            // 
            this.tab2.Controls.Add(this.lvLupulo);
            this.tab2.Controls.Add(this.label7);
            this.tab2.Controls.Add(this.pesquisatbx);
            this.tab2.Controls.Add(this.pesquisabtn);
            this.tab2.Location = new System.Drawing.Point(4, 22);
            this.tab2.Name = "tab2";
            this.tab2.Padding = new System.Windows.Forms.Padding(3);
            this.tab2.Size = new System.Drawing.Size(550, 364);
            this.tab2.TabIndex = 1;
            this.tab2.Text = "Pesquisa";
            this.tab2.UseVisualStyleBackColor = true;
            // 
            // lvLupulo
            // 
            this.lvLupulo.Location = new System.Drawing.Point(10, 55);
            this.lvLupulo.Name = "lvLupulo";
            this.lvLupulo.Size = new System.Drawing.Size(531, 288);
            this.lvLupulo.TabIndex = 4;
            this.lvLupulo.UseCompatibleStateImageBehavior = false;
            this.lvLupulo.View = System.Windows.Forms.View.Details;
            this.lvLupulo.SelectedIndexChanged += new System.EventHandler(this.LvLupulo_SelectedIndexChanged);
            this.lvLupulo.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lvLupulo_MouseDoubleClick);
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
            this.pesquisatbx.Size = new System.Drawing.Size(302, 26);
            this.pesquisatbx.TabIndex = 1;
            // 
            // pesquisabtn
            // 
            this.pesquisabtn.BackgroundImage = global::Brew.Properties.Resources.btPesquisa;
            this.pesquisabtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pesquisabtn.Location = new System.Drawing.Point(470, 11);
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
            // Lupulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 457);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Lupulo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lupulo";
            this.Load += new System.EventHandler(this.Lupulo_Load);
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

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button sairbtn;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tab1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nometbx;
        private System.Windows.Forms.TabPage tab2;
        private System.Windows.Forms.ListView lvLupulo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox pesquisatbx;
        private System.Windows.Forms.Button pesquisabtn;
        private System.Windows.Forms.Button salva;
        private System.Windows.Forms.ComboBox formatbx;
        private System.Windows.Forms.ComboBox tipotbx;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox notastbx;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox acidoBetatbx;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox acidoAlfatbx;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox origemtbx;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox precoTxt;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.PictureBox ilustacao;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button utilizatBtn;
    }
}