namespace MyFirstCSharp
{
    partial class Chap30_Class_F
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
            this.btnClassCall1 = new System.Windows.Forms.Button();
            this.btnClassCall2 = new System.Windows.Forms.Button();
            this.btnFieldsCall = new System.Windows.Forms.Button();
            this.btnFieldsCall2 = new System.Windows.Forms.Button();
            this.btnClassMethodCall = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnClassCall1
            // 
            this.btnClassCall1.Location = new System.Drawing.Point(180, 12);
            this.btnClassCall1.Name = "btnClassCall1";
            this.btnClassCall1.Size = new System.Drawing.Size(435, 80);
            this.btnClassCall1.TabIndex = 0;
            this.btnClassCall1.Text = "클래스 객체 생성 및 호출";
            this.btnClassCall1.UseVisualStyleBackColor = true;
            this.btnClassCall1.Click += new System.EventHandler(this.btnClassCall1_Click);
            // 
            // btnClassCall2
            // 
            this.btnClassCall2.Location = new System.Drawing.Point(180, 98);
            this.btnClassCall2.Name = "btnClassCall2";
            this.btnClassCall2.Size = new System.Drawing.Size(435, 80);
            this.btnClassCall2.TabIndex = 1;
            this.btnClassCall2.Text = "클래스 객체 생성 및 호출 2";
            this.btnClassCall2.UseVisualStyleBackColor = true;
            this.btnClassCall2.Click += new System.EventHandler(this.btnFieldsCall2_Click_1);
            // 
            // btnFieldsCall
            // 
            this.btnFieldsCall.Location = new System.Drawing.Point(180, 184);
            this.btnFieldsCall.Name = "btnFieldsCall";
            this.btnFieldsCall.Size = new System.Drawing.Size(435, 80);
            this.btnFieldsCall.TabIndex = 2;
            this.btnFieldsCall.Text = "필드 멤버 객체 전역변수 호출1";
            this.btnFieldsCall.UseVisualStyleBackColor = true;
            this.btnFieldsCall.Click += new System.EventHandler(this.btnFieldsCall3_Click_1);
            // 
            // btnFieldsCall2
            // 
            this.btnFieldsCall2.Location = new System.Drawing.Point(180, 270);
            this.btnFieldsCall2.Name = "btnFieldsCall2";
            this.btnFieldsCall2.Size = new System.Drawing.Size(435, 80);
            this.btnFieldsCall2.TabIndex = 3;
            this.btnFieldsCall2.Text = "필드 멤버 객체 전역변수 호출2\r\n";
            this.btnFieldsCall2.UseVisualStyleBackColor = true;
            this.btnFieldsCall2.Click += new System.EventHandler(this.btnFieldsCall2_Click);
            // 
            // btnClassMethodCall
            // 
            this.btnClassMethodCall.Location = new System.Drawing.Point(180, 358);
            this.btnClassMethodCall.Name = "btnClassMethodCall";
            this.btnClassMethodCall.Size = new System.Drawing.Size(435, 80);
            this.btnClassMethodCall.TabIndex = 4;
            this.btnClassMethodCall.Text = "다른 클래스의 객체 호출하기";
            this.btnClassMethodCall.UseVisualStyleBackColor = true;
            this.btnClassMethodCall.Click += new System.EventHandler(this.btnClassMethodCall_Click);
            // 
            // Chap30_Class_F
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnClassMethodCall);
            this.Controls.Add(this.btnFieldsCall2);
            this.Controls.Add(this.btnFieldsCall);
            this.Controls.Add(this.btnClassCall2);
            this.Controls.Add(this.btnClassCall1);
            this.Name = "Chap30_Class_F";
            this.Text = "클래스";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClassCall1;
        private System.Windows.Forms.Button btnClassCall2;
        private System.Windows.Forms.Button btnFieldsCall;
        private System.Windows.Forms.Button btnFieldsCall2;
        private System.Windows.Forms.Button btnClassMethodCall;
    }
}