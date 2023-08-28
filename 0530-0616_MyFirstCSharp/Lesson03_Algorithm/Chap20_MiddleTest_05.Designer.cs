namespace MyFirstCSharp
{
    partial class Chap20_MiddleTest_05
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
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AllowDrop = true;
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("맑은 고딕", 13F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(16, 84);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(772, 25);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "동해물과?백두산이 마르고닳?도록 하느님이 보우하사?우리 나라만세?무궁화 삼천리? 화려강산";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(580, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "아래의 문자열 중 첫번째 ?와 세번째 ?의 index를 찾아 각 index 의 합에 있는 index 문자열 3자리를 구하여\r\n \"XXX\"라는 문자" +
    "열로 치환 후 텍스트 박스에 표현하세요\r\n";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(21, 126);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(214, 44);
            this.button1.TabIndex = 2;
            this.button1.Text = "변경하기";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(21, 176);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(418, 21);
            this.textBox1.TabIndex = 3;
            // 
            // Chap20_MiddleTest_05
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblTitle);
            this.Name = "Chap20_MiddleTest_05";
            this.Text = "Index 위치 찾기 및 문자 바꾸기";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
    }
}