namespace SPP
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.kelolaTransaksiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lihatSemuaTransaksiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buatLaporanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kelolaUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.siswaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lihatSemuaSiswaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tambahkanSiswaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.petugasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lihatSemuaPetugasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tambahkanPetugasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.akunToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.profilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dividerToolStripMenuItem = new System.Windows.Forms.ToolStripSeparator();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label1);
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(12, 52);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 100);
            this.panel1.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(16, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 33);
            this.label6.TabIndex = 1;
            this.label6.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Siswa";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kelolaTransaksiToolStripMenuItem,
            this.kelolaUserToolStripMenuItem,
            this.akunToolStripMenuItem,
            this.refreshToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1048, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // kelolaTransaksiToolStripMenuItem
            // 
            this.kelolaTransaksiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lihatSemuaTransaksiToolStripMenuItem,
            this.buatLaporanToolStripMenuItem});
            this.kelolaTransaksiToolStripMenuItem.Name = "kelolaTransaksiToolStripMenuItem";
            this.kelolaTransaksiToolStripMenuItem.Size = new System.Drawing.Size(101, 20);
            this.kelolaTransaksiToolStripMenuItem.Text = "Kelola Transaksi";
            // 
            // lihatSemuaTransaksiToolStripMenuItem
            // 
            this.lihatSemuaTransaksiToolStripMenuItem.Name = "lihatSemuaTransaksiToolStripMenuItem";
            this.lihatSemuaTransaksiToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.lihatSemuaTransaksiToolStripMenuItem.Text = "Lihat Semua Transaksi";
            // 
            // buatLaporanToolStripMenuItem
            // 
            this.buatLaporanToolStripMenuItem.Name = "buatLaporanToolStripMenuItem";
            this.buatLaporanToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.buatLaporanToolStripMenuItem.Text = "Buat Laporan";
            // 
            // kelolaUserToolStripMenuItem
            // 
            this.kelolaUserToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.siswaToolStripMenuItem,
            this.petugasToolStripMenuItem});
            this.kelolaUserToolStripMenuItem.Name = "kelolaUserToolStripMenuItem";
            this.kelolaUserToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.kelolaUserToolStripMenuItem.Text = "Kelola User";
            // 
            // siswaToolStripMenuItem
            // 
            this.siswaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lihatSemuaSiswaToolStripMenuItem,
            this.tambahkanSiswaToolStripMenuItem});
            this.siswaToolStripMenuItem.Name = "siswaToolStripMenuItem";
            this.siswaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.siswaToolStripMenuItem.Text = "Siswa";
            // 
            // lihatSemuaSiswaToolStripMenuItem
            // 
            this.lihatSemuaSiswaToolStripMenuItem.Name = "lihatSemuaSiswaToolStripMenuItem";
            this.lihatSemuaSiswaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.lihatSemuaSiswaToolStripMenuItem.Text = "Lihat Semua Siswa";
            this.lihatSemuaSiswaToolStripMenuItem.Click += new System.EventHandler(this.lihatSemuaSiswaToolStripMenuItem_Click);
            // 
            // tambahkanSiswaToolStripMenuItem
            // 
            this.tambahkanSiswaToolStripMenuItem.Name = "tambahkanSiswaToolStripMenuItem";
            this.tambahkanSiswaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.tambahkanSiswaToolStripMenuItem.Text = "Tambahkan Siswa";
            this.tambahkanSiswaToolStripMenuItem.Click += new System.EventHandler(this.tambahkanSiswaToolStripMenuItem_Click);
            // 
            // petugasToolStripMenuItem
            // 
            this.petugasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lihatSemuaPetugasToolStripMenuItem,
            this.tambahkanPetugasToolStripMenuItem});
            this.petugasToolStripMenuItem.Name = "petugasToolStripMenuItem";
            this.petugasToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.petugasToolStripMenuItem.Text = "Petugas";
            // 
            // lihatSemuaPetugasToolStripMenuItem
            // 
            this.lihatSemuaPetugasToolStripMenuItem.Name = "lihatSemuaPetugasToolStripMenuItem";
            this.lihatSemuaPetugasToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.lihatSemuaPetugasToolStripMenuItem.Text = "Lihat Semua Petugas";
            this.lihatSemuaPetugasToolStripMenuItem.Click += new System.EventHandler(this.lihatSemuaPetugasToolStripMenuItem_Click);
            // 
            // tambahkanPetugasToolStripMenuItem
            // 
            this.tambahkanPetugasToolStripMenuItem.Name = "tambahkanPetugasToolStripMenuItem";
            this.tambahkanPetugasToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.tambahkanPetugasToolStripMenuItem.Text = "Tambahkan Petugas";
            this.tambahkanPetugasToolStripMenuItem.Click += new System.EventHandler(this.tambahkanPetugasToolStripMenuItem_Click);
            // 
            // akunToolStripMenuItem
            // 
            this.akunToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.profilToolStripMenuItem,
            this.dividerToolStripMenuItem,
            this.logOutToolStripMenuItem});
            this.akunToolStripMenuItem.Name = "akunToolStripMenuItem";
            this.akunToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.akunToolStripMenuItem.Text = "Akun";
            // 
            // profilToolStripMenuItem
            // 
            this.profilToolStripMenuItem.Name = "profilToolStripMenuItem";
            this.profilToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.profilToolStripMenuItem.Text = "Profil";
            // 
            // dividerToolStripMenuItem
            // 
            this.dividerToolStripMenuItem.Name = "dividerToolStripMenuItem";
            this.dividerToolStripMenuItem.Size = new System.Drawing.Size(114, 6);
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.logOutToolStripMenuItem.Text = "Log Out";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
            // 
            // refreshToolStripMenuItem
            // 
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            this.refreshToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.refreshToolStripMenuItem.Text = "Refresh";
            this.refreshToolStripMenuItem.Click += new System.EventHandler(this.refreshToolStripMenuItem_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label2);
            this.panel2.ForeColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(218, 52);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 100);
            this.panel2.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(21, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 33);
            this.label7.TabIndex = 2;
            this.label7.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Petugas";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.label3);
            this.panel3.ForeColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(424, 52);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 100);
            this.panel3.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(18, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 33);
            this.label8.TabIndex = 3;
            this.label8.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Transaksi";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dataGridView1);
            this.panel4.Location = new System.Drawing.Point(12, 212);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1024, 382);
            this.panel4.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(1024, 382);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Black;
            this.panel5.Controls.Add(this.label5);
            this.panel5.Controls.Add(this.label4);
            this.panel5.ForeColor = System.Drawing.Color.White;
            this.panel5.Location = new System.Drawing.Point(836, 52);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(200, 100);
            this.panel5.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(16, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 31);
            this.label5.TabIndex = 4;
            this.label5.Text = "Admin";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Halo,";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Black;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(987, 180);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(49, 26);
            this.button2.TabIndex = 5;
            this.button2.Text = "Cari";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(108, 180);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(873, 26);
            this.textBox1.TabIndex = 6;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 183);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 20);
            this.label9.TabIndex = 7;
            this.label9.Text = "Data Siswa";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1048, 606);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SPP";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem kelolaTransaksiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lihatSemuaTransaksiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buatLaporanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kelolaUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem siswaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lihatSemuaSiswaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tambahkanSiswaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem petugasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lihatSemuaPetugasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tambahkanPetugasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem akunToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem profilToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator dividerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}

