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
    public partial class Chap21_Collection_Test : Form
    {
        public Chap21_Collection_Test()
        {
            InitializeComponent();
        }

        private void btnDictionary_Click(object sender, EventArgs e)
        {
            Dictionary<int, int> dic = new Dictionary<int, int>();

            // Dictionary 의 key를 추출하는 기능
            // dic.Keys
            foreach (int iValue in dic.Values)
            {

            }
        }
    }
}
