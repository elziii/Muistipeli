namespace Muistipeli
{
    partial class Form2
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
            this.p1Parit = new System.Windows.Forms.Label();
            this.labelPari = new System.Windows.Forms.Label();
            this.p2Parit = new System.Windows.Forms.Label();
            this.pVuoro = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // p1Parit
            // 
            this.p1Parit.AutoSize = true;
            this.p1Parit.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p1Parit.Location = new System.Drawing.Point(12, 380);
            this.p1Parit.Name = "p1Parit";
            this.p1Parit.Size = new System.Drawing.Size(259, 37);
            this.p1Parit.TabIndex = 0;
            this.p1Parit.Text = "Pelaaja 1 Parit: 0";
            // 
            // labelPari
            // 
            this.labelPari.AutoSize = true;
            this.labelPari.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPari.Location = new System.Drawing.Point(10, 433);
            this.labelPari.Name = "labelPari";
            this.labelPari.Size = new System.Drawing.Size(53, 37);
            this.labelPari.TabIndex = 1;
            this.labelPari.Text = "    ";
            // 
            // p2Parit
            // 
            this.p2Parit.AutoSize = true;
            this.p2Parit.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p2Parit.Location = new System.Drawing.Point(294, 380);
            this.p2Parit.Name = "p2Parit";
            this.p2Parit.Size = new System.Drawing.Size(98, 37);
            this.p2Parit.TabIndex = 2;
            this.p2Parit.Text = "         ";
            // 
            // pVuoro
            // 
            this.pVuoro.AutoSize = true;
            this.pVuoro.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pVuoro.Location = new System.Drawing.Point(294, 471);
            this.pVuoro.Name = "pVuoro";
            this.pVuoro.Size = new System.Drawing.Size(80, 37);
            this.pVuoro.TabIndex = 3;
            this.pVuoro.Text = "       ";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 517);
            this.Controls.Add(this.pVuoro);
            this.Controls.Add(this.p2Parit);
            this.Controls.Add(this.labelPari);
            this.Controls.Add(this.p1Parit);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label p1Parit;
        private System.Windows.Forms.Label labelPari;
        private System.Windows.Forms.Label p2Parit;
        private System.Windows.Forms.Label pVuoro;
    }
}