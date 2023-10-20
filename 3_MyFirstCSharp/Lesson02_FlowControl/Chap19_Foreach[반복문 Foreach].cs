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
    public partial class Chap19_Foreach : Form
    {
        // Foreach
        // - 열거형 데이터 자료구조에서 데이터를 추출할때 사용
        // . 열거형 자료구조 : 일정한 데이터 자료가 동일한 경우 하나의 열거형 데이터로 집합할 수 있는 자료구조
        //                      배열, 문자열, 리스트... 
        // - 조건의 끝을 지정해주는 반복문 (for, while)과는 달리 자료형 구조가 포함하고 있는
        //   데이터의 수에 따라 반복하므로 반드시 종료가 되는 반복문

        public Chap19_Foreach()
        {
            InitializeComponent();
        }

        private void btnStringForeach_Click(object sender, EventArgs e)
        {
            // Title 라벨에 등록되어있는 문자열의 문자를 하나씩 추출한다.

            // 1. 입력한 문자 정보 받아오기
            // Length : 배열에 있는 데이터의 개수
            // txtInputWord.Text 가 문자열(문자의 배열) length를 사용할 수 있다. 
            if (txtInputWord.Text.Length > 1)
            {
                MessageBox.Show("한글자 이상은 처리할 수 없습니다.");
                return;
            }

            // 글자 하나, 문자를 변수
            char cValue = Convert.ToChar(txtInputWord.Text);

            // 라벨의 Title 글귀를 담을 변수
            string sTitle = lblTitle.Text;

            // 단위 데이터 자료 구조 in 집합 자료구조
            // 방법1
            bool bFindFlag = false; // 같은 값을 찾았을 때 True
            foreach(char c in sTitle)
            {
                if (cValue ==c)
                {
                    bFindFlag = true; // MessageBox.Show($"{cValue} 문자는 포함되어있습니다.")
                }
                    
            }

            // 방법2
            string eMessage = string.Empty;
            if(bFindFlag)
            {
                eMessage = $"{cValue} 문자는 포함되어있습니다. ";
            }
            else
            {
                eMessage = $"{cValue} 문자는 포함되어있지 않습니다. ";
            }
            MessageBox.Show(eMessage);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // 숫자형 배열에서 추출
            int[] iValues = { 1, 2, 3, 4, 5, 6 };

            // ForEach 가 반복하는 횟수 (배열의 개수)
            int iCount = 0;

            foreach(int iValue in iValues)
            {
                MessageBox.Show($"배열의 {iCount}번째 주소에 있는 {iValue} 입니다.");
                iCount++;
            }
            MessageBox.Show($"배열의 모든 데이터 수는 {iCount + 1} 개 입니다.");// 배열의 총 개수
            MessageBox.Show($"배열의 마지막 index 정보는 {iCount} 입니다."); // 배열의 index
        }


        private void btnAllClear_Click(object sender, EventArgs e)
        {
            // 컨테이너 안에 있는 텍스트박스 일괄 초기화하기
            // 아래의 로직은 확장성과 유지보수성이 떨어지며
            // 반복적으로 표현하는 구문이 존재하므로 비효율적인 코딩이 될 수 있다. 
            // foreach 는 속성을 뽑아내는 것. 
            //textBox1.Text = "";
            //textBox2.Text = "";
            //textBox3.Text = "";
            //textBox4.Text = "";
            //// ...
            //textBox17.Text = "";

            // 그룹박스(열거형)에 포함되어있는 컨트롤 (도구)를 하나씩 추출하여 텍스트 박스 일 경우 텍스트 속성의 내용을 지우는 로직을 구현
            // Winform에서는 도구의 클래스를 (Control, Component)라고 부른다. 

            // 그룹 박스의 컨트롤 들을 하나씩 추출하여 컨트롤 클래스 MyControl로 받아낸다.
            foreach (Control MyControl in grpControls.Controls)
            {
                // is : 해당 클래스인지. 해당 클래스를 상속받았는지에 대한 판단 후 결과를 반환
                // 만약에 MyControl 이 Textbox 유형이면 . text박스가  control을 상속받았다면 True, 반대시 F
                if (MyControl is TextBox) // text박스로 규정할 수 있는 control인가
                {
                    MyControl.Text = ""; //string .Empty; 
                }
                // 열거형 (Interface) 개념 : int[], string[], string, groupbox (개별적으로 상속받는다)
            }
        }
    }
}
