﻿namespace MyFirstCSharp
{
    partial class Chap33_Struct
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
            this.btnStruct = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnStruct
            // 
            this.btnStruct.Location = new System.Drawing.Point(105, 87);
            this.btnStruct.Name = "btnStruct";
            this.btnStruct.Size = new System.Drawing.Size(312, 130);
            this.btnStruct.TabIndex = 0;
            this.btnStruct.Text = "구조체";
            this.btnStruct.UseVisualStyleBackColor = true;
            this.btnStruct.Click += new System.EventHandler(this.btnStruct_Click);
            // 
            // Chap33_Struct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 303);
            this.Controls.Add(this.btnStruct);
            this.Name = "Chap33_Struct";
            this.Text = "구조체";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnStruct;
    }
}