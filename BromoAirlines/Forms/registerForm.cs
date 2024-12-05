using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BromoAirlines.Forms {
    public partial class registerForm : Form {
        public registerForm() {
            InitializeComponent();
        }

        String angka = "1234567890";
        bool validasi() {
            if (String.IsNullOrEmpty(tbUsername.Text) || String.IsNullOrEmpty(tbPassword.Text) || String.IsNullOrEmpty(tbNomorTelepon.Text) || String.IsNullOrEmpty(dateTimePicker.Text) || String.IsNullOrEmpty(tbNama.Text)) {
                MessageBox.Show("Semua field harus diisi");
                return false;
            }
            if (!Repo.isUnique(tbUsername.Text)) {
                MessageBox.Show("Username sudah dipakai");
                return false;
            }
            if (tbPassword.Text.Length < 8) {
                MessageBox.Show("Password minimal 8 karakter");
                return false;
            }
            
            foreach (char a in tbNomorTelepon.Text) {
                if (!char.IsDigit(a)) {
                    MessageBox.Show("Nomor telepon harus berupa angka!");
                    return false;
                }
            }

            return true;
        }

        private void label2_Click(object sender, EventArgs e) {

        }

        private void registerForm_Load(object sender, EventArgs e) {

        }

        private void btnDaftar_Click(object sender, EventArgs e) {
            if (validasi()) {
                DateTime date = DateTime.ParseExact(dateTimePicker.Text, "dddd, dd MMMM yyyy", CultureInfo.InvariantCulture);
                string output = date.ToString("yyyy-MM-dd");

                Akun akun = new Akun();
                akun.nama = tbNama.Text;
                akun.tanggalLahir = date;
                akun.username = tbUsername.Text;
                akun.password = tbPassword.Text;
                akun.role = "user";
                akun.nomorTelefon = Convert.ToInt32(tbNomorTelepon.Text);

                Repo.db.Akuns.Add(akun);
                Repo.db.SaveChanges();

                Repo.login(tbUsername.Text, tbPassword.Text);

                userForm userform = new userForm();
                this.Hide();
                userform.Show();
            }

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e) {

        }
    }
}
