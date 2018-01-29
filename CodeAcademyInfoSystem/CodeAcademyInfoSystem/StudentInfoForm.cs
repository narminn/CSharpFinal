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
    public partial class StudentInfoForm : Form
    {
        CodeAcademy_DBEntities db = new CodeAcademy_DBEntities();
        public int id;
        private Student selectedStdnt;
        public StudentInfoForm()
        {
            InitializeComponent();
        }

        private void tasks_Click(object sender, EventArgs e)
        {
            TaskPointsForm tskpnt = new TaskPointsForm(id);
            tskpnt.dataGridTaskPnt.Rows.Clear();
            int i = 0;
            List<Task> tsk_list = db.Tasks.Where(s=>s.task_student_id==id).ToList();
            foreach (Task selectedTask in tsk_list)
            {
                tskpnt.dataGridTaskPnt.Rows.Add();
                tskpnt.dataGridTaskPnt.Rows[i].Cells[0].Value = selectedTask.id;
                tskpnt.dataGridTaskPnt.Rows[i].Cells[1].Value = selectedTask.Task_types.task_type_name;
                tskpnt.dataGridTaskPnt.Rows[i].Cells[2].Value = selectedTask.task_start_date.ToShortDateString();
                tskpnt.dataGridTaskPnt.Rows[i].Cells[3].Value = selectedTask.task_end_date.ToShortDateString();
                tskpnt.dataGridTaskPnt.Rows[i].Cells[4].Value = selectedTask.task_source;
                tskpnt.dataGridTaskPnt.Rows[i].Cells[5].Value = selectedTask.task_point;
                tskpnt.dataGridTaskPnt.Rows[i].Cells[6].Value = selectedTask.task_note;
                tskpnt.dataGridTaskPnt.Rows[i].Cells[7].Value = selectedTask.task_point * selectedTask.Task_types.task_type_rate;
                
               i++;

            }

            




                tskpnt.ShowDialog();
            
        }

        private void label16_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void change_pswrd_Click(object sender, EventArgs e)
        {
            panelPassword.Visible = true;
        }

        private void chng_pswr_btn_Click(object sender, EventArgs e)
        {
            int stdId = db.Students.Where(d => d.student_name ==label_s_name.Text).First().id;
            selectedStdnt = db.Students.Find(stdId);
            if (old_password.Text == selectedStdnt.student_password)
            {
                selectedStdnt.student_password = new_password.Text;
                db.SaveChanges();
            }
            else
            {
                wrong_psw.Visible = true;
            }
        }
    }
}
