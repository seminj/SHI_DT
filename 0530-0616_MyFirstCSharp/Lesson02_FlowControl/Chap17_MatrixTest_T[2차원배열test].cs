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
    public partial class Chap17_MatrixTest_T : Form
    {
        public Chap17_MatrixTest_T()
        {
            InitializeComponent();
        }

        private void btnChang_Click(object sender, EventArgs e)
        {
            // 행 역전 배열 생성 및 표현
            int[,] iValues = new int[2, 4] { { 1, 2, 3, 4 }, { 5, 6, 7, 8 } };

            int iRowCount    = iValues.GetLength(0); // 2 배열의 행의 개수
            int iColumnCount = iValues.GetLength(1); // 2 배열의 컬럼 개수

            // 역전 될 배열이 담길 배열 변수
            int[,] iResults = new int[iRowCount, iColumnCount];

            // 원본 배열의 행을 역으로 거슬러 올라가는 행의 주소 i 생성
            int iResultRowindex = 0;
            for (int i = iRowCount -1; i >= 0; i--) // i행: 4로 시작, j는 0부터 시작 [4,0][3,0][2,0][1,0]
            {
                for (int j = 0; j < iColumnCount; j++) // j행: [4,1][4,2][4,3][4,4]
                {
                    iResults[iResultRowindex, j] = iValues[i, j];
                }
                iResultRowindex++;
            }

            // 두번째 의견
            for (int i = iRowCount - 1; i>= 0; i--)
            {
                for( int j = 0; j < iColumnCount; j++)
                {
                    iResults[iRowCount - (i + 1), j] = iValues[i, j];
                }
            }
        }
    }
}
