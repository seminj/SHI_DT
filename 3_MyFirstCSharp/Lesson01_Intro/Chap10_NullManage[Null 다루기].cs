﻿using System;
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
    public partial class Chap10_NullManage : Form
    {
        public Chap10_NullManage()
        {
            InitializeComponent();
        }

        private void btnHasValue_Click(object sender, EventArgs e)
        {
            // 데이터의 값이 Null인지 판단하는 기능. HasValue
            int? iValue = null; // 0, 정수형 데이터 타입에 null 처리

            // 값이 있을 경우 true / null 일경우 false
            bool bFlag = iValue.HasValue; //개체에 해당 내부 형식의 올바른 값이 있는지 여부를 나타내는 값을 가져옴

            MessageBox.Show(bFlag.ToString());

            // 문자열의 null처리 여부 판단.
            string sValue = null;
            // bFlag = sValue.HasValue; /* string은 hasvalue가 없어? */ 
            // 문자 열의 경우 null 상태를 허용하는 데이터 타입이므로 굳이 null 상태인지 체크하는 기능이 필요없다

        }

        private void btnNullable_Click(object sender, EventArgs e)
        {
            // Null 병합 연산자 '??' - ? 엘비스 기호
            // 데이터 타입의 유형이 null 처리 된 상태인지 판단하는 키워드

            // A ?? B : 만약에 A가 null 상태이면 B 를 표현하고, Null상태가 아니면 A를 그대로 표현하라.
            int? iValue = null;
            // 만약에 iValue 가 null 상태면 -1, 아니면 iValue 값을 iResult 에 대입하라 /**/
            int iResult = iValue ?? -1;
            MessageBox.Show(iResult.ToString());

            // string 타입에 null 값 여부 판단
            string sValue = null;
            MessageBox.Show(sValue ?? "변수가 null 상태입니다."); // 변수가 null

            sValue = "안녕하세요";
            MessageBox.Show(sValue ?? "변수가 null 상태입니다. "); // 안녕하세요 출력
        }
    }
}
