﻿namespace MyFirstCSharp
{
    partial class Chap20_MiddleTest_08_T
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.btnResult = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(36, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(413, 57);
            this.label1.TabIndex = 0;
            this.label1.Text = "아래의 수를 내림차순으로 정렬하여 텍스트 박스에 표현 하세요 \r\n * Array.Sort , Revers 기능 사용하지 말것. \r\n   { 1, " +
    " 11,  6,   20,   11 ,  8 ,  12,  6,  16,   13,  22 }";
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(40, 137);
            this.txtResult.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(411, 21);
            this.txtResult.TabIndex = 1;
            // 
            // btnResult
            // 
            this.btnResult.Location = new System.Drawing.Point(38, 97);
            this.btnResult.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnResult.Name = "btnResult";
            this.btnResult.Size = new System.Drawing.Size(410, 36);
            this.btnResult.TabIndex = 2;
            this.btnResult.Text = "정렬하기";
            this.btnResult.UseVisualStyleBackColor = true;
            this.btnResult.Click += new System.EventHandler(this.btnResult_Click);
            // 
            // Chap20_MiddleTest_08_T
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 168);
            this.Controls.Add(this.btnResult);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Chap20_MiddleTest_08_T";
            this.Text = "버블정렬 내림차순";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Button btnResult;
    }
}