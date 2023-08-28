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
    public partial class Chap20_MiddleTest_07 : Form
    {
        public Chap20_MiddleTest_07()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // 랜덤 난수 0부터 20
            Random random = new Random();
            int iRanNumber = 0;
            int[] iValue = new int[20];

            // 0부터 20까지의 수를 20개 만들어 정렬
            for (int i = 0; i < 20; i++)
            {
                iRanNumber = random.Next(0,20); // 0부터 20까지의 숫자를 랜덤으로
                iValue[i] = iRanNumber; // 하나씩 넣어
            }
            Array.Sort(iValue); // 정렬


            // 대상 문자 배열에 있는 값을 숫자 배열로 등록하기
            //for (int i = 0; i < iValue.Length; i++)
            //{
            //    iValue[i] = ();
            //}

            

        }
    }
}
