using System;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using System.Security.Cryptography;
using System.Text;
using System.Media;

namespace NNNOATM
{
    //只有Father直接继承的是Form，其他Form通过Father间接继承Form
    public partial class Father : Form
    {
        //收件人邮箱
        public string emailto;

        public Father()
        {
            InitializeComponent();
        }
        
        public void sendEmail(String emailto, String id, String message)
        {
            string HostName = Dns.GetHostName();
            //得到本机的主机名
            IPHostEntry ipEntry = Dns.GetHostByName(HostName);
            //取得本机IP
            string Addr = ipEntry.AddressList[0].ToString();
            //将本机IP转为string类型
            string t_message = "Welcome to NNNO Bank!<br />You are using ATM at " + HostName + ". <br />IP address: " + Addr + ".<br />ID: " + id + "." + message;
            //信息主体
            MailMessage mail = new MailMessage();
            //开始准备发email，新建MailMessage对象
            mail.Subject = "NNNO Bank";
            //信件主体
            mail.From = new MailAddress("877309786@qq.com", "NNNO Bank");
            //发件人地址，名称
            mail.To.Add(new MailAddress(emailto, id));
            //收件人地址，名称
            mail.Body = t_message;
            //信件内容
            mail.BodyEncoding = System.Text.Encoding.UTF8;
            //编码UTF8
            mail.IsBodyHtml = true;
            //Html格式，在html文件中可读
            mail.Priority = MailPriority.Normal;
            //优先级：正常
            mail.DeliveryNotificationOptions = DeliveryNotificationOptions.OnSuccess;
            SmtpClient client = new SmtpClient();
            //设置发送邮件的smtp服务器
            client.Host = "smtp.qq.com";
            //这里我用了qq的邮箱，qq的smtp服务器地址为"smtp.qq.com"
            client.Port = 25;
            //端口
            client.UseDefaultCredentials = true;
            //证书
            client.Credentials = new System.Net.NetworkCredential("877309786@qq.com", "35165q");
            //发件人登陆邮箱
            client.DeliveryMethod = SmtpDeliveryMethod.Network;
            client.Send(mail);
            //发送邮件
        }

        public String Encryption(string salt,string password)
        {
            string salted = salt; 
            //宣告变数,储存Salted值 
            if (salted.Length == 0)
            //如果使用者沒给Salt值,那給预设 
            {
                salted = "NNNOATM";
            } 
            byte[] Original = Encoding.Default.GetBytes(password);
            //将来源字串转为byte[] 
            byte[] SaltValue = Encoding.Default.GetBytes(salted);
            //将Salted Value转为byte[] 
            byte[] ToSalt = new byte[Original.Length + SaltValue.Length]; 
            //宣告新的byte[]来储存加密后的值 
            Original.CopyTo(ToSalt, 0);
            //将来源字串复制到新byte[] 
            SaltValue.CopyTo(ToSalt, Original.Length);
            //将Salted Value复制到新byte[] 
            MD5 st = MD5.Create();
            //使用MD5 
            byte[] SaltPWD = st.ComputeHash(ToSalt);
            //进行加密 
            byte[] PWD = new byte[SaltPWD.Length + SaltValue.Length];
            //宣告新byte[]储存加密及Salted的值 
            SaltPWD.CopyTo(PWD, 0);
            //将加密後的值复制到新byte[] 
            SaltValue.CopyTo(PWD, SaltPWD.Length);
            //将Salted Value复制到新byte[] 
            string finalpw = Convert.ToBase64String(PWD);
            //显示Salted Hash后的字串
            return finalpw;
            //返回加密后的字串
        }

        //汇率信息滚动
        private void timer1_Tick(object sender, EventArgs e)
        {
             if (exchange_rate.Left < this.Width)
             {
                exchange_rate.Left = exchange_rate.Left + 10;
             }
            //当滚动出屏幕边缘的时候，再从另一边重新再来，循环滚动
             else if (exchange_rate.Left > -this.Width)
             {
                 exchange_rate.Left = -exchange_rate.Width;
             }
             time.Text = DateTime.Now.ToString();
        }
    }
}
