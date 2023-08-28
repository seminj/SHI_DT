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
    public partial class Chap20_MiddleTest_01_T : Form
    {
        public Chap20_MiddleTest_01_T()
        {
            InitializeComponent();
        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            {
                // 합한 값이 16 이 되는 2개의 수 구하기

                // 배열 등록
                int[] iValues = { 1, 4, 6, 9, 10, 12, 16 };

                //// 찾은 값의 쌍을 등록 할 문자 변수
                string sFindValues = string.Empty;

                // i : 기준이 되는 배열의 index
                // for (int i = 0; i < iValues.Length; i++)

                //{
                //    // 찾은 결과를 반환 할 변수
                //    int iResult = -1;

                //    // 현재 자기 값과 합해서 16이 되는 수 , 대상 찾기
                //    int iFindValue = 16 - iValues[i];

                //    // 찾을 값의 존재 여부 를 확인
                //    for (int j = 0; j < iValues.Length; j++)
                //    {
                //        if (iValues[j] == iFindValue)
                //        {
                //            iResult = iFindValue; // 값이 있는지 확인 후 업데이트
                //            break;
                //        }
                //    }

                //    if (iResult == -1) continue;
                //    // 16 이 되는 2개의 수 표현한 메세지 누적
                //    sFindValues += $"{{ {iValues[i]},{iFindValue} }}";
                //}



                // 2. 제공되는 기능을 사용하는 방법.(실무적인 방법)
                // i : 기준이 되는 배열의 index
                for (int i = 0; i < iValues.Length; i++)
                {
                    // 찾은 결과를 반환 할 변수
                    int iResult = -1;

                    // 현재 자기 값과 합해서 16이 되는 수 , 대상 찾기
                    int iFindValue = 16 - iValues[i];

                    // 대상 찾기 메서드(기능)
                    // Array.IndexOf : 배열에 값이 있는지 확인 하고, 값이 있을 경우 해당값이 있는 index를 반환,
                    //                                               값이 없을 경우 -1을 반환
                    iResult = Array.IndexOf(iValues, iFindValue);

                    if (iResult == -1) continue;
                    // 16 이 되는 2개의 수 표현한 메세지 누적시키기
                    sFindValues += $"{{ {iValues[i]},{iValues[iResult]} }}";
                }
                MessageBox.Show(sFindValues);
            }
            
        }
    }
}
