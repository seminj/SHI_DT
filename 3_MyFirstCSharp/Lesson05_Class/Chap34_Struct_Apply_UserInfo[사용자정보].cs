﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstCSharp
{
    internal class Chap34_Struct_Apply_UserInfo
    {
        // 사용자 정보 관리를 위한 사용자 정보 데이터 구조체 생성

        public struct UserInfo
        {
            // 사용자 ID
            public string UserId { get; set; }

            // 사용자 PW
            public string PassWord { get; set; }

            // 사용자 명
            public string UserName { get; set; }

            // 메일 주소
            public string MailAddress { get; set; }

            // 사용여부
            public bool UseFlag{ get; set; }

            // 등록일시
            public DateTime MakeDate { get; set; }
        }
    }
}
