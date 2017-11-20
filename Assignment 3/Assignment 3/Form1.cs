using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_3 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void euro_TextChanged(object sender, EventArgs e) {

        }

        private void dollar_TextChanged(object sender, EventArgs e) {

        }

        private void RtoL_Click(object sender, EventArgs e) {
            float temp1 = float.Parse(dollar.Text) / float.Parse(rate.Text);
            euro.Text = temp1.ToString();
        }

        private void LtoR_Click(object sender, EventArgs e) {
            float temp2 = float.Parse(euro.Text) * float.Parse(rate.Text);
            dollar.Text = temp2.ToString();
        }
    }
}
