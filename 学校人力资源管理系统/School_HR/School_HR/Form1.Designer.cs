namespace School_HR
{
    partial class Form1
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.textid = new System.Windows.Forms.TextBox();
            this.textpassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.remberpassword = new System.Windows.Forms.RadioButton();
            this.txtexit = new System.Windows.Forms.Button();
            this.txtlogin = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Cornsilk;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(204, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "用户名";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textid
            // 
            this.textid.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textid.Location = new System.Drawing.Point(290, 78);
            this.textid.Name = "textid";
            this.textid.Size = new System.Drawing.Size(285, 34);
            this.textid.TabIndex = 1;
            // 
            // textpassword
            // 
            this.textpassword.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textpassword.Location = new System.Drawing.Point(290, 160);
            this.textpassword.Name = "textpassword";
            this.textpassword.Size = new System.Drawing.Size(285, 34);
            this.textpassword.TabIndex = 3;
            this.textpassword.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Cornsilk;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(204, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 27);
            this.label2.TabIndex = 2;
            this.label2.Text = "密码";
            // 
            // remberpassword
            // 
            this.remberpassword.AutoSize = true;
            this.remberpassword.BackColor = System.Drawing.Color.Cornsilk;
            this.remberpassword.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.remberpassword.Location = new System.Drawing.Point(210, 215);
            this.remberpassword.Name = "remberpassword";
            this.remberpassword.Size = new System.Drawing.Size(113, 31);
            this.remberpassword.TabIndex = 6;
            this.remberpassword.TabStop = true;
            this.remberpassword.Text = "记住密码";
            this.remberpassword.UseVisualStyleBackColor = false;
            // 
            // txtexit
            // 
            this.txtexit.BackColor = System.Drawing.Color.Lime;
            this.txtexit.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtexit.Location = new System.Drawing.Point(454, 289);
            this.txtexit.Name = "txtexit";
            this.txtexit.Size = new System.Drawing.Size(121, 48);
            this.txtexit.TabIndex = 7;
            this.txtexit.Text = "退出";
            this.txtexit.UseVisualStyleBackColor = false;
            this.txtexit.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtlogin
            // 
            this.txtlogin.BackColor = System.Drawing.Color.Lime;
            this.txtlogin.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtlogin.Location = new System.Drawing.Point(210, 289);
            this.txtlogin.Name = "txtlogin";
            this.txtlogin.Size = new System.Drawing.Size(121, 48);
            this.txtlogin.TabIndex = 8;
            this.txtlogin.Text = "登录";
            this.txtlogin.UseVisualStyleBackColor = false;
            this.txtlogin.Click += new System.EventHandler(this.txtlogin_Click_1);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Lime;
            this.button1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.Location = new System.Drawing.Point(667, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 48);
            this.button1.TabIndex = 9;
            this.button1.Text = "注册";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtlogin);
            this.Controls.Add(this.txtexit);
            this.Controls.Add(this.remberpassword);
            this.Controls.Add(this.textpassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textid);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "学校人力资源管理系统";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textid;
        private System.Windows.Forms.TextBox textpassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton remberpassword;
        private System.Windows.Forms.Button txtexit;
        private System.Windows.Forms.Button txtlogin;
        private System.Windows.Forms.Button button1;
    }
}

