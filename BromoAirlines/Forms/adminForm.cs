using BromoAirlines.Fragments;
using BromoAirlines.Properties;
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
    public partial class adminForm : Form {

        bool extended = true;
        public adminForm() {
            InitializeComponent();
        }
        private void adminForm_Load(object sender, EventArgs e) {
            this.AutoScaleMode = AutoScaleMode.Dpi;
            setNormal(pbBandara, lbBandara);
            showFrag(masterBandaraFrag);
        }

        void setNormal(PictureBox pb, Label lb) {
            PictureBox[] photo = { pbBandara, pbStatus, pbJadwal, pbMaskapai, pbPromo};
            Label[] label = {lbBandara, lbStatus, lbJadwal, lbMaskapai, lbPromo };
            Image[] imageSelected = { Image.FromFile("Assets/map-selected-72.png"), Image.FromFile("Assets/notepad-selected-72.png"), Image.FromFile("Assets/calendar-selected-72.png"), Image.FromFile("Assets/plane-take-off-selected-72.png"), Image.FromFile("Assets/purchase-tag-alt-selected-72.png") };
            Image[] imagUnselected = { Image.FromFile("Assets/map-unselected-72.png"), Image.FromFile("Assets/notepad-unselected-72.png"), Image.FromFile("Assets/calendar-unselected-72.png"), Image.FromFile("Assets/plane-take-off-unselected-72.png"), Image.FromFile("Assets/purchase-tag-alt-unselected-72.png") };

            for (int i = 0; i < photo.Length; i++) {
                if (pb == photo[i]) {
                    photo[i].Image = imageSelected[i];
                } else {
                    photo[i].Image = imagUnselected[i];
                }
            }

            for (int i = 0;i < label.Length; i++) {
                if (lb == label[i]) {
                    label[i].ForeColor = System.Drawing.Color.Black;
                } else {
                    label[i].ForeColor = System.Drawing.Color.Gray;
                }
            }
        }

        #region fragment

        void hideFrag() {
            foreach (UserControl frag in flowLayoutPanel1.Controls) {
                frag.Visible = false;
            }
        }

        void showFrag(UserControl frag) {
            hideFrag();
            frag.Visible = true;
        }

        #endregion

        #region onClick
        private void lbBandara_Click(object sender, EventArgs e) {
            setNormal(pbBandara, lbBandara);
            showFrag(masterBandaraFrag);
        }

        private void pbBandara_Click(object sender, EventArgs e) {
            setNormal(pbBandara, lbBandara);
            showFrag(masterBandaraFrag);
        }

        private void pbMaskapai_Click(object sender, EventArgs e) {
            setNormal(pbMaskapai, lbMaskapai);
            showFrag(masterMaskapaiFrag);
        }

        private void lbMaskapai_Click(object sender, EventArgs e) {
            setNormal(pbMaskapai, lbMaskapai);
            showFrag(masterMaskapaiFrag);
        }

        private void pbJadwal_Click(object sender, EventArgs e) {
            setNormal(pbJadwal, lbJadwal);
            showFrag(masterJadwalPenerbanganFrag);
        }

        private void lbJadwal_Click(object sender, EventArgs e) {
            setNormal(pbJadwal, lbJadwal);
            showFrag(masterJadwalPenerbanganFrag);

        }

        private void pbPromo_Click(object sender, EventArgs e) {
            setNormal(pbPromo, lbPromo);
            showFrag(masterKodePromoFrag);
        }

        private void lbPromo_Click(object sender, EventArgs e) {
            setNormal(pbPromo, lbPromo);
            showFrag(masterKodePromoFrag);
        }

        private void pbStatus_Click(object sender, EventArgs e) {
            setNormal(pbStatus, lbStatus);
            showFrag(ubahStatusPenerbanganFrag);
        }

        private void lbStatus_Click(object sender, EventArgs e) {
            setNormal(pbStatus, lbStatus);
            showFrag(ubahStatusPenerbanganFrag);
        }
        #endregion onClick

        #region Dashboard
        private void pbDashboard_Click(object sender, EventArgs e) {
            if (extended) {
                sidebar.Width -= 200;
            } else if (!extended) {
                sidebar.Width += 200;
            }
            extended = !extended;
        }

        private void lbDashboard_Click(object sender, EventArgs e) {
            if (extended) {
                sidebar.Width -= 200;
            } else if (!extended) {
                sidebar.Width += 200;
            }
            extended = !extended;
        }

        private void panelDashboard_Click(object sender, MouseEventArgs e) {
            if (extended) {
                sidebar.Width -= 200;
            } else if (!extended) {
                sidebar.Width += 200;
            }
            extended = !extended;
        }

        #endregion Dashboard

        private void panel1_Paint(object sender, PaintEventArgs e) {

        }
    }
}