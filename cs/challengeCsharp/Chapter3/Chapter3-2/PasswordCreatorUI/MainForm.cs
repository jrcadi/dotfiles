﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        }

        private void Execute_Click(object sender, EventArgs e) {
            string pw = controller.MakePassword();
            Password.Text = pw;
        }
        private void NumOfLetters_ValueChanged(object sender, EventArgs e) {
            controller.NumOfLetters = (int)NumOfLetters.Value;
        }
    }
}
