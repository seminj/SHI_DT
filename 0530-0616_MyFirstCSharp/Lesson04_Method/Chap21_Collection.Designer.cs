namespace MyFirstCSharp
{
    partial class Chap21_Collection
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
            this.btnList = new System.Windows.Forms.Button();
            this.btnListII = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnQueue = new System.Windows.Forms.Button();
            this.btnStack = new System.Windows.Forms.Button();
            this.btnDictionary = new System.Windows.Forms.Button();
            this.btnHashTable = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnList
            // 
            this.btnList.Font = new System.Drawing.Font("굴림", 15F, System.Drawing.FontStyle.Bold);
            this.btnList.Location = new System.Drawing.Point(68, 38);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(169, 84);
            this.btnList.TabIndex = 0;
            this.btnList.Text = "List";
            this.btnList.UseVisualStyleBackColor = true;
            this.btnList.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnListII
            // 
            this.btnListII.Location = new System.Drawing.Point(243, 38);
            this.btnListII.Name = "btnListII";
            this.btnListII.Size = new System.Drawing.Size(169, 84);
            this.btnListII.TabIndex = 1;
            this.btnListII.Text = "List II";
            this.btnListII.UseVisualStyleBackColor = true;
            this.btnListII.Click += new System.EventHandler(this.btnListII_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(68, 128);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(169, 84);
            this.button1.TabIndex = 2;
            this.button1.Text = "ArrayList";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnQueue
            // 
            this.btnQueue.Location = new System.Drawing.Point(68, 218);
            this.btnQueue.Name = "btnQueue";
            this.btnQueue.Size = new System.Drawing.Size(169, 84);
            this.btnQueue.TabIndex = 3;
            this.btnQueue.Text = "Queue";
            this.btnQueue.UseVisualStyleBackColor = true;
            this.btnQueue.Click += new System.EventHandler(this.btnQueue_Click);
            // 
            // btnStack
            // 
            this.btnStack.Location = new System.Drawing.Point(243, 218);
            this.btnStack.Name = "btnStack";
            this.btnStack.Size = new System.Drawing.Size(169, 84);
            this.btnStack.TabIndex = 4;
            this.btnStack.Text = "Stack";
            this.btnStack.UseVisualStyleBackColor = true;
            this.btnStack.Click += new System.EventHandler(this.btnStack_Click);
            // 
            // btnDictionary
            // 
            this.btnDictionary.Font = new System.Drawing.Font("굴림", 15F, System.Drawing.FontStyle.Bold);
            this.btnDictionary.Location = new System.Drawing.Point(68, 308);
            this.btnDictionary.Name = "btnDictionary";
            this.btnDictionary.Size = new System.Drawing.Size(169, 84);
            this.btnDictionary.TabIndex = 5;
            this.btnDictionary.Text = "Dictionary";
            this.btnDictionary.UseVisualStyleBackColor = true;
            this.btnDictionary.Click += new System.EventHandler(this.btnDictionary_Click);
            // 
            // btnHashTable
            // 
            this.btnHashTable.Location = new System.Drawing.Point(243, 308);
            this.btnHashTable.Name = "btnHashTable";
            this.btnHashTable.Size = new System.Drawing.Size(169, 84);
            this.btnHashTable.TabIndex = 6;
            this.btnHashTable.Text = "HashTable";
            this.btnHashTable.UseVisualStyleBackColor = true;
            this.btnHashTable.Click += new System.EventHandler(this.button2_Click);
            // 
            // Chap21_Collection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 450);
            this.Controls.Add(this.btnHashTable);
            this.Controls.Add(this.btnDictionary);
            this.Controls.Add(this.btnStack);
            this.Controls.Add(this.btnQueue);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnListII);
            this.Controls.Add(this.btnList);
            this.Name = "Chap21_Collection";
            this.Text = "Chap21_Collection";
            this.Load += new System.EventHandler(this.Chap21_Collection_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnList;
        private System.Windows.Forms.Button btnListII;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnQueue;
        private System.Windows.Forms.Button btnStack;
        private System.Windows.Forms.Button btnDictionary;
        private System.Windows.Forms.Button btnHashTable;
    }
}