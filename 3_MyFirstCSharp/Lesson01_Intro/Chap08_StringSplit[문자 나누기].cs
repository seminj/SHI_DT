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
    public partial class Chap08_StringSplit : Form
    {
        public Chap08_StringSplit()
        {
            InitializeComponent();
        }

        private void btnInterpolation_Click(object sender, EventArgs e)
        {
            // 문자열 보간
            // 보간 : 비거나 누락된 부분을 채우는 기능
            // 문자열의 " " 사이에 { } 를 사용해 표현하고자 하는 변수를 표기
            // { } 에 들어가는 데이터 타입 (변수, 상수)은 문자열로 형변환 됨
            // 이때, 형변환은 암시적으로 됨

            string sValue; // 보간을 통해 표현될 문자열이 담기는 변수

            // 문자형 데이터의 보간
            sValue = $"라벨의 타이틀 문구는 {lblTitle.Text} 입니다";

            // 정수형 데이터의 보간
            int iValue = 1;
            sValue = $"ivalue의 값은 {iValue} 입니다";
            MessageBox.Show(sValue);

            // "" 문자열의 시작과 종료를 나타내는 기능 => ""를 안에 쓰고 싶어도 기능으로 인식 => \ 사용으로 해결
            // "강사님이 "화이팅"이라고 말했다"
            sValue = "강사님이 \"화이팅\" 이라고 말했다";

            // 보간법에 포함되는 {}를 문자로 표현하고 싶을 때 {{ }} => 얘도 마찬가지임
            // "iValue의 갑은 {1} 입니다"
            sValue = $"iValue의 값은 {{{iValue}}} 입니다";
            MessageBox.Show(sValue);

            //////btnLength_click
                //문자열 개수를 구한다. 
                //나열되어있는 열거형의 자료 개수를 구하는 기능

                //타이틀 문자열 받아오기
            string sTitle = lblTitle.Text;

            MessageBox.Show($"타이틀의 문자열의 문자개수는 {sTitle.Length}개 입니다.");
                        
        }


        private void btnLength_Click(object sender, EventArgs e)
        {
            string sTitle = lblTitle.Text;
            //마지막 문자열을 찾고싶을때
            //"ABCDEFGHIJK" -- 개수 : 
            // 012345678910" -- 주소 위치
            // [0]A [1]B [2]c ...

            int iValue = "ABCDEFGHIJK".Length; //iValue :11
            // 문자열의 마지막 inde(주소값) 찾기
            MessageBox.Show($"타이틀의 마지막 주소값(Index)은 {sTitle.Length - 1} 입니다.");

            // 배열의 개수와 index 구하기
            //               0   1   2   3   4
            int[] iValues = { 11, 12, 13, 14, 15 };

            // 배열의 총 개수 구하기.
            int iValuesLength = iValues.Length; // 5

            // 마지막 배열의 수 ?를 찾기
            int iLastArrayValue = iValues[iValues.Length - 1];

            MessageBox.Show($"배열의 마지막 숫자는 {iLastArrayValue} 입니다.");
        }

        private void btnSplit_Click(object sender, EventArgs e)
        {
            ////btnClick
            //Split : 지정한 문자를 기준으로 문자열 (열거형데이터)를 자르고
            //자른값의 결과를 배열형태로 반환한다.

            //1. '/'를 기준으로 나눈 문자열을 Split 배열에 담는다. 
            // 배열: 같은 타입의 변수를 여러 개 모아놓은 데이터 타입
            string[] sValues = lblTitle.Text.Split('/'); /*열거형으로 되어있음*/

            // 배열에 몇개의 데이터가 나누어져 있는지 확인
            MessageBox.Show($"타이틀의 / 기준 문단 개수는 {sValues.Length} 개 입니다.");


            // 배열의 첫번째 문단? 
            MessageBox.Show($"타이틀 / 기준 첫 문단은 {sValues[0]} 입니다.");

            // 배열의 마지막 문단?
            MessageBox.Show($"타이틀 / 기준 첫 문단은 {sValues[sValues.Length -1]} 입니다.");
        }


        private void button1_Click(object sender, EventArgs e)
        {
            // Substring : 사용자가 지정한 위치 및 개수만큼 문자를 잘라서 표현

            // 문자열을 잘라올 원본 문자열
            string sTitle = lblTitle.Text;

            // 문자열을 자를 위치
            int iIndex = 0;
            int.TryParse(txtIndex.Text, out iIndex);

            // 문자열을 잘라올 개수
            int iCount = 0;
            int.TryParse(txtCount.Text, out iCount);

            // 문자열을 잘라와서 담을 변수
            string sValue;
            sValue = sTitle.Substring(iIndex, iCount);

            MessageBox.Show($"타이틀 {sTitle}의 {iIndex}번째 주소로부터 {iCount}개의 문자를 자른 결과는 {sValue}입니다. ");


            // 위의 로직을 한 행으로 표현할때는 아래 처럼 구현할 수 있다. (In Line 코드) /* 꼭 알고가세요*/
            MessageBox.Show($"타이틀{lblTitle.Text}의 {txtIndex.Text}째 주소로부터 {txtCount.Text}개의 문자를 " +
                             $"자른 결과는 {lblTitle.Text.Substring(Convert.ToInt32(txtIndex.Text), Convert.ToInt32(txtCount.Text))} 입니다.");

        }
    }
}
