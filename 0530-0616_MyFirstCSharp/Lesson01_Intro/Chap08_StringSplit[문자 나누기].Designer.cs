namespace MyFirstCSharp
{
    partial class Chap08_StringSplit
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnInterpolation = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnLength = new System.Windows.Forms.Button();
            this.txtLength = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSplit = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtIndex = new System.Windows.Forms.TextBox();
            this.txtCount = new System.Windows.Forms.TextBox();
            this.btnSubstring = new System.Windows.Forms.Button();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblTitle.Location = new System.Drawing.Point(31, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(240, 21);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "ABCDEFG/HIJKLMN/OPQRSTU";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnInterpolation);
            this.groupBox3.Location = new System.Drawing.Point(57, 71);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(187, 64);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "문자열 보간";
            // 
            // btnInterpolation
            // 
            this.btnInterpolation.Location = new System.Drawing.Point(7, 20);
            this.btnInterpolation.Name = "btnInterpolation";
            this.btnInterpolation.Size = new System.Drawing.Size(162, 33);
            this.btnInterpolation.TabIndex = 1;
            this.btnInterpolation.Text = "$";
            this.btnInterpolation.UseVisualStyleBackColor = true;
            this.btnInterpolation.Click += new System.EventHandler(this.btnInterpolation_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnLength);
            this.groupBox1.Controls.Add(this.txtLength);
            this.groupBox1.Location = new System.Drawing.Point(57, 181);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(187, 88);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Length";
            // 
            // btnLength
            // 
            this.btnLength.Location = new System.Drawing.Point(9, 44);
            this.btnLength.Name = "btnLength";
            this.btnLength.Size = new System.Drawing.Size(162, 33);
            this.btnLength.TabIndex = 1;
            this.btnLength.Text = "Length";
            this.btnLength.UseVisualStyleBackColor = true;
            this.btnLength.Click += new System.EventHandler(this.btnLength_Click);
            // 
            // txtLength
            // 
            this.txtLength.Location = new System.Drawing.Point(7, 17);
            this.txtLength.Name = "txtLength";
            this.txtLength.Size = new System.Drawing.Size(165, 21);
            this.txtLength.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnSplit);
            this.groupBox2.Location = new System.Drawing.Point(57, 309);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(187, 88);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Split";
            // 
            // btnSplit
            // 
            this.btnSplit.Location = new System.Drawing.Point(9, 44);
            this.btnSplit.Name = "btnSplit";
            this.btnSplit.Size = new System.Drawing.Size(162, 33);
            this.btnSplit.TabIndex = 1;
            this.btnSplit.Text = "Split";
            this.btnSplit.UseVisualStyleBackColor = true;
            this.btnSplit.Click += new System.EventHandler(this.btnSplit_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnSubstring);
            this.groupBox4.Controls.Add(this.txtCount);
            this.groupBox4.Controls.Add(this.txtIndex);
            this.groupBox4.Location = new System.Drawing.Point(57, 430);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(187, 100);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "groupBox4";
            // 
            // txtIndex
            // 
            this.txtIndex.Location = new System.Drawing.Point(6, 31);
            this.txtIndex.Name = "txtIndex";
            this.txtIndex.Size = new System.Drawing.Size(81, 21);
            this.txtIndex.TabIndex = 0;
            // 
            // txtCount
            // 
            this.txtCount.Location = new System.Drawing.Point(93, 31);
            this.txtCount.Name = "txtCount";
            this.txtCount.Size = new System.Drawing.Size(78, 21);
            this.txtCount.TabIndex = 1;
            // 
            // btnSubstring
            // 
            this.btnSubstring.Location = new System.Drawing.Point(10, 58);
            this.btnSubstring.Name = "btnSubstring";
            this.btnSubstring.Size = new System.Drawing.Size(162, 33);
            this.btnSubstring.TabIndex = 2;
            this.btnSubstring.Text = "Split";
            this.btnSubstring.UseVisualStyleBackColor = true;
            this.btnSubstring.Click += new System.EventHandler(this.button1_Click);
            // 
            // Chap08_StringSplit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 600);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.lblTitle);
            this.Name = "Chap08_StringSplit";
            this.Text = "SubString";
            this.groupBox3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnInterpolation;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnLength;
        private System.Windows.Forms.TextBox txtLength;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSplit;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnSubstring;
        private System.Windows.Forms.TextBox txtCount;
        private System.Windows.Forms.TextBox txtIndex;
    }
}