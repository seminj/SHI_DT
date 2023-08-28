namespace MyFirstCSharp
{
    partial class Chap20_MiddleTest_05_T
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
            this.btnResult = new System.Windows.Forms.Button();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("맑은 고딕", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblTitle.Location = new System.Drawing.Point(17, 57);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(772, 25);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "동해물과?백두산이 마르고닳?도록 하느님이 보우하사?우리 나라만세?무궁화 삼천리? 화려강산";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 31);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(892, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "아래의 문자열 중 첫번째 ? 와 세번째 ? 의 index 를 찾아각 index 의 합에 있는 index 문자열 3자리를 구하여 \"XXX\" 라는 문" +
    "자열로 치환후 텍스트 박스에 표현하세요.";
            // 
            // btnResult
            // 
            this.btnResult.Location = new System.Drawing.Point(21, 93);
            this.btnResult.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnResult.Name = "btnResult";
            this.btnResult.Size = new System.Drawing.Size(208, 34);
            this.btnResult.TabIndex = 2;
            this.btnResult.Text = "변경하기";
            this.btnResult.UseVisualStyleBackColor = true;
            this.btnResult.Click += new System.EventHandler(this.btnResult_Click);
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(21, 139);
            this.txtResult.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(918, 21);
            this.txtResult.TabIndex = 3;
            // 
            // Chap20_MiddleTest_05_T
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 173);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.btnResult);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblTitle);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Chap20_MiddleTest_05_T";
            this.Text = "Index 위치 찾기 및 문자 바꾸기";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnResult;
        private System.Windows.Forms.TextBox txtResult;
    }
}