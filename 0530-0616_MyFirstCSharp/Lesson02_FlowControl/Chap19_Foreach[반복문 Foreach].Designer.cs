﻿
namespace MyFirstCSharp
{
    partial class Chap19_Foreach
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
            this.btnStringForeach = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtInputWord = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.grpControls = new System.Windows.Forms.GroupBox();
            this.textBox17 = new System.Windows.Forms.TextBox();
            this.textBox18 = new System.Windows.Forms.TextBox();
            this.textBox19 = new System.Windows.Forms.TextBox();
            this.textBox20 = new System.Windows.Forms.TextBox();
            this.textBox21 = new System.Windows.Forms.TextBox();
            this.textBox22 = new System.Windows.Forms.TextBox();
            this.textBox23 = new System.Windows.Forms.TextBox();
            this.textBox24 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.textBox14 = new System.Windows.Forms.TextBox();
            this.textBox15 = new System.Windows.Forms.TextBox();
            this.textBox16 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAllClear = new System.Windows.Forms.Button();
            this.grpControls.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnStringForeach
            // 
            this.btnStringForeach.Location = new System.Drawing.Point(35, 43);
            this.btnStringForeach.Name = "btnStringForeach";
            this.btnStringForeach.Size = new System.Drawing.Size(195, 129);
            this.btnStringForeach.TabIndex = 0;
            this.btnStringForeach.Text = "string Foreach";
            this.btnStringForeach.UseVisualStyleBackColor = true;
            this.btnStringForeach.Click += new System.EventHandler(this.btnStringForeach_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(250, 69);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(214, 12);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            // 
            // txtInputWord
            // 
            this.txtInputWord.Location = new System.Drawing.Point(267, 98);
            this.txtInputWord.Name = "txtInputWord";
            this.txtInputWord.Size = new System.Drawing.Size(100, 21);
            this.txtInputWord.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "1. 문자 포함 여부 판단하기";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(497, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "2. 배열에서 데이터 추출하기";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(499, 44);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(195, 129);
            this.button1.TabIndex = 6;
            this.button1.Text = "Array Foreach";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // grpControls
            // 
            this.grpControls.Controls.Add(this.textBox17);
            this.grpControls.Controls.Add(this.textBox18);
            this.grpControls.Controls.Add(this.textBox19);
            this.grpControls.Controls.Add(this.textBox20);
            this.grpControls.Controls.Add(this.textBox21);
            this.grpControls.Controls.Add(this.textBox22);
            this.grpControls.Controls.Add(this.textBox23);
            this.grpControls.Controls.Add(this.textBox24);
            this.grpControls.Controls.Add(this.textBox9);
            this.grpControls.Controls.Add(this.textBox10);
            this.grpControls.Controls.Add(this.textBox11);
            this.grpControls.Controls.Add(this.textBox12);
            this.grpControls.Controls.Add(this.textBox13);
            this.grpControls.Controls.Add(this.textBox14);
            this.grpControls.Controls.Add(this.textBox15);
            this.grpControls.Controls.Add(this.textBox16);
            this.grpControls.Controls.Add(this.textBox5);
            this.grpControls.Controls.Add(this.textBox6);
            this.grpControls.Controls.Add(this.textBox7);
            this.grpControls.Controls.Add(this.textBox8);
            this.grpControls.Controls.Add(this.textBox3);
            this.grpControls.Controls.Add(this.textBox4);
            this.grpControls.Controls.Add(this.textBox2);
            this.grpControls.Controls.Add(this.textBox1);
            this.grpControls.Controls.Add(this.label3);
            this.grpControls.Controls.Add(this.btnAllClear);
            this.grpControls.Location = new System.Drawing.Point(35, 193);
            this.grpControls.Name = "grpControls";
            this.grpControls.Size = new System.Drawing.Size(697, 391);
            this.grpControls.TabIndex = 7;
            this.grpControls.TabStop = false;
            this.grpControls.Text = "컨테이너 도구 모음";
            // 
            // textBox17
            // 
            this.textBox17.Location = new System.Drawing.Point(453, 270);
            this.textBox17.Name = "textBox17";
            this.textBox17.Size = new System.Drawing.Size(204, 21);
            this.textBox17.TabIndex = 32;
            this.textBox17.Text = "안녕하세요";
            // 
            // textBox18
            // 
            this.textBox18.Location = new System.Drawing.Point(453, 243);
            this.textBox18.Name = "textBox18";
            this.textBox18.Size = new System.Drawing.Size(204, 21);
            this.textBox18.TabIndex = 31;
            this.textBox18.Text = "안녕하세요";
            // 
            // textBox19
            // 
            this.textBox19.Location = new System.Drawing.Point(453, 216);
            this.textBox19.Name = "textBox19";
            this.textBox19.Size = new System.Drawing.Size(204, 21);
            this.textBox19.TabIndex = 30;
            this.textBox19.Text = "안녕하세요";
            // 
            // textBox20
            // 
            this.textBox20.Location = new System.Drawing.Point(453, 189);
            this.textBox20.Name = "textBox20";
            this.textBox20.Size = new System.Drawing.Size(204, 21);
            this.textBox20.TabIndex = 29;
            this.textBox20.Text = "안녕하세요";
            // 
            // textBox21
            // 
            this.textBox21.Location = new System.Drawing.Point(453, 162);
            this.textBox21.Name = "textBox21";
            this.textBox21.Size = new System.Drawing.Size(204, 21);
            this.textBox21.TabIndex = 28;
            this.textBox21.Text = "안녕하세요";
            // 
            // textBox22
            // 
            this.textBox22.Location = new System.Drawing.Point(453, 135);
            this.textBox22.Name = "textBox22";
            this.textBox22.Size = new System.Drawing.Size(204, 21);
            this.textBox22.TabIndex = 27;
            this.textBox22.Text = "안녕하세요";
            // 
            // textBox23
            // 
            this.textBox23.Location = new System.Drawing.Point(453, 108);
            this.textBox23.Name = "textBox23";
            this.textBox23.Size = new System.Drawing.Size(204, 21);
            this.textBox23.TabIndex = 26;
            this.textBox23.Text = "안녕하세요";
            // 
            // textBox24
            // 
            this.textBox24.Location = new System.Drawing.Point(453, 81);
            this.textBox24.Name = "textBox24";
            this.textBox24.Size = new System.Drawing.Size(204, 21);
            this.textBox24.TabIndex = 25;
            this.textBox24.Text = "안녕하세요";
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(243, 270);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(204, 21);
            this.textBox9.TabIndex = 24;
            this.textBox9.Text = "안녕하세요";
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(243, 243);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(204, 21);
            this.textBox10.TabIndex = 23;
            this.textBox10.Text = "안녕하세요";
            // 
            // textBox11
            // 
            this.textBox11.Location = new System.Drawing.Point(243, 216);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(204, 21);
            this.textBox11.TabIndex = 22;
            this.textBox11.Text = "안녕하세요";
            // 
            // textBox12
            // 
            this.textBox12.Location = new System.Drawing.Point(243, 189);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(204, 21);
            this.textBox12.TabIndex = 21;
            this.textBox12.Text = "안녕하세요";
            // 
            // textBox13
            // 
            this.textBox13.Location = new System.Drawing.Point(243, 162);
            this.textBox13.Name = "textBox13";
            this.textBox13.Size = new System.Drawing.Size(204, 21);
            this.textBox13.TabIndex = 20;
            this.textBox13.Text = "안녕하세요";
            // 
            // textBox14
            // 
            this.textBox14.Location = new System.Drawing.Point(243, 135);
            this.textBox14.Name = "textBox14";
            this.textBox14.Size = new System.Drawing.Size(204, 21);
            this.textBox14.TabIndex = 19;
            this.textBox14.Text = "안녕하세요";
            // 
            // textBox15
            // 
            this.textBox15.Location = new System.Drawing.Point(243, 108);
            this.textBox15.Name = "textBox15";
            this.textBox15.Size = new System.Drawing.Size(204, 21);
            this.textBox15.TabIndex = 18;
            this.textBox15.Text = "안녕하세요";
            // 
            // textBox16
            // 
            this.textBox16.Location = new System.Drawing.Point(243, 81);
            this.textBox16.Name = "textBox16";
            this.textBox16.Size = new System.Drawing.Size(204, 21);
            this.textBox16.TabIndex = 17;
            this.textBox16.Text = "안녕하세요";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(33, 270);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(204, 21);
            this.textBox5.TabIndex = 16;
            this.textBox5.Text = "안녕하세요";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(33, 243);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(204, 21);
            this.textBox6.TabIndex = 15;
            this.textBox6.Text = "안녕하세요";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(33, 216);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(204, 21);
            this.textBox7.TabIndex = 14;
            this.textBox7.Text = "안녕하세요";
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(33, 189);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(204, 21);
            this.textBox8.TabIndex = 13;
            this.textBox8.Text = "안녕하세요";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(33, 162);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(204, 21);
            this.textBox3.TabIndex = 12;
            this.textBox3.Text = "안녕하세요";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(33, 135);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(204, 21);
            this.textBox4.TabIndex = 11;
            this.textBox4.Text = "안녕하세요";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(33, 108);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(204, 21);
            this.textBox2.TabIndex = 10;
            this.textBox2.Text = "안녕하세요";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(33, 81);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(204, 21);
            this.textBox1.TabIndex = 9;
            this.textBox1.Text = "안녕하세요";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(173, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(383, 12);
            this.label3.TabIndex = 8;
            this.label3.Text = "컨테이너에 포함된 도구(Control) 중에 텍스트 박스를 일괄 초기화하기\r\n";
            // 
            // btnAllClear
            // 
            this.btnAllClear.Location = new System.Drawing.Point(33, 33);
            this.btnAllClear.Name = "btnAllClear";
            this.btnAllClear.Size = new System.Drawing.Size(116, 39);
            this.btnAllClear.TabIndex = 8;
            this.btnAllClear.Text = "일괄 초기화";
            this.btnAllClear.UseVisualStyleBackColor = true;
            this.btnAllClear.Click += new System.EventHandler(this.btnAllClear_Click);
            // 
            // Chap19_Foreach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 625);
            this.Controls.Add(this.grpControls);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtInputWord);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnStringForeach);
            this.Name = "Chap19_Foreach";
            this.Text = "반복문 Foreach";
            this.grpControls.ResumeLayout(false);
            this.grpControls.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStringForeach;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtInputWord;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox grpControls;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAllClear;
        private System.Windows.Forms.TextBox textBox17;
        private System.Windows.Forms.TextBox textBox18;
        private System.Windows.Forms.TextBox textBox19;
        private System.Windows.Forms.TextBox textBox20;
        private System.Windows.Forms.TextBox textBox21;
        private System.Windows.Forms.TextBox textBox22;
        private System.Windows.Forms.TextBox textBox23;
        private System.Windows.Forms.TextBox textBox24;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.TextBox textBox13;
        private System.Windows.Forms.TextBox textBox14;
        private System.Windows.Forms.TextBox textBox15;
        private System.Windows.Forms.TextBox textBox16;
    }
}