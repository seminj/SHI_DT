﻿namespace MyFirstCSharp
{
    partial class Chap06_StringChange
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtLower = new System.Windows.Forms.TextBox();
            this.btnLower = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtUpper = new System.Windows.Forms.TextBox();
            this.btnToUpper = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtInsert = new System.Windows.Forms.TextBox();
            this.btnInsert = new System.Windows.Forms.Button();
            this.txtIndex = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtString = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnTrim = new System.Windows.Forms.Button();
            this.txtTrim = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.txtStartTrim = new System.Windows.Forms.TextBox();
            this.btnStartTrim = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.txtEndTrim = new System.Windows.Forms.TextBox();
            this.btnEndTrim = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("맑은 고딕", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblTitle.Location = new System.Drawing.Point(89, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(580, 28);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "        abcde ABCDE fghij FGHIJ abcde ABCDE fghij FGHIJ   ";
            this.lblTitle.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtLower);
            this.groupBox1.Controls.Add(this.btnLower);
            this.groupBox1.Location = new System.Drawing.Point(29, 62);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(742, 70);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ToLower()";
            // 
            // txtLower
            // 
            this.txtLower.Location = new System.Drawing.Point(22, 41);
            this.txtLower.Name = "txtLower";
            this.txtLower.Size = new System.Drawing.Size(707, 21);
            this.txtLower.TabIndex = 1;
            // 
            // btnLower
            // 
            this.btnLower.Location = new System.Drawing.Point(22, 11);
            this.btnLower.Name = "btnLower";
            this.btnLower.Size = new System.Drawing.Size(107, 24);
            this.btnLower.TabIndex = 0;
            this.btnLower.Text = "변형하기";
            this.btnLower.UseVisualStyleBackColor = true;
            this.btnLower.Click += new System.EventHandler(this.btnLower_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtUpper);
            this.groupBox2.Controls.Add(this.btnToUpper);
            this.groupBox2.Location = new System.Drawing.Point(30, 146);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(740, 66);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "ToUpper()";
            // 
            // txtUpper
            // 
            this.txtUpper.Location = new System.Drawing.Point(21, 39);
            this.txtUpper.Name = "txtUpper";
            this.txtUpper.Size = new System.Drawing.Size(707, 21);
            this.txtUpper.TabIndex = 2;
            // 
            // btnToUpper
            // 
            this.btnToUpper.Location = new System.Drawing.Point(21, 14);
            this.btnToUpper.Name = "btnToUpper";
            this.btnToUpper.Size = new System.Drawing.Size(107, 19);
            this.btnToUpper.TabIndex = 0;
            this.btnToUpper.Text = "변형하기";
            this.btnToUpper.UseVisualStyleBackColor = true;
            this.btnToUpper.Click += new System.EventHandler(this.btnToUpper_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtInsert);
            this.groupBox3.Controls.Add(this.btnInsert);
            this.groupBox3.Controls.Add(this.txtIndex);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.txtString);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(29, 224);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(740, 76);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Insert()";
            // 
            // txtInsert
            // 
            this.txtInsert.Location = new System.Drawing.Point(8, 47);
            this.txtInsert.Name = "txtInsert";
            this.txtInsert.Size = new System.Drawing.Size(721, 21);
            this.txtInsert.TabIndex = 5;
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(568, 10);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(144, 31);
            this.btnInsert.TabIndex = 4;
            this.btnInsert.Text = "삽입하기";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // txtIndex
            // 
            this.txtIndex.Location = new System.Drawing.Point(301, 14);
            this.txtIndex.Name = "txtIndex";
            this.txtIndex.Size = new System.Drawing.Size(203, 21);
            this.txtIndex.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(266, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "위치";
            // 
            // txtString
            // 
            this.txtString.Location = new System.Drawing.Point(53, 14);
            this.txtString.Name = "txtString";
            this.txtString.Size = new System.Drawing.Size(192, 21);
            this.txtString.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "문자열";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtTrim);
            this.groupBox4.Controls.Add(this.btnTrim);
            this.groupBox4.Location = new System.Drawing.Point(30, 307);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(741, 92);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Trim()";
            // 
            // btnTrim
            // 
            this.btnTrim.Location = new System.Drawing.Point(8, 20);
            this.btnTrim.Name = "btnTrim";
            this.btnTrim.Size = new System.Drawing.Size(139, 32);
            this.btnTrim.TabIndex = 0;
            this.btnTrim.Text = "삭제하기";
            this.btnTrim.UseVisualStyleBackColor = true;
            this.btnTrim.Click += new System.EventHandler(this.btnTrim_Click);
            // 
            // txtTrim
            // 
            this.txtTrim.Location = new System.Drawing.Point(8, 58);
            this.txtTrim.Name = "txtTrim";
            this.txtTrim.Size = new System.Drawing.Size(720, 21);
            this.txtTrim.TabIndex = 1;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.txtStartTrim);
            this.groupBox5.Controls.Add(this.btnStartTrim);
            this.groupBox5.Location = new System.Drawing.Point(29, 405);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(741, 92);
            this.groupBox5.TabIndex = 5;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "StartTrim()";
            // 
            // txtStartTrim
            // 
            this.txtStartTrim.Location = new System.Drawing.Point(8, 58);
            this.txtStartTrim.Name = "txtStartTrim";
            this.txtStartTrim.Size = new System.Drawing.Size(720, 21);
            this.txtStartTrim.TabIndex = 1;
            // 
            // btnStartTrim
            // 
            this.btnStartTrim.Location = new System.Drawing.Point(8, 20);
            this.btnStartTrim.Name = "btnStartTrim";
            this.btnStartTrim.Size = new System.Drawing.Size(139, 32);
            this.btnStartTrim.TabIndex = 0;
            this.btnStartTrim.Text = "삭제하기";
            this.btnStartTrim.UseVisualStyleBackColor = true;
            this.btnStartTrim.Click += new System.EventHandler(this.txtStartTrim_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.txtEndTrim);
            this.groupBox6.Controls.Add(this.btnEndTrim);
            this.groupBox6.Location = new System.Drawing.Point(30, 503);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(741, 92);
            this.groupBox6.TabIndex = 6;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "EndTrim()";
            // 
            // txtEndTrim
            // 
            this.txtEndTrim.Location = new System.Drawing.Point(8, 58);
            this.txtEndTrim.Name = "txtEndTrim";
            this.txtEndTrim.Size = new System.Drawing.Size(720, 21);
            this.txtEndTrim.TabIndex = 1;
            // 
            // btnEndTrim
            // 
            this.btnEndTrim.Location = new System.Drawing.Point(8, 20);
            this.btnEndTrim.Name = "btnEndTrim";
            this.btnEndTrim.Size = new System.Drawing.Size(139, 32);
            this.btnEndTrim.TabIndex = 0;
            this.btnEndTrim.Text = "삭제하기";
            this.btnEndTrim.UseVisualStyleBackColor = true;
            this.btnEndTrim.Click += new System.EventHandler(this.btnEndTrim_Click);
            // 
            // Chap06_StringChange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 675);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblTitle);
            this.Name = "Chap06_StringChange";
            this.Text = "문자열 바꾸기";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtLower;
        private System.Windows.Forms.Button btnLower;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtUpper;
        private System.Windows.Forms.Button btnToUpper;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtIndex;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtString;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtInsert;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtTrim;
        private System.Windows.Forms.Button btnTrim;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox txtStartTrim;
        private System.Windows.Forms.Button btnStartTrim;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TextBox txtEndTrim;
        private System.Windows.Forms.Button btnEndTrim;
    }
}