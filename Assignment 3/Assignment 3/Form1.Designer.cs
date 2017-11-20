namespace Assignment_3 {
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
            this.euro = new System.Windows.Forms.TextBox();
            this.dollar = new System.Windows.Forms.TextBox();
            this.RtoL = new System.Windows.Forms.Button();
            this.LtoR = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rate = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // euro
            // 
            this.euro.Location = new System.Drawing.Point(13, 13);
            this.euro.Name = "euro";
            this.euro.Size = new System.Drawing.Size(100, 20);
            this.euro.TabIndex = 0;
            this.euro.TextChanged += new System.EventHandler(this.euro_TextChanged);
            // 
            // dollar
            // 
            this.dollar.Location = new System.Drawing.Point(172, 13);
            this.dollar.Name = "dollar";
            this.dollar.Size = new System.Drawing.Size(100, 20);
            this.dollar.TabIndex = 1;
            this.dollar.TextChanged += new System.EventHandler(this.dollar_TextChanged);
            // 
            // RtoL
            // 
            this.RtoL.Location = new System.Drawing.Point(119, 13);
            this.RtoL.Name = "RtoL";
            this.RtoL.Size = new System.Drawing.Size(19, 20);
            this.RtoL.TabIndex = 2;
            this.RtoL.Text = "<";
            this.RtoL.UseVisualStyleBackColor = true;
            this.RtoL.Click += new System.EventHandler(this.RtoL_Click);
            // 
            // LtoR
            // 
            this.LtoR.Location = new System.Drawing.Point(147, 13);
            this.LtoR.Name = "LtoR";
            this.LtoR.Size = new System.Drawing.Size(19, 20);
            this.LtoR.TabIndex = 3;
            this.LtoR.Text = ">";
            this.LtoR.UseVisualStyleBackColor = true;
            this.LtoR.Click += new System.EventHandler(this.LtoR_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Euro";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(206, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Dollar";
            // 
            // rate
            // 
            this.rate.Location = new System.Drawing.Point(91, 58);
            this.rate.Name = "rate";
            this.rate.Size = new System.Drawing.Size(100, 20);
            this.rate.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 90);
            this.Controls.Add(this.rate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LtoR);
            this.Controls.Add(this.RtoL);
            this.Controls.Add(this.dollar);
            this.Controls.Add(this.euro);
            this.Name = "Form1";
            this.Text = "Euro - Dollar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox euro;
        private System.Windows.Forms.TextBox dollar;
        private System.Windows.Forms.Button RtoL;
        private System.Windows.Forms.Button LtoR;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox rate;
    }
}

