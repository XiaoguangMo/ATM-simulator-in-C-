﻿using System;
using System.Linq;
using System.Windows.Forms;
using System.Xml;
using System.Media;
using System.Drawing;

namespace NNNOATM
{
    public partial class Login : Father
    //继承父类
    {
        int choose=0;

        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Verification verification = new Verification();
            verification.Show();
        }
        
        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void button2_Click(object sender, EventArgs e)
        {
            //引用父类MD5方法，生成加密的密码
            string password = Encryption(Passwordtext.Text.Trim(), Passwordtext.Text);
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load("account.xml");
            //读取xml文件
            XmlNodeList xnl = xmlDoc.SelectSingleNode("Table").ChildNodes;
            //选择表单
            foreach (XmlNode xn in xnl)
            {
                //遍历
                XmlElement xe = (XmlElement)xn;
                if (xe.GetAttribute("id") == Accounttext.Text)
                {
                    if (xe.GetAttribute("pw") == password)
                    {
                        //显示欢迎信息
                        MessageBox.Show("Login successfully!\nWelcome " + Accounttext.Text);    
                        //记录id并且用于在各个界面间传
                        string id = xe.GetAttribute("id");
                        string money = xe.GetAttribute("money");
                        //发邮件
                        sendEmail(xe.GetAttribute("ea"), id, "<br />You have logged in on the ATM.<br />You have " + money + " yuan in your account.<br />Time: " + DateTime.Now.ToString());
                        Main Main = new Main(Accounttext.Text);
                        Main.Show();
                        this.Visible = false;
                    }
                    
                }

            }           
            
        }

        private void PMouseClick(object sender, MouseEventArgs e)
        {
            //清空输入
            Passwordtext.Clear();
            //显示数字键盘
            Numberkeyboard.Visible = true;
            //设定数字键盘的输入显示到哪
            choose = 2;
            //数字键盘的数字随即排列
            changeButton();
        }

        private void IMouseClick(object sender, MouseEventArgs e)
        {
            Accounttext.Clear();
            Numberkeyboard.Visible = true;
            choose = 1;
            changeButton();
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar)
            {
                default: 
                    //只允许输入数字和退格
                    if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8)
                    {
                        e.Handled = true;
                        //播放提示音
                        SystemSounds.Beep.Play();
                    }
                    break;
            }
        }

        //数字小键盘的输入
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

        private void button7_Click(object sender, EventArgs e)
        {
            input("6");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            input("5");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            input("4");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            input("3");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            input("2");
        }

        private void button12_Click(object sender, EventArgs e)
        {
            input("1");
        }

        private void button14_Click(object sender, EventArgs e)
        {
            input("0");
        }

        private void button15_Click(object sender, EventArgs e)
        {
            //清空输入
            if (choose == 1)
            {
                Accounttext.Clear();
            }
            else
            {
                Passwordtext.Clear();
            }            
        }

        private void button13_Click(object sender, EventArgs e)
        {
            //退格的操作，每次都取整个输入的字符串，长度减1，再放回去
            if (choose == 1&&Accounttext.Text.Length > 0)
            {
                    String s = Accounttext.Text;
                    s = s.Substring(0, s.Length - 1);
                    Accounttext.Text = s;
            }
            else if (choose == 2&&Passwordtext.Text.Length > 0)
                {
                    String s = Passwordtext.Text;
                    s = s.Substring(0, s.Length - 1);
                    Passwordtext.Text = s;
                }  
            else
                //空字符串直接播放提示音
            SystemSounds.Beep.Play();
        }

        public void input(string input)
        {
            //数字小键盘的输入，
            if (choose == 1 && Accounttext.TextLength <= 20)
            {
                Accounttext.AppendText(input);
            }
            else if (choose == 2 && Passwordtext.TextLength < 6)
            {
                Passwordtext.AppendText(input);
            }
            else
                SystemSounds.Beep.Play();
        }

        public void changeButton()
        {
            //先建立一个数组存放随机数
            int[] result = new int[10];
            int temp;
            //用Random生成随机数
            Random ran = new Random();
            for (int i = 0; i < 10; i++)
            {
                temp = ran.Next(1, 11);
                //如果随机数与当前数列中的数不重复，则加进去
                if (!result.Contains(temp))
                {
                    result[i] = temp;
                }
                else
                    i--;
            }
            //根据生成的随机数分别给10个数字分配位置
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

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            //只允许输入数字和退格
            switch (e.KeyChar)
            {
                default: 
                    if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8)
                    {
                        e.Handled = true;
                        //输入错误则播放提示音
                        SystemSounds.Beep.Play();
                    }
                    break;
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            //登陆后就循环播放背景音乐
            System.Media.SoundPlayer sp = new System.Media.SoundPlayer();
            sp.SoundLocation = @"backgroundmusic.wav";
            sp.PlayLooping();
        }

        private void textBox2_MouseHover(object sender, EventArgs e)
        {
            tip1.Visible = true;
        }

        private void textBox2_MouseLeave(object sender, EventArgs e)
        {
            tip1.Visible = false;
        }

        private void textBox1_MouseHover(object sender, EventArgs e)
        {
            tip2.Visible = true;
        }

        private void textBox1_MouseLeave(object sender, EventArgs e)
        {
            tip2.Visible = false;
        }
    }
}
