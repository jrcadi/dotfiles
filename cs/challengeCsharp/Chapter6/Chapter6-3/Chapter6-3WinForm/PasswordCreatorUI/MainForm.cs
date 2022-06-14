using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PasswordCreator;

namespace PasswordCreatorUI {
    public partial class MainForm : Form {
        private Controller controller;
        public MainForm() {
            InitializeComponent();
            controller = new Controller();
            NumOfLetters.Value = 12;
            NumOfLetters.Minimum = 10;
            NumOfLetters.Maximum = 32;
            this.Text = "Password Creator";
            Password.Font = new Font("Meiryo", 14);
            All.Checked = true;
        }
        private void NumOfLetters_ValueChanged(object sender, EventArgs e) {
            controller.NumOfLetters = (int)NumOfLetters.Value;
        }
        private void Execute_Click(object sender, EventArgs e) {
            string pw = controller.MakePassword();
            Password.Text = pw;
            Clipboard.SetText(pw);  //クリップボードにコピー
        }
        private void All_CheckedChanged(object sender, EventArgs e) {
            controller.IsAll = All.Checked;
        }
        private void NonMark_CheckedChanged(object sender, EventArgs e) {
            controller.IsNonMark = NonMark.Checked;
        }
        private void Mark2_CheckedChanged(object sender, EventArgs e) {
            controller.IsMark2 = Mark2.Checked;
        }
    }
}
