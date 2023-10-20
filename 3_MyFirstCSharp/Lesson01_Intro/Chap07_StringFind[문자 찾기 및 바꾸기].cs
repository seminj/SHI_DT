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
    public partial class Chap07_StringFind : Form
    {
        public Chap07_StringFind()
        {
            InitializeComponent();
        }

        private void Chap07_StringFind_Load(object sender, EventArgs e)
        {

        }

        private void btnIndexOf_Click(object sender, EventArgs e)
        {
            // Index of : 문자열 내에서 찾고자 하는 지정된 문자 또는 문자열의 위치 정보 찾기 (index)

            // 타이틀 변수에 담기
            string sTitle = lblTitle.Text;

            // 사용자가 입력한 문자열을 변수에 담기
            string sValue = txtIndexOf.Text;

            // 사용자가 지정한 문자열의 위치 찾아 담을 변수
            int iIndex = 0;
            iIndex = sTitle.IndexOf(sValue);
            MessageBox.Show(sValue + "가 있는 위치는 " + iIndex + "입니당~ 짝짝");
            // index는 string보다 작은 데이터형임. 따라서 string의 규격에 맞춰 형변환함 => 암시적 형변환

            // 암시적 형변환
            // 데이터 타입을 명시하지 않아도 데이터 타입이 큰 유형으로 자동 변환
            // 컴파일러가 컴파일시 자동으로 변환해주는 타입
            // 어떻게 암시적 형변환이 된거냐면? + 사용해서 ~~

            // 명시적으로 형변환하고 싶다면?
            // messageBox.Show(sValue + "가 있는 위치는 " + iIndex.ToString + "입니당");


        }

        private void btnLastIndexOf_Click(object sender, EventArgs e)
        {
            // Last Index of : 문자열의 뒤에서 찾아 몇 번째 인덱스에 있는지 리턴 (가장 처음 찾은 문자의 위치 정보 반환)
            // 참고) 앞에서부터 찾든지 뒤에서부터 찾든지 몇 번째 인덱스인지는 같음 (뒤에서부터 1,2,3,.. 아님)

            string sTitle = lblTitle.Text;
            // 사용자가 지정한 문자
            string sValue = txtLastIndexOf.Text;
            // 인덱스 위치 정보가 담길 변수 지정
            int iLastIndex = 0;
            // 문자열 뒤에서 몇 번째 index에 있는지 확인
            iLastIndex = sTitle.LastIndexOf(sValue);

            MessageBox.Show(sValue + "의 뒤에서부터의 위치는" + iLastIndex + "입니다앙");

        }

        private void btnStartWith_Click(object sender, EventArgs e)
        {
            // StartWith : 해당 문자열로 시작하는지 판단 / 반환 형식은 bool
            string sTitle = lblTitle.Text;
            string sValue = txtStartWith.Text;
            // 판단 결과 반환하기 => bool형식으로 반환되는 성질 이용했구나
            bool bFlag = sTitle.StartsWith(sValue);
            MessageBox.Show("판단 결과는 " + bFlag + "입니다");

        }

        private void btnEndWith_Click(object sender, EventArgs e)
        {
            // EndWith : 문자열이 지정한 문자로 끝나는지 판단한다
            string sTitle = lblTitle.Text;
            string sValue = txtEndWith.Text;
            bool bFlag = sTitle.EndsWith(sValue);
            MessageBox.Show("판단 결과는 " + bFlag + "입니다");

            // 위 로직은 아래와 같이 줄일 수 있따
            // MessageBox.Show("판단 결과는 " + lblTitle.Text.EndsWith(txtEndWith.Text) + "입니다");

            // 가독성 있는 정도는 한 줄로 할 것 But, 변수를 재사용할 것 같으면 풀어서 코딩하는 게 더 코드가 간결해진다~
        }

        private void btnContain_Click(object sender, EventArgs e)
        {
            // Contains() : 지정한 문자열을 포함하고 있는지 결과를 반환
            string sTitle = lblTitle.Text;
            string sValue = txtContain.Text;
            bool bFlag = sTitle.Contains(sValue);
            MessageBox.Show("판단 결과는 " + bFlag + "입니다");
        }

        private void btnReplace_Click(object sender, EventArgs e)
        {
            // 문자열을 원하는 문자열로 치환

            // 타이틀 받아오기
            string sTitle = lblTitle.Text;

            // 변경 전 사용자가 입력한 문자열 받아오기
            string sBeforeWord = txtBefore.Text;

            // 변경 후 문자열 받아오기
            string sAfterWord = txtAfter.Text;

            // 변경 완료 후 문자열이 담길 변수 지정
            string sResult = sTitle.Replace(sBeforeWord, sAfterWord);

            MessageBox.Show(sResult);


        }
    }
}
