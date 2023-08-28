using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static MyFirstCSharp.Chap34_Struct_Apply_UserInfo;

namespace MyFirstCSharp
{
    
    public partial class Chap34_Struture_Exam_Login_T : Form
    {
        // 클래스의 전역변수로 사용자 정보 데이터 유형을 나열할 수 있는 List
        private List<UserInfo_T> userinfos = new List<UserInfo_T>();


        public Chap34_Struture_Exam_Login_T()
        {
            InitializeComponent();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            // 로그인 가능 여부를 판단
            if (userinfos.Count == 0)
            {
                MessageBox.Show("등록된 사용자가 없습니다. ");
                return;
            }
            // 입력한 id, pw
            string sUserid = txtUserId.Text;
            string sPassword = txtUserId.Text;

            // 리스트에 등록되어 있는 사용자 정보와 입력한 사용자의 정보가 같은지 확인
            
            foreach (UserInfo_T userinfo in userinfos)
            {
                if (userinfo.UserId == sUserid)
                {
                    // 사용자 아이디가 같다면
                    if (userinfo.Password == sPassword)
                    {
                        // 비밀번호 체크
                        MessageBox.Show($"{userinfo.UserName} 님 반갑습니다.");
                    }
                    else
                    {
                        MessageBox.Show("비밀번호가 일치하지 않습니다.");
                    }
                    break;
                }   
            }
            MessageBox.Show("일치하는 사용자 ID가 없습니다.");

        }
        private void btnUserReg_Click(object sender, EventArgs e)
        {
            // 사용자 등록 버튼을 클릭시 사용자에 대한 정보를 담을 수 있는 사용자 등록 클래스 전달(참조 주소)
            Chap34_Struture_Apply_UserReg_T CHAP34 = new Chap34_Struture_Apply_UserReg_T(userinfos);
            CHAP34.ShowDialog();

        }
    }
}
