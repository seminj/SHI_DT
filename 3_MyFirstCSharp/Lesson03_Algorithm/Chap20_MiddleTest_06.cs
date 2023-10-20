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
    public partial class Chap20_MiddleTest_06 : Form
    {
        public Chap20_MiddleTest_06()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rNumber = new Random();
            int iRanNumber = rNumber.Next(0, 100);

            MessageBox.Show(iRanNumber.ToString());
        }
    }
}
