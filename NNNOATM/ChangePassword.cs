using System;
using System.Linq;
using System.Windows.Forms;
using System.Xml;
using System.Media;

namespace NNNOATM
{
    public partial class ChangePassword : Father
    {
        string id;
        int time = 60;
        int choose = 0;

        public ChangePassword(string pid)
        {
            id = pid;
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //倒数计时退出
            time--;
            number.Text = "" + time;
            if (time == 0)
            {
                timer1.Stop();
                Login Login = new Login();
                Login.Show();
                this.Visible = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Main Main = new Main(id);
            Main.Show();
            this.Visible = false;
        }

        private void textBox1_MouseClick(object sender, MouseEventArgs e)
        {
            //单击清空输入并打开数字键盘
            PWtext.Clear();
            numberkeyboard.Visible = true;
            choose = 1;
            changeButton();
        }

        private void textBox2_MouseClick(object sender, MouseEventArgs e)
        {
            Repeattext.Clear();
            numberkeyboard.Visible = true;
            choose = 2;
            changeButton();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar)
            {
                    //只允许输入数字和退格，输错则播放提示音
                default: //8 is the ASCII for backspace
                    if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8)
                    {
                        e.Handled = true;
                        SystemSounds.Beep.Play();
                    }
                    break;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar)
            {
                //只允许输入数字和退格，输错则播放提示音
                default: //8 is the ASCII for backspace
                    if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8)
                    {
                        e.Handled = true;
                        SystemSounds.Beep.Play();
                    }
                    break;
            }
        }

        //数字键盘的输入
        private void button4_Click(object sender, EventArgs e)
        {
            input("7");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            input("8");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            input("9");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            input("4");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            input("5");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            input("6");
        }

        private void button12_Click(object sender, EventArgs e)
        {
            input("1");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            input("2");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            input("3");
        }

        private void button14_Click(object sender, EventArgs e)
        {
            input("0");
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (choose == 1&&PWtext.Text.Length > 0)
            {
                    String s = PWtext.Text;
                    s = s.Substring(0, s.Length - 1);
                    PWtext.Text = s;
            }
            else if (choose == 2&&Repeattext.Text.Length > 0)
                {
                    String s = Repeattext.Text;
                    s = s.Substring(0, s.Length - 1);
                    Repeattext.Text = s;
                }
            else
            SystemSounds.Beep.Play();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (choose == 1)
            {
                PWtext.Clear();
            }
            else
            {
                Repeattext.Clear();
            }
        }

        public void input(string input)
        {
            if (choose == 1 && PWtext.TextLength < 6)
            {
                PWtext.AppendText(input);
            }
            else if (choose == 2 && Repeattext.TextLength < 6)
            {
                Repeattext.AppendText(input);
            }
            else
                SystemSounds.Beep.Play();
        }

        private void changeButton()
        {
            //改变数字键盘的排序
            int[] result = new int[10];
            int temp;
            Random ran = new Random();
            for (int i = 0; i < 10; i++)
            {
                temp = ran.Next(1, 11);
                if (!result.Contains(temp))
                {
                    result[i] = temp;
                }
                else
                    i--;
            }
            //7
            if (result[0] < 4)
            {
                number7.Left = (result[0] - 1) * 36;
                number7.Top = 0;
            }
            else if (result[0] < 7 && result[0] > 3)
            {
                number7.Left = (result[0] - 4) * 36;
                number7.Top = 36;
            }
            else if (result[0] < 10 && result[0] > 6)
            {
                number7.Left = (result[0] - 7) * 36;
                number7.Top = 72;
            }
            else
            {
                number7.Left = 36;
                number7.Top = 108;
            }
            //8
            if (result[1] < 4)
            {
                number8.Left = (result[1] - 1) * 36;
                number8.Top = 0;
            }
            else if (result[1] < 7 && result[1] > 3)
            {
                number8.Left = (result[1] - 4) * 36;
                number8.Top = 36;
            }
            else if (result[1] < 10 && result[1] > 6)
            {
                number8.Left = (result[1] - 7) * 36;
                number8.Top = 72;
            }
            else
            {
                number8.Left = 36;
                number8.Top = 108;
            }
            //9
            if (result[2] < 4)
            {
                number9.Left = (result[2] - 1) * 36;
                number9.Top = 0;
            }
            else if (result[2] < 7 && result[2] > 3)
            {
                number9.Left = (result[2] - 4) * 36;
                number9.Top = 36;
            }
            else if (result[2] < 10 && result[2] > 6)
            {
                number9.Left = (result[2] - 7) * 36;
                number9.Top = 72;
            }
            else
            {
                number9.Left = 36;
                number9.Top = 108;
            }
            //4
            if (result[3] < 4)
            {
                number6.Left = (result[3] - 1) * 36;
                number6.Top = 0;
            }
            else if (result[3] < 7 && result[3] > 3)
            {
                number6.Left = (result[3] - 4) * 36;
                number6.Top = 36;
            }
            else if (result[3] < 10 && result[3] > 6)
            {
                number6.Left = (result[3] - 7) * 36;
                number6.Top = 72;
            }
            else
            {
                number6.Left = 36;
                number6.Top = 108;
            }
            //5
            if (result[4] < 4)
            {
                number5.Left = (result[4] - 1) * 36;
                number5.Top = 0;
            }
            else if (result[4] < 7 && result[4] > 3)
            {
                number5.Left = (result[4] - 4) * 36;
                number5.Top = 36;
            }
            else if (result[4] < 10 && result[4] > 6)
            {
                number5.Left = (result[4] - 7) * 36;
                number5.Top = 72;
            }
            else
            {
                number5.Left = 36;
                number5.Top = 108;
            }
            //6
            if (result[5] < 4)
            {
                number4.Left = (result[5] - 1) * 36;
                number4.Top = 0;
            }
            else if (result[5] < 7 && result[5] > 3)
            {
                number4.Left = (result[5] - 4) * 36;
                number4.Top = 36;
            }
            else if (result[5] < 10 && result[5] > 6)
            {
                number4.Left = (result[5] - 7) * 36;
                number4.Top = 72;
            }
            else
            {
                number4.Left = 36;
                number4.Top = 108;
            }
            //1
            if (result[6] < 4)
            {
                number3.Left = (result[6] - 1) * 36;
                number3.Top = 0;
            }
            else if (result[6] < 7 && result[6] > 3)
            {
                number3.Left = (result[6] - 4) * 36;
                number3.Top = 36;
            }
            else if (result[6] < 10 && result[6] > 6)
            {
                number3.Left = (result[6] - 7) * 36;
                number3.Top = 72;
            }
            else
            {
                number3.Left = 36;
                number3.Top = 108;
            }
            //2
            if (result[7] < 4)
            {
                number2.Left = (result[7] - 1) * 36;
                number2.Top = 0;
            }
            else if (result[7] < 7 && result[7] > 3)
            {
                number2.Left = (result[7] - 4) * 36;
                number2.Top = 36;
            }
            else if (result[7] < 10 && result[7] > 6)
            {
                number2.Left = (result[7] - 7) * 36;
                number2.Top = 72;
            }
            else
            {
                number2.Left = 36;
                number2.Top = 108;
            }
            //3
            if (result[8] < 4)
            {
                number1.Left = (result[8] - 1) * 36;
                number1.Top = 0;
            }
            else if (result[8] < 7 && result[8] > 3)
            {
                number1.Left = (result[8] - 4) * 36;
                number1.Top = 36;
            }
            else if (result[8] < 10 && result[8] > 6)
            {
                number1.Left = (result[8] - 7) * 36;
                number1.Top = 72;
            }
            else
            {
                number1.Left = 36;
                number1.Top = 108;
            }
            //0
            if (result[9] < 4)
            {
                number0.Left = (result[9] - 1) * 36;
                number0.Top = 0;
            }
            else if (result[9] < 7 && result[9] > 3)
            {
                number0.Left = (result[9] - 4) * 36;
                number0.Top = 36;
            }
            else if (result[9] < 10 && result[9] > 6)
            {
                number0.Left = (result[9] - 7) * 36;
                number0.Top = 72;
            }
            else
            {
                number0.Left = 36;
                number0.Top = 108;
            }
            //←
            delete.Left = 0;
            delete.Top = 108;
            //clr
            clear.Left = 72;
            clear.Top = 108;
        }

        //鼠标移上去显示提示信息，移走则消失
        private void textBox1_MouseHover(object sender, EventArgs e)
        {
            tip1.Visible = true;
        }

        private void textBox1_MouseLeave(object sender, EventArgs e)
        {
            tip1.Visible = false;
        }

        private void textBox2_MouseHover(object sender, EventArgs e)
        {
            tip2.Visible = true;
        }

        private void textBox2_MouseLeave(object sender, EventArgs e)
        {
            tip2.Visible = false;
        }

        private void Change_Click(object sender, EventArgs e)
        {
            if (PWtext.Text == Repeattext.Text && PWtext.Text.Length == 6 && Repeattext.Text.Length == 6)
            {
                string password = Encryption(Repeattext.Text.Trim(), Repeattext.Text);
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.Load("account.xml");
                XmlNodeList xnl = xmlDoc.SelectSingleNode("Table").ChildNodes;
                foreach (XmlNode xn in xnl)
                {
                    XmlElement xe = (XmlElement)xn;
                    if (xe.GetAttribute("id") == id)
                    {
                        xe.SetAttribute("pw", password);
                        emailto = xe.GetAttribute("ea");
                        string money = xe.GetAttribute("money");
                        xmlDoc.Save("account.xml");
                        timer1.Stop();
                        SystemSounds.Exclamation.Play();
                        MessageBox.Show("ID: " + id + "\nYou have change your password to " + PWtext.Text);
                        sendEmail(emailto, id, "<br />You have changed your password to " + PWtext.Text + " on the ATM.<br />You have " + money + " yuan in your account.<br />Time: " + DateTime.Now.ToString());
                        timer1.Stop();
                        Main Main = new Main(id);
                        Main.Show();
                        this.Visible = false;
                    }
                }
            }
            else
            {
                SystemSounds.Hand.Play();
                MessageBox.Show("Your password's length should be 6 and two input should be the same!");
            }
        }
    }
}
