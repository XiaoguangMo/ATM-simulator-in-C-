using System;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Xml;
using System.Media;


namespace NNNOATM
{
    public partial class Create : Father
    {
        int time = 60;

        public Create()
        {
            InitializeComponent();
        }

        private void IKeyPress(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar)
            {
                    //只允许数字输入
                default: //8 is the ASCII for backspace
                    if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8)
                    {
                        e.Handled = true;
                        SystemSounds.Beep.Play();
                    }
                    break;
            }
        }
                
        private void NKeyPress(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar)
            {
                    //只允许数字输入
                default: //8 is the ASCII for backspace
                    if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8)
                    {
                        e.Handled = true;
                        SystemSounds.Beep.Play();
                    }
                    break;
            }
        }
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            //倒数计时
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

        private void button1_Click(object sender, EventArgs e)
        {
            //利用正则验证邮箱和生日的输入是否正确
            Regex reg1 = new Regex(@"^(?:(?!0000)[0-9]{4}-(?:(?:0[1-9]|1[0-2])-(?:0[1-9]|1[0-9]|2[0-8])|(?:0[13-9]|1[0-2])-(?:29|30)|(?:0[13578]|1[02])-31)|(?:[0-9]{2}(?:0[48]|[2468][048]|[13579][26])|(?:0[48]|[2468][048]|[13579][26])00)-02-29)$");
            string regexEmail = @"\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*";
            RegexOptions options = ((RegexOptions.IgnorePatternWhitespace | RegexOptions.Multiline) | System.Text.RegularExpressions.RegexOptions.IgnoreCase);
            Regex reg2 = new Regex(regexEmail, options);
            //密码转MD5码
            string password = Encryption(Passwordtext.Text.Trim(), Passwordtext.Text);
            if (Accounttext.Text.Length != 0&&Accounttext.Text != "Please input your ID")
            {
                if (Passwordtext.Text.Length == 6)
                {
                    if (reg2.IsMatch(Emailtext.Text))
                    {
                        if (reg1.IsMatch(Birthdaytext.Text))
                        {
                            //全部符合要求则建立账户
                            XmlDocument xmlDoc = new XmlDocument();
                            xmlDoc.Load("account.xml");
                            XmlNode root = xmlDoc.SelectSingleNode("Table");
                            XmlElement xe1 = xmlDoc.CreateElement("account");
                            xe1.SetAttribute("id", Accounttext.Text);
                            xe1.SetAttribute("pw", password);
                            xe1.SetAttribute("ea", Emailtext.Text);
                            xe1.SetAttribute("bd", Birthdaytext.Text);
                            xe1.SetAttribute("money", "0");
                            root.AppendChild(xe1);
                            xmlDoc.Save("account.xml");
                            //显示欢迎信息
                            MessageBox.Show("Account created successfully!\nWelcome " + Accounttext.Text + "!");
                            timer1.Stop();
                            Main Main = new Main(Accounttext.Text);
                            Main.Show();
                            this.Close();
                        }
                            //各种输入不符合规范，弹出提示信息
                        else
                        {
                            SystemSounds.Hand.Play();
                            MessageBox.Show("Your birthday 's form should be ????-??-??");
                            time = 60;
                        }
                    }
                    else
                    {
                        SystemSounds.Hand.Play();
                        MessageBox.Show("Please input an available email address!");
                        time = 60;
                    }
                }
                else
                {
                    SystemSounds.Hand.Play();
                    MessageBox.Show("Your password should be digits with length of 6");
                    time = 60;
                }
            }
            else
            {
                SystemSounds.Hand.Play();
                MessageBox.Show("Please input an account ID!");
                time = 60;
            }
        }

        //单击输入框清空输入
        private void textBox4_MouseClick(object sender, MouseEventArgs e)
        {
            Birthdaytext.Clear();
        }

        private void textBox3_MouseClick(object sender, MouseEventArgs e)
        {
            Emailtext.Clear();
        }

        private void textBox2_MouseClick(object sender, MouseEventArgs e)
        {
            Passwordtext.Clear();
        }

        private void textBox1_MouseClick(object sender, MouseEventArgs e)
        {
            Accounttext.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop(); 
            Login Login = new Login();
            Login.Show();
            this.Visible = false;
        }

        //鼠标移到输入框上则显示当前输入框的提示信息，移开则消失
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

        private void textBox3_MouseHover(object sender, EventArgs e)
        {
            tip3.Visible = true;
        }

        private void textBox3_MouseLeave(object sender, EventArgs e)
        {
            tip3.Visible = false;
        }

        private void textBox4_MouseHover(object sender, EventArgs e)
        {
            tip4.Visible = true;
        }

        private void textBox4_MouseLeave(object sender, EventArgs e)
        {
            tip4.Visible = false;
        }
     }
}