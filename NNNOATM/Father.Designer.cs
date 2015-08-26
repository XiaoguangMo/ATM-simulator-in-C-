namespace NNNOATM
{
    partial class Father
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
            this.exchange_rate = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.time = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // exchange_rate
            // 
            this.exchange_rate.AutoSize = true;
            this.exchange_rate.Location = new System.Drawing.Point(12, 9);
            this.exchange_rate.Name = "exchange_rate";
            this.exchange_rate.Size = new System.Drawing.Size(1121, 12);
            this.exchange_rate.TabIndex = 10;
            this.exchange_rate.Text = "Exchange rate: USD 100:629.40     HKD: 100:81.17 EUR: 100:846.98   GBP: 100:999.8" +
                "0   JPY: 100:7.77   CHF: 100:703.90   CAD: 100:629.78   AUD: 100:673.99   DKK: 1" +
                "00:115.87   Exchange rate";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // time
            // 
            this.time.AutoSize = true;
            this.time.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.time.Location = new System.Drawing.Point(470, 409);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(36, 19);
            this.time.TabIndex = 11;
            this.time.Text = "time";
            // 
            // Father
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 442);
            this.Controls.Add(this.time);
            this.Controls.Add(this.exchange_rate);
            this.Name = "Father";
            this.Text = "Father";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label exchange_rate;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label time;
    }
}