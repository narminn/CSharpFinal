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
    public partial class TaskPointsForm : Form
    {
        CodeAcademy_DBEntities db = new CodeAcademy_DBEntities();
        Student student;
        public TaskPointsForm(int id )
        {
            InitializeComponent();
            student = db.Students.Find(id);

        }

        private void TaskPointsForm_Load(object sender, EventArgs e)
        {
            //double sum_a = 0, sum_p = 0, sum_f = 0, sum_c = 0, sum_d = 0, sum_m = 0, sum_z = 0,  sum_v=0;

            //int count_a = 0, count_p = 0, count_f = 0, count_c = 0, count_d = 0, count_m = 0, count_z = 0, count_v=0;


            //for (int i = 0; i < dataGridTaskPnt.Rows.Count; ++i)
            //{
            //    if (Convert.ToString(dataGridTaskPnt.Rows[i].Cells[1].Value) == "Arasdirma")
            //    {
            //        sum_a += Convert.ToInt32(dataGridTaskPnt.Rows[i].Cells[7].Value);
            //        count_a++;
            //    }
            //    if (Convert.ToString(dataGridTaskPnt.Rows[i].Cells[1].Value) == "Praktiki")
            //    {
            //        sum_p += Convert.ToInt32(dataGridTaskPnt.Rows[i].Cells[7].Value);
            //        count_p++;
            //    }
            //    if (Convert.ToString(dataGridTaskPnt.Rows[i].Cells[1].Value) == "Front end sonu layihe")
            //    {
            //        sum_f += Convert.ToInt32(dataGridTaskPnt.Rows[i].Cells[7].Value);
            //        count_f++;
            //    }
            //    if (Convert.ToString(dataGridTaskPnt.Rows[i].Cells[1].Value) == "c# sonu layihe")
            //    {
            //        sum_c += Convert.ToInt32(dataGridTaskPnt.Rows[i].Cells[7].Value);
            //        count_c++;
            //    }
            //    if (Convert.ToString(dataGridTaskPnt.Rows[i].Cells[1].Value) == ".net sonu layihe")
            //    {
            //        sum_d += Convert.ToInt32(dataGridTaskPnt.Rows[i].Cells[7].Value);
            //        count_d++;
            //    }
            //    if (Convert.ToString(dataGridTaskPnt.Rows[i].Cells[1].Value) == "MTI layihe")
            //    {
            //        sum_m += Convert.ToInt32(dataGridTaskPnt.Rows[i].Cells[7].Value);
            //        count_m++;
            //    }
            //    if (Convert.ToString(dataGridTaskPnt.Rows[i].Cells[1].Value) == "Mezuniyyet layihesi")
            //    {
            //        sum_z += Convert.ToInt32(dataGridTaskPnt.Rows[i].Cells[7].Value);
            //        count_z++;
            //    }
            //    if (Convert.ToString(dataGridTaskPnt.Rows[i].Cells[1].Value) == "Davamiyyet")
            //    {
            //        sum_v += Convert.ToInt32(dataGridTaskPnt.Rows[i].Cells[7].Value);
            //        count_v++;
            //    }


            //    //MessageBox.Show(db.Task_types.);
            //    //List<Task> task_Arashdirma = db.Tasks.Where(t => t.task_type_id)




            //}

            //double avg_a = sum_a / count_a;
            //double avg_p = sum_p / count_p;
            //double avg_f = sum_f / count_f;
            //double avg_c = sum_c / count_c;
            //double avg_d = sum_d / count_d;
            //double avg_m = sum_m / count_m;
            //double avg_z = sum_z / count_z;
            //double avg_v = sum_v / count_v;
            //double avg = avg_a + avg_p + avg_f+avg_c+avg_d+avg_m+avg_z+avg_v;
            //total.Text = avg.ToString();
            //cap_pnt.Text = (avg * 0.05).ToString();


            List<int> task_types = new List<int>();
            List<Task> tasks = db.Tasks.Where(t => t.task_student_id == this.student.id).ToList();


            foreach (Task item in tasks)
            {
                if (!task_types.Contains(item.task_type_id))
                {
                    task_types.Add(item.task_type_id);
                }
            }


            int count = 0;
            double sum = 0;
            double cap_point = 0;
            double rate = 0;
            double average = 0;
            foreach (int item in task_types)
            {
                count = tasks.Where(t => t.task_type_id == item).Count();
                sum = tasks.Where(t => t.task_type_id == item).Select(t => t.task_point).Sum();
                rate = db.Task_types.First(t => t.id == item).task_type_rate;
                average += (sum / count) * rate;
                cap_point = average*0.05;
            }

            this.total.Text = Math.Round(average,2).ToString();
            
            this.cap_pnt.Text = Math.Round(cap_point,2).ToString();

            student.student_cap_point= cap_point;
            db.SaveChanges();
        }

        private void export_tsk_pnt_btn_Click(object sender, EventArgs e)
        {
            TaskForm tskf = new TaskForm();
            tskf.exportExcel(dataGridTaskPnt);
        }

        private void label16_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
    }
}
