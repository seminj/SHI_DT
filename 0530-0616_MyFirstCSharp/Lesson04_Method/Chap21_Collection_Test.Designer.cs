namespace MyFirstCSharp
{
    partial class Chap21_Collection_Test
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
            this.label2 = new System.Windows.Forms.Label();
            this.btnResult1 = new System.Windows.Forms.Button();
            this.btnLastOf = new System.Windows.Forms.Button();
            this.btnDictionary = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(139, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(497, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "아래 문자열에서 중복되지 않는 문자 중 왼쪽에서 가장 첫 문자를 메세지 박스로 나타내세요";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("맑은 고딕", 13F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(293, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(194, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "ABCLD/EML/BAMDC/";
            // 
            // btnResult1
            // 
            this.btnResult1.Location = new System.Drawing.Point(234, 121);
            this.btnResult1.Name = "btnResult1";
            this.btnResult1.Size = new System.Drawing.Size(296, 63);
            this.btnResult1.TabIndex = 2;
            this.btnResult1.Text = "자유코딩";
            this.btnResult1.UseVisualStyleBackColor = true;
            // 
            // btnLastOf
            // 
            this.btnLastOf.Location = new System.Drawing.Point(234, 190);
            this.btnLastOf.Name = "btnLastOf";
            this.btnLastOf.Size = new System.Drawing.Size(296, 63);
            this.btnLastOf.TabIndex = 3;
            this.btnLastOf.Text = "LastindexOf() 방식";
            this.btnLastOf.UseVisualStyleBackColor = true;
            // 
            // btnDictionary
            // 
            this.btnDictionary.Location = new System.Drawing.Point(234, 259);
            this.btnDictionary.Name = "btnDictionary";
            this.btnDictionary.Size = new System.Drawing.Size(296, 63);
            this.btnDictionary.TabIndex = 4;
            this.btnDictionary.Text = "Dictionary와 Foreach를 사용";
            this.btnDictionary.UseVisualStyleBackColor = true;
            this.btnDictionary.Click += new System.EventHandler(this.btnDictionary_Click);
            // 
            // Chap21_Collection_Test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDictionary);
            this.Controls.Add(this.btnLastOf);
            this.Controls.Add(this.btnResult1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Chap21_Collection_Test";
            this.Text = "Collection을 이용한 중복 찾기";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnResult1;
        private System.Windows.Forms.Button btnLastOf;
        private System.Windows.Forms.Button btnDictionary;
    }
}