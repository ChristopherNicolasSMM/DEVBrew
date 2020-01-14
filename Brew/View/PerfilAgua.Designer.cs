namespace Brew.View
{
    partial class PerfilAgua
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PerfilAgua));
            this.panel3 = new System.Windows.Forms.Panel();
            this.utilizatBtn = new System.Windows.Forms.Button();
            this.salva = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.sairbtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.laudoTxt = new System.Windows.Forms.TextBox();
            this.uploadLaudoBtn = new System.Windows.Forms.Button();
            this.panel3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.PaleTurquoise;
            this.panel3.Controls.Add(this.utilizatBtn);
            this.panel3.Controls.Add(this.salva);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.sairbtn);
            this.panel3.Location = new System.Drawing.Point(-1, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(563, 40);
            this.panel3.TabIndex = 19;
            // 
            // utilizatBtn
            // 
            this.utilizatBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.utilizatBtn.Image = global::Brew.Properties.Resources.btConfirma;
            this.utilizatBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.utilizatBtn.Location = new System.Drawing.Point(0, -1);
            this.utilizatBtn.Name = "utilizatBtn";
            this.utilizatBtn.Size = new System.Drawing.Size(82, 41);
            this.utilizatBtn.TabIndex = 9;
            this.utilizatBtn.Text = "Utilizar";
            this.utilizatBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.utilizatBtn.UseVisualStyleBackColor = true;
            // 
            // salva
            // 
            this.salva.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("salva.BackgroundImage")));
            this.salva.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.salva.Location = new System.Drawing.Point(446, 0);
            this.salva.Name = "salva";
            this.salva.Size = new System.Drawing.Size(48, 40);
            this.salva.TabIndex = 10;
            this.salva.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(202, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(142, 24);
            this.label6.TabIndex = 4;
            this.label6.Text = "Perfil de Água";
            // 
            // sairbtn
            // 
            this.sairbtn.BackgroundImage = global::Brew.Properties.Resources.btSai;
            this.sairbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.sairbtn.Location = new System.Drawing.Point(510, 0);
            this.sairbtn.Name = "sairbtn";
            this.sairbtn.Size = new System.Drawing.Size(53, 40);
            this.sairbtn.TabIndex = 11;
            this.sairbtn.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.uploadLaudoBtn);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.laudoTxt);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Location = new System.Drawing.Point(12, 56);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(538, 382);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Perfil de água";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(22, 61);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(192, 20);
            this.textBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(338, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Laudo";
            // 
            // laudoTxt
            // 
            this.laudoTxt.Location = new System.Drawing.Point(340, 61);
            this.laudoTxt.Name = "laudoTxt";
            this.laudoTxt.ReadOnly = true;
            this.laudoTxt.Size = new System.Drawing.Size(192, 20);
            this.laudoTxt.TabIndex = 2;
            // 
            // uploadLaudoBtn
            // 
            this.uploadLaudoBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uploadLaudoBtn.Location = new System.Drawing.Point(414, 34);
            this.uploadLaudoBtn.Name = "uploadLaudoBtn";
            this.uploadLaudoBtn.Size = new System.Drawing.Size(118, 23);
            this.uploadLaudoBtn.TabIndex = 4;
            this.uploadLaudoBtn.Text = "Upload Laudo";
            this.uploadLaudoBtn.UseVisualStyleBackColor = true;
            // 
            // PerfilAgua
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PerfilAgua";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PerfilAgua";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button utilizatBtn;
        private System.Windows.Forms.Button salva;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button sairbtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button uploadLaudoBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox laudoTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
    }
}