namespace School_HR
{
    partial class FormAddposition
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
            this.positionadd = new System.Windows.Forms.Button();
            this.textpositionname = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textpositionid = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // positionconsel
            // 
            this.positionconsel.BackColor = System.Drawing.Color.Lime;
            this.positionconsel.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.positionconsel.Location = new System.Drawing.Point(519, 314);
            this.positionconsel.Name = "positionconsel";
            this.positionconsel.Size = new System.Drawing.Size(146, 52);
            this.positionconsel.TabIndex = 39;
            this.positionconsel.Text = "取消";
            this.positionconsel.UseVisualStyleBackColor = false;
            this.positionconsel.Click += new System.EventHandler(this.positionconsel_Click);
            // 
            // positionadd
            // 
            this.positionadd.BackColor = System.Drawing.Color.Lime;
            this.positionadd.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.positionadd.Location = new System.Drawing.Point(140, 314);
            this.positionadd.Name = "positionadd";
            this.positionadd.Size = new System.Drawing.Size(125, 52);
            this.positionadd.TabIndex = 38;
            this.positionadd.Text = "添加";
            this.positionadd.UseVisualStyleBackColor = false;
            this.positionadd.Click += new System.EventHandler(this.positionadd_Click);
            // 
            // textpositionname
            // 
            this.textpositionname.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textpositionname.Location = new System.Drawing.Point(266, 192);
            this.textpositionname.Name = "textpositionname";
            this.textpositionname.Size = new System.Drawing.Size(399, 34);
            this.textpositionname.TabIndex = 37;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(135, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 27);
            this.label4.TabIndex = 36;
            this.label4.Text = "职位名称";
            // 
            // textpositionid
            // 
            this.textpositionid.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textpositionid.Location = new System.Drawing.Point(266, 85);
            this.textpositionid.Name = "textpositionid";
            this.textpositionid.Size = new System.Drawing.Size(399, 34);
            this.textpositionid.TabIndex = 35;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(135, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 27);
            this.label1.TabIndex = 34;
            this.label1.Text = "职位编号";
            // 
            // FormAddposition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.positionconsel);
            this.Controls.Add(this.positionadd);
            this.Controls.Add(this.textpositionname);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textpositionid);
            this.Controls.Add(this.label1);
            this.Name = "FormAddposition";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "添加职位";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button positionconsel;
        private System.Windows.Forms.Button positionadd;
        private System.Windows.Forms.TextBox textpositionname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textpositionid;
        private System.Windows.Forms.Label label1;
    }
}