
namespace MyFirstCSharp
{
    partial class Chap12_IF
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Chap12_IF));
            this.label4 = new System.Windows.Forms.Label();
            this.txtBtnClickCount = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEMultiValue = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnJudge = new System.Windows.Forms.Button();
            this.txtInputValue = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(153, 215);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(419, 144);
            this.label4.TabIndex = 15;
            this.label4.Text = resources.GetString("label4.Text");
            // 
            // txtBtnClickCount
            // 
            this.txtBtnClickCount.Location = new System.Drawing.Point(306, 158);
            this.txtBtnClickCount.Margin = new System.Windows.Forms.Padding(2);
            this.txtBtnClickCount.Name = "txtBtnClickCount";
            this.txtBtnClickCount.Size = new System.Drawing.Size(157, 21);
            this.txtBtnClickCount.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(170, 160);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 12);
            this.label3.TabIndex = 13;
            this.label3.Text = "버튼을 클릭한 총 횟수";
            // 
            // txtEMultiValue
            // 
            this.txtEMultiValue.Location = new System.Drawing.Point(306, 127);
            this.txtEMultiValue.Margin = new System.Windows.Forms.Padding(2);
            this.txtEMultiValue.Name = "txtEMultiValue";
            this.txtEMultiValue.Size = new System.Drawing.Size(157, 21);
            this.txtEMultiValue.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(142, 129);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 12);
            this.label2.TabIndex = 11;
            this.label2.Text = "8의 배수 일 경우 값과의 곱";
            // 
            // btnJudge
            // 
            this.btnJudge.Location = new System.Drawing.Point(466, 92);
            this.btnJudge.Margin = new System.Windows.Forms.Padding(2);
            this.btnJudge.Name = "btnJudge";
            this.btnJudge.Size = new System.Drawing.Size(193, 23);
            this.btnJudge.TabIndex = 10;
            this.btnJudge.Text = "2 , 5 의 공배수 인지 판단";
            this.btnJudge.UseVisualStyleBackColor = true;
            this.btnJudge.Click += new System.EventHandler(this.btnJudge_Click);
            // 
            // txtInputValue
            // 
            this.txtInputValue.Location = new System.Drawing.Point(306, 95);
            this.txtInputValue.Margin = new System.Windows.Forms.Padding(2);
            this.txtInputValue.Name = "txtInputValue";
            this.txtInputValue.Size = new System.Drawing.Size(157, 21);
            this.txtInputValue.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(229, 97);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 12);
            this.label1.TabIndex = 8;
            this.label1.Text = "입력 받을값";
            // 
            // Chap12_IF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtBtnClickCount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtEMultiValue);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnJudge);
            this.Controls.Add(this.txtInputValue);
            this.Controls.Add(this.label1);
            this.Name = "Chap12_IF";
            this.Text = "Chap12_IF";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBtnClickCount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEMultiValue;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnJudge;
        private System.Windows.Forms.TextBox txtInputValue;
        private System.Windows.Forms.Label label1;
    }
}