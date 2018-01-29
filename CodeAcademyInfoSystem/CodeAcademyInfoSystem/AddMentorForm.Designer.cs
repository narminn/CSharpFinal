namespace CodeAcademyInfoSystem
{
    partial class AddMentorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddMentorForm));
            this.browse_m = new System.Windows.Forms.Label();
            this.m_update_btn = new System.Windows.Forms.Button();
            this.m_delete_btn = new System.Windows.Forms.Button();
            this.m_add_btn = new System.Windows.Forms.Button();
            this.m_show_btn = new System.Windows.Forms.Button();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridMentor = new System.Windows.Forms.DataGridView();
            this.m_password = new System.Windows.Forms.TextBox();
            this.m_phone = new System.Windows.Forms.TextBox();
            this.m_email = new System.Windows.Forms.TextBox();
            this.m_surname = new System.Windows.Forms.TextBox();
            this.m_info = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.m_gender = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.m_name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.export_Mentor_btn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMentor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // browse_m
            // 
            this.browse_m.AutoSize = true;
            this.browse_m.BackColor = System.Drawing.Color.Transparent;
            this.browse_m.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.browse_m.ForeColor = System.Drawing.SystemColors.Highlight;
            this.browse_m.Location = new System.Drawing.Point(731, 208);
            this.browse_m.Name = "browse_m";
            this.browse_m.Size = new System.Drawing.Size(62, 16);
            this.browse_m.TabIndex = 50;
            this.browse_m.Text = "Browse...";
            this.browse_m.Click += new System.EventHandler(this.browse_m_Click);
            // 
            // m_update_btn
            // 
            this.m_update_btn.BackColor = System.Drawing.Color.PeachPuff;
            this.m_update_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.m_update_btn.Location = new System.Drawing.Point(662, 259);
            this.m_update_btn.Name = "m_update_btn";
            this.m_update_btn.Size = new System.Drawing.Size(100, 27);
            this.m_update_btn.TabIndex = 48;
            this.m_update_btn.Text = "Update";
            this.m_update_btn.UseVisualStyleBackColor = false;
            this.m_update_btn.Click += new System.EventHandler(this.m_update_btn_Click);
            // 
            // m_delete_btn
            // 
            this.m_delete_btn.BackColor = System.Drawing.Color.PeachPuff;
            this.m_delete_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.m_delete_btn.Location = new System.Drawing.Point(788, 259);
            this.m_delete_btn.Name = "m_delete_btn";
            this.m_delete_btn.Size = new System.Drawing.Size(100, 27);
            this.m_delete_btn.TabIndex = 47;
            this.m_delete_btn.Text = "Delete";
            this.m_delete_btn.UseVisualStyleBackColor = false;
            this.m_delete_btn.Click += new System.EventHandler(this.m_delete_btn_Click);
            // 
            // m_add_btn
            // 
            this.m_add_btn.BackColor = System.Drawing.Color.PeachPuff;
            this.m_add_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.m_add_btn.Location = new System.Drawing.Point(402, 259);
            this.m_add_btn.Name = "m_add_btn";
            this.m_add_btn.Size = new System.Drawing.Size(100, 27);
            this.m_add_btn.TabIndex = 46;
            this.m_add_btn.Text = "Add";
            this.m_add_btn.UseVisualStyleBackColor = false;
            this.m_add_btn.Click += new System.EventHandler(this.m_add_btn_Click);
            // 
            // m_show_btn
            // 
            this.m_show_btn.BackColor = System.Drawing.Color.PeachPuff;
            this.m_show_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.m_show_btn.Location = new System.Drawing.Point(529, 259);
            this.m_show_btn.Name = "m_show_btn";
            this.m_show_btn.Size = new System.Drawing.Size(100, 27);
            this.m_show_btn.TabIndex = 45;
            this.m_show_btn.Text = "Profile";
            this.m_show_btn.UseVisualStyleBackColor = false;
            this.m_show_btn.Click += new System.EventHandler(this.m_show_btn_Click);
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Info";
            this.Column6.Name = "Column6";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Email";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Phone";
            this.Column5.Name = "Column5";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Gender";
            this.Column7.Name = "Column7";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Surname";
            this.Column3.Name = "Column3";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Name";
            this.Column2.Name = "Column2";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Id";
            this.Column1.Name = "Column1";
            // 
            // dataGridMentor
            // 
            this.dataGridMentor.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridMentor.BackgroundColor = System.Drawing.Color.PeachPuff;
            this.dataGridMentor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridMentor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column7,
            this.Column5,
            this.Column4,
            this.Column6});
            this.dataGridMentor.Location = new System.Drawing.Point(24, 316);
            this.dataGridMentor.Name = "dataGridMentor";
            this.dataGridMentor.Size = new System.Drawing.Size(864, 221);
            this.dataGridMentor.TabIndex = 44;
            this.dataGridMentor.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.select_mentor);
            // 
            // m_password
            // 
            this.m_password.Location = new System.Drawing.Point(472, 165);
            this.m_password.Multiline = true;
            this.m_password.Name = "m_password";
            this.m_password.Size = new System.Drawing.Size(213, 27);
            this.m_password.TabIndex = 43;
            // 
            // m_phone
            // 
            this.m_phone.Location = new System.Drawing.Point(472, 56);
            this.m_phone.Multiline = true;
            this.m_phone.Name = "m_phone";
            this.m_phone.Size = new System.Drawing.Size(213, 27);
            this.m_phone.TabIndex = 42;
            // 
            // m_email
            // 
            this.m_email.Location = new System.Drawing.Point(472, 110);
            this.m_email.Multiline = true;
            this.m_email.Name = "m_email";
            this.m_email.Size = new System.Drawing.Size(213, 27);
            this.m_email.TabIndex = 41;
            // 
            // m_surname
            // 
            this.m_surname.Location = new System.Drawing.Point(109, 110);
            this.m_surname.Multiline = true;
            this.m_surname.Name = "m_surname";
            this.m_surname.Size = new System.Drawing.Size(211, 27);
            this.m_surname.TabIndex = 40;
            // 
            // m_info
            // 
            this.m_info.Location = new System.Drawing.Point(107, 220);
            this.m_info.Multiline = true;
            this.m_info.Name = "m_info";
            this.m_info.Size = new System.Drawing.Size(270, 66);
            this.m_info.TabIndex = 39;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(20, 243);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 20);
            this.label7.TabIndex = 38;
            this.label7.Text = "Info";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(377, 172);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 20);
            this.label6.TabIndex = 37;
            this.label6.Text = "Password";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(377, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 20);
            this.label5.TabIndex = 36;
            this.label5.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(377, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 20);
            this.label4.TabIndex = 35;
            this.label4.Text = "Phone";
            // 
            // m_gender
            // 
            this.m_gender.FormattingEnabled = true;
            this.m_gender.Location = new System.Drawing.Point(107, 174);
            this.m_gender.Name = "m_gender";
            this.m_gender.Size = new System.Drawing.Size(176, 21);
            this.m_gender.TabIndex = 34;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(20, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 20);
            this.label3.TabIndex = 33;
            this.label3.Text = "Gender";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(20, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 20);
            this.label2.TabIndex = 32;
            this.label2.Text = "Surname";
            // 
            // m_name
            // 
            this.m_name.Location = new System.Drawing.Point(107, 56);
            this.m_name.Multiline = true;
            this.m_name.Name = "m_name";
            this.m_name.Size = new System.Drawing.Size(213, 27);
            this.m_name.TabIndex = 31;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(20, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 20);
            this.label1.TabIndex = 30;
            this.label1.Text = "Name";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::CodeAcademyInfoSystem.Properties.Resources.user;
            this.pictureBox2.Location = new System.Drawing.Point(734, 50);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(145, 145);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 49;
            this.pictureBox2.TabStop = false;
            // 
            // export_Mentor_btn
            // 
            this.export_Mentor_btn.BackColor = System.Drawing.Color.PeachPuff;
            this.export_Mentor_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.export_Mentor_btn.Location = new System.Drawing.Point(788, 561);
            this.export_Mentor_btn.Name = "export_Mentor_btn";
            this.export_Mentor_btn.Size = new System.Drawing.Size(100, 27);
            this.export_Mentor_btn.TabIndex = 51;
            this.export_Mentor_btn.Text = "Export";
            this.export_Mentor_btn.UseVisualStyleBackColor = false;
            this.export_Mentor_btn.Click += new System.EventHandler(this.export_Mentor_btn_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightSlateGray;
            this.panel2.Controls.Add(this.label8);
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panel2.Location = new System.Drawing.Point(1, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(901, 34);
            this.panel2.TabIndex = 52;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Tomato;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(854, -1);
            this.label8.Name = "label8";
            this.label8.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.label8.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label8.Size = new System.Drawing.Size(45, 34);
            this.label8.TabIndex = 4;
            this.label8.Text = "X";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // AddMentorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(900, 600);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.export_Mentor_btn);
            this.Controls.Add(this.browse_m);
            this.Controls.Add(this.m_update_btn);
            this.Controls.Add(this.m_delete_btn);
            this.Controls.Add(this.m_add_btn);
            this.Controls.Add(this.m_show_btn);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.dataGridMentor);
            this.Controls.Add(this.m_password);
            this.Controls.Add(this.m_phone);
            this.Controls.Add(this.m_email);
            this.Controls.Add(this.m_surname);
            this.Controls.Add(this.m_info);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.m_gender);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.m_name);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddMentorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddMentorForm";
            this.Load += new System.EventHandler(this.AddMentorForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMentor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label browse_m;
        private System.Windows.Forms.Button m_update_btn;
        private System.Windows.Forms.Button m_delete_btn;
        private System.Windows.Forms.Button m_add_btn;
        private System.Windows.Forms.Button m_show_btn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.DataGridView dataGridMentor;
        private System.Windows.Forms.TextBox m_password;
        private System.Windows.Forms.TextBox m_phone;
        private System.Windows.Forms.TextBox m_email;
        private System.Windows.Forms.TextBox m_surname;
        private System.Windows.Forms.TextBox m_info;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox m_gender;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox m_name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button export_Mentor_btn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label8;
    }
}