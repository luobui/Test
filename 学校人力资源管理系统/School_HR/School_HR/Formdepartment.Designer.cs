namespace School_HR
{
    partial class Formdepartment
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
            this.departmentconsel = new System.Windows.Forms.Button();
            this.departmentadd = new System.Windows.Forms.Button();
            this.textdepartmentname = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textdepartmentid = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // departmentconsel
            // 
            this.departmentconsel.BackColor = System.Drawing.Color.Lime;
            this.departmentconsel.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.departmentconsel.Location = new System.Drawing.Point(472, 321);
            this.departmentconsel.Name = "departmentconsel";
            this.departmentconsel.Size = new System.Drawing.Size(146, 52);
            this.departmentconsel.TabIndex = 33;
            this.departmentconsel.Text = "取消";
            this.departmentconsel.UseVisualStyleBackColor = false;
            this.departmentconsel.Click += new System.EventHandler(this.departmentconsel_Click);
            // 
            // departmentadd
            // 
            this.departmentadd.BackColor = System.Drawing.Color.Lime;
            this.departmentadd.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.departmentadd.Location = new System.Drawing.Point(93, 321);
            this.departmentadd.Name = "departmentadd";
            this.departmentadd.Size = new System.Drawing.Size(125, 52);
            this.departmentadd.TabIndex = 32;
            this.departmentadd.Text = "添加";
            this.departmentadd.UseVisualStyleBackColor = false;
            this.departmentadd.Click += new System.EventHandler(this.departmentadd_Click);
            // 
            // textdepartmentname
            // 
            this.textdepartmentname.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textdepartmentname.Location = new System.Drawing.Point(219, 199);
            this.textdepartmentname.Name = "textdepartmentname";
            this.textdepartmentname.Size = new System.Drawing.Size(399, 34);
            this.textdepartmentname.TabIndex = 31;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(88, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 27);
            this.label4.TabIndex = 30;
            this.label4.Text = "部门名称";
            // 
            // textdepartmentid
            // 
            this.textdepartmentid.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textdepartmentid.Location = new System.Drawing.Point(219, 92);
            this.textdepartmentid.Name = "textdepartmentid";
            this.textdepartmentid.Size = new System.Drawing.Size(399, 34);
            this.textdepartmentid.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(88, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 27);
            this.label1.TabIndex = 28;
            this.label1.Text = "部门编号";
            // 
            // Formdepartment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.ClientSize = new System.Drawing.Size(727, 482);
            this.Controls.Add(this.departmentconsel);
            this.Controls.Add(this.departmentadd);
            this.Controls.Add(this.textdepartmentname);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textdepartmentid);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Formdepartment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "添加部门";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button departmentconsel;
        private System.Windows.Forms.Button departmentadd;
        private System.Windows.Forms.TextBox textdepartmentname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textdepartmentid;
        private System.Windows.Forms.Label label1;
    }
}