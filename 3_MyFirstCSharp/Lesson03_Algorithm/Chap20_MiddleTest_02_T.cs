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
    public partial class Chap20_MiddleTest_02_T : Form
    {
        public Chap20_MiddleTest_02_T()
        {
            InitializeComponent();
        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            {
                {
                    // 2차원 배열 만들기
                    int[,] iValues = { { 1, 4, 5, 9, 10, 12, 16 },
                             { 2, 7, 11, 13, 14, 15, 18 } };

                    // 찾은 쌍을 등록 해서 누적시킬 문자열 변수
                    string sValues = string.Empty;

                    // 배열의 행의 수 구하기
                    int iRowCnt = iValues.GetLength(0);

                    // 배열의 열의 수 구하기
                    int iColCnt = iValues.GetLength(1);

                    // 찾을 수 ( 20 - 기준값 )
                    int iFindValue = 0;

                    // 찾은 값( 배열에서 값을 찾았을 경우 )을 누적 시킬 배열
                    int[] iResults = new int[iRowCnt * iColCnt];
                    int iResultIndex = 0; // 찾은 값이 등록 될 주소

                    // 로직 수행 여부를 지정할 외부 변수 Bool
                    bool bBreakFlag = false;

                    // 반복의 횟수를 찾기 위한 Foreach Count
                    int iMvalueForeachCnt = 0; // 기준값 Foreach Count //iMain
                    int iSvalueForeachCnt = 0; // 찾을값 Foreach Count

                    // 2차원 배열에서 기준 값을 뽑아올 foreach
                    foreach (int iValue in iValues)
                    {
                        ++iMvalueForeachCnt;
                        bBreakFlag = false;
                        // bool bBreakFlag = false; 사용은 가능한데 메모리 많이 사용됨
                        // 메모화 기능을 이용한 벨리데이션
                        // 찾은 값이 등록되어 있는 배열에서 기준값이 등록 되어 있는지 확인
                        for (int i = 0; i < iResults.Length; i++)
                        {
                            if (iValue == iResults[i])
                            {
                                // 기존에 찾은 쌍의 값을 기준값으로 하여 찾으려 할 경우
                                // 중복 쌍을 찾는 경우이므로 등록 로직을 수행 할 필요가 없다
                                bBreakFlag = true;
                                break; // for 문에서 break 받고 나옴
                            }
                        }

                        if (bBreakFlag)
                        {
                            continue;
                        }

                        // 기준 값 과 합이 20 이 되는 쌍의 수 구하기
                        iFindValue = 20 - iValue; // 배열에서 찾을 수

                        // iR_Value : 기준 값에서 20 을 만들수 있는 대상 정수
                        foreach (int iR_Value in iValues)
                        {
                            ++iSvalueForeachCnt;
                            if (iMvalueForeachCnt == iSvalueForeachCnt)
                            {
                                break;
                            }

                            // 찾아야 되는 수 == 하나씩 추출한 수
                            if (iFindValue == iR_Value)
                            {
                                // 기준값과 합이 20이 되는 수가 배열에 존재
                                iResults[iResultIndex] = iR_Value; // 찾은 값을 메모화 배열에 등록
                                ++iResultIndex;
                                sValues += $"{iValue},{iR_Value}\r\n"; // 찾은 값의 쌍을 보여주기 위해 문자열에 등록
                            }

                        }
                        // 찾을값을 찾는 반복 횟수 0 으로 초기화
                        iSvalueForeachCnt = 0; // 초기화

                    }

                    MessageBox.Show(sValues);

                }
            }
        }
    }
}
