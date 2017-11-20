namespace PCS_2___Week_1 {
    partial class Form1 {
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
            this.button1 = new System.Windows.Forms.Button();
            this.redRadio = new System.Windows.Forms.RadioButton();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.imageBtn = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Gold;
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(108, 226);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Who am I";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // redRadio
            // 
            this.redRadio.AutoSize = true;
            this.redRadio.Location = new System.Drawing.Point(13, 229);
            this.redRadio.Name = "redRadio";
            this.redRadio.Size = new System.Drawing.Size(77, 17);
            this.redRadio.TabIndex = 1;
            this.redRadio.TabStop = true;
            this.redRadio.Text = "make it red";
            this.redRadio.UseVisualStyleBackColor = true;
            this.redRadio.CheckedChanged += new System.EventHandler(this.redRadio_CheckedChanged);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(13, 58);
            this.trackBar1.Maximum = 100;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(259, 45);
            this.trackBar1.TabIndex = 2;
            this.trackBar1.Value = 50;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 12);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(260, 39);
            this.progressBar1.TabIndex = 3;
            this.progressBar1.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label1.Location = new System.Drawing.Point(131, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "0";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // imageBtn
            // 
            this.imageBtn.AutoSize = true;
            this.imageBtn.Location = new System.Drawing.Point(209, 229);
            this.imageBtn.Name = "imageBtn";
            this.imageBtn.Size = new System.Drawing.Size(54, 17);
            this.imageBtn.TabIndex = 5;
            this.imageBtn.TabStop = true;
            this.imageBtn.Text = "Magic";
            this.imageBtn.UseVisualStyleBackColor = true;
            this.imageBtn.CheckedChanged += new System.EventHandler(this.imageBtn_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.imageBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.redRadio);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Assignment";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton redRadio;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton imageBtn;
    }
}

