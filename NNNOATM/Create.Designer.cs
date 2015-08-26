namespace NNNOATM
{
    partial class Create
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Create));
            this.Createbt = new System.Windows.Forms.Button();
            this.Account = new System.Windows.Forms.Label();
            this.Password = new System.Windows.Forms.Label();
            this.Emailadd = new System.Windows.Forms.Label();
            this.Birthday = new System.Windows.Forms.Label();
            this.Accounttext = new System.Windows.Forms.TextBox();
            this.Passwordtext = new System.Windows.Forms.TextBox();
            this.Emailtext = new System.Windows.Forms.TextBox();
            this.Birthdaytext = new System.Windows.Forms.TextBox();
            this.Back = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.number = new System.Windows.Forms.Label();
            this.tip1 = new System.Windows.Forms.Label();
            this.tip2 = new System.Windows.Forms.Label();
            this.tip3 = new System.Windows.Forms.Label();
            this.tip4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Createbt
            // 
            this.Createbt.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Createbt.BackgroundImage")));
            this.Createbt.FlatAppearance.BorderSize = 0;
            this.Createbt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Createbt.Location = new System.Drawing.Point(65, 320);
            this.Createbt.Name = "Createbt";
            this.Createbt.Size = new System.Drawing.Size(160, 60);
            this.Createbt.TabIndex = 0;
            this.Createbt.Text = "Create";
            this.Createbt.UseVisualStyleBackColor = true;
            this.Createbt.Click += new System.EventHandler(this.button1_Click);
            // 
            // Account
            // 
            this.Account.AutoSize = true;
            this.Account.BackColor = System.Drawing.Color.Transparent;
            this.Account.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold);
            this.Account.Location = new System.Drawing.Point(105, 63);
            this.Account.Name = "Account";
            this.Account.Size = new System.Drawing.Size(80, 16);
            this.Account.TabIndex = 1;
            this.Account.Text = "Account:";
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.BackColor = System.Drawing.Color.Transparent;
            this.Password.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold);
            this.Password.Location = new System.Drawing.Point(105, 130);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(89, 16);
            this.Password.TabIndex = 2;
            this.Password.Text = "Password:";
            // 
            // Emailadd
            // 
            this.Emailadd.AutoSize = true;
            this.Emailadd.BackColor = System.Drawing.Color.Transparent;
            this.Emailadd.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold);
            this.Emailadd.Location = new System.Drawing.Point(105, 192);
            this.Emailadd.Name = "Emailadd";
            this.Emailadd.Size = new System.Drawing.Size(134, 16);
            this.Emailadd.TabIndex = 3;
            this.Emailadd.Text = "Email Address:";
            // 
            // Birthday
            // 
            this.Birthday.AutoSize = true;
            this.Birthday.BackColor = System.Drawing.Color.Transparent;
            this.Birthday.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold);
            this.Birthday.Location = new System.Drawing.Point(105, 255);
            this.Birthday.Name = "Birthday";
            this.Birthday.Size = new System.Drawing.Size(89, 16);
            this.Birthday.TabIndex = 4;
            this.Birthday.Text = "Birthday:";
            // 
            // Accounttext
            // 
            this.Accounttext.Location = new System.Drawing.Point(249, 64);
            this.Accounttext.MaxLength = 20;
            this.Accounttext.Name = "Accounttext";
            this.Accounttext.Size = new System.Drawing.Size(191, 21);
            this.Accounttext.TabIndex = 5;
            this.Accounttext.Text = "Please input your account";
            this.Accounttext.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBox1_MouseClick);
            this.Accounttext.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.IKeyPress);
            this.Accounttext.MouseLeave += new System.EventHandler(this.textBox1_MouseLeave);
            this.Accounttext.MouseHover += new System.EventHandler(this.textBox1_MouseHover);
            // 
            // Passwordtext
            // 
            this.Passwordtext.Location = new System.Drawing.Point(249, 131);
            this.Passwordtext.MaxLength = 6;
            this.Passwordtext.Name = "Passwordtext";
            this.Passwordtext.Size = new System.Drawing.Size(191, 21);
            this.Passwordtext.TabIndex = 6;
            this.Passwordtext.Text = "Should be 6 digits";
            this.Passwordtext.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBox2_MouseClick);
            this.Passwordtext.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NKeyPress);
            this.Passwordtext.MouseLeave += new System.EventHandler(this.textBox2_MouseLeave);
            this.Passwordtext.MouseHover += new System.EventHandler(this.textBox2_MouseHover);
            // 
            // Emailtext
            // 
            this.Emailtext.Location = new System.Drawing.Point(249, 193);
            this.Emailtext.MaxLength = 30;
            this.Emailtext.Name = "Emailtext";
            this.Emailtext.Size = new System.Drawing.Size(191, 21);
            this.Emailtext.TabIndex = 7;
            this.Emailtext.Text = "Available email address";
            this.Emailtext.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBox3_MouseClick);
            this.Emailtext.MouseLeave += new System.EventHandler(this.textBox3_MouseLeave);
            this.Emailtext.MouseHover += new System.EventHandler(this.textBox3_MouseHover);
            // 
            // Birthdaytext
            // 
            this.Birthdaytext.Location = new System.Drawing.Point(249, 256);
            this.Birthdaytext.MaxLength = 20;
            this.Birthdaytext.Name = "Birthdaytext";
            this.Birthdaytext.Size = new System.Drawing.Size(191, 21);
            this.Birthdaytext.TabIndex = 8;
            this.Birthdaytext.Text = "Form should be like 1991-06-01";
            this.Birthdaytext.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBox4_MouseClick);
            this.Birthdaytext.MouseLeave += new System.EventHandler(this.textBox4_MouseLeave);
            this.Birthdaytext.MouseHover += new System.EventHandler(this.textBox4_MouseHover);
            // 
            // Back
            // 
            this.Back.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Back.BackgroundImage")));
            this.Back.FlatAppearance.BorderSize = 0;
            this.Back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Back.Location = new System.Drawing.Point(415, 320);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(160, 60);
            this.Back.TabIndex = 9;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.button2_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // number
            // 
            this.number.AutoSize = true;
            this.number.BackColor = System.Drawing.Color.Transparent;
            this.number.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold);
            this.number.Location = new System.Drawing.Point(576, 21);
            this.number.Name = "number";
            this.number.Size = new System.Drawing.Size(36, 26);
            this.number.TabIndex = 11;
            this.number.Text = "60";
            // 
            // tip1
            // 
            this.tip1.AutoSize = true;
            this.tip1.BackColor = System.Drawing.Color.Transparent;
            this.tip1.Location = new System.Drawing.Point(247, 88);
            this.tip1.Name = "tip1";
            this.tip1.Size = new System.Drawing.Size(245, 12);
            this.tip1.TabIndex = 12;
            this.tip1.Text = "Should be digits and length less than 20";
            this.tip1.Visible = false;
            // 
            // tip2
            // 
            this.tip2.AutoSize = true;
            this.tip2.BackColor = System.Drawing.Color.Transparent;
            this.tip2.Location = new System.Drawing.Point(247, 155);
            this.tip2.Name = "tip2";
            this.tip2.Size = new System.Drawing.Size(101, 12);
            this.tip2.TabIndex = 13;
            this.tip2.Text = "Must be 6 digits";
            this.tip2.Visible = false;
            // 
            // tip3
            // 
            this.tip3.AutoSize = true;
            this.tip3.BackColor = System.Drawing.Color.Transparent;
            this.tip3.Location = new System.Drawing.Point(247, 217);
            this.tip3.Name = "tip3";
            this.tip3.Size = new System.Drawing.Size(143, 12);
            this.tip3.TabIndex = 14;
            this.tip3.Text = "Available email address";
            this.tip3.Visible = false;
            // 
            // tip4
            // 
            this.tip4.AutoSize = true;
            this.tip4.BackColor = System.Drawing.Color.Transparent;
            this.tip4.Location = new System.Drawing.Point(247, 280);
            this.tip4.Name = "tip4";
            this.tip4.Size = new System.Drawing.Size(137, 12);
            this.tip4.TabIndex = 15;
            this.tip4.Text = "Should like ????-??-??";
            this.tip4.Visible = false;
            // 
            // Create
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(624, 442);
            this.Controls.Add(this.tip4);
            this.Controls.Add(this.tip3);
            this.Controls.Add(this.tip2);
            this.Controls.Add(this.tip1);
            this.Controls.Add(this.number);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.Birthdaytext);
            this.Controls.Add(this.Emailtext);
            this.Controls.Add(this.Passwordtext);
            this.Controls.Add(this.Accounttext);
            this.Controls.Add(this.Birthday);
            this.Controls.Add(this.Emailadd);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Account);
            this.Controls.Add(this.Createbt);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Create";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create";
            this.Controls.SetChildIndex(this.Createbt, 0);
            this.Controls.SetChildIndex(this.Account, 0);
            this.Controls.SetChildIndex(this.Password, 0);
            this.Controls.SetChildIndex(this.Emailadd, 0);
            this.Controls.SetChildIndex(this.Birthday, 0);
            this.Controls.SetChildIndex(this.Accounttext, 0);
            this.Controls.SetChildIndex(this.Passwordtext, 0);
            this.Controls.SetChildIndex(this.Emailtext, 0);
            this.Controls.SetChildIndex(this.Birthdaytext, 0);
            this.Controls.SetChildIndex(this.Back, 0);
            this.Controls.SetChildIndex(this.number, 0);
            this.Controls.SetChildIndex(this.tip1, 0);
            this.Controls.SetChildIndex(this.tip2, 0);
            this.Controls.SetChildIndex(this.tip3, 0);
            this.Controls.SetChildIndex(this.tip4, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Createbt;
        private System.Windows.Forms.Label Account;
        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.Label Emailadd;
        private System.Windows.Forms.Label Birthday;
        private System.Windows.Forms.TextBox Accounttext;
        private System.Windows.Forms.TextBox Passwordtext;
        private System.Windows.Forms.TextBox Emailtext;
        private System.Windows.Forms.TextBox Birthdaytext;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label number;
        private System.Windows.Forms.Label tip1;
        private System.Windows.Forms.Label tip2;
        private System.Windows.Forms.Label tip3;
        private System.Windows.Forms.Label tip4;
    }
}