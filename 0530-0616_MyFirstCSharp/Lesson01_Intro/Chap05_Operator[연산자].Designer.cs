namespace MyFirstCSharp
{
    partial class Chap05_Operator
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnEqual = new System.Windows.Forms.Button();
            this.btnSumEqual = new System.Windows.Forms.Button();
            this.btnMinEqual = new System.Windows.Forms.Button();
            this.btnMulEqual = new System.Windows.Forms.Button();
            this.btnDivEqual = new System.Windows.Forms.Button();
            this.btnPerEqual = new System.Windows.Forms.Button();
            this.btnSS = new System.Windows.Forms.Button();
            this.btsmm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnEqual
            // 
            this.btnEqual.Location = new System.Drawing.Point(59, 50);
            this.btnEqual.Name = "btnEqual";
            this.btnEqual.Size = new System.Drawing.Size(186, 103);
            this.btnEqual.TabIndex = 0;
            this.btnEqual.Text = "=";
            this.btnEqual.UseVisualStyleBackColor = true;
            this.btnEqual.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSumEqual
            // 
            this.btnSumEqual.Location = new System.Drawing.Point(296, 50);
            this.btnSumEqual.Name = "btnSumEqual";
            this.btnSumEqual.Size = new System.Drawing.Size(186, 103);
            this.btnSumEqual.TabIndex = 1;
            this.btnSumEqual.Text = "+=";
            this.btnSumEqual.UseVisualStyleBackColor = true;
            this.btnSumEqual.Click += new System.EventHandler(this.btnSumEqual_Click);
            // 
            // btnMinEqual
            // 
            this.btnMinEqual.Location = new System.Drawing.Point(59, 177);
            this.btnMinEqual.Name = "btnMinEqual";
            this.btnMinEqual.Size = new System.Drawing.Size(186, 102);
            this.btnMinEqual.TabIndex = 2;
            this.btnMinEqual.Text = "-=";
            this.btnMinEqual.UseVisualStyleBackColor = true;
            this.btnMinEqual.Click += new System.EventHandler(this.btnMinEqual_Click);
            // 
            // btnMulEqual
            // 
            this.btnMulEqual.Location = new System.Drawing.Point(296, 177);
            this.btnMulEqual.Name = "btnMulEqual";
            this.btnMulEqual.Size = new System.Drawing.Size(186, 102);
            this.btnMulEqual.TabIndex = 3;
            this.btnMulEqual.Text = "*=";
            this.btnMulEqual.UseVisualStyleBackColor = true;
            this.btnMulEqual.Click += new System.EventHandler(this.btnMulEqual_Click);
            // 
            // btnDivEqual
            // 
            this.btnDivEqual.Location = new System.Drawing.Point(59, 310);
            this.btnDivEqual.Name = "btnDivEqual";
            this.btnDivEqual.Size = new System.Drawing.Size(186, 102);
            this.btnDivEqual.TabIndex = 4;
            this.btnDivEqual.Text = "/=";
            this.btnDivEqual.UseVisualStyleBackColor = true;
            this.btnDivEqual.Click += new System.EventHandler(this.btnDivEqual_Click);
            // 
            // btnPerEqual
            // 
            this.btnPerEqual.Location = new System.Drawing.Point(296, 310);
            this.btnPerEqual.Name = "btnPerEqual";
            this.btnPerEqual.Size = new System.Drawing.Size(186, 102);
            this.btnPerEqual.TabIndex = 5;
            this.btnPerEqual.Text = "%=";
            this.btnPerEqual.UseVisualStyleBackColor = true;
            this.btnPerEqual.Click += new System.EventHandler(this.btnPerEqual_Click);
            // 
            // btnSS
            // 
            this.btnSS.Location = new System.Drawing.Point(59, 437);
            this.btnSS.Name = "btnSS";
            this.btnSS.Size = new System.Drawing.Size(186, 102);
            this.btnSS.TabIndex = 6;
            this.btnSS.Text = "++";
            this.btnSS.UseVisualStyleBackColor = true;
            this.btnSS.Click += new System.EventHandler(this.btnSS_Click);
            // 
            // btsmm
            // 
            this.btsmm.Location = new System.Drawing.Point(296, 437);
            this.btsmm.Name = "btsmm";
            this.btsmm.Size = new System.Drawing.Size(186, 102);
            this.btsmm.TabIndex = 7;
            this.btsmm.Text = "--";
            this.btsmm.UseVisualStyleBackColor = true;
            this.btsmm.Click += new System.EventHandler(this.btsmm_Click);
            // 
            // Chap05_Operator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 568);
            this.Controls.Add(this.btsmm);
            this.Controls.Add(this.btnSS);
            this.Controls.Add(this.btnPerEqual);
            this.Controls.Add(this.btnDivEqual);
            this.Controls.Add(this.btnMulEqual);
            this.Controls.Add(this.btnMinEqual);
            this.Controls.Add(this.btnSumEqual);
            this.Controls.Add(this.btnEqual);
            this.Name = "Chap05_Operator";
            this.Text = "연산자 대입";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEqual;
        private System.Windows.Forms.Button btnSumEqual;
        private System.Windows.Forms.Button btnMinEqual;
        private System.Windows.Forms.Button btnMulEqual;
        private System.Windows.Forms.Button btnDivEqual;
        private System.Windows.Forms.Button btnPerEqual;
        private System.Windows.Forms.Button btnSS;
        private System.Windows.Forms.Button btsmm;
    }
}