using System;
using System.Collections;
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
    public partial class Chap21_Collection : Form
    {
        // Collection
        // 특정 데이터를 여러개 담아서 관리 할 수 있는 자료형 구조
        // 몽땅 포함하여 Collection 이라고한다.
        // Collection 이라고 불리는 자료형 구조들(List, ArrayList, Dic, Stack...) 등은 모두 Collection을 상속받아 구현된 개체(클래스)
        // Collection(인터페이스) : 데이터를 나열하여 (열거) 관리할 수 있도록 정의하는 기준
        //          [List, ArrayList, Stack 과 같은 자료형들이 **파생**이 되어서 생성이 되는 것,
        //          부모(컬렉션)으로부터 상속받은 자식(리스트, 어레이, 스택)들 각자의 개성]
        // Collection 이라고 불리는 자료형 구조들 (List,ArrayList,Dic,Stack...)
        // 

        public Chap21_Collection()
        {
            InitializeComponent();
        }
        #region < LIST >
        private void Chap21_Collection_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // List <Collection 의 기능을 구현하는 구현체>
            // 배열과 유사한 열거형 데이터 자료
            // 크기가 가변적인 데이터를 담을 수 있다.

            // 요소 : index와 데이터값을 통틀어 부르는 말

            // 1. 리스트의 생성
            // int[]
            List<int> list_iValues = new List<int>(); // 정수형 List의 생성
                                                      // 정수형 List 클래스를 list_iValues 라는 이름으로 new 키워드를 이용하여 
                                                      // 객체화(사용가능한 실체)하여 현재 블럭에서 사용하겠다.

            // string[]
            List<string> list_sValues = new List<string>(); // 문자열 형 List 의 생성

            // 2. 리스트에 데이터 할당
            list_iValues.Add(100);
            list_iValues.Add(44);
            list_sValues.Add("안녕하세요");
            list_sValues.Add("반갑습니다");// 배열보다는 유연하게 사용한다. 실무에서는 list사용

            // 3. 리스트 생성과 동시에 값 할당/**/
            List<int> list_iValues2 = new List<int>() { 11, 34, 53, 119, 3300 };

            // 4. 리스트의 개수를 확인 / Count 사용
            // 배열 개수 : Length 
            MessageBox.Show($"list_iValues2 의 데이터 개수는 {list_iValues2.Count} 입니다.");

            // 5. 리스트 요소의 데이터 확인하기
            StringBuilder sb = new StringBuilder();

            // 5-1 **열거형이므로 Foreach를 사용**하여 데이터 추출 가능
            foreach (int iValue in list_iValues2) 
            {
                sb.Append(iValue + "\r\n");
            }
            MessageBox.Show(sb.ToString());

            sb.Clear(); // 스트링 빌더의 값 초기화
            // 5-2 For 를 이용하여 index의 데이터를 추출
            // 배열과 마찬가지로 데이터(Data)의 주소(index)를 이용하여 요소를 관리
            for(int i = 0; i < list_iValues2.Count; i++)
            {
                sb.Append(list_iValues2[i] + "\r\n");
            }
            MessageBox.Show(sb.ToString());

            // List 는 클래스, 배열과 마찬가지로 참조형
            // 기본적으로 클래스는 참조형. Heap 메모리 영역에 등록
            // int[] iValues [101, 201, 301, 401]    heap(101, 201, 301, 40)
            // list<int> iList [100, 200]           

            // 6. List 의 복사
            // 6-1 참조 전달 . (앝은 복사)
            List<int> list_Copy = list_iValues2;
            list_Copy[0] = 55555;
            MessageBox.Show($"얕은 복사 방식으로 list_Copy[0]에 할당한 55555 값이list_iValues2[0] 값{list_iValues2[0]}과 동일합니다. ");

            // 6-2 Heap에 할당된 값 자체를 복사(깊은 복사)
            // .ToList() : 리스트를 깊은 복사하는 방법
            List<int> list_Copy2 = list_iValues2.ToList();
            list_Copy2[0] = 11;
            MessageBox.Show($"깊은복사 방식으로 list_iValues2의 값을 복사한 list_Copy2 리스트의 0번 주소 값이 11로 바뀌었지만. " +
                             $"list_iValues2[0]의값은 {list_iValues2[0]} 인것을 확인할 수 있습니다. ");
        }

        private void btnListII_Click(object sender, EventArgs e)
        {
            // 리스트 2. 
            List<int> list_i = new List<int>() { 11, 34, 53, 119, 119, 66, 150, 20, 300 };

            // 7. 리스트에 요소를 추가(index + 데이터)
            list_i.Insert(2, 300);

            // 8. 리스트의 특정 요소를 제거
            // Remove
            // - 데이터가 존재할 경우 데이터의 index 를 함께 삭제
            //   데이터가 없을 경우 아무일도 일어나지 않는다.
            //   * 해당 index가 삭제 되고난 후 순차적으로 채워넣기 식으로 재정렬
            //   가까운 index로부터 하나의 데이터가 삭제된다
            list_i.Remove(119);

            // Removeat
            // - index의 요소를 삭제
            //   해당 index를 삭제 후 index가 순차적으로 채워넣기 식으로 정렬
            list_i.RemoveAt(5); //119
            //list_i.RemoveAt(100);// 존재하지 않는 index의 경우 오류 발생

            // 9. 특정 조건을 만족할 경우 List 요소를 제거
            foreach(int iValue in list_i)
            {
                if(iValue > 100)
                {
                    list_i.Remove((int)iValue);
                }
            }

            /* Foreach 사용시 열거형 요소는 수정, 추가 할 수 없다. 
               Foreach 는 열거형 데이터를 읽기 전용으로 가져오기 때문에 
               최초 Foreach 문으로 읽어온 list_i 가 실행될 당시의 구조와 변형(갱신)되었을 경우
               마지막 요소까지 순차적으로 실행 할 수 없기 때문에 오류를 발생한다. */

            // 그러면? 특정 조건을 만족시킬 때 (ex. iValue > 100) 리스트의 요소를 삭제하는 방법?
            // i : 리스트의 index를 가리키는 정수

            /*// 해결 1 : index 의 요소를 삭제 후 현재 index를 다시 비교할 수 있도록 i를 1차감
            for (int i = 0; i < list_i.Count; i++)
            {
                if (list_i[i] > 100) // 100 이상은 삭제요청
                {
                    list_i.RemoveAt(i);
                    --i; // 하나빼고 다시 i++이면 자기자신.
                }
            }*/

            // 해결2 : 역 For 문을 이용하여 마지막 index로 부터 순차적으로 처리하도록 하는 방법
            for (int i = list_i.Count - 1; i >= 0; i--)
            {
                if (list_i[i] > 100)
                {
                    list_i.RemoveAt(i);
                }
            } 
            // 마지막 index로부터 검색 해서 올라올 경우 (역 For)
            // 현재 index의 요소가 삭제되더라도 현재 index 데이터 들만 재정렬 되므로
            // 다음 처리해야할 index(현재 index -1) 의 데이터는 위치 변경이 없으므로 원활히 삭제가 가능하다. 
        }
        #endregion

        #region < Array List>
        private void button1_Click_1(object sender, EventArgs e)
        {
            // ArrayList
            // - 데이터 형식에 상관없이 다중 데이터를 관리할 수 있는 데이터 타입
            // - 데이터 형식에 구애 없이 데이터가 할당 되므로 데이터를 확인할 때는 반드시 데이터형 변환이 이루어져야한다.

            // 1. ArrayList 의 생성
            // using System.Collections;
            // ArrayList 클래스가 있는 DDL파일(프로젝트, 어셈블리, 네임스페이스)
            ArrayList arraylist = new ArrayList();

            // 2. 데이터를 등록하는 방법
            for (int i = 0; i < 11; i++)
            {
                // arraylist 에 정수형 데이터를 0 ~ 10까지 할당
                arraylist.Add(i);
            }
            arraylist.Add("안녕하세요");
            // ArryaList 에 데이터를 등록할때 Object 형식으로 할당된다. (Boxing)

            // 오름차순 정렬 : 정수형데이터와 문자형데이터가 혼합되어있기 때문에 오류생성됨
            // arraylist.Sort();
            // 정수형 데이터와 문자 데이터가 혼합 등록 되어있으므로 오류가 발생

            // 데이터의 삭제
            arraylist.Remove(3); // 3이라는 값을 가진 데이터의 요소를 삭제

            arraylist.Remove("안녕하세요");

            arraylist.RemoveAt(3); // index의 요소를 삭제 

            // 요소의 등록
            arraylist.Insert(2, 40);

            // ArrayList 에 기존 컬렉션의 데이터를 추가하는 방법
            // arraylist <- int[]
            int[] iValues = { 1, 2, 3, 4 };
            // ArrayList 라는 클래스를 사용할껀데 정수배열 iValues를 던져 줄테니 이 값을 가지고 복사해서 초기값을 할당 후 (초기화) 사용하게 해주세요.
            ArrayList arraylist2 = new ArrayList(iValues);
            MessageBox.Show(arraylist2[0].ToString()); // 1
            arraylist2[0] = "안녕하세요";

            //int[] iValues2 = new int[] { 1,2,3,4,5 };
            //ArrayList arraylist3 = new ArrayList(iValues2);// new int[] {1,2,3,4,5});
            ArrayList arraylist3 = new ArrayList(new int[] {1,2,3,4,5});
        }
        #endregion

        private void btnQueue_Click(object sender, EventArgs e)
        {
            // Queue 
            // 선입 선출 방식의 자료 구조.
            // 데이터나 작업을 차례대로 입력된 순서에 따라 하나씩 처리
            // 웹 등에서 동영상이나 문서등의파일을 다운받을 때 순차적으로 처리하기 위해 데이터를 담을 때 주로 사용

            // 1. Queue 의 선언
            Queue<int> queue = new Queue<int>();

            // 2. Queue 에 데이터 등록
            // 데이터 할당하는 방식으로 등록하는 것이 아닌 데이터 등록 메서드가 별도로 존재
            queue.Enqueue(10); // 선입선출할 수 있는 데이터 정렬을 하는 기능
            queue.Enqueue(20);
            queue.Enqueue(30);
            queue.Enqueue(40);

            // 3. Queue 데이터를 확인
            // 어떤 데이터가 있는지 확인
            foreach(int iValue in queue)
            {
                MessageBox.Show("Foreach: " + iValue.ToString());
            }

            // Queue 의 데이터를 확인
            for (int i = 0;i < queue.Count; i++)
            {
                MessageBox.Show("Peek: " + queue.Peek().ToString());
                // 우선 순위가 높은 (선입) 데이터를 표현
                // 현재 추출될 데이터가 무엇인지 확인하고 로직을 처리하는데 사용
            }

            // Queue 의 데이터를 사용하기 위하여 추출하고 요소를 삭제
            while (queue.Count > 0)
            {
                MessageBox.Show(queue.Dequeue().ToString());// 순차적인 데이터 추출 10, 20, 30, 40
            }

            // 다른 컬렉션의 데이터를 Queue 에 담기
            Queue queue2 = new Queue(new int[] {1,2,3,4,5});

            // 리스트로 담기
            Queue queue3 = new Queue(new List<int>() 
            { 
                1, 2, 3, 4, 5 
            });

            /*// 위의 List 대입 문법은 아래와 같이 표현할 수 있다. 
            List<int> iValues = new List<int>();
            iValues.Add(1);
            iValues.Add(2);
            iValues.Add(3);
            iValues.Add(4);
            iValues.Add(5);

            List<int> iValues2 = new List<int>(){ 1, 2, 3, 4, 5 };
            Queue queue4 = new Queue(iValues2);*/

            // Queue
            // 데이터를 순차적으로 담아서 처리(선입 선출) 후 메모리에서 데이터를 삭제하므로 메모리 관리에 용이한 자료형 구조이나
            // 데이터가 휘발성(확인 후 삭제)되므로 필요한 곳에 따라서 잘 사용할 수 있도록 하자
        }

        private void btnStack_Click(object sender, EventArgs e)
        {
            // Stack : 선입 후출 방식의 데이터 자료 구조
            // 메모리 영역의 Stack과 이름은 같으나 자료형 구조의 Stack인 경우 Stack메모리 영역에 데이터가 관리되는 방법을 나타낸다.
            // 메모리 관리에 용이하다. (데이터 사용 후 즉각처리)
            
            // Stack 의 생성
            Stack<int>  stack = new Stack<int>();

            // Stack 에 데이터를 등록하는 방법
            stack.Push(10); // 후입 선출하기 위해 데이터를 재정렬하는 기능
            stack.Push(20); 
            stack.Push(30);
            stack.Push(40);

            // 데이터 확인
            foreach(int iValue in stack)
            {
                MessageBox.Show("Foreach : "+ iValue.ToString());
                // 나중에 들어온 데이터를 우선순위로 하여 보여준다.
            }

            // 데이터를 제거하지 않고 표현
            for (int i = 0; i < stack.Count; i++)
            {
                MessageBox.Show("Peek" + stack.Peek());
                // 40, 40, 40, 40
            }

            // 데이터를 추출 후 우선순위 재정렬
            // Pop: 데이터 추출 및 재정렬 하는 기능
            while(stack.Count > 0)
            {
                MessageBox.Show(stack.Pop().ToString());
            }
        }

        private void btnDictionary_Click(object sender, EventArgs e)
        {
            // Dictionary
            // 데이터가 담기는 주소를 Key로 설정하여 데이터를 등록하는 자료형

            // 1. Dictionary 의 생성
            Dictionary<string, int> MyDic = new Dictionary<string, int>();

            // 2. Dic 에 데이터 등록
            MyDic.Add("하나", 10);
            MyDic.Add("둘", 20);
            // MyDic.Add(1, "하나"); // Key 와 값의 데이터 자료형이 일치하지않는 오류 발생
            MyDic["셋"] = 40; // 셋이라는 키를 가진 요소를 새로 생성하면서 40값을 할당
            // iValues[0] = 40;

            // 3. Dic 의 데이터 확인
            MessageBox.Show(MyDic["셋"].ToString());

            // 4. Dic 복사
            // 참조 전달 복사( 주소 전달)
            Dictionary<string, int> MyDic_Copy = MyDic;
            MyDic_Copy["하나"] = 100;
            MessageBox.Show(MyDic["하나"].ToString());

            // 값 형태로 복사( 깊은 복사 )
            // MyDic_Copy2 이라는 이름으로 Dictionary 클래스의 기능을 사용할건데,
            // MyDic에 있는 값으로 새로운 메모리 데이터를 만들어서 할당하여 사용하게 해주세요
            Dictionary<string, int> MyDic_Copy2 = new Dictionary<string, int>(MyDic);
            MyDic["하나"] = 4000;
            MessageBox.Show(MyDic_Copy2["하나"].ToString());

            // 5. Key 를 사용하고 있는지 확인하는 기능
            if (MyDic.ContainsKey("하나"))
            {
                MessageBox.Show("하나라는 키를 사용하고 있습니다.");
            }
            else
            {
                MessageBox.Show("열이라는 키를 사용하고 있지않습니다.");
            }

            // 6. Value의 사용유무 확인
            if (MyDic.ContainsValue(100))
            {
                MessageBox.Show("100 값이 포함되어있습니다.");
            }
            else
            {
                MessageBox.Show("100 값이 포함되어있지 않습니다.");
            }

            // 데이터의 삭제
            MyDic.Remove("둘"); // "둘" 이라는 Key의 요소를 삭제 // 하나 셋만 남아있음
            // MyDic 의 Remove 는 해당 Key가 존재하지 않을 경우 오류가 반환되지 않는다. 
            MyDic.Remove("백");


        }

        private void button2_Click(object sender, EventArgs e)
        {
            // HashTable
            // Dictionary 와 유사한 기능을 가지지만 Key와 Value의 데이터 유형을 따로 정해주지 않는다. (object방식)
            // Value의 내용이 데이터 타입이 지정되지 않았으므로 호출시에는 반드시 형변환이 필요하다.

            // 생성 및 데이터 등록 
            Hashtable HT = new Hashtable();
            HT.Add("하나", 1);
            HT[10] = "십";
            HT["소수"] = 1.2;
            HT.Add(true, "트루");

            // 2. HashTable의 데이터 표현
            // (int): 명시적 형변환 캐스팅(강제 형변환)
            // * 반드시 변경 되어야하는 데이터 형이 정해져있어야(일치해야) 한다. 
            // int iValue = (int)HT[10];// unboxing 을 통한 데이터 타입 일치 /*컴파일 오류 발생: "십"을 정수로 나타내기때문
            string iValue = (string)HT[10];

            // 3. HashTable에 데이터 등록 방법(초기화)
            // 3-1 Dictionary 초기자로 초기화하는 방식
            Hashtable HT2 = new Hashtable() { ["일"] = 10, ["Two"] = 20, [2] = "이", [1.3] = 1.3 };
            //int[] iValues = new int[] {1,2,3,4,5};

            // 3-2 컬렉션의 초기자로 초기화 하는 방식
            Hashtable HT3 = new Hashtable() { { "하나", 1 }, { "둘", 2 }, { 1.3, 1.2 } };
            int[,] iValues = new int[3, 2] { { 1, 2 }, { 2, 3 }, { 3, 4 } };

            // 4. HashTable 의 복사
            // 4-1. 얕은 복사
            Hashtable HT4 = HT;

            //4-2 깊은 복사.
            //Heap에 등록된 값을 그대로 복사하여 새로 생성된 주소를 새로운 객체에 전달.
            Hashtable HT5 = new Hashtable(HT);

            //5. 키와 값 추가.
            HT.Add("육", 102);

            //6. 키와 값 삭제.
            HT.Remove("육");

            //7. 키의 존재 여부.
            bool bCheck;
            bCheck = HT.ContainsKey("육"); //육이라는 key가 존재하는지 확인.

            //8. 값의 존재여부 확인
            bCheck = HT.ContainsValue(102); //102값이 있는지 확인.

            //9. 데이터의 삭제.
            HT.Clear();

            // 자료형 구조. Collection
            // 크게 두가지 유형으로 나뉜다.
            // 1. 주소값 index 로 데이터를 관리하는 유형
            // - int[], List, ArrayList
            //  . 수정, 삭제 시 인덱스를 재정렬하고 주소값을 전달해야 하는 과정이 일어나므로 갱신속도가 떨어진다.
            //  . index 주소 값을 곧바로 찾아 가므로 조회에 대한 성능은 좋다. 

            // 2. Key 정보를 바탕으로 주소를 찾아가서 데이터를 관리하는 유형
            // - Dictionary, HashTable
            //  . 지정한 키를 통해 데이터를 등록 삭제하므로 Heap의 변경에 관계 없이 메모리 부하를 낮출 수 있다.
            // 수정, 삭제, 추가의 효율이 높다.
            //  . 조회의 성능은 떨어진다.(Key를 통하여 Heap메모리 주소를 참조)
        }
    }
}
