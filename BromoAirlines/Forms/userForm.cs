using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BromoAirlines.Forms {
    public partial class userForm : Form {
        public userForm() {
            InitializeComponent();
        }

        private void userForm_Load(object sender, EventArgs e) {
            Console.WriteLine(Repo.logged.username);
        }
    }
}
