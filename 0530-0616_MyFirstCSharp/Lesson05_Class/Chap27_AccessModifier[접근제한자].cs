using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstCSharp.MyFirstCSharp
{
    // 접근 제한자
    // 프로그램 내에서 특정한 코드, 변수, 필드, 메서드 등 에 접근하려고 (호출) 할때
    // 권한에 따라 호출 여부를 결정 지을 수 있는 제한자

    // 접근제한자를 사용하는 이유
    // - 캡슐화( 객체지향 언어에서 지켜야하는 규칙, 지켜야하는 개념)
    //  . 모든 기능과 변수를 외부에서 접근가능한 코딩으로 구현할 경우
    //    1. 개발을 한 당사자 외에 여러 사용자에 따라 데이터의 변형을 일으키거나 정상적인 동작을 저해할 우려가 있다. 
    //    2. 불필요하게 너무 많은 기능을 외부에서 호출 가능하도록 하면 개발자 입장에서 어떤 기능을 정확히 사용해야하는지 혼란이 올 수 있다.
    //       따라서 코드 내부에서 처리되는 내용은 외부에서 접근하지 못하도록 막고
    //       외부에서 호출하여 사용해야되는 핵심 기능만 접근 가능하도록 하여 효율적이고 안정성있는 프로그램을 구현하도록 하기 위하여 사용된다.
    //       ex) 1 -> 2 -> 3 -> 4 -> 5 의 순서로 구현되어야 되는 메서드가 있다고 가정을 할때 5의 결과를 얻기 위해서는 반드시 1부터 시작해야하는데
    //      1) 1 외에 2, 3, 4, 5 메서드를 호출 가능한 상태로 만들어버리면, 1부터 시작해야 하는 정상 로직이 안전하게 구현되지 못하는 오류가 발생할 수 있다.
    //      2) 개발자는 시작점이 어디인지 판단하기 힘들다. 

    internal class Chap27_AccessModifier
    {
        // 접근 제한자
        // Public : 모든 클래스에서 접근 할 수 있다. 
        // Private : 해당 클래스 내에서만 접근 할 수 있다.
        //           C#의 경우 접근제한자를 명시하는 부분에 접근 제한자를 표시하지 않을 때 기본으로 private이 적용 !!
        // internal : 동일한 NameSpace에서 접근할 수 있다. 
        // Protected : 파생 클랙스에서 접근이 가능

        // 클래스의 인스턴스 변수 (클래스의 필드 멤버, 전역변수)
        public string sPublic =  "안녕하세요";                     // 모든 곳에서 접근이 가능한 클래스 변수를 생성한 것
        private string sPrivate = "Private Tring";          // 해당 클래스에서만 호출이 가능
        protected string sPartial = "Partial Class string"; // 분할 클래스에서만 접근이 가능한 인스턴스 변수

        // int iLoopCnnt = 0;// private가 생략됨

        public void FindValue()
        {
            // 다른 클래스에서 호출이 가능한 public 형태의 메서드
            sPrivate = "클래스 내에서 접근이 가능";

            FindValue2(); // 해당 클래스 내에서 호출 가능한 private 메서드
        }

        private void FindValue2()
        {
            // 다른 클래스에서는 호출 할 수 없는 private 메서드.
            sPrivate = "동일 클래스의 다른 메서드에서도 접근 가능";
            sPublic = "동일 클래스의 다른 메서드에서도 접근 가능";
            sPartial = "동일 클래스의 다른 메서드에서도 접근 가능";
        }
    }

    // 클래스의 코드 작성 위치
    // . 클래스를 생성할 경우 프로젝트에 cs파일로 추가하는 방법이 있고 소스 내에서 클래스를 수동으로 생성하는 방법이 있다.
    //   솔루션 탐색기에서 확인 할 수 있도록 파일 형태의 클래스를 생성 하는 것이 좋고
    //   개발자가 단독으로 사용할 클래스 인 경우 소스 내에서 생성하여 사용할 수 있다. 
    class NewClass
    {
        // 새로운 클래스의 생성
        void NewMethod()
        {
            // 로직이 실행되는 메서드
            Random random = new Random(); // 마이크로 소프트에서 만들어진 
            Chap27_AccessModifier CHP27 = new Chap27_AccessModifier(); // 내가 만들어서 사용할 클래스
            CHP27.sPublic = "모시모시";  
            //CHP27.sPrivate = "모구모구"; // 외부에서 접근 불가
            //CHP27.sPartial = "세민이";   // 외부에서 접근 불가

            CHP27.FindValue(); // 다른 클래스에서 접근이 가능한 메서드 public method
                               //CHP27.FindValue2(); // 오류 생성 : 다른 클래스에서 접근이 불가능한 메서드



            // FindValue()를 실행하고 FindeValue2()를 순차적으로 실행해야 하는 경우
            // FindValue2()를 외부에서 접근하지 못하도록 Private 로 접근 제한을 두고 
            // FindValue()는 외부에서 접근 가능하도록 Public 으로 접근 제한을 두면서 FindValue2()를 호출함으로써
            // 순차적인 로직을 실행 할 수 있도록 한다. 

            // 캡슐화 : 프로그램을 안전하게 보관하는 것
            // : 최소한의 소스, 코딩만 외부에 공개 함으로서 프로그램의 무결성과 안전성을 유지하도록 하는 방식

        }

    }

    partial class Chap27_AccessModifier_Partial
    {
        // 동일한 네임스페이스에서는 Partial 클래스를 어디서든지 생성하여 하나로 만들 수 있다.
    }




}

