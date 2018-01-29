namespace CodeAcademyInfoSystem
{
    partial class AddGroupForm
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
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.directorySearcher1 = new System.DirectoryServices.DirectorySearcher();
            this.g_name = new System.Windows.Forms.TextBox();
            this.g_add_btn = new System.Windows.Forms.Button();
            this.t_update_btn = new System.Windows.Forms.Button();
            this.t_delete_btn = new System.Windows.Forms.Button();
            this.g_type = new System.Windows.Forms.ComboBox();
            this.g_teacher = new System.Windows.Forms.ComboBox();
            this.g_mentor = new System.Windows.Forms.ComboBox();
            this.dataGridGroup = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.g_start_data = new System.Windows.Forms.DateTimePicker();
            this.export_group_btn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridGroup)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Group Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Group Type";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Group Teacher";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Group Mentor";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(14, 216);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Group Start Date";
            // 
            // directorySearcher1
            // 
            this.directorySearcher1.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // g_name
            // 
            this.g_name.Location = new System.Drawing.Point(197, 43);
            this.g_name.Name = "g_name";
            this.g_name.Size = new System.Drawing.Size(121, 20);
            this.g_name.TabIndex = 8;
            // 
            // g_add_btn
            // 
            this.g_add_btn.BackColor = System.Drawing.Color.Khaki;
            this.g_add_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.g_add_btn.Location = new System.Drawing.Point(17, 269);
            this.g_add_btn.Name = "g_add_btn";
            this.g_add_btn.Size = new System.Drawing.Size(100, 27);
            this.g_add_btn.TabIndex = 12;
            this.g_add_btn.Text = "Add";
            this.g_add_btn.UseVisualStyleBackColor = false;
            this.g_add_btn.Click += new System.EventHandler(this.g_add_btn_Click);
            // 
            // t_update_btn
            // 
            this.t_update_btn.BackColor = System.Drawing.Color.Khaki;
            this.t_update_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.t_update_btn.Location = new System.Drawing.Point(258, 269);
            this.t_update_btn.Name = "t_update_btn";
            this.t_update_btn.Size = new System.Drawing.Size(100, 27);
            this.t_update_btn.TabIndex = 13;
            this.t_update_btn.Text = "Update";
            this.t_update_btn.UseVisualStyleBackColor = false;
            this.t_update_btn.Click += new System.EventHandler(this.t_update_btn_Click);
            // 
            // t_delete_btn
            // 
            this.t_delete_btn.BackColor = System.Drawing.Color.Khaki;
            this.t_delete_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.t_delete_btn.Location = new System.Drawing.Point(488, 269);
            this.t_delete_btn.Name = "t_delete_btn";
            this.t_delete_btn.Size = new System.Drawing.Size(100, 27);
            this.t_delete_btn.TabIndex = 14;
            this.t_delete_btn.Text = "Delete";
            this.t_delete_btn.UseVisualStyleBackColor = false;
            this.t_delete_btn.Click += new System.EventHandler(this.t_delete_btn_Click);
            // 
            // g_type
            // 
            this.g_type.FormattingEnabled = true;
            this.g_type.Location = new System.Drawing.Point(197, 84);
            this.g_type.Name = "g_type";
            this.g_type.Size = new System.Drawing.Size(121, 21);
            this.g_type.TabIndex = 15;
            // 
            // g_teacher
            // 
            this.g_teacher.FormattingEnabled = true;
            this.g_teacher.Location = new System.Drawing.Point(197, 126);
            this.g_teacher.Name = "g_teacher";
            this.g_teacher.Size = new System.Drawing.Size(121, 21);
            this.g_teacher.TabIndex = 16;
            // 
            // g_mentor
            // 
            this.g_mentor.FormattingEnabled = true;
            this.g_mentor.Location = new System.Drawing.Point(197, 173);
            this.g_mentor.Name = "g_mentor";
            this.g_mentor.Size = new System.Drawing.Size(121, 21);
            this.g_mentor.TabIndex = 17;
            // 
            // dataGridGroup
            // 
            this.dataGridGroup.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridGroup.BackgroundColor = System.Drawing.Color.Khaki;
            this.dataGridGroup.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridGroup.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dataGridGroup.Location = new System.Drawing.Point(12, 320);
            this.dataGridGroup.Name = "dataGridGroup";
            this.dataGridGroup.Size = new System.Drawing.Size(576, 199);
            this.dataGridGroup.TabIndex = 18;
            this.dataGridGroup.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.select_group);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "id";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Group Name";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Group Type";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Group Teacher";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Group Mentor";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Group Start Date";
            this.Column6.Name = "Column6";
            // 
            // g_start_data
            // 
            this.g_start_data.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.g_start_data.Location = new System.Drawing.Point(197, 215);
            this.g_start_data.Name = "g_start_data";
            this.g_start_data.Size = new System.Drawing.Size(121, 20);
            this.g_start_data.TabIndex = 19;
            // 
            // export_group_btn
            // 
            this.export_group_btn.BackColor = System.Drawing.Color.Khaki;
            this.export_group_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.export_group_btn.Location = new System.Drawing.Point(488, 541);
            this.export_group_btn.Name = "export_group_btn";
            this.export_group_btn.Size = new System.Drawing.Size(100, 27);
            this.export_group_btn.TabIndex = 20;
            this.export_group_btn.Text = "Export";
            this.export_group_btn.UseVisualStyleBackColor = false;
            this.export_group_btn.Click += new System.EventHandler(this.export_group_btn_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightSlateGray;
            this.panel2.Controls.Add(this.label6);
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(600, 28);
            this.panel2.TabIndex = 49;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Tomato;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(854, -1);
            this.label6.Name = "label6";
            this.label6.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label6.Size = new System.Drawing.Size(45, 34);
            this.label6.TabIndex = 4;
            this.label6.Text = "X";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Tomato;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(564, 0);
            this.label7.Name = "label7";
            this.label7.Padding = new System.Windows.Forms.Padding(7, 4, 7, 4);
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label7.Size = new System.Drawing.Size(35, 28);
            this.label7.TabIndex = 50;
            this.label7.Text = "X";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // AddGroupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CodeAcademyInfoSystem.Properties.Resources._2023;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(600, 580);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.export_group_btn);
            this.Controls.Add(this.g_start_data);
            this.Controls.Add(this.dataGridGroup);
            this.Controls.Add(this.g_mentor);
            this.Controls.Add(this.g_teacher);
            this.Controls.Add(this.g_type);
            this.Controls.Add(this.t_delete_btn);
            this.Controls.Add(this.t_update_btn);
            this.Controls.Add(this.g_add_btn);
            this.Controls.Add(this.g_name);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddGroupForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddGroupForm";
            this.Load += new System.EventHandler(this.AddGroupForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridGroup)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.DirectoryServices.DirectorySearcher directorySearcher1;
        private System.Windows.Forms.TextBox g_name;
        private System.Windows.Forms.Button g_add_btn;
        private System.Windows.Forms.Button t_update_btn;
        private System.Windows.Forms.Button t_delete_btn;
        private System.Windows.Forms.ComboBox g_type;
        private System.Windows.Forms.ComboBox g_teacher;
        private System.Windows.Forms.ComboBox g_mentor;
        private System.Windows.Forms.DataGridView dataGridGroup;
        private System.Windows.Forms.DateTimePicker g_start_data;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.Button export_group_btn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}