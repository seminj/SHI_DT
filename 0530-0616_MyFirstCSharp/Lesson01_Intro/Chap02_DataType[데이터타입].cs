using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstCSharp
{
    internal class Chap02_DataType
    {
        // 변수 : 값을 담아주는 그릇의 개념
        // 하나의 데이터 값을 가질 수 있으며, 한번 정해진 값이 고정되는 게 아니라,
        // 특정한 상황에 따라 계속해서 변하는 데이터 타입.


        // 1. 정수형 데이터 타입과 변수
        // - 정수형 데이터를 정수형 변수에 담는다.

        // int : integer 정수형 데이터 타입

        // 1-1. 정수형 데이터 타입을 담을 그릇을 만들기.
        //      그릇의 이름을 iValue 로 설정, 10이라는 정수를 iValue 라는 그릇에 담기.
        int iValue = 10; 

        // 정수형 그릇 iValue2 를 만들기.
        int iValue2 = 0; // 메서드에 담아줘야 가능
        
        public Chap02_DataType()
        {
            // iValue2 에 특정 정수 데이터 담기.
            iValue2 = 10;

            // 정수형 그릇 iValue3 에 100 담기.
            int iValue3 = 100;

            
            // 2. 실수형 데이터 타입과 변수. (크기 double > int )
            // double 형태의 데이터를 담는 그릇(자료형 구조) 은 int 형태의 그릇의 크기보다 큰 형태이므로
            // 정수형 데이터와 실수형 데이터 모두 double 형태의 그릇에 담길 수 있다. 
            double dValue = 10; // 오류(초록색 줄): 검토부탁
            dValue = 115.5;

            // 데이터의 크기가 큰 내역은 작은 데이터 타입의 그릇에 담을 수 없다. 
            // iValue3 = 115.5; // 오류(빨간색 줄):경고줄


            // 3. 문자형 데이터 타입과 변수 "String"
            string sValue; // 문자를 담을 수 있는 그릇을 sValue 라는 이름으로 생성. 

            sValue = "안녕하세요";
            // sValue = 안녕하세요 // 쌍따옴표가 없이 문자를 대입할 수 없다. 
            sValue = "100";
            // sValue = 100 // 정수형 데이터를 문자형 데이터 타입에 대입하려 하였으므로 오류 발생.


            // 4. 논리형 데이터 타입과 변수.
            // 논리 : 참과 거짓을 구분 지을 수 있는 데이터 타입
            // ! : 참과 거짓을 판단하는 데이터 형을 스위칭하여 적용하는 키워드
            bool bValue; // bValue라는 변수를 Bool데이터 타입으로 생성.

            bValue = true; // bValue 에 참 True 인 상태를 등록.
            bValue = !true; // True 를 스위칭하여(False) bValue에 대입
            bValue = false; // bValue에 false인 상태를 등록.
            bValue = !false; // False를 스위칭하여(True) bValue에 대입

            // 데이터타입이 맞지 않는 데이터를 대입시 오류가 발생
            //bValue = 1; 
            //bValue = "참";

            // 주석
            // 개발자가 프로그램 작성 시 로직에 대한 코멘트(생각 또는 설명)을 첨가하여 작성해두는 방법
            // 프로그램 실행에는 영향을 미치지 않는다. 
            // 선택 영역 주석 Ctr + K, Ctr + C

            // 빌드(컴파일) (Ctr + B , 프로젝트 - 빌드) / 솔루션 빌드 - Shift + Ctr + B
            // 개발자가 코딩한 프로그램한 내용을 컴퓨터가 알아들을 수 있도록 포장(MSIL, CIL)
            // 중간 단계의 언어로 바꾸는 것

            // 프로그램 오류 검출의 종류
            // 1) 컴파일 할 때 (빌드, 중간언어로 포장할 때) 개발자에게 오류 내역을 즉각 알려주는 에러타입
            //    - 컴파일 타입의 에러 검출 유형
            // 2) 프로그램을 실행 시켜야만 오류 내역을 확인 할 수 있는 방식. 
            //    - 런타임 에러 검출 유형


            // 5. 그 외의 데이터 타입.
            // 5-1 캐릭터 형식 '' 홑따옴표로 문자 1자리를 담는다. 
            char cValue = 'A'; // 문자 하나만 담는 그릇
            string sValue3 = "ABCDE"; // string : 문자열(배열, 나열된 문자)

            // 5-2 unit(Unsigned Integer : UINT)
            uint uiValue = 1; // 양의 정수만 다루는 데이터 형식
                              //uiValue = -1;

            // var 형식. 
            // 특정 데이터를 담을 형식을 미리 정해두지 않고 가변적으로 데이터를 관리할 경우 사용
            
            var vValue = 10; // 정수형 데이터 등록 가능.

            var vValue2 = "안녕하세요"; // 문자열 데이터 등록 가능. 

            var vValue3 = false; // 논리형 데이터 등록 가능

            //vValue = "11"; // 주의) 정수형 데이터를 대입하고 난 다음에는 문자형 데이터를 대입할 수 없다. 

            // 어떠한 그릇에 데이터를 최초 대입하다. : 데이터를 초기화 했다. 

            // object 형식 : 무엇이 들어와도 관대하게 다 받을 수 있다.  
            // 모든 데이터 타입의 조상 시초.
            object oValue = 10;
            oValue = "10";
            oValue = false;

            // var, object
            // 가변적으로 데이터를 관리 할 수 있는 유용한 자료형 구조이지만,
            // 대규모 프로젝트에서 타 개발자가 만든 특정 로직으로 인한 데이터 타입이 일치하지 않는
            // 오류가 발생할 수 있으므로 사용을 추천하지 않는다.  오브젝트 쓰지말 것


        }



    }
}
