namespace MyFirstCSharp
{
    partial class Chap09_StringManage_Test
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(13, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(595, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "안녕하세요 2023 제조혁신 인재양성 S/W 개발 교육과정을 이수하게 된 OOO  입니다. \r\n즐겁고 보람찬 DIGITALTRANING 교육이 되" +
    "었으면 합니다.";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(43, 66);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(215, 95);
            this.button1.TabIndex = 1;
            this.button1.Text = "OOO -> 본인 이름으로 변경\r\n* 라벨 TEXT 에 직접 변경해서 표현";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(264, 66);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(215, 95);
            this.button2.TabIndex = 1;
            this.button2.Text = "\"S/W\" 의 위치를 찾고 메세지 박스 \r\n* 구현은 In Line으로 ";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(43, 167);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(215, 95);
            this.button3.TabIndex = 1;
            this.button3.Text = "시작 단어와 마지막 단어 각각 1자씩 \r\n메세지로 표현";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button2_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(264, 167);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(215, 95);
            this.button4.TabIndex = 1;
            this.button4.Text = "타이틀 문자열의 앞, 뒤에 \r\n\"-DT-\" 문자열 삽입\r\n* 라벨 TEXT 에 직접 변경해서 표현";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button2_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(43, 268);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(215, 95);
            this.button5.TabIndex = 1;
            this.button5.Text = "DIGITALTRANING 만 소문자로 변경\r\n* DIGITALTRANING  문자는 고정\r\n* 라벨 TEXT 에 직접 변경해서 표현";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button2_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(264, 268);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(215, 95);
            this.button6.TabIndex = 1;
            this.button6.Text = "타이틀의 문자열의 모든 공백 없애기\r\n* 라벨 TEXT 에 직접 변경해서 표현";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button2_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(43, 369);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(436, 95);
            this.button7.TabIndex = 1;
            this.button7.Text = "원본 문자열로 바꾸기";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button2_Click);
            // 
            // Chap09_StringManage_Test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 552);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "Chap09_StringManage_Test";
            this.Text = "문자열 다루기";
            this.Load += new System.EventHandler(this.Chap09_StringManage_Test_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
    }
}