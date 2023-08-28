using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFirstCSharp
{
    public partial class Chap21_Collection_Test_T : Form
    {
        public Chap21_Collection_Test_T()
        {
            InitializeComponent();
        }

        

        private void btnResult1_Click(object sender, EventArgs e)
        {
            // 중복 되지 않는 문자 찾기( For in For)
            string sTitle = lbltitle.Text;

            // 1. 기준 문자 담을 변수
            // 캐릭터 변수에 기본값 설정 /0: null의 코드
            char cStandardWord = default(char);

            // 중복 문자가 아닌 첫 문자를 찾았을 경우를 알리는 bool
            bool bFindFlag = false;
            // i : 문자열 (타이틀)에서 기준이 되는 문자를 가리키는 index가 됨
            for (int i = 0; i < sTitle.Length; i++)
            {
                cStandardWord = sTitle[i];
                // j : i 문자가 있는지 없는지 찾을 문자열의 index
                for (int j = 0; j < sTitle.Length; j++)
                {
                    if (i == j) continue;// 아래 j 포문에 영향을 주는 애
                    // 기준문자 i가 자기자신을 비교할 경우j 는 
                    if (sTitle[i] == sTitle[j])
                    {
                        // 중복 단어를 찾은 경우
                        bFindFlag = true; 
                        break;
                    }
                }
                if (!bFindFlag) break;
                else
                {
                    bFindFlag = false;
                    continue;
                }
            }
            MessageBox.Show($"중복되지 않은 가장 첫 문자는 {cStandardWord}입니다.");
        }

        private void btnLastIndexOf_Click(object sender, EventArgs e)
        {
            // LastIndexOf 방식()

            string sTitle = lbltitle.Text;

            // 기준 문자 담을 변수
            char cStandardWord = default(char);

            bool bFindFlag = false; // 중복되지 않은 문자를 찾은 경우 true
            // 반복문 시작
            // i : 기준 문자가 위치하는 index 정보
            for (int i = 0; i < sTitle.Length;i++)
            {
                cStandardWord = sTitle[i]; // 기준문자 할당
                // 현재 기준 문자가 있는 i 의 위치와 기준 문자를
                // 마지막부터 찾은 LastIndexOf 의 주소값이 같을 경우 = 자기자신.중복되지 않은 문자를 찾은 경우가 됨
                if (i == sTitle.LastIndexOf(sTitle[i]))
                {
                    // 중복되지 않은 문자를 찾았을 경우
                    bFindFlag = true;
                    break;
                }
            }
            if (bFindFlag)
            {
                MessageBox.Show($"중복되지 않은 문자는 {cStandardWord}입니다. ");
            }
            else
            {
                MessageBox.Show("중복되지 않은 문자를 찾지 못했습니다. ");
            }
        }

        private void btnDictionary_Click(object sender, EventArgs e)
        {
            //Dictionary 와 Foreach를 사용
            // 중복 되지 않은 문자열 찾기 Dictionary 와 Foreach

            string sTitle = lbltitle.Text;
            // 문자열에서 한글자씩 가지고와서 Key로 생성, Key의 데이터 타입은 char형식

            Dictionary<char, int> dic = new Dictionary<char, int>();


            // 타이틀에서 한글자씩 추출하고 Dictionary 에 Key 의 값으로 등록하는데 Key의 값으로 이미 등록되어있으면 1 증가
            // Key의 값으로 등록되어있지 않은 상태라면, 1
            foreach (char cWord in sTitle)
            {
                if (dic.ContainsKey(cWord) == true)
                {
                    // 딕셔너리에 추출한 글자로 된 Key가 있을 경우
                    dic[cWord]++; //dic[cWord] = dic[cWord] + 1;
                }
                else //(dic.ContainsKey(cWord))
                {
                    dic[cWord] = 1;
                }
            }

            // DIctionary 의 key 를 추출하는 기능.
            // dic.Keys
            foreach (char iValue in dic.Keys)
            {
                if (dic[iValue] == 1)
                {
                    MessageBox.Show($"중복되지 않은 첫 글자는 {iValue}입니다. ");
                    break;// return ;
                }
            }
        }
    }
}
