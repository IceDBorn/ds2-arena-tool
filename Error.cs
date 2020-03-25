using System;
using System.Windows.Forms;

namespace DS2_Arena_Tool {
    public partial class Error : Form {
        public Error(bool flag) {
            InitializeComponent();
            label1.Text = flag.Equals(true) ? "You don't have a Dark Souls 2 Backup Folder!" : "You don't have a Dark Souls 2 Save Folder!";
        }

        private void button1_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}