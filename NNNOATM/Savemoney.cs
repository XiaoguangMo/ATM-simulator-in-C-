using System;
using System.Windows.Forms;
using System.Xml;
using System.Media;

namespace NNNOATM
{
    public partial class Savemoney : Father
    {
        string id;
        int time = 60;        
        int money;
        int savemoney;

        public Savemoney(string pid)
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

        private void textBox1_MouseClick(object sender, MouseEventArgs e)
        {
            Savetext.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //存钱数必须是100的倍数，ATM机接受不了面额100以外的钞票
            if (Convert.ToInt32(Savetext.Text) % 100 != 0)
            {
                SystemSounds.Hand.Play();  
                MessageBox.Show("The money you want to withdrawal must be the multiple of one hundred");
                Savetext.Clear();
                return;
                time = 60;
            }
            else{
                //存钱成功，信息写入xml，弹出提示框
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.Load("account.xml");
                XmlNodeList xnl = xmlDoc.SelectSingleNode("Table").ChildNodes;
                foreach (XmlNode xn in xnl)
                {
                    XmlElement xe = (XmlElement)xn;
                    if (xe.GetAttribute("id") == id)
                    {
                        emailto = xe.GetAttribute("ea");
                        money = Convert.ToInt32(xe.GetAttribute("money"));
                        savemoney = money + Convert.ToInt32(Savetext.Text);
                        xe.SetAttribute("money", "" + savemoney);
                        xmlDoc.Save("account.xml");
                    }

                }
                SystemSounds.Exclamation.Play();
                MessageBox.Show("ID: " + id + "\nYou have saved " + Savetext.Text + " yuan on the ATM.\nYou have " + savemoney + " yuan in your account.\nTime: " + DateTime.Now.ToString());
                sendEmail(emailto,id,"<br />You have saved " + Savetext.Text + " yuan on the ATM.<br />You have " + savemoney + " yuan in your account.<br />Time: " + DateTime.Now.ToString());
                timer1.Stop();
                Main Main = new Main(id);
                Main.Show();
                this.Visible = false;
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar)
            {
                    //只允许输入数字和退格
                default: //8 is the ASCII for backspace
                    if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8)
                    {
                        e.Handled = true;
                        SystemSounds.Beep.Play();
                    }
                    break;
            }
        }

        private void Savetext_MouseHover(object sender, EventArgs e)
        {
            tip.Visible = true;
        }

        private void Savetext_MouseLeave(object sender, EventArgs e)
        {
            tip.Visible = false;
        }
    }
}
