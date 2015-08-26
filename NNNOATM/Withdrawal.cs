using System;
using System.Windows.Forms;
using System.Xml;
using System.Media;

namespace NNNOATM
{
    public partial class Withdrawal : Father
    {
        string id;
        int time = 60;
        int totWithdrawal = 0;
        int withdrawal;

        //每次取完钱，都要验证下哪些按钮要因为钱不够而消失
        private void checkButtons(int money)
        {
            button1.Visible = true;
            button2.Visible = true;
            button3.Visible = true;
            button4.Visible = true;
            button5.Visible = true;
            if (money < 2000)
            {
                button5.Visible = false;
                if (money < 1000)
                {
                    button4.Visible = false;
                    if (money < 500)
                    {
                        button3.Visible = false;
                        if (money < 200)
                        {
                            button2.Visible = false;
                            if (money < 100)
                            {
                                button1.Visible = false;
                            }
                        }
                    }
                }
            }
        }

        public Withdrawal(string pid)
        {
            id = pid;
            InitializeComponent();
        }
                
        //一分钟不操作就退出
        private void timer1_Tick(object sender, EventArgs e)
        {
            time--;
            label2.Text = "" + time;
            if (time == 0)
            {
                timer1.Stop();
                Login Login = new Login();
                Login.Show();
                this.Visible = false;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            Main Main = new Main(id);
            Main.Show();
            this.Visible = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Visible = true;
            button8.Visible = true;
        }

        private void textBox1_MouseClick(object sender, MouseEventArgs e)
        {
            textBox1.Clear();
        }
                
        private void button1_Click(object sender, EventArgs e)
        {    
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load("account.xml");
            XmlNodeList xnl = xmlDoc.SelectSingleNode("Table").ChildNodes;
            foreach (XmlNode xn in xnl)
            {
                XmlElement xe = (XmlElement)xn;
                if (xe.GetAttribute("id") == id)
                {
                    System.DateTime currentTime = new System.DateTime();
                    currentTime = System.DateTime.Now;
                    string date = "r" + currentTime.Year + currentTime.Month + currentTime.Day;
                    if (xe.GetAttribute(date).Length > 0 && (Convert.ToInt32(xe.GetAttribute(date)) + 100) > 20000)
                    {
                        MessageBox.Show("You can only withdrawal 20000 yuan per day, and you have already withdrawal " + xe.GetAttribute(date) + " yuan today!");
                        break;
                    }
                    else
                    {
                        emailto = xe.GetAttribute("ea");
                        int money = Convert.ToInt32(xe.GetAttribute("money"));
                        withdrawal = money - 100;
                        xe.SetAttribute("money", "" + withdrawal);


                        if (xe.GetAttribute(date).Length != 0)
                        {
                            totWithdrawal = Convert.ToInt32(xe.GetAttribute(date)) + 100;
                            xe.SetAttribute(date, "" + totWithdrawal);
                        }
                        else
                        {
                            xe.SetAttribute(date, "" + 100);
                        }
                        xmlDoc.Save("account.xml");
                        SystemSounds.Exclamation.Play();
                        String message = "ID: " + id + "\nYou have withdrawaled 100 yuan from ATM.\nYou have " + withdrawal + " yuan in your account.\nTime: " + DateTime.Now.ToString();
                        MessageBox.Show(message);
                        sendEmail(emailto, id, "<br />You have withdrawaled 100 yuan on the ATM.<br />You have " + withdrawal + " yuan in your account.<br />Time: " + DateTime.Now.ToString());
                        timer1.Stop();
                        Main Main = new Main(id);
                        Main.Show();
                        checkButtons(withdrawal);
                        this.Visible = false;
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load("account.xml");
            XmlNodeList xnl = xmlDoc.SelectSingleNode("Table").ChildNodes;
            foreach (XmlNode xn in xnl)
            {
                XmlElement xe = (XmlElement)xn;
                if (xe.GetAttribute("id") == id)
                {
                    System.DateTime currentTime = new System.DateTime();
                    currentTime = System.DateTime.Now;
                    string date = "r" + currentTime.Year + currentTime.Month + currentTime.Day;
                    if (xe.GetAttribute(date).Length > 0 && (Convert.ToInt32(xe.GetAttribute(date)) + 200) > 20000)
                    {
                        MessageBox.Show("You can only withdrawal 20000 yuan per day, and you have already withdrawal " + xe.GetAttribute(date) + " yuan today!");
                        break;
                    }
                    else
                    {
                        emailto = xe.GetAttribute("ea");
                        int money = Convert.ToInt32(xe.GetAttribute("money"));
                        withdrawal = money - 200;
                        xe.SetAttribute("money", "" + withdrawal);


                        if (xe.GetAttribute(date).Length != 0)
                        {
                            totWithdrawal = Convert.ToInt32(xe.GetAttribute(date)) + 200;
                            xe.SetAttribute(date, "" + totWithdrawal);
                        }
                        else
                        {
                            xe.SetAttribute(date, "" + 200);
                        }
                        xmlDoc.Save("account.xml");
                        SystemSounds.Exclamation.Play();
                        String message = "ID: " + id + "\nYou have withdrawaled 200 yuan from ATM.\nYou have " + withdrawal + " yuan in your account.\nTime: " + DateTime.Now.ToString();
                        MessageBox.Show(message);
                        sendEmail(emailto, id, "<br />You have withdrawaled 200 yuan on the ATM.<br />You have " + withdrawal + " yuan in your account.<br />Time: " + DateTime.Now.ToString());
                        timer1.Stop();
                        Main Main = new Main(id);
                        Main.Show();
                        checkButtons(withdrawal);
                        this.Visible = false;
                    }                    
                }
            }            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load("account.xml");
            XmlNodeList xnl = xmlDoc.SelectSingleNode("Table").ChildNodes;
            foreach (XmlNode xn in xnl)
            {
                XmlElement xe = (XmlElement)xn;
                if (xe.GetAttribute("id") == id)
                {
                    System.DateTime currentTime = new System.DateTime();
                    currentTime = System.DateTime.Now;
                    string date = "r" + currentTime.Year + currentTime.Month + currentTime.Day;
                    if (xe.GetAttribute(date).Length > 0 && (Convert.ToInt32(xe.GetAttribute(date)) + 500) > 20000)
                    {
                        MessageBox.Show("You can only withdrawal 20000 yuan per day, and you have already withdrawal " + xe.GetAttribute(date) + " yuan today!");
                        break;
                    }
                    else
                    {
                        emailto = xe.GetAttribute("ea");
                        int money = Convert.ToInt32(xe.GetAttribute("money"));
                        withdrawal = money - 500;
                        xe.SetAttribute("money", "" + withdrawal);


                        if (xe.GetAttribute(date).Length != 0)
                        {
                            totWithdrawal = Convert.ToInt32(xe.GetAttribute(date)) + 500;
                            xe.SetAttribute(date, "" + totWithdrawal);
                        }
                        else
                        {
                            xe.SetAttribute(date, "" + 500);
                        }
                        xmlDoc.Save("account.xml");
                        SystemSounds.Exclamation.Play();
                        String message = "ID: " + id + "\nYou have withdrawaled 500 yuan from ATM.\nYou have " + withdrawal + " yuan in your account.\nTime: " + DateTime.Now.ToString();
                        MessageBox.Show(message);
                        sendEmail(emailto, id, "<br />You have withdrawaled 500 yuan on the ATM.<br />You have " + withdrawal + " yuan in your account.<br />Time: " + DateTime.Now.ToString());
                        timer1.Stop();
                        Main Main = new Main(id);
                        Main.Show();
                        checkButtons(withdrawal);
                        this.Visible = false;
                    }
                }
            }            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load("account.xml");
            XmlNodeList xnl = xmlDoc.SelectSingleNode("Table").ChildNodes;
            foreach (XmlNode xn in xnl)
            {
                XmlElement xe = (XmlElement)xn;
                if (xe.GetAttribute("id") == id)
                {
                    System.DateTime currentTime = new System.DateTime();
                    currentTime = System.DateTime.Now;
                    string date = "r" + currentTime.Year + currentTime.Month + currentTime.Day;
                    if (xe.GetAttribute(date).Length > 0 && (Convert.ToInt32(xe.GetAttribute(date)) + 1000) > 20000)
                    {
                        MessageBox.Show("You can only withdrawal 20000 yuan per day, and you have already withdrawal " + xe.GetAttribute(date) + " yuan today!");
                        break;
                    }
                    else
                    {
                        emailto = xe.GetAttribute("ea");
                        int money = Convert.ToInt32(xe.GetAttribute("money"));
                        withdrawal = money - 1000;
                        xe.SetAttribute("money", "" + withdrawal);


                        if (xe.GetAttribute(date).Length != 0)
                        {
                            totWithdrawal = Convert.ToInt32(xe.GetAttribute(date)) + 1000;
                            xe.SetAttribute(date, "" + totWithdrawal);
                        }
                        else
                        {
                            xe.SetAttribute(date, "" + 1000);
                        }
                        xmlDoc.Save("account.xml");
                        SystemSounds.Exclamation.Play();
                        String message = "ID: " + id + "\nYou have withdrawaled 1000 yuan from ATM.\nYou have " + withdrawal + " yuan in your account.\nTime: " + DateTime.Now.ToString();
                        MessageBox.Show(message);
                        sendEmail(emailto, id, "<br />You have withdrawaled 1000 yuan on the ATM.<br />You have " + withdrawal + " yuan in your account.<br />Time: " + DateTime.Now.ToString());
                        timer1.Stop();
                        Main Main = new Main(id);
                        Main.Show();
                        checkButtons(withdrawal);
                        this.Visible = false;
                    }
                }
            }            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load("account.xml");
            XmlNodeList xnl = xmlDoc.SelectSingleNode("Table").ChildNodes;
            foreach (XmlNode xn in xnl)
            {
                XmlElement xe = (XmlElement)xn;
                if (xe.GetAttribute("id") == id)
                {
                    System.DateTime currentTime = new System.DateTime();
                    currentTime = System.DateTime.Now;
                    string date = "r" + currentTime.Year + currentTime.Month + currentTime.Day;
                    if (xe.GetAttribute(date).Length > 0 && (Convert.ToInt32(xe.GetAttribute(date)) + 2000) > 20000)
                    {
                        MessageBox.Show("You can only withdrawal 20000 yuan per day, and you have already withdrawal " + xe.GetAttribute(date) + " yuan today!");
                        break;           
                    }
                    else
                    {
                        emailto = xe.GetAttribute("ea");
                        int money = Convert.ToInt32(xe.GetAttribute("money"));
                        withdrawal = money - 2000;
                        xe.SetAttribute("money", "" + withdrawal);


                        if (xe.GetAttribute(date).Length != 0)
                        {
                            totWithdrawal = Convert.ToInt32(xe.GetAttribute(date)) + 2000;
                            xe.SetAttribute(date, "" + totWithdrawal);
                        }
                        else
                        {
                            xe.SetAttribute(date, "" + 2000);
                        }
                        xmlDoc.Save("account.xml");
                        SystemSounds.Exclamation.Play();
                        String message = "ID: " + id + "\nYou have withdrawaled 2000 yuan from ATM.\nYou have " + withdrawal + " yuan in your account.\nTime: " + DateTime.Now.ToString();
                        MessageBox.Show(message);
                        sendEmail(emailto, id, "<br />You have withdrawaled 2000 yuan on the ATM.<br />You have " + withdrawal + " yuan in your account.<br />Time: " + DateTime.Now.ToString());
                        timer1.Stop();
                        Main Main = new Main(id);
                        Main.Show();
                        checkButtons(withdrawal);
                        this.Visible = false;
                    }
                }
            }            
        }

        private void button8_Click(object sender, EventArgs e)
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load("account.xml");
            XmlNodeList xnl = xmlDoc.SelectSingleNode("Table").ChildNodes;
            foreach (XmlNode xn in xnl)
            {
                XmlElement xe = (XmlElement)xn;
                if (xe.GetAttribute("id") == id && textBox1.Text.Length > 0 && textBox1.Text != "Withdrawal how much?")
                {
                    if (Convert.ToInt32(xe.GetAttribute("money")) < Convert.ToInt32(textBox1.Text))
                    {
                        SystemSounds.Hand.Play();
                        MessageBox.Show("You don't have enough money!");
                        break;
                    }
                    else if (Convert.ToInt32(textBox1.Text) % 100 != 0)
                    {
                        SystemSounds.Hand.Play();
                        MessageBox.Show("The money you want to withdrawal must be the multiple of one hundred");
                        break;
                    }
                    else
                    {
                        System.DateTime currentTime = new System.DateTime();
                        currentTime = System.DateTime.Now;
                        string date = "r" + currentTime.Year + currentTime.Month + currentTime.Day;
                        if ((Convert.ToInt32(xe.GetAttribute(date)) + Convert.ToInt32(textBox1.Text)) > 20000)
                        {
                            SystemSounds.Hand.Play();
                            MessageBox.Show("You can only withdrawal 20000 yuan per day, and you have already withdrawal " + xe.GetAttribute(date) + " yuan today!");
                            break;
                        }
                        else
                        {
                            emailto = xe.GetAttribute("ea");
                            int money = Convert.ToInt32(xe.GetAttribute("money"));
                            withdrawal = money - Convert.ToInt32(textBox1.Text);
                            xe.SetAttribute("money", "" + withdrawal);


                            if (xe.GetAttribute(date).Length != 0)
                            {
                                totWithdrawal = Convert.ToInt32(xe.GetAttribute(date)) + Convert.ToInt32(textBox1.Text);
                                xe.SetAttribute(date, "" + totWithdrawal);
                            }
                            else
                            {
                                xe.SetAttribute(date, "" + Convert.ToInt32(textBox1.Text));
                            }
                            xmlDoc.Save("account.xml");
                            SystemSounds.Exclamation.Play();
                            String message = "ID: " + id + "\nYou have withdrawaled "+Convert.ToInt32(textBox1.Text)+" yuan from ATM.\nYou have " + withdrawal + " yuan in your account.\nTime: " + DateTime.Now.ToString();
                            MessageBox.Show(message);
                            sendEmail(emailto, id, "<br />You have withdrawaled "+Convert.ToInt32(textBox1.Text) +" yuan on the ATM.<br />You have " + withdrawal + " yuan in your account.<br />Time: " + DateTime.Now.ToString());
                            timer1.Stop();
                            Main Main = new Main(id);
                            Main.Show();
                            checkButtons(withdrawal);
                            this.Visible = false;
                        } 
                    }
                    
                }

            }
            
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar)
            {
                default: //8 is the ASCII for backspace
                    if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8)
                    {
                        e.Handled = true;
                        SystemSounds.Beep.Play();
                    }
                    break;
            }
        }
    }
}