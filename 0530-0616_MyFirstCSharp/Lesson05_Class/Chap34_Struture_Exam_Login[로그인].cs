using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static MyFirstCSharp.Chap34_Struct_Apply_UserInfo;

namespace MyFirstCSharp
{
    public partial class Chap34_Struture_Exam_Login_로그인_ : Form
    {
        // 클래스의 전역 변수로 사용자 등록 데이터를 나열할 수 있는 List
        private List<UserInfo> userinfos = new List<UserInfo>();

        public Chap34_Struture_Exam_Login_로그인_()
        {
            InitializeComponent();
        }

        private void btnUserReg_Click(object sender, EventArgs e)
        {
            // 사용자 등록을 하기 전 밸리데이션 체크
            string sUserid = txtUserId.Text;
            string sPassWod = txtPassWord.Text;

            // 벨리데이션 체크
            if (sUserid == "" || sPassWod == "")
            {
                MessageBox.Show($"{sUserid} 님 반갑습니다.");
                return;
            }
            else if(sPassWod == "")
            {

            }

            userinfos.Add(new UserInfo
            {
                UserId = sUserid,      // 사용자 ID
                PassWord = sPassWod,     // 비밀번호
                UseFlag = true,         // 사용
                MakeDate = DateTime.Now // 현재 일 시
            });
        }
    }
}
