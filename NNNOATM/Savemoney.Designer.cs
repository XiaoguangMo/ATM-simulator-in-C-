namespace NNNOATM
{
    partial class Savemoney
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Savemoney));
            this.Save = new System.Windows.Forms.Button();
            this.Back = new System.Windows.Forms.Button();
            this.Savetext = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Savelab = new System.Windows.Forms.Label();
            this.number = new System.Windows.Forms.Label();
            this.tip = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Save
            // 
            this.Save.BackColor = System.Drawing.Color.Green;
            this.Save.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Save.BackgroundImage")));
            this.Save.FlatAppearance.BorderSize = 0;
            this.Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Save.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.Save.Location = new System.Drawing.Point(65, 320);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(160, 60);
            this.Save.TabIndex = 0;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = false;
            this.Save.Click += new System.EventHandler(this.button1_Click);
            // 
            // Back
            // 
            this.Back.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Back.BackgroundImage")));
            this.Back.FlatAppearance.BorderSize = 0;
            this.Back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Back.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.Back.Location = new System.Drawing.Point(415, 320);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(160, 60);
            this.Back.TabIndex = 1;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.button2_Click);
            // 
            // Savetext
            // 
            this.Savetext.Location = new System.Drawing.Point(213, 183);
            this.Savetext.MaxLength = 10;
            this.Savetext.Name = "Savetext";
            this.Savetext.Size = new System.Drawing.Size(221, 21);
            this.Savetext.TabIndex = 2;
            this.Savetext.Text = "How much money do you want to save?";
            this.Savetext.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBox1_MouseClick);
            this.Savetext.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            this.Savetext.MouseLeave += new System.EventHandler(this.Savetext_MouseLeave);
            this.Savetext.MouseHover += new System.EventHandler(this.Savetext_MouseHover);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Savelab
            // 
            this.Savelab.AutoSize = true;
            this.Savelab.BackColor = System.Drawing.Color.Transparent;
            this.Savelab.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold);
            this.Savelab.Location = new System.Drawing.Point(139, 182);
            this.Savelab.Name = "Savelab";
            this.Savelab.Size = new System.Drawing.Size(53, 16);
            this.Savelab.TabIndex = 4;
            this.Savelab.Text = "Save:";
            // 
            // number
            // 
            this.number.AutoSize = true;
            this.number.BackColor = System.Drawing.Color.Transparent;
            this.number.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold);
            this.number.Location = new System.Drawing.Point(576, 21);
            this.number.Name = "number";
            this.number.Size = new System.Drawing.Size(36, 26);
            this.number.TabIndex = 5;
            this.number.Text = "60";
            // 
            // tip
            // 
            this.tip.AutoSize = true;
            this.tip.BackColor = System.Drawing.Color.Transparent;
            this.tip.Location = new System.Drawing.Point(211, 207);
            this.tip.Name = "tip";
            this.tip.Size = new System.Drawing.Size(203, 12);
            this.tip.TabIndex = 12;
            this.tip.Text = "Should be multiple of one hundred";
            this.tip.Visible = false;
            // 
            // Savemoney
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(624, 442);
            this.Controls.Add(this.tip);
            this.Controls.Add(this.number);
            this.Controls.Add(this.Savelab);
            this.Controls.Add(this.Savetext);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.Save);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Savemoney";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Savemoney";
            this.Controls.SetChildIndex(this.Save, 0);
            this.Controls.SetChildIndex(this.Back, 0);
            this.Controls.SetChildIndex(this.Savetext, 0);
            this.Controls.SetChildIndex(this.Savelab, 0);
            this.Controls.SetChildIndex(this.number, 0);
            this.Controls.SetChildIndex(this.tip, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.TextBox Savetext;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label Savelab;
        private System.Windows.Forms.Label number;
        private System.Windows.Forms.Label tip;
    }
}