using System;
using System.Windows.Forms;
using System.Xml;
using System.Media;

namespace NNNOATM
{
    public partial class Transfer : Father
    {
        string id;
        int time = 60;

        public Transfer(string pid)
        {
            id = pid;
            InitializeComponent();
        }

        //一分钟不操作退出
        private void timer1_Tick(object sender, EventArgs e)
        {
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

        //单击输入框清空输入
        private void textBox1_MouseClick(object sender, MouseEventArgs e)
        {
            Accounttext.Clear();
        }

        private void textBox2_MouseClick(object sender, MouseEventArgs e)
        {
            Moneytext.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //验证输入合法
            if(Accounttext.Text!="You want to transfer to which account?"&&Accounttext.Text.Length!=0&&Moneytext.Text.Length!=0&&Moneytext.Text!="Transfer how much?"&&Convert.ToInt16(Moneytext.Text)!=0)
            {
                int check1 = 0;
                int check2 = 0;
                int money = 0; ;
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.Load("account.xml");
                XmlNodeList xnl = xmlDoc.SelectSingleNode("Table").ChildNodes;
                foreach (XmlNode xn in xnl)
                {
                    XmlElement xe = (XmlElement)xn;
                    //验证当前账户钱够支付转账手续费：按照中信银行标准，每笔2元
                    if (xe.GetAttribute("id") == id && Convert.ToInt32(xe.GetAttribute("money")) >= (2 + Convert.ToInt32(Moneytext.Text)))
                    {
                        check1 = 1;
                    }

                }
                foreach (XmlNode xn in xnl)
                {
                    XmlElement xe = (XmlElement)xn;
                    //验证目标账户存在
                    if (xe.GetAttribute("id") == Accounttext.Text)
                    {
                        check2 = 1;
                    }

                }
                //不符合要求则报错
                if (check2 == 0)
                {
                    SystemSounds.Hand.Play();
                    MessageBox.Show("You don't have enough money!");
                    return;
                    time = 60;
                }
                else if (check1 == 0)
                {
                    SystemSounds.Hand.Play();
                    MessageBox.Show("The account you want to transfer to is not exist!");
                    return;
                    time = 60;
                }
                else if (check1 == 1 && check2 == 1)
                {
                    //全部满足条件，开始转账
                    foreach (XmlNode xn in xnl)
                    {                        
                        //当前账户钱减少
                        XmlElement xe = (XmlElement)xn;
                        if (xe.GetAttribute("id") == id)
                        {
                            emailto = xe.GetAttribute("ea");
                            money =(Convert.ToInt32(xe.GetAttribute("money")) - 2 - Convert.ToInt32(Moneytext.Text));
                            xe.SetAttribute("money", "" + money);
                            xmlDoc.Save("account.xml");
                        }
                    }
                    foreach (XmlNode xn in xnl)
                    {
                        //目标账户钱增加
                        XmlElement xe = (XmlElement)xn;
                        if (xe.GetAttribute("id") == Accounttext.Text)
                        {
                            xe.SetAttribute("money", "" + (Convert.ToInt32(xe.GetAttribute("money")) + Convert.ToInt32(Moneytext.Text)));
                            xmlDoc.Save("account.xml");
                        }
                    }
                    //弹出提示信息，返回主菜单继续下一步操作
                    SystemSounds.Exclamation.Play();
                    MessageBox.Show("ID: " + id + "\nYou have transfered " + Moneytext.Text + " to " + Accounttext.Text + " .\nYou have " + money + " yuan in your account.\nTime: " + DateTime.Now.ToString());
                    sendEmail(emailto, id, "<br />You have transfered " + Moneytext.Text + " to " + Accounttext.Text + " .<br />You have " + money + " yuan in your account.<br />Time: " + DateTime.Now.ToString());
                    timer1.Stop();
                    Main Main = new Main(id);
                    Main.Show();
                    this.Visible = false;
                }
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar)
            {
                    //只能输入数字
                default: //8 is the ASCII for backspace
                    if (!Char.IsLetter(e.KeyChar) && !Char.IsDigit(e.KeyChar) && e.KeyChar != 8)
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
                    //只能输入数字
                default: //8 is the ASCII for backspace
                    if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8)
                    {
                        e.Handled = true;
                        SystemSounds.Beep.Play();
                    }
                    break;
            }
        }

        //鼠标移到输入框上面弹出提示信息，移开则消失
        private void Accounttext_MouseHover(object sender, EventArgs e)
        {
            tip1.Visible = true;
        }

        private void Accounttext_MouseLeave(object sender, EventArgs e)
        {
            tip1.Visible = false;
        }

        private void Moneytext_MouseHover(object sender, EventArgs e)
        {
            tip2.Visible = true;
        }

        private void Moneytext_MouseLeave(object sender, EventArgs e)
        {
            tip2.Visible = false;
        }
    }
}
