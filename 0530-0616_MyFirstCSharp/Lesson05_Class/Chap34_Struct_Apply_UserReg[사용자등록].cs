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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace MyFirstCSharp
{
    public partial class Chap34_Struct_Apply_UserReg : Form
    {
        // 클래스의 전역 변수로 사용자 등록 데이터를 나열할 수 있는 List
        private List<UserInfo> userinfos = new List<UserInfo>();
        public Chap34_Struct_Apply_UserReg()
        {
            InitializeComponent();
        }

        private void btnUserReg_Click(object sender, EventArgs e)
        {
            // 사용자 등록을 하기 전 밸리데이션 체크
            string sUserid = txtUserId.Text;
            string sPassWod = txtPassWord.Text;
            string sUserName = txtUserName.Text;
            string sMailAddress = txtUserMail.Text;

            // 벨리데이션 체크
            if (sUserid == "" || sPassWod == "" || sUserName == "" || sMailAddress == "")
            {
                MessageBox.Show("필수 입력 항목이 누락 되었습니다.");
                return;
            }

            /*// 사용자 정보를 담을 수 있는 데이터 자료형에 등록하는 사용자에 대한 데이터를 할당
            UserInfo userinfo = new UserInfo();
            userinfo.UserId      = sUserid;      // 사용자 ID
            userinfo.PassWord    = sPassWod;     // 비밀번호
            userinfo.UserName    = sUserName;    // 사용자명
            userinfo.MailAddress = sMailAddress; // 메일 주소
            userinfo.UseFlag     = true;         // 사용
            userinfo.MakeDate    = DateTime.Now; // 현재 일 시

            // 전역변수 리스트에 사용자 정보를 Add 
            userinfos = ADdd(info);
            */

            // 위 로직은 아래와 같이 표현할 수 있다. 
            userinfos.Add(new UserInfo
            {
                UserId = sUserid,      // 사용자 ID
                PassWord = sPassWod,     // 비밀번호
                UserName = sUserName,    // 사용자명
                MailAddress = sMailAddress, // 메일 주소
                UseFlag = true,         // 사용
                MakeDate = DateTime.Now // 현재 일 시
            });



        }
    }
}
