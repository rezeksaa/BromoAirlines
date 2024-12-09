using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BromoAirlines.Fragments {
    public partial class MasterBandaraFrag : UserControl {
        bool isEditing = false;
        int selectedBandaraID = 0;

        public MasterBandaraFrag() {
            InitializeComponent();
        }

        private void MasterBandaraFrag_Load(object sender, EventArgs e) {
            lbStatus.Text = "Menambah Bandara";
            LoadDataGridView();
        }

        #region Refresh DataGridView
        private void LoadDataGridView() {
            this.bandaraTableAdapter.Fill(this.bromoAirlinesDataSet.Bandara);

            BindingSource bs = (BindingSource)dataGridView1.DataSource;
            bs.Sort = "Nama";

            foreach (DataGridViewRow row in dataGridView1.Rows) {
                var model = Repo.db.Negaras.Find(row.Cells["NegaraID"].Value);
                row.Cells["Negara"].Value = model.Nama;
            }
            this.negaraTableAdapter.Fill(this.bromoAirlinesDataSet.Negara);
        
        }
        #endregion

        #region Validation

        bool Validasi() {
            var editingBandara = new BromoAirlines.Bandara();
            if (isEditing) {
                editingBandara = Repo.db.Bandaras.Where(r => r.ID.Equals(selectedBandaraID)).FirstOrDefault();
            }

            if (string.IsNullOrEmpty(tbNama.Text) || string.IsNullOrEmpty(tbKota.Text) ||
                string.IsNullOrEmpty(tbKode.Text) || string.IsNullOrEmpty(tbAlamat.Text)) {
                MessageBox.Show("Semua field harus diisi!");
                return false;
            }
            if (isEditing == false) {
                if (Repo.db.Bandaras.Any(r => r.Nama.Equals(tbNama.Text))) {
                    MessageBox.Show("Nama Bandara sudah digunakan!");
                    return false;
                }
            }
            if (isEditing) {
                if (tbKode.Text == editingBandara.KodeIATA) {
                    return true;
                }
            }

            if (Repo.db.Bandaras.Any(r => r.KodeIATA.Equals(tbKode.Text))) {
                MessageBox.Show("Kode IATA harus unik dan belum digunakan!");
                return false;
            }
            if (tbKode.Text.Length < 3) {
                MessageBox.Show("Kode IATA harus memiliki 3 karakter!");
                return false;
            }
            return true;
        }

        #endregion

        private void btnSimpan_Click(object sender, EventArgs e) {
            if (Validasi()) {
                if (isEditing) {
                    var editingBandara = Repo.db.Bandaras.Where(r => r.ID.Equals(selectedBandaraID)).FirstOrDefault();

                    editingBandara.Nama = tbNama.Text;
                    editingBandara.Kota = tbKota.Text;
                    editingBandara.NegaraID = Convert.ToInt32(cbNegara.SelectedValue);
                    editingBandara.Alamat = tbAlamat.Text;
                    editingBandara.JumlahTerminal = Convert.ToInt32(nudTerminal.Value);
                    editingBandara.KodeIATA = tbKode.Text;

                    Repo.db.SaveChanges();

                    LoadDataGridView();

                    ClearInputFields();
                    MessageBox.Show("Bandara berhasil diubah!");
                } else {
                    Bandara bandara = new Bandara {
                        Nama = tbNama.Text,
                        Kota = tbKota.Text,
                        NegaraID = Convert.ToInt32(cbNegara.SelectedValue),
                        Alamat = tbAlamat.Text,
                        JumlahTerminal = Convert.ToInt32(nudTerminal.Value),
                        KodeIATA = tbKode.Text
                    };

                    Repo.db.Bandaras.Add(bandara);

                    Repo.db.SaveChanges();

                    LoadDataGridView();

                    ClearInputFields();
                    MessageBox.Show("Bandara berhasil ditambahkan!");
                }
            }
        }

        #region Clear Input Fields
        private void ClearInputFields() {
            tbNama.Clear();
            tbKota.Clear();
            tbKode.Clear();
            tbAlamat.Clear();
            nudTerminal.Value = 1;
            if (cbNegara.Items.Count > 0) {
                cbNegara.SelectedIndex = 0;
            }
        }
        #endregion

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) {
            if (e.RowIndex >= 0 && e.ColumnIndex == dataGridView1.Columns["Ubah"].Index) {
                isEditing = true;
                selectedBandaraID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["ID"].Value);
                var editingBandara = Repo.db.Bandaras.Where(r => r.ID.Equals(selectedBandaraID)).FirstOrDefault();

                String BandaraName = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells["Nama"].Value);
                lbStatus.Text = "sedang mengubah bandara " + BandaraName;

                tbNama.Text = editingBandara.Nama;
                tbKota.Text = editingBandara.Kota;
                tbKode.Text = editingBandara.KodeIATA;
                tbAlamat.Text = editingBandara.Alamat;
                cbNegara.SelectedValue = editingBandara.NegaraID;
                nudTerminal.Value = editingBandara.JumlahTerminal;
            } else if (e.RowIndex >= 0 && e.ColumnIndex == dataGridView1.Columns["Hapus"].Index) {
                selectedBandaraID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["ID"].Value);
                var deletingBandara = Repo.db.Bandaras.Where(r => r.ID.Equals(selectedBandaraID)).FirstOrDefault();
                String BandaraName = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells["Nama"].Value);
                DialogResult result = MessageBox.Show("Apakah anda yakin ingin menghapus bandara " + BandaraName + "?", "Konfirmasi", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes) {
                    Repo.db.Bandaras.Remove(deletingBandara);

                    Repo.db.SaveChanges();

                    LoadDataGridView();

                    MessageBox.Show("Bandara " + BandaraName + " berhasil dihapus");
                } else {

                }
            }
        }

        private void btnBatal_Click(object sender, EventArgs e) {
            ClearInputFields();
            isEditing = false;
            lbStatus.Text = "Menambah Bandara";
        }
    }

}
