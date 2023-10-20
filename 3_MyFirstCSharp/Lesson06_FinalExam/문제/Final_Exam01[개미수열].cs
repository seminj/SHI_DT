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
    public partial class Final_Exam01 : Form
    {
        public Final_Exam01()
        {
            InitializeComponent();
        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            
        }

        public class AntSequence
        {
            public static void Main()
            {
                int n = 15; // 수열의 길이

                string antSequence = GenerateAntSequence(n);

                Console.WriteLine(antSequence);
            }

            public static string GenerateAntSequence(int n)
            {
                string sequence = "1"; // 초기 수열은 1로 시작

                for (int i = 1; i < n; i++)
                {
                    sequence = GetNextSequence(sequence);
                }

                return sequence;
            }

            public static string GetNextSequence(string sequence)
            {
                StringBuilder builder = new StringBuilder();
                int count = 1;

                for (int i = 0; i < sequence.Length; i++)
                {
                    if (i < sequence.Length - 1 && sequence[i] == sequence[i + 1])
                    {
                        count++;
                    }
                    else
                    {
                        builder.Append(count.ToString());
                        builder.Append(sequence[i]);
                        count = 1;
                    }
                }

                return builder.ToString();
            }
        }
    }





}














public class AntSequence
{
    public static void Main()
    {
        int n = 15; // 수열의 길이

        string antSequence = GenerateAntSequence(n);

        Console.WriteLine(antSequence);
    }

    public static string GenerateAntSequence(int n)
    {
        string sequence = "1"; // 초기 수열은 1로 시작

        for (int i = 1; i < n; i++)
        {
            sequence = GetNextSequence(sequence);
        }

        return sequence;
    }

    public static string GetNextSequence(string sequence)
    {
        StringBuilder builder = new StringBuilder();
        int count = 1;

        for (int i = 0; i < sequence.Length; i++)
        {
            if (i < sequence.Length - 1 && sequence[i] == sequence[i + 1])
            {
                count++;
            }
            else
            {
                builder.Append(count.ToString());
                builder.Append(sequence[i]);
                count = 1;
            }
        }

        return builder.ToString();
    }
}
