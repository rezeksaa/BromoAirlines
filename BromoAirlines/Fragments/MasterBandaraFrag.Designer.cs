namespace BromoAirlines.Fragments {
    partial class MasterBandaraFrag {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.btnBatal = new System.Windows.Forms.Button();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.tbAlamat = new System.Windows.Forms.RichTextBox();
            this.nudTerminal = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbKota = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbKode = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbNama = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bandaraBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bromoAirlinesDataSet = new BromoAirlines.BromoAirlinesDataSet();
            this.bandaraTableAdapter = new BromoAirlines.BromoAirlinesDataSetTableAdapters.BandaraTableAdapter();
            this.cbNegara = new System.Windows.Forms.ComboBox();
            this.negaraBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.negaraTableAdapter = new BromoAirlines.BromoAirlinesDataSetTableAdapters.NegaraTableAdapter();
            this.lbStatus = new System.Windows.Forms.Label();
            this.Nama = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NegaraID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Negara = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ubah = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Hapus = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.nudTerminal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bandaraBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bromoAirlinesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.negaraBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBatal
            // 
            this.btnBatal.Location = new System.Drawing.Point(612, 609);
            this.btnBatal.Name = "btnBatal";
            this.btnBatal.Size = new System.Drawing.Size(97, 33);
            this.btnBatal.TabIndex = 38;
            this.btnBatal.Text = "Batal";
            this.btnBatal.UseVisualStyleBackColor = true;
            this.btnBatal.Click += new System.EventHandler(this.btnBatal_Click);
            // 
            // btnSimpan
            // 
            this.btnSimpan.Location = new System.Drawing.Point(727, 609);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(97, 33);
            this.btnSimpan.TabIndex = 37;
            this.btnSimpan.Text = "Simpan";
            this.btnSimpan.UseVisualStyleBackColor = true;
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
            // 
            // tbAlamat
            // 
            this.tbAlamat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbAlamat.Location = new System.Drawing.Point(567, 471);
            this.tbAlamat.Name = "tbAlamat";
            this.tbAlamat.Size = new System.Drawing.Size(257, 101);
            this.tbAlamat.TabIndex = 36;
            this.tbAlamat.Text = "";
            // 
            // nudTerminal
            // 
            this.nudTerminal.Location = new System.Drawing.Point(567, 428);
            this.nudTerminal.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudTerminal.Name = "nudTerminal";
            this.nudTerminal.Size = new System.Drawing.Size(257, 22);
            this.nudTerminal.TabIndex = 35;
            this.nudTerminal.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(447, 473);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 16);
            this.label7.TabIndex = 34;
            this.label7.Text = "Alamat";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(447, 432);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(106, 16);
            this.label8.TabIndex = 33;
            this.label8.Text = "Jumlah Terminal";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(48, 553);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 16);
            this.label5.TabIndex = 32;
            this.label5.Text = "Negara";
            // 
            // tbKota
            // 
            this.tbKota.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbKota.Location = new System.Drawing.Point(149, 509);
            this.tbKota.Name = "tbKota";
            this.tbKota.Size = new System.Drawing.Size(257, 22);
            this.tbKota.TabIndex = 31;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(48, 512);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 16);
            this.label6.TabIndex = 30;
            this.label6.Text = "Kota";
            // 
            // tbKode
            // 
            this.tbKode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbKode.Location = new System.Drawing.Point(149, 470);
            this.tbKode.MaxLength = 3;
            this.tbKode.Name = "tbKode";
            this.tbKode.Size = new System.Drawing.Size(257, 22);
            this.tbKode.TabIndex = 29;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 473);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 16);
            this.label4.TabIndex = 28;
            this.label4.Text = "Kode IATA";
            // 
            // tbNama
            // 
            this.tbNama.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbNama.Location = new System.Drawing.Point(149, 429);
            this.tbNama.Name = "tbNama";
            this.tbNama.Size = new System.Drawing.Size(257, 22);
            this.tbNama.TabIndex = 27;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 432);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 16);
            this.label3.TabIndex = 26;
            this.label3.Text = "Nama";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(47, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(382, 20);
            this.label2.TabIndex = 24;
            this.label2.Text = "Semua bandara yang terdaftar akan muncul di sini";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(298, 42);
            this.label1.TabIndex = 23;
            this.label1.Text = "Master Bandara";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nama,
            this.ID,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.NegaraID,
            this.Negara,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.Ubah,
            this.Hapus});
            this.dataGridView1.DataSource = this.bandaraBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(51, 122);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 40;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(773, 277);
            this.dataGridView1.TabIndex = 39;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // bandaraBindingSource
            // 
            this.bandaraBindingSource.DataMember = "Bandara";
            this.bandaraBindingSource.DataSource = this.bromoAirlinesDataSet;
            // 
            // bromoAirlinesDataSet
            // 
            this.bromoAirlinesDataSet.DataSetName = "BromoAirlinesDataSet";
            this.bromoAirlinesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bandaraTableAdapter
            // 
            this.bandaraTableAdapter.ClearBeforeFill = true;
            // 
            // cbNegara
            // 
            this.cbNegara.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.negaraBindingSource, "Nama", true));
            this.cbNegara.DataSource = this.negaraBindingSource;
            this.cbNegara.DisplayMember = "Nama";
            this.cbNegara.FormattingEnabled = true;
            this.cbNegara.Location = new System.Drawing.Point(149, 550);
            this.cbNegara.Name = "cbNegara";
            this.cbNegara.Size = new System.Drawing.Size(257, 24);
            this.cbNegara.TabIndex = 40;
            this.cbNegara.ValueMember = "ID";
            // 
            // negaraBindingSource
            // 
            this.negaraBindingSource.DataMember = "Negara";
            this.negaraBindingSource.DataSource = this.bromoAirlinesDataSet;
            // 
            // negaraTableAdapter
            // 
            this.negaraTableAdapter.ClearBeforeFill = true;
            // 
            // lbStatus
            // 
            this.lbStatus.AutoSize = true;
            this.lbStatus.Location = new System.Drawing.Point(48, 617);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(44, 16);
            this.lbStatus.TabIndex = 41;
            this.lbStatus.Text = "Status";
            // 
            // Nama
            // 
            this.Nama.DataPropertyName = "Nama";
            this.Nama.HeaderText = "Nama";
            this.Nama.MinimumWidth = 6;
            this.Nama.Name = "Nama";
            this.Nama.ReadOnly = true;
            this.Nama.Width = 125;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            this.ID.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "KodeIATA";
            this.dataGridViewTextBoxColumn2.HeaderText = "KodeIATA";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Kota";
            this.dataGridViewTextBoxColumn3.HeaderText = "Kota";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // NegaraID
            // 
            this.NegaraID.DataPropertyName = "NegaraID";
            this.NegaraID.HeaderText = "Negara";
            this.NegaraID.MinimumWidth = 6;
            this.NegaraID.Name = "NegaraID";
            this.NegaraID.ReadOnly = true;
            this.NegaraID.Visible = false;
            this.NegaraID.Width = 125;
            // 
            // Negara
            // 
            this.Negara.HeaderText = "Negara";
            this.Negara.MinimumWidth = 6;
            this.Negara.Name = "Negara";
            this.Negara.ReadOnly = true;
            this.Negara.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "JumlahTerminal";
            this.dataGridViewTextBoxColumn4.HeaderText = "JumlahTerminal";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Alamat";
            this.dataGridViewTextBoxColumn5.HeaderText = "Alamat";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // Ubah
            // 
            this.Ubah.HeaderText = "";
            this.Ubah.MinimumWidth = 6;
            this.Ubah.Name = "Ubah";
            this.Ubah.ReadOnly = true;
            this.Ubah.Text = "Ubah";
            this.Ubah.UseColumnTextForButtonValue = true;
            this.Ubah.Width = 125;
            // 
            // Hapus
            // 
            this.Hapus.HeaderText = "";
            this.Hapus.MinimumWidth = 6;
            this.Hapus.Name = "Hapus";
            this.Hapus.ReadOnly = true;
            this.Hapus.Text = "Hapus";
            this.Hapus.UseColumnTextForButtonValue = true;
            this.Hapus.Width = 125;
            // 
            // MasterBandaraFrag
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbStatus);
            this.Controls.Add(this.cbNegara);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnBatal);
            this.Controls.Add(this.btnSimpan);
            this.Controls.Add(this.tbAlamat);
            this.Controls.Add(this.nudTerminal);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbKota);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbKode);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbNama);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "MasterBandaraFrag";
            this.Size = new System.Drawing.Size(944, 675);
            this.Load += new System.EventHandler(this.MasterBandaraFrag_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudTerminal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bandaraBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bromoAirlinesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.negaraBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnBatal;
        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.RichTextBox tbAlamat;
        private System.Windows.Forms.NumericUpDown nudTerminal;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbKota;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbKode;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbNama;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn namaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kodeIATADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kotaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jumlahTerminalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn alamatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource bandaraBindingSource;
        private BromoAirlinesDataSet bromoAirlinesDataSet;
        private BromoAirlinesDataSetTableAdapters.BandaraTableAdapter bandaraTableAdapter;
        private System.Windows.Forms.ComboBox cbNegara;
        private System.Windows.Forms.BindingSource negaraBindingSource;
        private BromoAirlinesDataSetTableAdapters.NegaraTableAdapter negaraTableAdapter;
        private System.Windows.Forms.Label lbStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nama;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn NegaraID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Negara;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewButtonColumn Ubah;
        private System.Windows.Forms.DataGridViewButtonColumn Hapus;
    }
}
