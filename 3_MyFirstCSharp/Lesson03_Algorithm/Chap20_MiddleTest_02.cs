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
    public partial class Chap20_MiddleTest_02 : Form
    {
        public Chap20_MiddleTest_02()
        {
            InitializeComponent();
        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            // 배열 등록
            int[] iValues = { 1, 4, 6, 9, 10, 12, 16 };

            // 찾은 값의 쌍을 등록 할 문자 변수
            string sFindValues = string.Empty;// 제공되는 기능 사용

            // i : 기준이 되는 배열의 index
            for (int i = 0; i < iValues.Length; i++)
            {
                // 찾은 결과를 반환 할 변수
                int iResult = -1;

                // 현재 자기 값과 합해서 20이 되는 수 , 대상 찾기
                int iFindValue = 20 - iValues[i];

                // 대상 찾기 메서드(기능)
                // Array.IndexOf : 배열에 값이 있는지 확인 하고, 값이 있을 경우 해당값이 있는 index를 반환,
                //                                               값이 없을 경우 -1을 반환
                iResult = Array.IndexOf(iValues, iFindValue);

                if (iResult == -1) continue;
                // 20 이 되는 수 표현한 메세지 누적시키기
                sFindValues += $"{{ {iValues[i]},{iValues[iResult]} }}";
                //sFindValues.Text += "\r\n"; // 개행
            }
            MessageBox.Show(sFindValues);
        }
    }
}
