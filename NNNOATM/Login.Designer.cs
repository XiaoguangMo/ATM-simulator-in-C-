namespace NNNOATM
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.Account = new System.Windows.Forms.Label();
            this.Password = new System.Windows.Forms.Label();
            this.Accounttext = new System.Windows.Forms.TextBox();
            this.Passwordtext = new System.Windows.Forms.TextBox();
            this.Create = new System.Windows.Forms.Button();
            this.Loginbt = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
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
            this.Numberkeyboard = new System.Windows.Forms.Panel();
            this.tip1 = new System.Windows.Forms.Label();
            this.tip2 = new System.Windows.Forms.Label();
            this.Numberkeyboard.SuspendLayout();
            this.SuspendLayout();
            // 
            // Account
            // 
            this.Account.AutoSize = true;
            this.Account.BackColor = System.Drawing.Color.Transparent;
            this.Account.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Account.Location = new System.Drawing.Point(108, 204);
            this.Account.Name = "Account";
            this.Account.Size = new System.Drawing.Size(80, 16);
            this.Account.TabIndex = 0;
            this.Account.Text = "Account:";
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.BackColor = System.Drawing.Color.Transparent;
            this.Password.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Password.Location = new System.Drawing.Point(99, 251);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(89, 16);
            this.Password.TabIndex = 1;
            this.Password.Text = "Password:";
            // 
            // Accounttext
            // 
            this.Accounttext.Location = new System.Drawing.Point(238, 205);
            this.Accounttext.MaxLength = 20;
            this.Accounttext.Name = "Accounttext";
            this.Accounttext.Size = new System.Drawing.Size(162, 21);
            this.Accounttext.TabIndex = 2;
            this.Accounttext.Text = "Input your account here";
            this.Accounttext.MouseClick += new System.Windows.Forms.MouseEventHandler(this.IMouseClick);
            this.Accounttext.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            this.Accounttext.MouseLeave += new System.EventHandler(this.textBox1_MouseLeave);
            this.Accounttext.MouseHover += new System.EventHandler(this.textBox1_MouseHover);
            // 
            // Passwordtext
            // 
            this.Passwordtext.Location = new System.Drawing.Point(238, 252);
            this.Passwordtext.MaxLength = 6;
            this.Passwordtext.Name = "Passwordtext";
            this.Passwordtext.PasswordChar = '*';
            this.Passwordtext.Size = new System.Drawing.Size(162, 21);
            this.Passwordtext.TabIndex = 3;
            this.Passwordtext.Text = "******";
            this.Passwordtext.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PMouseClick);
            this.Passwordtext.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            this.Passwordtext.MouseLeave += new System.EventHandler(this.textBox2_MouseLeave);
            this.Passwordtext.MouseHover += new System.EventHandler(this.textBox2_MouseHover);
            // 
            // Create
            // 
            this.Create.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Create.BackgroundImage")));
            this.Create.FlatAppearance.BorderSize = 0;
            this.Create.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Create.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.Create.Location = new System.Drawing.Point(65, 320);
            this.Create.Name = "Create";
            this.Create.Size = new System.Drawing.Size(160, 60);
            this.Create.TabIndex = 4;
            this.Create.Text = "Create";
            this.Create.UseVisualStyleBackColor = true;
            this.Create.Click += new System.EventHandler(this.button1_Click);
            // 
            // Loginbt
            // 
            this.Loginbt.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Loginbt.BackgroundImage")));
            this.Loginbt.FlatAppearance.BorderSize = 0;
            this.Loginbt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Loginbt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.Loginbt.Location = new System.Drawing.Point(240, 320);
            this.Loginbt.Name = "Loginbt";
            this.Loginbt.Size = new System.Drawing.Size(160, 60);
            this.Loginbt.TabIndex = 5;
            this.Loginbt.Text = "Login";
            this.Loginbt.UseVisualStyleBackColor = true;
            this.Loginbt.Click += new System.EventHandler(this.button2_Click);
            // 
            // Exit
            // 
            this.Exit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Exit.BackgroundImage")));
            this.Exit.FlatAppearance.BorderSize = 0;
            this.Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Exit.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.Exit.Location = new System.Drawing.Point(415, 320);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(160, 60);
            this.Exit.TabIndex = 6;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.button3_Click);
            // 
            // clear
            // 
            this.clear.Font = new System.Drawing.Font("宋体", 9F);
            this.clear.Location = new System.Drawing.Point(72, 106);
            this.clear.Margin = new System.Windows.Forms.Padding(0);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(36, 36);
            this.clear.TabIndex = 11;
            this.clear.Text = "clr";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.button15_Click);
            // 
            // number0
            // 
            this.number0.Location = new System.Drawing.Point(36, 106);
            this.number0.Margin = new System.Windows.Forms.Padding(0);
            this.number0.Name = "number0";
            this.number0.Size = new System.Drawing.Size(36, 36);
            this.number0.TabIndex = 10;
            this.number0.Text = "0";
            this.number0.UseVisualStyleBackColor = true;
            this.number0.Click += new System.EventHandler(this.button14_Click);
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(0, 106);
            this.delete.Margin = new System.Windows.Forms.Padding(0);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(36, 36);
            this.delete.TabIndex = 9;
            this.delete.Text = "←";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.button13_Click);
            // 
            // number1
            // 
            this.number1.Location = new System.Drawing.Point(0, 70);
            this.number1.Margin = new System.Windows.Forms.Padding(0);
            this.number1.Name = "number1";
            this.number1.Size = new System.Drawing.Size(36, 36);
            this.number1.TabIndex = 8;
            this.number1.Text = "1";
            this.number1.UseVisualStyleBackColor = true;
            this.number1.Click += new System.EventHandler(this.button12_Click);
            // 
            // number2
            // 
            this.number2.Location = new System.Drawing.Point(36, 70);
            this.number2.Margin = new System.Windows.Forms.Padding(0);
            this.number2.Name = "number2";
            this.number2.Size = new System.Drawing.Size(36, 36);
            this.number2.TabIndex = 7;
            this.number2.Text = "2";
            this.number2.UseVisualStyleBackColor = true;
            this.number2.Click += new System.EventHandler(this.button11_Click);
            // 
            // number3
            // 
            this.number3.Location = new System.Drawing.Point(72, 70);
            this.number3.Margin = new System.Windows.Forms.Padding(0);
            this.number3.Name = "number3";
            this.number3.Size = new System.Drawing.Size(36, 36);
            this.number3.TabIndex = 6;
            this.number3.Text = "3";
            this.number3.UseVisualStyleBackColor = true;
            this.number3.Click += new System.EventHandler(this.button10_Click);
            // 
            // number4
            // 
            this.number4.Location = new System.Drawing.Point(0, 35);
            this.number4.Margin = new System.Windows.Forms.Padding(0);
            this.number4.Name = "number4";
            this.number4.Size = new System.Drawing.Size(36, 36);
            this.number4.TabIndex = 5;
            this.number4.Text = "4";
            this.number4.UseVisualStyleBackColor = true;
            this.number4.Click += new System.EventHandler(this.button9_Click);
            // 
            // number5
            // 
            this.number5.Location = new System.Drawing.Point(36, 35);
            this.number5.Margin = new System.Windows.Forms.Padding(0);
            this.number5.Name = "number5";
            this.number5.Size = new System.Drawing.Size(36, 36);
            this.number5.TabIndex = 4;
            this.number5.Text = "5";
            this.number5.UseVisualStyleBackColor = true;
            this.number5.Click += new System.EventHandler(this.button8_Click);
            // 
            // number6
            // 
            this.number6.Location = new System.Drawing.Point(72, 35);
            this.number6.Margin = new System.Windows.Forms.Padding(0);
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
            this.number9.Margin = new System.Windows.Forms.Padding(0);
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
            this.number8.Margin = new System.Windows.Forms.Padding(0);
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
            this.number7.Margin = new System.Windows.Forms.Padding(0);
            this.number7.Name = "number7";
            this.number7.Size = new System.Drawing.Size(36, 36);
            this.number7.TabIndex = 0;
            this.number7.Text = "7";
            this.number7.UseVisualStyleBackColor = true;
            this.number7.Click += new System.EventHandler(this.button4_Click);
            // 
            // Numberkeyboard
            // 
            this.Numberkeyboard.BackColor = System.Drawing.Color.Transparent;
            this.Numberkeyboard.Controls.Add(this.clear);
            this.Numberkeyboard.Controls.Add(this.number0);
            this.Numberkeyboard.Controls.Add(this.delete);
            this.Numberkeyboard.Controls.Add(this.number3);
            this.Numberkeyboard.Controls.Add(this.number2);
            this.Numberkeyboard.Controls.Add(this.number1);
            this.Numberkeyboard.Controls.Add(this.number6);
            this.Numberkeyboard.Controls.Add(this.number5);
            this.Numberkeyboard.Controls.Add(this.number4);
            this.Numberkeyboard.Controls.Add(this.number9);
            this.Numberkeyboard.Controls.Add(this.number8);
            this.Numberkeyboard.Controls.Add(this.number7);
            this.Numberkeyboard.Location = new System.Drawing.Point(406, 171);
            this.Numberkeyboard.Name = "Numberkeyboard";
            this.Numberkeyboard.Size = new System.Drawing.Size(108, 144);
            this.Numberkeyboard.TabIndex = 11;
            this.Numberkeyboard.Visible = false;
            // 
            // tip1
            // 
            this.tip1.AutoSize = true;
            this.tip1.BackColor = System.Drawing.Color.Transparent;
            this.tip1.Location = new System.Drawing.Point(238, 277);
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
            this.tip2.Location = new System.Drawing.Point(236, 229);
            this.tip2.Name = "tip2";
            this.tip2.Size = new System.Drawing.Size(77, 12);
            this.tip2.TabIndex = 13;
            this.tip2.Text = "Only numbers";
            this.tip2.Visible = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(624, 442);
            this.Controls.Add(this.tip2);
            this.Controls.Add(this.tip1);
            this.Controls.Add(this.Numberkeyboard);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Loginbt);
            this.Controls.Add(this.Create);
            this.Controls.Add(this.Passwordtext);
            this.Controls.Add(this.Accounttext);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Account);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.Controls.SetChildIndex(this.Account, 0);
            this.Controls.SetChildIndex(this.Password, 0);
            this.Controls.SetChildIndex(this.Accounttext, 0);
            this.Controls.SetChildIndex(this.Passwordtext, 0);
            this.Controls.SetChildIndex(this.Create, 0);
            this.Controls.SetChildIndex(this.Loginbt, 0);
            this.Controls.SetChildIndex(this.Exit, 0);
            this.Controls.SetChildIndex(this.Numberkeyboard, 0);
            this.Controls.SetChildIndex(this.tip1, 0);
            this.Controls.SetChildIndex(this.tip2, 0);
            this.Numberkeyboard.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Account;
        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.TextBox Accounttext;
        private System.Windows.Forms.TextBox Passwordtext;
        private System.Windows.Forms.Button Create;
        private System.Windows.Forms.Button Loginbt;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button number0;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button number1;
        private System.Windows.Forms.Button number2;
        private System.Windows.Forms.Button number3;
        private System.Windows.Forms.Button number4;
        private System.Windows.Forms.Button number5;
        private System.Windows.Forms.Button number6;
        private System.Windows.Forms.Button number9;
        private System.Windows.Forms.Button number8;
        private System.Windows.Forms.Button number7;
        private System.Windows.Forms.Panel Numberkeyboard;
        private System.Windows.Forms.Label tip1;
        private System.Windows.Forms.Label tip2;
    }
}

