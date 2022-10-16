
namespace AplikasiKalkulator
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
            this.pilihOperasi = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.NilaiA = new System.Windows.Forms.Label();
            this.txtNilaiA = new System.Windows.Forms.TextBox();
            this.NilaiB = new System.Windows.Forms.Label();
            this.txtNilaiB = new System.Windows.Forms.TextBox();
            this.Hasil = new System.Windows.Forms.Label();
            this.lstHasil = new System.Windows.Forms.ListBox();
            this.btnHitung = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pilihOperasi
            // 
            this.pilihOperasi.FormattingEnabled = true;
            this.pilihOperasi.Items.AddRange(new object[] {
            "Pertambahan",
            "Pengurangan",
            "Perkalian",
            "Pembagian"});
            this.pilihOperasi.Location = new System.Drawing.Point(70, 24);
            this.pilihOperasi.Name = "pilihOperasi";
            this.pilihOperasi.Size = new System.Drawing.Size(147, 21);
            this.pilihOperasi.TabIndex = 0;
            this.pilihOperasi.Text = "Pilih Hitung";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Operasi";
            // 
            // NilaiA
            // 
            this.NilaiA.AutoSize = true;
            this.NilaiA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.NilaiA.Location = new System.Drawing.Point(12, 101);
            this.NilaiA.Name = "NilaiA";
            this.NilaiA.Size = new System.Drawing.Size(48, 17);
            this.NilaiA.TabIndex = 2;
            this.NilaiA.Text = "Nilai A";
            // 
            // txtNilaiA
            // 
            this.txtNilaiA.Location = new System.Drawing.Point(70, 100);
            this.txtNilaiA.Name = "txtNilaiA";
            this.txtNilaiA.Size = new System.Drawing.Size(147, 20);
            this.txtNilaiA.TabIndex = 3;
            // 
            // NilaiB
            // 
            this.NilaiB.AutoSize = true;
            this.NilaiB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.NilaiB.Location = new System.Drawing.Point(12, 140);
            this.NilaiB.Name = "NilaiB";
            this.NilaiB.Size = new System.Drawing.Size(48, 17);
            this.NilaiB.TabIndex = 4;
            this.NilaiB.Text = "Nilai B";
            // 
            // txtNilaiB
            // 
            this.txtNilaiB.Location = new System.Drawing.Point(70, 138);
            this.txtNilaiB.Name = "txtNilaiB";
            this.txtNilaiB.Size = new System.Drawing.Size(147, 20);
            this.txtNilaiB.TabIndex = 5;
            // 
            // Hasil
            // 
            this.Hasil.AutoSize = true;
            this.Hasil.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Hasil.Location = new System.Drawing.Point(12, 189);
            this.Hasil.Name = "Hasil";
            this.Hasil.Size = new System.Drawing.Size(39, 17);
            this.Hasil.TabIndex = 6;
            this.Hasil.Text = "Hasil";
            // 
            // lstHasil
            // 
            this.lstHasil.BackColor = System.Drawing.SystemColors.Menu;
            this.lstHasil.FormattingEnabled = true;
            this.lstHasil.Location = new System.Drawing.Point(71, 182);
            this.lstHasil.Name = "lstHasil";
            this.lstHasil.Size = new System.Drawing.Size(146, 30);
            this.lstHasil.TabIndex = 7;
            // 
            // btnHitung
            // 
            this.btnHitung.Location = new System.Drawing.Point(116, 230);
            this.btnHitung.Name = "btnHitung";
            this.btnHitung.Size = new System.Drawing.Size(75, 23);
            this.btnHitung.TabIndex = 8;
            this.btnHitung.Text = "Hasil";
            this.btnHitung.UseVisualStyleBackColor = true;
            this.btnHitung.Click += new System.EventHandler(this.btnHitung_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 450);
            this.Controls.Add(this.btnHitung);
            this.Controls.Add(this.lstHasil);
            this.Controls.Add(this.Hasil);
            this.Controls.Add(this.txtNilaiB);
            this.Controls.Add(this.NilaiB);
            this.Controls.Add(this.txtNilaiA);
            this.Controls.Add(this.NilaiA);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pilihOperasi);
            this.Name = "Form1";
            this.Text = "Aplikasi Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox pilihOperasi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label NilaiA;
        private System.Windows.Forms.TextBox txtNilaiA;
        private System.Windows.Forms.Label NilaiB;
        private System.Windows.Forms.TextBox txtNilaiB;
        private System.Windows.Forms.Label Hasil;
        private System.Windows.Forms.ListBox lstHasil;
        private System.Windows.Forms.Button btnHitung;
    }
}

