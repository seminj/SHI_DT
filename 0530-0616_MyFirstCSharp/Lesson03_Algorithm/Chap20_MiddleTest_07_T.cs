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
    public partial class Chap20_MiddleTest_07_T : Form
    {
        public Chap20_MiddleTest_07_T()
        {
            InitializeComponent();
        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            // 0부터 20까지의 수 표현, 없는 수 합해서 메세지로 나타내기
            Random random = new Random();

            // 임의 난수 20개 받을 배열 생성
            int[] iValues = new int[20];

            // i: iValues의 index
            for (int i = 0; i <20; i++)
            {
                iValues[i] = random.Next(0, 21); // 20 미만 (인덱싱임)
                
                // 텍스트 박스에 표현
                //txtResult.Text += iValues[i] + ","; //?
            }
            Array.Sort(iValues);

            // 텍스트 박스에 오름차순으로 표현하기
            txtResult.Text = "";
            foreach (int i in iValues)
            {
                txtResult.Text += i.ToString() + " ";
            }

            // 0~10까지 누락된 값 찾기
            int iResult = 0; // 누락된 값의 합이 할당 될 변수
            StringBuilder sResult = new StringBuilder(); // 누락된 값의 리스트를 만들것임
            // i : 누락된 수(찾을값)
            for (int i = 0; i < 21; i++)
            {
                #region < 방법 1 : For 문을 이용한 값의 존재 여부 확인>
                //// 찾을 기준값으로 배열에 데이터가 있는지 확인
                //// j : 배열의 index
                //int j = 0;
                //for (j = 0; j < iValues.Length; j++)
                //{
                //    if (iValues[j] == i)
                //    {
                //        // 배열에 i 값이 할당되어 있다. 더이상 비교할 필요가 없다.
                //        break;
                //    }
                //}

                //if (j == 20) 
                //{   
                //// 누락된 값을 결과에 등록
                //iResult += i; // 누적 합산 결과
                //sResult.Append(i + " ");  // 누락된 수 리스트
                //}
                #endregion

                #region <방법 2 : 기능을 통하여 찾아내기>
                // 배열에 값이 있는지 찾기(i 값이 있는지 찾기)
                // indexof : 배열에 찾을 값이 없을 경우 -1을 리턴
                int iIndexFlag = Array.IndexOf(iValues, i);
                if(iIndexFlag == -1)
                {
                    // 찾는 값이 배열에 없으므로 
                    iResult += i;
                    sResult.Append(i + " ");
                }
                #endregion

            }
            MessageBox.Show($"난수 배열 중 {sResult} 이 없으며 총 합은 {iResult}입니다.");
        }
    }
}
