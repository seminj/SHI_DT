
namespace MyFirstCSharp
{
    partial class Chap18_While
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
            this.button1 = new System.Windows.Forms.Button();
            this.btnWhileNoExit = new System.Windows.Forms.Button();
            this.btnDoWhile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(104, 90);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(174, 85);
            this.button1.TabIndex = 0;
            this.button1.Text = "While";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnWhileNoExit
            // 
            this.btnWhileNoExit.Location = new System.Drawing.Point(284, 90);
            this.btnWhileNoExit.Name = "btnWhileNoExit";
            this.btnWhileNoExit.Size = new System.Drawing.Size(174, 85);
            this.btnWhileNoExit.TabIndex = 1;
            this.btnWhileNoExit.Text = "무한 루프";
            this.btnWhileNoExit.UseVisualStyleBackColor = true;
            this.btnWhileNoExit.Click += new System.EventHandler(this.btnWhileNoExit_Click);
            // 
            // btnDoWhile
            // 
            this.btnDoWhile.Location = new System.Drawing.Point(464, 90);
            this.btnDoWhile.Name = "btnDoWhile";
            this.btnDoWhile.Size = new System.Drawing.Size(174, 85);
            this.btnDoWhile.TabIndex = 2;
            this.btnDoWhile.Text = "Do While";
            this.btnDoWhile.UseVisualStyleBackColor = true;
            this.btnDoWhile.Click += new System.EventHandler(this.btnDoWhile_Click);
            // 
            // Chap18_While
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDoWhile);
            this.Controls.Add(this.btnWhileNoExit);
            this.Controls.Add(this.button1);
            this.Name = "Chap18_While";
            this.Text = "반복문 While";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnWhileNoExit;
        private System.Windows.Forms.Button btnDoWhile;
    }
}