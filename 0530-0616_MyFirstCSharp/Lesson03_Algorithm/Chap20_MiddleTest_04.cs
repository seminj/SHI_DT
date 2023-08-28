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
    public partial class Chap20_MiddleTest_04 : Form
    {
        public Chap20_MiddleTest_04()
        {
            InitializeComponent();
        }

        private void btnFindResult_Click(object sender, EventArgs e)
        {

            //int[] iValues = Convert.ToInt32(lblTitle.Text);
            
            ////int[] iValues = { 1, 2, 13, 15, 17, 23, 8, 15, 8, 19, 3, 8, 13 };


            //// 정렬
            //Array.Sort(iValues);

            //// 중복 값 찾는 변수 생성
            //int iFindValues = 0;
            //int sFindValues = 0;
            //int iR_Value = 0;
            //int iResultIndex = 0;

            //for (int i = 0; i < iValues.Length; i++)
            //{

            //    // 찾아야 되는 수 == 하나씩 추출한 수
            //    if (iFindValues == iR_Value)
            //    {

            //    }
            //    // 찾은 결과를 반환 할 변수
            //    int iResult = -1;

            //    // 현재 자기 값과 합해서 16이 되는 수 , 대상 찾기
            //    int iFindValue = 16 - iValues[i];

            //    // 대상 찾기 메서드(기능)
            //    // Array.IndexOf : 배열에 값이 있는지 확인 하고, 값이 있을 경우 해당값이 있는 index를 반환,
            //    //                                               값이 없을 경우 -1을 반환
            //    iResult = Array.IndexOf(iValues, iFindValue);

            //    if (iResult == -1) continue;
            //    // 첫번째 값과 세번째 값 나타내기
            //    sFindValues += $"{{ {iValues[i]},{iValues[iResult]} }}";
            //}
            //MessageBox.Show(sFindValues);

        }
    }
}
