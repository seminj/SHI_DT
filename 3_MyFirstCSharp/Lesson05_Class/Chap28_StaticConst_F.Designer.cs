namespace MyFirstCSharp.MyFirstCSharp
{
    partial class Chap28_StaticConst_F
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
            this.btnStep1 = new System.Windows.Forms.Button();
            this.btnStep2 = new System.Windows.Forms.Button();
            this.btnStep3 = new System.Windows.Forms.Button();
            this.btnStatic = new System.Windows.Forms.Button();
            this.btnStaticCall = new System.Windows.Forms.Button();
            this.btnMethod = new System.Windows.Forms.Button();
            this.btnConst = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnStep1
            // 
            this.btnStep1.Location = new System.Drawing.Point(31, 38);
            this.btnStep1.Name = "btnStep1";
            this.btnStep1.Size = new System.Drawing.Size(212, 118);
            this.btnStep1.TabIndex = 0;
            this.btnStep1.Text = "안녕하세요";
            this.btnStep1.UseVisualStyleBackColor = true;
            this.btnStep1.Click += new System.EventHandler(this.btnStep1_Click);
            // 
            // btnStep2
            // 
            this.btnStep2.Location = new System.Drawing.Point(249, 38);
            this.btnStep2.Name = "btnStep2";
            this.btnStep2.Size = new System.Drawing.Size(212, 118);
            this.btnStep2.TabIndex = 1;
            this.btnStep2.Text = "반갑습니다. ";
            this.btnStep2.UseVisualStyleBackColor = true;
            this.btnStep2.Click += new System.EventHandler(this.btnStep2_Click);
            // 
            // btnStep3
            // 
            this.btnStep3.Location = new System.Drawing.Point(467, 38);
            this.btnStep3.Name = "btnStep3";
            this.btnStep3.Size = new System.Drawing.Size(212, 118);
            this.btnStep3.TabIndex = 2;
            this.btnStep3.Text = "C# 프로그래밍";
            this.btnStep3.UseVisualStyleBackColor = true;
            this.btnStep3.Click += new System.EventHandler(this.btnStep3_Click);
            // 
            // btnStatic
            // 
            this.btnStatic.Location = new System.Drawing.Point(31, 162);
            this.btnStatic.Name = "btnStatic";
            this.btnStatic.Size = new System.Drawing.Size(212, 63);
            this.btnStatic.TabIndex = 3;
            this.btnStatic.Text = "정적 /인스턴스 필드에 값 대입";
            this.btnStatic.UseVisualStyleBackColor = true;
            this.btnStatic.Click += new System.EventHandler(this.btnStatic_Click);
            // 
            // btnStaticCall
            // 
            this.btnStaticCall.Location = new System.Drawing.Point(249, 162);
            this.btnStaticCall.Name = "btnStaticCall";
            this.btnStaticCall.Size = new System.Drawing.Size(212, 63);
            this.btnStaticCall.TabIndex = 4;
            this.btnStaticCall.Text = "정적 /인스턴스 필드에 값 호출";
            this.btnStaticCall.UseVisualStyleBackColor = true;
            this.btnStaticCall.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnMethod
            // 
            this.btnMethod.Location = new System.Drawing.Point(31, 231);
            this.btnMethod.Name = "btnMethod";
            this.btnMethod.Size = new System.Drawing.Size(212, 63);
            this.btnMethod.TabIndex = 5;
            this.btnMethod.Text = "정적 메서드";
            this.btnMethod.UseVisualStyleBackColor = true;
            this.btnMethod.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnConst
            // 
            this.btnConst.Location = new System.Drawing.Point(249, 231);
            this.btnConst.Name = "btnConst";
            this.btnConst.Size = new System.Drawing.Size(212, 63);
            this.btnConst.TabIndex = 6;
            this.btnConst.Text = "상수";
            this.btnConst.UseVisualStyleBackColor = true;
            this.btnConst.Click += new System.EventHandler(this.btnConst_Click);
            // 
            // Chap28_StaticConst_F
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnConst);
            this.Controls.Add(this.btnMethod);
            this.Controls.Add(this.btnStaticCall);
            this.Controls.Add(this.btnStatic);
            this.Controls.Add(this.btnStep3);
            this.Controls.Add(this.btnStep2);
            this.Controls.Add(this.btnStep1);
            this.Name = "Chap28_StaticConst_F";
            this.Text = "Static 생성자와 상수";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnStep1;
        private System.Windows.Forms.Button btnStep2;
        private System.Windows.Forms.Button btnStep3;
        private System.Windows.Forms.Button btnStatic;
        private System.Windows.Forms.Button btnStaticCall;
        private System.Windows.Forms.Button btnMethod;
        private System.Windows.Forms.Button btnConst;
    }
}