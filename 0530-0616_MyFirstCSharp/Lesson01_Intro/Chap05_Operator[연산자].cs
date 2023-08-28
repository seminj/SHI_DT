using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFirstCSharp
{
    public partial class Chap05_Operator : Form
    {
        // 연산자
        // 프로그램에서 변수나 값의 연산을 위해 사용되는 부호 ( = , + , - , / , % , ++, += ...)

        public Chap05_Operator()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // 대입연산자 = (= 의 오른쪽에 있는 값 (리터럴)을 왼쪽 데이터 타입 변수 등에 대입한다.)
            int iValue;
            iValue = 10;

            MessageBox.Show(Convert.ToString(iValue));
        }

        private void btnSumEqual_Click(object sender, EventArgs e)
        {
            // += : 리터럴을 왼쪽 변수에 있는 값과 합한 후 결과 를 다시 왼쪽 변수에 대입한다.

            int iValue = 10;
            iValue = iValue + 10; // 20

            // 누적증가연산자를 사용해 표현
            iValue += 10;
            MessageBox.Show(Convert.ToString(iValue)); // 30

        }

        private void btnMinEqual_Click(object sender, EventArgs e)
        {
            // 누적감소연산자
            // 리터럴 값을 왼쪽 변수에 차감해 자기 자신(변수)에 담는다.
            int iValue = 10;
            iValue -= 5;
            MessageBox.Show(Convert.ToString(iValue)); // 5
        }

        private void btnMulEqual_Click(object sender, EventArgs e)
        {
            // 누적곱연산자
            int iValue = 10;
            iValue *= 10;
            MessageBox.Show(Convert.ToString(iValue)); // 100
        }

        private void btnDivEqual_Click(object sender, EventArgs e)
        {
            // '/' 나누기 연산자. 결과는 몫 (10 / 3 = 3)
            // 리터럴 값은 자기 자신 변수에 나누기의 몫을 대입한다.
            int iValue = 10;
            iValue /= 3;
            MessageBox.Show(Convert.ToString(iValue)); // 3
        }

        private void btnPerEqual_Click(object sender, EventArgs e)
        {
            // '%' 퍼센트 연산자. 결과는 나머지 (10 % 3 = 1)
            // 나머지 값을 자기 자신에게 대입.
            int iValue = 10;
            iValue %= 3;
            MessageBox.Show(Convert.ToString(iValue)); // 1
        }

        private void btnSS_Click(object sender, EventArgs e)
        {
            // 전위 증가 연산자, 후위 증가 연산자
            // 왼쪽 변수에 1씩 더한다.

            // 후위증가연산 - 코드가 실행되고 난 뒤 자기 자신에게 1증가 값 대입
            int iValue = 10;
            iValue++;
            MessageBox.Show(Convert.ToString(iValue)); // 11

            // 전위증가연산 - 코드가 실행될 때 자기 자신에게 1 증가 값이 대입
            ++iValue;
            MessageBox.Show(Convert.ToString(iValue)); // 12 // ++이 앞에 있으면 연산하고 출력하고, 뒤에있으면 출력하고 연산한다. 

            MessageBox.Show(Convert.ToString(iValue++)); // 12
            MessageBox.Show(Convert.ToString(++iValue)); // 14

            // 전위 증가연산 (실시간 증가 연산 처리 기능)을 사용하는 것을 권장함~~ 강추(강사의 추천)
        }

        private void btsmm_Click(object sender, EventArgs e)
        {
            // 전위 감소 연산자, 후위 증가 연산자
            int iValue = 10;
            MessageBox.Show(Convert.ToString(--iValue)); // 9
            MessageBox.Show(Convert.ToString(iValue--)); // 출력은 9지만 값은 8이나온다.
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
