namespace Muistipeli
{
    partial class Form3
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
            this.labelP1voitot = new System.Windows.Forms.Label();
            this.labelP2voitot = new System.Windows.Forms.Label();
            this.labelYPParit = new System.Windows.Forms.Label();
            this.btnTakaisin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelP1voitot
            // 
            this.labelP1voitot.AutoSize = true;
            this.labelP1voitot.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelP1voitot.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelP1voitot.Location = new System.Drawing.Point(61, 33);
            this.labelP1voitot.Name = "labelP1voitot";
            this.labelP1voitot.Size = new System.Drawing.Size(186, 27);
            this.labelP1voitot.TabIndex = 0;
            this.labelP1voitot.Text = "Pelaajan 1 voitot: ";
            // 
            // labelP2voitot
            // 
            this.labelP2voitot.AutoSize = true;
            this.labelP2voitot.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelP2voitot.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelP2voitot.Location = new System.Drawing.Point(61, 69);
            this.labelP2voitot.Name = "labelP2voitot";
            this.labelP2voitot.Size = new System.Drawing.Size(186, 27);
            this.labelP2voitot.TabIndex = 1;
            this.labelP2voitot.Text = "Pelaajan 2 voitot: ";
            // 
            // labelYPParit
            // 
            this.labelYPParit.AutoSize = true;
            this.labelYPParit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelYPParit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelYPParit.Location = new System.Drawing.Point(61, 139);
            this.labelYPParit.Name = "labelYPParit";
            this.labelYPParit.Size = new System.Drawing.Size(156, 27);
            this.labelYPParit.TabIndex = 2;
            this.labelYPParit.Text = "Yksinpeli parit:";
            // 
            // btnTakaisin
            // 
            this.btnTakaisin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTakaisin.Location = new System.Drawing.Point(12, 208);
            this.btnTakaisin.Name = "btnTakaisin";
            this.btnTakaisin.Size = new System.Drawing.Size(75, 23);
            this.btnTakaisin.TabIndex = 3;
            this.btnTakaisin.Text = "Takaisin";
            this.btnTakaisin.UseVisualStyleBackColor = true;
            this.btnTakaisin.Click += new System.EventHandler(this.btnTakaisin_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 243);
            this.Controls.Add(this.btnTakaisin);
            this.Controls.Add(this.labelYPParit);
            this.Controls.Add(this.labelP2voitot);
            this.Controls.Add(this.labelP1voitot);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelP1voitot;
        private System.Windows.Forms.Label labelP2voitot;
        private System.Windows.Forms.Label labelYPParit;
        private System.Windows.Forms.Button btnTakaisin;
    }
}