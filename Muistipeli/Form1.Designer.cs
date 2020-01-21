namespace Muistipeli
{
    partial class Form1
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
            this.labelTitle = new System.Windows.Forms.Label();
            this.cbVaikeustaso = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbPelaajat = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.cbAihe = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnTilastot = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(72, 23);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(176, 31);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "MUISTIPELI";
            // 
            // cbVaikeustaso
            // 
            this.cbVaikeustaso.FormattingEnabled = true;
            this.cbVaikeustaso.Items.AddRange(new object[] {
            "Helppo",
            "Vaikea"});
            this.cbVaikeustaso.Location = new System.Drawing.Point(127, 72);
            this.cbVaikeustaso.Name = "cbVaikeustaso";
            this.cbVaikeustaso.Size = new System.Drawing.Size(121, 21);
            this.cbVaikeustaso.TabIndex = 1;
            this.cbVaikeustaso.Text = "Helppo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Vaikeustaso:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Pelaajamäärä:";
            // 
            // cbPelaajat
            // 
            this.cbPelaajat.FormattingEnabled = true;
            this.cbPelaajat.Items.AddRange(new object[] {
            "Yksi",
            "Kaksi"});
            this.cbPelaajat.Location = new System.Drawing.Point(127, 106);
            this.cbPelaajat.Name = "cbPelaajat";
            this.cbPelaajat.Size = new System.Drawing.Size(121, 21);
            this.cbPelaajat.TabIndex = 4;
            this.cbPelaajat.Text = "Yksi";
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(76, 183);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(172, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Aloita peli";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbAihe
            // 
            this.cbAihe.FormattingEnabled = true;
            this.cbAihe.Items.AddRange(new object[] {
            "Eläimet",
            "Runet"});
            this.cbAihe.Location = new System.Drawing.Point(127, 144);
            this.cbAihe.Name = "cbAihe";
            this.cbAihe.Size = new System.Drawing.Size(121, 21);
            this.cbAihe.TabIndex = 7;
            this.cbAihe.Text = "Eläimet";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(90, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Aihe:";
            // 
            // btnTilastot
            // 
            this.btnTilastot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTilastot.Location = new System.Drawing.Point(76, 214);
            this.btnTilastot.Name = "btnTilastot";
            this.btnTilastot.Size = new System.Drawing.Size(172, 23);
            this.btnTilastot.TabIndex = 8;
            this.btnTilastot.Text = "Tilastot";
            this.btnTilastot.UseVisualStyleBackColor = true;
            this.btnTilastot.Click += new System.EventHandler(this.btnTilastot_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 249);
            this.Controls.Add(this.btnTilastot);
            this.Controls.Add(this.cbAihe);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cbPelaajat);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbVaikeustaso);
            this.Controls.Add(this.labelTitle);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.ComboBox cbVaikeustaso;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbPelaajat;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cbAihe;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnTilastot;
    }
}

