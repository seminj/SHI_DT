﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFirstCSharp
{
    /*
        - 클래스
        . 객체 지향 프로그래밍 언어를 이루는 가장 중요한 개념
        . 프로그램을 구현하는 설계도 역할(설계도를 참조해서 실체를 만들어내는 과정)
        . 설계도를 보고 같은 모양의 단위 부품을 필요에 의해 여러번 만들 수 있듯이 클래스 라는 파일을 생성해두고
          프로그램 내에서 필요에 따라 객체(실체)로 인스턴스화해서 사용할 수 있다. 
        . 객체화(인스턴스화) : 클래스(설계도, 레시피) 를 바탕으로 실제로 구현되어야 할 내용을 실행할 수 있도록 만드는 단계
        . 외부에서 선언 후 사용하는 것이 목적 / 기본 상태는 Public
          Private 형태로는 만들 수 없다. (중첩 클래스 일 경우는 Private 제한자 설정이 가능)

        - 클래스를 구성하는 요소
        1. 필드 (멤버) - 인스턴스 변수, 정적 필드, 전역 변수
        2. 프로퍼티 (멤버) 
        3. 생성자 (멤버)
        4. 메서드 (멤버)

     */
    internal class Chap29_Class
    {
        // 1. 필드 멤버
        // 클래스 내부 또는 외부에서 사용될 변수
        // (전역변수, 인스턴스변수, 정적변수) 객체 등을 기입하는 멤버
        // 객체 생성 시 가장 먼저 메모리에 등록(Heap, Data)

        public string sValue = "안녕하세요. 필드 멤버 인스턴스 문자열 변수입니다. ";
        public Random random = new Random(); // 클래스를 Chap29_Class 의 필드 멤버로 사용하기 위해 등록
        public static string sStatic = "정적 필드 멤버";
        private const string sConst = "내부 상수 정적 필드 상수";

        // 2. 프로퍼티 멤버
        // 외부에서 해당 인스턴스 변수에 접근 시 관리 할 수 있는 조건을 설정 해놓은 전역변수(다음 챕터에서 기술)
        // 
        public string sProperty { get; set; }

        // 3. 생성자 멤버
        public Chap29_Class()
        {
            // 클래스 이름과 같은 일종의 메서드
            // 1. 반환 유형을 설정 할 수 없다. 
            // 2. 해당 클래스 (this) 가 객체화 (new Chap29_Class()) 될때 호출 되는 코드의 모음
            // 3. 주로 클래스의 멤버를 초기화하는 용도로 많이 사용됨 (초기화 = 비어있는 객체의 이름에 값을 할당)
            sValue = "안녕하세요 필드 멤버 인스턴스 문자열 변수입니다. ";
        }



        public Chap29_Class(string sValue)
        {
            // 생성자 멤버의 OverLoding
            // 초기화 할 클래스릐 생성자를 OverLoding 하여
            // 필요에 따라 유연하게 클래스 멤버를 초기화 하는 기능으로 구현 할 수 있다

            // 생성자 호출 시 전달값으로 필드 멤버를 초기화
            this.sValue = sValue;
        }

        // 4. 메서드 멤버
        public void MethodMember()
        {
            // 실제 프로그래밍이 구현되는 곳
            // 메서드 내에서 선언한 변수를 지역변수
        }

        // 필드 멤버     : 클래스에서 사용되는 변수, 객체를 관리하는 멤버
        // 프로퍼티 멤버 : 클래스에서 사용되는 변수(특정 조건을 기입할 수 있다.)
        // 생성자 멤버   : 클래스가 생성될 때 호출되는 특수형태의 메서드
        // 메서드 멤버   : 클래스를 생성 후 실제구현이 이루어지는 곳을 호출하여 프로그램을 실행
    }
    class NewClass
    {
        public NewClass()
        {
            // Chap29_Class() 생성자 메서드를 실행하여 초기화한 내역을 New 키워드가 메모리(Heap)에 등록하고 Chap29 라는 객체 이름을 Stack 에 등록하여
            // Heap에 있는 주소를 CHAP29 객체 (Stack)에 전달
            Chap29_Class CHAP29 = new Chap29_Class(); // 기본 생성자를 호출
            MessageBox.Show(CHAP29.sValue); // 안녕하세요 필드 멤버 인스턴스 문자열 변수입니다. 
            Chap29_Class CHAP29_T = new Chap29_Class("셋팅할 문자열 할당");
            MessageBox.Show(CHAP29.sValue); // "셋팅할 문자열 할당"
        }


    }
}
