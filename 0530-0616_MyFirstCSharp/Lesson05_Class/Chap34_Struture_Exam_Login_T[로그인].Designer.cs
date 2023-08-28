namespace MyFirstCSharp
{ 
    partial class Chap34_Struture_Exam_Login_T
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Chap34_Struture_Exam_Login_T));
            this.label1 = new System.Windows.Forms.Label();
            this.txtUserId = new System.Windows.Forms.TextBox();
            this.txtPassWord = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnlogin = new System.Windows.Forms.Button();
            this.btnUserReg = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "사용자 ID";
            // 
            // txtUserId
            // 
            this.txtUserId.Location = new System.Drawing.Point(66, 13);
            this.txtUserId.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtUserId.Name = "txtUserId";
            this.txtUserId.Size = new System.Drawing.Size(160, 21);
            this.txtUserId.TabIndex = 1;
            // 
            // txtPassWord
            // 
            this.txtPassWord.Location = new System.Drawing.Point(66, 36);
            this.txtPassWord.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPassWord.Name = "txtPassWord";
            this.txtPassWord.PasswordChar = '*';
            this.txtPassWord.Size = new System.Drawing.Size(160, 21);
            this.txtPassWord.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 38);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "PW";
            // 
            // btnlogin
            // 
            this.btnlogin.Location = new System.Drawing.Point(74, 59);
            this.btnlogin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(66, 37);
            this.btnlogin.TabIndex = 4;
            this.btnlogin.Text = "로그인";
            this.btnlogin.UseVisualStyleBackColor = true;
            this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click);
            // 
            // btnUserReg
            // 
            this.btnUserReg.Location = new System.Drawing.Point(145, 59);
            this.btnUserReg.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnUserReg.Name = "btnUserReg";
            this.btnUserReg.Size = new System.Drawing.Size(80, 37);
            this.btnUserReg.TabIndex = 5;
            this.btnUserReg.Text = "사용자 등록";
            this.btnUserReg.UseVisualStyleBackColor = true;
            this.btnUserReg.Click += new System.EventHandler(this.btnUserReg_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(8, 117);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(546, 190);
            this.label3.TabIndex = 6;
            this.label3.Text = resources.GetString("label3.Text");
            // 
            // Chap34_Struture_Exam_Login_T
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 323);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnUserReg);
            this.Controls.Add(this.btnlogin);
            this.Controls.Add(this.txtPassWord);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtUserId);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Chap34_Struture_Exam_Login_T";
            this.Text = "사용자 로그인";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox txtUserId;
    private System.Windows.Forms.TextBox txtPassWord;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Button btnlogin;
    private System.Windows.Forms.Button btnUserReg;
    private System.Windows.Forms.Label label3;
}
}