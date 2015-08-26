using System;
using System.Windows.Forms;
using System.Media;

namespace NNNOATM
{
    public partial class Verification : Father
    {
        int result;
        int time = 60;

        public Verification()
        {
            InitializeComponent();
        }

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

        private void verification_Load(object sender, EventArgs e)
        {
            //生成随机数
            Random rd = new Random();
            //保存4个随机数
            int intResult1 = rd.Next(0, 9);
            int intResult2 = rd.Next(0, 9);
            int intResult3 = rd.Next(0, 9);
            int intResult4 = rd.Next(0, 9);
            //用4个随机数组成4位数
            result = intResult1 * 1000 + intResult2 * 100 + intResult3 * 10 + intResult4;
            //将4个图片摆进图片框
            pictureBox1.Image = numberList.Images[intResult1];
            pictureBox2.Image = numberList.Images[intResult2];
            pictureBox3.Image = numberList.Images[intResult3];
            pictureBox4.Image = numberList.Images[intResult4];
        }

        private void button2_Click(object sender, EventArgs e)
        {
             timer1.Stop();
             Login Login = new Login();
             Login.Show();
             this.Visible = false;           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //判断用户输入与随机出的数相等
            if (Inputtext.Text.Length!=0&&result == Convert.ToInt32(Inputtext.Text))
            {
                timer1.Stop();
                Create Create = new Create();
                Create.Show();
                this.Visible = false;
            }
            else
            {
                SystemSounds.Hand.Play();
                MessageBox.Show("Your input is wrong!");
                return;
                time = 60;
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
                    else if (Char.IsDigit(e.KeyChar) && Input.Text.Length == 4)
                    {
                        SystemSounds.Beep.Play();
                    }
                    else if (e.KeyChar == 8 && Input.Text.Length <1)
                    {
                        SystemSounds.Beep.Play();
                    }
                    break;
            }
        }
    }
}
