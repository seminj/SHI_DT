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
    public partial class Chap22_Method02_Test : Form
    {
        // 총 구매 금액 관리 변수
        int iTotalPrice = 0;

        public Chap22_Method02_Test()
        {
            InitializeComponent();
        }

        private void btnAppleOrder_Click(object sender, EventArgs e)
        {
            // 사과 주문 클릭 로직
            int iAppleCnt = Convert.ToInt32(lblAppleCnt.Text);

            // 사과 현재 재고 수량
            if (iAppleCnt == 0)
            {
                MessageBox.Show("사과의 재고 수량이 0개 입니다. 주문 할 수 없습니다.");
                return; // 현재 사과주문 버튼의 로직 종료
            }
            // 사과 재고 수량 차감
            lblAppleCnt.Text = (--iAppleCnt).ToString();//--iAppleCnt; 
                                                        // iAppleCnt -= 1;

            // 총 구매 금액에 사과 금액 누적
            iTotalPrice += 2000;
        }


        private void btnMelonOrder_Click(object sender, EventArgs e)
        {
            // 참외 주문 클릭 로직
            int iMelonCnt = Convert.ToInt32(lblMelonCnt.Text);

            // 참외 현재 재고 수량
            if (iMelonCnt == 0)
            {
                MessageBox.Show("참외의 재고 수량이 0개 입니다. 주문 할 수 없습니다.");
                return;
            }

            // 참외 재고 수량 차감
            lblMelonCnt.Text = (--iMelonCnt).ToString();

            // 총 구매 금액에 참외 금액 누적
            iTotalPrice += 2500;

        }

        private void btnWMOrder_Click(object sender, EventArgs e)
        {
            // 수박 주문 클릭 로직
            int iWMCont = Convert.ToInt32(lblWMCnt.Text);

            // 수박 현재 재고 수량
            if (iWMCont == 0)
            {
                MessageBox.Show("수박의 재고 수량이 0개 입니다. 주문 할 수 없습니다.");
                return;
            }

            // 수박 재고 수량 차감
            lblMelonCnt.Text = (--iWMCont).ToString();

            // 총 구매 금액에 참외 금액 누적
            iTotalPrice += 18000;
        }
        private void btnTotalPrice_Click(object sender, EventArgs e)
        {
            // 총 결제 금액 보기
            MessageBox.Show($" 총결제 금액은 {iTotalPrice}원 입니다.");
        }
    }
}
