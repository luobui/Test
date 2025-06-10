namespace School_HR
{
    partial class FormLogon
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.adminsconsel = new System.Windows.Forms.Button();
            this.adminsadd = new System.Windows.Forms.Button();
            this.textadminpassword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textadminid = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(136, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 15);
            this.label1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(106, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 15);
            this.label2.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(90, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 15);
            this.label3.TabIndex = 3;
            // 
            // adminsconsel
            // 
            this.adminsconsel.BackColor = System.Drawing.Color.Lime;
            this.adminsconsel.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.adminsconsel.Location = new System.Drawing.Point(519, 319);
            this.adminsconsel.Name = "adminsconsel";
            this.adminsconsel.Size = new System.Drawing.Size(146, 52);
            this.adminsconsel.TabIndex = 33;
            this.adminsconsel.Text = "取消";
            this.adminsconsel.UseVisualStyleBackColor = false;
            this.adminsconsel.Click += new System.EventHandler(this.adminsconsel_Click);
            // 
            // adminsadd
            // 
            this.adminsadd.BackColor = System.Drawing.Color.Lime;
            this.adminsadd.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.adminsadd.Location = new System.Drawing.Point(140, 319);
            this.adminsadd.Name = "adminsadd";
            this.adminsadd.Size = new System.Drawing.Size(125, 52);
            this.adminsadd.TabIndex = 32;
            this.adminsadd.Text = "注册";
            this.adminsadd.UseVisualStyleBackColor = false;
            this.adminsadd.Click += new System.EventHandler(this.adminsadd_Click);
            // 
            // textadminpassword
            // 
            this.textadminpassword.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textadminpassword.Location = new System.Drawing.Point(266, 197);
            this.textadminpassword.Name = "textadminpassword";
            this.textadminpassword.Size = new System.Drawing.Size(399, 34);
            this.textadminpassword.TabIndex = 31;
            this.textadminpassword.TextChanged += new System.EventHandler(this.textadminpassword_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(135, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 27);
            this.label4.TabIndex = 30;
            this.label4.Text = "管理员密码";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // textadminid
            // 
            this.textadminid.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textadminid.Location = new System.Drawing.Point(266, 90);
            this.textadminid.Name = "textadminid";
            this.textadminid.Size = new System.Drawing.Size(399, 34);
            this.textadminid.TabIndex = 29;
            this.textadminid.TextChanged += new System.EventHandler(this.textadminid_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(135, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 27);
            this.label5.TabIndex = 28;
            this.label5.Text = "管理员编号";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // FormLogon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.ClientSize = new System.Drawing.Size(800, 460);
            this.Controls.Add(this.adminsconsel);
            this.Controls.Add(this.adminsadd);
            this.Controls.Add(this.textadminpassword);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textadminid);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormLogon";
            this.Text = "用户注册";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button adminsconsel;
        private System.Windows.Forms.Button adminsadd;
        private System.Windows.Forms.TextBox textadminpassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textadminid;
        private System.Windows.Forms.Label label5;
    }
}