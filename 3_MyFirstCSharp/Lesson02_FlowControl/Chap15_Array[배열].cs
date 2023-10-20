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
    public partial class Chap15_Array : Form
    {
        // 배열 (참조형식, 배열의 이름은 STack에 값은 Heap 저장)
        // - 같은 데이터 타입의 여러 데이터가 하나의 배열 변수 이름으로 나열된 데이터형식
        // - C# 에서 배열은 반드시 방의 개수를 지정하여 생성하거나 배열에 나열 될 값들의 개수가 명시되어야한다.
        // (EX. new int[5], Split('/')

        public Chap15_Array()
        {
            InitializeComponent();
        }

        private void btnArrayF_Click(object sender, EventArgs e)
        {
            // 1. 여러가지 배열의 초기화 (배열을 생성하고 값을 대입)

            // 배열의 개수와 값을 바로 등록
            int[] iValues = new int[6];

            // 배열의 방의 개수와 값을 바로 등록
            int[] iValue2 = new int[3] { 0, 1, 2 };

            // 배열의 개수 지정 없이 값을 바로 등록
            int[] iValue3 = new int[] { 10, 30, 50 };

            // new int[] 키워드 없이 값을 바로 등록
            int[] iValue4 = new int[] { 10, 20, 30, 40, 50 };

            // 반환 형태가 배열인 기능(메서드)를 이용하여 배열을 등록
            string[] sValues = "ABCDE-FGHI".Split('-');

            // 기존에 생성되어 있는 배열 방 개수만큼 빈 배열 만들기
            int[] iValue5 = new int[sValues.Length];


            // 2. C#에서 배열을 관리할 때 사용되는 주요 기능

            // 샘플 배열         0   1   2   3   4
            int[] iExamArray = { 10, 30, 60, 50, 20 };

            // 배열의 정렬(오름차순)   0   1   2   3   4
            Array.Sort(iExamArray); // 10, 20, 30, 50, 60

            // 배열의 정렬(내림차순)
            Array.Reverse(iExamArray); //60, 50, 30, 20, 10

            // 배열의 값을 하나의 문자열로 표현하는 기능
            string sExamValue = string.Empty; // 배열의 값을 하나로 담을 변수
            sExamValue = string.Join("/", iExamArray);
            MessageBox.Show(sExamValue);

            // 배열의 데이터를 모두 삭제.(방은 그대로 두고 데이터만 삭제)
            //          삭제할 배열, 삭제 시작주소, 삭제할 데이터 갯수
            Array.Clear(iExamArray,             0,                  2);// 자율배열, 자동시작 인덱스, 자율 개수
            Array.Clear(iExamArray,             0,  iExamArray.Length);// 배열의 모든 데이터 삭제


            // 배열의 복사
            // () : 캐스팅 - 강제로 형변환을 하는 기능 / 변환되어야하는 대상이 명확할 경우에 사용
            // 깊은 복사 방법
            // - 참조 형식의 데이터를 복사 할때 주소와 값의 정보를 그대로 복사하여 서로 다른 데이터 형식으로 복사하는 방법
            object oValue = iExamArray.Clone(); // Object 형식 -> int 또는 특정데이터 형식 형변환 unBoxing / Clone 은 배열을 복사하는 것
            int[] iBackUps = (int[]) oValue; // oValue : int 배열 형태로 바꾸라는 말

        }

        private void btnArrayCopy_Click(object sender, EventArgs e)
        {
            // 값 형식과 참조 형식의 복사
            
                // 전처리 지시문 (아래를 묶을때 사용)
            #region < 값 형식의 복사 방법 >
            int iValue = 10; //램에다가 넣음
            int iValue2 = iValue; // iValue2 에 iValue를 대입

            // iValue = 10, iValue2 = 10;
            MessageBox.Show(iValue.ToString()); // "10"
            iValue2 = 20;
            MessageBox.Show(iValue.ToString()); // "10"
                                                // int 데이터 타입은 값 형식으로 복사를 할 경우 해당 값을 직접 전달하여 복사된다.

            #endregion

            #region <참조 형식의 복사>
            // 배열을 복사 (배열은 참조형식임, 값 형식이 아니다. )
            int[] iValues1 = { 10, 20, 30, 40, 50};
            int[] iValues2 = iValues1;

            MessageBox.Show(iValues1[0].ToString()); // "10"
            iValues2[0] = 333;
            MessageBox.Show(iValues1[0].ToString()); // "333"
            // 얕은 복사 방법
            // 참조형식의 데이터를 복사 할 때, 값이 저장된 위치 정보만 전달해주는 방법
            //iValues1
            //iValue2 = 20
            //iValue = 10
            #endregion
        }
    }
}
