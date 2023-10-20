using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFirstCSharp
{
    public partial class Chap19_Foreach_Test : Form
    {
        public Chap19_Foreach_Test()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // 개행하는 시점을 어떻게 줄건지 파악해야한다. 

            int[,] iValues1 = new int[3, 4] { { 1, 2, 3, 4 }, { 5, 6, 7, 8 }, { 9, 10, 11, 12 } };

            foreach (Control MyControl in btnForeach.Controls)
            {
                // is : 해당 클래스인지. 해당 클래스를 상속받았는지에 대한 판단 후 결과를 반환
                // 만약에 MyControl 이 Textbox 유형이면 . text박스가  control을 상속받았다면 True, 반대시 F
                if (MyControl is TextBox) // text박스로 규정할 수 있는 control인가
                {
                    MyControl.Text = ""; //string .Empty; 
                }
            }
        }
    }
}
