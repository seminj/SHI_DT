
namespace MyFirstCSharp
{
    partial class Chap14_Switch_Test
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Chap14_Switch_Test));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAppleOrder = new System.Windows.Forms.Button();
            this.lblAppleCnt = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblMelonOrder = new System.Windows.Forms.Button();
            this.lblMelonCnt = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblWMOrder = new System.Windows.Forms.Button();
            this.lblWMCnt = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnTotalPrice = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAppleOrder);
            this.groupBox1.Controls.Add(this.lblAppleCnt);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(132, 60);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(161, 113);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "사과";
            // 
            // btnAppleOrder
            // 
            this.btnAppleOrder.Location = new System.Drawing.Point(9, 45);
            this.btnAppleOrder.Name = "btnAppleOrder";
            this.btnAppleOrder.Size = new System.Drawing.Size(141, 59);
            this.btnAppleOrder.TabIndex = 3;
            this.btnAppleOrder.Text = "사과 주문";
            this.btnAppleOrder.UseVisualStyleBackColor = true;
            this.btnAppleOrder.Click += new System.EventHandler(this.btnAppleOrder_Click);
            // 
            // lblAppleCnt
            // 
            this.lblAppleCnt.AutoSize = true;
            this.lblAppleCnt.Location = new System.Drawing.Point(126, 21);
            this.lblAppleCnt.Name = "lblAppleCnt";
            this.lblAppleCnt.Size = new System.Drawing.Size(33, 12);
            this.lblAppleCnt.TabIndex = 2;
            this.lblAppleCnt.Text = "10 개";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "남은 수량 : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "2000 원";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblMelonOrder);
            this.groupBox2.Controls.Add(this.lblMelonCnt);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(299, 60);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(161, 113);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "참외";
            // 
            // lblMelonOrder
            // 
            this.lblMelonOrder.Location = new System.Drawing.Point(9, 45);
            this.lblMelonOrder.Name = "lblMelonOrder";
            this.lblMelonOrder.Size = new System.Drawing.Size(141, 59);
            this.lblMelonOrder.TabIndex = 3;
            this.lblMelonOrder.Text = "참외 주문";
            this.lblMelonOrder.UseVisualStyleBackColor = true;
            // 
            // lblMelonCnt
            // 
            this.lblMelonCnt.AutoSize = true;
            this.lblMelonCnt.Location = new System.Drawing.Point(126, 21);
            this.lblMelonCnt.Name = "lblMelonCnt";
            this.lblMelonCnt.Size = new System.Drawing.Size(17, 12);
            this.lblMelonCnt.TabIndex = 2;
            this.lblMelonCnt.Text = "10";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(58, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 12);
            this.label4.TabIndex = 1;
            this.label4.Text = "남은 수량 : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 12);
            this.label5.TabIndex = 0;
            this.label5.Text = "2500 원";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblWMOrder);
            this.groupBox3.Controls.Add(this.lblWMCnt);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Location = new System.Drawing.Point(466, 60);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(161, 113);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "수박";
            // 
            // lblWMOrder
            // 
            this.lblWMOrder.Location = new System.Drawing.Point(9, 45);
            this.lblWMOrder.Name = "lblWMOrder";
            this.lblWMOrder.Size = new System.Drawing.Size(141, 59);
            this.lblWMOrder.TabIndex = 3;
            this.lblWMOrder.Text = "수박 주문";
            this.lblWMOrder.UseVisualStyleBackColor = true;
            // 
            // lblWMCnt
            // 
            this.lblWMCnt.AutoSize = true;
            this.lblWMCnt.Location = new System.Drawing.Point(126, 21);
            this.lblWMCnt.Name = "lblWMCnt";
            this.lblWMCnt.Size = new System.Drawing.Size(17, 12);
            this.lblWMCnt.TabIndex = 2;
            this.lblWMCnt.Text = "10";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(58, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 12);
            this.label6.TabIndex = 1;
            this.label6.Text = "남은 수량 : ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 12);
            this.label7.TabIndex = 0;
            this.label7.Text = "18000 원";
            // 
            // btnTotalPrice
            // 
            this.btnTotalPrice.Location = new System.Drawing.Point(210, 190);
            this.btnTotalPrice.Name = "btnTotalPrice";
            this.btnTotalPrice.Size = new System.Drawing.Size(337, 59);
            this.btnTotalPrice.TabIndex = 4;
            this.btnTotalPrice.Text = "총 결제 금액 보기";
            this.btnTotalPrice.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(139, 275);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(425, 96);
            this.label3.TabIndex = 4;
            this.label3.Text = resources.GetString("label3.Text");
            // 
            // Chap14_Switch_Test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnTotalPrice);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Chap14_Switch_Test";
            this.Text = "Switch 분기문 실습";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAppleOrder;
        private System.Windows.Forms.Label lblAppleCnt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button lblMelonOrder;
        private System.Windows.Forms.Label lblMelonCnt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button lblWMOrder;
        private System.Windows.Forms.Label lblWMCnt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnTotalPrice;
        private System.Windows.Forms.Label label3;
    }
}