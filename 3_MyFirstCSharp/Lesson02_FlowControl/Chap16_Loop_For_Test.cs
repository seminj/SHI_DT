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
    public partial class Chap16_Loop_For_Test : Form
    {
        public Chap16_Loop_For_Test()
        {
            InitializeComponent();
        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            string sTitle = txtStart.Text;
            string eTitle = txtEnd.Text;

            // 정수 데이터 변수 생성
            int sResult = 0; 
            int eResult = 0;

            // 입력값을 숫자로 변환 체크
            bool sFalg = false; 
            bool eFalg = false;

            // 입력문자 숫자 변환
            sFalg = int.TryParse(sTitle, out sResult);
            eFalg = int.TryParse(eTitle, out eResult);

            // 범위 안의 짝/홀수
            string txtEven = txtEvenResult.Text;
            string txtOdd = txtOddResult.Text;

            // 짝/홀 합 표현
            MessageBox.Show(txtEven + txtOdd);
            
            // 변경 후 문자열 받아오기
            string evenResult = txtEvenResult.Text;
            string oddResult= txtOddResult.Text;

            // 변경 완료 후 문자열이 담길 변수 지정
            sTitle.Replace(evenResult, oddResult);

            //MessageBox.Show();
        }
        
    }
}
