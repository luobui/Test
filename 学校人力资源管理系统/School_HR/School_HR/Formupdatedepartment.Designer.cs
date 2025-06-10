namespace School_HR
{
    partial class Formupdatedepartment
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
            this.textupdatedepartmentname = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // departmentconsel
            // 
            this.departmentconsel.BackColor = System.Drawing.Color.Lime;
            this.departmentconsel.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.departmentconsel.Location = new System.Drawing.Point(477, 309);
            this.departmentconsel.Name = "departmentconsel";
            this.departmentconsel.Size = new System.Drawing.Size(146, 52);
            this.departmentconsel.TabIndex = 39;
            this.departmentconsel.Text = "取消";
            this.departmentconsel.UseVisualStyleBackColor = false;
            this.departmentconsel.Click += new System.EventHandler(this.departmentconsel_Click);
            // 
            // departmentadd
            // 
            this.departmentadd.BackColor = System.Drawing.Color.Lime;
            this.departmentadd.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.departmentadd.Location = new System.Drawing.Point(98, 309);
            this.departmentadd.Name = "departmentadd";
            this.departmentadd.Size = new System.Drawing.Size(125, 52);
            this.departmentadd.TabIndex = 38;
            this.departmentadd.Text = "确认修改";
            this.departmentadd.UseVisualStyleBackColor = false;
            this.departmentadd.Click += new System.EventHandler(this.departmentadd_Click);
            // 
            // textupdatedepartmentname
            // 
            this.textupdatedepartmentname.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textupdatedepartmentname.Location = new System.Drawing.Point(224, 118);
            this.textupdatedepartmentname.Name = "textupdatedepartmentname";
            this.textupdatedepartmentname.Size = new System.Drawing.Size(399, 34);
            this.textupdatedepartmentname.TabIndex = 37;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(93, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 27);
            this.label4.TabIndex = 36;
            this.label4.Text = "部门名称";
            // 
            // Formupdatedepartment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.ClientSize = new System.Drawing.Size(757, 435);
            this.Controls.Add(this.departmentconsel);
            this.Controls.Add(this.departmentadd);
            this.Controls.Add(this.textupdatedepartmentname);
            this.Controls.Add(this.label4);
            this.Name = "Formupdatedepartment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "部门信息修改";
            this.Load += new System.EventHandler(this.Formupdatedepartment_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button departmentconsel;
        private System.Windows.Forms.Button departmentadd;
        private System.Windows.Forms.TextBox textupdatedepartmentname;
        private System.Windows.Forms.Label label4;
    }
}