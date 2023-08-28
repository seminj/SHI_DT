namespace MyFirstCSharp
{
    partial class Chap20_MiddleTest_07
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
            this.lblText = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 10F);
            this.label1.Location = new System.Drawing.Point(88, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(380, 95);
            this.label1.TabIndex = 0;
            this.label1.Text = "랜덤함수 0부터 20까지의 수를 20개 받아와서 \r\n배열에 담고 오름차순으로 정렬하여 텍스트박스에 표현 후 \r\n\r\n배열에 나열된 수 중 (0~ 2" +
    "0) \r\n없는 수를 모두 합한 결과를 메세지 박스로 표현하세요";
            // 
            // lblText
            // 
            this.lblText.Location = new System.Drawing.Point(92, 240);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(376, 21);
            this.lblText.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(92, 183);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(376, 51);
            this.button1.TabIndex = 2;
            this.button1.Text = "없는 수 합하기";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Chap20_MiddleTest_07
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblText);
            this.Controls.Add(this.label1);
            this.Name = "Chap20_MiddleTest_07";
            this.Text = "누락된 숫자 구하기";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox lblText;
        private System.Windows.Forms.Button button1;
    }
}