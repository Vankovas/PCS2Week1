using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PCS_2___Week_1 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {

        }

        private void button1_Click(object sender, EventArgs e) {
            MessageBox.Show("My name is Ivan");
        }

        private void progressBar1_Click(object sender, EventArgs e) {

        }

        private void trackBar1_Scroll(object sender, EventArgs e) {
            progressBar1.Value = trackBar1.Value;
            this.label1.Text = this.trackBar1.Value.ToString();
        }

        private void redRadio_CheckedChanged(object sender, EventArgs e) {
            if (redRadio.Checked == true) {
                this.label1.ForeColor = Color.Red;
            }
        }

        private void label1_Click(object sender, EventArgs e) {

        }

        private void imageBtn_CheckedChanged(object sender, EventArgs e) {
            if (this.imageBtn.Checked == true) {
                Image myimage = new Bitmap(@"D:\Programming\C#\PCS\Second Block\PCS 2 - Week 1\177.jpg");
                this.BackgroundImage = myimage;
            }
        }
    }
}
