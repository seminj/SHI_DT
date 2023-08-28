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
    public partial class Chap06_StringChange : Form
    {
        public Chap06_StringChange()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnLower_Click(object sender, EventArgs e)
        {
            // 표현해야 하는 도구(텍스트 박스)에 소문자로 변형 후 표현
            // 원본 데이터의 문자를 변수에 담기
            string sTitle = lblTitle.Text;

            // 변수에 있는 문자를 소문자로 변경하기
            txtLower.Text = sTitle.ToLower();
        }

        private void btnToUpper_Click(object sender, EventArgs e)
        {
            // 원본 데이터를 대문자로 변경 후 표현
            string sTitle = lblTitle.Text;
            txtUpper.Text = sTitle.ToUpper();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            // 특정 문자를 받아 해당 위치에 삽입하는 로직
            string sValue = lblTitle.Text;

            // 입력한 문자열 받아오기
            string sInsertValue = txtString.Text;

            // 입력한 위치 정보 정수형으로 변환하기
            int iIndex = 0;
            int.TryParse(txtIndex.Text, out iIndex);

            // 입력받은 문자열을 삽입 후 텍스트 박스에 표현하기
            // insert(삽입될 위치, 삽입할 문자열)
            txtInsert.Text = sValue.Insert(iIndex, sInsertValue);

            
            // 문자열
            // 문자가 나열되어 있는 형식
            // 각 문자 별로 위치 정보가 주어진다
            // ex. 문자     : 'ABCDE'
            //     위치정보 :  01234

        }

        private void btnTrim_Click(object sender, EventArgs e)
        {
            // 문자열의 앞/뒤에 존재하는 모든 공백을 삭제
            string sValue = lblTitle.Text;

            // 앞/뒤 공백 삭제
            txtTrim.Text = sValue.Trim();

        }

        private void txtStartTrim_Click(object sender, EventArgs e)
        {
            // 문자열의 앞에 존재하는 모든 공백 삭제
            string sValue = lblTitle.Text;
            txtStartTrim.Text = sValue.TrimStart();
        }

        private void btnEndTrim_Click(object sender, EventArgs e)
        {
            // 문자열 뒤의 공백 삭제
            string sValue = lblTitle.Text;
            txtEndTrim.Text = sValue.TrimEnd();
        }
    }
}
