namespace School_HR
{
    partial class FormAddadmins
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
            this.adminsconsel = new System.Windows.Forms.Button();
            this.adminsadd = new System.Windows.Forms.Button();
            this.textadminpassword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textadminid = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // adminsconsel
            // 
            this.adminsconsel.BackColor = System.Drawing.Color.Lime;
            this.adminsconsel.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.adminsconsel.Location = new System.Drawing.Point(461, 318);
            this.adminsconsel.Name = "adminsconsel";
            this.adminsconsel.Size = new System.Drawing.Size(146, 52);
            this.adminsconsel.TabIndex = 27;
            this.adminsconsel.Text = "取消";
            this.adminsconsel.UseVisualStyleBackColor = false;
            this.adminsconsel.Click += new System.EventHandler(this.adminsconsel_Click);
            // 
            // adminsadd
            // 
            this.adminsadd.BackColor = System.Drawing.Color.Lime;
            this.adminsadd.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.adminsadd.Location = new System.Drawing.Point(82, 318);
            this.adminsadd.Name = "adminsadd";
            this.adminsadd.Size = new System.Drawing.Size(125, 52);
            this.adminsadd.TabIndex = 26;
            this.adminsadd.Text = "添加";
            this.adminsadd.UseVisualStyleBackColor = false;
            this.adminsadd.Click += new System.EventHandler(this.adminsadd_Click);
            // 
            // textadminpassword
            // 
            this.textadminpassword.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textadminpassword.Location = new System.Drawing.Point(208, 196);
            this.textadminpassword.Name = "textadminpassword";
            this.textadminpassword.Size = new System.Drawing.Size(399, 34);
            this.textadminpassword.TabIndex = 25;
            this.textadminpassword.TextChanged += new System.EventHandler(this.textadminpassword_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(77, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 27);
            this.label4.TabIndex = 24;
            this.label4.Text = "管理员密码";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // textadminid
            // 
            this.textadminid.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textadminid.Location = new System.Drawing.Point(208, 89);
            this.textadminid.Name = "textadminid";
            this.textadminid.Size = new System.Drawing.Size(399, 34);
            this.textadminid.TabIndex = 17;
            this.textadminid.TextChanged += new System.EventHandler(this.textadminid_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(77, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 27);
            this.label1.TabIndex = 16;
            this.label1.Text = "管理员编号";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // FormAddadmins
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.ClientSize = new System.Drawing.Size(709, 453);
            this.Controls.Add(this.adminsconsel);
            this.Controls.Add(this.adminsadd);
            this.Controls.Add(this.textadminpassword);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textadminid);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormAddadmins";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "添加管理员";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button adminsconsel;
        private System.Windows.Forms.Button adminsadd;
        private System.Windows.Forms.TextBox textadminpassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textadminid;
        private System.Windows.Forms.Label label1;
    }
}