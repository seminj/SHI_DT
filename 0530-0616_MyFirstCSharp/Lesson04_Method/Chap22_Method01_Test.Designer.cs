namespace MyFirstCSharp
{
    partial class Chap22_Method01_Test
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtbox1 = new System.Windows.Forms.TextBox();
            this.txtbox2 = new System.Windows.Forms.TextBox();
            this.btnTwo_M = new System.Windows.Forms.Button();
            this.btnF_M = new System.Windows.Forms.Button();
            this.btnTen_M = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 11F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(102, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(568, 80);
            this.label1.TabIndex = 0;
            this.label1.Text = "반복문을 (For, While) 한 번만 코딩하여 (소스내에서 반복문이 한번만 보이도록)\r\n범위 안의 수 중 2, 5, 10의 배수의 합을 각 버" +
    "튼 클릭하여 메세지박스로 표현하세요\r\n  * 텍스트 박스의 문자는 숫자만 입력\r\n  * 음수는 입력받을 수 없다. ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(202, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "입력 받을 범위";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(399, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "~";
            // 
            // txtbox1
            // 
            this.txtbox1.Location = new System.Drawing.Point(293, 174);
            this.txtbox1.Name = "txtbox1";
            this.txtbox1.Size = new System.Drawing.Size(100, 21);
            this.txtbox1.TabIndex = 3;
            // 
            // txtbox2
            // 
            this.txtbox2.Location = new System.Drawing.Point(419, 174);
            this.txtbox2.Name = "txtbox2";
            this.txtbox2.Size = new System.Drawing.Size(100, 21);
            this.txtbox2.TabIndex = 4;
            // 
            // btnTwo_M
            // 
            this.btnTwo_M.Location = new System.Drawing.Point(180, 219);
            this.btnTwo_M.Name = "btnTwo_M";
            this.btnTwo_M.Size = new System.Drawing.Size(107, 55);
            this.btnTwo_M.TabIndex = 5;
            this.btnTwo_M.Text = "2의 배수 표현";
            this.btnTwo_M.UseVisualStyleBackColor = true;
            this.btnTwo_M.Click += new System.EventHandler(this.btnTwo_M_Click);
            // 
            // btnF_M
            // 
            this.btnF_M.Location = new System.Drawing.Point(309, 219);
            this.btnF_M.Name = "btnF_M";
            this.btnF_M.Size = new System.Drawing.Size(107, 55);
            this.btnF_M.TabIndex = 6;
            this.btnF_M.Text = "5의 배수 표현";
            this.btnF_M.UseVisualStyleBackColor = true;
            this.btnF_M.Click += new System.EventHandler(this.btnF_M_Click);
            // 
            // btnTen_M
            // 
            this.btnTen_M.Location = new System.Drawing.Point(448, 219);
            this.btnTen_M.Name = "btnTen_M";
            this.btnTen_M.Size = new System.Drawing.Size(107, 55);
            this.btnTen_M.TabIndex = 7;
            this.btnTen_M.Text = "10의 배수 표현";
            this.btnTen_M.UseVisualStyleBackColor = true;
            this.btnTen_M.Click += new System.EventHandler(this.btnTen_M_Click);
            // 
            // Chap22_Method01_Test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnTen_M);
            this.Controls.Add(this.btnF_M);
            this.Controls.Add(this.btnTwo_M);
            this.Controls.Add(this.txtbox2);
            this.Controls.Add(this.txtbox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Chap22_Method01_Test";
            this.Text = "메서드 응용하기";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtbox1;
        private System.Windows.Forms.TextBox txtbox2;
        private System.Windows.Forms.Button btnTwo_M;
        private System.Windows.Forms.Button btnF_M;
        private System.Windows.Forms.Button btnTen_M;
    }
}