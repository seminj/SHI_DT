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
    public partial class Chap11_BranchingStatement : Form
    {

        // 분기문
        // 프로그램 흐름의 조건에 따라 여러 갈래로 나누는 흐름제어
        // 비교연산자로 == , != , <= , >= , &&(and) , ||(or) 을 사용한다. 

        public Chap11_BranchingStatement()
        {
            InitializeComponent();
        }

        private void btnIF_Click(object sender, EventArgs e)
        {
            // 텍스트 박스에 입력한 값이 없을 경우 " 아무값도 없습니다. " 라는 메세지를 표현하고 
            // 아닐경우(값이 있을 경우) 해당 값을 메세지로 표현

            // 텍스트 박스에 입력한 값을 변수에 담기
            string sValue = txtBS.Text;

            if (sValue == "") // 참이면 내려와라
            {
                // True
                MessageBox.Show("아무 값도 없습니다.");
            }
            else
            {
                // False
                MessageBox.Show(sValue);
            }
            /*
            if (sValue != "")
            {
                MessageBox.Show(sValue);
            }*/

        }

        private void txtBs_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnInIf_Click(object sender, EventArgs e)
        {
            /* 
                만약에 텍스트 박스에 입력한 값이
                1 일때는 "분기문 1 실행" 메세지
                2 일때는 "분기문 2 실행" 메세지
                3 일때는 "분기문 3 실행" 메세지

                아무 값도 입력하지 않은 경우 "값을 입력하세요" 메세지
                그리고 값은 있는데 1, 2, 3 이 아닐 경우 " 적절한 분기문이 없습니다. " 메세지
            */

            // 1. 텍스트 박스에 입력한 값 받아오기
            string sTextValue = txtBS.Text;

            // 먼저 입력한 값이 없을 경우를 걸러내는 분기문을 바깥쪽에 작성
            if (sTextValue == "")
            {
                MessageBox.Show("값을 입력하세요");
            }
            else 
            {
                if (sTextValue == "1")
                {
                    MessageBox.Show("분기문 1 실행");
                }
                if (sTextValue == "2")
                {
                    MessageBox.Show("분기문 2 실행");
                }
                if (sTextValue == "3")
                {
                    MessageBox.Show("분기문 3 실행");
                }
                else
                {
                    MessageBox.Show("적절한 분기문이 없습니다. ");
                }
            }

            // 마지막의 else 는 3번 분기문을 만족시키지 못할 경우의 로직이다.
            // 1, 2 를 입력하였을 경우, "1번 , 2번 분기문 실행"이라는 메세지를 표현하고
            // 3이 아니기때문에 적절한 분기문이 없습니다. 표현.
            // 예상한 시나리오대로 동작하지 않는 로직이 된다. 

            // 1, 2, 3, else의 흐름을 하나로 만들어주는 if 문의 흐름이 필요하다. 
            

        }

        private void btnElseIf_Click(object sender, EventArgs e)
        {
            // else if
            // if 문과 다음 if 문을 하나의 흐름으로 만들어준다. 
            // if, else if 를 만족시키는 조건을 하나라도 수행하면 흐름을 종료
            // 모두 거짓 상태일 경우 else 로직을 수행.


            /* 시나리오
                만약에 텍스트 박스에 입력한 값이
                1 일때는 "분기문 1 실행" 메세지
                2 일때는 "분기문 2 실행" 메세지
                3 일때는 "분기문 3 실행" 메세지

                아무 값도 입력하지 않은 경우 "값을 입력하세요" 메세지
                그리고 값은 있는데 1, 2, 3 이 아닐 경우 " 적절한 분기문이 없습니다. " 메세지
            */

            // 입력한 값
            string sValue = txtBS.Text;

            //1. 값을 입력하지 않았을 경우.
            if (sValue == "")
            {
                MessageBox.Show("값을 입력하세요");
            }
            else if (sValue == "1")
            {
                MessageBox.Show("1 분기문 실행");
            }
            else if (sValue == "2")
            {
                MessageBox.Show("2 분기문 실행");
            }
            else if (sValue == "3")
            {
                MessageBox.Show("3 분기문 실행");
            }
            else
            {
                MessageBox.Show(" 적절한 분기문이 없습니다.");
            }

        }

        private void btnAndIf_Click(object sender, EventArgs e)
        {
            // && : 모든 조건을 만족 시킬 경우에만 참   '그리고'
            
            // 입력한 값 받아오기
            string sValue = txtBS.Text;

            if (sValue == "1" && sValue == "2" && sValue == "3")
            {
                MessageBox.Show($"{sValue} 번 분기문 실행");
            }
            else if(sValue == "")
            {
                MessageBox.Show("값을 입력하세요");
            }
            else 
            {
                MessageBox.Show("적절한 분기문이 없습니다");
            }
        }

        private void btnORIf_Click(object sender, EventArgs e)
        {
            // OR IF문 : 조건 중 하나라도 참일 경우 true 로 간주. '이거나'
            // || 버티컬 (shift + \)

            string sValue = txtBS.Text;

            // 1 이거나 2 이거나 3 이거나 하나만 맞아도 true
            if (sValue == "1" || sValue == "2" || sValue == "3")
            {
                // true
                MessageBox.Show($"{sValue}번 분기문");
            }
            else if (sValue == "")
            {
                MessageBox.Show("값을 입력하세요");
            }
            else
            {
                MessageBox.Show("적절한 분기문이 없습니다.");
            }
        }

        private void btnBoolIf_Click(object sender, EventArgs e)/* 이건 기억하세요 */
        {
            // 분기문의 외부 변수를 이용하여 분기 흐름 제어하기
            // bool 데이터 변수에 데이터가 담긴 결과로 흐름을 판단하는 로직

            // 1. 입력한 값 받아오기
            string sValue = txtBS.Text;

            // 2. 분기 흐름 제어를 위한 외부 bool 변수 생성
            bool bFalg = false; // 기본값 : False

            // 3. 첫번재 분기 흐름 생성
            if (sValue == "1" || sValue == "2" || sValue == "3")
            {
                bFalg = true;
            }
            else if (sValue == "")
            {
                MessageBox.Show("값을 입력하세요.");
                return; // 로직 종료
                //bFalg &= true; 

            }

            // 4. 두번재 분기 흐름 생성
            // bFlag 의 참 / 거짓에 따른 분기 흐름

            // 아래 두 경우는 같은 케이스
            // bFlag 에 false 값이 있다면 if 문 실행

            //if (!bFalg)
            //{
                // true
            //}

            if (bFalg == true) // == !bFalg
            {
                // true
                // 1, 2, 3을 입력하지 않은 경우
                MessageBox.Show("적절한 분기문이 없습니다.");
            }
            else // 1,2,3, 값을 입력한 경우
            {
                MessageBox.Show($"{sValue}번 분기문 실행");
            }

        }

        private void btnPM_Click(object sender, EventArgs e)
        {
            // 입력한 값이 음수인지 양수인지 판단

            // 입력한 값 받아오기
            string sValue = txtBS.Text;

            // 정수 데이터 변수 생성
            int iResult = 0;

            // 입력받은 값을 숫자로 변환 할 수 있는지 체크 bool 변수
            bool bFalg = false;

            // 입력문자를 숫자로 변환 후 iResult 에 담고 성공여부를 bFlag에 담기
            bFalg = int.TryParse(sValue, out iResult);

            // 벨리데이션 체크
            // 개발자가 프로그램 개발 시 오류 사항이 발생할 수 있는 로직을 예상하고 오류 상황이 발생할 수 있는 로직을 처리하기 전에
            // 에러 메세지를 사용자에게 전달해줌으로써 시스템 오류를 발생시키지 않으면서 프로그램에 대한 신뢰도를 높이는 개발방법
            // 사용자에게 정확한 사용 방법을 알리면서 올바르게 프로그램을 사용할 수 있도록 유도하는 목적이 있음

            if (!bFalg) 
            {
                MessageBox.Show("음수 양수 판단을 할 수 없습니다.");
                return;
            }

            // 음수/양수 판단하는 로직
            if (iResult > 0)
            {
                MessageBox.Show("양수입니다.");
            }
            else if (iResult < 0)
            {
                MessageBox.Show("음수입니다.");
            }
            else
            {
                MessageBox.Show("0 입니다.");
            }
        }

        private void btnDO_Click(object sender, EventArgs e)
        {
            // 입력한 값이 홀수인지 짝수인지 판단

            // 정수 데이터 변수 생성
            int iResult = 0;
            string sValue = txtBS.Text;
            bool bFalg; // defalt = false

            bFalg = int.TryParse(sValue, out iResult);

            // 홀짝 찾기
            if (!bFalg)
            {
                MessageBox.Show("홀수 짝수 판단을 할 수 없습니다. ");
                return;
            }

            // 홀수/짝수 판단하는 로직
            if (iResult % 2  == 0 && iResult !=0)
            {
                MessageBox.Show("짝수입니다.");
            }
            else
            {
                MessageBox.Show("홀수입니다.");
            }
        }

        private void btnTernaryOperator_Click(object sender, EventArgs e)
        {
            // 삼항연산자
            // 피 연산자의 개수가 3개인 조건부 연산자
            // if - else 구문을 한 줄로 간단하게 표현할 수 있기 때문에 IN - LINE IF 문이라고도 함

            // 홀/짝 구하기를 삼항연산자로 표현해보자
            string sValue = txtBS.Text;
            int iResult = 0;
            bool bFlag = false;
            bFlag = int.TryParse(sValue, out iResult);

            if (!bFlag)
            {
                MessageBox.Show("판단 못해");
                return;
            }

            // 결과 받을 string 변수
            string sResult = string.Empty; // ""
            // string sResult = ""; -> 요걸로 해도 된다~

            sResult = (iResult % 2 == 0) ? "짝수입니다 짝짝~~" : "홀수입니다 홀홀홀";
            MessageBox.Show(sResult);

            // 한줄로 표현
            MessageBox.Show((iResult % 2 == 0) ? "짝수입니다 짝짝~~" : "홀수입니다 홀홀홀");
        }
    }
}
