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
    public partial class Chap01 : Form
    {
        public Chap01()
        {
            InitializeComponent();
        }

        private void btnHello_Click(object sender, EventArgs e)
        {
            // 버튼을 클릭했을 때 메세지 창 띄우기

            // MessageBox : 메세지를 관리할 수 있는 명령의 집합
            // .Show(???) : Show라는 기능을 이용해서 ???를 수행하는 것

            // 메세지박스에 있는 Show라는 기능(함수, 메서드)을 이용해서 '헬로 월드~~'를 표현하라.
            MessageBox.Show("헬로 월드~~");
            // 주의) 파이썬과 다르게 작은 따옴표와 큰 따옴표 구분한다!
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // 반갑다 버튼을 클릭했을 때 반갑습니다 메세지를 표한하라
            MessageBox.Show("반갑습니다");

        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("내 이름은 정세민");
        }
    }
}
