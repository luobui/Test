namespace School_HR
{
    partial class FormUpdatepassword
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
            this.txtexit = new System.Windows.Forms.Button();
            this.txtlogin = new System.Windows.Forms.Button();
            this.textnewpassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textoldpassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textokpassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtexit
            // 
            this.txtexit.BackColor = System.Drawing.Color.Lime;
            this.txtexit.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtexit.Location = new System.Drawing.Point(532, 347);
            this.txtexit.Name = "txtexit";
            this.txtexit.Size = new System.Drawing.Size(138, 48);
            this.txtexit.TabIndex = 15;
            this.txtexit.Text = "返回";
            this.txtexit.UseVisualStyleBackColor = false;
            this.txtexit.Click += new System.EventHandler(this.txtexit_Click);
            // 
            // txtlogin
            // 
            this.txtlogin.BackColor = System.Drawing.Color.Lime;
            this.txtlogin.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtlogin.Location = new System.Drawing.Point(190, 347);
            this.txtlogin.Name = "txtlogin";
            this.txtlogin.Size = new System.Drawing.Size(121, 48);
            this.txtlogin.TabIndex = 13;
            this.txtlogin.Text = "确认修改";
            this.txtlogin.UseVisualStyleBackColor = false;
            this.txtlogin.Click += new System.EventHandler(this.txtlogin_Click);
            // 
            // textnewpassword
            // 
            this.textnewpassword.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textnewpassword.Location = new System.Drawing.Point(385, 178);
            this.textnewpassword.MaxLength = 20;
            this.textnewpassword.Name = "textnewpassword";
            this.textnewpassword.Size = new System.Drawing.Size(285, 34);
            this.textnewpassword.TabIndex = 12;
            this.textnewpassword.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(185, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 27);
            this.label2.TabIndex = 11;
            this.label2.Text = "新密码";
            // 
            // textoldpassword
            // 
            this.textoldpassword.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textoldpassword.Location = new System.Drawing.Point(385, 100);
            this.textoldpassword.MaxLength = 20;
            this.textoldpassword.Name = "textoldpassword";
            this.textoldpassword.Size = new System.Drawing.Size(285, 34);
            this.textoldpassword.TabIndex = 10;
            this.textoldpassword.TextChanged += new System.EventHandler(this.texoldpassword_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(185, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 27);
            this.label1.TabIndex = 9;
            this.label1.Text = "原密码";
            // 
            // textokpassword
            // 
            this.textokpassword.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textokpassword.Location = new System.Drawing.Point(385, 264);
            this.textokpassword.MaxLength = 20;
            this.textokpassword.Name = "textokpassword";
            this.textokpassword.Size = new System.Drawing.Size(285, 34);
            this.textokpassword.TabIndex = 17;
            this.textokpassword.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(185, 267);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 27);
            this.label3.TabIndex = 16;
            this.label3.Text = "确认密码";
            // 
            // FormUpdatepassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.ClientSize = new System.Drawing.Size(849, 527);
            this.Controls.Add(this.textokpassword);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtexit);
            this.Controls.Add(this.txtlogin);
            this.Controls.Add(this.textnewpassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textoldpassword);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormUpdatepassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "管理员密码修改";
            this.Load += new System.EventHandler(this.FormUpdatepassword_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button txtexit;
        private System.Windows.Forms.Button txtlogin;
        private System.Windows.Forms.TextBox textnewpassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textoldpassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textokpassword;
        private System.Windows.Forms.Label label3;
    }
}