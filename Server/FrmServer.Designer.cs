namespace Server
{
    partial class FrmServer
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
            this.cmbIgre = new System.Windows.Forms.ComboBox();
            this.txtBrojIgraca = new System.Windows.Forms.TextBox();
            this.btnPokreni = new System.Windows.Forms.Button();
            this.dgvIgraci = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIgraci)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbIgre
            // 
            this.cmbIgre.FormattingEnabled = true;
            this.cmbIgre.Location = new System.Drawing.Point(192, 12);
            this.cmbIgre.Name = "cmbIgre";
            this.cmbIgre.Size = new System.Drawing.Size(388, 21);
            this.cmbIgre.TabIndex = 0;
            // 
            // txtBrojIgraca
            // 
            this.txtBrojIgraca.Location = new System.Drawing.Point(192, 56);
            this.txtBrojIgraca.Name = "txtBrojIgraca";
            this.txtBrojIgraca.Size = new System.Drawing.Size(388, 20);
            this.txtBrojIgraca.TabIndex = 1;
            // 
            // btnPokreni
            // 
            this.btnPokreni.Location = new System.Drawing.Point(445, 100);
            this.btnPokreni.Name = "btnPokreni";
            this.btnPokreni.Size = new System.Drawing.Size(135, 23);
            this.btnPokreni.TabIndex = 2;
            this.btnPokreni.Text = "Pokreni";
            this.btnPokreni.UseVisualStyleBackColor = true;
            this.btnPokreni.Click += new System.EventHandler(this.btnPokreni_Click);
            // 
            // dgvIgraci
            // 
            this.dgvIgraci.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIgraci.Location = new System.Drawing.Point(12, 142);
            this.dgvIgraci.Name = "dgvIgraci";
            this.dgvIgraci.Size = new System.Drawing.Size(568, 254);
            this.dgvIgraci.TabIndex = 3;
            // 
            // FrmServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 450);
            this.Controls.Add(this.dgvIgraci);
            this.Controls.Add(this.btnPokreni);
            this.Controls.Add(this.txtBrojIgraca);
            this.Controls.Add(this.cmbIgre);
            this.Name = "FrmServer";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmServer_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dgvIgraci)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbIgre;
        private System.Windows.Forms.TextBox txtBrojIgraca;
        private System.Windows.Forms.Button btnPokreni;
        private System.Windows.Forms.DataGridView dgvIgraci;
    }
}

