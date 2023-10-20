using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// namespace, 프로젝트, 클래스 라이브러리, dll, API, 어셈블리 라고 지칭
namespace MyFirstCSharp
{
    public partial class Chap20_MiddleTest_03_T : Form
    {
        // 클래스의 전역변수, 필드멤버, 인스턴스 변수
        int iClickCount; // 0

        public Chap20_MiddleTest_03_T()
        {
            InitializeComponent();
        }

        private void btnMakeRan_Click(object sender, EventArgs e)
        {
            // 난수 : 임의의 정수 . 

            ++iClickCount;

            Random rNumber = new Random();
            int iRanNumber = rNumber.Next(0, 100);

            MessageBox.Show(iRanNumber.ToString());

            //// 배열에 값을 추가하는 방법
            //int[] a = { 2 };
            //a = a.Append(30).ToArray();

            // 난수 생성 버튼을 클릭한 횟수에 따른 표기
            if (iClickCount == 1)
            {
                txtNum1.Text = iRanNumber.ToString();
            }
            else if (iClickCount == 2)
            {
                txtNum2.Text = iRanNumber.ToString();
            }
            else 
            {
                txtNum3.Text = iRanNumber.ToString();
                iClickCount = 0; //계속 3번자리에 적혀지기때문에 초기화를 해주어야함
            }
            
            // 이렇게 구현도 가능함. 하지만 foreach로 사용도 가능하기 때문에 아래 로직 사용
            //txtNum1.Text = iRanNumber.ToString();
            //txtNum2.Text = iRanNumber.ToString();
            //txtNum3.Text = iRanNumber.ToString();
        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            // 세 수를 담을 배열 생성
            int[] iValues = new int[3];
            int.TryParse(txtNum1.Text, out iValues[0]);
            int.TryParse(txtNum2.Text, out iValues[1]);
            int.TryParse(txtNum3.Text, out iValues[2]);

            Array.Sort(iValues); // 오름차순으로 정렬. 0 : 최소값, 2: 최대값  

            // 정렬 알고리즘!!
            // 배열에 있는 값을 모두 더하기
            int iSumValue = 0;
            foreach(int iValue in iValues)
            {
                iSumValue += iValue;
            }

            string sMessage = string.Empty;
            if (iSumValue < 100)
            {
                sMessage = $"3 수의 합이 100 미만이면 최소값{iValues[0]}, 최대값 {iValues[2]}이고 곱은 {iValues[0] * iValues[2]} 입니다.";
            }
            else if (iSumValue >= 100 && iSumValue < 200)
            {
                sMessage = $"3 수의 합이 100이상 200미만이면 최소값{iValues[0]}, 최대값 {iValues[2]}이고 합은{iValues[0] + iValues[2]} 입니다.";
            }
            else
            {
                sMessage = $"3 수의 합이 200을 넘습니다.";
            }
            MessageBox.Show(sMessage);

            // 텍스트 박스 일괄 clear
            // this : 현재 로직이 구현되고 있는 클래스를 지칭함(form이라고 생각하면 됨)
            
            // 지금 화면(클래스)에 있는 모든 컨트롤을 추출
            foreach(Control con in this.Controls)
            {
                if (con is TextBox)
                {
                    // 현재 화면에 있는 모든 텍스트 박스를 초기화하는 것
                    con.Text = "";
                }
                iClickCount = 0; // 클리어 후 새로 생성
            }
        }
    }
}
