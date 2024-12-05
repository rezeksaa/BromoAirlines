using System.Windows.Forms;

namespace BromoAirlines.Forms {
    partial class adminForm {
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(adminForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelDashboard = new System.Windows.Forms.Panel();
            this.lbDashboard = new System.Windows.Forms.Label();
            this.pbDashboard = new System.Windows.Forms.PictureBox();
            this.sidebar = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pbLogout = new System.Windows.Forms.PictureBox();
            this.lbLogout = new System.Windows.Forms.Label();
            this.lbStatus = new System.Windows.Forms.Label();
            this.pbStatus = new System.Windows.Forms.PictureBox();
            this.lbPromo = new System.Windows.Forms.Label();
            this.pbPromo = new System.Windows.Forms.PictureBox();
            this.lbJadwal = new System.Windows.Forms.Label();
            this.pbJadwal = new System.Windows.Forms.PictureBox();
            this.lbMaskapai = new System.Windows.Forms.Label();
            this.pbMaskapai = new System.Windows.Forms.PictureBox();
            this.lbBandara = new System.Windows.Forms.Label();
            this.pbBandara = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panelDashboard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbDashboard)).BeginInit();
            this.sidebar.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPromo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbJadwal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMaskapai)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBandara)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(93)))), ((int)(((byte)(169)))));
            this.panel1.Controls.Add(this.panelDashboard);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1279, 97);
            this.panel1.TabIndex = 0;
            // 
            // panelDashboard
            // 
            this.panelDashboard.Controls.Add(this.lbDashboard);
            this.panelDashboard.Controls.Add(this.pbDashboard);
            this.panelDashboard.Location = new System.Drawing.Point(15, 22);
            this.panelDashboard.Name = "panelDashboard";
            this.panelDashboard.Size = new System.Drawing.Size(185, 51);
            this.panelDashboard.TabIndex = 0;
            this.panelDashboard.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panelDashboard_Click);
            // 
            // lbDashboard
            // 
            this.lbDashboard.AutoSize = true;
            this.lbDashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbDashboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDashboard.ForeColor = System.Drawing.Color.White;
            this.lbDashboard.Location = new System.Drawing.Point(66, 15);
            this.lbDashboard.Name = "lbDashboard";
            this.lbDashboard.Size = new System.Drawing.Size(98, 22);
            this.lbDashboard.TabIndex = 1;
            this.lbDashboard.Text = "Dashboard";
            this.lbDashboard.Click += new System.EventHandler(this.lbDashboard_Click);
            // 
            // pbDashboard
            // 
            this.pbDashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbDashboard.Image = ((System.Drawing.Image)(resources.GetObject("pbDashboard.Image")));
            this.pbDashboard.Location = new System.Drawing.Point(0, 0);
            this.pbDashboard.Name = "pbDashboard";
            this.pbDashboard.Size = new System.Drawing.Size(60, 50);
            this.pbDashboard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbDashboard.TabIndex = 0;
            this.pbDashboard.TabStop = false;
            this.pbDashboard.Click += new System.EventHandler(this.pbDashboard_Click);
            // 
            // sidebar
            // 
            this.sidebar.BackColor = System.Drawing.Color.White;
            this.sidebar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sidebar.Controls.Add(this.panel3);
            this.sidebar.Controls.Add(this.lbStatus);
            this.sidebar.Controls.Add(this.pbStatus);
            this.sidebar.Controls.Add(this.lbPromo);
            this.sidebar.Controls.Add(this.pbPromo);
            this.sidebar.Controls.Add(this.lbJadwal);
            this.sidebar.Controls.Add(this.pbJadwal);
            this.sidebar.Controls.Add(this.lbMaskapai);
            this.sidebar.Controls.Add(this.pbMaskapai);
            this.sidebar.Controls.Add(this.lbBandara);
            this.sidebar.Controls.Add(this.pbBandara);
            this.sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebar.Location = new System.Drawing.Point(0, 97);
            this.sidebar.Name = "sidebar";
            this.sidebar.Size = new System.Drawing.Size(335, 675);
            this.sidebar.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.pbLogout);
            this.panel3.Controls.Add(this.lbLogout);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 573);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(333, 100);
            this.panel3.TabIndex = 14;
            // 
            // pbLogout
            // 
            this.pbLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbLogout.Image = ((System.Drawing.Image)(resources.GetObject("pbLogout.Image")));
            this.pbLogout.Location = new System.Drawing.Point(14, 39);
            this.pbLogout.Name = "pbLogout";
            this.pbLogout.Size = new System.Drawing.Size(60, 50);
            this.pbLogout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLogout.TabIndex = 12;
            this.pbLogout.TabStop = false;
            // 
            // lbLogout
            // 
            this.lbLogout.AutoSize = true;
            this.lbLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLogout.ForeColor = System.Drawing.Color.Red;
            this.lbLogout.Location = new System.Drawing.Point(80, 54);
            this.lbLogout.Name = "lbLogout";
            this.lbLogout.Size = new System.Drawing.Size(65, 22);
            this.lbLogout.TabIndex = 13;
            this.lbLogout.Text = "Logout";
            // 
            // lbStatus
            // 
            this.lbStatus.AutoSize = true;
            this.lbStatus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStatus.ForeColor = System.Drawing.Color.Gray;
            this.lbStatus.Location = new System.Drawing.Point(80, 303);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(222, 22);
            this.lbStatus.TabIndex = 11;
            this.lbStatus.Text = "Ubah Status Penerbangan";
            this.lbStatus.Click += new System.EventHandler(this.lbStatus_Click);
            // 
            // pbStatus
            // 
            this.pbStatus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbStatus.Image = ((System.Drawing.Image)(resources.GetObject("pbStatus.Image")));
            this.pbStatus.Location = new System.Drawing.Point(14, 288);
            this.pbStatus.Name = "pbStatus";
            this.pbStatus.Size = new System.Drawing.Size(60, 50);
            this.pbStatus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbStatus.TabIndex = 10;
            this.pbStatus.TabStop = false;
            this.pbStatus.Click += new System.EventHandler(this.pbStatus_Click);
            // 
            // lbPromo
            // 
            this.lbPromo.AutoSize = true;
            this.lbPromo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbPromo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPromo.ForeColor = System.Drawing.Color.Gray;
            this.lbPromo.Location = new System.Drawing.Point(80, 237);
            this.lbPromo.Name = "lbPromo";
            this.lbPromo.Size = new System.Drawing.Size(168, 22);
            this.lbPromo.TabIndex = 9;
            this.lbPromo.Text = "Master Kode Promo";
            this.lbPromo.Click += new System.EventHandler(this.lbPromo_Click);
            // 
            // pbPromo
            // 
            this.pbPromo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbPromo.Image = ((System.Drawing.Image)(resources.GetObject("pbPromo.Image")));
            this.pbPromo.Location = new System.Drawing.Point(14, 222);
            this.pbPromo.Name = "pbPromo";
            this.pbPromo.Size = new System.Drawing.Size(60, 50);
            this.pbPromo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPromo.TabIndex = 8;
            this.pbPromo.TabStop = false;
            this.pbPromo.Click += new System.EventHandler(this.pbPromo_Click);
            // 
            // lbJadwal
            // 
            this.lbJadwal.AutoSize = true;
            this.lbJadwal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbJadwal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbJadwal.ForeColor = System.Drawing.Color.Gray;
            this.lbJadwal.Location = new System.Drawing.Point(80, 169);
            this.lbJadwal.Name = "lbJadwal";
            this.lbJadwal.Size = new System.Drawing.Size(238, 22);
            this.lbJadwal.TabIndex = 7;
            this.lbJadwal.Text = "Master Jadwal Penerbangan";
            this.lbJadwal.Click += new System.EventHandler(this.lbJadwal_Click);
            // 
            // pbJadwal
            // 
            this.pbJadwal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbJadwal.Image = ((System.Drawing.Image)(resources.GetObject("pbJadwal.Image")));
            this.pbJadwal.Location = new System.Drawing.Point(14, 154);
            this.pbJadwal.Name = "pbJadwal";
            this.pbJadwal.Size = new System.Drawing.Size(60, 50);
            this.pbJadwal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbJadwal.TabIndex = 6;
            this.pbJadwal.TabStop = false;
            this.pbJadwal.Click += new System.EventHandler(this.pbJadwal_Click);
            // 
            // lbMaskapai
            // 
            this.lbMaskapai.AutoSize = true;
            this.lbMaskapai.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbMaskapai.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaskapai.ForeColor = System.Drawing.Color.Gray;
            this.lbMaskapai.Location = new System.Drawing.Point(80, 101);
            this.lbMaskapai.Name = "lbMaskapai";
            this.lbMaskapai.Size = new System.Drawing.Size(145, 22);
            this.lbMaskapai.TabIndex = 5;
            this.lbMaskapai.Text = "Master Maskapai";
            this.lbMaskapai.Click += new System.EventHandler(this.lbMaskapai_Click);
            // 
            // pbMaskapai
            // 
            this.pbMaskapai.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbMaskapai.Image = ((System.Drawing.Image)(resources.GetObject("pbMaskapai.Image")));
            this.pbMaskapai.Location = new System.Drawing.Point(14, 86);
            this.pbMaskapai.Name = "pbMaskapai";
            this.pbMaskapai.Size = new System.Drawing.Size(60, 50);
            this.pbMaskapai.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbMaskapai.TabIndex = 4;
            this.pbMaskapai.TabStop = false;
            this.pbMaskapai.Click += new System.EventHandler(this.pbMaskapai_Click);
            // 
            // lbBandara
            // 
            this.lbBandara.AutoSize = true;
            this.lbBandara.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbBandara.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBandara.ForeColor = System.Drawing.Color.Gray;
            this.lbBandara.Location = new System.Drawing.Point(80, 33);
            this.lbBandara.Name = "lbBandara";
            this.lbBandara.Size = new System.Drawing.Size(137, 22);
            this.lbBandara.TabIndex = 3;
            this.lbBandara.Text = "Master Bandara";
            this.lbBandara.Click += new System.EventHandler(this.lbBandara_Click);
            // 
            // pbBandara
            // 
            this.pbBandara.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbBandara.Image = ((System.Drawing.Image)(resources.GetObject("pbBandara.Image")));
            this.pbBandara.Location = new System.Drawing.Point(14, 18);
            this.pbBandara.Name = "pbBandara";
            this.pbBandara.Size = new System.Drawing.Size(60, 50);
            this.pbBandara.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbBandara.TabIndex = 2;
            this.pbBandara.TabStop = false;
            this.pbBandara.Click += new System.EventHandler(this.pbBandara_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(335, 97);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(944, 675);
            this.panel2.TabIndex = 2;
            // 
            // adminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1279, 772);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.sidebar);
            this.Controls.Add(this.panel1);
            this.Name = "adminForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "adminForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.adminForm_Load);
            this.panel1.ResumeLayout(false);
            this.panelDashboard.ResumeLayout(false);
            this.panelDashboard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbDashboard)).EndInit();
            this.sidebar.ResumeLayout(false);
            this.sidebar.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPromo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbJadwal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMaskapai)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBandara)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel sidebar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panelDashboard;
        private System.Windows.Forms.Label lbDashboard;
        private System.Windows.Forms.PictureBox pbDashboard;
        private Label lbStatus;
        private PictureBox pbStatus;
        private Label lbPromo;
        private PictureBox pbPromo;
        private Label lbJadwal;
        private PictureBox pbJadwal;
        private Label lbMaskapai;
        private PictureBox pbMaskapai;
        private Label lbBandara;
        private PictureBox pbBandara;
        private Label lbLogout;
        private PictureBox pbLogout;
        private Panel panel3;
    }
}