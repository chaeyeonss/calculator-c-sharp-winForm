using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class calculator : System.Windows.Forms.Form
    {
        /* 변수 설명
         * 
         * op: 현재 입력된 연산자 명령
         * first: 첫 번째 피연산자
         * second: 두 번째 피연산자
         * result: 계산 결과 값
         * 
         * isSecond: true면 두 번째 피연산자를 입력할 차례
         * followExp: 한 차례 계산이 끝난 뒤(등호를 입력한 뒤) 이어서 식을 계산하려는 경우
         *            즉, 계산 결과 값 이후 숫자가 아닌 연산자를 입력한 경우 followExp = true
         * newExp: 계산이 끝난 뒤 다시 숫자를 입력한 경우, 새로운 연산을 하려는 것이므로 newExp = true
         * 
             */
        char op;
        int first, second, result; 
        Boolean isSecond, followExp, newExp;

        // 생성자
        public calculator()
        {
            InitializeComponent();
        }

        // 폼이 로드되면
        private void Form1_Load(object sender, EventArgs e)
        {
            isSecond = false;
            followExp = false;
            newExp = true;
            label1.Text = "";
            label2.Text = "";
        }

        /* 숫자 키패드 */
        private void button1_Click(object sender, EventArgs e)
        {
            if (!newExp)
            {
                first = 0; second = 0; result = 0;
                textBox1.Text = "";
                label1.Text = "";
                newExp = true;
            }
            else if (isSecond)
            {
                textBox1.Text = "";
                isSecond = false;
            }
            else if (textBox1.Text.Length > 0 && textBox1.Text == "0")
            {
                textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
                label1.Text = label1.Text.Substring(0, label1.Text.Length - 1);
            }

            textBox1.Text += "1";
            label1.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!newExp)
            {
                first = 0; second = 0; result = 0;
                textBox1.Text = "";
                label1.Text = "";
                newExp = true;
            }
            else if (isSecond)
            {
                textBox1.Text = "";
                isSecond = false;
            }
            else if (textBox1.Text.Length > 0 && textBox1.Text == "0")
            {
                textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
                label1.Text = label1.Text.Substring(0, label1.Text.Length - 1);
            }
            textBox1.Text += "2";
            label1.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!newExp)
            {
                first = 0; second = 0; result = 0;
                textBox1.Text = "";
                label1.Text = "";
                newExp = true;
            }
            else if (isSecond)
            {
                textBox1.Text = "";
                isSecond = false;
            }
            else if (textBox1.Text.Length > 0 && textBox1.Text == "0")
            {
                textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
                label1.Text = label1.Text.Substring(0, label1.Text.Length - 1);
            }
            textBox1.Text += "3";
            label1.Text += "3";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (!newExp)
            {
                first = 0; second = 0; result = 0;
                textBox1.Text = "";
                label1.Text = "";
                newExp = true;
            }
            else if (isSecond)
            {
                textBox1.Text = "";
                isSecond = false;
            }
            else if (textBox1.Text.Length > 0 && textBox1.Text == "0")
            {
                textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
                label1.Text = label1.Text.Substring(0, label1.Text.Length - 1);
            }
            textBox1.Text += "4";
            label1.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (!newExp)
            {
                first = 0; second = 0; result = 0;
                textBox1.Text = "";
                label1.Text = "";
                newExp = true;
            }
            else if (isSecond)
            {
                textBox1.Text = "";
                isSecond = false;
            }
            else if (textBox1.Text.Length > 0 && textBox1.Text == "0")
            {
                textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
                label1.Text = label1.Text.Substring(0, label1.Text.Length - 1);
            }
            textBox1.Text += "5";
            label1.Text += "5";
        }
        
        private void button4_Click(object sender, EventArgs e)
        {
            if (!newExp)
            {
                first = 0; second = 0; result = 0;
                textBox1.Text = "";
                label1.Text = "";
                newExp = true;
            }
            else if (isSecond)
            {
                textBox1.Text = "";
                isSecond = false;
            }
            else if (textBox1.Text.Length > 0 && textBox1.Text == "0")
            {
                textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
                label1.Text = label1.Text.Substring(0, label1.Text.Length - 1);
            }
            textBox1.Text += "6";
            label1.Text += "6";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (!newExp)
            {
                first = 0; second = 0; result = 0;
                textBox1.Text = "";
                label1.Text = "";
                newExp = true;
            }
            else if (isSecond)
            {
                textBox1.Text = "";
                isSecond = false;
            }
            else if (textBox1.Text.Length > 0 && textBox1.Text == "0")
            {
                textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
                label1.Text = label1.Text.Substring(0, label1.Text.Length - 1);
            }
            textBox1.Text += "7";
            label1.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (!newExp)
            {
                first = 0; second = 0; result = 0;
                textBox1.Text = "";
                label1.Text = "";
                newExp = true;
            }
            else if (isSecond)
            {
                textBox1.Text = "";
                isSecond = false;
            }
            else if (textBox1.Text.Length > 0 && textBox1.Text == "0")
            {
                textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
                label1.Text = label1.Text.Substring(0, label1.Text.Length - 1);
            }
            textBox1.Text += "8";
            label1.Text += "8";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (!newExp)
            {
                first = 0; second = 0; result = 0;
                textBox1.Text = "";
                label1.Text = "";
                newExp = true;
            }
            else if (isSecond)
            {
                textBox1.Text = "";
                isSecond = false;
            }
            else if (textBox1.Text.Length > 0 && textBox1.Text == "0")
            {
                textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
                label1.Text = label1.Text.Substring(0, label1.Text.Length - 1);
            }
            textBox1.Text += "9";
            label1.Text += "9";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (!newExp)
            {
                first = 0; second = 0; result = 0;
                textBox1.Text = "";
                label1.Text = "";
                newExp = true;
            }
            else if (isSecond)
            {
                textBox1.Text = "";
                isSecond = false;
            }
            // 0만 입력했을 때 0은 계속 추가되지 않게 만들어야 한다.
            if (textBox1.Text == "0")
            {
                textBox1.Text += "";
                label1.Text += "";
            }
            else
            {
                textBox1.Text += "0";
                label1.Text += "0";
            }
        }

        /* 연산자 버튼 */
        private void button11_Click(object sender, EventArgs e)
        {
            op = '+';
            if (followExp)
            {
                label1.Text = textBox1.Text;
                followExp = false;
            }
            label1.Text += "+";
            first += int.Parse(textBox1.Text);
            isSecond = true;
            newExp = true;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            op = '-';
            if (followExp)
            {
                label1.Text = textBox1.Text;
                followExp = false;
            }
            label1.Text += "-";
            first += int.Parse(textBox1.Text);
            isSecond = true;                  // 두 번째 피연산자 입력될 차례
            newExp = true;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            op = '*';
            if (followExp)
            {
                label1.Text = textBox1.Text;
                followExp = false;
            }
            label1.Text += "*";
            first += int.Parse(textBox1.Text);
            isSecond = true;
            newExp = true;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            op = '/';
            if (followExp)
            {
                label1.Text = textBox1.Text;
                followExp = false;
            }
            label1.Text += "/";
            first += int.Parse(textBox1.Text);
            isSecond = true;
            newExp = true;
        }

        /* clear 버튼 */
        private void button16_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            label1.Text = "";
            followExp = false; isSecond = false;
            first = 0; second = 0; result = 0;
        }

        /* backspace 버튼 */
        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
            label1.Text = label1.Text.Substring(0, label1.Text.Length - 1);
        }

        /* 등호 버튼 */
        private void button15_Click(object sender, EventArgs e)
        {
            second = int.Parse(textBox1.Text);
            if (op == '+') result = first + second;
            if (op == '-') result = first - second;
            if (op == '*') result = first * second;
            if (op == '/') result = first / second;
            textBox1.Text = result.ToString();
            label2.Text += "\n" + label1.Text + " = " + textBox1.Text;
            first = 0; second = 0;
            followExp = true;
            newExp = false;
        }
    }
}
