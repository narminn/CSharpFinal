namespace CodeAcademyInfoSystem
{
    partial class AddGroupTypeForm
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.g_type = new System.Windows.Forms.TextBox();
            this.g_schedule = new System.Windows.Forms.ComboBox();
            this.add_gtype_btn = new System.Windows.Forms.Button();
            this.dataGridGrpType = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codeAcademy_DBDataSet = new CodeAcademyInfoSystem.CodeAcademy_DBDataSet();
            this.codeAcademyDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.upd_grptype_btn = new System.Windows.Forms.Button();
            this.export_Grptype = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridGrpType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.codeAcademy_DBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.codeAcademyDBDataSetBindingSource)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(23, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Group Type Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(23, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Group Schedule";
            // 
            // g_type
            // 
            this.g_type.Location = new System.Drawing.Point(203, 75);
            this.g_type.Name = "g_type";
            this.g_type.Size = new System.Drawing.Size(121, 20);
            this.g_type.TabIndex = 2;
            // 
            // g_schedule
            // 
            this.g_schedule.FormattingEnabled = true;
            this.g_schedule.Location = new System.Drawing.Point(203, 133);
            this.g_schedule.Name = "g_schedule";
            this.g_schedule.Size = new System.Drawing.Size(121, 21);
            this.g_schedule.TabIndex = 3;
            // 
            // add_gtype_btn
            // 
            this.add_gtype_btn.BackColor = System.Drawing.Color.Silver;
            this.add_gtype_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_gtype_btn.Location = new System.Drawing.Point(12, 207);
            this.add_gtype_btn.Name = "add_gtype_btn";
            this.add_gtype_btn.Size = new System.Drawing.Size(100, 27);
            this.add_gtype_btn.TabIndex = 4;
            this.add_gtype_btn.Text = "Add";
            this.add_gtype_btn.UseVisualStyleBackColor = false;
            this.add_gtype_btn.Click += new System.EventHandler(this.add_gtype_btn_Click);
            // 
            // dataGridGrpType
            // 
            this.dataGridGrpType.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridGrpType.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridGrpType.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dataGridGrpType.Location = new System.Drawing.Point(12, 257);
            this.dataGridGrpType.Name = "dataGridGrpType";
            this.dataGridGrpType.Size = new System.Drawing.Size(421, 150);
            this.dataGridGrpType.TabIndex = 5;
            this.dataGridGrpType.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.select_grptype);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Id";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Group Type Name";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Group Schedule";
            this.Column3.Name = "Column3";
            // 
            // codeAcademy_DBDataSet
            // 
            this.codeAcademy_DBDataSet.DataSetName = "CodeAcademy_DBDataSet";
            this.codeAcademy_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // codeAcademyDBDataSetBindingSource
            // 
            this.codeAcademyDBDataSetBindingSource.DataSource = this.codeAcademy_DBDataSet;
            this.codeAcademyDBDataSetBindingSource.Position = 0;
            // 
            // upd_grptype_btn
            // 
            this.upd_grptype_btn.BackColor = System.Drawing.Color.Silver;
            this.upd_grptype_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.upd_grptype_btn.Location = new System.Drawing.Point(170, 207);
            this.upd_grptype_btn.Name = "upd_grptype_btn";
            this.upd_grptype_btn.Size = new System.Drawing.Size(100, 27);
            this.upd_grptype_btn.TabIndex = 6;
            this.upd_grptype_btn.Text = "Update";
            this.upd_grptype_btn.UseVisualStyleBackColor = false;
            this.upd_grptype_btn.Click += new System.EventHandler(this.upd_grptype_btn_Click);
            // 
            // export_Grptype
            // 
            this.export_Grptype.BackColor = System.Drawing.Color.Silver;
            this.export_Grptype.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.export_Grptype.Location = new System.Drawing.Point(334, 207);
            this.export_Grptype.Name = "export_Grptype";
            this.export_Grptype.Size = new System.Drawing.Size(100, 27);
            this.export_Grptype.TabIndex = 7;
            this.export_Grptype.Text = "Export";
            this.export_Grptype.UseVisualStyleBackColor = false;
            this.export_Grptype.Click += new System.EventHandler(this.export_Grptype_Click);
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
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightSlateGray;
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(447, 28);
            this.panel2.TabIndex = 51;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Tomato;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(412, 0);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(7, 4, 7, 4);
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label3.Size = new System.Drawing.Size(35, 28);
            this.label3.TabIndex = 52;
            this.label3.Text = "X";
            this.label3.Click += new System.EventHandler(this.label3_Click);
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
            // AddGroupTypeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CodeAcademyInfoSystem.Properties.Resources.background_988582_960_7201;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(446, 419);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.export_Grptype);
            this.Controls.Add(this.upd_grptype_btn);
            this.Controls.Add(this.dataGridGrpType);
            this.Controls.Add(this.add_gtype_btn);
            this.Controls.Add(this.g_schedule);
            this.Controls.Add(this.g_type);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddGroupTypeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddGroupTypeForm";
            this.Load += new System.EventHandler(this.AddGroupTypeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridGrpType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.codeAcademy_DBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.codeAcademyDBDataSetBindingSource)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox g_type;
        private System.Windows.Forms.ComboBox g_schedule;
        private System.Windows.Forms.Button add_gtype_btn;
        private System.Windows.Forms.DataGridView dataGridGrpType;
        private System.Windows.Forms.BindingSource codeAcademyDBDataSetBindingSource;
        private CodeAcademy_DBDataSet codeAcademy_DBDataSet;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Button upd_grptype_btn;
        private System.Windows.Forms.Button export_Grptype;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
    }
}