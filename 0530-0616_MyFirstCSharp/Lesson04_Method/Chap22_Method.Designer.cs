namespace MyFirstCSharp
{
    partial class Chap22_Method
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
            this.btnMethod = new System.Windows.Forms.Button();
            this.btnPaAr = new System.Windows.Forms.Button();
            this.btnVoidReturn = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.btnStringReturn = new System.Windows.Forms.Button();
            this.btnIntReturn = new System.Windows.Forms.Button();
            this.btnDefaultParameter = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCatch2 = new System.Windows.Forms.Button();
            this.btnCatch1 = new System.Windows.Forms.Button();
            this.btnArrayArgument = new System.Windows.Forms.Button();
            this.btnArrayReturn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnMethod
            // 
            this.btnMethod.Location = new System.Drawing.Point(53, 92);
            this.btnMethod.Name = "btnMethod";
            this.btnMethod.Size = new System.Drawing.Size(128, 69);
            this.btnMethod.TabIndex = 0;
            this.btnMethod.Text = "메서드 호출";
            this.btnMethod.UseVisualStyleBackColor = true;
            this.btnMethod.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnPaAr
            // 
            this.btnPaAr.Location = new System.Drawing.Point(187, 92);
            this.btnPaAr.Name = "btnPaAr";
            this.btnPaAr.Size = new System.Drawing.Size(128, 69);
            this.btnPaAr.TabIndex = 1;
            this.btnPaAr.Text = "인수와 인자";
            this.btnPaAr.UseVisualStyleBackColor = true;
            this.btnPaAr.Click += new System.EventHandler(this.btnPaAr_Click);
            // 
            // btnVoidReturn
            // 
            this.btnVoidReturn.Location = new System.Drawing.Point(53, 167);
            this.btnVoidReturn.Name = "btnVoidReturn";
            this.btnVoidReturn.Size = new System.Drawing.Size(128, 69);
            this.btnVoidReturn.TabIndex = 2;
            this.btnVoidReturn.Text = "Void Return";
            this.btnVoidReturn.UseVisualStyleBackColor = true;
            this.btnVoidReturn.Click += new System.EventHandler(this.btnVoidReturn_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(57, 46);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(38, 12);
            this.lblTitle.TabIndex = 3;
            this.lblTitle.Text = "label1";
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(187, 43);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(100, 21);
            this.txtTitle.TabIndex = 4;
            // 
            // btnStringReturn
            // 
            this.btnStringReturn.Location = new System.Drawing.Point(187, 167);
            this.btnStringReturn.Name = "btnStringReturn";
            this.btnStringReturn.Size = new System.Drawing.Size(128, 69);
            this.btnStringReturn.TabIndex = 5;
            this.btnStringReturn.Text = "String Return";
            this.btnStringReturn.UseVisualStyleBackColor = true;
            this.btnStringReturn.Click += new System.EventHandler(this.btnStringReturn_Click);
            // 
            // btnIntReturn
            // 
            this.btnIntReturn.Location = new System.Drawing.Point(321, 167);
            this.btnIntReturn.Name = "btnIntReturn";
            this.btnIntReturn.Size = new System.Drawing.Size(128, 69);
            this.btnIntReturn.TabIndex = 6;
            this.btnIntReturn.Text = "int Return";
            this.btnIntReturn.UseVisualStyleBackColor = true;
            this.btnIntReturn.Click += new System.EventHandler(this.btnIntReturn_Click);
            // 
            // btnDefaultParameter
            // 
            this.btnDefaultParameter.Location = new System.Drawing.Point(455, 167);
            this.btnDefaultParameter.Name = "btnDefaultParameter";
            this.btnDefaultParameter.Size = new System.Drawing.Size(128, 69);
            this.btnDefaultParameter.TabIndex = 7;
            this.btnDefaultParameter.Text = "Default Parameter";
            this.btnDefaultParameter.UseVisualStyleBackColor = true;
            this.btnDefaultParameter.Click += new System.EventHandler(this.btnDefaultParameter_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCatch2);
            this.groupBox1.Controls.Add(this.btnCatch1);
            this.groupBox1.Location = new System.Drawing.Point(53, 254);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(530, 100);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "클래스를 인수로 전달하는 경우";
            // 
            // btnCatch2
            // 
            this.btnCatch2.Location = new System.Drawing.Point(140, 20);
            this.btnCatch2.Name = "btnCatch2";
            this.btnCatch2.Size = new System.Drawing.Size(128, 69);
            this.btnCatch2.TabIndex = 10;
            this.btnCatch2.UseVisualStyleBackColor = true;
            this.btnCatch2.Click += new System.EventHandler(this.btnCatch2_Click);
            // 
            // btnCatch1
            // 
            this.btnCatch1.Location = new System.Drawing.Point(6, 20);
            this.btnCatch1.Name = "btnCatch1";
            this.btnCatch1.Size = new System.Drawing.Size(128, 69);
            this.btnCatch1.TabIndex = 9;
            this.btnCatch1.Text = "나 잡아봐라~";
            this.btnCatch1.UseVisualStyleBackColor = true;
            this.btnCatch1.Click += new System.EventHandler(this.btnCatch1_Click);
            // 
            // btnArrayArgument
            // 
            this.btnArrayArgument.Location = new System.Drawing.Point(53, 360);
            this.btnArrayArgument.Name = "btnArrayArgument";
            this.btnArrayArgument.Size = new System.Drawing.Size(128, 69);
            this.btnArrayArgument.TabIndex = 11;
            this.btnArrayArgument.Text = "ArrayArgument";
            this.btnArrayArgument.UseVisualStyleBackColor = true;
            this.btnArrayArgument.Click += new System.EventHandler(this.btnArrayArgument_Click);
            // 
            // btnArrayReturn
            // 
            this.btnArrayReturn.Location = new System.Drawing.Point(187, 360);
            this.btnArrayReturn.Name = "btnArrayReturn";
            this.btnArrayReturn.Size = new System.Drawing.Size(128, 69);
            this.btnArrayReturn.TabIndex = 12;
            this.btnArrayReturn.Text = "ArrayReturn";
            this.btnArrayReturn.UseVisualStyleBackColor = true;
            this.btnArrayReturn.Click += new System.EventHandler(this.btnArrayReturn_Click);
            // 
            // Chap22_Method
            // 
            this.ClientSize = new System.Drawing.Size(800, 529);
            this.Controls.Add(this.btnArrayReturn);
            this.Controls.Add(this.btnArrayArgument);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnDefaultParameter);
            this.Controls.Add(this.btnIntReturn);
            this.Controls.Add(this.btnStringReturn);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnVoidReturn);
            this.Controls.Add(this.btnPaAr);
            this.Controls.Add(this.btnMethod);
            this.Name = "Chap22_Method";
            this.Text = "Chap22_Method";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMethod;
        private System.Windows.Forms.Button btnPaAr;
        private System.Windows.Forms.Button btnVoidReturn;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Button btnStringReturn;
        private System.Windows.Forms.Button btnIntReturn;
        private System.Windows.Forms.Button btnDefaultParameter;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCatch1;
        private System.Windows.Forms.Button btnCatch2;
        private System.Windows.Forms.Button btnArrayArgument;
        private System.Windows.Forms.Button btnArrayReturn;
    }
}