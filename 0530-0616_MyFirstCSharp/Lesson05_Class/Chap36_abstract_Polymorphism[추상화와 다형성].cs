﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFirstCSharp //MyFirstCSharp
{
    public partial class Chap36_abstract_Polymorphism : Form
    {
        #region < 0. 추상화의 정의 와 Abstract >
        /*
            추상화 
            구현해야 하는 기능을 정의만 해 둔다.
            추상적으로 기능에 대한 정의, 로직, 은 존재하지 않는 상태
            추상클래스 를 상속받는 클래스는 추상클래스에 서 정의한 기능을 구현해야 한다.
            
            * 추상 클래스의 상속을 구현 하는 이유?
              프로그램을 설계 하는 사람. 많은 클래스(화면) 에서 반드시 구현해야 하는 기능이 있을때.  
              (조회, 추가, 저장, 삭제) 
              여러 개발자들이 개발을할때 설계자의 의도를 파악하지 못하고 
              1. 조회, 추가, 저장, 삭제 등에 대한 기능을 누락하여 구현 할 경우가 발생
              2. 개발자들 마다 조회(search(), Find()) , 추가,저장, 삭제 기능의 명칭을 통일성 없이 사용할 가능성

             설계자가 생각한 필수 기능(조회,저장 등) 과 기능에 대한 명칭(Search(), Inquire()) 상속받아서 
             각 클래스 별로 목적에 맞게 기능을 상세히 구현할수 있도록 하여 
             프로그램에 대한 일관성과 통일성 을 지키고 필수 기능 누락 상황을 예방 할 수 있다.



             abstract : 추상 클래스(부모클래스) 를 만들어 주는 키워드
             1. 상속 받는 클래스에서 반드시 구현 해야하는 기능
             2. 클래스 멤버 중 하나라도 abstract 형식이면 클래스 자체는 abstract 키워드를 부여해야 한다.
             3. 메서드의 기능명칭 만 정의 하되 구현은 상속 받은 클래스에서 한다.
                - 메서드의 본문을 정의 할 수 없다. (일반 메서드 를 작성 할 수 없다)
             4. Abstract 클래스 는 일반 함수 및 필드 멤버를 가질수 있다. 
             5. abstract 클래스 는 인스턴스 화(객체화) 할 수 없다. (기능 정의 와 상속 이 목적)

            **** 상속 받을 클래스에서 반드시 구현해야 하지만 누락 할 가능성이 있는 기능 을 
                 구현 할 수 있도록 강제 하는 기능. 
        */




        public Chap36_abstract_Polymorphism()
        {
            InitializeComponent();
        }
        #endregion

        #region < 2. 상속한 클래스의 기능 실행. 및 업 캐스팅 > 
        private void btnAbstract_Click(object sender, EventArgs e)
        {
            ItemMaster itemr = new ItemMaster();
            // ItemMaster() 생성자에있는 기능을 실행하고 (초기화)
            // new   :  그 결과를 Heap 메모리에 등록 을해라. 
            // itemr : Stack 에 itemr 이라는 이름으로 등록 하고
            // =     : new 로 생성한 Heap 에 있는 메모리 주소를 itemr 에 전달하라. 



            // 추상 클래스 는 인스턴스화 할 수 없다(기능 정의 와 상속이 목적)
            //ToolBar toolBar = new ToolBar();

            // ItemMaster 클래스의 인스턴스 화 및 기능 실행. 
            ItemMaster itemM = new ItemMaster();
            itemM.DoSearch(); // 추상클래스(Toolbar) 에서 상속 받아 구현을 강제 받은 메서드.
            itemM.DoSave();   // 추상클래스(Toolbar) 에서 상속 받아 구현을 강제 받은 메서드.
            itemM.DoPrint();  // 품목 마스터(ItemMaster) 클래스에서 별도로 구현한 메서드.

            // 추상 클래스의 업캐스팅
            // 부모 클래스의 기능 중 자식 클래스가 오버라이드(구현 선언)
            // 한 기능을 부모 클래스의 객체로 형변환후 실행 할 수 있다.
            ToolBar toolBar = new ItemMaster(); // 업캐스팅
            toolBar.DoSearch();
            toolBar.DoSave();
            //toolBar.DoPrint(); 
        }

        // 업 캐스팅을 왜 ? 쓰는 걸까 ? 
        // 3 과 같이 ToolBar 클래스를 상속 받는 클래스가 여러개 있을경우
        // 품목 조회, 사용자 조회, 작업장 조회 버튼을 클릭 하면 각각 의 조회 기능을 실행 해야 하는 경우

        #endregion

        #region < 4. 업 캐스팅을 통한 추상메서드 기능 호출.>




        // 아래 3개의 메서드 는 불필요한 로직이 반복 되어 
        // 메서드 하나로 줄인다.
        //private void btnUserSearch_Click(object sender, EventArgs e)
        //{
        //    // 사용자 정보 조회 기능 
        //    UserMaster UM = new UserMaster();
        //    UM.DoSearch(); // 사용자 정보 조회 기능 실행
        //}

        //private void btnCustSearch_Click(object sender, EventArgs e)
        //{
        //    CustMaster CM  = new CustMaster();
        //    CM.DoSearch(); // 고객 정보 조회 기능 실행
        //}

        //private void btnItemSearch_Click(object sender, EventArgs e)
        //{
        //    ItemMaster IM = new ItemMaster();
        //    IM.DoSearch(); // 품목 정보 조회 기능 실행.
        //}

        // 리펙토링 : 프로그램 구현에 영향을 주지 않고 간결 하고 효율적인 코드로 꾸미는 작업.
        // 코드 리펙토링 1 번째 단계 
        //private void MenuSearch(object sender, EventArgs e)
        //{
        //    Button button = (Button)sender;
        //    if (button.Name == "btnUserSearch")
        //    {
        //        // 사용자 정보 조회 기능 
        //        UserMaster UM = new UserMaster();
        //        UM.DoSearch(); // 사용자 정보 조회 기능 실행
        //    }

        //    if (button.Name == "btnCustSearch")
        //    {
        //        // 고객 정보 조회 기능
        //        CustMaster CM = new CustMaster();
        //        CM.DoSearch(); // 고객 정보 조회 기능 실행
        //    }

        //    if (button.Name == "btnItemSearch")
        //    {

        //        // 품목 정보 조회 기능
        //        ItemMaster IM = new ItemMaster();
        //        IM.DoSearch(); // 품목 정보 조회 기능 실행.
        //    }
        //}


        // 코드 리펙터링 2 번째 단계 
        // 버튼에 Tag 를 두어 클래스를 가변적으로 생성. 
        //private void MenuSearch(object sender, EventArgs e)
        //{
        //    // 1. 버튼의 객체를 생성.
        //    Button button = (Button)sender;
        //    // 2. 찾으려는 클래스의 네임스페이스와 이름.
        //    string sClassName = $"MyFirstCSharp.{button.Tag}";
        //    // 3. 문자열로 클래스를 찾기. 
        //    Type type = Type.GetType(sClassName);
        //    // 4. 해당 클래스 를 인스턴스 화 하기. 
        //    object instence = Activator.CreateInstance(type);

        //    // 품목, 사용자, 고객 클래스 3개중에 하나
        //    // is : instecnce 객체가 itemmaster 클래스로 변환될수 있다면 (true/false)
        //    // if(instence is ItemMaster) 

        //    // as : instence 객체 가 Itemmaster 클래스로 변환 될수 있다면
        //    // 변환하고(ItemMaster IM Stack 메모리에 주소 를 전달하라)
        //    // 안되다면 null을 반환하라
        //    ItemMaster IM =  instence as ItemMaster; 
        //    if (IM != null)
        //    {
        //        IM.DoSearch(); // 품목마스터 클래스의 조회 기능을 실행.
        //    }

        //    CustMaster CM = instence as CustMaster;
        //    if (CM != null)
        //    {
        //        CM.DoSearch(); // 고객 마스터 클래스의 조회 기능을 실행.
        //    }

        //    UserMaster UM = instence as UserMaster;
        //    if (UM != null)
        //    {
        //        UM.DoSearch(); // 사용자 마스터 클래스의 조회 기능을 실행.
        //    }
        //    // 해당 클래스에 있는 기능을 호출 하기 위해서는 
        //    // 해당 클래스 의 객체를 선언 해야 한다. 
        //    // 만약 100 개의 화면이 있을경우 100개의 로직을 구현해 내야 한다.
        //    // 코드가 간결해지지 못하고 확장성 과 유지보수성이 떨어진다.
        //}



        // 코드 리펙터링 3 번째 단계 
        // 다형성을 통한 추상클래스 를 상속 받는 클래스 를 업캐스팅 (패턴).
        private void MenuSearch(object sender, EventArgs e)
        {
            // 1. 버튼의 객체를 생성.
            Button button = (Button)sender;
            // 2. 찾으려는 클래스의 네임스페이스와 이름.
            string sClassName = $"MyFirstCSharp.{button.Tag}";
            // 3. 문자열로 클래스를 찾기. 
            Type type = Type.GetType(sClassName);
            // 4. 해당 클래스 를 인스턴스 화 하기. 
            object instence = Activator.CreateInstance(type);

            // 다형성 을 구현하기 위한 기능 UPCasting
            // UPCasting 을 통한 다형성 등장. 
            // UPCasting : 부모 클래스 로 부터 구현을 정의 받은 기능을 
            //             자식클래스에서 구현하고 자식클래스가 부모 클래스로 형변환 되면서
            //             자식클래스의 기능을 부모 클래스의 객체 가 구현 할 수 있도록 하는 기능. 
            ToolBar TempMenu = instence as ToolBar;
            if (TempMenu != null)
            {
                TempMenu.DoSearch();
            }

            // 다형성 => UPCasting 기능을 통하여 구현.
            //- 어떤 객체의 속성이나 기능이 상황에 따라 여러 가지 형태를 가질 수 있는 성질
            //- 추상 클래스를 상속 받은 자식 클래스들이 부모의 클래스 로 업캐스팅 되어
            //  부모 클래스 형태로
            //  자식 클래스에서 구현한 부모 클래스의 기능을 동작 하도록 제어 하는 방법
            //  자식 클래스들의 기능 구현해야 할때 자식 객체를 N 개 객체화 할 필요가 없게 되므로
            //  코딩을 간결하게 표현 할 수 있다.


            // 추상 클래스 의 상속 과 다형성(업 캐스팅) 의 패턴. 
            // 추상클래스를 상속 받은 자식 클래스의 수가 많을때 에도 
            // 부모 클래스의 기능을 상속 받아 구현한 자식 클래스의 기능을 부모 클래스의 객체로 호출 할 수 있으므로
            // 코드가 간결해 지고
            // 확장성(자식 클래스가 N 개라도 다형성 코드를 수정 할 필요가 없다) 및
            // 유지 보수성(메서드 명칭을 변경 시 다형성 코드 만 수정 하면 됨) 이 확대 된다.

        }
        #endregion

    }
    #region < 1. 추상 클래스 의 생성 및 상속 > 
    // 모든 화면에서 구현해야 하는 기능 
    public abstract class ToolBar  // 멤버 중 하나라도 abstract 가 부여(추상화) 되어있을경우 클래스도 abstract(추상화) 를 설정해야한다.
    {
        public abstract void DoSearch(); // 반드시 구현해야 하는기능 1

        public abstract void DoSave(); // 반드시 구현해야 하는 기능 2

        public void DoSomthing()
        {
            // 로직이 구현되는 일반 메서드 를 작성 할 수 있다.
        }
        //public abstract void DoDelete()
        //{
        //    // abstract 멤버 에는 기능 구현 을 할 수 없다(일반 메서드 를 만들수 없다.)
        //    MessageBox.Show("");
        //}
    }

    class ItemMaster : ToolBar
    {
        // 부모 추상 클래스 에서 구현을 강제 하는 기능을 구현 하겠다 선언 키워드
        // Override : 내가 부모 클래스(추상클래스) 에서 지시한 기능을 구현하겠다. 
        public override void DoSearch()
        {
            MessageBox.Show("조건에 맞는 품목을 검색합니다.");
        }
        public override void DoSave()
        {
            MessageBox.Show("품목의 내용을 저장합니다.");
        }
        public void DoPrint()
        {
            MessageBox.Show("품목 화면을 출력합니다.");
        }
    }
    #endregion

    #region < 3. 추상 클래스를 상속 받는 추가 (클래스)화면 들 >
    class UserMaster : ToolBar
    {
        public override void DoSave()
        {
            MessageBox.Show("사용자 정보를 저장합니다.");
        }

        public override void DoSearch()
        {
            MessageBox.Show("사용자 정보를 조회합니다.");
        }
    }

    class CustMaster : ToolBar
    {
        public override void DoSave()
        {
            MessageBox.Show("고객 정보를 저장합니다.");
        }

        public override void DoSearch()
        {
            MessageBox.Show("고객 정보1를 조회합니다.");
        }
    }


    class CustMaster2 : ToolBar
    {
        public override void DoSave()
        {
            MessageBox.Show("고객 정보를 저장합니다.");
        }

        public override void DoSearch()
        {
            MessageBox.Show("고객 정보2를 조회합니다.");
        }
    }


    class CustMaster3 : ToolBar
    {
        public override void DoSave()
        {
            MessageBox.Show("고객 정보를 저장합니다.");
        }

        public override void DoSearch()
        {
            MessageBox.Show("고객 정보3를 조회합니다.");
        }
    }


    class CustMaster5 : ToolBar
    {
        public override void DoSave()
        {
            MessageBox.Show("고객 정보를 저장합니다.");
        }

        public override void DoSearch()
        {
            MessageBox.Show("고객 정보4를 조회합니다.");
        }
    }

    class CustMaster4 : ToolBar
    {
        public override void DoSave()
        {
            MessageBox.Show("고객 정보5를 저장합니다.");
        }

        public override void DoSearch()
        {
            MessageBox.Show("고객 정보5를 조회합니다.");
        }
    }
    #endregion


}
