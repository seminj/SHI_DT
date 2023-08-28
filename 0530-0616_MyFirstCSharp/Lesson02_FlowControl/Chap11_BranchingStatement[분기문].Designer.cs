namespace MyFirstCSharp
{
    partial class Chap11_BranchingStatement
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
            this.btnIF = new System.Windows.Forms.Button();
            this.txtBS = new System.Windows.Forms.TextBox();
            this.btnInIf = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnAndIf = new System.Windows.Forms.Button();
            this.btnORIf = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnPM = new System.Windows.Forms.Button();
            this.btnDO = new System.Windows.Forms.Button();
            this.btnTernaryOperator = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnIF
            // 
            this.btnIF.Location = new System.Drawing.Point(67, 72);
            this.btnIF.Name = "btnIF";
            this.btnIF.Size = new System.Drawing.Size(200, 91);
            this.btnIF.TabIndex = 0;
            this.btnIF.Text = "IF";
            this.btnIF.UseVisualStyleBackColor = true;
            this.btnIF.Click += new System.EventHandler(this.btnIF_Click);
            // 
            // txtBS
            // 
            this.txtBS.Location = new System.Drawing.Point(67, 45);
            this.txtBS.Name = "txtBS";
            this.txtBS.Size = new System.Drawing.Size(200, 21);
            this.txtBS.TabIndex = 1;
            this.txtBS.TextChanged += new System.EventHandler(this.txtBs_TextChanged);
            // 
            // btnInIf
            // 
            this.btnInIf.Location = new System.Drawing.Point(273, 72);
            this.btnInIf.Name = "btnInIf";
            this.btnInIf.Size = new System.Drawing.Size(200, 91);
            this.btnInIf.TabIndex = 0;
            this.btnInIf.Text = "In IF";
            this.btnInIf.UseVisualStyleBackColor = true;
            this.btnInIf.Click += new System.EventHandler(this.btnInIf_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(479, 72);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 91);
            this.button1.TabIndex = 2;
            this.button1.Text = "else IF";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnElseIf_Click);
            // 
            // btnAndIf
            // 
            this.btnAndIf.Location = new System.Drawing.Point(67, 169);
            this.btnAndIf.Name = "btnAndIf";
            this.btnAndIf.Size = new System.Drawing.Size(200, 91);
            this.btnAndIf.TabIndex = 3;
            this.btnAndIf.Text = "And IF";
            this.btnAndIf.UseVisualStyleBackColor = true;
            this.btnAndIf.Click += new System.EventHandler(this.btnAndIf_Click);
            // 
            // btnORIf
            // 
            this.btnORIf.Location = new System.Drawing.Point(273, 169);
            this.btnORIf.Name = "btnORIf";
            this.btnORIf.Size = new System.Drawing.Size(200, 91);
            this.btnORIf.TabIndex = 4;
            this.btnORIf.Text = "OR IF";
            this.btnORIf.UseVisualStyleBackColor = true;
            this.btnORIf.Click += new System.EventHandler(this.btnORIf_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(479, 169);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(200, 91);
            this.button2.TabIndex = 5;
            this.button2.Text = "Bool IF";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btnBoolIf_Click);
            // 
            // btnPM
            // 
            this.btnPM.Location = new System.Drawing.Point(67, 266);
            this.btnPM.Name = "btnPM";
            this.btnPM.Size = new System.Drawing.Size(200, 91);
            this.btnPM.TabIndex = 6;
            this.btnPM.Text = "음수/양수 판단";
            this.btnPM.UseVisualStyleBackColor = true;
            this.btnPM.Click += new System.EventHandler(this.btnPM_Click);
            // 
            // btnDO
            // 
            this.btnDO.Location = new System.Drawing.Point(273, 266);
            this.btnDO.Name = "btnDO";
            this.btnDO.Size = new System.Drawing.Size(200, 91);
            this.btnDO.TabIndex = 7;
            this.btnDO.Text = "홀수/짝수 판단";
            this.btnDO.UseVisualStyleBackColor = true;
            this.btnDO.Click += new System.EventHandler(this.btnDO_Click);
            // 
            // btnTernaryOperator
            // 
            this.btnTernaryOperator.Location = new System.Drawing.Point(479, 266);
            this.btnTernaryOperator.Name = "btnTernaryOperator";
            this.btnTernaryOperator.Size = new System.Drawing.Size(200, 91);
            this.btnTernaryOperator.TabIndex = 8;
            this.btnTernaryOperator.Text = "삼항 연산자";
            this.btnTernaryOperator.UseVisualStyleBackColor = true;
            this.btnTernaryOperator.Click += new System.EventHandler(this.btnTernaryOperator_Click);
            // 
            // Chap11_BranchingStatement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnTernaryOperator);
            this.Controls.Add(this.btnDO);
            this.Controls.Add(this.btnPM);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnORIf);
            this.Controls.Add(this.btnAndIf);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtBS);
            this.Controls.Add(this.btnInIf);
            this.Controls.Add(this.btnIF);
            this.Name = "Chap11_BranchingStatement";
            this.Text = "Chap11_BranchingStatement";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnIF;
        private System.Windows.Forms.TextBox txtBS;
        private System.Windows.Forms.Button btnInIf;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnAndIf;
        private System.Windows.Forms.Button btnORIf;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnPM;
        private System.Windows.Forms.Button btnDO;
        private System.Windows.Forms.Button btnTernaryOperator;
    }
}