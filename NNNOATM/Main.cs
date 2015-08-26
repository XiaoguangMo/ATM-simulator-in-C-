using System;
using System.Windows.Forms;
using System.Xml;
using System.Media;

namespace NNNOATM
{
    public partial class Main : Father
    {
        string id;
        int time = 60;

        public Main(string pid)
        {
            id = pid;
            InitializeComponent();
        }

        //一分钟不操作自动退出
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

        //存钱
        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            Savemoney Savemoney = new Savemoney(id);
            Savemoney.Show();
            this.Visible = false;
        }

        //返回
        private void button6_Click(object sender, EventArgs e)
        {
            Login Login = new Login();
            Login.Show();
            this.Visible = false;
        }

        //根据当前存款数多少决定取钱form下哪些按钮可以隐藏
        private void button3_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load("account.xml");
            XmlNodeList xnl = xmlDoc.SelectSingleNode("Table").ChildNodes;
            foreach (XmlNode xn in xnl)
            {
                XmlElement xe = (XmlElement)xn;
                if (xe.GetAttribute("id") == id)
                {
                    Withdrawal Withdrawal = new Withdrawal(id);
                    Withdrawal.button1.Visible = true;
                    Withdrawal.button2.Visible = true;
                    Withdrawal.button3.Visible = true;
                    Withdrawal.button4.Visible = true;
                    Withdrawal.button5.Visible = true;
                    if(Convert.ToInt32(xe.GetAttribute("money"))<2000)
                    {
                        Withdrawal.button5.Visible = false;
                        if (Convert.ToInt32(xe.GetAttribute("money")) < 1000)
                        {
                            Withdrawal.button4.Visible = false;
                            if (Convert.ToInt32(xe.GetAttribute("money")) < 500)
                            {
                                Withdrawal.button3.Visible = false;
                                if (Convert.ToInt32(xe.GetAttribute("money")) < 200)
                                {
                                    Withdrawal.button2.Visible = false;
                                    if (Convert.ToInt32(xe.GetAttribute("money")) < 100)
                                    {
                                        Withdrawal.button1.Visible = false;
                                    }
                                }
                            }
                        }
                    }
                    Withdrawal.Show();
                    this.Close();
                }

            }
            
        }

        //转账
        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop(); 
            Transfer Transfer = new Transfer(id);
            Transfer.Show();
            this.Visible = false;
        }

        //改密码
        private void button5_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            ChangePassword ChangePassword = new ChangePassword(id);
            ChangePassword.Show();
            this.Visible = false;
        }

        //查余额
        private void button4_Click(object sender, EventArgs e)
        {
            time= 60;
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load("account.xml");
            XmlNodeList xnl = xmlDoc.SelectSingleNode("Table").ChildNodes;
            string money;
            foreach (XmlNode xn in xnl)
            {
                XmlElement xe = (XmlElement)xn;
                if (xe.GetAttribute("id") == id)
                {
                    money = xe.GetAttribute("money");
                    SystemSounds.Exclamation.Play();
                    MessageBox.Show("ID: " + id +"\nYou have "+ money + " yuan in your account.");
                }

            }
        }
    }
}
