using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodeAcademyInfoSystem
{
    public partial class AddGroupScheduleForm : Form
    {
        CodeAcademy_DBEntities db = new CodeAcademy_DBEntities();
        private Group_schedule selectedGrpSch;
        public AddGroupScheduleForm()
        {
            InitializeComponent();
        }

        private void AddGroupScheduleForm_Load(object sender, EventArgs e)
        {
            fillDataGrpSch();
        }

        private void sch_add_Click(object sender, EventArgs e)
        {
            Group_schedule grp_sch = new Group_schedule();
            grp_sch.group_schedule_name = grp_sch_name.Text;
            grp_sch.group_begin_time = sch_start.Value;
            grp_sch.group_end_time = sch_end.Value;
            db.Group_schedule.Add(grp_sch);
            db.SaveChanges();
            fillDataGrpSch();
        }
        private void fillDataGrpSch()
        {
            dataGridGrpSch.Rows.Clear();
            int i = 0;
            List<Group_schedule> grpsch_list = db.Group_schedule.ToList();
            foreach (Group_schedule item in grpsch_list)
            {
                dataGridGrpSch.Rows.Add();
                dataGridGrpSch.Rows[i].Cells[0].Value = item.id;
                dataGridGrpSch.Rows[i].Cells[1].Value = item.group_schedule_name;
                dataGridGrpSch.Rows[i].Cells[2].Value = item.group_begin_time.ToShortTimeString();
                dataGridGrpSch.Rows[i].Cells[3].Value = item.group_end_time.ToShortTimeString();
                i++;
            }
        }

        

        private void select_grpsch(object sender, DataGridViewCellMouseEventArgs e)
        {
            int id = Convert.ToInt32(dataGridGrpSch.Rows[e.RowIndex].Cells[0].Value);
            selectedGrpSch = db.Group_schedule.Find(id);
            grp_sch_name.Text = selectedGrpSch.group_schedule_name;
            sch_start.Value = selectedGrpSch.group_begin_time;
            sch_end.Value = selectedGrpSch.group_end_time;
        }
        private void sch_upd_Click(object sender, EventArgs e)
        {
            
            selectedGrpSch.group_schedule_name = grp_sch_name.Text;
            selectedGrpSch.group_begin_time = sch_start.Value;
            selectedGrpSch.group_end_time = sch_end.Value;
            
            db.SaveChanges();
            fillDataGrpSch();
        }

        private void exp_grp_sch_btn_Click(object sender, EventArgs e)
        {
            TaskForm tskf = new TaskForm();
            tskf.exportExcel(dataGridGrpSch);

        }

        private void label7_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
