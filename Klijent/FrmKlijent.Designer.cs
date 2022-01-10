namespace Klijent
{
    partial class FrmKlijent
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
            this.txtKorisnickoIme = new System.Windows.Forms.TextBox();
            this.txtPitanje = new System.Windows.Forms.TextBox();
            this.txtOdgovor = new System.Windows.Forms.TextBox();
            this.txtPorukaOdServera = new System.Windows.Forms.TextBox();
            this.txtUkupanBrojPoena = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnPosaljiOdgovor = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.gbPrijava = new System.Windows.Forms.GroupBox();
            this.gbIgra = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.gbPrijava.SuspendLayout();
            this.gbIgra.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtKorisnickoIme
            // 
            this.txtKorisnickoIme.Location = new System.Drawing.Point(153, 40);
            this.txtKorisnickoIme.Name = "txtKorisnickoIme";
            this.txtKorisnickoIme.Size = new System.Drawing.Size(308, 20);
            this.txtKorisnickoIme.TabIndex = 0;
            // 
            // txtPitanje
            // 
            this.txtPitanje.Enabled = false;
            this.txtPitanje.Location = new System.Drawing.Point(153, 30);
            this.txtPitanje.Name = "txtPitanje";
            this.txtPitanje.Size = new System.Drawing.Size(308, 20);
            this.txtPitanje.TabIndex = 1;
            // 
            // txtOdgovor
            // 
            this.txtOdgovor.Location = new System.Drawing.Point(153, 66);
            this.txtOdgovor.Name = "txtOdgovor";
            this.txtOdgovor.Size = new System.Drawing.Size(308, 20);
            this.txtOdgovor.TabIndex = 2;
            // 
            // txtPorukaOdServera
            // 
            this.txtPorukaOdServera.Enabled = false;
            this.txtPorukaOdServera.Location = new System.Drawing.Point(153, 140);
            this.txtPorukaOdServera.Name = "txtPorukaOdServera";
            this.txtPorukaOdServera.Size = new System.Drawing.Size(308, 20);
            this.txtPorukaOdServera.TabIndex = 3;
            // 
            // txtUkupanBrojPoena
            // 
            this.txtUkupanBrojPoena.Enabled = false;
            this.txtUkupanBrojPoena.Location = new System.Drawing.Point(153, 178);
            this.txtUkupanBrojPoena.Name = "txtUkupanBrojPoena";
            this.txtUkupanBrojPoena.Size = new System.Drawing.Size(308, 20);
            this.txtUkupanBrojPoena.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(299, 67);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(162, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Prijavi se";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnPrijava_Click);
            // 
            // btnPosaljiOdgovor
            // 
            this.btnPosaljiOdgovor.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnPosaljiOdgovor.Location = new System.Drawing.Point(299, 93);
            this.btnPosaljiOdgovor.Name = "btnPosaljiOdgovor";
            this.btnPosaljiOdgovor.Size = new System.Drawing.Size(162, 23);
            this.btnPosaljiOdgovor.TabIndex = 6;
            this.btnPosaljiOdgovor.Text = "Posalji odgovor";
            this.btnPosaljiOdgovor.UseVisualStyleBackColor = true;
            this.btnPosaljiOdgovor.Click += new System.EventHandler(this.btnPosaljiOdgovor_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Korisnicko ime:";
            // 
            // groupBox1
            // 
            this.gbPrijava.Controls.Add(this.label1);
            this.gbPrijava.Controls.Add(this.txtKorisnickoIme);
            this.gbPrijava.Controls.Add(this.button1);
            this.gbPrijava.Location = new System.Drawing.Point(12, 12);
            this.gbPrijava.Name = "groupBox1";
            this.gbPrijava.Size = new System.Drawing.Size(485, 100);
            this.gbPrijava.TabIndex = 8;
            this.gbPrijava.TabStop = false;
            this.gbPrijava.Text = "Prijava";
            // 
            // gbIgra
            // 
            this.gbIgra.Controls.Add(this.label5);
            this.gbIgra.Controls.Add(this.label4);
            this.gbIgra.Controls.Add(this.label3);
            this.gbIgra.Controls.Add(this.label2);
            this.gbIgra.Controls.Add(this.txtPitanje);
            this.gbIgra.Controls.Add(this.txtOdgovor);
            this.gbIgra.Controls.Add(this.btnPosaljiOdgovor);
            this.gbIgra.Controls.Add(this.txtPorukaOdServera);
            this.gbIgra.Controls.Add(this.txtUkupanBrojPoena);
            this.gbIgra.Location = new System.Drawing.Point(12, 123);
            this.gbIgra.Name = "gbIgra";
            this.gbIgra.Size = new System.Drawing.Size(485, 230);
            this.gbIgra.TabIndex = 9;
            this.gbIgra.TabStop = false;
            this.gbIgra.Text = "Igra";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Pitanje:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Odgovor:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Poruka od servera:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(39, 181);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Ukupan broj poena";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 373);
            this.Controls.Add(this.gbIgra);
            this.Controls.Add(this.gbPrijava);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gbPrijava.ResumeLayout(false);
            this.gbPrijava.PerformLayout();
            this.gbIgra.ResumeLayout(false);
            this.gbIgra.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtKorisnickoIme;
        private System.Windows.Forms.TextBox txtPitanje;
        private System.Windows.Forms.TextBox txtOdgovor;
        private System.Windows.Forms.TextBox txtPorukaOdServera;
        private System.Windows.Forms.TextBox txtUkupanBrojPoena;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnPosaljiOdgovor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbPrijava;
        private System.Windows.Forms.GroupBox gbIgra;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}

