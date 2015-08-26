namespace NNNOATM
{
    partial class Transfer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Transfer));
            this.Account = new System.Windows.Forms.Label();
            this.money = new System.Windows.Forms.Label();
            this.Accounttext = new System.Windows.Forms.TextBox();
            this.Moneytext = new System.Windows.Forms.TextBox();
            this.Transferbt = new System.Windows.Forms.Button();
            this.Back = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.number = new System.Windows.Forms.Label();
            this.tip1 = new System.Windows.Forms.Label();
            this.tip2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Account
            // 
            this.Account.AutoSize = true;
            this.Account.BackColor = System.Drawing.Color.Transparent;
            this.Account.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold);
            this.Account.Location = new System.Drawing.Point(118, 150);
            this.Account.Name = "Account";
            this.Account.Size = new System.Drawing.Size(80, 16);
            this.Account.TabIndex = 1;
            this.Account.Text = "Account:";
            // 
            // money
            // 
            this.money.AutoSize = true;
            this.money.BackColor = System.Drawing.Color.Transparent;
            this.money.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold);
            this.money.Location = new System.Drawing.Point(136, 217);
            this.money.Name = "money";
            this.money.Size = new System.Drawing.Size(62, 16);
            this.money.TabIndex = 2;
            this.money.Text = "Money:";
            // 
            // Accounttext
            // 
            this.Accounttext.Location = new System.Drawing.Point(237, 151);
            this.Accounttext.MaxLength = 10;
            this.Accounttext.Name = "Accounttext";
            this.Accounttext.Size = new System.Drawing.Size(235, 21);
            this.Accounttext.TabIndex = 3;
            this.Accounttext.Text = "You want to transfer to which account?";
            this.Accounttext.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBox1_MouseClick);
            this.Accounttext.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            this.Accounttext.MouseLeave += new System.EventHandler(this.Accounttext_MouseLeave);
            this.Accounttext.MouseHover += new System.EventHandler(this.Accounttext_MouseHover);
            // 
            // Moneytext
            // 
            this.Moneytext.Location = new System.Drawing.Point(237, 218);
            this.Moneytext.MaxLength = 10;
            this.Moneytext.Name = "Moneytext";
            this.Moneytext.Size = new System.Drawing.Size(169, 21);
            this.Moneytext.TabIndex = 4;
            this.Moneytext.Text = "Transfer how much?";
            this.Moneytext.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBox2_MouseClick);
            this.Moneytext.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            this.Moneytext.MouseLeave += new System.EventHandler(this.Moneytext_MouseLeave);
            this.Moneytext.MouseHover += new System.EventHandler(this.Moneytext_MouseHover);
            // 
            // Transferbt
            // 
            this.Transferbt.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Transferbt.BackgroundImage")));
            this.Transferbt.FlatAppearance.BorderSize = 0;
            this.Transferbt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Transferbt.Location = new System.Drawing.Point(65, 320);
            this.Transferbt.Name = "Transferbt";
            this.Transferbt.Size = new System.Drawing.Size(160, 60);
            this.Transferbt.TabIndex = 5;
            this.Transferbt.Text = "Transfer";
            this.Transferbt.UseVisualStyleBackColor = true;
            this.Transferbt.Click += new System.EventHandler(this.button1_Click);
            // 
            // Back
            // 
            this.Back.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Back.BackgroundImage")));
            this.Back.FlatAppearance.BorderSize = 0;
            this.Back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Back.Location = new System.Drawing.Point(415, 320);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(160, 60);
            this.Back.TabIndex = 6;
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
            this.number.TabIndex = 7;
            this.number.Text = "60";
            // 
            // tip1
            // 
            this.tip1.AutoSize = true;
            this.tip1.BackColor = System.Drawing.Color.Transparent;
            this.tip1.Location = new System.Drawing.Point(235, 175);
            this.tip1.Name = "tip1";
            this.tip1.Size = new System.Drawing.Size(161, 12);
            this.tip1.TabIndex = 12;
            this.tip1.Text = "Transfer to which account?";
            this.tip1.Visible = false;
            // 
            // tip2
            // 
            this.tip2.AutoSize = true;
            this.tip2.BackColor = System.Drawing.Color.Transparent;
            this.tip2.Location = new System.Drawing.Point(235, 242);
            this.tip2.Name = "tip2";
            this.tip2.Size = new System.Drawing.Size(113, 12);
            this.tip2.TabIndex = 13;
            this.tip2.Text = "Transfer how much?";
            this.tip2.Visible = false;
            // 
            // Transfer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(624, 442);
            this.Controls.Add(this.tip2);
            this.Controls.Add(this.tip1);
            this.Controls.Add(this.number);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.Transferbt);
            this.Controls.Add(this.Moneytext);
            this.Controls.Add(this.Accounttext);
            this.Controls.Add(this.money);
            this.Controls.Add(this.Account);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Transfer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Transfer";
            this.Controls.SetChildIndex(this.Account, 0);
            this.Controls.SetChildIndex(this.money, 0);
            this.Controls.SetChildIndex(this.Accounttext, 0);
            this.Controls.SetChildIndex(this.Moneytext, 0);
            this.Controls.SetChildIndex(this.Transferbt, 0);
            this.Controls.SetChildIndex(this.Back, 0);
            this.Controls.SetChildIndex(this.number, 0);
            this.Controls.SetChildIndex(this.tip1, 0);
            this.Controls.SetChildIndex(this.tip2, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Account;
        private System.Windows.Forms.Label money;
        private System.Windows.Forms.TextBox Accounttext;
        private System.Windows.Forms.TextBox Moneytext;
        private System.Windows.Forms.Button Transferbt;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label number;
        private System.Windows.Forms.Label tip1;
        private System.Windows.Forms.Label tip2;
    }
}