namespace School_HR
{
    partial class Formupdateposition
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
            this.positionconsel = new System.Windows.Forms.Button();
            this.positionupdate = new System.Windows.Forms.Button();
            this.textupdatepositionname = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // positionconsel
            // 
            this.positionconsel.BackColor = System.Drawing.Color.Lime;
            this.positionconsel.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.positionconsel.Location = new System.Drawing.Point(519, 314);
            this.positionconsel.Name = "positionconsel";
            this.positionconsel.Size = new System.Drawing.Size(146, 52);
            this.positionconsel.TabIndex = 45;
            this.positionconsel.Text = "返回";
            this.positionconsel.UseVisualStyleBackColor = false;
            this.positionconsel.Click += new System.EventHandler(this.positionconsel_Click);
            // 
            // positionupdate
            // 
            this.positionupdate.BackColor = System.Drawing.Color.Lime;
            this.positionupdate.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.positionupdate.Location = new System.Drawing.Point(140, 314);
            this.positionupdate.Name = "positionupdate";
            this.positionupdate.Size = new System.Drawing.Size(125, 52);
            this.positionupdate.TabIndex = 44;
            this.positionupdate.Text = "确认修改";
            this.positionupdate.UseVisualStyleBackColor = false;
            this.positionupdate.Click += new System.EventHandler(this.positionupdate_Click);
            // 
            // textupdatepositionname
            // 
            this.textupdatepositionname.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textupdatepositionname.Location = new System.Drawing.Point(266, 109);
            this.textupdatepositionname.Name = "textupdatepositionname";
            this.textupdatepositionname.Size = new System.Drawing.Size(399, 34);
            this.textupdatepositionname.TabIndex = 43;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(135, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 27);
            this.label4.TabIndex = 42;
            this.label4.Text = "职位名称";
            // 
            // Formupdateposition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.positionconsel);
            this.Controls.Add(this.positionupdate);
            this.Controls.Add(this.textupdatepositionname);
            this.Controls.Add(this.label4);
            this.Name = "Formupdateposition";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "职位信息修改";
            this.Load += new System.EventHandler(this.Formupdateposition_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button positionconsel;
        private System.Windows.Forms.Button positionupdate;
        private System.Windows.Forms.TextBox textupdatepositionname;
        private System.Windows.Forms.Label label4;
    }
}