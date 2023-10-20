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
    public partial class Chap12_IF_Test_T : Form
    {
        // 버튼 클릭의 누적 횟수를 담는 변수(클래스 Chap12_IF_Test_T가 호출될때 (인스턴스화, 객체화) 최초 1회 0으로 초기화된다
        int iButtonClickCont = 0; // 클래스 필드 멤버(클래스 전역변수) / 초기값 생성
        //여기는 정의하는 곳
        public Chap12_IF_Test_T()
        {
            InitializeComponent();
            iButtonClickCont = 0;// 여기는 대입하는 곳
        }

        private void btnJudge_Click(object sender, EventArgs e)
        {
            // 버튼을 총 클릭한 횟수 (정수) / 클래스 생성
            ++iButtonClickCont; // 버튼을 클릭했을 때 1씩 증가.(전위증가 연산)
            txtBtnClickCount.Text = iButtonClickCont.ToString();


            // 1. 변수 설정
            string sValue = txtInputValue.Text; // 입력 받을 값
            int iValue = 0;                     // 입력받은 값이 정수로 변환될 변수
            bool bCheck = false;                // 입력받은 값이 정수로 변환 가능 여부 검증

            // 2. 입력한 문자가 숫자로 바뀔 수 있는지 검증(밸리데이션)
            bCheck = int.TryParse(sValue, out iValue);
            if (!bCheck)
            {
                MessageBox.Show("숫자만 입력하세요");
                return; // 밸리데이션 체크 후 오류 발생 검출 시 로직을 호출한 곳으로 반환(종료하는 구문)
            }

            // 3. 2와 5의 공배수 인지 판단
            string sMessage = string.Empty; // (방법2) / ""과 같은 의미 / 분기에 따른 메세지 변수
            if (iValue % 2 == 0 && iValue % 5 == 0) // 2와 5의 공배수
            {
                //MessageBox.Show("2와 5의 공배수입니다."); // (방법1)
                sMessage = "2와 5의 공배수입니다."; // (방법2)
            }
            else
            {
                //MessageBox.Show("2와 5의 공배수가 아닙니다."); // (방법1)
                sMessage = "2와 5의 공배수가 아닙니다."; // (방법2)
            }
            
            // 4. 8의 배수인지 확인하는 방법
            if (iValue % 8 == 0)
            {
                txtEMultiValue.Text = Convert.ToString(iValue * 8); //text이기 때문에 string으로 convert변환
            }
            else
            {
                txtEMultiValue.Text = "";
            }


        }
    }
}
