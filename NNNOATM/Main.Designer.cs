namespace NNNOATM
{
    partial class Main
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.SaveMoney = new System.Windows.Forms.Button();
            this.Transfer = new System.Windows.Forms.Button();
            this.Withdrawal = new System.Windows.Forms.Button();
            this.BalanceChecking = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.ChangePassword = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.number = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SaveMoney
            // 
            this.SaveMoney.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.SaveMoney.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SaveMoney.BackgroundImage")));
            this.SaveMoney.FlatAppearance.BorderSize = 0;
            this.SaveMoney.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveMoney.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.SaveMoney.Location = new System.Drawing.Point(65, 67);
            this.SaveMoney.Name = "SaveMoney";
            this.SaveMoney.Size = new System.Drawing.Size(160, 60);
            this.SaveMoney.TabIndex = 0;
            this.SaveMoney.Text = "Save Money";
            this.SaveMoney.UseVisualStyleBackColor = false;
            this.SaveMoney.Click += new System.EventHandler(this.button1_Click);
            // 
            // Transfer
            // 
            this.Transfer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Transfer.BackgroundImage")));
            this.Transfer.FlatAppearance.BorderSize = 0;
            this.Transfer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Transfer.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.Transfer.Location = new System.Drawing.Point(65, 194);
            this.Transfer.Name = "Transfer";
            this.Transfer.Size = new System.Drawing.Size(160, 60);
            this.Transfer.TabIndex = 1;
            this.Transfer.Text = "Transfer";
            this.Transfer.UseVisualStyleBackColor = true;
            this.Transfer.Click += new System.EventHandler(this.button2_Click);
            // 
            // Withdrawal
            // 
            this.Withdrawal.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Withdrawal.BackgroundImage")));
            this.Withdrawal.FlatAppearance.BorderSize = 0;
            this.Withdrawal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Withdrawal.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.Withdrawal.Location = new System.Drawing.Point(415, 67);
            this.Withdrawal.Name = "Withdrawal";
            this.Withdrawal.Size = new System.Drawing.Size(160, 60);
            this.Withdrawal.TabIndex = 2;
            this.Withdrawal.Text = "Withdrawal";
            this.Withdrawal.UseVisualStyleBackColor = true;
            this.Withdrawal.Click += new System.EventHandler(this.button3_Click);
            // 
            // BalanceChecking
            // 
            this.BalanceChecking.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BalanceChecking.BackgroundImage")));
            this.BalanceChecking.FlatAppearance.BorderSize = 0;
            this.BalanceChecking.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BalanceChecking.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.BalanceChecking.Location = new System.Drawing.Point(415, 194);
            this.BalanceChecking.Name = "BalanceChecking";
            this.BalanceChecking.Size = new System.Drawing.Size(160, 60);
            this.BalanceChecking.TabIndex = 3;
            this.BalanceChecking.Text = "Balance Checking";
            this.BalanceChecking.UseVisualStyleBackColor = true;
            this.BalanceChecking.Click += new System.EventHandler(this.button4_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ChangePassword
            // 
            this.ChangePassword.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ChangePassword.BackgroundImage")));
            this.ChangePassword.FlatAppearance.BorderSize = 0;
            this.ChangePassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChangePassword.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.ChangePassword.Location = new System.Drawing.Point(65, 320);
            this.ChangePassword.Name = "ChangePassword";
            this.ChangePassword.Size = new System.Drawing.Size(160, 60);
            this.ChangePassword.TabIndex = 5;
            this.ChangePassword.Text = "Change Password";
            this.ChangePassword.UseVisualStyleBackColor = true;
            this.ChangePassword.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button6.BackgroundImage")));
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button6.Location = new System.Drawing.Point(415, 320);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(160, 60);
            this.button6.TabIndex = 6;
            this.button6.Text = "Exit";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // number
            // 
            this.number.AutoSize = true;
            this.number.BackColor = System.Drawing.Color.Transparent;
            this.number.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.number.Location = new System.Drawing.Point(576, 21);
            this.number.Name = "number";
            this.number.Size = new System.Drawing.Size(36, 26);
            this.number.TabIndex = 7;
            this.number.Text = "60";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(624, 442);
            this.Controls.Add(this.number);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.ChangePassword);
            this.Controls.Add(this.BalanceChecking);
            this.Controls.Add(this.Withdrawal);
            this.Controls.Add(this.Transfer);
            this.Controls.Add(this.SaveMoney);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.Controls.SetChildIndex(this.SaveMoney, 0);
            this.Controls.SetChildIndex(this.Transfer, 0);
            this.Controls.SetChildIndex(this.Withdrawal, 0);
            this.Controls.SetChildIndex(this.BalanceChecking, 0);
            this.Controls.SetChildIndex(this.ChangePassword, 0);
            this.Controls.SetChildIndex(this.button6, 0);
            this.Controls.SetChildIndex(this.number, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SaveMoney;
        private System.Windows.Forms.Button Transfer;
        private System.Windows.Forms.Button Withdrawal;
        private System.Windows.Forms.Button BalanceChecking;
        public System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button ChangePassword;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label number;
    }
}