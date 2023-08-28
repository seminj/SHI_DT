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
    public partial class Chap03_DataTypeConversion : Form
    {
        // 데이터 타입의 형 변환(숫자 -> 문자)
        // 문자열로 데이터 타입을 변경 : .ToString() , Convert.ToString()

        // 데이터 타입의 형 변환(문자 -> 숫자)
        // 숫자형으로 데이터 타입을 변경 : .Parse(), Convert.Toint32()


        // 명시적 형변환
        // 변경할 데이터 타입을 지정 후 변환
        // .ToStirng()

        public Chap03_DataTypeConversion()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) //왜 변경이 안될까?
        {


            // 디버깅
            // 프로그램 개발 시 오류 내역을 검출하거나, 프로그램의 로직이 실행되는
            // 각 단위별로 결과를 확인할 수 있도록 하는 프로그래밍 방법 / 들어가기 직전에 걸림 / F10 다음 단계 실행
            // 브레이크 포인트 : 로직이 실행될 때 멈춰서 디버깅이 시작되는 시점(왼쪽 음영색 라인 클릭,  F9)

            // 숫자를 문자로 변환하기 기능

            // 1. 변환될 대상 숫자를 담을 변수 생성 및 초기화.
            // 초기화 할때 또는 대입 할때 대입되는 대상 (리터럴)
            int iValue = 10; // 변수 선언 후 iValue = 20; 으로 사용은 가능
            int iValue2 = 20;

            double dValue = 10.1;
            double dValue2 = 20.5;

            // 2. 변형된 데이터 타입이 담길 문자 변수.
            string sValue1;
            string sValue2;

            // iValue의 데이터타입 int 의 기능중 ToString() 이라는 기능을 사용하여 
            // 숫자를 문자로 변형 후 sValue(string)에 대입한다. 
            sValue1 = iValue.ToString(); /*무엇에.이기능을 , 정수형을 문자형으로 변경*/

            // 4. 메세지 박스로 변형된 문자형 숫자를 표현
            MessageBox.Show(sValue1); /*Show 에 커서, string text를 넣어줘야함 / MessageBox 안의 함수를 호출한 것임(생성x)*/

            // 1) (사용x) sValue2에 dvalue2을 대입해보세요. (sValue2를 dValue2 문자열로 초기화)
            sValue2 = dValue2.ToString(); /* **실무에서는 잘 사용하지 않음**, null 때문에. 오류를 배제할 수 있는 형변환 방법이 있음*/

            // 2) (강추!) 문자열로 변환하는 기능 2번째
            sValue2 = Convert.ToString(dValue2); /*Convert안에 있는 ToStirng / F12번 활용*/ 

            // Convert.ToString()의 기능은 결과적으로는 .ToString()과 같은 결과를 생성하지만
            // Null처리의 오류 반환때문에 .ToString() 보다는 Convert.ToString() 형식을 사용하는 것을 추천


            // 문자 열의 합(연관되는 문자열을 이어서 표현)
            // s Value2 : "10", sValue2: "20.5"
            string sValue3 = sValue1 + sValue2;
            MessageBox.Show(sValue3); //1020.5 //messagebox 두개 뜸

        }

        private void btnStoI_Click(object sender, EventArgs e)
        {
            // 문자를 숫자로 변경하는 로직
            // 1. 숫자로 바꿀 문자열 변수 생성.
            string sValue1 = "안녕하세요";
            string sValue2 = "10";
            string sValue3 = "10.1"; // 소수를 포함한 실수


            // 2. .Parse()기능을 통한 변환: 문자를 숫자로 바꾸는 것
            int iResult = 0; // 변환 결과를 담을 int 변수

            // 안녕하세요 문자를 숫자로 바꾸려 했으나 변환 실패를 통한 런타임 오류 발생
            // iResult = int.Parse(sValue1); // 런타임오류 발생

            // 숫자로 변환할 수 있는 문자일 경우 오류 없이 변환이 완료.
            iResult = int.Parse(sValue2);

            // 3. Convert.ToInt32()
            // 문자 -> 숫자
            // 숫자로 바꿀 수 없는 문자일 경우 시스템 오류 발생.
            // iResult = Convert.ToInt32(sValue1); // "안녕하세요"가 숫자로 바뀔 수 없으므로 오류 반환

            // 4. 숫자로 변환할 수 있는 문자인지 검증하는 기능 .TryParse() : 변경을 시도한다. 
            
            // 숫자형 데이터 형변환 실패.
            // bResult : false
            // iResult : 0
            bool bResult = int.TryParse(sValue1, out iResult); /* 반환값 T/F  / , 는 두개를 같이 넣는다. */

            // 숫자형 데이터 형변환 실패(실수형 데이터(소수포함)를 정수로 변형하려 할 때 실패)
            // sValue3 : 10.1
            // bResult : false
            // iResult : 0
            bResult = int.TryParse(sValue3, out iResult);

            // 숫자형 데이터 형변환(소수 데이터를 형변환)
            double dResult = 0; // 소수 형변환 결과를 받을 변수

            // 소수형 실수 문자열을 실수 데이터 타입으로 형변환 및 결과 검출.
            // sValue3 : "10.1"
            // dResult : 10.1
            // bResult : true
            bResult = double.TryParse(sValue3, out dResult);

            // 정수형 문자열을 실수 데이터 타입으로 형변환 하는 경우, 
            // sValue2 : "10";
            // dResult : 10
            // bResult : true
            bResult = double.TryParse(sValue2, out dResult); //성공한 값과 성공여부를 알수 있음

            // 문자를 숫자로 형변환할 경우, .Parse()와 Convert.Toint32()를 사용할 수 있지만, 
            // 변환할 수 없는 유형의 문자인 경우 런타임 오류가 발생하므로
            // 데이터타입.TryParse() 기능을 사용하여 형변환하는 것을 추천.
        }

        private void btnNull_Click(object sender, EventArgs e)
        {
            // 다중 주석 처리문 /* */
            /* 
              Null 상태의 변환 처리
            - Convert.ToString() 구문을 사용 시 Null 처리된 값이 있을 경우 빈값을 반환

            - Null : 
             . 데이터의 용량(메모리)가 할당되지 않는 상태
             . " "은 아무런 값이 없는 값이 할당된 상태
            
             . 숫자형 데이터 타입은 : 키워드를 추가하여 null 상태로 만들 수 있다.  
             
             */

            string sValue = null;
            // MessageBox.Show(sValue.ToString()); // sValue가 null 처리 되었으므로 오류가 발생. (런타임 오류)
            MessageBox.Show(Convert.ToString(sValue)); /// sValue 가 null처리 되었어도 아무것도 없는 값으로 치환하여 반환
            string sValue2 = ""; // 초기화됨


            // 숫자 데이터를 null 처리 하는 방법 .?
            // Convert.ToString 과 .ToStirng() 형식으로 Null 을 변환 할 수 있다. 
            int? iValue = null; // ? 를 처리하면 한시적으로 null처리를 할 수 있게 됨 / int? iValue = 10; null이 생기지만 10을 반환
            MessageBox.Show(iValue.ToString());

            string sValue3 = null; 

        }

        private void btnSUM_Click(object sender, EventArgs e)
        {
            // 문자열의 합과 숫자의 합
            string sValue1 = "ABC";
            string sValue2 = "DEF";

            string sVaule3 = sValue1 + sValue2;
            MessageBox.Show(sVaule3); // 문자 + 문자는 문자열이 나옴

            int iValue1 = 50;
            int iValue2 = 30;
            int iValue3 = iValue1 + iValue2; // 50 + 30
            MessageBox.Show(Convert.ToString(iValue3)); //80의 숫자를 문자형으로 변환하여 출력 
        }
    }
}
