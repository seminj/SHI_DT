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
    public partial class Chap09_StringManage_Test_Teacher : Form
    {
        // 되돌리기를 위한 원본 문자열을 담을 변수
        // 클래스의 전역변수. 클래스의 필드멤버/**/
        string sTitle; // 클래스의 전역변수(필드멤버)

        // 클래스가 객체화 될때 실행되는 멤버 (생성자 멤버)

        public Chap09_StringManage_Test_Teacher()
        {
            // 클래스가 최초 호출 될때 디자인을 셋팅하는 함수
            InitializeComponent();
            sTitle = lblTitle.Text;/* 이미 위에 설정했기 때문에 오류생성되지 않음*/
        }

        private void btnNameChange_Click(object sender, EventArgs e)
        {
            // OOO ->  자기 이름으로 표현
            lblTitle.Text = lblTitle.Text.Replace("OOO", "정세민");
        }

        private void btnFindSwIndex_Click(object sender, EventArgs e)
        {
            // S/W index 표시
            MessageBox.Show($" S/W 글귀의 위치는 {lblTitle.Text.IndexOf("S/W")} 입니다.");
        }

        private void btnFLWord_Click(object sender, EventArgs e)
        {
            // 타이틀 문자열 변수 담기
            // this.sTitle; /* 변수명이 같지만 스택 메모리는 다름*/
            string sTitle = lblTitle.Text;
            MessageBox.Show($"시작문자 : {sTitle[0]}, 종료문자: {sTitle[sTitle.Length - 2]}");
        }

        private void btnInsertDT_Click(object sender, EventArgs e)
        {
            // 앞 뒤에 -DT- 넣기
            lblTitle.Text = $"-DT-{lblTitle.Text}-DT-";
        }

        private void btnLower_Click(object sender, EventArgs e)
        {
            // 특정 문자 소문자로 변경
            string sValue = "DIGITALTRANING";
            lblTitle.Text = lblTitle.Text.Replace(sValue, sValue.ToLower());
        }

        private void btnRemoveSpace_Click(object sender, EventArgs e)
        {
            // 라벨 타이틀 모든 공백 없애기
            lblTitle.Text = lblTitle.Text.Replace(" ", "");
        }

        private void btnRollback_Click(object sender, EventArgs e)
        {
            // sTitle 에 있는 원본 문자열을 다시 lblTitle.Text에 대입
            lblTitle.Text = sTitle;
        }
    }
}
