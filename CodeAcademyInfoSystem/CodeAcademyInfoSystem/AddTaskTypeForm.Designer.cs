namespace CodeAcademyInfoSystem
{
    partial class AddTaskTypeForm
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
            this.tsk_type = new System.Windows.Forms.TextBox();
            this.tsk_typ_rate = new System.Windows.Forms.TextBox();
            this.add_tsktype_btn = new System.Windows.Forms.Button();
            this.upd_tsktype_btn = new System.Windows.Forms.Button();
            this.dataGridTaskType = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.export_Tsktyp_btn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTaskType)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(32, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Task Type Name ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(32, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Task Type Rate";
            // 
            // tsk_type
            // 
            this.tsk_type.Location = new System.Drawing.Point(193, 60);
            this.tsk_type.Name = "tsk_type";
            this.tsk_type.Size = new System.Drawing.Size(130, 20);
            this.tsk_type.TabIndex = 2;
            // 
            // tsk_typ_rate
            // 
            this.tsk_typ_rate.Location = new System.Drawing.Point(193, 132);
            this.tsk_typ_rate.Name = "tsk_typ_rate";
            this.tsk_typ_rate.Size = new System.Drawing.Size(130, 20);
            this.tsk_typ_rate.TabIndex = 3;
            // 
            // add_tsktype_btn
            // 
            this.add_tsktype_btn.Location = new System.Drawing.Point(21, 212);
            this.add_tsktype_btn.Name = "add_tsktype_btn";
            this.add_tsktype_btn.Size = new System.Drawing.Size(110, 30);
            this.add_tsktype_btn.TabIndex = 4;
            this.add_tsktype_btn.Text = "Add";
            this.add_tsktype_btn.UseVisualStyleBackColor = true;
            this.add_tsktype_btn.Click += new System.EventHandler(this.add_tsktype_btn_Click);
            // 
            // upd_tsktype_btn
            // 
            this.upd_tsktype_btn.Location = new System.Drawing.Point(154, 212);
            this.upd_tsktype_btn.Name = "upd_tsktype_btn";
            this.upd_tsktype_btn.Size = new System.Drawing.Size(110, 30);
            this.upd_tsktype_btn.TabIndex = 5;
            this.upd_tsktype_btn.Text = "Update";
            this.upd_tsktype_btn.UseVisualStyleBackColor = true;
            this.upd_tsktype_btn.Click += new System.EventHandler(this.upd_tsktype_btn_Click);
            // 
            // dataGridTaskType
            // 
            this.dataGridTaskType.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridTaskType.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridTaskType.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dataGridTaskType.Location = new System.Drawing.Point(21, 267);
            this.dataGridTaskType.Name = "dataGridTaskType";
            this.dataGridTaskType.Size = new System.Drawing.Size(375, 129);
            this.dataGridTaskType.TabIndex = 6;
            this.dataGridTaskType.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.select_task_type);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Id";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Task Type Name";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Task Type Rate";
            this.Column3.Name = "Column3";
            // 
            // export_Tsktyp_btn
            // 
            this.export_Tsktyp_btn.Location = new System.Drawing.Point(286, 212);
            this.export_Tsktyp_btn.Name = "export_Tsktyp_btn";
            this.export_Tsktyp_btn.Size = new System.Drawing.Size(110, 30);
            this.export_Tsktyp_btn.TabIndex = 7;
            this.export_Tsktyp_btn.Text = "Export";
            this.export_Tsktyp_btn.UseVisualStyleBackColor = true;
            this.export_Tsktyp_btn.Click += new System.EventHandler(this.export_Tsktyp_btn_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightSlateGray;
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panel2.Location = new System.Drawing.Point(3, -1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(410, 28);
            this.panel2.TabIndex = 52;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Tomato;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(372, 0);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(7, 4, 7, 4);
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label4.Size = new System.Drawing.Size(35, 28);
            this.label4.TabIndex = 53;
            this.label4.Text = "X";
            this.label4.Click += new System.EventHandler(this.label4_Click);
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
            // AddTaskTypeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CodeAcademyInfoSystem.Properties.Resources.background_988582_960_7202;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(408, 423);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.export_Tsktyp_btn);
            this.Controls.Add(this.dataGridTaskType);
            this.Controls.Add(this.upd_tsktype_btn);
            this.Controls.Add(this.add_tsktype_btn);
            this.Controls.Add(this.tsk_typ_rate);
            this.Controls.Add(this.tsk_type);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddTaskTypeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddTaskTypeForm";
            this.Load += new System.EventHandler(this.AddTaskTypeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTaskType)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tsk_type;
        private System.Windows.Forms.TextBox tsk_typ_rate;
        private System.Windows.Forms.Button add_tsktype_btn;
        private System.Windows.Forms.Button upd_tsktype_btn;
        private System.Windows.Forms.DataGridView dataGridTaskType;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Button export_Tsktyp_btn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
    }
}