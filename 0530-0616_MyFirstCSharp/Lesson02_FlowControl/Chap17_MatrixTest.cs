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
    public partial class Chap17_MatrixTest : Form
    {
        public Chap17_MatrixTest()
        {
            InitializeComponent();
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            int[,] iValues1 = new int[2, 4] { { 1, 2, 3, 4 },{ 5, 6, 7, 8 }};
        }

    }
}
