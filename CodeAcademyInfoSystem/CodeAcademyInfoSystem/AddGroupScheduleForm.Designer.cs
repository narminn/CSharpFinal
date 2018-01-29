namespace CodeAcademyInfoSystem
{
    partial class AddGroupScheduleForm
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
            this.grp_sch_name = new System.Windows.Forms.TextBox();
            this.sch_start = new System.Windows.Forms.DateTimePicker();
            this.sch_end = new System.Windows.Forms.DateTimePicker();
            this.sch_add = new System.Windows.Forms.Button();
            this.dataGridGrpSch = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sch_upd = new System.Windows.Forms.Button();
            this.exp_grp_sch_btn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridGrpSch)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(17, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Group Schedule Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(17, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Start Time";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(18, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "End time";
            // 
            // grp_sch_name
            // 
            this.grp_sch_name.Location = new System.Drawing.Point(211, 55);
            this.grp_sch_name.Name = "grp_sch_name";
            this.grp_sch_name.Size = new System.Drawing.Size(160, 20);
            this.grp_sch_name.TabIndex = 3;
            // 
            // sch_start
            // 
            this.sch_start.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.sch_start.Location = new System.Drawing.Point(211, 117);
            this.sch_start.Name = "sch_start";
            this.sch_start.Size = new System.Drawing.Size(160, 20);
            this.sch_start.TabIndex = 4;
            // 
            // sch_end
            // 
            this.sch_end.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.sch_end.Location = new System.Drawing.Point(211, 179);
            this.sch_end.Name = "sch_end";
            this.sch_end.Size = new System.Drawing.Size(160, 20);
            this.sch_end.TabIndex = 5;
            // 
            // sch_add
            // 
            this.sch_add.BackColor = System.Drawing.Color.Silver;
            this.sch_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sch_add.Location = new System.Drawing.Point(12, 253);
            this.sch_add.Name = "sch_add";
            this.sch_add.Size = new System.Drawing.Size(100, 27);
            this.sch_add.TabIndex = 6;
            this.sch_add.Text = "Add";
            this.sch_add.UseVisualStyleBackColor = false;
            this.sch_add.Click += new System.EventHandler(this.sch_add_Click);
            // 
            // dataGridGrpSch
            // 
            this.dataGridGrpSch.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridGrpSch.BackgroundColor = System.Drawing.Color.Silver;
            this.dataGridGrpSch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridGrpSch.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dataGridGrpSch.Location = new System.Drawing.Point(12, 315);
            this.dataGridGrpSch.Name = "dataGridGrpSch";
            this.dataGridGrpSch.Size = new System.Drawing.Size(493, 162);
            this.dataGridGrpSch.TabIndex = 7;
            this.dataGridGrpSch.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.select_grpsch);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Id";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Group Schedule Name";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Start Time";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "End Time";
            this.Column4.Name = "Column4";
            // 
            // sch_upd
            // 
            this.sch_upd.BackColor = System.Drawing.Color.Silver;
            this.sch_upd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sch_upd.Location = new System.Drawing.Point(211, 253);
            this.sch_upd.Name = "sch_upd";
            this.sch_upd.Size = new System.Drawing.Size(100, 27);
            this.sch_upd.TabIndex = 8;
            this.sch_upd.Text = "Update";
            this.sch_upd.UseVisualStyleBackColor = false;
            this.sch_upd.Click += new System.EventHandler(this.sch_upd_Click);
            // 
            // exp_grp_sch_btn
            // 
            this.exp_grp_sch_btn.BackColor = System.Drawing.Color.Silver;
            this.exp_grp_sch_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exp_grp_sch_btn.Location = new System.Drawing.Point(405, 253);
            this.exp_grp_sch_btn.Name = "exp_grp_sch_btn";
            this.exp_grp_sch_btn.Size = new System.Drawing.Size(100, 27);
            this.exp_grp_sch_btn.TabIndex = 9;
            this.exp_grp_sch_btn.Text = "Export";
            this.exp_grp_sch_btn.UseVisualStyleBackColor = false;
            this.exp_grp_sch_btn.Click += new System.EventHandler(this.exp_grp_sch_btn_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightSlateGray;
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(517, 28);
            this.panel2.TabIndex = 50;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Tomato;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(482, 0);
            this.label7.Name = "label7";
            this.label7.Padding = new System.Windows.Forms.Padding(7, 4, 7, 4);
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label7.Size = new System.Drawing.Size(35, 28);
            this.label7.TabIndex = 51;
            this.label7.Text = "X";
            this.label7.Click += new System.EventHandler(this.label7_Click);
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
            // AddGroupScheduleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CodeAcademyInfoSystem.Properties.Resources.background_988582_960_720;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(517, 501);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.exp_grp_sch_btn);
            this.Controls.Add(this.sch_upd);
            this.Controls.Add(this.dataGridGrpSch);
            this.Controls.Add(this.sch_add);
            this.Controls.Add(this.sch_end);
            this.Controls.Add(this.sch_start);
            this.Controls.Add(this.grp_sch_name);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddGroupScheduleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddGroupScheduleForm";
            this.Load += new System.EventHandler(this.AddGroupScheduleForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridGrpSch)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox grp_sch_name;
        private System.Windows.Forms.DateTimePicker sch_start;
        private System.Windows.Forms.DateTimePicker sch_end;
        private System.Windows.Forms.Button sch_add;
        private System.Windows.Forms.DataGridView dataGridGrpSch;
        private System.Windows.Forms.Button sch_upd;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Button exp_grp_sch_btn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}