namespace Week1___Exercise_2 {
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
            this.inputLeft = new System.Windows.Forms.TextBox();
            this.inputRight = new System.Windows.Forms.TextBox();
            this.resultLeft = new System.Windows.Forms.TextBox();
            this.ResultRight = new System.Windows.Forms.TextBox();
            this.ALabel = new System.Windows.Forms.Label();
            this.BLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.result = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // inputLeft
            // 
            this.inputLeft.Location = new System.Drawing.Point(12, 23);
            this.inputLeft.Name = "inputLeft";
            this.inputLeft.Size = new System.Drawing.Size(100, 20);
            this.inputLeft.TabIndex = 0;
            // 
            // inputRight
            // 
            this.inputRight.Location = new System.Drawing.Point(172, 23);
            this.inputRight.Name = "inputRight";
            this.inputRight.Size = new System.Drawing.Size(100, 20);
            this.inputRight.TabIndex = 1;
            // 
            // resultLeft
            // 
            this.resultLeft.Location = new System.Drawing.Point(12, 67);
            this.resultLeft.Name = "resultLeft";
            this.resultLeft.Size = new System.Drawing.Size(100, 20);
            this.resultLeft.TabIndex = 2;
            // 
            // ResultRight
            // 
            this.ResultRight.Location = new System.Drawing.Point(172, 67);
            this.ResultRight.Name = "ResultRight";
            this.ResultRight.Size = new System.Drawing.Size(100, 20);
            this.ResultRight.TabIndex = 3;
            // 
            // ALabel
            // 
            this.ALabel.AutoSize = true;
            this.ALabel.Location = new System.Drawing.Point(50, 7);
            this.ALabel.Name = "ALabel";
            this.ALabel.Size = new System.Drawing.Size(17, 13);
            this.ALabel.TabIndex = 4;
            this.ALabel.Text = "A:";
            // 
            // BLabel
            // 
            this.BLabel.AutoSize = true;
            this.BLabel.Location = new System.Drawing.Point(209, 7);
            this.BLabel.Name = "BLabel";
            this.BLabel.Size = new System.Drawing.Size(17, 13);
            this.BLabel.TabIndex = 5;
            this.BLabel.Text = "B:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "A/B";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(212, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "A%B";
            // 
            // result
            // 
            this.result.Location = new System.Drawing.Point(111, 107);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(75, 23);
            this.result.TabIndex = 8;
            this.result.Text = "Result";
            this.result.UseVisualStyleBackColor = true;
            this.result.Click += new System.EventHandler(this.result_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 152);
            this.Controls.Add(this.result);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BLabel);
            this.Controls.Add(this.ALabel);
            this.Controls.Add(this.ResultRight);
            this.Controls.Add(this.resultLeft);
            this.Controls.Add(this.inputRight);
            this.Controls.Add(this.inputLeft);
            this.Name = "Form1";
            this.Text = "Assignment Dividing";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox inputLeft;
        private System.Windows.Forms.TextBox inputRight;
        private System.Windows.Forms.TextBox resultLeft;
        private System.Windows.Forms.TextBox ResultRight;
        private System.Windows.Forms.Label ALabel;
        private System.Windows.Forms.Label BLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button result;
    }
}

