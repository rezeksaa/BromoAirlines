using BromoAirlines.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BromoAirlines {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {

        }

        bool validasi() {
            if (String.IsNullOrEmpty(tbUsername.Text)) {
                MessageBox.Show("Username tidak boleh kosong!");
                return false;
            }
            if (String.IsNullOrEmpty(tbPassword.Text)) {
                MessageBox.Show("Password tidak boleh kosong!");
                return false;
            }
            return true;
        }

        private void btnLogin_Click(object sender, EventArgs e) {
            if (validasi()) {
                Repo.login(tbUsername.Text, tbPassword.Text);
                    if (Repo.logged != null) {
                        if (Repo.logged.role == "admin") {
                            adminForm adminForm = new adminForm();
                            this.Hide();
                            adminForm.Show();
                        } else if (Repo.logged.role == "user") {
                            userForm userForm = new userForm();
                            this.Hide();
                            userForm.Show();
                        }
                    } else {
                        MessageBox.Show("Akun tidak ditemukan!");
                    }
            } else {

            }
        }

        private void linkDaftar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            registerForm register = new registerForm();
            this.Hide();
            register.Show();
        }
    }
}