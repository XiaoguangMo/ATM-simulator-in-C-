namespace NNNOATM
{
    partial class ChangePassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangePassword));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Change = new System.Windows.Forms.Button();
            this.Back = new System.Windows.Forms.Button();
            this.Newpw = new System.Windows.Forms.Label();
            this.Repeat = new System.Windows.Forms.Label();
            this.PWtext = new System.Windows.Forms.TextBox();
            this.Repeattext = new System.Windows.Forms.TextBox();
            this.number = new System.Windows.Forms.Label();
            this.numberkeyboard = new System.Windows.Forms.Panel();
            this.clear = new System.Windows.Forms.Button();
            this.number0 = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.number1 = new System.Windows.Forms.Button();
            this.number2 = new System.Windows.Forms.Button();
            this.number3 = new System.Windows.Forms.Button();
            this.number4 = new System.Windows.Forms.Button();
            this.number5 = new System.Windows.Forms.Button();
            this.number6 = new System.Windows.Forms.Button();
            this.number9 = new System.Windows.Forms.Button();
            this.number8 = new System.Windows.Forms.Button();
            this.number7 = new System.Windows.Forms.Button();
            this.tip1 = new System.Windows.Forms.Label();
            this.tip2 = new System.Windows.Forms.Label();
            this.numberkeyboard.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Change
            // 
            this.Change.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Change.BackgroundImage")));
            this.Change.FlatAppearance.BorderSize = 0;
            this.Change.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Change.Location = new System.Drawing.Point(65, 320);
            this.Change.Name = "Change";
            this.Change.Size = new System.Drawing.Size(160, 60);
            this.Change.TabIndex = 0;
            this.Change.Text = "Change";
            this.Change.UseVisualStyleBackColor = true;
            this.Change.Click += new System.EventHandler(this.Change_Click);
            // 
            // Back
            // 
            this.Back.BackColor = System.Drawing.SystemColors.Control;
            this.Back.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Back.BackgroundImage")));
            this.Back.FlatAppearance.BorderSize = 0;
            this.Back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Back.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Back.Location = new System.Drawing.Point(415, 320);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(160, 60);
            this.Back.TabIndex = 1;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = false;
            this.Back.Click += new System.EventHandler(this.button2_Click);
            // 
            // Newpw
            // 
            this.Newpw.AutoSize = true;
            this.Newpw.BackColor = System.Drawing.Color.Transparent;
            this.Newpw.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold);
            this.Newpw.Location = new System.Drawing.Point(81, 150);
            this.Newpw.Name = "Newpw";
            this.Newpw.Size = new System.Drawing.Size(133, 16);
            this.Newpw.TabIndex = 3;
            this.Newpw.Text = "New Password：";
            // 
            // Repeat
            // 
            this.Repeat.AutoSize = true;
            this.Repeat.BackColor = System.Drawing.Color.Transparent;
            this.Repeat.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold);
            this.Repeat.Location = new System.Drawing.Point(135, 217);
            this.Repeat.Name = "Repeat";
            this.Repeat.Size = new System.Drawing.Size(79, 16);
            this.Repeat.TabIndex = 4;
            this.Repeat.Text = "Repeat：";
            // 
            // PWtext
            // 
            this.PWtext.Location = new System.Drawing.Point(237, 151);
            this.PWtext.MaxLength = 6;
            this.PWtext.Name = "PWtext";
            this.PWtext.Size = new System.Drawing.Size(169, 21);
            this.PWtext.TabIndex = 5;
            this.PWtext.Text = "Input your new password";
            this.PWtext.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBox1_MouseClick);
            this.PWtext.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            this.PWtext.MouseLeave += new System.EventHandler(this.textBox1_MouseLeave);
            this.PWtext.MouseHover += new System.EventHandler(this.textBox1_MouseHover);
            // 
            // Repeattext
            // 
            this.Repeattext.Location = new System.Drawing.Point(237, 218);
            this.Repeattext.MaxLength = 6;
            this.Repeattext.Name = "Repeattext";
            this.Repeattext.Size = new System.Drawing.Size(169, 21);
            this.Repeattext.TabIndex = 6;
            this.Repeattext.Text = "repeat your new password";
            this.Repeattext.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBox2_MouseClick);
            this.Repeattext.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            this.Repeattext.MouseLeave += new System.EventHandler(this.textBox2_MouseLeave);
            this.Repeattext.MouseHover += new System.EventHandler(this.textBox2_MouseHover);
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
            // numberkeyboard
            // 
            this.numberkeyboard.BackColor = System.Drawing.Color.Transparent;
            this.numberkeyboard.Controls.Add(this.clear);
            this.numberkeyboard.Controls.Add(this.number0);
            this.numberkeyboard.Controls.Add(this.delete);
            this.numberkeyboard.Controls.Add(this.number1);
            this.numberkeyboard.Controls.Add(this.number2);
            this.numberkeyboard.Controls.Add(this.number3);
            this.numberkeyboard.Controls.Add(this.number4);
            this.numberkeyboard.Controls.Add(this.number5);
            this.numberkeyboard.Controls.Add(this.number6);
            this.numberkeyboard.Controls.Add(this.number9);
            this.numberkeyboard.Controls.Add(this.number8);
            this.numberkeyboard.Controls.Add(this.number7);
            this.numberkeyboard.Location = new System.Drawing.Point(415, 150);
            this.numberkeyboard.Name = "numberkeyboard";
            this.numberkeyboard.Size = new System.Drawing.Size(108, 144);
            this.numberkeyboard.TabIndex = 8;
            this.numberkeyboard.Visible = false;
            // 
            // clear
            // 
            this.clear.Location = new System.Drawing.Point(72, 108);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(36, 36);
            this.clear.TabIndex = 11;
            this.clear.Text = "clr";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.button15_Click);
            // 
            // number0
            // 
            this.number0.Location = new System.Drawing.Point(36, 108);
            this.number0.Name = "number0";
            this.number0.Size = new System.Drawing.Size(36, 36);
            this.number0.TabIndex = 10;
            this.number0.Text = "0";
            this.number0.UseVisualStyleBackColor = true;
            this.number0.Click += new System.EventHandler(this.button14_Click);
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(0, 108);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(36, 36);
            this.delete.TabIndex = 9;
            this.delete.Text = "←";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.button13_Click);
            // 
            // number1
            // 
            this.number1.Location = new System.Drawing.Point(0, 72);
            this.number1.Name = "number1";
            this.number1.Size = new System.Drawing.Size(36, 36);
            this.number1.TabIndex = 8;
            this.number1.Text = "1";
            this.number1.UseVisualStyleBackColor = true;
            this.number1.Click += new System.EventHandler(this.button12_Click);
            // 
            // number2
            // 
            this.number2.Location = new System.Drawing.Point(36, 72);
            this.number2.Name = "number2";
            this.number2.Size = new System.Drawing.Size(36, 36);
            this.number2.TabIndex = 7;
            this.number2.Text = "2";
            this.number2.UseVisualStyleBackColor = true;
            this.number2.Click += new System.EventHandler(this.button11_Click);
            // 
            // number3
            // 
            this.number3.Location = new System.Drawing.Point(72, 72);
            this.number3.Name = "number3";
            this.number3.Size = new System.Drawing.Size(36, 36);
            this.number3.TabIndex = 6;
            this.number3.Text = "3";
            this.number3.UseVisualStyleBackColor = true;
            this.number3.Click += new System.EventHandler(this.button10_Click);
            // 
            // number4
            // 
            this.number4.Location = new System.Drawing.Point(0, 36);
            this.number4.Name = "number4";
            this.number4.Size = new System.Drawing.Size(36, 36);
            this.number4.TabIndex = 5;
            this.number4.Text = "4";
            this.number4.UseVisualStyleBackColor = true;
            this.number4.Click += new System.EventHandler(this.button9_Click);
            // 
            // number5
            // 
            this.number5.Location = new System.Drawing.Point(36, 36);
            this.number5.Name = "number5";
            this.number5.Size = new System.Drawing.Size(36, 36);
            this.number5.TabIndex = 4;
            this.number5.Text = "5";
            this.number5.UseVisualStyleBackColor = true;
            this.number5.Click += new System.EventHandler(this.button8_Click);
            // 
            // number6
            // 
            this.number6.Location = new System.Drawing.Point(72, 36);
            this.number6.Name = "number6";
            this.number6.Size = new System.Drawing.Size(36, 36);
            this.number6.TabIndex = 3;
            this.number6.Text = "6";
            this.number6.UseVisualStyleBackColor = true;
            this.number6.Click += new System.EventHandler(this.button7_Click);
            // 
            // number9
            // 
            this.number9.Location = new System.Drawing.Point(72, 0);
            this.number9.Name = "number9";
            this.number9.Size = new System.Drawing.Size(36, 36);
            this.number9.TabIndex = 2;
            this.number9.Text = "9";
            this.number9.UseVisualStyleBackColor = true;
            this.number9.Click += new System.EventHandler(this.button6_Click);
            // 
            // number8
            // 
            this.number8.Location = new System.Drawing.Point(36, 0);
            this.number8.Name = "number8";
            this.number8.Size = new System.Drawing.Size(36, 36);
            this.number8.TabIndex = 1;
            this.number8.Text = "8";
            this.number8.UseVisualStyleBackColor = true;
            this.number8.Click += new System.EventHandler(this.button5_Click);
            // 
            // number7
            // 
            this.number7.Location = new System.Drawing.Point(0, 0);
            this.number7.Name = "number7";
            this.number7.Size = new System.Drawing.Size(36, 36);
            this.number7.TabIndex = 0;
            this.number7.Text = "7";
            this.number7.UseVisualStyleBackColor = true;
            this.number7.Click += new System.EventHandler(this.button4_Click);
            // 
            // tip1
            // 
            this.tip1.AutoSize = true;
            this.tip1.BackColor = System.Drawing.Color.Transparent;
            this.tip1.Location = new System.Drawing.Point(235, 175);
            this.tip1.Name = "tip1";
            this.tip1.Size = new System.Drawing.Size(167, 12);
            this.tip1.TabIndex = 12;
            this.tip1.Text = "Password should be 6 digits";
            this.tip1.Visible = false;
            // 
            // tip2
            // 
            this.tip2.AutoSize = true;
            this.tip2.BackColor = System.Drawing.Color.Transparent;
            this.tip2.Location = new System.Drawing.Point(235, 242);
            this.tip2.Name = "tip2";
            this.tip2.Size = new System.Drawing.Size(155, 12);
            this.tip2.TabIndex = 13;
            this.tip2.Text = "Same with the input above";
            this.tip2.Visible = false;
            // 
            // ChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(624, 442);
            this.Controls.Add(this.tip2);
            this.Controls.Add(this.tip1);
            this.Controls.Add(this.numberkeyboard);
            this.Controls.Add(this.Repeattext);
            this.Controls.Add(this.number);
            this.Controls.Add(this.PWtext);
            this.Controls.Add(this.Repeat);
            this.Controls.Add(this.Newpw);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.Change);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ChangePassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChangePassword";
            this.Controls.SetChildIndex(this.Change, 0);
            this.Controls.SetChildIndex(this.Back, 0);
            this.Controls.SetChildIndex(this.Newpw, 0);
            this.Controls.SetChildIndex(this.Repeat, 0);
            this.Controls.SetChildIndex(this.PWtext, 0);
            this.Controls.SetChildIndex(this.number, 0);
            this.Controls.SetChildIndex(this.Repeattext, 0);
            this.Controls.SetChildIndex(this.numberkeyboard, 0);
            this.Controls.SetChildIndex(this.tip1, 0);
            this.Controls.SetChildIndex(this.tip2, 0);
            this.numberkeyboard.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button Change;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Label Newpw;
        private System.Windows.Forms.Label Repeat;
        private System.Windows.Forms.TextBox PWtext;
        private System.Windows.Forms.TextBox Repeattext;
        private System.Windows.Forms.Label number;
        private System.Windows.Forms.Panel numberkeyboard;
        private System.Windows.Forms.Button number7;
        private System.Windows.Forms.Button number9;
        private System.Windows.Forms.Button number8;
        private System.Windows.Forms.Button number4;
        private System.Windows.Forms.Button number5;
        private System.Windows.Forms.Button number6;
        private System.Windows.Forms.Button number1;
        private System.Windows.Forms.Button number2;
        private System.Windows.Forms.Button number3;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button number0;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Label tip1;
        private System.Windows.Forms.Label tip2;
    }
}