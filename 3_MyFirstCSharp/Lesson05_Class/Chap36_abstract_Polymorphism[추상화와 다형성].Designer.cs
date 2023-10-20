namespace MyFirstCSharp
{
    partial class Chap36_abstract_Polymorphism
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
            this.btnUserSearch = new System.Windows.Forms.Button();
            this.btnCustSearch = new System.Windows.Forms.Button();
            this.btnItemSearch = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(315, 75);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(208, 93);
            this.button1.TabIndex = 0;
            this.button1.Text = "추상화(abstract)";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnAbstract_Click);
            // 
            // btnUserSearch
            // 
            this.btnUserSearch.Location = new System.Drawing.Point(12, 20);
            this.btnUserSearch.Name = "btnUserSearch";
            this.btnUserSearch.Size = new System.Drawing.Size(208, 93);
            this.btnUserSearch.TabIndex = 1;
            this.btnUserSearch.Text = "사용자 정보 조회";
            this.btnUserSearch.UseVisualStyleBackColor = true;
            // 
            // btnCustSearch
            // 
            this.btnCustSearch.Location = new System.Drawing.Point(226, 20);
            this.btnCustSearch.Name = "btnCustSearch";
            this.btnCustSearch.Size = new System.Drawing.Size(208, 93);
            this.btnCustSearch.TabIndex = 2;
            this.btnCustSearch.Text = "고객 정보 조회";
            this.btnCustSearch.UseVisualStyleBackColor = true;
            // 
            // btnItemSearch
            // 
            this.btnItemSearch.Location = new System.Drawing.Point(440, 20);
            this.btnItemSearch.Name = "btnItemSearch";
            this.btnItemSearch.Size = new System.Drawing.Size(208, 93);
            this.btnItemSearch.TabIndex = 3;
            this.btnItemSearch.Text = "품목 정보 조회";
            this.btnItemSearch.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnItemSearch);
            this.groupBox1.Controls.Add(this.btnUserSearch);
            this.groupBox1.Controls.Add(this.btnCustSearch);
            this.groupBox1.Location = new System.Drawing.Point(89, 174);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(654, 123);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // Chap36_abstract_Polymorphism
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Name = "Chap36_abstract_Polymorphism";
            this.Text = "추상화와 다형성";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnUserSearch;
        private System.Windows.Forms.Button btnCustSearch;
        private System.Windows.Forms.Button btnItemSearch;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}