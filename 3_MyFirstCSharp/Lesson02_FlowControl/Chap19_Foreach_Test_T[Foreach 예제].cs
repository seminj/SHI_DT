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
    public partial class Chap19_Foreach_Test_T : Form
    {
        public Chap19_Foreach_Test_T()
        {
            InitializeComponent();
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            // 2차원 배열을 Foreach 로 텍스트 박스에 표현하기

            // 1. 배열을 생성
            int[,] iValues = { { 1, 2, 3, 4 }, { 5, 6, 7, 8 }, { 9,10,11,12} };

            // 2차원 배열의 열의 수를 구함
            int iArrayColumnCNT = iValues.GetLength(1); // columnCount

            int iColumnCnt = 0; // 처리할 데이터추출의 개수가 열의 개수와 일치하는지 확인하는 것
            foreach (int ivalue in iValues)
            {
                ++iColumnCnt; // 열의 CNT 증가(누적 증가 연산자)
                txtMatrix.Text += ivalue.ToString() + " "; // 현재 추출 한 데이터를 표현
                if (iColumnCnt == iArrayColumnCNT)
                {
                    txtMatrix.Text += "\r\n"; // 개행
                    iColumnCnt = 0; // 초기화
                }
            }
        }
    }
}
