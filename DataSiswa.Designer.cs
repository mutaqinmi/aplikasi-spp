namespace SPP
{
    partial class DataSiswa
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
            this.panel4 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.NISN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NIS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NamaSiswa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDKelas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Alamat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NoTelp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDSPP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dataGridView1);
            this.panel4.Location = new System.Drawing.Point(19, 80);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1024, 382);
            this.panel4.TabIndex = 8;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NISN,
            this.NIS,
            this.NamaSiswa,
            this.IDKelas,
            this.Alamat,
            this.NoTelp,
            this.IDSPP});
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(1024, 382);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(19, 57);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 5);
            this.panel1.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 42);
            this.label1.TabIndex = 12;
            this.label1.Text = "Data Siswa";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(340, 36);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(646, 26);
            this.textBox1.TabIndex = 17;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Black;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(992, 36);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(49, 26);
            this.button2.TabIndex = 16;
            this.button2.Text = "Cari";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
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
            // NIS
            // 
            this.NIS.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.NIS.DataPropertyName = "nis";
            this.NIS.HeaderText = "NIS";
            this.NIS.Name = "NIS";
            this.NIS.ReadOnly = true;
            this.NIS.Width = 61;
            // 
            // NamaSiswa
            // 
            this.NamaSiswa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NamaSiswa.DataPropertyName = "nama";
            this.NamaSiswa.HeaderText = "Nama Siswa";
            this.NamaSiswa.Name = "NamaSiswa";
            this.NamaSiswa.ReadOnly = true;
            // 
            // IDKelas
            // 
            this.IDKelas.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.IDKelas.DataPropertyName = "id_kelas";
            this.IDKelas.HeaderText = "ID Kelas";
            this.IDKelas.Name = "IDKelas";
            this.IDKelas.ReadOnly = true;
            this.IDKelas.Width = 94;
            // 
            // Alamat
            // 
            this.Alamat.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Alamat.DataPropertyName = "alamat";
            this.Alamat.HeaderText = "Alamat";
            this.Alamat.Name = "Alamat";
            this.Alamat.ReadOnly = true;
            this.Alamat.Width = 84;
            // 
            // NoTelp
            // 
            this.NoTelp.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.NoTelp.DataPropertyName = "no_telp";
            this.NoTelp.HeaderText = "No Telepon";
            this.NoTelp.Name = "NoTelp";
            this.NoTelp.ReadOnly = true;
            this.NoTelp.Width = 115;
            // 
            // IDSPP
            // 
            this.IDSPP.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.IDSPP.DataPropertyName = "id_spp";
            this.IDSPP.HeaderText = "ID SPP";
            this.IDSPP.Name = "IDSPP";
            this.IDSPP.ReadOnly = true;
            this.IDSPP.Width = 86;
            // 
            // DataSiswa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1063, 474);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel4);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "DataSiswa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DataSiswa";
            this.Load += new System.EventHandler(this.DataSiswa_Load);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn NISN;
        private System.Windows.Forms.DataGridViewTextBoxColumn NIS;
        private System.Windows.Forms.DataGridViewTextBoxColumn NamaSiswa;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDKelas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Alamat;
        private System.Windows.Forms.DataGridViewTextBoxColumn NoTelp;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDSPP;
    }
}