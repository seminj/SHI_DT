using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static MyFirstCSharp.Chap34_Struct_Apply_UserInfo;

namespace MyFirstCSharp
{
    public partial class Final_Exam02_2_Login : Form
    {
        public Final_Exam02_2_Login()
        {
            InitializeComponent();
        }


        private void btnLogin_Click(object sender, EventArgs e)
        {
            // 로그인 가능 여부를 판단.
            //if (userinfos.Count == 0)
            //{
            //    MessageBox.Show("등록된 사용자가 없습니다.");
            //    return;
            //}
            //// 입력한 id , pw
            //string sUserId = txtUserId.Text;
            //string sPassword = txtPassWord.Text;

            //foreach (UserInfo userinfo in userinfos)
            //{
            //    if (userinfo.PassWord == sPassword)
            //    {

            //    }
            //}

        }

        private void btnUserReg_Click(object sender, EventArgs e)
        {
            // 사용자 등록
        }
    }
}
