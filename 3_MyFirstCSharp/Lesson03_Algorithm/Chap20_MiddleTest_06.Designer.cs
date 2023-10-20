namespace MyFirstCSharp
{
    partial class Chap20_MiddleTest_06
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(17, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(786, 57);
            this.label1.TabIndex = 0;
            this.label1.Text = "N 번 이용하면 원래 이용료의 N 배를 받는 놀이기구가 있다고 할때\r\n가진 금액, 놀이기구 반복횟수, 놀이기구 최초 가격을 랜덤난수로 함수에 전달" +
    "하고\r\n\" AA 원이 있을때 이용요금 BB 인 놀이기구를 CC 번 타면 DD 원이 (모자랍니다. 또는 남습니다.) \" 를 메세지로 표현하세요\r\n" +
    "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("굴림", 10F);
            this.label3.Location = new System.Drawing.Point(18, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(565, 28);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ex ) 10000 원이 있을때 이용요금 100 원 인 놀이기구를 4번 타면 9000 원이 남습니다.\"\r\n    - 1회 100원,  2회 200" +
    "원,   3회 300원,   4회 400원  총 지출 금액 : 1000 원";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 12);
            this.label4.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("굴림", 10F);
            this.label5.Location = new System.Drawing.Point(18, 166);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(456, 42);
            this.label5.TabIndex = 4;
            this.label5.Text = "* 놀이기구 이용료는 최소 100 원부터 3000 원까지 랜덤하게 주어진다.\r\n* 놀이기구 타는 횟수는 1번부터 20번까지 랜덤하게 주어진다.\r\n" +
    "* 초기 금액은 1만원 에서 50만원 까지 랜덤하게 주어진다.";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(619, 104);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(184, 104);
            this.button1.TabIndex = 5;
            this.button1.Text = "부족 금액 계산";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Chap20_MiddleTest_06
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "Chap20_MiddleTest_06";
            this.Text = "Chap20_MiddleTest_06";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
    }
}