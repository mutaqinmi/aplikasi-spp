namespace SPP
{
    partial class DataPembayaran
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
            this.button2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.IdPembayaran = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdPetugas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NISN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TglBayar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BlnBayar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThnBayar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdSPP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.JumlahBayar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Black;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(973, 26);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(74, 38);
            this.button2.TabIndex = 21;
            this.button2.Text = "Filter";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(23, 59);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(314, 5);
            this.panel1.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(334, 42);
            this.label1.TabIndex = 19;
            this.label1.Text = "Data Pembayaran";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dataGridView1);
            this.panel4.Location = new System.Drawing.Point(23, 82);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1024, 382);
            this.panel4.TabIndex = 18;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdPembayaran,
            this.IdPetugas,
            this.NISN,
            this.TglBayar,
            this.BlnBayar,
            this.ThnBayar,
            this.IdSPP,
            this.JumlahBayar});
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(1024, 382);
            this.dataGridView1.TabIndex = 0;
            // 
            // IdPembayaran
            // 
            this.IdPembayaran.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.IdPembayaran.DataPropertyName = "id_pembayaran";
            this.IdPembayaran.HeaderText = "ID Pembayaran";
            this.IdPembayaran.Name = "IdPembayaran";
            this.IdPembayaran.ReadOnly = true;
            this.IdPembayaran.Visible = false;
            this.IdPembayaran.Width = 144;
            // 
            // IdPetugas
            // 
            this.IdPetugas.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.IdPetugas.DataPropertyName = "id_petugas";
            this.IdPetugas.HeaderText = "ID Petugas";
            this.IdPetugas.Name = "IdPetugas";
            this.IdPetugas.ReadOnly = true;
            this.IdPetugas.Width = 114;
            // 
            // NISN
            // 
            this.NISN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.NISN.DataPropertyName = "nisn";
            this.NISN.HeaderText = "NISN";
            this.NISN.Name = "NISN";
            this.NISN.ReadOnly = true;
            this.NISN.Width = 72;
            // 
            // TglBayar
            // 
            this.TglBayar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.TglBayar.DataPropertyName = "tgl_bayar";
            this.TglBayar.HeaderText = "Tanggal";
            this.TglBayar.Name = "TglBayar";
            this.TglBayar.ReadOnly = true;
            this.TglBayar.Width = 91;
            // 
            // BlnBayar
            // 
            this.BlnBayar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.BlnBayar.DataPropertyName = "bulan_dibayar";
            this.BlnBayar.HeaderText = "Bulan";
            this.BlnBayar.Name = "BlnBayar";
            this.BlnBayar.ReadOnly = true;
            this.BlnBayar.Width = 75;
            // 
            // ThnBayar
            // 
            this.ThnBayar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ThnBayar.DataPropertyName = "tahun_dibayar";
            this.ThnBayar.HeaderText = "Tahun";
            this.ThnBayar.Name = "ThnBayar";
            this.ThnBayar.ReadOnly = true;
            this.ThnBayar.Width = 79;
            // 
            // IdSPP
            // 
            this.IdSPP.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.IdSPP.DataPropertyName = "id_spp";
            this.IdSPP.HeaderText = "ID SPP";
            this.IdSPP.Name = "IdSPP";
            this.IdSPP.ReadOnly = true;
            this.IdSPP.Width = 86;
            // 
            // JumlahBayar
            // 
            this.JumlahBayar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.JumlahBayar.DataPropertyName = "jumlah_bayar";
            this.JumlahBayar.HeaderText = "Jumlah Bayar";
            this.JumlahBayar.Name = "JumlahBayar";
            this.JumlahBayar.ReadOnly = true;
            this.JumlahBayar.Width = 130;
            // 
            // DataPembayaran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1063, 474);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel4);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "DataPembayaran";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DataPembayaran";
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdPembayaran;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdPetugas;
        private System.Windows.Forms.DataGridViewTextBoxColumn NISN;
        private System.Windows.Forms.DataGridViewTextBoxColumn TglBayar;
        private System.Windows.Forms.DataGridViewTextBoxColumn BlnBayar;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThnBayar;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdSPP;
        private System.Windows.Forms.DataGridViewTextBoxColumn JumlahBayar;
    }
}