using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week1___Exercise_2 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void result_Click(object sender, EventArgs e) {
            float left = int.Parse(inputLeft.Text) / float.Parse(inputRight.Text);
            float right = float.Parse(inputLeft.Text) % float.Parse(inputRight.Text);

            resultLeft.Text = left.ToString();
            ResultRight.Text = right.ToString();


            if (left != float.Parse(resultLeft.Text) || right != float.Parse(ResultRight.Text)) {
                MessageBox.Show("Something fucked up ???");
            }
        }
    }
}
